Public Class frmCliente
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        actualizarDataGridView()
    End Sub

    Private Sub actualizarDataGridView()
        Dim Query As String = "SELECT nombre as Nombre, direccion as Direccion, telefono as Telefono, email as Correo from clientes"
        cargar_dataGridView(Query, dgvShow)
    End Sub

End Class