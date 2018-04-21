<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnadirPromocion
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
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbDescuento = New System.Windows.Forms.GroupBox()
        Me.rbUno = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rtbMsg = New System.Windows.Forms.RichTextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDescuento.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(43, 410)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(755, 205)
        Me.dgvProductos.TabIndex = 41
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(194, 650)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(96, 57)
        Me.btnAnadir.TabIndex = 40
        Me.btnAnadir.Text = "AÑADIR"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(143, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(83, 20)
        Me.txtNombre.TabIndex = 39
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(57, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 13)
        Me.lblNombre.TabIndex = 38
        Me.lblNombre.Text = "NOMBRE "
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(43, 650)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 57)
        Me.btnGuardar.TabIndex = 37
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gbDescuento
        '
        Me.gbDescuento.Controls.Add(Me.rbUno)
        Me.gbDescuento.Controls.Add(Me.rbTodos)
        Me.gbDescuento.Location = New System.Drawing.Point(43, 259)
        Me.gbDescuento.Name = "gbDescuento"
        Me.gbDescuento.Size = New System.Drawing.Size(443, 124)
        Me.gbDescuento.TabIndex = 36
        Me.gbDescuento.TabStop = False
        Me.gbDescuento.Text = "APLICAR DESCUENTO"
        '
        'rbUno
        '
        Me.rbUno.AutoSize = True
        Me.rbUno.Location = New System.Drawing.Point(252, 59)
        Me.rbUno.Name = "rbUno"
        Me.rbUno.Size = New System.Drawing.Size(186, 17)
        Me.rbUno.TabIndex = 1
        Me.rbUno.TabStop = True
        Me.rbUno.Text = "PRODUCTOS SELECCIONADOS"
        Me.rbUno.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(24, 59)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(158, 17)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "TODOS LOS PRODUCTOS"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rtbMsg
        '
        Me.rtbMsg.Location = New System.Drawing.Point(440, 68)
        Me.rtbMsg.Name = "rtbMsg"
        Me.rtbMsg.Size = New System.Drawing.Size(358, 154)
        Me.rtbMsg.TabIndex = 35
        Me.rtbMsg.Text = ""
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(437, 43)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(57, 13)
        Me.lblMsg.TabIndex = 34
        Me.lblMsg.Text = "MENSAJE"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(143, 170)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(83, 20)
        Me.txtDescuento.TabIndex = 33
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(143, 126)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(222, 21)
        Me.cbProducto.TabIndex = 32
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(143, 83)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(222, 21)
        Me.cbCategoria.TabIndex = 31
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(40, 178)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(74, 13)
        Me.lblDescuento.TabIndex = 30
        Me.lblDescuento.Text = "DESCUENTO"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(47, 134)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(68, 13)
        Me.lblProducto.TabIndex = 29
        Me.lblProducto.Text = "PRODUCTO"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(46, 91)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(69, 13)
        Me.lblCategoria.TabIndex = 28
        Me.lblCategoria.Text = "CATEGORIA"
        '
        'AnadirPromocion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 733)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbDescuento)
        Me.Controls.Add(Me.rtbMsg)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblCategoria)
        Me.Name = "AnadirPromocion"
        Me.Text = "AnadirPromocion"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDescuento.ResumeLayout(False)
        Me.gbDescuento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnAnadir As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents gbDescuento As GroupBox
    Friend WithEvents rbUno As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rtbMsg As RichTextBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblCategoria As Label
End Class
