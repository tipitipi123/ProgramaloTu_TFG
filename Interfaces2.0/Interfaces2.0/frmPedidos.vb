Public Class frmPedidos
    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub actualizarDataGridView()
        Dim Query As String = "SELECT nombre, direccion, telefono, email from clientes"
        cargar_dataGridView(Query, dgvShow)
    End Sub
End Class