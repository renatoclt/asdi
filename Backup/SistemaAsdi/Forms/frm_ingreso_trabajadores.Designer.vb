<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ingreso_trabajadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ingreso_trabajadores))
        Me.tb_persona_grupo = New System.Windows.Forms.TabControl
        Me.tb_persona_informacion = New System.Windows.Forms.TabPage
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.dtp_fch_nacimiento = New System.Windows.Forms.DateTimePicker
        Me.txt_nro_documento = New System.Windows.Forms.MaskedTextBox
        Me.txt_fono_celular = New System.Windows.Forms.MaskedTextBox
        Me.txt_fono_fijo = New System.Windows.Forms.MaskedTextBox
        Me.gb_controles = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.cbx_tp_documento = New System.Windows.Forms.ComboBox
        Me.txt_direccion = New System.Windows.Forms.TextBox
        Me.txt_ap_materno = New System.Windows.Forms.TextBox
        Me.txt_ap_paterno = New System.Windows.Forms.TextBox
        Me.txt_id_persona = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_nombres = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdb_femenino = New System.Windows.Forms.RadioButton
        Me.rdb_masculino = New System.Windows.Forms.RadioButton
        Me.tb_persona_anexo = New System.Windows.Forms.TabPage
        Me.txt_fono_emergencia = New System.Windows.Forms.MaskedTextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txt_lugar_nacimiento = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txt_contacto_emergencia = New System.Windows.Forms.TextBox
        Me.txt_nombre_madre = New System.Windows.Forms.TextBox
        Me.txt_nombre_padre = New System.Windows.Forms.TextBox
        Me.txt_contraseña = New System.Windows.Forms.TextBox
        Me.txt_usuario = New System.Windows.Forms.TextBox
        Me.txt_correo_institucional = New System.Windows.Forms.TextBox
        Me.txt_correo_personal = New System.Windows.Forms.TextBox
        Me.pbx_foto = New System.Windows.Forms.PictureBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tb_roles = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btn_cancelar_1 = New System.Windows.Forms.Button
        Me.btn_guardar_1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdb_no = New System.Windows.Forms.RadioButton
        Me.rdb_si = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_recibos = New System.Windows.Forms.CheckBox
        Me.chk_super = New System.Windows.Forms.CheckBox
        Me.chk_administrador = New System.Windows.Forms.CheckBox
        Me.chk_notas = New System.Windows.Forms.CheckBox
        Me.chk_matriculas = New System.Windows.Forms.CheckBox
        Me.chk_caja = New System.Windows.Forms.CheckBox
        Me.chk_tramites = New System.Windows.Forms.CheckBox
        Me.tb_persona_grupo.SuspendLayout()
        Me.tb_persona_informacion.SuspendLayout()
        Me.gb_controles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tb_persona_anexo.SuspendLayout()
        CType(Me.pbx_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_roles.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_persona_grupo
        '
        Me.tb_persona_grupo.Controls.Add(Me.tb_persona_informacion)
        Me.tb_persona_grupo.Controls.Add(Me.tb_persona_anexo)
        Me.tb_persona_grupo.Controls.Add(Me.tb_roles)
        Me.tb_persona_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_persona_grupo.Location = New System.Drawing.Point(3, 1)
        Me.tb_persona_grupo.Name = "tb_persona_grupo"
        Me.tb_persona_grupo.SelectedIndex = 0
        Me.tb_persona_grupo.Size = New System.Drawing.Size(627, 437)
        Me.tb_persona_grupo.TabIndex = 2
        '
        'tb_persona_informacion
        '
        Me.tb_persona_informacion.Controls.Add(Me.Label35)
        Me.tb_persona_informacion.Controls.Add(Me.Label21)
        Me.tb_persona_informacion.Controls.Add(Me.Label22)
        Me.tb_persona_informacion.Controls.Add(Me.dtp_fch_nacimiento)
        Me.tb_persona_informacion.Controls.Add(Me.txt_nro_documento)
        Me.tb_persona_informacion.Controls.Add(Me.txt_fono_celular)
        Me.tb_persona_informacion.Controls.Add(Me.txt_fono_fijo)
        Me.tb_persona_informacion.Controls.Add(Me.gb_controles)
        Me.tb_persona_informacion.Controls.Add(Me.cbx_tp_documento)
        Me.tb_persona_informacion.Controls.Add(Me.txt_direccion)
        Me.tb_persona_informacion.Controls.Add(Me.txt_ap_materno)
        Me.tb_persona_informacion.Controls.Add(Me.txt_ap_paterno)
        Me.tb_persona_informacion.Controls.Add(Me.txt_id_persona)
        Me.tb_persona_informacion.Controls.Add(Me.Label18)
        Me.tb_persona_informacion.Controls.Add(Me.Label17)
        Me.tb_persona_informacion.Controls.Add(Me.Label16)
        Me.tb_persona_informacion.Controls.Add(Me.Label15)
        Me.tb_persona_informacion.Controls.Add(Me.Label14)
        Me.tb_persona_informacion.Controls.Add(Me.Label13)
        Me.tb_persona_informacion.Controls.Add(Me.Label9)
        Me.tb_persona_informacion.Controls.Add(Me.Label7)
        Me.tb_persona_informacion.Controls.Add(Me.Label6)
        Me.tb_persona_informacion.Controls.Add(Me.Label5)
        Me.tb_persona_informacion.Controls.Add(Me.Label4)
        Me.tb_persona_informacion.Controls.Add(Me.Label3)
        Me.tb_persona_informacion.Controls.Add(Me.Label2)
        Me.tb_persona_informacion.Controls.Add(Me.Label1)
        Me.tb_persona_informacion.Controls.Add(Me.txt_nombres)
        Me.tb_persona_informacion.Controls.Add(Me.Label19)
        Me.tb_persona_informacion.Controls.Add(Me.Label20)
        Me.tb_persona_informacion.Controls.Add(Me.GroupBox1)
        Me.tb_persona_informacion.Location = New System.Drawing.Point(4, 27)
        Me.tb_persona_informacion.Name = "tb_persona_informacion"
        Me.tb_persona_informacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_persona_informacion.Size = New System.Drawing.Size(619, 406)
        Me.tb_persona_informacion.TabIndex = 0
        Me.tb_persona_informacion.Text = "INFORMACION"
        Me.tb_persona_informacion.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Red
        Me.Label35.Location = New System.Drawing.Point(530, 136)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(15, 18)
        Me.Label35.TabIndex = 35
        Me.Label35.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(531, 204)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 18)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(531, 92)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 18)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "*"
        '
        'dtp_fch_nacimiento
        '
        Me.dtp_fch_nacimiento.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fch_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fch_nacimiento.Location = New System.Drawing.Point(211, 167)
        Me.dtp_fch_nacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fch_nacimiento.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fch_nacimiento.Name = "dtp_fch_nacimiento"
        Me.dtp_fch_nacimiento.Size = New System.Drawing.Size(122, 24)
        Me.dtp_fch_nacimiento.TabIndex = 21
        '
        'txt_nro_documento
        '
        Me.txt_nro_documento.Location = New System.Drawing.Point(339, 204)
        Me.txt_nro_documento.Name = "txt_nro_documento"
        Me.txt_nro_documento.Size = New System.Drawing.Size(189, 24)
        Me.txt_nro_documento.TabIndex = 6
        '
        'txt_fono_celular
        '
        Me.txt_fono_celular.Location = New System.Drawing.Point(346, 334)
        Me.txt_fono_celular.Name = "txt_fono_celular"
        Me.txt_fono_celular.Size = New System.Drawing.Size(115, 24)
        Me.txt_fono_celular.TabIndex = 9
        Me.txt_fono_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_fono_fijo
        '
        Me.txt_fono_fijo.Location = New System.Drawing.Point(115, 334)
        Me.txt_fono_fijo.Name = "txt_fono_fijo"
        Me.txt_fono_fijo.Size = New System.Drawing.Size(116, 24)
        Me.txt_fono_fijo.TabIndex = 8
        Me.txt_fono_fijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gb_controles
        '
        Me.gb_controles.Controls.Add(Me.btn_Cancelar)
        Me.gb_controles.Controls.Add(Me.btn_Guardar)
        Me.gb_controles.Location = New System.Drawing.Point(469, 316)
        Me.gb_controles.Name = "gb_controles"
        Me.gb_controles.Size = New System.Drawing.Size(144, 87)
        Me.gb_controles.TabIndex = 20
        Me.gb_controles.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(75, 18)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(61, 60)
        Me.btn_Cancelar.TabIndex = 11
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(8, 18)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(61, 60)
        Me.btn_Guardar.TabIndex = 10
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'cbx_tp_documento
        '
        Me.cbx_tp_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tp_documento.FormattingEnabled = True
        Me.cbx_tp_documento.Location = New System.Drawing.Point(130, 204)
        Me.cbx_tp_documento.Name = "cbx_tp_documento"
        Me.cbx_tp_documento.Size = New System.Drawing.Size(156, 26)
        Me.cbx_tp_documento.TabIndex = 5
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(115, 254)
        Me.txt_direccion.MaxLength = 200
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(413, 61)
        Me.txt_direccion.TabIndex = 7
        '
        'txt_ap_materno
        '
        Me.txt_ap_materno.Location = New System.Drawing.Point(115, 136)
        Me.txt_ap_materno.MaxLength = 60
        Me.txt_ap_materno.Name = "txt_ap_materno"
        Me.txt_ap_materno.Size = New System.Drawing.Size(413, 24)
        Me.txt_ap_materno.TabIndex = 3
        '
        'txt_ap_paterno
        '
        Me.txt_ap_paterno.Location = New System.Drawing.Point(115, 91)
        Me.txt_ap_paterno.MaxLength = 60
        Me.txt_ap_paterno.Name = "txt_ap_paterno"
        Me.txt_ap_paterno.Size = New System.Drawing.Size(413, 24)
        Me.txt_ap_paterno.TabIndex = 2
        '
        'txt_id_persona
        '
        Me.txt_id_persona.Enabled = False
        Me.txt_id_persona.Location = New System.Drawing.Point(115, 15)
        Me.txt_id_persona.MaxLength = 5
        Me.txt_id_persona.Name = "txt_id_persona"
        Me.txt_id_persona.Size = New System.Drawing.Size(165, 24)
        Me.txt_id_persona.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(241, 334)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 18)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "TELEFONO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 334)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 18)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "TELEFONO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 352)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 18)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "FIJO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(241, 352)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 18)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "CELULAR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "PATERNO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "APELLIDO "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DIRECCION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nro."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "FECHA DE NACIMIENTO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DOCUMENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MATERNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDO "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO"
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(115, 47)
        Me.txt_nombres.MaxLength = 60
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(254, 24)
        Me.txt_nombres.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(368, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 18)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(285, 201)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 18)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb_femenino)
        Me.GroupBox1.Controls.Add(Me.rdb_masculino)
        Me.GroupBox1.Location = New System.Drawing.Point(403, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 75)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEXO"
        '
        'rdb_femenino
        '
        Me.rdb_femenino.AutoSize = True
        Me.rdb_femenino.Location = New System.Drawing.Point(22, 43)
        Me.rdb_femenino.Name = "rdb_femenino"
        Me.rdb_femenino.Size = New System.Drawing.Size(100, 22)
        Me.rdb_femenino.TabIndex = 1
        Me.rdb_femenino.TabStop = True
        Me.rdb_femenino.Text = "Femenino"
        Me.rdb_femenino.UseVisualStyleBackColor = True
        '
        'rdb_masculino
        '
        Me.rdb_masculino.AutoSize = True
        Me.rdb_masculino.Location = New System.Drawing.Point(22, 15)
        Me.rdb_masculino.Name = "rdb_masculino"
        Me.rdb_masculino.Size = New System.Drawing.Size(103, 22)
        Me.rdb_masculino.TabIndex = 0
        Me.rdb_masculino.TabStop = True
        Me.rdb_masculino.Text = "Masculino"
        Me.rdb_masculino.UseVisualStyleBackColor = True
        '
        'tb_persona_anexo
        '
        Me.tb_persona_anexo.Controls.Add(Me.txt_fono_emergencia)
        Me.tb_persona_anexo.Controls.Add(Me.Label34)
        Me.tb_persona_anexo.Controls.Add(Me.txt_lugar_nacimiento)
        Me.tb_persona_anexo.Controls.Add(Me.Label33)
        Me.tb_persona_anexo.Controls.Add(Me.Label32)
        Me.tb_persona_anexo.Controls.Add(Me.txt_contacto_emergencia)
        Me.tb_persona_anexo.Controls.Add(Me.txt_nombre_madre)
        Me.tb_persona_anexo.Controls.Add(Me.txt_nombre_padre)
        Me.tb_persona_anexo.Controls.Add(Me.txt_contraseña)
        Me.tb_persona_anexo.Controls.Add(Me.txt_usuario)
        Me.tb_persona_anexo.Controls.Add(Me.txt_correo_institucional)
        Me.tb_persona_anexo.Controls.Add(Me.txt_correo_personal)
        Me.tb_persona_anexo.Controls.Add(Me.pbx_foto)
        Me.tb_persona_anexo.Controls.Add(Me.Label30)
        Me.tb_persona_anexo.Controls.Add(Me.Label29)
        Me.tb_persona_anexo.Controls.Add(Me.Label28)
        Me.tb_persona_anexo.Controls.Add(Me.Label27)
        Me.tb_persona_anexo.Controls.Add(Me.Label26)
        Me.tb_persona_anexo.Controls.Add(Me.Label25)
        Me.tb_persona_anexo.Controls.Add(Me.Label24)
        Me.tb_persona_anexo.Controls.Add(Me.Label23)
        Me.tb_persona_anexo.Controls.Add(Me.Label12)
        Me.tb_persona_anexo.Controls.Add(Me.Label11)
        Me.tb_persona_anexo.Controls.Add(Me.Label10)
        Me.tb_persona_anexo.Controls.Add(Me.Label8)
        Me.tb_persona_anexo.Location = New System.Drawing.Point(4, 27)
        Me.tb_persona_anexo.Name = "tb_persona_anexo"
        Me.tb_persona_anexo.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_persona_anexo.Size = New System.Drawing.Size(619, 406)
        Me.tb_persona_anexo.TabIndex = 1
        Me.tb_persona_anexo.Text = "INFORMACION ADICIONAL"
        Me.tb_persona_anexo.UseVisualStyleBackColor = True
        '
        'txt_fono_emergencia
        '
        Me.txt_fono_emergencia.Location = New System.Drawing.Point(166, 354)
        Me.txt_fono_emergencia.Mask = "999999999"
        Me.txt_fono_emergencia.Name = "txt_fono_emergencia"
        Me.txt_fono_emergencia.Size = New System.Drawing.Size(261, 24)
        Me.txt_fono_emergencia.TabIndex = 20
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(16, 139)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(110, 18)
        Me.Label34.TabIndex = 36
        Me.Label34.Text = "NACIMIENTO"
        '
        'txt_lugar_nacimiento
        '
        Me.txt_lugar_nacimiento.Location = New System.Drawing.Point(126, 121)
        Me.txt_lugar_nacimiento.MaxLength = 100
        Me.txt_lugar_nacimiento.Name = "txt_lugar_nacimiento"
        Me.txt_lugar_nacimiento.Size = New System.Drawing.Size(487, 24)
        Me.txt_lugar_nacimiento.TabIndex = 16
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(16, 121)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(92, 18)
        Me.Label33.TabIndex = 34
        Me.Label33.Text = "LUGAR DE"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(16, 301)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(118, 18)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = "EMERGENCIA"
        '
        'txt_contacto_emergencia
        '
        Me.txt_contacto_emergencia.Location = New System.Drawing.Point(166, 295)
        Me.txt_contacto_emergencia.MaxLength = 200
        Me.txt_contacto_emergencia.Name = "txt_contacto_emergencia"
        Me.txt_contacto_emergencia.Size = New System.Drawing.Size(266, 24)
        Me.txt_contacto_emergencia.TabIndex = 19
        '
        'txt_nombre_madre
        '
        Me.txt_nombre_madre.Location = New System.Drawing.Point(212, 214)
        Me.txt_nombre_madre.MaxLength = 200
        Me.txt_nombre_madre.Name = "txt_nombre_madre"
        Me.txt_nombre_madre.Size = New System.Drawing.Size(401, 24)
        Me.txt_nombre_madre.TabIndex = 18
        '
        'txt_nombre_padre
        '
        Me.txt_nombre_padre.Location = New System.Drawing.Point(212, 168)
        Me.txt_nombre_padre.MaxLength = 200
        Me.txt_nombre_padre.Name = "txt_nombre_padre"
        Me.txt_nombre_padre.Size = New System.Drawing.Size(401, 24)
        Me.txt_nombre_padre.TabIndex = 17
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(429, 77)
        Me.txt_contraseña.MaxLength = 50
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña.Size = New System.Drawing.Size(184, 24)
        Me.txt_contraseña.TabIndex = 15
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(120, 77)
        Me.txt_usuario.MaxLength = 20
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(184, 24)
        Me.txt_usuario.TabIndex = 14
        '
        'txt_correo_institucional
        '
        Me.txt_correo_institucional.Location = New System.Drawing.Point(424, 17)
        Me.txt_correo_institucional.MaxLength = 100
        Me.txt_correo_institucional.Name = "txt_correo_institucional"
        Me.txt_correo_institucional.Size = New System.Drawing.Size(189, 24)
        Me.txt_correo_institucional.TabIndex = 13
        '
        'txt_correo_personal
        '
        Me.txt_correo_personal.Location = New System.Drawing.Point(120, 17)
        Me.txt_correo_personal.MaxLength = 100
        Me.txt_correo_personal.Name = "txt_correo_personal"
        Me.txt_correo_personal.Size = New System.Drawing.Size(184, 24)
        Me.txt_correo_personal.TabIndex = 12
        '
        'pbx_foto
        '
        Me.pbx_foto.BackColor = System.Drawing.Color.White
        Me.pbx_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_foto.Location = New System.Drawing.Point(459, 255)
        Me.pbx_foto.Name = "pbx_foto"
        Me.pbx_foto.Size = New System.Drawing.Size(130, 136)
        Me.pbx_foto.TabIndex = 24
        Me.pbx_foto.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(399, 255)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(54, 18)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "FOTO"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 375)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(144, 18)
        Me.Label29.TabIndex = 22
        Me.Label29.Text = "DE ENERGENCIA"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 83)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(82, 18)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "USUARIO"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(308, 80)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(121, 18)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "CONTRASEÑA"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(16, 174)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(179, 18)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "NOMBRE DEL PADRE"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 220)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(197, 18)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "NOMBRE DE LA MADRE"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 357)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 18)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "TELEFONO"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 283)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 18)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "CONTACTO DE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(310, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "CORREO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(301, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "INSTITUCIONAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "PERSONAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CORREO"
        '
        'tb_roles
        '
        Me.tb_roles.Controls.Add(Me.GroupBox4)
        Me.tb_roles.Controls.Add(Me.GroupBox3)
        Me.tb_roles.Controls.Add(Me.GroupBox2)
        Me.tb_roles.Location = New System.Drawing.Point(4, 27)
        Me.tb_roles.Name = "tb_roles"
        Me.tb_roles.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_roles.Size = New System.Drawing.Size(619, 406)
        Me.tb_roles.TabIndex = 2
        Me.tb_roles.Text = "PERMISOS"
        Me.tb_roles.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_cancelar_1)
        Me.GroupBox4.Controls.Add(Me.btn_guardar_1)
        Me.GroupBox4.Location = New System.Drawing.Point(470, 317)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(144, 87)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'btn_cancelar_1
        '
        Me.btn_cancelar_1.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_cancelar_1.Location = New System.Drawing.Point(75, 18)
        Me.btn_cancelar_1.Name = "btn_cancelar_1"
        Me.btn_cancelar_1.Size = New System.Drawing.Size(61, 60)
        Me.btn_cancelar_1.TabIndex = 11
        Me.btn_cancelar_1.UseVisualStyleBackColor = True
        '
        'btn_guardar_1
        '
        Me.btn_guardar_1.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_guardar_1.Location = New System.Drawing.Point(8, 18)
        Me.btn_guardar_1.Name = "btn_guardar_1"
        Me.btn_guardar_1.Size = New System.Drawing.Size(61, 60)
        Me.btn_guardar_1.TabIndex = 10
        Me.btn_guardar_1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdb_no)
        Me.GroupBox3.Controls.Add(Me.rdb_si)
        Me.GroupBox3.Location = New System.Drawing.Point(376, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(104, 112)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ACTIVO"
        '
        'rdb_no
        '
        Me.rdb_no.AutoSize = True
        Me.rdb_no.Location = New System.Drawing.Point(27, 57)
        Me.rdb_no.Name = "rdb_no"
        Me.rdb_no.Size = New System.Drawing.Size(51, 22)
        Me.rdb_no.TabIndex = 1
        Me.rdb_no.TabStop = True
        Me.rdb_no.Text = "NO"
        Me.rdb_no.UseVisualStyleBackColor = True
        '
        'rdb_si
        '
        Me.rdb_si.AutoSize = True
        Me.rdb_si.Location = New System.Drawing.Point(27, 28)
        Me.rdb_si.Name = "rdb_si"
        Me.rdb_si.Size = New System.Drawing.Size(41, 22)
        Me.rdb_si.TabIndex = 0
        Me.rdb_si.TabStop = True
        Me.rdb_si.Text = "SI"
        Me.rdb_si.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_recibos)
        Me.GroupBox2.Controls.Add(Me.chk_super)
        Me.GroupBox2.Controls.Add(Me.chk_administrador)
        Me.GroupBox2.Controls.Add(Me.chk_notas)
        Me.GroupBox2.Controls.Add(Me.chk_matriculas)
        Me.GroupBox2.Controls.Add(Me.chk_caja)
        Me.GroupBox2.Controls.Add(Me.chk_tramites)
        Me.GroupBox2.Location = New System.Drawing.Point(79, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 226)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ROLES"
        '
        'chk_recibos
        '
        Me.chk_recibos.AutoSize = True
        Me.chk_recibos.Location = New System.Drawing.Point(23, 136)
        Me.chk_recibos.Name = "chk_recibos"
        Me.chk_recibos.Size = New System.Drawing.Size(255, 22)
        Me.chk_recibos.TabIndex = 6
        Me.chk_recibos.Text = "MODIFICACIÓN DE BOLETAS"
        Me.chk_recibos.UseVisualStyleBackColor = True
        '
        'chk_super
        '
        Me.chk_super.AutoSize = True
        Me.chk_super.Location = New System.Drawing.Point(23, 192)
        Me.chk_super.Name = "chk_super"
        Me.chk_super.Size = New System.Drawing.Size(163, 22)
        Me.chk_super.TabIndex = 5
        Me.chk_super.Text = "SUPER USUARIO"
        Me.chk_super.UseVisualStyleBackColor = True
        '
        'chk_administrador
        '
        Me.chk_administrador.AutoSize = True
        Me.chk_administrador.Location = New System.Drawing.Point(23, 164)
        Me.chk_administrador.Name = "chk_administrador"
        Me.chk_administrador.Size = New System.Drawing.Size(163, 22)
        Me.chk_administrador.TabIndex = 4
        Me.chk_administrador.Text = "ADMINISTRADOR"
        Me.chk_administrador.UseVisualStyleBackColor = True
        '
        'chk_notas
        '
        Me.chk_notas.AutoSize = True
        Me.chk_notas.Location = New System.Drawing.Point(23, 108)
        Me.chk_notas.Name = "chk_notas"
        Me.chk_notas.Size = New System.Drawing.Size(83, 22)
        Me.chk_notas.TabIndex = 3
        Me.chk_notas.Text = "NOTAS"
        Me.chk_notas.UseVisualStyleBackColor = True
        '
        'chk_matriculas
        '
        Me.chk_matriculas.AutoSize = True
        Me.chk_matriculas.Location = New System.Drawing.Point(23, 80)
        Me.chk_matriculas.Name = "chk_matriculas"
        Me.chk_matriculas.Size = New System.Drawing.Size(131, 22)
        Me.chk_matriculas.TabIndex = 2
        Me.chk_matriculas.Text = "MATRICULAS"
        Me.chk_matriculas.UseVisualStyleBackColor = True
        '
        'chk_caja
        '
        Me.chk_caja.AutoSize = True
        Me.chk_caja.Location = New System.Drawing.Point(23, 52)
        Me.chk_caja.Name = "chk_caja"
        Me.chk_caja.Size = New System.Drawing.Size(68, 22)
        Me.chk_caja.TabIndex = 1
        Me.chk_caja.Text = "CAJA"
        Me.chk_caja.UseVisualStyleBackColor = True
        '
        'chk_tramites
        '
        Me.chk_tramites.AutoSize = True
        Me.chk_tramites.Location = New System.Drawing.Point(23, 24)
        Me.chk_tramites.Name = "chk_tramites"
        Me.chk_tramites.Size = New System.Drawing.Size(109, 22)
        Me.chk_tramites.TabIndex = 0
        Me.chk_tramites.Text = "TRÁMITES"
        Me.chk_tramites.UseVisualStyleBackColor = True
        '
        'frm_ingreso_trabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(628, 438)
        Me.Controls.Add(Me.tb_persona_grupo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ingreso_trabajadores"
        Me.Text = "Registro e información de trabajador"
        Me.tb_persona_grupo.ResumeLayout(False)
        Me.tb_persona_informacion.ResumeLayout(False)
        Me.tb_persona_informacion.PerformLayout()
        Me.gb_controles.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tb_persona_anexo.ResumeLayout(False)
        Me.tb_persona_anexo.PerformLayout()
        CType(Me.pbx_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_roles.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tb_persona_grupo As System.Windows.Forms.TabControl
    Friend WithEvents tb_persona_informacion As System.Windows.Forms.TabPage
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtp_fch_nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nro_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fono_celular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fono_fijo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents gb_controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cbx_tp_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_ap_materno As System.Windows.Forms.TextBox
    Friend WithEvents txt_ap_paterno As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_persona As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_femenino As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_masculino As System.Windows.Forms.RadioButton
    Friend WithEvents tb_persona_anexo As System.Windows.Forms.TabPage
    Friend WithEvents txt_fono_emergencia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_lugar_nacimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_contacto_emergencia As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_madre As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_padre As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_correo_institucional As System.Windows.Forms.TextBox
    Friend WithEvents txt_correo_personal As System.Windows.Forms.TextBox
    Friend WithEvents pbx_foto As System.Windows.Forms.PictureBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_roles As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_no As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_si As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_super As System.Windows.Forms.CheckBox
    Friend WithEvents chk_administrador As System.Windows.Forms.CheckBox
    Friend WithEvents chk_notas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_matriculas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_caja As System.Windows.Forms.CheckBox
    Friend WithEvents chk_tramites As System.Windows.Forms.CheckBox
    Friend WithEvents chk_recibos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar_1 As System.Windows.Forms.Button
    Friend WithEvents btn_guardar_1 As System.Windows.Forms.Button
End Class
