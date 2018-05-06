Imports MySql.Data.MySqlClient
Public Class frmCategorias
    '/////////////////////////////////////////////////////
    'BOTÓN GUARDAR. GUARDA LA INFORMACIÓN EN LA BD
    '/////////////////////////////////////////////////////
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobar_datos() And comprobar_existe() Then
            insertar_datos()
            actualizarDataGridView()
        End If
    End Sub

    '//////////////////////////////////////////////////////
    'COMPROBACION DE LA ENTRADA DE DATOS
    '//////////////////////////////////////////////////////
    Private Function comprobar_datos()
        If IsNumeric(txtNombre.Text) Or txtNombre.Text = "" Then
            mostrar_error.SetError(Me.txtNombre, "TIENE QUE INTRODUCIR POR LO MENOS UN CARACTER ALFABÉTICO")
            Return False
        End If
        mostrar_error.Clear()
        Return True
    End Function

    '/////////////////////////////////////////////////////
    'FUNCIÓN QUE INSERTA LOS DATOS 
    '/////////////////////////////////////////////////////
    Private Sub insertar_datos()
        Try
            conn.Open()
            Dim Query As String
            Query = "insert into Categorias(Nombre,Promocion,Descuento) values ('" & txtNombre.Text & "',false,0)"
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader
            MessageBox.Show("Categoría creada")
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        READER.Close()
        conn.Close()
    End Sub

    '/////////////////////////////////////////////////////
    'COMPRUEBA SI LA CATEGORÍA YA EXISTE
    '/////////////////////////////////////////////////////
    Private Function comprobar_existe()
        Dim Query As String
        Query = "SELECT * FROM Categorias WHERE Nombre='" & txtNombre.Text & "'"
        Try
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()
            If READER.Read = Nothing Then
                READER.Close()
                conn.Close()
                mostrar_error.SetError(Me.txtNombre, "")
                Return True
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            Return False
        End Try
        READER.Close()
        conn.Close()
        mostrar_error.SetError(Me.txtNombre, "LA CATEGORÍA YA EXISTE")
        Return False
    End Function

    '/////////////////////////////////////////////////////
    'MÉTODO PARA ACTUALIZAR EL DATA GRID VIEW
    '/////////////////////////////////////////////////////
    Private Sub actualizarDataGridView()
        Dim Query As String
        Query = "SELECT * FROM Categorias"
        Try
            conn.Close()
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()
            'Creamos un DataTable y le pasamos la consulta 
            Dim dt = New DataTable()
            dt.Load(READER)
            'Cargamos el DataTable en el GridDataView
            dgvShow.AutoGenerateColumns = True
            dgvShow.DataSource = dt
            dgvShow.Refresh()
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    '/////////////////////////////////////////////////////
    'MÉTODO QUE PRECARGA TODO LO NECESARIO
    '/////////////////////////////////////////////////////
    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles Me.Load
        actualizarDataGridView()
    End Sub

    '/////////////////////////////////////////////////////
    'BOTÓN EDITAR
    '/////////////////////////////////////////////////////
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        cargarCategorias()
    End Sub

    Private Sub cargarCategorias()
        If dgvShow.SelectedRows.Count > 0 Then
            txtNombre.Text = dgvShow.CurrentRow.Cells.Item(1).Value.ToString
        End If
    End Sub

    '/////////////////////////////////////////////////////
    'BOTÓN ELIMINAR
    '/////////////////////////////////////////////////////
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        borrarEnPedidos()
        If borrarEnCategoria() Then
            actualizarDataGridView()
            MsgBox("Categoria Borrado")
        End If
    End Sub

    Private Function borrarEnCategoria()
        Try
            conn.Open()
            Dim Query As String
            Query = "delete from Categorias where id_categoria = ?id"
            Command = New MySqlCommand(Query, conn)
            Command.Parameters.AddWithValue("?id", dgvShow.CurrentRow.Cells.Item(0).Value)
            READER = Command.ExecuteReader
            Return True
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        Catch e As System.NullReferenceException
            MsgBox("No hay una fila seleccionada")
        End Try
        READER.Close()
        conn.Close()
        Return False
    End Function

    Private Sub borrarEnPedidos()
        Try
            conn.Open()
            Dim Query As String
            Query = "delete from productos where categoria = ?id"
            Command = New MySqlCommand(Query, conn)
            Command.Parameters.AddWithValue("?id", dgvShow.CurrentRow.Cells.Item(0).Value)
            READER = Command.ExecuteReader
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        Catch e As System.NullReferenceException

        End Try
        READER.Close()
        conn.Close()
    End Sub
End Class