Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AnadirProductos
    Dim result As Byte()
    '//////////////////////////////////////////////////////////////////
    'FUNCIÓN LOAD PARA CARGAR EN EL COMBOBOX LAS CATEGORIAS DISPONIBLES
    '//////////////////////////////////////////////////////////////////
    Private Sub AnadirProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Query As String
        Query = "SELECT * FROM Categorias"
        Try
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()
            'Limpiar cajas de texto
            txtCategoria.Items.Clear()
            txtCategoria.Text = ""
            txtNombre.Text = ""
            While READER.Read
                txtCategoria.Items.Add(READER("Nombre").ToString())
            End While
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////
    'BOTON PARA SELECCIONAR UNA IMAGEN Y CONVERTIRLA EN UN ARRAY DE BYTE
    '////////////////////////////////////////////////////////////////////
    Private Function btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        'Stream se usa junto a openFile para poder leer la imagen
        Dim myStream As Stream = Nothing
        Dim name As String = ""
        Dim openFile As New OpenFileDialog()

        'Propiedades de la ventana
        openFile.InitialDirectory = "c:\"
        'openFileDialog1.Filter = "imagefiles files (*.png)|*.jpg"
        openFile.FilterIndex = 2
        openFile.RestoreDirectory = True

        If openFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFile.OpenFile()
                If (myStream IsNot Nothing) Then
                    name = openFile.FileName
                    result = File.ReadAllBytes(name)
                End If
            Catch Ex As Exception
                MessageBox.Show("NO SE PUEDE LEER LA IMAGEN: " & Ex.Message)
            Finally
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
        Return result
    End Function

    '////////////////////////////////////////////////////////
    'BOTON PARA ALMACENAR LA INFORMACION EN LA BASE DE DATOS
    '////////////////////////////////////////////////////////
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub guardar_producto()
        Try
            conn.Open()
            Dim Query As String
            Query = "insert into Productos(nombre,categoria,precio,descuento,promocion,foto) values ('" & txtNombre.Text & "'," & devolver_id_categoria() & "," & txtPrecio.Text & "," & 0 & "," & False & "," & result & ")"
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader
            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    '///////////////////////////////////////////////////////
    'FUNCIÓN QUE DEVUELVE EL ID DE LA CATEGORÍA SELECCIONADA
    '///////////////////////////////////////////////////////
    Private Function devolver_id_categoria()
        Dim id As Integer = 0
        Dim Query As String
        Query = "SELECT id_categoria FROM Categorias where nombre='" & txtCategoria.Text & "'"
        Try
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()
            If READER.Read = Nothing Then
                mostrar_error.SetError(Me.txtCategoria, "TIENE QUE INTRODUCIR UNA CATEGORÍA EXISTENTE")
            Else
                mostrar_error.SetError(Me.txtCategoria, "")
                id = READER("id_categoria")
                READER.Close()
                conn.Close()
                Return id
            End If
            READER.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            READER.Close()
            conn.Close()
        End Try
        Return False
    End Function


End Class