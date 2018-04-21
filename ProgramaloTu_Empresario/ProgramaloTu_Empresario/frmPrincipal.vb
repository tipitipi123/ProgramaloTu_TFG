Public Class frmPrincipal
    Private Sub AÑADIRCATEGORÍAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AÑADIRCATEGORÍAToolStripMenuItem.Click
        Dim nuevoHijo As New AñadirCategoria()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "AÑADIR CATEGORÍA"
        nuevoHijo.Name = "AnadirCategoria"
        nuevoHijo.Show()
    End Sub

    Private Sub AÑADIRPRODUCTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AÑADIRPRODUCTOToolStripMenuItem.Click
        Dim nuevoHijo As New AnadirProductos()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "AÑADIR PRODUCTO"
        nuevoHijo.Name = "AnadirProducto"
        nuevoHijo.Show()
    End Sub

    Private Sub AÑADIRPROMOCIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AÑADIRPROMOCIÓNToolStripMenuItem.Click
        Dim nuevoHijo As New AnadirPromocion()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "AÑADIR PROMOCIÓN"
        nuevoHijo.Name = "AnadirPrmocion"
        nuevoHijo.Show()
    End Sub

    Private Sub MODIFICARCATEGORÍAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARCATEGORÍAToolStripMenuItem.Click
        Dim nuevoHijo As New ModificarCategoria()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "MODIFICAR CATEGORÍA"
        nuevoHijo.Name = "ModificarCategoria"
        nuevoHijo.Show()
    End Sub

    Private Sub MODIFICARPRODUCTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARPRODUCTOToolStripMenuItem.Click
        Dim nuevoHijo As New ModificarProductos()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "MODIFICAR PRODUCTO"
        nuevoHijo.Name = "ModificarProducto"
        nuevoHijo.Show()
    End Sub

    Private Sub ELIMINARCATEGORÍAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARCATEGORÍAToolStripMenuItem.Click
        Dim nuevoHijo As New EliminarCategoria()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "ELIMINAR CASTEGORIA"
        nuevoHijo.Name = "EliminarCategoria"
        nuevoHijo.Show()
    End Sub

    Private Sub ELIMINARPRODUCTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARPRODUCTOToolStripMenuItem.Click
        Dim nuevoHijo As New EliminarProducto()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "ELIMINAR PRODUCTOS"
        nuevoHijo.Name = "EliminarProductos"
        nuevoHijo.Show()
    End Sub

    Private Sub ELIMINARPROMOCIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARPROMOCIÓNToolStripMenuItem.Click
        Dim nuevoHijo As New EliminarPromocion()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "ELIMINAR PROMOCIÓN"
        nuevoHijo.Name = "EliminarPromocion"
        nuevoHijo.Show()
    End Sub

    Private Sub ENVIARCORREOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENVIARCORREOToolStripMenuItem.Click
        Dim nuevoHijo As New EnviarCorreo()
        nuevoHijo.MdiParent = Me
        nuevoHijo.Text = "ENVIAR CORREO"
        nuevoHijo.Name = "EnviarCorreo"
        nuevoHijo.Show()
    End Sub
End Class