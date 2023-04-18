Public Class AgregarC

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)


    End Sub

    Private Sub AgregarC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Distrito' Puede moverla o quitarla según sea necesario.
        Me.DistritoTableAdapter.Fill(Me.FerreteriaDataSet.Distrito)
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.FerreteriaDataSet.Clientes)
        Me.ClientesBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Clientes.Show()
        Me.Close()

    End Sub

    Private Sub BtnAgregarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarC.Click
        Me.ClientesBindingSource.EndEdit()
        Me.ClientesBindingSource.Current("Dni") = Val(DniTextBox.Text)
        Me.ClientesBindingSource.Current("Nombre") = NombreTextBox.Text
        Me.ClientesBindingSource.Current("Apellido") = ApellidoTextBox.Text
        Me.ClientesBindingSource.Current("Cod_Distrito") = CbxDistrito.SelectedValue
        Me.ClientesBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)
        Me.ClientesBindingSource.Current("Direccion") = Val(DireccionTextBox.Text)

        'guardo los datos ingresados
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)
        Me.ClientesTableAdapter.Fill(Me.FerreteriaDataSet.Clientes)
        Transaccion.ClientesTableAdapter.Fill(Transaccion.FerreteriaDataSet.Clientes)
        Clientes.ClientesTableAdapter.Fill(Clientes.FerreteriaDataSet.Clientes)
        MsgBox("El Cliente se guardo con exito. ") 'podrias mostrar el dni o el nombre del cliente

    End Sub

    Private Sub DniTextBox_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DniTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Numeros(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            NombreTextBox.Focus()
        End If
    End Sub

    Private Sub NombreTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            ApellidoTextBox.Focus()
        End If
    End Sub

    Private Sub CbxDistrito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxDistrito.SelectedIndexChanged
        TelefonoTextBox.Focus()

    End Sub

    Private Sub TelefonoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            DireccionTextBox.Focus()
        End If
    End Sub

    Private Sub ApellidoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            CbxDistrito.Focus()
        End If
    End Sub

    Private Sub DireccionTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DireccionTextBox.KeyPress
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            BtnAgregarC.Focus()
        End If
    End Sub

   
End Class