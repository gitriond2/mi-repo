Public Class ModificarArticulos

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub ModificarArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)

    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Me.ProductoBindingSource.EndEdit()
        Me.ProductoTableAdapter.Update(Me.FerreteriaDataSet.Producto)              'Guarda
        Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)                'Actualiza
        'ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)
        MsgBox("El Archivo fue modificado exitosamente")
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila, CodigoConsulta As Integer
        CodigoConsulta = Val(InputBox("ingrese El codigo de busqueda: "))
        fila = Me.ProductoBindingSource.Find("Cod_Producto", CodigoConsulta)

        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos o debe igresar un valor numerico")
        Else
            Me.ProductoBindingSource.Position = fila

        End If
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Articulos.Show()
        Me.Close()
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
            BtnModificar.Focus()
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