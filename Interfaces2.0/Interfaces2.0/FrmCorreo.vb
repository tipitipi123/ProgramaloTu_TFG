Imports MySql.Data.MySqlClient
Public Class FrmCorreo
    Dim enviarTodos As Boolean = False
    '//////////////////////////////////////////////
    'PRECARGAR DATOS
    '//////////////////////////////////////////////
    Private Sub FrmCorreo_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_Email()
    End Sub

    Private Sub load_Email()
        Dim Query As String
        Query = "SELECT * FROM clientes"
        Try
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()
            'Limpiar cajas de texto
            cbSend.Items.Clear()
            cbSend.Text = ""
            While READER.Read
                cbSend.Items.Add(READER("email").ToString())
            End While
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '//////////////////////////////////////////////
    'COMPROBAR ESTADO CHECKBOX
    '//////////////////////////////////////////////
    Private Sub ckSelecTodo_CheckedChanged(sender As Object, e As EventArgs) Handles ckSelecTodo.CheckedChanged
        If ckSelecTodo.Checked Then
            cbSend.Enabled = False
            enviarTodos = True
        Else
            cbSend.Enabled = True
            enviarTodos = False
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

    End Sub
End Class