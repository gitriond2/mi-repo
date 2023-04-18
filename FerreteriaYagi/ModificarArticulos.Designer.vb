<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarArticulos
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
        Me.CBXProv = New System.Windows.Forms.ComboBox()
        Me.Nom_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.FerreteriaDataSet = New FerreteriaYagi.FerreteriaDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New FerreteriaYagi.FerreteriaDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Nom_ProductoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Cod_ProvLabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nom_ProductoLabel
        '
        Nom_ProductoLabel.AutoSize = True
        Nom_ProductoLabel.Location = New System.Drawing.Point(46, 32)
        Nom_ProductoLabel.Name = "Nom_ProductoLabel"
        Nom_ProductoLabel.Size = New System.Drawing.Size(78, 13)
        Nom_ProductoLabel.TabIndex = 16
        Nom_ProductoLabel.Text = "Nom Producto:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(46, 58)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 18
        MarcaLabel.Text = "Marca:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(46, 84)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 20
        PrecioLabel.Text = "Precio:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(46, 110)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 22
        CantidadLabel.Text = "Cantidad:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(46, 169)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 24
        DescripcionLabel.Text = "Descripcion:"
        '
        'Cod_ProvLabel
        '
        Cod_ProvLabel.AutoSize = True
        Cod_ProvLabel.Location = New System.Drawing.Point(46, 136)
        Cod_ProvLabel.Name = "Cod_ProvLabel"
        Cod_ProvLabel.Size = New System.Drawing.Size(54, 13)
        Cod_ProvLabel.TabIndex = 26
        Cod_ProvLabel.Text = "Cod Prov:"
        '
        'CBXProv
        '
        Me.CBXProv.DisplayMember = "Nom_Producto"
        Me.CBXProv.FormattingEnabled = True
        Me.CBXProv.Location = New System.Drawing.Point(130, 136)
        Me.CBXProv.Name = "CBXProv"
        Me.CBXProv.Size = New System.Drawing.Size(121, 21)
        Me.CBXProv.TabIndex = 27
        Me.CBXProv.ValueMember = "Cod_Prov"
        '
        'Nom_ProductoTextBox
        '
        Me.Nom_ProductoTextBox.Location = New System.Drawing.Point(130, 29)
        Me.Nom_ProductoTextBox.Name = "Nom_ProductoTextBox"
        Me.Nom_ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nom_ProductoTextBox.TabIndex = 17
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.Location = New System.Drawing.Point(130, 55)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarcaTextBox.TabIndex = 19
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.Location = New System.Drawing.Point(130, 81)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 21
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Location = New System.Drawing.Point(130, 107)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 23
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Location = New System.Drawing.Point(130, 166)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(298, 50)
        Me.DescripcionTextBox.TabIndex = 25
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(272, 270)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 28
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
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
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(176, 270)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 29
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(363, 270)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 30
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'ModificarArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 346)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
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
        Me.Name = "ModificarArticulos"
        Me.Text = "ModificarArticulos"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBXProv As System.Windows.Forms.ComboBox
    Friend WithEvents Nom_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents FerreteriaDataSet As FerreteriaYagi.FerreteriaDataSet
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As FerreteriaYagi.FerreteriaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As FerreteriaYagi.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
End Class
