Public Class usuarioForm
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar
    End Sub

    Private Sub Limpiar()
        txtID.Text = "0"
        txtNombre.Clear()
        txtUsuario.Clear()
        txtClave.Clear()
        cboTipo.SelectedIndex = -1
        chkClientes.Checked = False
        chkDevoluciones.Checked = False
        chkRentar.Checked = False
        chkReportes.Checked = False
        chkSistema.Checked = False
        chkUsuarios.Checked = False
        chkVehiculos.Checked = False

        txtNombre.Focus()


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtID.Text = "0" Then
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("insert into usuario(nombre,usuario,clave,tipo,REGISTRO_CLIENTES,REGISTRO_VEHICULOS,RENTAR,DEVOLVER,REPORTES,REGISTRO_USUARIOS,SISTEMA) values('" & txtNombre.Text & "','" & txtUsuario.Text & "','" & txtClave.Text & "','" & cboTipo.Text & "','" & chkClientes.CheckState & "','" & chkVehiculos.CheckState & "','" & chkRentar.CheckState & "','" & chkDevoluciones.CheckState & "','" & chkReportes.CheckState & "','" & chkUsuarios.CheckState & "','" & chkSistema.CheckState & "')", Conexion)
                cmd.ExecuteNonQuery()
            End If

            LlenarGrid()
        Else
            If MessageBox.Show("¿Seguro que desea modificar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("update usuario set nombre='" & txtNombre.Text & "',usuario='" & txtUsuario.Text & "',clave='" & txtClave.Text & "',tipo='" & cboTipo.Text & "',REGISTRO_CLIENTES='" & chkClientes.CheckState & "',REGISTRO_VEHICULOS='" & chkVehiculos.CheckState & "',RENTAR='" & chkRentar.CheckState & "',devolver='" & chkDevoluciones.CheckState & "',reportes='" & chkReportes.CheckState & "',registro_usuarios='" & chkUsuarios.CheckState & "',sistema='" & chkSistema.CheckState & "' where id=" & txtID.Text, Conexion)
                cmd.ExecuteNonQuery()
            End If

            LlenarGrid()
        End If
    End Sub

    Private Sub LlenarGrid()
        Dim da As New OleDb.OleDbDataAdapter("select * from usuario where nombre like'%" & txtBuscar.Text & "%'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns("CLAVE").Visible = False
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim cmd As New OleDb.OleDbCommand("delete * from usuario where id=" & txtID.Text, Conexion)
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
            txtNombre.Text = DataGridView1.CurrentRow.Cells("NOMBRE").Value.ToString
            txtUsuario.Text = DataGridView1.CurrentRow.Cells("USUARIO").Value.ToString
            txtClave.Text = DataGridView1.CurrentRow.Cells("CLAVE").Value.ToString
            cboTipo.Text = DataGridView1.CurrentRow.Cells("TIPO").Value.ToString

            chkClientes.Checked = DataGridView1.CurrentRow.Cells("REGISTRO_CLIENTES").Value
            chkDevoluciones.Checked = DataGridView1.CurrentRow.Cells("DEVOLVER").Value
            chkRentar.Checked = DataGridView1.CurrentRow.Cells("RENTAR").Value
            chkReportes.Checked = DataGridView1.CurrentRow.Cells("REPORTES").Value
            chkSistema.Checked = DataGridView1.CurrentRow.Cells("SISTEMA").Value
            chkVehiculos.Checked = DataGridView1.CurrentRow.Cells("REGISTRO_VEHICULOS").Value
            chkUsuarios.Checked = DataGridView1.CurrentRow.Cells("REGISTRO_USUARIOS").Value

        End If
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.Text = "Administrador" Then
            chkClientes.Checked = True
            chkDevoluciones.Checked = True
            chkRentar.Checked = True
            chkUsuarios.Checked = True
            chkReportes.Checked = True
            chkSistema.Checked = True
            chkVehiculos.Checked = True
        Else
            chkClientes.Checked = True
            chkDevoluciones.Checked = True
            chkRentar.Checked = True
            chkUsuarios.Checked = False
            chkReportes.Checked = False
            chkSistema.Checked = False
            chkVehiculos.Checked = False
        End If
    End Sub

    Private Sub usuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
    End Sub
End Class