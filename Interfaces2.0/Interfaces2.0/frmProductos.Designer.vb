<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuDerecha = New System.Windows.Forms.Panel()
        Me.cbCategorias = New System.Windows.Forms.ComboBox()
        Me.btnSelectImage = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddTag = New System.Windows.Forms.Label()
        Me.MenuIzquierdo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvShow = New System.Windows.Forms.DataGridView()
        Me.btnDeleteProd = New System.Windows.Forms.Button()
        Me.btnEditarProd = New System.Windows.Forms.Button()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mostrar_error = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.MenuDerecha.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuIzquierdo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_error, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuDerecha
        '
        Me.MenuDerecha.BackColor = System.Drawing.Color.DimGray
        Me.MenuDerecha.Controls.Add(Me.txtDescuento)
        Me.MenuDerecha.Controls.Add(Me.lblDescuento)
        Me.MenuDerecha.Controls.Add(Me.cbCategorias)
        Me.MenuDerecha.Controls.Add(Me.btnSelectImage)
        Me.MenuDerecha.Controls.Add(Me.pbImagen)
        Me.MenuDerecha.Controls.Add(Me.txtPrecio)
        Me.MenuDerecha.Controls.Add(Me.Label3)
        Me.MenuDerecha.Controls.Add(Me.Label2)
        Me.MenuDerecha.Controls.Add(Me.btnGuardar)
        Me.MenuDerecha.Controls.Add(Me.txtNombre)
        Me.MenuDerecha.Controls.Add(Me.lblName)
        Me.MenuDerecha.Controls.Add(Me.lblAddTag)
        Me.MenuDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuDerecha.Location = New System.Drawing.Point(706, 0)
        Me.MenuDerecha.Name = "MenuDerecha"
        Me.MenuDerecha.Size = New System.Drawing.Size(474, 604)
        Me.MenuDerecha.TabIndex = 2
        '
        'cbCategorias
        '
        Me.cbCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategorias.FormattingEnabled = True
        Me.cbCategorias.Location = New System.Drawing.Point(139, 141)
        Me.cbCategorias.Name = "cbCategorias"
        Me.cbCategorias.Size = New System.Drawing.Size(277, 26)
        Me.cbCategorias.TabIndex = 10
        '
        'btnSelectImage
        '
        Me.btnSelectImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectImage.Location = New System.Drawing.Point(143, 469)
        Me.btnSelectImage.Name = "btnSelectImage"
        Me.btnSelectImage.Size = New System.Drawing.Size(224, 23)
        Me.btnSelectImage.TabIndex = 9
        Me.btnSelectImage.Text = "Seleccionar Imagen"
        Me.btnSelectImage.UseVisualStyleBackColor = True
        '
        'pbImagen
        '
        Me.pbImagen.Image = CType(resources.GetObject("pbImagen.Image"), System.Drawing.Image)
        Me.pbImagen.Location = New System.Drawing.Point(143, 286)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(224, 163)
        Me.pbImagen.TabIndex = 8
        Me.pbImagen.TabStop = False
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.White
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(141, 187)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(10)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(275, 24)
        Me.txtPrecio.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(64, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(41, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Categoria:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(33, 531)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(417, 49)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(139, 99)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(10)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(277, 24)
        Me.txtNombre.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Coral
        Me.lblName.Location = New System.Drawing.Point(52, 103)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(76, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Nombre:"
        '
        'lblAddTag
        '
        Me.lblAddTag.AutoSize = True
        Me.lblAddTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddTag.ForeColor = System.Drawing.Color.White
        Me.lblAddTag.Location = New System.Drawing.Point(40, 35)
        Me.lblAddTag.Name = "lblAddTag"
        Me.lblAddTag.Size = New System.Drawing.Size(181, 25)
        Me.lblAddTag.TabIndex = 0
        Me.lblAddTag.Text = "Añadir Producto"
        '
        'MenuIzquierdo
        '
        Me.MenuIzquierdo.BackColor = System.Drawing.Color.Gray
        Me.MenuIzquierdo.Controls.Add(Me.Panel1)
        Me.MenuIzquierdo.Controls.Add(Me.btnEliminar)
        Me.MenuIzquierdo.Controls.Add(Me.btnEditar)
        Me.MenuIzquierdo.Controls.Add(Me.lblCategorias)
        Me.MenuIzquierdo.Controls.Add(Me.DataGridView1)
        Me.MenuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuIzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.MenuIzquierdo.Name = "MenuIzquierdo"
        Me.MenuIzquierdo.Size = New System.Drawing.Size(710, 604)
        Me.MenuIzquierdo.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.dgvShow)
        Me.Panel1.Controls.Add(Me.btnDeleteProd)
        Me.Panel1.Controls.Add(Me.btnEditarProd)
        Me.Panel1.Controls.Add(Me.lblProductos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 604)
        Me.Panel1.TabIndex = 4
        '
        'dgvShow
        '
        Me.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvShow.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvShow.ColumnHeadersHeight = 30
        Me.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvShow.EnableHeadersVisualStyles = False
        Me.dgvShow.Location = New System.Drawing.Point(26, 99)
        Me.dgvShow.Name = "dgvShow"
        Me.dgvShow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShow.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvShow.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShow.Size = New System.Drawing.Size(688, 380)
        Me.dgvShow.TabIndex = 4
        '
        'btnDeleteProd
        '
        Me.btnDeleteProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteProd.Location = New System.Drawing.Point(107, 503)
        Me.btnDeleteProd.Name = "btnDeleteProd"
        Me.btnDeleteProd.Size = New System.Drawing.Size(75, 33)
        Me.btnDeleteProd.TabIndex = 3
        Me.btnDeleteProd.Text = "Eliminar"
        Me.btnDeleteProd.UseVisualStyleBackColor = True
        '
        'btnEditarProd
        '
        Me.btnEditarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarProd.Location = New System.Drawing.Point(26, 503)
        Me.btnEditarProd.Name = "btnEditarProd"
        Me.btnEditarProd.Size = New System.Drawing.Size(75, 33)
        Me.btnEditarProd.TabIndex = 2
        Me.btnEditarProd.Text = "Editar"
        Me.btnEditarProd.UseVisualStyleBackColor = True
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductos.ForeColor = System.Drawing.Color.White
        Me.lblProductos.Location = New System.Drawing.Point(21, 35)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(235, 25)
        Me.lblProductos.TabIndex = 1
        Me.lblProductos.Text = "Productos Existentes"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(93, 503)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 33)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(12, 503)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 33)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategorias.ForeColor = System.Drawing.Color.White
        Me.lblCategorias.Location = New System.Drawing.Point(12, 35)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(243, 25)
        Me.lblCategorias.TabIndex = 1
        Me.lblCategorias.Text = "Categorias Existentes"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(688, 380)
        Me.DataGridView1.TabIndex = 0
        '
        'mostrar_error
        '
        Me.mostrar_error.ContainerControl = Me
        '
        'txtDescuento
        '
        Me.txtDescuento.BackColor = System.Drawing.Color.White
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(139, 231)
        Me.txtDescuento.Margin = New System.Windows.Forms.Padding(10)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(275, 24)
        Me.txtDescuento.TabIndex = 12
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.ForeColor = System.Drawing.Color.Coral
        Me.lblDescuento.Location = New System.Drawing.Point(25, 235)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(101, 20)
        Me.lblDescuento.TabIndex = 11
        Me.lblDescuento.Text = "Descuento:"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1180, 604)
        Me.Controls.Add(Me.MenuIzquierdo)
        Me.Controls.Add(Me.MenuDerecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductos"
        Me.Text = "frmProductos"
        Me.MenuDerecha.ResumeLayout(False)
        Me.MenuDerecha.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuIzquierdo.ResumeLayout(False)
        Me.MenuIzquierdo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_error, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuDerecha As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddTag As Label
    Friend WithEvents MenuIzquierdo As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblCategorias As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDeleteProd As Button
    Friend WithEvents btnEditarProd As Button
    Friend WithEvents lblProductos As Label
    Friend WithEvents btnSelectImage As Button
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCategorias As ComboBox
    Friend WithEvents dgvShow As DataGridView
    Friend WithEvents mostrar_error As ErrorProvider
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents lblDescuento As Label
End Class
