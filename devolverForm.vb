Public Class devolverForm

    Public Desde As DateTime
    Dim TiempoExtra As Double = 0

    Dim Impuestos As Double = 0

    Private Sub btnCompletar_Click(sender As Object, e As EventArgs) Handles btnCompletar.Click
        If MessageBox.Show("Seguro que desea proceder con esta devolución?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Dim cmd As New OleDb.OleDbCommand("insert into devoluciones (renta_id,id_cliente,fecha_entrega,retraso_horas,cargo_mora) " &
                                                          "values('" & lbIDrenta.Text & "','" & txtID.Text & "',@FECHA,'" & TiempoExtra & "','" & CDbl(txtTotal.Text) & "')", Conexion)

            cmd.Parameters.AddWithValue("@FECHA", OleDb.OleDbType.Date).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm")
            cmd.ExecuteNonQuery()


            cmd = New OleDb.OleDbCommand("update renta_detalle set retornado='SI' where renta_id=" & lbIDrenta.Text, Conexion)
            cmd.ExecuteNonQuery()

            cmd = New OleDb.OleDbCommand("update vehiculo set disponible='SI' where placa='" & txtPlaca.Text & "'", Conexion)
            cmd.ExecuteNonQuery()

            'Insertar montos en la tabla transacciones
            '-------------------------------------------------------------
            cmd = New OleDb.OleDbCommand("insert into transacciones(Renta_id,fecha,descripcion,subtotal,impuestos,total)  " &
                                             "values('" & lbIDrenta.Text & "',@FECHA1,'Devolucion de vehiculo','" & CDbl(txtAdicional.Text) & "','" & CDbl(txtImpuestos.Text) & "','" & CDbl(txtTotal.Text) & "')", Conexion)
            cmd.Parameters.AddWithValue("@FECHA1", OleDb.OleDbType.Date).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm")
            cmd.ExecuteNonQuery()



            Me.Close()

        End If
    End Sub


    Public Sub CalcularCosto()
        'Si la cantidad de horas extras es mayor a 6, se cobrará el dia completo
        '-------------------------------------------------------------------------------

        Dim Hasta As DateTime

        Dim da As New OleDb.OleDbDataAdapter("select * from sistema", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Impuestos = ds.Tables(0).Rows(0).Item("IMPUESTOS")
        End If

        Hasta = DateTime.Now.ToString("yyyy/MM/dd HH:mm")

        TiempoExtra = DateDiff(DateInterval.Hour, Desde, Hasta)

        If TiempoExtra > 1 And TiempoExtra < 6 Then
            lbRetraso.Text = TiempoExtra & " Horas"

            txtAdicional.Text = Format((CDbl(txtPrecio.Text) / 24) * TiempoExtra, "standard")
            txtImpuestos.Text = Format(CDbl(txtAdicional.Text) * (Impuestos / 100), "standard")
            txtTotal.Text = Format(CDbl(txtAdicional.Text) + CDbl(txtImpuestos.Text), "standard")
        End If


        If TiempoExtra > 5 And TiempoExtra < 24 Then
            lbRetraso.Text = TiempoExtra & " Horas"

            txtAdicional.Text = Format((CDbl(txtPrecio.Text)), "standard")
            txtImpuestos.Text = Format(CDbl(txtPrecio.Text) * (Impuestos / 100), "standard")
            txtTotal.Text = Format(CDbl(txtAdicional.Text) + CDbl(txtImpuestos.Text), "standard")
        End If

        If TiempoExtra > 24 Then
            lbRetraso.Text = TiempoExtra & " Horas"

            Dim CantidadDias As Double = TiempoExtra / 24


            'Funcion para dividir la cantidad en dos partes, antes y después del punto, enteros y fracciones
            Dim Numero As String = CantidadDias.ToString("N2")
            Dim output As String() = Numero.Split(".".ToCharArray())

            Dim salidaDias As String = output(0)
            Dim SalidaHoras As String = output(1)

            salidaDias = (Convert.ToInt64(salidaDias)) * 24
            SalidaHoras = TiempoExtra - salidaDias

            If SalidaHoras > 5 Then
                txtAdicional.Text = Format(CDbl(txtPrecio.Text) * ((salidaDias / 24) + 1), "standard")
                txtImpuestos.Text = Format(CDbl(txtAdicional.Text) * (Impuestos / 100), "standard")
                txtTotal.Text = Format(CDbl(txtAdicional.Text) + CDbl(txtImpuestos.Text), "standard")
            Else
                txtAdicional.Text = Format((CDbl(txtPrecio.Text) / 24) * TiempoExtra, "standard")
                txtImpuestos.Text = Format(CDbl(txtAdicional.Text) * (Impuestos / 100), "standard")
                txtTotal.Text = Format(CDbl(txtAdicional.Text) + CDbl(txtImpuestos.Text), "standard")
            End If

        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        consultaRentados.Show()
    End Sub

    Private Sub devolverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class