
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class FrmCorreo
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
        Else
            cbSend.Enabled = True
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If checkAll() Then
            If ckSelecTodo.Checked Then
                sendAll()
            Else
                sendMail(cbSend.Text)
            End If
            MsgBox("Msg Enviado")
        End If
    End Sub

    Private Sub sendMail(ByRef correoTo)
        Dim mail As New MailMessage
        mail.Subject = txtTittle.Text
        mail.To.Add(correoTo)
        mail.From = New MailAddress("tipix1998@gmail.com")
        mail.Body = rtbMsg.Text

        Dim Smtp As New SmtpClient("smtp.gmail.com")
        Smtp.EnableSsl = True
        Smtp.Credentials = New System.Net.NetworkCredential("tipix1998@gmail.com", "juanantonio1998.")
        Smtp.Port = "587"
        Smtp.Send(mail)
    End Sub


    Private Sub sendAll()
        Dim Query As String
        Query = "SELECT * FROM clientes"
        Try
            conn.Open()
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader()

            While READER.Read
                sendMail(READER("email").ToString())
            End While
            READER.Close()
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '//////////////////////////////////////////////
    'COMPROBAR DATOS
    '//////////////////////////////////////////////
    Private Function checkTittle()
        If txtTittle.Text = "" Then
            mostrar_error.SetError(Me.txtTittle, "TIENE QUE INTRODUCIR UN TÍTULO CORRECTO")
            Return False
        End If
        mostrar_error.SetError(Me.txtTittle, "")
        Return True
    End Function

    Private Function checkEmail()
        If cbSend.Text = "" And Not ckSelecTodo.Checked Then
            mostrar_error.SetError(Me.cbSend, "TIENE QUE INTRODUCIR UN CORREO CORRECTO")
            Return False
        End If
        mostrar_error.SetError(Me.cbSend, "")
        Return True
    End Function

    Private Function checkSubject()
        If rtbMsg.Text = "" Then
            mostrar_error.SetError(Me.rtbMsg, "TIENE QUE INTRODUCIR UN TÍTULO CORRECTO")
            Return False
        End If
        mostrar_error.SetError(Me.rtbMsg, "")
        Return True
    End Function

    Private Function checkAll()
        If checkEmail() And checkSubject() And checkTittle() Then
            Return True
        End If
        Return False
    End Function
End Class