<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lista_notas_alumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lista_notas_alumno))
        Me.lbl_alumnos = New System.Windows.Forms.Label()
        Me.lbl_periodo = New System.Windows.Forms.Label()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.Cb_Alumno = New System.Windows.Forms.ComboBox()
        Me.DgvNotas = New System.Windows.Forms.DataGridView()
        CType(Me.DgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_alumnos
        '
        Me.lbl_alumnos.AutoSize = True
        Me.lbl_alumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alumnos.Location = New System.Drawing.Point(132, 21)
        Me.lbl_alumnos.Name = "lbl_alumnos"
        Me.lbl_alumnos.Size = New System.Drawing.Size(293, 18)
        Me.lbl_alumnos.TabIndex = 5
        Me.lbl_alumnos.Text = "REPORTE DE NOTAS POR ALUMNO"
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(27, 81)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(78, 18)
        Me.lbl_periodo.TabIndex = 10
        Me.lbl_periodo.Text = "ALUMNO"
        '
        'btn_reporte
        '
        Me.btn_reporte.Image = Global.SistemaAsdi.My.Resources.Resources.Bar_Chart
        Me.btn_reporte.Location = New System.Drawing.Point(468, 44)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(56, 58)
        Me.btn_reporte.TabIndex = 13
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'Cb_Alumno
        '
        Me.Cb_Alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Alumno.FormattingEnabled = True
        Me.Cb_Alumno.Location = New System.Drawing.Point(122, 78)
        Me.Cb_Alumno.Name = "Cb_Alumno"
        Me.Cb_Alumno.Size = New System.Drawing.Size(299, 24)
        Me.Cb_Alumno.TabIndex = 26
        '
        'DgvNotas
        '
        Me.DgvNotas.AllowUserToAddRows = False
        Me.DgvNotas.AllowUserToDeleteRows = False
        Me.DgvNotas.AllowUserToOrderColumns = True
        Me.DgvNotas.AllowUserToResizeRows = False
        Me.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNotas.Location = New System.Drawing.Point(0, 131)
        Me.DgvNotas.Name = "DgvNotas"
        Me.DgvNotas.ReadOnly = True
        Me.DgvNotas.RowHeadersVisible = False
        Me.DgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNotas.Size = New System.Drawing.Size(591, 417)
        Me.DgvNotas.TabIndex = 25
        '
        'frm_lista_notas_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 546)
        Me.Controls.Add(Me.Cb_Alumno)
        Me.Controls.Add(Me.DgvNotas)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.lbl_periodo)
        Me.Controls.Add(Me.lbl_alumnos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_lista_notas_alumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Notas por Alumno"
        CType(Me.DgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_alumnos As System.Windows.Forms.Label
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents Cb_Alumno As System.Windows.Forms.ComboBox
    Friend WithEvents DgvNotas As System.Windows.Forms.DataGridView
End Class
