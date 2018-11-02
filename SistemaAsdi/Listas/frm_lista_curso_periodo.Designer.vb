<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lista_curso_periodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lista_curso_periodo))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbplan_est = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.cbx_periodo = New System.Windows.Forms.ComboBox()
        Me.lbl_periodo = New System.Windows.Forms.Label()
        Me.dg_cursos = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dg_cursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(181, 4)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(264, 18)
        Me.lbl_titulo.TabIndex = 6
        Me.lbl_titulo.Text = "REPORTE DE CICLOS POR MES"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbplan_est)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_reporte)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_periodo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_periodo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dg_cursos)
        Me.SplitContainer1.Size = New System.Drawing.Size(647, 438)
        Me.SplitContainer1.SplitterDistance = 46
        Me.SplitContainer1.TabIndex = 7
        '
        'cbplan_est
        '
        Me.cbplan_est.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbplan_est.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbplan_est.FormattingEnabled = True
        Me.cbplan_est.Location = New System.Drawing.Point(367, 11)
        Me.cbplan_est.Name = "cbplan_est"
        Me.cbplan_est.Size = New System.Drawing.Size(167, 23)
        Me.cbplan_est.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "PLAN E."
        '
        'btn_reporte
        '
        Me.btn_reporte.Image = Global.SistemaAsdi.My.Resources.Resources.Bar_Chart
        Me.btn_reporte.Location = New System.Drawing.Point(564, 0)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(46, 45)
        Me.btn_reporte.TabIndex = 12
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'cbx_periodo
        '
        Me.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodo.FormattingEnabled = True
        Me.cbx_periodo.Location = New System.Drawing.Point(105, 11)
        Me.cbx_periodo.Name = "cbx_periodo"
        Me.cbx_periodo.Size = New System.Drawing.Size(167, 23)
        Me.cbx_periodo.TabIndex = 9
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(18, 13)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(44, 18)
        Me.lbl_periodo.TabIndex = 8
        Me.lbl_periodo.Text = "MES"
        '
        'dg_cursos
        '
        Me.dg_cursos.AllowUserToAddRows = False
        Me.dg_cursos.AllowUserToDeleteRows = False
        Me.dg_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_cursos.Location = New System.Drawing.Point(0, 0)
        Me.dg_cursos.Name = "dg_cursos"
        Me.dg_cursos.ReadOnly = True
        Me.dg_cursos.RowHeadersVisible = False
        Me.dg_cursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_cursos.Size = New System.Drawing.Size(647, 388)
        Me.dg_cursos.TabIndex = 0
        '
        'frm_lista_curso_periodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(648, 469)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_lista_curso_periodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Clicos por Mes"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dg_cursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents cbx_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents dg_cursos As System.Windows.Forms.DataGridView
    Friend WithEvents cbplan_est As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
