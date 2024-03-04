<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devolverForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(devolverForm))
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtImpuestos = New System.Windows.Forms.TextBox()
        Me.lbIDrenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdicional = New System.Windows.Forms.TextBox()
        Me.lbRetraso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbEntrega = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAsientos = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFabricado = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCompletar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLicencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(206, 369)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(132, 26)
        Me.txtTotal.TabIndex = 194
        Me.txtTotal.Text = "0"
        '
        'txtImpuestos
        '
        Me.txtImpuestos.BackColor = System.Drawing.Color.White
        Me.txtImpuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestos.Location = New System.Drawing.Point(206, 340)
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.Size = New System.Drawing.Size(132, 26)
        Me.txtImpuestos.TabIndex = 193
        Me.txtImpuestos.Text = "0"
        '
        'lbIDrenta
        '
        Me.lbIDrenta.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lbIDrenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDrenta.ForeColor = System.Drawing.Color.Red
        Me.lbIDrenta.Location = New System.Drawing.Point(502, 330)
        Me.lbIDrenta.Name = "lbIDrenta"
        Me.lbIDrenta.ReadOnly = True
        Me.lbIDrenta.Size = New System.Drawing.Size(164, 26)
        Me.lbIDrenta.TabIndex = 192
        Me.lbIDrenta.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(414, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "RENTA #"
        '
        'txtAdicional
        '
        Me.txtAdicional.BackColor = System.Drawing.Color.White
        Me.txtAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdicional.Location = New System.Drawing.Point(206, 312)
        Me.txtAdicional.Name = "txtAdicional"
        Me.txtAdicional.Size = New System.Drawing.Size(132, 26)
        Me.txtAdicional.TabIndex = 190
        Me.txtAdicional.Text = "0"
        '
        'lbRetraso
        '
        Me.lbRetraso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbRetraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRetraso.ForeColor = System.Drawing.Color.Red
        Me.lbRetraso.Location = New System.Drawing.Point(183, 257)
        Me.lbRetraso.Name = "lbRetraso"
        Me.lbRetraso.Size = New System.Drawing.Size(155, 24)
        Me.lbRetraso.TabIndex = 189
        Me.lbRetraso.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(35, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "Retraso"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(37, 316)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(151, 21)
        Me.Label24.TabIndex = 187
        Me.Label24.Text = "Cargos adicionales"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(37, 341)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 21)
        Me.Label22.TabIndex = 186
        Me.Label22.Text = "Impuestos:"
        '
        'lbEntrega
        '
        Me.lbEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntrega.ForeColor = System.Drawing.Color.Green
        Me.lbEntrega.Location = New System.Drawing.Point(183, 230)
        Me.lbEntrega.Name = "lbEntrega"
        Me.lbEntrega.Size = New System.Drawing.Size(155, 24)
        Me.lbEntrega.TabIndex = 185
        Me.lbEntrega.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(35, 230)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(139, 20)
        Me.Label20.TabIndex = 184
        Me.Label20.Text = "Fecha de entrega:"
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTipo.Location = New System.Drawing.Point(502, 213)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(164, 26)
        Me.txtTipo.TabIndex = 183
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(502, 248)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(164, 26)
        Me.txtPrecio.TabIndex = 179
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(412, 251)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 20)
        Me.Label16.TabIndex = 182
        Me.Label16.Text = "Precio"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(412, 216)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 20)
        Me.Label17.TabIndex = 181
        Me.Label17.Text = "Tipo"
        '
        'txtAsientos
        '
        Me.txtAsientos.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtAsientos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAsientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsientos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAsientos.Location = New System.Drawing.Point(502, 181)
        Me.txtAsientos.Name = "txtAsientos"
        Me.txtAsientos.ReadOnly = True
        Me.txtAsientos.Size = New System.Drawing.Size(164, 26)
        Me.txtAsientos.TabIndex = 178
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(412, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 20)
        Me.Label18.TabIndex = 180
        Me.Label18.Text = "Asientos"
        '
        'txtFabricado
        '
        Me.txtFabricado.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtFabricado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFabricado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFabricado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFabricado.Location = New System.Drawing.Point(502, 149)
        Me.txtFabricado.Name = "txtFabricado"
        Me.txtFabricado.ReadOnly = True
        Me.txtFabricado.Size = New System.Drawing.Size(164, 26)
        Me.txtFabricado.TabIndex = 172
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(412, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 20)
        Me.Label11.TabIndex = 177
        Me.Label11.Text = "Año"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtColor.Location = New System.Drawing.Point(502, 117)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(164, 26)
        Me.txtColor.TabIndex = 171
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(412, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 20)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = "Color"
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModelo.Location = New System.Drawing.Point(502, 85)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(164, 26)
        Me.txtModelo.TabIndex = 170
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(412, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 20)
        Me.Label13.TabIndex = 175
        Me.Label13.Text = "Modelo"
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMarca.Location = New System.Drawing.Point(502, 53)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(164, 26)
        Me.txtMarca.TabIndex = 169
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(414, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 20)
        Me.Label14.TabIndex = 174
        Me.Label14.Text = "Marca"
        '
        'txtPlaca
        '
        Me.txtPlaca.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlaca.Location = New System.Drawing.Point(502, 21)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.ReadOnly = True
        Me.txtPlaca.Size = New System.Drawing.Size(164, 26)
        Me.txtPlaca.TabIndex = 168
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(414, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 20)
        Me.Label15.TabIndex = 173
        Me.Label15.Text = "Placa"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(231, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscar.TabIndex = 167
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnCompletar
        '
        Me.btnCompletar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompletar.Image = CType(resources.GetObject("btnCompletar.Image"), System.Drawing.Image)
        Me.btnCompletar.Location = New System.Drawing.Point(41, 406)
        Me.btnCompletar.Name = "btnCompletar"
        Me.btnCompletar.Size = New System.Drawing.Size(283, 63)
        Me.btnCompletar.TabIndex = 166
        Me.btnCompletar.Text = "Completar devolución"
        Me.btnCompletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompletar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 24)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Total a pagar:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(125, 181)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(213, 26)
        Me.txtTelefono.TabIndex = 164
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "Telefono"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDireccion.Location = New System.Drawing.Point(125, 120)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(213, 58)
        Me.txtDireccion.TabIndex = 162
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Direccion"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(125, 88)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(213, 26)
        Me.txtNombre.TabIndex = 160
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Cliente"
        '
        'txtLicencia
        '
        Me.txtLicencia.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtLicencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicencia.Location = New System.Drawing.Point(125, 56)
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.ReadOnly = True
        Me.txtLicencia.Size = New System.Drawing.Size(213, 26)
        Me.txtLicencia.TabIndex = 158
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Licencia #"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(125, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 26)
        Me.txtID.TabIndex = 156
        Me.txtID.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Id cliente"
        '
        'devolverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(711, 507)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtImpuestos)
        Me.Controls.Add(Me.lbIDrenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAdicional)
        Me.Controls.Add(Me.lbRetraso)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lbEntrega)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtAsientos)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtFabricado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCompletar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLicencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "devolverForm"
        Me.Text = "devolverForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtImpuestos As TextBox
    Friend WithEvents lbIDrenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAdicional As TextBox
    Friend WithEvents lbRetraso As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbEntrega As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtAsientos As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtFabricado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCompletar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLicencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
End Class
