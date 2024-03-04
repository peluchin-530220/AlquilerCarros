Imports System.Runtime.InteropServices

Public Class completarForm

    Dim Impuestos As Double = 0

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub btnCompletar_Click(sender As Object, e As EventArgs) Handles btnCompletar.Click
        If txtID.Text = "0" Then
            MessageBox.Show("Seleccione un cliente primero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CInt(lbDias.Text) = "0" Then
            MessageBox.Show("Seleccione la cantidad de días de renta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If MessageBox.Show("¿Seguro que desea completar esta transacción?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim IDRENTA As Integer = 0

                Dim cmd As New OleDb.OleDbCommand("insert into renta(fecha,id_usuario,id_cliente,licencia,nombre,direccion,telefono)  " &
                                                  "values(@FECHA,'" & mainForm.lbIdUsuario.Text & "','" & txtID.Text & "','" & txtLicencia.Text & "','" & txtNombre.Text & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "')", Conexion)
                cmd.Parameters.AddWithValue("@FECHA", OleDb.OleDbType.Date).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm")

                cmd.ExecuteNonQuery()

                Dim da As New OleDb.OleDbDataAdapter("select top 1 ID from renta where id_cliente=" & txtID.Text & " order by ID desc", Conexion)
                Dim ds As New DataSet
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    IDRENTA = ds.Tables(0).Rows(0).Item("ID")
                End If

                cmd = New OleDb.OleDbCommand("insert into renta_detalle(Renta_id,placa,marca,modelo,color,fabricado,asientos,tipo,precio,total_dias,impuestos,total,rentado_desde,rentado_hasta,notas,retornado)  " &
                                             "values('" & IDRENTA & "','" & txtPlaca.Text & "','" & txtMarca.Text & "','" & txtModelo.Text & "','" & txtColor.Text & "','" & CInt(txtFabricado.Text) & "','" & CInt(txtAsientos.Text) & "','" & txtTipo.Text & "','" & CDbl(txtPrecio.Text) & "','" & CInt(lbDias.Text) & "','" & CDbl(lbImpuestos.Text) & "','" & CDbl(lbTotal.Text) & "',@FECHA1,@FECHA2,'" & txtNotas.Text & "','NO')", Conexion)
                cmd.Parameters.AddWithValue("@FECHA1", OleDb.OleDbType.Date).Value = DateTimePicker1.Value.Date & " " & Now.ToString("HH:mm")
                cmd.Parameters.AddWithValue("@FECHA2", OleDb.OleDbType.Date).Value = DateTimePicker2.Value.Date & " " & Now.ToString("HH:mm")

                cmd.ExecuteNonQuery()

                cmd = New OleDb.OleDbCommand("update vehiculo set disponible='NO' where placa='" & txtPlaca.Text & "'", Conexion)
                cmd.ExecuteNonQuery()


                'Insertar montos en la tabla transacciones
                '----------------------------------------------------------------------
                cmd = New OleDb.OleDbCommand("insert into transacciones(Renta_id,fecha,descripcion,subtotal,impuestos,total)  " &
                                             "values('" & IDRENTA & "',@FECHA1,'Renta de vehiculo','" & CDbl(lbSubtotal.Text) & "','" & CDbl(lbImpuestos.Text) & "','" & CDbl(lbTotal.Text) & "')", Conexion)
                cmd.Parameters.AddWithValue("@FECHA1", OleDb.OleDbType.Date).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm")
                cmd.ExecuteNonQuery()

                'Imprimir Factura
                '------------------------------------------------------------------
                FacturaHTML.FechaRenta = DateTime.Now.ToString("yyyy/MM/dd HH:mm")
                FacturaHTML.Factura = IDRENTA
                FacturaHTML.NombreCliente = txtNombre.Text
                FacturaHTML.IDcliente = CInt(txtID.Text)
                FacturaHTML.Empleado = mainForm.lbNombreUsuario.Text
                FacturaHTML.Placa = txtPlaca.Text
                FacturaHTML.Marca = txtMarca.Text
                FacturaHTML.Modelo = txtModelo.Text
                FacturaHTML.Color = txtColor.Text
                FacturaHTML.Fabricado = txtFabricado.Text
                FacturaHTML.Tipo = txtTipo.Text
                FacturaHTML.SubTotal = lbSubtotal.Text
                FacturaHTML.Impuestos = lbImpuestos.Text
                FacturaHTML.Total = lbTotal.Text
                FacturaHTML.Desde = DateTimePicker1.Value.Date & " " & Now.ToString("HH:mm")
                FacturaHTML.Hasta = DateTimePicker2.Value.Date & " " & Now.ToString("HH:mm")
                FacturaHTML.ImpresionFisica()

                Me.Close()
            End If

        End If
    End Sub

    Private Sub CalcularCosto()
        Dim da As New OleDb.OleDbDataAdapter("select * from sistema", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Impuestos = ds.Tables(0).Rows(0).Item("IMPUESTOS")
        End If

        lbSubtotal.Text = (CDbl(txtPrecio.Text) * CInt(lbDias.Text))
        lbImpuestos.Text = ((CDbl(txtPrecio.Text) * CInt(lbDias.Text)) * (Impuestos / 100))
        lbTotal.Text = (CDbl(txtPrecio.Text) * CInt(lbDias.Text)) + ((CDbl(txtPrecio.Text) * CInt(lbDias.Text)) * (Impuestos / 100))
        lbTotal.Text = Format(lbTotal.Text, "standard")


    End Sub

    Private Sub completarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.txtNotas.Handle, &H1501, 0, "**Opcional nombre 2do. Conductor")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        clienteForm.WindowState = FormWindowState.Normal
        clienteForm.StartPosition = FormStartPosition.CenterScreen
        clienteForm.FormBorderStyle = FormBorderStyle.FixedDialog
        clienteForm.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        lbDias.Text = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)

        lbEntrega.Text = DateTimePicker2.Value.Date & " " & Now.ToString("HH:mm")

        CalcularCosto()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        lbDias.Text = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        lbEntrega.Text = DateTimePicker2.Value.Date & " " & Now.ToString("HH:mm")

        CalcularCosto()
    End Sub
End Class