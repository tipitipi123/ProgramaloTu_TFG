Public Class frmPedidos
    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub actualizarDataGridView()
        Dim Query As String = "SELECT productos_factura.nombre, cantidad, precio, total from productos_factura, cestas where facturas.id = codigo_factura and "
        cargar_dataGridView(Query, dgvShow)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub
End Class