<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCorreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ckSelecTodo = New System.Windows.Forms.CheckBox()
        Me.txtTittle = New System.Windows.Forms.TextBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.rtbMsg = New System.Windows.Forms.RichTextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.cbSend = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(49, 47)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(169, 25)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "Enviar Correos"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(53, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(79, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Enviar a:"
        '
        'ckSelecTodo
        '
        Me.ckSelecTodo.AutoSize = True
        Me.ckSelecTodo.Location = New System.Drawing.Point(57, 177)
        Me.ckSelecTodo.Name = "ckSelecTodo"
        Me.ckSelecTodo.Size = New System.Drawing.Size(222, 17)
        Me.ckSelecTodo.TabIndex = 13
        Me.ckSelecTodo.Text = "Pulse para seleccionar todos los correos, "
        Me.ckSelecTodo.UseVisualStyleBackColor = True
        '
        'txtTittle
        '
        Me.txtTittle.BackColor = System.Drawing.Color.White
        Me.txtTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTittle.Location = New System.Drawing.Point(57, 256)
        Me.txtTittle.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTittle.Name = "txtTittle"
        Me.txtTittle.Size = New System.Drawing.Size(1043, 24)
        Me.txtTittle.TabIndex = 15
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.White
        Me.lbTitulo.Location = New System.Drawing.Point(53, 225)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(58, 20)
        Me.lbTitulo.TabIndex = 14
        Me.lbTitulo.Text = "Título:"
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.White
        Me.lblmsg.Location = New System.Drawing.Point(53, 311)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(81, 20)
        Me.lblmsg.TabIndex = 16
        Me.lblmsg.Text = "Mensaje:"
        '
        'rtbMsg
        '
        Me.rtbMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMsg.Location = New System.Drawing.Point(57, 355)
        Me.rtbMsg.Name = "rtbMsg"
        Me.rtbMsg.Size = New System.Drawing.Size(1043, 148)
        Me.rtbMsg.TabIndex = 17
        Me.rtbMsg.Text = ""
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.Black
        Me.btnSend.Location = New System.Drawing.Point(57, 528)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(109, 39)
        Me.btnSend.TabIndex = 18
        Me.btnSend.Text = "Enviar"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'cbSend
        '
        Me.cbSend.FormattingEnabled = True
        Me.cbSend.Location = New System.Drawing.Point(57, 138)
        Me.cbSend.Name = "cbSend"
        Me.cbSend.Size = New System.Drawing.Size(395, 21)
        Me.cbSend.TabIndex = 19
        '
        'FrmCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1180, 604)
        Me.Controls.Add(Me.cbSend)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.rtbMsg)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.txtTittle)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.ckSelecTodo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTittle)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCorreo"
        Me.Text = "FrmCorreo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTittle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents ckSelecTodo As CheckBox
    Friend WithEvents txtTittle As TextBox
    Friend WithEvents lbTitulo As Label
    Friend WithEvents lblmsg As Label
    Friend WithEvents rtbMsg As RichTextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents cbSend As ComboBox
End Class
