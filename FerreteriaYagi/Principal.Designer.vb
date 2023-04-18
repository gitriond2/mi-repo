<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnVender = New System.Windows.Forms.Button()
        Me.BtnArticulos = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeFerreteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ConcretarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 33)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Principal"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Silver
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(339, 235)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(219, 73)
        Me.BtnSalir.TabIndex = 21
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnVender
        '
        Me.BtnVender.BackColor = System.Drawing.Color.Silver
        Me.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVender.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVender.Location = New System.Drawing.Point(339, 120)
        Me.BtnVender.Name = "BtnVender"
        Me.BtnVender.Size = New System.Drawing.Size(219, 73)
        Me.BtnVender.TabIndex = 17
        Me.BtnVender.Text = "Vender"
        Me.BtnVender.UseVisualStyleBackColor = False
        '
        'BtnArticulos
        '
        Me.BtnArticulos.BackColor = System.Drawing.Color.Silver
        Me.BtnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnArticulos.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArticulos.Location = New System.Drawing.Point(101, 120)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(219, 73)
        Me.BtnArticulos.TabIndex = 16
        Me.BtnArticulos.Text = "Articulos"
        Me.BtnArticulos.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(921, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConcretarVentaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HerramientasToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticuloToolStripMenuItem, Me.AgregarClienteToolStripMenuItem, Me.AgregarProveedorToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ArticuloToolStripMenuItem
        '
        Me.ArticuloToolStripMenuItem.Name = "ArticuloToolStripMenuItem"
        Me.ArticuloToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ArticuloToolStripMenuItem.Text = "ArticuloNuevo"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AgregarClienteToolStripMenuItem.Text = "AgregarCliente"
        '
        'AgregarProveedorToolStripMenuItem
        '
        Me.AgregarProveedorToolStripMenuItem.Name = "AgregarProveedorToolStripMenuItem"
        Me.AgregarProveedorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AgregarProveedorToolStripMenuItem.Text = "AgregarProveedor"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeFerreteriaToolStripMenuItem})
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'AcercaDeFerreteriaToolStripMenuItem
        '
        Me.AcercaDeFerreteriaToolStripMenuItem.Name = "AcercaDeFerreteriaToolStripMenuItem"
        Me.AcercaDeFerreteriaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AcercaDeFerreteriaToolStripMenuItem.Text = "Acerca de Ferreteria"
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Silver
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClientes.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Location = New System.Drawing.Point(573, 235)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(219, 73)
        Me.BtnClientes.TabIndex = 24
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackColor = System.Drawing.Color.Silver
        Me.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnProveedor.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedor.Location = New System.Drawing.Point(573, 120)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(219, 73)
        Me.BtnProveedor.TabIndex = 25
        Me.BtnProveedor.Text = "Provedores"
        Me.BtnProveedor.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "JoseRomano"
        '
        'ConcretarVentaToolStripMenuItem
        '
        Me.ConcretarVentaToolStripMenuItem.Name = "ConcretarVentaToolStripMenuItem"
        Me.ConcretarVentaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ConcretarVentaToolStripMenuItem.Text = "ConcretarVenta"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 331)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnVender)
        Me.Controls.Add(Me.BtnArticulos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Principal"
        Me.Text = "FerreteriaYagi"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnVender As System.Windows.Forms.Button
    Friend WithEvents BtnArticulos As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeFerreteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents BtnProveedor As System.Windows.Forms.Button
    Friend WithEvents AgregarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ConcretarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
