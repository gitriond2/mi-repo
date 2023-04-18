Public Class AgregarP

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Articulos.Show()
        Me.Close()

    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Agregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.FerreteriaDataSet.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Distrito' Puede moverla o quitarla según sea necesario.
        Me.DistritoTableAdapter.Fill(Me.FerreteriaDataSet.Distrito)
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)
        Me.ProductoBindingSource.AddNew()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Me.ProductoBindingSource.EndEdit()
        Me.ProductoBindingSource.Current("Nom_Producto") = Nom_ProductoTextBox.Text
        Me.ProductoBindingSource.Current("Marca") = MarcaTextBox.Text
        Me.ProductoBindingSource.Current("Precio") = Val(PrecioTextBox.Text)
        Me.ProductoBindingSource.Current("Cantidad") = Val(CantidadTextBox.Text)
        Me.ProductoBindingSource.Current("Precio") = Val(PrecioTextBox.Text)
        Me.ProductoBindingSource.Current("Descripcion") = DescripcionTextBox.Text
        Me.ProductoBindingSource.Current("Cod_Prov") = CBXProv.SelectedValue

        'guardo los datos ingresados
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)
        Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)
        Articulos.ProductoTableAdapter.Fill(Articulos.FerreteriaDataSet.Producto)
        MsgBox("El archivo se guardo con exito. ") 'podrias mostrar el nro de articulo

        Me.ProductoBindingSource.AddNew()
        Nom_ProductoTextBox.Focus()

    End Sub

    Private Sub PrecioTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Numeros(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            CantidadTextBox.Focus()
        End If
    End Sub

    Private Sub DescripcionTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            BtnGuardar.Focus()
        End If
    End Sub

    Private Sub Nom_ProductoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nom_ProductoTextBox.KeyPress
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            MarcaTextBox.Focus()
        End If
    End Sub

    Private Sub MarcaTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MarcaTextBox.KeyPress
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            PrecioTextBox.Focus()
        End If
    End Sub

    Private Sub CBXProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBXProv.SelectedIndexChanged
        DescripcionTextBox.Focus()


    End Sub

End Class