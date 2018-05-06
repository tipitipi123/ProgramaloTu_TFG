<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategorias
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
        Me.MenuIzquierdo = New System.Windows.Forms.Panel()
        Me.MenuDerecha = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.lblAddTag = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.MenuIzquierdo.SuspendLayout()
        Me.MenuDerecha.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuIzquierdo
        '
        Me.MenuIzquierdo.BackColor = System.Drawing.Color.Gray
        Me.MenuIzquierdo.Controls.Add(Me.btnEliminar)
        Me.MenuIzquierdo.Controls.Add(Me.btnEditar)
        Me.MenuIzquierdo.Controls.Add(Me.lblCategorias)
        Me.MenuIzquierdo.Controls.Add(Me.DataGridView1)
        Me.MenuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuIzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.MenuIzquierdo.Name = "MenuIzquierdo"
        Me.MenuIzquierdo.Size = New System.Drawing.Size(843, 604)
        Me.MenuIzquierdo.TabIndex = 0
        '
        'MenuDerecha
        '
        Me.MenuDerecha.BackColor = System.Drawing.Color.DimGray
        Me.MenuDerecha.Controls.Add(Me.btnGuardar)
        Me.MenuDerecha.Controls.Add(Me.txtNombre)
        Me.MenuDerecha.Controls.Add(Me.lblName)
        Me.MenuDerecha.Controls.Add(Me.lblAddTag)
        Me.MenuDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuDerecha.Location = New System.Drawing.Point(706, 0)
        Me.MenuDerecha.Name = "MenuDerecha"
        Me.MenuDerecha.Size = New System.Drawing.Size(474, 604)
        Me.MenuDerecha.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(688, 380)
        Me.DataGridView1.TabIndex = 0
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
        'lblAddTag
        '
        Me.lblAddTag.AutoSize = True
        Me.lblAddTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddTag.ForeColor = System.Drawing.Color.White
        Me.lblAddTag.Location = New System.Drawing.Point(40, 35)
        Me.lblAddTag.Name = "lblAddTag"
        Me.lblAddTag.Size = New System.Drawing.Size(189, 25)
        Me.lblAddTag.TabIndex = 0
        Me.lblAddTag.Text = "Añadir Categoria"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Coral
        Me.lblName.Location = New System.Drawing.Point(41, 133)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(76, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(120, 129)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(275, 24)
        Me.txtNombre.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(31, 465)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(417, 49)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        'frmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1180, 604)
        Me.Controls.Add(Me.MenuDerecha)
        Me.Controls.Add(Me.MenuIzquierdo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCategorias"
        Me.Text = "frmCategorias"
        Me.MenuIzquierdo.ResumeLayout(False)
        Me.MenuIzquierdo.PerformLayout()
        Me.MenuDerecha.ResumeLayout(False)
        Me.MenuDerecha.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuIzquierdo As Panel
    Friend WithEvents MenuDerecha As Panel
    Friend WithEvents lblCategorias As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddTag As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
End Class
