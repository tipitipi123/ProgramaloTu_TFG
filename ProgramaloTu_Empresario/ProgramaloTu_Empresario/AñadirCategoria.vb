Imports MySql.Data.MySqlClient
Public Class AñadirCategoria

    '/////////////////////////////////////////////////////
    'BOTÓN GUARDAR. GUARDA LA INFORMACIÓN EN LA BD
    '/////////////////////////////////////////////////////
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobar_datos() And comprobar_existe() Then
            insertar_datos()
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
            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
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
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
            READER.Close()
            conn.Close()
            Return False
        End Try
        mostrar_error.SetError(Me.txtNombre, "LA CATEGORÍA YA EXISTE")
        Return False
    End Function

End Class