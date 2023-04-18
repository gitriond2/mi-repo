Public Class VentasF

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.FerreteriaDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila, CodigoConsulta As Integer
        CodigoConsulta = Val(InputBox("ingrese El codigo de busqueda: "))
        fila = Me.VentasBindingSource.Find("Id_Venta", CodigoConsulta)

        'If CodigoConsulta <> "" And IsNumeric(CodigoConsulta) Then
        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos o no ingreso un valor numerico")
        Else
            Me.VentasBindingSource.Position = fila

        End If

    End Sub

    Private Sub BtnVender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVender.Click
        Transaccion.Show()
        Me.Hide()

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Principal.Show()
        Me.Close()

    End Sub

    Private Sub BtnEliminarVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarVentas.Click
        'codigo de consulta vacio

        Dim Pregunta, fila, CodigoConsulta As Integer
        CodigoConsulta = Val(InputBox("ingrese El codigo de busqueda a Eliminar: "))
        fila = Me.VentasBindingSource.Find("Id_Producto", CodigoConsulta)

        'If fila = "" or fila = Char then

        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos o debe ingresar un valor numerico")
        Else
            Me.VentasBindingSource.Position = fila
            Pregunta = MsgBox("Desea Eliminar el archivo seleccionado?", 32 + 1, "Eliminar")
            If Pregunta = 1 Then
                Me.VentasBindingSource.RemoveCurrent()
                Me.VentasBindingSource.EndEdit()
                Me.VentasTableAdapter.Update(Me.FerreteriaDataSet.Ventas)   ' guardo tabla

                Me.VentasTableAdapter.Fill(Me.FerreteriaDataSet.Ventas)     'actualizo tabla
                MsgBox("El Archivo fue eliminado con exito")

            End If

        End If
    End Sub

    Private Sub TBXFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBXFiltro.TextChanged
        Dim vista As New DataView
        vista.Table = Me.FerreteriaDataSet.Ventas
        vista.RowFilter = "Decripcion LIKE'" & TBXFiltro.Text & "%'"
        Me.VentasDataGridView.DataSource = vista
    End Sub

    
End Class