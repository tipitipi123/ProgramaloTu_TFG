Imports MySql.Data.MySqlClient
Public Class ModificarCategoria
    '//////////////////////////////////////////////////////////////////
    'BOTON PARA MODIFICAR EL NOMBRE DE LA CATEGORÍA
    '//////////////////////////////////////////////////////////////////
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobar_dato_new() And comprobar_dato_old() Then
            realizar_modificacion()
            cargar_categorias()
        End If
    End Sub

    '//////////////////////////////////////////////////////////////////
    'FUNCIÓN LOAD PARA CARGAR EN EL COMBOBOX LAS CATEGORIAS DISPONIBLES
    '//////////////////////////////////////////////////////////////////
    Private Sub Modificar_Categoria_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar_categorias()
    End Sub

    Private Sub cargar_categorias()
        Dim Query As String
        Query = "SELECT * FROM Categorias"
        Try
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()
            'Limpiar cajas de texto
            cbCategoria.Items.Clear()
            cbCategoria.Text = ""
            txtNombre.Text = ""
            While READER.Read
                cbCategoria.Items.Add(READER("Nombre").ToString())
            End While
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '//////////////////////////////////////////////////////
    'COMPROBACION DE LA ENTRADA DE DATOS
    '//////////////////////////////////////////////////////
    Private Function comprobar_dato_new()
        If IsNumeric(txtNombre.Text) Or txtNombre.Text = "" Then
            mostrar_error.SetError(Me.txtNombre, "TIENE QUE INTRODUCIR POR LO MENOS UN CARACTER ALFABÉTICO")
            Return False
        End If
        mostrar_error.SetError(Me.txtNombre, "")
        Return True
    End Function

    Private Function comprobar_dato_old()
        Dim Query As String
        Query = "SELECT * FROM Categorias WHERE Nombre='" & cbCategoria.Text & "'"
        Try
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()
            If READER.Read = Nothing Then
                mostrar_error.SetError(Me.cbCategoria, "TIENE QUE INTRODUCIR UNA CATEGORÍA EXISTENTE")
                READER.Close()
                conn.Close()
                Return False
            End If
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            READER.Close()
            conn.Close()
            Return False
        End Try
        mostrar_error.SetError(Me.cbCategoria, "")
        Return True
    End Function

    '////////////////////////////////////////////////////////////
    'FUNCIÓN PARA CAMBIAR EL NOMBRE DE LA CATEGORÍA
    '////////////////////////////////////////////////////////////
    Private Sub realizar_modificacion()
        Try
            conn.Open()
            Dim Query As String
            Query = "UPDATE Categorias SET nombre='" & txtNombre.Text & "' WHERE nombre='" & cbCategoria.Text & "'"
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader
            MessageBox.Show("DATOS MODIFICADOS")
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class