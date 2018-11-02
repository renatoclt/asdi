<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_view_cursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_view_cursos))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.cbx_plan_estudio = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg_view_cursos = New System.Windows.Forms.DataGridView
        Me.lbl_cursos = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dg_view_cursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Cancelar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Guardar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_plan_estudio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dg_view_cursos)
        Me.SplitContainer1.Size = New System.Drawing.Size(476, 497)
        Me.SplitContainer1.SplitterDistance = 56
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(423, 4)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(50, 51)
        Me.btn_Cancelar.TabIndex = 32
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(367, 4)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(50, 51)
        Me.btn_Guardar.TabIndex = 31
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'cbx_plan_estudio
        '
        Me.cbx_plan_estudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_plan_estudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_plan_estudio.FormattingEnabled = True
        Me.cbx_plan_estudio.Location = New System.Drawing.Point(96, 15)
        Me.cbx_plan_estudio.Name = "cbx_plan_estudio"
        Me.cbx_plan_estudio.Size = New System.Drawing.Size(265, 23)
        Me.cbx_plan_estudio.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ESTUDIOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PLAN DE"
        '
        'dg_view_cursos
        '
        Me.dg_view_cursos.AllowUserToAddRows = False
        Me.dg_view_cursos.AllowUserToDeleteRows = False
        Me.dg_view_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_view_cursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_view_cursos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dg_view_cursos.Location = New System.Drawing.Point(0, 0)
        Me.dg_view_cursos.Name = "dg_view_cursos"
        Me.dg_view_cursos.RowHeadersVisible = False
        Me.dg_view_cursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_view_cursos.Size = New System.Drawing.Size(476, 437)
        Me.dg_view_cursos.TabIndex = 0
        '
        'lbl_cursos
        '
        Me.lbl_cursos.AutoSize = True
        Me.lbl_cursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cursos.Location = New System.Drawing.Point(29, 9)
        Me.lbl_cursos.Name = "lbl_cursos"
        Me.lbl_cursos.Size = New System.Drawing.Size(405, 18)
        Me.lbl_cursos.TabIndex = 3
        Me.lbl_cursos.Text = "ORDEN DE LOS CICLOS POR PLAN DE ESTUDIOS"
        '
        'frm_view_cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(477, 527)
        Me.Controls.Add(Me.lbl_cursos)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_view_cursos"
        Me.Text = "Asignación de orden de los ciclos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dg_view_cursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dg_view_cursos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_cursos As System.Windows.Forms.Label
    Friend WithEvents cbx_plan_estudio As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
End Class
