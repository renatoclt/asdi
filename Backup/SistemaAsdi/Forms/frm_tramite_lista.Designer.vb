<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tramite_lista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tramite_lista))
        Me.lbl_tramite = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.cbx_tp_tramite = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg_tramites = New System.Windows.Forms.DataGridView
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dg_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_tramite
        '
        Me.lbl_tramite.AutoSize = True
        Me.lbl_tramite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tramite.Location = New System.Drawing.Point(266, 9)
        Me.lbl_tramite.Name = "lbl_tramite"
        Me.lbl_tramite.Size = New System.Drawing.Size(167, 18)
        Me.lbl_tramite.TabIndex = 3
        Me.lbl_tramite.Text = "LISTA DE TRAMITES"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_nombre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_tp_tramite)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dg_tramites)
        Me.SplitContainer1.Size = New System.Drawing.Size(677, 518)
        Me.SplitContainer1.SplitterDistance = 93
        Me.SplitContainer1.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(310, 53)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(259, 21)
        Me.txt_nombre.TabIndex = 8
        '
        'cbx_tp_tramite
        '
        Me.cbx_tp_tramite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tp_tramite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_tp_tramite.FormattingEnabled = True
        Me.cbx_tp_tramite.Items.AddRange(New Object() {"Seleccionar"})
        Me.cbx_tp_tramite.Location = New System.Drawing.Point(309, 24)
        Me.cbx_tp_tramite.Name = "cbx_tp_tramite"
        Me.cbx_tp_tramite.Size = New System.Drawing.Size(260, 23)
        Me.cbx_tp_tramite.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOMBRE DEL ALUMNO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TIPO DE TRAMITE"
        '
        'dg_tramites
        '
        Me.dg_tramites.AllowUserToAddRows = False
        Me.dg_tramites.AllowUserToDeleteRows = False
        Me.dg_tramites.AllowUserToOrderColumns = True
        Me.dg_tramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tramites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_tramites.Location = New System.Drawing.Point(0, 0)
        Me.dg_tramites.Name = "dg_tramites"
        Me.dg_tramites.ReadOnly = True
        Me.dg_tramites.RowHeadersVisible = False
        Me.dg_tramites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_tramites.Size = New System.Drawing.Size(677, 421)
        Me.dg_tramites.TabIndex = 0
        '
        'frm_tramite_lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(681, 548)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lbl_tramite)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tramite_lista"
        Me.Text = "Lista de Tramites"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dg_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tramite As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dg_tramites As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents cbx_tp_tramite As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
