<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lista_alumno_asistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lista_alumno_asistencia))
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.lbl_alumnos = New System.Windows.Forms.Label()
        Me.cbx_profesor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_periodo = New System.Windows.Forms.ComboBox()
        Me.lbl_periodo = New System.Windows.Forms.Label()
        Me.cbx_horario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_curso_ofertado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_reporte
        '
        Me.btn_reporte.Image = Global.SistemaAsdi.My.Resources.Resources.Bar_Chart
        Me.btn_reporte.Location = New System.Drawing.Point(602, 75)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(56, 58)
        Me.btn_reporte.TabIndex = 13
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'lbl_alumnos
        '
        Me.lbl_alumnos.AutoSize = True
        Me.lbl_alumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alumnos.Location = New System.Drawing.Point(249, 18)
        Me.lbl_alumnos.Name = "lbl_alumnos"
        Me.lbl_alumnos.Size = New System.Drawing.Size(302, 18)
        Me.lbl_alumnos.TabIndex = 8
        Me.lbl_alumnos.Text = "REPORTE DE ALUMNOS ASISTENCIA"
        '
        'cbx_profesor
        '
        Me.cbx_profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_profesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_profesor.FormattingEnabled = True
        Me.cbx_profesor.Location = New System.Drawing.Point(241, 150)
        Me.cbx_profesor.Name = "cbx_profesor"
        Me.cbx_profesor.Size = New System.Drawing.Size(328, 23)
        Me.cbx_profesor.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "PROFESOR"
        '
        'cbx_periodo
        '
        Me.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodo.FormattingEnabled = True
        Me.cbx_periodo.Location = New System.Drawing.Point(241, 70)
        Me.cbx_periodo.Name = "cbx_periodo"
        Me.cbx_periodo.Size = New System.Drawing.Size(328, 23)
        Me.cbx_periodo.TabIndex = 10
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(127, 71)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(44, 18)
        Me.lbl_periodo.TabIndex = 9
        Me.lbl_periodo.Text = "MES"
        '
        'cbx_horario
        '
        Me.cbx_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_horario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_horario.FormattingEnabled = True
        Me.cbx_horario.Location = New System.Drawing.Point(241, 110)
        Me.cbx_horario.Name = "cbx_horario"
        Me.cbx_horario.Size = New System.Drawing.Size(328, 23)
        Me.cbx_horario.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "HORARIO"
        '
        'cbx_curso_ofertado
        '
        Me.cbx_curso_ofertado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_curso_ofertado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_curso_ofertado.FormattingEnabled = True
        Me.cbx_curso_ofertado.Location = New System.Drawing.Point(241, 189)
        Me.cbx_curso_ofertado.Name = "cbx_curso_ofertado"
        Me.cbx_curso_ofertado.Size = New System.Drawing.Size(328, 23)
        Me.cbx_curso_ofertado.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CICLO"
        '
        'DgvAlumnos
        '
        Me.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DgvAlumnos.EnableHeadersVisualStyles = False
        Me.DgvAlumnos.Location = New System.Drawing.Point(6, 236)
        Me.DgvAlumnos.Name = "DgvAlumnos"
        Me.DgvAlumnos.Size = New System.Drawing.Size(758, 336)
        Me.DgvAlumnos.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.Image = Global.SistemaAsdi.My.Resources.Resources.Bar_Chart
        Me.Button1.Location = New System.Drawing.Point(676, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 58)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_lista_alumno_asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 584)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvAlumnos)
        Me.Controls.Add(Me.cbx_curso_ofertado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbx_horario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.lbl_alumnos)
        Me.Controls.Add(Me.cbx_profesor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbx_periodo)
        Me.Controls.Add(Me.lbl_periodo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_lista_alumno_asistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Alumnos Asistencia"
        CType(Me.DgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents lbl_alumnos As System.Windows.Forms.Label
    Friend WithEvents cbx_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbx_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents cbx_horario As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbx_curso_ofertado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DgvAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
