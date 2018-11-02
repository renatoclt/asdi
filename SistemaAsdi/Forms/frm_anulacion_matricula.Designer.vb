<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_anulacion_matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_anulacion_matricula))
        Me.cbx_curso_ofertado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_plan_estudio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_ciclo = New System.Windows.Forms.ComboBox()
        Me.lbl_periodo = New System.Windows.Forms.Label()
        Me.DgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.btn_anulacion = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_desmat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_nomalum = New System.Windows.Forms.TextBox()
        CType(Me.DgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_curso_ofertado
        '
        Me.cbx_curso_ofertado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_curso_ofertado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_curso_ofertado.FormattingEnabled = True
        Me.cbx_curso_ofertado.Location = New System.Drawing.Point(126, 147)
        Me.cbx_curso_ofertado.Name = "cbx_curso_ofertado"
        Me.cbx_curso_ofertado.Size = New System.Drawing.Size(269, 23)
        Me.cbx_curso_ofertado.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "CICLO:"
        '
        'cbx_plan_estudio
        '
        Me.cbx_plan_estudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_plan_estudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_plan_estudio.FormattingEnabled = True
        Me.cbx_plan_estudio.Location = New System.Drawing.Point(126, 98)
        Me.cbx_plan_estudio.Name = "cbx_plan_estudio"
        Me.cbx_plan_estudio.Size = New System.Drawing.Size(214, 23)
        Me.cbx_plan_estudio.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 36)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "PLAN DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESTUDIO:"
        '
        'cbx_ciclo
        '
        Me.cbx_ciclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_ciclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_ciclo.FormattingEnabled = True
        Me.cbx_ciclo.Location = New System.Drawing.Point(126, 54)
        Me.cbx_ciclo.Name = "cbx_ciclo"
        Me.cbx_ciclo.Size = New System.Drawing.Size(214, 23)
        Me.cbx_ciclo.TabIndex = 17
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(33, 56)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(49, 18)
        Me.lbl_periodo.TabIndex = 16
        Me.lbl_periodo.Text = "MES:"
        '
        'DgvAlumnos
        '
        Me.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DgvAlumnos.EnableHeadersVisualStyles = False
        Me.DgvAlumnos.Location = New System.Drawing.Point(36, 250)
        Me.DgvAlumnos.Name = "DgvAlumnos"
        Me.DgvAlumnos.Size = New System.Drawing.Size(471, 348)
        Me.DgvAlumnos.TabIndex = 27
        '
        'btn_anulacion
        '
        Me.btn_anulacion.Location = New System.Drawing.Point(412, 49)
        Me.btn_anulacion.Name = "btn_anulacion"
        Me.btn_anulacion.Size = New System.Drawing.Size(95, 35)
        Me.btn_anulacion.TabIndex = 44
        Me.btn_anulacion.Text = "Anulacion"
        Me.btn_anulacion.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "ALUMNO:"
        '
        'btn_desmat
        '
        Me.btn_desmat.Location = New System.Drawing.Point(412, 92)
        Me.btn_desmat.Name = "btn_desmat"
        Me.btn_desmat.Size = New System.Drawing.Size(95, 35)
        Me.btn_desmat.TabIndex = 45
        Me.btn_desmat.Text = "Desmatricular"
        Me.btn_desmat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 18)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "ANULACION DE MATRICULA"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(445, 177)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(62, 57)
        Me.btn_Cancelar.TabIndex = 116
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(412, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "Transferencia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_nomalum
        '
        Me.txt_nomalum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomalum.Location = New System.Drawing.Point(126, 212)
        Me.txt_nomalum.Name = "txt_nomalum"
        Me.txt_nomalum.ReadOnly = True
        Me.txt_nomalum.Size = New System.Drawing.Size(269, 22)
        Me.txt_nomalum.TabIndex = 118
        '
        'frm_anulacion_matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 631)
        Me.Controls.Add(Me.txt_nomalum)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_desmat)
        Me.Controls.Add(Me.btn_anulacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DgvAlumnos)
        Me.Controls.Add(Me.cbx_curso_ofertado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbx_plan_estudio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbx_ciclo)
        Me.Controls.Add(Me.lbl_periodo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_anulacion_matricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anulacion de Matricula"
        CType(Me.DgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbx_curso_ofertado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbx_plan_estudio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbx_ciclo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents DgvAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_anulacion As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_desmat As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_nomalum As System.Windows.Forms.TextBox
End Class
