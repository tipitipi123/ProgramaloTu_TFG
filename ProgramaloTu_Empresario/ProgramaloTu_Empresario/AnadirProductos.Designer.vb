<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnadirProductos
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.txtCategoria = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCategorai = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(101, 286)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 43)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(446, 306)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(202, 23)
        Me.btnImagen.TabIndex = 25
        Me.btnImagen.Text = "SELECCIONAR IMAGEN"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'pbImagen
        '
        Me.pbImagen.Location = New System.Drawing.Point(402, 35)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(284, 249)
        Me.pbImagen.TabIndex = 24
        Me.pbImagen.TabStop = False
        '
        'txtCategoria
        '
        Me.txtCategoria.FormattingEnabled = True
        Me.txtCategoria.Location = New System.Drawing.Point(132, 134)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(192, 21)
        Me.txtCategoria.TabIndex = 23
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(132, 215)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(64, 20)
        Me.txtPrecio.TabIndex = 22
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(132, 59)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 20)
        Me.txtNombre.TabIndex = 21
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(54, 218)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblPrecio.TabIndex = 20
        Me.lblPrecio.Text = "PRECIO"
        '
        'lblCategorai
        '
        Me.lblCategorai.AutoSize = True
        Me.lblCategorai.Location = New System.Drawing.Point(32, 134)
        Me.lblCategorai.Name = "lblCategorai"
        Me.lblCategorai.Size = New System.Drawing.Size(69, 13)
        Me.lblCategorai.TabIndex = 19
        Me.lblCategorai.Text = "CATEGORÍA"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(44, 62)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 13)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "NOMBRE "
        '
        'AnadirProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 383)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnImagen)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCategorai)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "AnadirProductos"
        Me.Text = "AnadirProductos"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
