
Public Class Form1

    'Definir variables globales; estas van despues de la linea de inherits
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub pictureMover_Click(sender As Object, e As EventArgs) Handles pictureMover.Click
        If (MenuVertical.Width = 250) Then
            pbLetrasLogo.Visible = False
            MenuVertical.Width = 65
        Else
            pbLetrasLogo.Visible = True
            MenuVertical.Width = 250
        End If
    End Sub

    Private Sub pbMaximizar_Click(sender As Object, e As EventArgs) Handles pbMaximizar.Click
        WindowState = FormWindowState.Maximized
        pbMaximizar.Visible = False
        pbMinimizar.Visible = True
    End Sub

    Private Sub pbMinimizar_Click(sender As Object, e As EventArgs) Handles pbMinimizar.Click
        WindowState = FormWindowState.Normal
        pbMaximizar.Visible = True
        pbMinimizar.Visible = False
    End Sub

    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Close()
    End Sub

    Private Sub pbBackground_Click(sender As Object, e As EventArgs) Handles pbBackground.Click
        WindowState = FormWindowState.Minimized
    End Sub


    '///////////////////////////////////////////////////////
    'Mover Barra
    '//////////////////////////////////////////////////////
    Private Sub MenuTop_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuTop.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub MenuTop_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuTop.MouseUp
        Arrastre = False
    End Sub

    Private Sub MenuTop_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuTop.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    '////////////////////////////////////////////////////////
    'Cargar Diferentes Paneles
    '////////////////////////////////////////////////////////
    Private Sub abrirFromulario(frmHijo As Object)
        If (MenuForm.Controls.Count > 0) Then
            MenuForm.Controls.RemoveAt(0)
        End If

        Dim frm As Form
        frm = frmHijo
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.MenuForm.Controls.Add(frm)
        MenuForm.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        abrirFromulario(frmProductos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFromulario(frmPromociones)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        abrirFromulario(FrmCorreo)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        abrirFromulario(frmCliente)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        abrirFromulario(frmPedidos)
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        abrirFromulario(frmCategorias)
    End Sub
End Class
