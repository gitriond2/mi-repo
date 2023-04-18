Public Class Articulos

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        AgregarP.Show()
        Me.Hide()

    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        'Me.StockRegistroBindingSource.RemoveCurrent()
        'preguntar si es vacio
        Dim Pregunta, fila, CodigoConsulta As Integer
        
        CodigoConsulta = Val(InputBox("ingrese El codigo de busqueda: "))
        fila = Me.ProductoBindingSource.Find("Cod_Producto", CodigoConsulta)

        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos o debe igresar un valor numerico")
        Else
            Me.ProductoBindingSource.Position = fila
            Pregunta = MsgBox("Desea Eliminar el archivo seleccionado?", 32 + 1, "Eliminar")
            If Pregunta = 1 Then
                Me.ProductoBindingSource.RemoveCurrent()
                Me.ProductoBindingSource.EndEdit()
                Me.ProductoTableAdapter.Update(Me.FerreteriaDataSet.Producto)

                Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)
                MsgBox("El Archivo fue eliminado con exito")

            End If

        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        ModificarArticulos.Show()
        Me.Hide()

    End Sub

    Private Sub TBXFiltroArticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBXFiltroArticulo.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))

    End Sub

    Private Sub TBXFiltroArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBXFiltroArticulo.TextChanged
        Dim vista As New DataView
        vista.Table = Me.FerreteriaDataSet.Producto
        vista.RowFilter = "Nom_Producto LIKE'" & TBXFiltroArticulo.Text & "%'"      'toma el campo primero y despues de donde lo compara para filtrar
        Me.ProductoDataGridView.DataSource = vista
    End Sub

    Private Sub ProductoDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductoDataGridView.CellClick
        Dim fila As Integer
        fila = ProductoDataGridView.CurrentCellAddress.Y
        Transaccion.TBXBusqueda.Text = ProductoDataGridView.Item(0, fila).Value()      'pega el seleccionado en otro formulario
        Transaccion.TbxCantidad.Focus()                                              ' hace focus al siguiente del otro formulario
        Transaccion.Show()                                                           'abre el formulario de ventas
        Me.Close()                                                              'cierro el actual

    End Sub

   
End Class