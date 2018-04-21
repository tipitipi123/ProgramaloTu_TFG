<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnviarCorreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtbTitulo = New System.Windows.Forms.RichTextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.ckSelecTodo = New System.Windows.Forms.CheckBox()
        Me.cbCorreos = New System.Windows.Forms.ComboBox()
        Me.rtbMsg = New System.Windows.Forms.RichTextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtbTitulo
        '
        Me.rtbTitulo.Location = New System.Drawing.Point(46, 234)
        Me.rtbTitulo.Name = "rtbTitulo"
        Me.rtbTitulo.Size = New System.Drawing.Size(1002, 29)
        Me.rtbTitulo.TabIndex = 16
        Me.rtbTitulo.Text = ""
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(41, 186)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(86, 25)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "TÍTULO"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(41, 301)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(112, 25)
        Me.lblMsg.TabIndex = 14
        Me.lblMsg.Text = "MENSAJE"
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnEnviar.Location = New System.Drawing.Point(46, 615)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(130, 48)
        Me.btnEnviar.TabIndex = 13
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'ckSelecTodo
        '
        Me.ckSelecTodo.AutoSize = True
        Me.ckSelecTodo.Location = New System.Drawing.Point(46, 129)
        Me.ckSelecTodo.Name = "ckSelecTodo"
        Me.ckSelecTodo.Size = New System.Drawing.Size(222, 17)
        Me.ckSelecTodo.TabIndex = 12
        Me.ckSelecTodo.Text = "Pulse para seleccionar todos los correos, "
        Me.ckSelecTodo.UseVisualStyleBackColor = True
        '
        'cbCorreos
        '
        Me.cbCorreos.FormattingEnabled = True
        Me.cbCorreos.Location = New System.Drawing.Point(46, 86)
        Me.cbCorreos.Name = "cbCorreos"
        Me.cbCorreos.Size = New System.Drawing.Size(467, 21)
        Me.cbCorreos.TabIndex = 11
        '
        'rtbMsg
        '
        Me.rtbMsg.Location = New System.Drawing.Point(46, 347)
        Me.rtbMsg.Name = "rtbMsg"
        Me.rtbMsg.Size = New System.Drawing.Size(1002, 229)
        Me.rtbMsg.TabIndex = 10
        Me.rtbMsg.Text = ""
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(41, 36)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(117, 25)
        Me.lblCorreo.TabIndex = 9
        Me.lblCorreo.Text = "CORREOS"
        '
        'EnviarCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 692)
        Me.Controls.Add(Me.rtbTitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.ckSelecTodo)
        Me.Controls.Add(Me.cbCorreos)
        Me.Controls.Add(Me.rtbMsg)
        Me.Controls.Add(Me.lblCorreo)
        Me.Name = "EnviarCorreo"
        Me.Text = "EnviarCorreo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbTitulo As RichTextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents ckSelecTodo As CheckBox
    Friend WithEvents cbCorreos As ComboBox
    Friend WithEvents rtbMsg As RichTextBox
    Friend WithEvents lblCorreo As Label
End Class
