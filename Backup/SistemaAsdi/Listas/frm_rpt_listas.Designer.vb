<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_listas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rpt_listas))
        Me.crv_reportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crv_reportes
        '
        Me.crv_reportes.ActiveViewIndex = -1
        Me.crv_reportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_reportes.DisplayGroupTree = False
        Me.crv_reportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_reportes.Location = New System.Drawing.Point(0, 0)
        Me.crv_reportes.Name = "crv_reportes"
        Me.crv_reportes.SelectionFormula = ""
        Me.crv_reportes.Size = New System.Drawing.Size(623, 554)
        Me.crv_reportes.TabIndex = 0
        Me.crv_reportes.ViewTimeSelectionFormula = ""
        '
        'frm_rpt_listas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 554)
        Me.Controls.Add(Me.crv_reportes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_rpt_listas"
        Me.Text = "Listas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_reportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
