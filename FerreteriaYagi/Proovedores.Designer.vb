<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proovedores
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
        Dim Nom_ProductoLabel As System.Windows.Forms.Label
        Dim Cod_ProvLabel As System.Windows.Forms.Label
        Dim Nom_ProvLabel As System.Windows.Forms.Label
        Dim Tel_ProvLabel As System.Windows.Forms.Label
        Dim Nro_ArticuloLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FerreteriaDataSet = New FerreteriaYagi.FerreteriaDataSet()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.ProveedorTableAdapter()
        Me.TableAdapterManager = New FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_ProvTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_ProvTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_ProvTextBox = New System.Windows.Forms.TextBox()
        Me.Nro_ArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Nom_ProductoLabel = New System.Windows.Forms.Label()
        Cod_ProvLabel = New System.Windows.Forms.Label()
        Nom_ProvLabel = New System.Windows.Forms.Label()
        Tel_ProvLabel = New System.Windows.Forms.Label()
        Nro_ArticuloLabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nom_ProductoLabel
        '
        Nom_ProductoLabel.AutoSize = True
        Nom_ProductoLabel.Location = New System.Drawing.Point(41, 71)
        Nom_ProductoLabel.Name = "Nom_ProductoLabel"
        Nom_ProductoLabel.Size = New System.Drawing.Size(78, 13)
        Nom_ProductoLabel.TabIndex = 2
        Nom_ProductoLabel.Text = "Nom Producto:"
        '
        'Cod_ProvLabel
        '
        Cod_ProvLabel.AutoSize = True
        Cod_ProvLabel.Location = New System.Drawing.Point(41, 45)
        Cod_ProvLabel.Name = "Cod_ProvLabel"
        Cod_ProvLabel.Size = New System.Drawing.Size(54, 13)
        Cod_ProvLabel.TabIndex = 4
        Cod_ProvLabel.Text = "Cod Prov:"
        '
        'Nom_ProvLabel
        '
        Nom_ProvLabel.AutoSize = True
        Nom_ProvLabel.Location = New System.Drawing.Point(41, 98)
        Nom_ProvLabel.Name = "Nom_ProvLabel"
        Nom_ProvLabel.Size = New System.Drawing.Size(57, 13)
        Nom_ProvLabel.TabIndex = 6
        Nom_ProvLabel.Text = "Nom Prov:"
        '
        'Tel_ProvLabel
        '
        Tel_ProvLabel.AutoSize = True
        Tel_ProvLabel.Location = New System.Drawing.Point(41, 124)
        Tel_ProvLabel.Name = "Tel_ProvLabel"
        Tel_ProvLabel.Size = New System.Drawing.Size(50, 13)
        Tel_ProvLabel.TabIndex = 8
        Tel_ProvLabel.Text = "Tel Prov:"
        '
        'Nro_ArticuloLabel
        '
        Nro_ArticuloLabel.AutoSize = True
        Nro_ArticuloLabel.Location = New System.Drawing.Point(41, 150)
        Nro_ArticuloLabel.Name = "Nro_ArticuloLabel"
        Nro_ArticuloLabel.Size = New System.Drawing.Size(65, 13)
        Nro_ArticuloLabel.TabIndex = 10
        Nro_ArticuloLabel.Text = "Nro Articulo:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(141, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DistritoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.ROLESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(296, 12)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(549, 220)
        Me.ProveedorDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cod_Prov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cod_Prov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nom_Producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nom_Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nom_Prov"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nom_Prov"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tel_Prov"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tel_Prov"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nro_Articulo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nro_Articulo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Nom_ProductoTextBox
        '
        Me.Nom_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Nom_Producto", True))
        Me.Nom_ProductoTextBox.Location = New System.Drawing.Point(125, 68)
        Me.Nom_ProductoTextBox.Name = "Nom_ProductoTextBox"
        Me.Nom_ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nom_ProductoTextBox.TabIndex = 3
        '
        'Cod_ProvTextBox
        '
        Me.Cod_ProvTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cod_ProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Cod_Prov", True))
        Me.Cod_ProvTextBox.Enabled = False
        Me.Cod_ProvTextBox.Location = New System.Drawing.Point(125, 42)
        Me.Cod_ProvTextBox.Name = "Cod_ProvTextBox"
        Me.Cod_ProvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_ProvTextBox.TabIndex = 5
        '
        'Nom_ProvTextBox
        '
        Me.Nom_ProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Nom_Prov", True))
        Me.Nom_ProvTextBox.Location = New System.Drawing.Point(125, 95)
        Me.Nom_ProvTextBox.Name = "Nom_ProvTextBox"
        Me.Nom_ProvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nom_ProvTextBox.TabIndex = 7
        '
        'Tel_ProvTextBox
        '
        Me.Tel_ProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Tel_Prov", True))
        Me.Tel_ProvTextBox.Location = New System.Drawing.Point(125, 121)
        Me.Tel_ProvTextBox.Name = "Tel_ProvTextBox"
        Me.Tel_ProvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tel_ProvTextBox.TabIndex = 9
        '
        'Nro_ArticuloTextBox
        '
        Me.Nro_ArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Nro_Articulo", True))
        Me.Nro_ArticuloTextBox.Location = New System.Drawing.Point(125, 147)
        Me.Nro_ArticuloTextBox.Name = "Nro_ArticuloTextBox"
        Me.Nro_ArticuloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nro_ArticuloTextBox.TabIndex = 11
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(60, 189)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 12
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(141, 189)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(131, 23)
        Me.BtnModificar.TabIndex = 13
        Me.BtnModificar.Text = "Modificar o Guardar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'Proovedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 306)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Nom_ProductoLabel)
        Me.Controls.Add(Me.Nom_ProductoTextBox)
        Me.Controls.Add(Cod_ProvLabel)
        Me.Controls.Add(Me.Cod_ProvTextBox)
        Me.Controls.Add(Nom_ProvLabel)
        Me.Controls.Add(Me.Nom_ProvTextBox)
        Me.Controls.Add(Tel_ProvLabel)
        Me.Controls.Add(Me.Tel_ProvTextBox)
        Me.Controls.Add(Nro_ArticuloLabel)
        Me.Controls.Add(Me.Nro_ArticuloTextBox)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Proovedores"
        Me.Text = "Proveedores"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FerreteriaDataSet As FerreteriaYagi.FerreteriaDataSet
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents TableAdapterManager As FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Nom_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_ProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_ProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_ProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nro_ArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
