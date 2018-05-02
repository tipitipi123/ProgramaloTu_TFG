
Public Class Form1

    'Definir variables globales; estas van despues de la linea de inherits
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub pictureMover_Click(sender As Object, e As EventArgs) Handles pictureMover.Click
        If (MenuVertical.Width = 250) Then
            pbLetrasLogo.Visible = False
            MenuVertical.Width = 70
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
End Class
