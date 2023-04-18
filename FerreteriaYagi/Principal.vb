Public Class Principal

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click
        Articulos.Show()
        Me.Visible = False
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End

    End Sub

    Private Sub BtnVender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVender.Click
        VentasF.Show()
        Me.Visible = False
    End Sub

    Private Sub BtnCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Proovedores.Show()
        Me.Visible = False
    End Sub

    Private Sub BtnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        Clientes.Show()

    End Sub

    Private Sub BtnProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedor.Click
        Proovedores.Show()
        Me.Hide()

    End Sub

    Private Sub ArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticuloToolStripMenuItem.Click
        AgregarP.Show()
        Me.Hide()


    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        AgregarC.Show()
        Me.Hide()

    End Sub

    Private Sub AgregarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProveedorToolStripMenuItem.Click
        Proovedores.Show()
        Me.Hide()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End

    End Sub

    Private Sub AcercaDeFerreteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeFerreteriaToolStripMenuItem.Click
        Acerca_de_Ferreteria.Show()
        Me.Hide()
    End Sub

    Private Sub ConcretarVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConcretarVentaToolStripMenuItem.Click
        Transaccion.Show()
        Me.Hide()

    End Sub
End Class
