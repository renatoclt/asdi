﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lista_alumno_horario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lista_alumno_horario))
        Me.lbl_alumnos = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btn_reporte = New System.Windows.Forms.Button
        Me.cbx_horario = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbx_periodo = New System.Windows.Forms.ComboBox
        Me.lbl_periodo = New System.Windows.Forms.Label
        Me.dg_alumnos = New System.Windows.Forms.DataGridView
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dg_alumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_alumnos
        '
        Me.lbl_alumnos.AutoSize = True
        Me.lbl_alumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alumnos.Location = New System.Drawing.Point(65, 9)
        Me.lbl_alumnos.Name = "lbl_alumnos"
        Me.lbl_alumnos.Size = New System.Drawing.Size(384, 18)
        Me.lbl_alumnos.TabIndex = 5
        Me.lbl_alumnos.Text = "LISTA DE ALUMNOS POR PERIODO Y HORARIO"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_reporte)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_horario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_periodo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_periodo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dg_alumnos)
        Me.SplitContainer1.Size = New System.Drawing.Size(520, 501)
        Me.SplitContainer1.SplitterDistance = 82
        Me.SplitContainer1.TabIndex = 6
        '
        'btn_reporte
        '
        Me.btn_reporte.Image = Global.SistemaAsdi.My.Resources.Resources.Bar_Chart
        Me.btn_reporte.Location = New System.Drawing.Point(455, 8)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(56, 58)
        Me.btn_reporte.TabIndex = 17
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'cbx_horario
        '
        Me.cbx_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_horario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_horario.FormattingEnabled = True
        Me.cbx_horario.Location = New System.Drawing.Point(111, 47)
        Me.cbx_horario.Name = "cbx_horario"
        Me.cbx_horario.Size = New System.Drawing.Size(328, 23)
        Me.cbx_horario.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "HORARIO"
        '
        'cbx_periodo
        '
        Me.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodo.FormattingEnabled = True
        Me.cbx_periodo.Location = New System.Drawing.Point(111, 9)
        Me.cbx_periodo.Name = "cbx_periodo"
        Me.cbx_periodo.Size = New System.Drawing.Size(328, 23)
        Me.cbx_periodo.TabIndex = 14
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(9, 11)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(84, 18)
        Me.lbl_periodo.TabIndex = 13
        Me.lbl_periodo.Text = "PERIODO"
        '
        'dg_alumnos
        '
        Me.dg_alumnos.AllowUserToAddRows = False
        Me.dg_alumnos.AllowUserToDeleteRows = False
        Me.dg_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_alumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_alumnos.Location = New System.Drawing.Point(0, 0)
        Me.dg_alumnos.Name = "dg_alumnos"
        Me.dg_alumnos.ReadOnly = True
        Me.dg_alumnos.RowHeadersVisible = False
        Me.dg_alumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_alumnos.Size = New System.Drawing.Size(520, 415)
        Me.dg_alumnos.TabIndex = 0
        '
        'frm_lista_alumno_horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(521, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lbl_alumnos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_lista_alumno_horario"
        Me.Text = "Lista de alumnos por horario"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dg_alumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_alumnos As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dg_alumnos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents cbx_horario As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbx_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
End Class
