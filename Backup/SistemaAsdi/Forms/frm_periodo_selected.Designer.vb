<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_periodo_selected
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_periodo_selected))
        Me.lbl_periodo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dg_periodo = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_Seleccionar = New System.Windows.Forms.Button
        Me.lbl_periodo_selecionado = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.dg_periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(44, 3)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(286, 18)
        Me.lbl_periodo.TabIndex = 3
        Me.lbl_periodo.Text = "LISTA DE PERIODOS ACADEMICOS"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dg_periodo)
        Me.Panel1.Location = New System.Drawing.Point(1, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 226)
        Me.Panel1.TabIndex = 4
        '
        'dg_periodo
        '
        Me.dg_periodo.AllowUserToAddRows = False
        Me.dg_periodo.AllowUserToDeleteRows = False
        Me.dg_periodo.AllowUserToOrderColumns = True
        Me.dg_periodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_periodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_periodo.Location = New System.Drawing.Point(0, 0)
        Me.dg_periodo.Name = "dg_periodo"
        Me.dg_periodo.ReadOnly = True
        Me.dg_periodo.RowHeadersVisible = False
        Me.dg_periodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_periodo.Size = New System.Drawing.Size(241, 226)
        Me.dg_periodo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PERIODO:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Seleccionar
        '
        Me.btn_Seleccionar.Image = Global.SistemaAsdi.My.Resources.Resources.Accept
        Me.btn_Seleccionar.Location = New System.Drawing.Point(266, 150)
        Me.btn_Seleccionar.Name = "btn_Seleccionar"
        Me.btn_Seleccionar.Size = New System.Drawing.Size(72, 56)
        Me.btn_Seleccionar.TabIndex = 12
        Me.btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'lbl_periodo_selecionado
        '
        Me.lbl_periodo_selecionado.AutoSize = True
        Me.lbl_periodo_selecionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo_selecionado.Location = New System.Drawing.Point(270, 94)
        Me.lbl_periodo_selecionado.Name = "lbl_periodo_selecionado"
        Me.lbl_periodo_selecionado.Size = New System.Drawing.Size(68, 18)
        Me.lbl_periodo_selecionado.TabIndex = 13
        Me.lbl_periodo_selecionado.Text = "0000-00"
        Me.lbl_periodo_selecionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_periodo_selected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(371, 250)
        Me.Controls.Add(Me.lbl_periodo_selecionado)
        Me.Controls.Add(Me.btn_Seleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_periodo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_periodo_selected"
        Me.Text = "Periodo Académico"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dg_periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dg_periodo As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents lbl_periodo_selecionado As System.Windows.Forms.Label
End Class
