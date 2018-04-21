<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProductos
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
        Me.gbAntiguoProducto = New System.Windows.Forms.GroupBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.cbCategoriaAntigua = New System.Windows.Forms.ComboBox()
        Me.lblCategoriaAntigua = New System.Windows.Forms.Label()
        Me.gbNuevo = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.txtCategoria = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCategorai = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbAntiguoProducto.SuspendLayout()
        Me.gbNuevo.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbAntiguoProducto
        '
        Me.gbAntiguoProducto.Controls.Add(Me.cbProducto)
        Me.gbAntiguoProducto.Controls.Add(Me.lblProductos)
        Me.gbAntiguoProducto.Controls.Add(Me.cbCategoriaAntigua)
        Me.gbAntiguoProducto.Controls.Add(Me.lblCategoriaAntigua)
        Me.gbAntiguoProducto.Location = New System.Drawing.Point(51, 53)
        Me.gbAntiguoProducto.Name = "gbAntiguoProducto"
        Me.gbAntiguoProducto.Size = New System.Drawing.Size(811, 100)
        Me.gbAntiguoProducto.TabIndex = 29
        Me.gbAntiguoProducto.TabStop = False
        Me.gbAntiguoProducto.Text = "BUSCAR PRODUCTO"
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(546, 39)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(192, 21)
        Me.cbProducto.TabIndex = 30
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(446, 42)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(68, 13)
        Me.lblProductos.TabIndex = 29
        Me.lblProductos.Text = "PRODUCTO"
        '
        'cbCategoriaAntigua
        '
        Me.cbCategoriaAntigua.FormattingEnabled = True
        Me.cbCategoriaAntigua.Location = New System.Drawing.Point(147, 39)
        Me.cbCategoriaAntigua.Name = "cbCategoriaAntigua"
        Me.cbCategoriaAntigua.Size = New System.Drawing.Size(192, 21)
        Me.cbCategoriaAntigua.TabIndex = 28
        '
        'lblCategoriaAntigua
        '
        Me.lblCategoriaAntigua.AutoSize = True
        Me.lblCategoriaAntigua.Location = New System.Drawing.Point(47, 42)
        Me.lblCategoriaAntigua.Name = "lblCategoriaAntigua"
        Me.lblCategoriaAntigua.Size = New System.Drawing.Size(69, 13)
        Me.lblCategoriaAntigua.TabIndex = 27
        Me.lblCategoriaAntigua.Text = "CATEGORÍA"
        '
        'gbNuevo
        '
        Me.gbNuevo.Controls.Add(Me.btnGuardar)
        Me.gbNuevo.Controls.Add(Me.btnImagen)
        Me.gbNuevo.Controls.Add(Me.pbImagen)
        Me.gbNuevo.Controls.Add(Me.txtCategoria)
        Me.gbNuevo.Controls.Add(Me.txtPrecio)
        Me.gbNuevo.Controls.Add(Me.txtNombre)
        Me.gbNuevo.Controls.Add(Me.lblPrecio)
        Me.gbNuevo.Controls.Add(Me.lblCategorai)
        Me.gbNuevo.Controls.Add(Me.lblNombre)
        Me.gbNuevo.Location = New System.Drawing.Point(51, 178)
        Me.gbNuevo.Name = "gbNuevo"
        Me.gbNuevo.Size = New System.Drawing.Size(811, 355)
        Me.gbNuevo.TabIndex = 28
        Me.gbNuevo.TabStop = False
        Me.gbNuevo.Text = "DATOS PRODUCTO"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(147, 281)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 43)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(492, 301)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(202, 23)
        Me.btnImagen.TabIndex = 16
        Me.btnImagen.Text = "SELECCIONAR IMAGEN"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'pbImagen
        '
        Me.pbImagen.Location = New System.Drawing.Point(448, 30)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(284, 249)
        Me.pbImagen.TabIndex = 15
        Me.pbImagen.TabStop = False
        '
        'txtCategoria
        '
        Me.txtCategoria.FormattingEnabled = True
        Me.txtCategoria.Location = New System.Drawing.Point(178, 129)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(192, 21)
        Me.txtCategoria.TabIndex = 14
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(178, 210)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(64, 20)
        Me.txtPrecio.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(178, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 20)
        Me.txtNombre.TabIndex = 12
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(100, 213)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblPrecio.TabIndex = 11
        Me.lblPrecio.Text = "PRECIO"
        '
        'lblCategorai
        '
        Me.lblCategorai.AutoSize = True
        Me.lblCategorai.Location = New System.Drawing.Point(78, 129)
        Me.lblCategorai.Name = "lblCategorai"
        Me.lblCategorai.Size = New System.Drawing.Size(69, 13)
        Me.lblCategorai.TabIndex = 10
        Me.lblCategorai.Text = "CATEGORÍA"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(90, 57)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "NOMBRE "
        '
        'ModificarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 610)
        Me.Controls.Add(Me.gbAntiguoProducto)
        Me.Controls.Add(Me.gbNuevo)
        Me.Name = "ModificarProductos"
        Me.Text = "ModificarProductos"
        Me.gbAntiguoProducto.ResumeLayout(False)
        Me.gbAntiguoProducto.PerformLayout()
        Me.gbNuevo.ResumeLayout(False)
        Me.gbNuevo.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbAntiguoProducto As GroupBox
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents lblProductos As Label
    Friend WithEvents cbCategoriaAntigua As ComboBox
    Friend WithEvents lblCategoriaAntigua As Label
    Friend WithEvents gbNuevo As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnImagen As Button
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents txtCategoria As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblCategorai As Label
    Friend WithEvents lblNombre As Label
End Class
