<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaccion
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
        Dim Cod_EmpleadoLabel As System.Windows.Forms.Label
        Me.FerreteriaDataSet = New FerreteriaYagi.FerreteriaDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TBXBusqueda = New System.Windows.Forms.TextBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnConcretar = New System.Windows.Forms.Button()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.CbxCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.ClientesTableAdapter()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.TbxCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.VentasTableAdapter()
        Me.FechaCaptura = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxEmpleado = New System.Windows.Forms.ComboBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.EmpleadoTableAdapter()
        Cod_EmpleadoLabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_EmpleadoLabel
        '
        Cod_EmpleadoLabel.AutoSize = True
        Cod_EmpleadoLabel.Location = New System.Drawing.Point(467, 156)
        Cod_EmpleadoLabel.Name = "Cod_EmpleadoLabel"
        Cod_EmpleadoLabel.Size = New System.Drawing.Size(57, 13)
        Cod_EmpleadoLabel.TabIndex = 12
        Cod_EmpleadoLabel.Text = "Empleado:"
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DistritoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.ROLESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(74, 24)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(762, 60)
        Me.ProductoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cod_Producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod_Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom_Producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom_Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cod_Prov"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cod_Prov"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(259, 108)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TBXBusqueda
        '
        Me.TBXBusqueda.Location = New System.Drawing.Point(98, 110)
        Me.TBXBusqueda.Name = "TBXBusqueda"
        Me.TBXBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.TBXBusqueda.TabIndex = 3
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(730, 203)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 4
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnConcretar
        '
        Me.BtnConcretar.Location = New System.Drawing.Point(470, 199)
        Me.BtnConcretar.Name = "BtnConcretar"
        Me.BtnConcretar.Size = New System.Drawing.Size(134, 23)
        Me.BtnConcretar.TabIndex = 5
        Me.BtnConcretar.Text = "Concretar Venta"
        Me.BtnConcretar.UseVisualStyleBackColor = True
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(34, 156)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 7
        Me.Cliente.Text = "Cliente"
        '
        'CbxCliente
        '
        Me.CbxCliente.DataSource = Me.ClientesBindingSource
        Me.CbxCliente.DisplayMember = "Dni"
        Me.CbxCliente.FormattingEnabled = True
        Me.CbxCliente.Location = New System.Drawing.Point(98, 153)
        Me.CbxCliente.Name = "CbxCliente"
        Me.CbxCliente.Size = New System.Drawing.Size(121, 21)
        Me.CbxCliente.TabIndex = 8
        Me.CbxCliente.ValueMember = "Cod_Persona"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(259, 151)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(133, 23)
        Me.BtnClientes.TabIndex = 9
        Me.BtnClientes.Text = "Agregar Cliente"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'TbxCantidad
        '
        Me.TbxCantidad.Location = New System.Drawing.Point(552, 108)
        Me.TbxCantidad.Name = "TbxCantidad"
        Me.TbxCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TbxCantidad.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cantidad"
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'FechaCaptura
        '
        Me.FechaCaptura.Location = New System.Drawing.Point(98, 202)
        Me.FechaCaptura.Name = "FechaCaptura"
        Me.FechaCaptura.Size = New System.Drawing.Size(200, 20)
        Me.FechaCaptura.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fecha"
        '
        'CbxEmpleado
        '
        Me.CbxEmpleado.DataSource = Me.EmpleadoBindingSource
        Me.CbxEmpleado.DisplayMember = "Nombre_Empleado"
        Me.CbxEmpleado.FormattingEnabled = True
        Me.CbxEmpleado.Location = New System.Drawing.Point(552, 151)
        Me.CbxEmpleado.Name = "CbxEmpleado"
        Me.CbxEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.CbxEmpleado.TabIndex = 16
        Me.CbxEmpleado.ValueMember = "Cod_Empleado"
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'Transaccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 305)
        Me.Controls.Add(Me.CbxEmpleado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FechaCaptura)
        Me.Controls.Add(Cod_EmpleadoLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbxCantidad)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.CbxCliente)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.BtnConcretar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.TBXBusqueda)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Name = "Transaccion"
        Me.Text = "transaccion"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FerreteriaDataSet As FerreteriaYagi.FerreteriaDataSet
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TBXBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnConcretar As System.Windows.Forms.Button
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents CbxCliente As System.Windows.Forms.ComboBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents TbxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents FechaCaptura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.EmpleadoTableAdapter
End Class
