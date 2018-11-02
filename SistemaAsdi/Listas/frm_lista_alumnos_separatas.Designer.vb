<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lista_alumnos_separatas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lista_alumnos_separatas))
        Me.Cbx_plan_est = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.Cbx_ciclo = New System.Windows.Forms.ComboBox()
        Me.lbl_periodo = New System.Windows.Forms.Label()
        Me.lbl_alumnos = New System.Windows.Forms.Label()
        Me.DgvMatriculaSep = New System.Windows.Forms.DataGridView()
        Me.cbx_curso_grupo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvMatriculaSep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbx_plan_est
        '
        Me.Cbx_plan_est.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_plan_est.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Cbx_plan_est.FormattingEnabled = True
        Me.Cbx_plan_est.Location = New System.Drawing.Point(151, 107)
        Me.Cbx_plan_est.Name = "Cbx_plan_est"
        Me.Cbx_plan_est.Size = New System.Drawing.Size(380, 23)
        Me.Cbx_plan_est.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "PLAN E."
        '
        'btn_reporte
        '
        Me.btn_reporte.Image = Global.SistemaAsdi.My.Resources.Resources.Bar_Chart
        Me.btn_reporte.Location = New System.Drawing.Point(572, 68)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(56, 58)
        Me.btn_reporte.TabIndex = 37
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'Cbx_ciclo
        '
        Me.Cbx_ciclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_ciclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Cbx_ciclo.FormattingEnabled = True
        Me.Cbx_ciclo.Location = New System.Drawing.Point(151, 68)
        Me.Cbx_ciclo.Name = "Cbx_ciclo"
        Me.Cbx_ciclo.Size = New System.Drawing.Size(380, 23)
        Me.Cbx_ciclo.TabIndex = 36
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(56, 71)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(44, 18)
        Me.lbl_periodo.TabIndex = 35
        Me.lbl_periodo.Text = "MES"
        '
        'lbl_alumnos
        '
        Me.lbl_alumnos.AutoSize = True
        Me.lbl_alumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alumnos.Location = New System.Drawing.Point(198, 22)
        Me.lbl_alumnos.Name = "lbl_alumnos"
        Me.lbl_alumnos.Size = New System.Drawing.Size(275, 18)
        Me.lbl_alumnos.TabIndex = 34
        Me.lbl_alumnos.Text = "REPORTE ALUMNOS SEPARATAS"
        '
        'DgvMatriculaSep
        '
        Me.DgvMatriculaSep.AllowUserToAddRows = False
        Me.DgvMatriculaSep.AllowUserToDeleteRows = False
        Me.DgvMatriculaSep.AllowUserToOrderColumns = True
        Me.DgvMatriculaSep.AllowUserToResizeRows = False
        Me.DgvMatriculaSep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMatriculaSep.Location = New System.Drawing.Point(1, 195)
        Me.DgvMatriculaSep.Name = "DgvMatriculaSep"
        Me.DgvMatriculaSep.ReadOnly = True
        Me.DgvMatriculaSep.RowHeadersVisible = False
        Me.DgvMatriculaSep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMatriculaSep.Size = New System.Drawing.Size(673, 417)
        Me.DgvMatriculaSep.TabIndex = 33
        '
        'cbx_curso_grupo
        '
        Me.cbx_curso_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_curso_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_curso_grupo.FormattingEnabled = True
        Me.cbx_curso_grupo.Location = New System.Drawing.Point(151, 148)
        Me.cbx_curso_grupo.Name = "cbx_curso_grupo"
        Me.cbx_curso_grupo.Size = New System.Drawing.Size(380, 23)
        Me.cbx_curso_grupo.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "CICLO"
        '
        'frm_lista_alumnos_separatas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 614)
        Me.Controls.Add(Me.cbx_curso_grupo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cbx_plan_est)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.Cbx_ciclo)
        Me.Controls.Add(Me.lbl_periodo)
        Me.Controls.Add(Me.lbl_alumnos)
        Me.Controls.Add(Me.DgvMatriculaSep)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_lista_alumnos_separatas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Alumnos Separatas"
        CType(Me.DgvMatriculaSep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbx_plan_est As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents Cbx_ciclo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents lbl_alumnos As System.Windows.Forms.Label
    Friend WithEvents DgvMatriculaSep As System.Windows.Forms.DataGridView
    Friend WithEvents cbx_curso_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
