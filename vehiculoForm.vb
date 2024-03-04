Public Class vehiculoForm
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar
    End Sub

    Private Sub Limpiar()
        txtID.Text = "0"
        txtMarca.Clear()
        txtModelo.Clear()
        txtPlaca.Clear()
        txtColor.Clear()
        txtAsientos.Clear()
        txtFabricado.Clear()
        txtPrecio.Clear()
        cboTipo.SelectedIndex = -1
        txtPlaca.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtID.Text = "0" Then
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                If btnImagen.Text = "Seleccionar imagen" Then
                    btnImagen.Text = "\imagenes\default.png"
                End If

                Dim cmd As New OleDb.OleDbCommand("insert into vehiculo(placa,marca,modelo,color,fabricado,asientos,tipo,precio,disponible,foto) values('" & txtPlaca.Text & "','" & txtMarca.Text & "','" & txtModelo.Text & "','" & txtColor.Text & "','" & txtFabricado.Text & "','" & txtAsientos.Text & "','" & cboTipo.Text & "','" & txtPrecio.Text & "','" & ListView1.SelectedItems(0).Text & "','" & btnImagen.Text & "')", Conexion)
                cmd.ExecuteNonQuery()

                LlenarGrid()

            End If
        Else
            If MessageBox.Show("¿Seguro que desea modificar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                Dim cmd As New OleDb.OleDbCommand("update vehiculo Set placa='" & txtPlaca.Text & "',marca='" & txtMarca.Text & "',modelo='" & txtModelo.Text & "',color='" & txtColor.Text & "',fabricado='" & txtFabricado.Text & "',asientos='" & txtAsientos.Text & "',tipo='" & cboTipo.Text & "',precio='" & txtPrecio.Text & "',disponible='" & ListView1.SelectedItems(0).Text & "',foto='" & btnImagen.Text & "'  where id=" & txtID.Text, Conexion)
                cmd.ExecuteNonQuery()

                LlenarGrid()
            End If
        End If
    End Sub

    Private Sub LlenarGrid()
        Dim da As New OleDb.OleDbDataAdapter("select * from vehiculo where marca like'%" & txtBuscar.Text & "%' or modelo like'%" & txtBuscar.Text & "%' or tipo like'%" & txtBuscar.Text & "%' ", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim cmd As New OleDb.OleDbCommand("delete * from vehiculo where id=" & txtID.Text, Conexion)
            cmd.ExecuteNonQuery()

            LlenarGrid()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.RowCount > 0 Then
            txtID.Text = DataGridView1.CurrentRow.Cells("ID").Value
            txtPlaca.Text = DataGridView1.CurrentRow.Cells("PLACA").Value.ToString
            txtMarca.Text = DataGridView1.CurrentRow.Cells("MARCA").Value.ToString
            txtModelo.Text = DataGridView1.CurrentRow.Cells("MODELO").Value.ToString
            txtColor.Text = DataGridView1.CurrentRow.Cells("COLOR").Value.ToString
            txtFabricado.Text = DataGridView1.CurrentRow.Cells("FABRICADO").Value
            txtAsientos.Text = DataGridView1.CurrentRow.Cells("ASIENTOS").Value.ToString
            cboTipo.Text = DataGridView1.CurrentRow.Cells("TIPO").Value.ToString
            txtPrecio.Text = DataGridView1.CurrentRow.Cells("PRECIO").Value
            btnImagen.Text = DataGridView1.CurrentRow.Cells("FOTO").Value.ToString

            If btnImagen.Text.Length > 0 Then
                PictureBox1.Image = Image.FromFile(btnImagen.Text)
            End If


            ListView1.Items(0).Selected = False
            ListView1.Items(1).Selected = False
            If DataGridView1.CurrentRow.Cells("DISPONIBLE").Value.ToString = "SI" Then
                ListView1.Items(0).Selected = True
            Else
                ListView1.Items(1).Selected = True
            End If

        End If
    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        OpenFileDialog1.InitialDirectory = (My.Computer.FileSystem.CurrentDirectory & "\Imagenes")
        OpenFileDialog1.Filter = "Archivos de Imagenes |*.jpg;*.jpeg;*.png;*.bmp"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        btnImagen.Text = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(btnImagen.Text)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        LlenarGrid()
    End Sub

    Private Sub vehiculoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
    End Sub
End Class