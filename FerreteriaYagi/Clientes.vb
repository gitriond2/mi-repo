Public Class Clientes

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.FerreteriaDataSet.Clientes)

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        AgregarC.Show()
        Me.Hide()
        AgregarC.DniTextBox.Focus()
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Me.Close()

    End Sub

    
    Private Sub BtnBuscarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarClientes.Click
        Dim fila As Integer
        'If TbxBusquedaClientes.Text <> "" Or IsNumeric(TbxBusquedaClientes.Text) Then
        If TbxBusquedaClientes.Text = "" Or IsNumeric(TbxBusquedaClientes.Text) Then
            MsgBox("debe ingresar un valor")
        Else

            fila = Val(Me.ClientesBindingSource.Find("Dni", TbxBusquedaClientes.Text))

            If fila = -1 Then
                MsgBox("El Registro no se encuentra en los campos establecidos")
            Else
                Me.ClientesBindingSource.Position = fila

            End If
        End If

    End Sub
End Class