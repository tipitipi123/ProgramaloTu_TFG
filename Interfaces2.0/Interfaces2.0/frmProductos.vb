Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmProductos
    Dim foto As Byte()
    Dim Editar As Boolean = False
    Dim nombre As String

    '/////////////////////////////////////////////////////
    'MÉTODO QUE PRECARGA TODO LO NECESARIO
    '/////////////////////////////////////////////////////
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        actualizarDataGridView()
        load_tagg()
        pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'Cargar Categorias
    Private Sub load_tagg()
        Dim Query As String
        Query = "SELECT * FROM Categorias"
        Try
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()
            'Limpiar cajas de texto
            cbCategorias.Items.Clear()
            cbCategorias.Text = ""
            txtNombre.Text = ""
            While READER.Read
                cbCategorias.Items.Add(READER("Nombre").ToString())
            End While
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub actualizarDataGridView()
        Dim Query As String = "SELECT productos.nombre as 'Producto', productos.precio as 'Precio',categorias.nombre as 'Categoria', promociones.descuento as 'Descuento' FROM productos, categorias, promociones WHERE categoria = categorias.id_categoria and promocion = promociones.id_promocion"
        cargar_dataGridView(Query, dgvShow)
    End Sub

    '////////////////////////////////////////////////////////////////////
    'BOTON PARA SELECCIONAR UNA IMAGEN Y CONVERTIRLA EN UN ARRAY DE BYTE
    '////////////////////////////////////////////////////////////////////
    Private Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
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
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            Catch Ex As Exception
                MessageBox.Show("NO SE PUEDE LEER LA IMAGEN")
            Finally
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////
    'COMPROBAR DATOS 
    '////////////////////////////////////////////////////////////////////
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

    '///////////////////////////////////////////////////////////////////////////////////
    'FUNCIÓN QUE OBTIENE EL ID DE LA CATEGORÍA SELECCIONADA Y COMPRUEBA SI ES CORRECTA 
    '//////////////////////////////////////////////////////////////////////////////////
    Private Function obtener_id_categoria()
        Dim Query As String
        Query = String.Format("SELECT id_categoria FROM Categorias where nombre='{0}'", cbCategorias.Text)
        If consulta_bd(Query) Then
            mostrar_error.SetError(Me.cbCategorias, "SELECCIONE UNA CATEGORIA EXISTENTE")
            Return False
        End If
        mostrar_error.SetError(Me.cbCategorias, "")
        Return True
    End Function

    '///////////////////////////////////////////////////////////////////////////////////
    'FUNCIÓN BOTON GUARDAR 
    '//////////////////////////////////////////////////////////////////////////////////
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobar_todo() And Editar = False Then
            guardar_producto()
        ElseIf comprobar_todo() And Editar = True Then
            If actualizarProducto() Then
                Editar = False
                MsgBox("Producto Actualizado")
            End If
        End If
        actualizarDataGridView()
    End Sub

    Private Sub guardar_producto()
        Try
            Dim Query As String
            Dim QueryId As String = "SELECT id_categoria FROM Categorias where nombre='" & cbCategorias.Text & "'"
            Query = String.Format("insert into productos(nombre,categoria,precio,promocion,foto) values ('{0}',{1},{2},{3},'{4}')", txtNombre.Text, devolverIdCategoria(QueryId), txtPrecio.Text, 1, foto)
            insertar_bd(Query)
            Query = String.Format("insert into productos_factura(nombre,categoria,precio,promocion,foto) values ('{0}',{1},{2},{3},'{4}')", txtNombre.Text, devolverIdCategoria(QueryId), txtPrecio.Text, 1, foto)
            If insertar_bd(Query) Then
                MsgBox("Producto Guardado")
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    '///////////////////////////////////////////////////////////////////////////////////
    'BOTÓN BORRAR
    '//////////////////////////////////////////////////////////////////////////////////
    Private Sub btnDeleteProd_Click(sender As Object, e As EventArgs) Handles btnDeleteProd.Click
        If buttonDelet() Then
            actualizarDataGridView()
            MsgBox("Producto Borrado")
        End If
    End Sub

    Private Function buttonDelet()
        Dim Query As String
        Try
            Query = String.Format("delete from productos where nombre = '{0}'", dgvShow.CurrentRow.Cells.Item(0).Value)
        Catch ex2 As System.NullReferenceException
            MessageBox.Show(ex2.Message)
        End Try
        Return borrar_bd(Query)
    End Function

    '///////////////////////////////////////////////////////////////////////////////////
    'BOTÓN EDITAR
    '//////////////////////////////////////////////////////////////////////////////////
    Private Sub btnEditarProd_Click(sender As Object, e As EventArgs) Handles btnEditarProd.Click
        cargarCategorias()
    End Sub

    Private Sub cargarCategorias()
        If dgvShow.SelectedRows.Count > 0 Then
            Editar = True
            nombre = dgvShow.CurrentRow.Cells.Item(0).Value.ToString
            txtNombre.Text = dgvShow.CurrentRow.Cells.Item(0).Value.ToString
            txtPrecio.Text = dgvShow.CurrentRow.Cells.Item(1).Value.ToString
            cbCategorias.Text = dgvShow.CurrentRow.Cells.Item(2).Value.ToString
            ' obtener_imagen(nombre)
        End If
    End Sub

    Private Sub obtener_imagen(ByRef nombre)
        Dim sentencia As String = String.Format("select foto from productos where nombre = '{0}'", nombre)
        Try
            conn.Open()
            Command = New MySqlCommand(sentencia, conn)
            READER = Command.ExecuteReader()

            Dim ms As New MemoryStream(foto)
            pbImagen.Image = Image.FromStream(ms)
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        READER.Close()
        conn.Close()
    End Sub

    Private Function actualizarProducto()
        Try
            Dim QueryId As String = "SELECT id_categoria FROM Categorias where nombre='" & cbCategorias.Text & "'"
            Dim Query As String = String.Format("update productos set nombre = '{0}', categoria = {1}, precio = {2}, promocion = {3}, foto = {4} where nombre = '{5}'", txtNombre.Text, devolverIdCategoria(QueryId), txtPrecio.Text, 1, foto, nombre)
            insertar_bd(Query)
            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function
End Class