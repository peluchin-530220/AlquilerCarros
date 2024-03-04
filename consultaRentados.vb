Public Class consultaRentados
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        llenargrid
    End Sub

    Private Sub LlenarGrid()
        Dim da As New OleDb.OleDbDataAdapter("select renta.id,renta.id_cliente,renta.licencia,renta.nombre,renta.direccion,renta.telefono,renta_detalle.placa,renta_detalle.marca,renta_detalle.modelo,renta_detalle.color,renta_detalle.fabricado,renta_detalle.asientos,renta_detalle.tipo,renta_detalle.precio,renta_detalle.total,renta_detalle.rentado_desde,renta_detalle.rentado_hasta  " &
                                             "from renta_detalle inner join renta on renta_detalle.renta_id=renta.id where renta_detalle.retornado='NO' and (renta.nombre like'%" & txtBuscar.Text & "%' or (marca & ' ' & modelo & ' ' & fabricado) like'%" & txtBuscar.Text & "%')", Conexion)

        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If DataGridView1.Rows.Count > 0 Then
            devolverForm.txtImpuestos.Text = "0"
            devolverForm.txtAdicional.Text = "0"


            devolverForm.lbIDrenta.Text = DataGridView1.CurrentRow.Cells("ID").Value
            devolverForm.txtID.Text = DataGridView1.CurrentRow.Cells("ID_CLIENTE").Value
            devolverForm.txtNombre.Text = DataGridView1.CurrentRow.Cells("NOMBRE").Value
            devolverForm.txtLicencia.Text = DataGridView1.CurrentRow.Cells("LICENCIA").Value
            devolverForm.txtDireccion.Text = DataGridView1.CurrentRow.Cells("DIRECCION").Value
            devolverForm.txtTelefono.Text = DataGridView1.CurrentRow.Cells("TELEFONO").Value
            devolverForm.txtPlaca.Text = DataGridView1.CurrentRow.Cells("PLACA").Value
            devolverForm.txtMarca.Text = DataGridView1.CurrentRow.Cells("MARCA").Value
            devolverForm.txtModelo.Text = DataGridView1.CurrentRow.Cells("MODELO").Value
            devolverForm.txtColor.Text = DataGridView1.CurrentRow.Cells("COLOR").Value
            devolverForm.txtFabricado.Text = DataGridView1.CurrentRow.Cells("FABRICADO").Value
            devolverForm.txtAsientos.Text = DataGridView1.CurrentRow.Cells("ASIENTOS").Value
            devolverForm.txtPrecio.Text = DataGridView1.CurrentRow.Cells("PRECIO").Value
            devolverForm.txtTipo.Text = DataGridView1.CurrentRow.Cells("TIPO").Value
            devolverForm.Desde = DataGridView1.CurrentRow.Cells("RENTADO_HASTA").Value
            devolverForm.lbEntrega.Text = DataGridView1.CurrentRow.Cells("RENTADO_HASTA").Value

            devolverForm.CalcularCosto()
            Me.Hide()
        End If

    End Sub

    Private Sub consultarRentados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
    End Sub
End Class