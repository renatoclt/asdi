<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transferencia_matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_transferencia_matricula))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnomcur = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_plan_estudio = New System.Windows.Forms.TextBox()
        Me.cbx_periodo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ciclo = New System.Windows.Forms.TextBox()
        Me.txt_tipo_alumno = New System.Windows.Forms.TextBox()
        Me.cbx_cursos = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha_creacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_codigo_alumno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.txtnom_t = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_idmat = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnomcur)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_plan_estudio)
        Me.GroupBox1.Controls.Add(Me.cbx_periodo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_ciclo)
        Me.GroupBox1.Controls.Add(Me.txt_tipo_alumno)
        Me.GroupBox1.Controls.Add(Me.cbx_cursos)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_creacion)
        Me.GroupBox1.Controls.Add(Me.txt_codigo_alumno)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 185)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'txtnomcur
        '
        Me.txtnomcur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcur.Location = New System.Drawing.Point(101, 100)
        Me.txtnomcur.Name = "txtnomcur"
        Me.txtnomcur.ReadOnly = True
        Me.txtnomcur.Size = New System.Drawing.Size(143, 22)
        Me.txtnomcur.TabIndex = 128
        Me.txtnomcur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(496, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 36)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "PLAN DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESTUDIOS:"
        '
        'txt_plan_estudio
        '
        Me.txt_plan_estudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_plan_estudio.Location = New System.Drawing.Point(606, 98)
        Me.txt_plan_estudio.Name = "txt_plan_estudio"
        Me.txt_plan_estudio.ReadOnly = True
        Me.txt_plan_estudio.Size = New System.Drawing.Size(103, 22)
        Me.txt_plan_estudio.TabIndex = 124
        Me.txt_plan_estudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbx_periodo
        '
        Me.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodo.FormattingEnabled = True
        Me.cbx_periodo.Location = New System.Drawing.Point(330, 98)
        Me.cbx_periodo.Name = "cbx_periodo"
        Me.cbx_periodo.Size = New System.Drawing.Size(132, 24)
        Me.cbx_periodo.TabIndex = 122
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(267, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 18)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "MES:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 18)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "CICLO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(487, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 36)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "TIPO DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ALUMNO:"
        '
        'txt_ciclo
        '
        Me.txt_ciclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ciclo.Location = New System.Drawing.Point(122, 100)
        Me.txt_ciclo.Name = "txt_ciclo"
        Me.txt_ciclo.ReadOnly = True
        Me.txt_ciclo.Size = New System.Drawing.Size(1, 22)
        Me.txt_ciclo.TabIndex = 118
        Me.txt_ciclo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_tipo_alumno
        '
        Me.txt_tipo_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipo_alumno.Location = New System.Drawing.Point(576, 148)
        Me.txt_tipo_alumno.Name = "txt_tipo_alumno"
        Me.txt_tipo_alumno.ReadOnly = True
        Me.txt_tipo_alumno.Size = New System.Drawing.Size(133, 22)
        Me.txt_tipo_alumno.TabIndex = 117
        Me.txt_tipo_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbx_cursos
        '
        Me.cbx_cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_cursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_cursos.FormattingEnabled = True
        Me.cbx_cursos.Location = New System.Drawing.Point(102, 148)
        Me.cbx_cursos.Name = "cbx_cursos"
        Me.cbx_cursos.Size = New System.Drawing.Size(361, 24)
        Me.cbx_cursos.TabIndex = 112
        '
        'dtp_fecha_creacion
        '
        Me.dtp_fecha_creacion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_fecha_creacion.Enabled = False
        Me.dtp_fecha_creacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_creacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_creacion.Location = New System.Drawing.Point(577, 25)
        Me.dtp_fecha_creacion.Name = "dtp_fecha_creacion"
        Me.dtp_fecha_creacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtp_fecha_creacion.ShowUpDown = True
        Me.dtp_fecha_creacion.Size = New System.Drawing.Size(132, 24)
        Me.dtp_fecha_creacion.TabIndex = 111
        '
        'txt_codigo_alumno
        '
        Me.txt_codigo_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_alumno.Location = New System.Drawing.Point(232, 25)
        Me.txt_codigo_alumno.Name = "txt_codigo_alumno"
        Me.txt_codigo_alumno.ReadOnly = True
        Me.txt_codigo_alumno.Size = New System.Drawing.Size(126, 22)
        Me.txt_codigo_alumno.TabIndex = 110
        Me.txt_codigo_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(232, 60)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(335, 22)
        Me.txt_nombre.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 18)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "ALUMNO A TRANSFERIR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(496, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "FECHA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "GRUPO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 18)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "CODIGO DE ALUMNO:"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(671, 300)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(62, 57)
        Me.btn_Cancelar.TabIndex = 115
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(601, 300)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(60, 57)
        Me.btn_Guardar.TabIndex = 114
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'txtnom_t
        '
        Me.txtnom_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom_t.Location = New System.Drawing.Point(333, 17)
        Me.txtnom_t.Name = "txtnom_t"
        Me.txtnom_t.ReadOnly = True
        Me.txtnom_t.Size = New System.Drawing.Size(231, 22)
        Me.txtnom_t.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "ALUMNO:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Txt_idmat)
        Me.Panel1.Controls.Add(Me.txtnom_t)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 54)
        Me.Panel1.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 18)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "ID MATRICULA:"
        '
        'Txt_idmat
        '
        Me.Txt_idmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_idmat.Location = New System.Drawing.Point(145, 17)
        Me.Txt_idmat.Name = "Txt_idmat"
        Me.Txt_idmat.ReadOnly = True
        Me.Txt_idmat.Size = New System.Drawing.Size(84, 22)
        Me.Txt_idmat.TabIndex = 126
        Me.Txt_idmat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.SistemaAsdi.My.Resources.Resources.Search
        Me.btn_buscar.Location = New System.Drawing.Point(671, 50)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(62, 51)
        Me.btn_buscar.TabIndex = 113
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(271, 18)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "TRANSFERENCIA DE MATRICULA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(597, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 45)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "Buscar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alumno a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "transferir:"
        '
        'frm_transferencia_matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 369)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_transferencia_matricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencia de Matricula"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnomcur As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_plan_estudio As System.Windows.Forms.TextBox
    Friend WithEvents cbx_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_ciclo As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_alumno As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cbx_cursos As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha_creacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_codigo_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnom_t As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_idmat As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
