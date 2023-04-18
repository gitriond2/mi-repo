<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarP
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
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Cod_ProvLabel As System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.FerreteriaDataSet = New FerreteriaYagi.FerreteriaDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.DistritoTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.DistritoTableAdapter()
        Me.ProveedorTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.ProveedorTableAdapter()
        Me.Nom_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.CBXProv = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistritoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Nom_ProductoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Cod_ProvLabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistritoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nom_ProductoLabel
        '
        Nom_ProductoLabel.AutoSize = True
        Nom_ProductoLabel.Location = New System.Drawing.Point(70, 17)
        Nom_ProductoLabel.Name = "Nom_ProductoLabel"
        Nom_ProductoLabel.Size = New System.Drawing.Size(78, 13)
        Nom_ProductoLabel.TabIndex = 4
        Nom_ProductoLabel.Text = "Nom Producto:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(70, 43)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 6
        MarcaLabel.Text = "Marca:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(70, 69)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 8
        PrecioLabel.Text = "Precio:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(70, 95)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 10
        CantidadLabel.Text = "Cantidad:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(70, 154)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 12
        DescripcionLabel.Text = "Descripcion:"
        '
        'Cod_ProvLabel
        '
        Cod_ProvLabel.AutoSize = True
        Cod_ProvLabel.Location = New System.Drawing.Point(70, 121)
        Cod_ProvLabel.Name = "Cod_ProvLabel"
        Cod_ProvLabel.Size = New System.Drawing.Size(54, 13)
        Cod_ProvLabel.TabIndex = 14
        Cod_ProvLabel.Text = "Cod Prov:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(377, 14)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(477, 14)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 1
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.DistritoTableAdapter = Me.DistritoTableAdapter
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.ROLESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'DistritoTableAdapter
        '
        Me.DistritoTableAdapter.ClearBeforeFill = True
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'Nom_ProductoTextBox
        '
        Me.Nom_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nom_Producto", True))
        Me.Nom_ProductoTextBox.Location = New System.Drawing.Point(154, 14)
        Me.Nom_ProductoTextBox.Name = "Nom_ProductoTextBox"
        Me.Nom_ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nom_ProductoTextBox.TabIndex = 5
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(154, 40)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarcaTextBox.TabIndex = 7
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(154, 66)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 9
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(154, 92)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 11
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(154, 151)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(298, 50)
        Me.DescripcionTextBox.TabIndex = 13
        '
        'CBXProv
        '
        Me.CBXProv.DataSource = Me.ProveedorBindingSource
        Me.CBXProv.DisplayMember = "Nom_Producto"
        Me.CBXProv.FormattingEnabled = True
        Me.CBXProv.Location = New System.Drawing.Point(154, 121)
        Me.CBXProv.Name = "CBXProv"
        Me.CBXProv.Size = New System.Drawing.Size(121, 21)
        Me.CBXProv.TabIndex = 15
        Me.CBXProv.ValueMember = "Cod_Prov"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'DistritoBindingSource
        '
        Me.DistritoBindingSource.DataMember = "Distrito"
        Me.DistritoBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'AgregarP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 245)
        Me.Controls.Add(Me.CBXProv)
        Me.Controls.Add(Nom_ProductoLabel)
        Me.Controls.Add(Me.Nom_ProductoTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Cod_ProvLabel)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "AgregarP"
        Me.Text = "Agregar"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistritoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents FerreteriaDataSet As FerreteriaYagi.FerreteriaDataSet
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Nom_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistritoTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.DistritoTableAdapter
    Friend WithEvents CBXProv As System.Windows.Forms.ComboBox
    Friend WithEvents DistritoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
End Class
