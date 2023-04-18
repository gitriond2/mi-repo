Public Class Transaccion

    Private Sub Transaccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.FerreteriaDataSet.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.FerreteriaDataSet.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Empleado' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.FerreteriaDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.FerreteriaDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)

    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila As Integer

        fila = Me.ProductoBindingSource.Find("Nom_Producto", TBXBusqueda.Text)
        'agregar consulta de ingreso de valores
        'If CodigoConsulta <> "" And IsNumeric(CodigoConsulta) Then
        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos")
        Else
            Me.ProductoBindingSource.Position = fila
            CbxCliente.Focus()

        End If
    End Sub

    Private Sub BtnConcretar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConcretar.Click
        Dim fila, Pregunta As Integer
        Dim importe As Double

        fila = Me.ProductoBindingSource.Find("Nom_Producto", TBXBusqueda.Text)
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            'lo encontro
            Me.ProductoBindingSource.Position = fila
            Pregunta = MsgBox("Quiere realizar esta venta ", 32 + 1, "Vender")
            If Pregunta = 1 Then
                If Me.ProductoBindingSource.Current("Cantidad") >= Val(TbxCantidad.Text) Then
                    'tabla de venta-------------------------
                    Me.VentasBindingSource.AddNew()
                    Me.VentasBindingSource.Current("Id_Producto") = Me.ProductoBindingSource.Current("Cod_Producto")
                    Me.VentasBindingSource.Current("Cantidad") = Val(TbxCantidad.Text)
                    Me.VentasBindingSource.Current("Cod_Cliente") = Val(CbxCliente.SelectedValue)
                    Me.VentasBindingSource.Current("Cod_Empleado") = Val(CbxEmpleado.SelectedValue)
                    Me.VentasBindingSource.Current("Fecha") = FechaCaptura.Value
                    Me.VentasBindingSource.Current("Factura") = Val(TbxCantidad.Text) * Me.ProductoBindingSource.Current("Precio")
                    Me.VentasBindingSource.EndEdit()
                    Me.VentasTableAdapter.Update(Me.FerreteriaDataSet.Ventas)
                    'cierro y guardo la tabla venta
                    'tabla stock-----------------------------
                    Me.ProductoBindingSource.Current("Cantidad") = Me.ProductoBindingSource.Current("Cantidad") - Val(TbxCantidad.Text)
                    importe = Val(TbxCantidad.Text) * Me.ProductoBindingSource.Current("Precio")
                    MsgBox("La venta ha sido exitosa el importe es: " & importe & " Pesos")

                    'guardo todo y actualizo las tablas
                    Me.ProductoBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)               'guardo todo en la base de datos
                    VentasF.VentasTableAdapter.Fill(VentasF.FerreteriaDataSet.Ventas)  'actualizo el data set del principal

                    Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)
                    Me.VentasTableAdapter.Fill(Me.FerreteriaDataSet.Ventas)

                    'Limpio txtbox------------------------------------------------------------
                    TBXBusqueda.Focus()
                    TBXBusqueda.Text = ""
                    TbxCantidad.Text = ""
                Else
                    MsgBox("No hay suficiente stock" & Me.ProductoBindingSource.Current("Cantidad") & "Unidades")
                End If
            End If


        End If



        '   Dim Pregunta, fila, ConsultaCant As Integer

        '   fila = Me.ProductoBindingSource.Current("Id_Producto")

        '   If fila = -1 Then
        '       MsgBox("El Registro no se encuentra en los campos establecidos")
        '   Else
        '       fila = Me.ProductoBindingSource.Position
        '       Pregunta = MsgBox("Desea vender el articulo " & Me.ProductoBindingSource.Current("Nom_Producto"), 32 + 1, "Vender")
        '       If Pregunta = 1 Then
        '           ConsultaCant = InputBox("Cantidad que desea Vender: ")
        '           If Me.ProductoBindingSource.Current("Cantidad") >= ConsultaCant Then
        '               Me.ProductoBindingSource.Current("Cantidad") = Me.ProductoBindingSource.Current("Cantidad") - ConsultaCant
        '               Me.ProductoBindingSource.Current.EndEdit()
        '               Me.ProductoTableAdapter.Update(Me.FerreteriaDataSet.Producto)
        '               Me.ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)


        '               MsgBox("El producto fue vendido con exito")
        '           Else
        '               MsgBox("El valor es mayor al que hay en stock./n hay: " & Me.ProductoBindingSource.Current("Cantidad"))
        '           End If
        '       End If
        '   End If

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        VentasF.Show()
        Me.Close()

    End Sub

    Private Sub BtnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        Clientes.Show()
        FechaCaptura.Focus()

    End Sub

    Private Sub TbxCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbxCantidad.KeyPress
        e.KeyChar = ChrW(Solo_Numeros(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            CbxEmpleado.Focus()
        End If
    End Sub

    Private Sub ProductoDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductoDataGridView.CellClick
        Dim fila As Integer
        fila = ProductoDataGridView.CurrentCellAddress.Y
        TBXBusqueda.Text = ProductoDataGridView.Item(1, fila).Value()      'pega el seleccionado en otro formulario o en donde quieras la informacion
        TBXBusqueda.Focus()                                              ' hace focus al siguiente del otro formulario
        
    End Sub

    Private Sub ProductoDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductoDataGridView.CellContentClick
        'TBXBusqueda.Text = 
    End Sub

    Private Sub TBXBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBXBusqueda.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            BtnBuscar.Focus()
        End If
    End Sub

    
    Private Sub CbxCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxCliente.SelectedIndexChanged

        FechaCaptura.Focus()

    End Sub

    Private Sub FechaCaptura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaCaptura.ValueChanged
        TbxCantidad.Focus()
    End Sub

    

    Private Sub CbxEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxEmpleado.SelectedIndexChanged
        BtnConcretar.Focus()
        
    End Sub

    Private Sub TBXBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBXBusqueda.TextChanged

    End Sub

End Class