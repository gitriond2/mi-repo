Public Class Proovedores

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Principal.Show()
        Me.Close()

    End Sub

    Private Sub ProveedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Proovedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.FerreteriaDataSet.Proveedor)

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Me.ProveedorBindingSource.AddNew()
        'Me.ProveedorBindingSource.EndEdit()
        'Me.ProveedorBindingSource.Current("Nom_Producto") = Nom_ProductoTextBox.Text
        'Me.ProveedorBindingSource.Current("Nom_Prov") = Nom_ProvTextBox.Text
        'Me.ProveedorBindingSource.Current("Tel_Prov") = Val(Tel_ProvTextBox.Text)
        'Me.ProveedorBindingSource.Current("Nro_Articulo") = Val(Nro_ArticuloTextBox.Text)


        ''guardo los datos ingresados
        'Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)
        'Me.ProveedorTableAdapter.Fill(Me.FerreteriaDataSet.Proveedor)
        'Articulos.ProductoTableAdapter.Fill(Articulos.FerreteriaDataSet.Producto)
        'MsgBox("El archivo se guardo con exito. ") 'podrias mostrar el nro de articulo

        ''Me.ProveedorBindingSource.AddNew()
        Nom_ProductoTextBox.Focus()
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Me.ProveedorBindingSource.EndEdit()
        Me.ProveedorTableAdapter.Update(Me.FerreteriaDataSet.Proveedor)              'Guarda
        Me.ProveedorTableAdapter.Fill(Me.FerreteriaDataSet.Proveedor)                'Actualiza
        'ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)
        MsgBox("El Archivo fue modificado exitosamente")
    End Sub

    Private Sub ProveedorDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedorDataGridView.CellClick
        'Dim fila As Integer
        'fila = ProveedorDataGridView.CurrentCellAddress.Y
        'Articulos.ProductoDataGridView.Text = ProveedorDataGridView.Item(0, fila).Value()      'pega el seleccionado en otro formulario
        'Articulos.TBXFiltroArticulo.Focus()                                              ' hace focus al siguiente del otro formulario
        'Articulos.Show()                                                           'abre el formulario de ventas
        'Me.Close()
        'Focusea a la tabla de articulos

    End Sub

    Private Sub Tel_ProvTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tel_ProvTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Numeros(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            Nro_ArticuloTextBox.Focus()
        End If
    End Sub

    Private Sub Nro_ArticuloTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nro_ArticuloTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Numeros(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            BtnModificar.Focus()
        End If
    End Sub

    Private Sub Nom_ProductoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nom_ProductoTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            Nom_ProvTextBox.Focus()
        End If
    End Sub

    Private Sub Nom_ProvTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nom_ProvTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            Tel_ProvTextBox.Focus()
        End If
    End Sub
End Class