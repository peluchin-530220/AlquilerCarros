Public Class clienteForm
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar
    End Sub
    Private Sub Limpiar()
        txtID.Text = "0"
        txtLicencia.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtLicencia.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtID.Text = "0" Then
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                Dim cmd As New OleDb.OleDbCommand("insert into cliente(licencia_no,nombre,direccion,telefono) values('" & txtLicencia.Text & "','" & txtNombre.Text & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "')", Conexion)
                cmd.ExecuteNonQuery()

                LlenarGrid()

            End If
        Else
            If MessageBox.Show("¿Seguro que desea modificar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                Dim cmd As New OleDb.OleDbCommand("update cliente set licencia_no='" & txtLicencia.Text & "',nombre='" & txtNombre.Text & "',direccion='" & txtDireccion.Text & "',telefono='" & txtTelefono.Text & "' where id=" & txtID.Text, Conexion)
                cmd.ExecuteNonQuery()

                LlenarGrid()
            End If
        End If
    End Sub

    Private Sub LlenarGrid()
        Dim da As New OleDb.OleDbDataAdapter("select * from cliente where nombre like'%" & txtBuscar.Text & "%'", Conexion)
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
            Dim cmd As New OleDb.OleDbCommand("delete * from cliente where id=" & txtID.Text, Conexion)
            cmd.ExecuteNonQuery()

            LlenarGrid()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        LlenarGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.RowCount > 0 Then
            txtID.Text = DataGridView1.CurrentRow.Cells("ID").Value
            txtLicencia.Text = DataGridView1.CurrentRow.Cells("LICENCIA_NO").Value.ToString
            txtNombre.Text = DataGridView1.CurrentRow.Cells("NOMBRE").Value.ToString
            txtDireccion.Text = DataGridView1.CurrentRow.Cells("DIRECCION").Value.ToString
            txtTelefono.Text = DataGridView1.CurrentRow.Cells("TELEFONO").Value.ToString

        End If
    End Sub

    Private Sub clienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        completarForm.txtID.Text = txtID.Text
        completarForm.txtNombre.Text = txtNombre.Text
        completarForm.txtLicencia.Text = txtLicencia.Text
        completarForm.txtDireccion.Text = txtDireccion.Text
        completarForm.txtTelefono.Text = txtTelefono.Text

        Me.Hide()
    End Sub
End Class