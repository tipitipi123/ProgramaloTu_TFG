Public Class frmProductos

    '/////////////////////////////////////////////////////
    'MÉTODO QUE PRECARGA TODO LO NECESARIO
    '/////////////////////////////////////////////////////
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Query As String = "SELECT * FROM Productos"
        cargar_dataGridView(Query, dgvShow)
    End Sub

    'Cargar Categorias
    Private Sub load_tagg()

    End Sub
End Class