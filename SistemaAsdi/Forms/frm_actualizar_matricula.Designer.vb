<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_actualizar_matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_actualizar_matricula))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_plan_estudio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbx_periodo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ciclo = New System.Windows.Forms.TextBox()
        Me.txt_tipo_alumno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.cbx_cursos = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha_creacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_codigo_alumno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIdMatricula = New System.Windows.Forms.TextBox()
        Me.txtnomcur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(270, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 18)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "PLAN DE"
        '
        'txt_plan_estudio
        '
        Me.txt_plan_estudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_plan_estudio.Location = New System.Drawing.Point(359, 189)
        Me.txt_plan_estudio.Name = "txt_plan_estudio"
        Me.txt_plan_estudio.ReadOnly = True
        Me.txt_plan_estudio.Size = New System.Drawing.Size(180, 22)
        Me.txt_plan_estudio.TabIndex = 75
        Me.txt_plan_estudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(265, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 18)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "ESTUDIOS"
        '
        'cbx_periodo
        '
        Me.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodo.FormattingEnabled = True
        Me.cbx_periodo.Location = New System.Drawing.Point(359, 145)
        Me.cbx_periodo.Name = "cbx_periodo"
        Me.cbx_periodo.Size = New System.Drawing.Size(180, 24)
        Me.cbx_periodo.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(268, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "MES"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 18)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "CICLO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "TIPO DE"
        '
        'txt_ciclo
        '
        Me.txt_ciclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ciclo.Location = New System.Drawing.Point(165, 188)
        Me.txt_ciclo.Name = "txt_ciclo"
        Me.txt_ciclo.ReadOnly = True
        Me.txt_ciclo.Size = New System.Drawing.Size(1, 22)
        Me.txt_ciclo.TabIndex = 69
        Me.txt_ciclo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_tipo_alumno
        '
        Me.txt_tipo_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipo_alumno.Location = New System.Drawing.Point(98, 146)
        Me.txt_tipo_alumno.Name = "txt_tipo_alumno"
        Me.txt_tipo_alumno.ReadOnly = True
        Me.txt_tipo_alumno.Size = New System.Drawing.Size(161, 22)
        Me.txt_tipo_alumno.TabIndex = 68
        Me.txt_tipo_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "ALUMNO"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(477, 259)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(62, 57)
        Me.btn_Cancelar.TabIndex = 66
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(411, 259)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(60, 57)
        Me.btn_Guardar.TabIndex = 65
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.SistemaAsdi.My.Resources.Resources.Search
        Me.btn_buscar.Location = New System.Drawing.Point(477, 84)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(62, 51)
        Me.btn_buscar.TabIndex = 64
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'cbx_cursos
        '
        Me.cbx_cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_cursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_cursos.FormattingEnabled = True
        Me.cbx_cursos.Location = New System.Drawing.Point(98, 229)
        Me.cbx_cursos.Name = "cbx_cursos"
        Me.cbx_cursos.Size = New System.Drawing.Size(441, 24)
        Me.cbx_cursos.TabIndex = 63
        '
        'dtp_fecha_creacion
        '
        Me.dtp_fecha_creacion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_fecha_creacion.Enabled = False
        Me.dtp_fecha_creacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_creacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_creacion.Location = New System.Drawing.Point(319, 56)
        Me.dtp_fecha_creacion.Name = "dtp_fecha_creacion"
        Me.dtp_fecha_creacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtp_fecha_creacion.ShowUpDown = True
        Me.dtp_fecha_creacion.Size = New System.Drawing.Size(132, 24)
        Me.dtp_fecha_creacion.TabIndex = 62
        '
        'txt_codigo_alumno
        '
        Me.txt_codigo_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_alumno.Location = New System.Drawing.Point(116, 54)
        Me.txt_codigo_alumno.Name = "txt_codigo_alumno"
        Me.txt_codigo_alumno.ReadOnly = True
        Me.txt_codigo_alumno.Size = New System.Drawing.Size(117, 22)
        Me.txt_codigo_alumno.TabIndex = 61
        Me.txt_codigo_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(98, 103)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(373, 22)
        Me.txt_nombre.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "ALUMNO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "FECHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "GRUPO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "CODIGO DE"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matricula.Location = New System.Drawing.Point(148, 14)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(209, 18)
        Me.lbl_matricula.TabIndex = 54
        Me.lbl_matricula.Text = "MODIFICAR MATRICULAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "ALUMNO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 18)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "ID MATRICULA"
        '
        'TxtIdMatricula
        '
        Me.TxtIdMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdMatricula.Location = New System.Drawing.Point(151, 272)
        Me.TxtIdMatricula.Name = "TxtIdMatricula"
        Me.TxtIdMatricula.ReadOnly = True
        Me.TxtIdMatricula.Size = New System.Drawing.Size(161, 22)
        Me.TxtIdMatricula.TabIndex = 77
        Me.TxtIdMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnomcur
        '
        Me.txtnomcur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcur.Location = New System.Drawing.Point(98, 188)
        Me.txtnomcur.Name = "txtnomcur"
        Me.txtnomcur.ReadOnly = True
        Me.txtnomcur.Size = New System.Drawing.Size(117, 22)
        Me.txtnomcur.TabIndex = 79
        Me.txtnomcur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_actualizar_matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 332)
        Me.Controls.Add(Me.txtnomcur)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtIdMatricula)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_plan_estudio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbx_periodo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_ciclo)
        Me.Controls.Add(Me.txt_tipo_alumno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cbx_cursos)
        Me.Controls.Add(Me.dtp_fecha_creacion)
        Me.Controls.Add(Me.txt_codigo_alumno)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_matricula)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_actualizar_matricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Matricula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_plan_estudio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbx_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_ciclo As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_alumno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents cbx_cursos As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha_creacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_codigo_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtIdMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtnomcur As System.Windows.Forms.TextBox
End Class
