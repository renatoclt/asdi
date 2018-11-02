<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_curso_grupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_curso_grupo))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbx_periodo = New System.Windows.Forms.ComboBox
        Me.cbx_plan_estudio = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg_curso_ofertado = New System.Windows.Forms.DataGridView
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
        Me.cbx_horario = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dg_curso_grupo = New System.Windows.Forms.DataGridView
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.txt_matriculados = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_nombre_grupo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbx_aula = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbx_profesor = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_horario = New System.Windows.Forms.TextBox
        Me.txt_curso_ofertado = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.lbl_grupos = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dg_curso_ofertado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.dg_curso_grupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(806, 510)
        Me.SplitContainer1.SplitterDistance = 277
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbx_periodo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbx_plan_estudio)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dg_curso_ofertado)
        Me.SplitContainer2.Size = New System.Drawing.Size(277, 510)
        Me.SplitContainer2.SplitterDistance = 122
        Me.SplitContainer2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "LISTA DE CICLOS APERTURADOS"
        '
        'cbx_periodo
        '
        Me.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodo.FormattingEnabled = True
        Me.cbx_periodo.Location = New System.Drawing.Point(16, 72)
        Me.cbx_periodo.Name = "cbx_periodo"
        Me.cbx_periodo.Size = New System.Drawing.Size(234, 23)
        Me.cbx_periodo.TabIndex = 7
        '
        'cbx_plan_estudio
        '
        Me.cbx_plan_estudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_plan_estudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_plan_estudio.FormattingEnabled = True
        Me.cbx_plan_estudio.Location = New System.Drawing.Point(16, 22)
        Me.cbx_plan_estudio.Name = "cbx_plan_estudio"
        Me.cbx_plan_estudio.Size = New System.Drawing.Size(234, 23)
        Me.cbx_plan_estudio.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PERIODO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PLAN DE ESTUDIOS"
        '
        'dg_curso_ofertado
        '
        Me.dg_curso_ofertado.AllowUserToAddRows = False
        Me.dg_curso_ofertado.AllowUserToDeleteRows = False
        Me.dg_curso_ofertado.AllowUserToResizeRows = False
        Me.dg_curso_ofertado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_curso_ofertado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_curso_ofertado.Location = New System.Drawing.Point(0, 0)
        Me.dg_curso_ofertado.MultiSelect = False
        Me.dg_curso_ofertado.Name = "dg_curso_ofertado"
        Me.dg_curso_ofertado.ReadOnly = True
        Me.dg_curso_ofertado.RowHeadersVisible = False
        Me.dg_curso_ofertado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_curso_ofertado.Size = New System.Drawing.Size(277, 384)
        Me.dg_curso_ofertado.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(525, 510)
        Me.SplitContainer3.SplitterDistance = 268
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.cbx_horario)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.dg_curso_grupo)
        Me.SplitContainer5.Size = New System.Drawing.Size(525, 268)
        Me.SplitContainer5.SplitterDistance = 35
        Me.SplitContainer5.TabIndex = 2
        '
        'cbx_horario
        '
        Me.cbx_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_horario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_horario.FormattingEnabled = True
        Me.cbx_horario.Location = New System.Drawing.Point(165, 5)
        Me.cbx_horario.Name = "cbx_horario"
        Me.cbx_horario.Size = New System.Drawing.Size(277, 23)
        Me.cbx_horario.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "HORARIO"
        '
        'dg_curso_grupo
        '
        Me.dg_curso_grupo.AllowUserToAddRows = False
        Me.dg_curso_grupo.AllowUserToDeleteRows = False
        Me.dg_curso_grupo.AllowUserToOrderColumns = True
        Me.dg_curso_grupo.AllowUserToResizeRows = False
        Me.dg_curso_grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_curso_grupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_curso_grupo.Location = New System.Drawing.Point(0, 0)
        Me.dg_curso_grupo.Name = "dg_curso_grupo"
        Me.dg_curso_grupo.ReadOnly = True
        Me.dg_curso_grupo.RowHeadersVisible = False
        Me.dg_curso_grupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_curso_grupo.Size = New System.Drawing.Size(525, 229)
        Me.dg_curso_grupo.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.txt_matriculados)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer4.Panel1.Controls.Add(Me.txt_nombre_grupo)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer4.Panel1.Controls.Add(Me.cbx_aula)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer4.Panel1.Controls.Add(Me.cbx_profesor)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer4.Panel1.Controls.Add(Me.txt_horario)
        Me.SplitContainer4.Panel1.Controls.Add(Me.txt_curso_ofertado)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label7)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.btn_Borrar)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btn_Guardar)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btn_Editar)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btn_Agregar)
        Me.SplitContainer4.Size = New System.Drawing.Size(525, 238)
        Me.SplitContainer4.SplitterDistance = 392
        Me.SplitContainer4.TabIndex = 0
        '
        'txt_matriculados
        '
        Me.txt_matriculados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matriculados.Location = New System.Drawing.Point(145, 206)
        Me.txt_matriculados.Name = "txt_matriculados"
        Me.txt_matriculados.ReadOnly = True
        Me.txt_matriculados.Size = New System.Drawing.Size(235, 21)
        Me.txt_matriculados.TabIndex = 23
        Me.txt_matriculados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 18)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "MATRICULADOS"
        '
        'txt_nombre_grupo
        '
        Me.txt_nombre_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_grupo.Location = New System.Drawing.Point(114, 169)
        Me.txt_nombre_grupo.Name = "txt_nombre_grupo"
        Me.txt_nombre_grupo.Size = New System.Drawing.Size(266, 21)
        Me.txt_nombre_grupo.TabIndex = 21
        Me.txt_nombre_grupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 18)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "DEL GRUPO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "NOMBRE"
        '
        'cbx_aula
        '
        Me.cbx_aula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_aula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_aula.FormattingEnabled = True
        Me.cbx_aula.Location = New System.Drawing.Point(114, 129)
        Me.cbx_aula.Name = "cbx_aula"
        Me.cbx_aula.Size = New System.Drawing.Size(266, 23)
        Me.cbx_aula.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(58, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "AULA"
        '
        'cbx_profesor
        '
        Me.cbx_profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_profesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_profesor.FormattingEnabled = True
        Me.cbx_profesor.Location = New System.Drawing.Point(114, 95)
        Me.cbx_profesor.Name = "cbx_profesor"
        Me.cbx_profesor.Size = New System.Drawing.Size(266, 23)
        Me.cbx_profesor.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "PROFESOR"
        '
        'txt_horario
        '
        Me.txt_horario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_horario.Location = New System.Drawing.Point(114, 62)
        Me.txt_horario.Name = "txt_horario"
        Me.txt_horario.ReadOnly = True
        Me.txt_horario.Size = New System.Drawing.Size(267, 21)
        Me.txt_horario.TabIndex = 14
        Me.txt_horario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_curso_ofertado
        '
        Me.txt_curso_ofertado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_curso_ofertado.Location = New System.Drawing.Point(124, 28)
        Me.txt_curso_ofertado.Name = "txt_curso_ofertado"
        Me.txt_curso_ofertado.ReadOnly = True
        Me.txt_curso_ofertado.Size = New System.Drawing.Size(257, 21)
        Me.txt_curso_ofertado.TabIndex = 13
        Me.txt_curso_ofertado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(167, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "GRUPO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CICLO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "HORARIO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "APERTURADO"
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Image = Global.SistemaAsdi.My.Resources.Resources.Delete
        Me.btn_Borrar.Location = New System.Drawing.Point(65, 104)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(61, 47)
        Me.btn_Borrar.TabIndex = 38
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(65, 157)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(61, 50)
        Me.btn_Cancelar.TabIndex = 37
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(4, 157)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(55, 50)
        Me.btn_Guardar.TabIndex = 36
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = Global.SistemaAsdi.My.Resources.Resources.Pencil
        Me.btn_Editar.Location = New System.Drawing.Point(3, 104)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(56, 47)
        Me.btn_Editar.TabIndex = 35
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Image = Global.SistemaAsdi.My.Resources.Resources.__1
        Me.btn_Agregar.Location = New System.Drawing.Point(3, 51)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(123, 47)
        Me.btn_Agregar.TabIndex = 34
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_grupos
        '
        Me.lbl_grupos.AutoSize = True
        Me.lbl_grupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grupos.Location = New System.Drawing.Point(225, 3)
        Me.lbl_grupos.Name = "lbl_grupos"
        Me.lbl_grupos.Size = New System.Drawing.Size(353, 18)
        Me.lbl_grupos.TabIndex = 4
        Me.lbl_grupos.Text = "APERTURA DE GRUPOS PARA CADA CICLO"
        '
        'frm_curso_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(809, 541)
        Me.Controls.Add(Me.lbl_grupos)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_curso_grupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Apertura de Grupos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dg_curso_ofertado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.dg_curso_grupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbl_grupos As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents cbx_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_plan_estudio As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg_curso_ofertado As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents cbx_horario As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dg_curso_grupo As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents txt_curso_ofertado As System.Windows.Forms.TextBox
    Friend WithEvents txt_horario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbx_aula As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbx_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombre_grupo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_matriculados As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
