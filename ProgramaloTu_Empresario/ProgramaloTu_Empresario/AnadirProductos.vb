Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AnadirProductos
    Dim foto As Byte()
    Dim categoria As Integer
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
                    foto = File.ReadAllBytes(name)
                    pbImagen.Image = Image.FromFile(openFile.FileName)
                End If
            Catch Ex As Exception
                MessageBox.Show("NO SE PUEDE LEER LA IMAGEN")
            Finally
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
        Return foto
    End Function

    '////////////////////////////////////////////////////////
    'BOTON PARA ALMACENAR LA INFORMACION EN LA BASE DE DATOS
    '////////////////////////////////////////////////////////
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobar_todo() Then
            guardar_producto()
        End If
    End Sub

    Private Sub guardar_producto()
        Try
            conn.Open()
            Dim Query As String
            Query = "insert into Productos(nombre,categoria,precio,descuento,promocion,foto) values (?nombre,?categoria,?precio,0,false,?foto)"
            Command = New MySqlCommand(Query, conn)
            Command.Parameters.AddWithValue("?foto", foto)
            Command.Parameters.AddWithValue("?nombre", txtNombre.Text)
            Command.Parameters.AddWithValue("?categoria", categoria)
            Command.Parameters.AddWithValue("?precio", txtPrecio.Text)

            READER = Command.ExecuteReader
            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    '///////////////////////////////////////////////////////////////////////////////////
    'FUNCIÓN QUE OBTIENE EL ID DE LA CATEGORÍA SELECCIONADA Y COMPRUEBA SI ES CORRECTA 
    '//////////////////////////////////////////////////////////////////////////////////
    Private Function obtener_id_categoria()
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
                categoria = id
                Return True
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

    '///////////////////////////////////////////////////////////
    'COMPROBAR SI LOS DATOS INTRODUCIDOS SON CORRECTOS
    '///////////////////////////////////////////////////////////
    Private Function comprobar_nombre()
        If txtNombre.Text = "" Then
            mostrar_error.SetError(Me.txtNombre, "TIENE QUE INTRODUCIR UN NOMBRE CORRECTO")
            Return False
        End If
        mostrar_error.SetError(Me.txtNombre, "")
        Return True
    End Function

    Private Function comprobar_precio()
        If txtPrecio.Text = "" And Not Double.TryParse(txtPrecio.Text, 2) Then
            mostrar_error.SetError(Me.txtPrecio, "TIENE QUE INTRODUCIR UN PRECIO CORRECTO")
            Return False
        End If
        mostrar_error.SetError(Me.txtPrecio, "")
        Return True
    End Function

    Private Function comprobar_imagen()
        If IsNothing(foto) Then
            mostrar_error.SetError(Me.pbImagen, "SELECCIONE UNA IMAGEN")
            Return False
        End If
        mostrar_error.SetError(Me.pbImagen, "")
        Return True
    End Function

    Private Function comprobar_todo()
        If comprobar_nombre() And comprobar_precio() And comprobar_imagen() And obtener_id_categoria() Then
            Return True
        End If
        Return False
    End Function
End Class