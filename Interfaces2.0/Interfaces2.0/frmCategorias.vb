Imports MySql.Data.MySqlClient
Public Class frmCategorias
    Dim Editar As Boolean = False
    Dim id As String
    '/////////////////////////////////////////////////////
    'BOTÓN GUARDAR. GUARDA LA INFORMACIÓN EN LA BD
    '/////////////////////////////////////////////////////
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobar_datos() And comprobar_existe() And Editar = False Then
            insertar_datos()
        ElseIf comprobar_datos() And Editar = True Then
            If actualizarCategoria() Then
                MsgBox("Categoria modificada")
            End If
            Editar = False
        End If
        actualizarDataGridView()
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
        Dim Query As String = "insert into Categorias(nombre) values ('" & txtNombre.Text & "')"
        insertar_bd(Query)
    End Sub

    '/////////////////////////////////////////////////////
    'COMPRUEBA SI LA CATEGORÍA YA EXISTE
    '/////////////////////////////////////////////////////
    Private Function comprobar_existe()
        Dim Query As String = "SELECT * FROM Categorias WHERE Nombre='" & txtNombre.Text & "'"
        Return consulta_bd(Query)
    End Function

    '/////////////////////////////////////////////////////
    'MÉTODO PARA ACTUALIZAR EL DATA GRID VIEW
    '/////////////////////////////////////////////////////
    Private Sub actualizarDataGridView()
        Dim Query As String = "SELECT * FROM Categorias"
        cargar_dataGridView(Query, dgvShow)
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
            Editar = True
            id = dgvShow.CurrentRow.Cells.Item(0).Value.ToString
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
        Dim Query As String
        Try
            Query = "delete from Categorias where id_categoria = " & dgvShow.CurrentRow.Cells.Item(0).Value
        Catch ex2 As System.NullReferenceException
        End Try
        Return borrar_bd(Query)
    End Function

    Private Function borrarEnPedidos()
        Dim Query As String
        Try
            Query = "delete from productos where categoria = " & dgvShow.CurrentRow.Cells.Item(0).Value
        Catch ex2 As System.NullReferenceException
            MessageBox.Show(ex2.Message)
        End Try
        Return borrar_bd(Query)
    End Function

    '/////////////////////////////////////////////////////
    'ACTUALIZAR CATEGORIA EXISTENTES
    '/////////////////////////////////////////////////////
    Private Function actualizarCategoria()
        Try
            Dim Query As String = "update Categorias set nombre = '" & txtNombre.Text & "' where id_categoria = " & id
            insertar_bd(Query)
            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function
End Class