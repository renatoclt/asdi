<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tp_documento
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tp_documento))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dg_tp_documento = New System.Windows.Forms.DataGridView
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.txt_tp_documento = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_tp_documento = New System.Windows.Forms.Label
        Me.tooltip_tp_documento = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dg_tp_documento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dg_tp_documento)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Borrar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Guardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Editar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Agregar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_tp_documento)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(387, 229)
        Me.SplitContainer1.SplitterDistance = 197
        Me.SplitContainer1.TabIndex = 0
        '
        'dg_tp_documento
        '
        Me.dg_tp_documento.AllowUserToAddRows = False
        Me.dg_tp_documento.AllowUserToDeleteRows = False
        Me.dg_tp_documento.AllowUserToOrderColumns = True
        Me.dg_tp_documento.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dg_tp_documento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tp_documento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_tp_documento.Location = New System.Drawing.Point(0, 0)
        Me.dg_tp_documento.MultiSelect = False
        Me.dg_tp_documento.Name = "dg_tp_documento"
        Me.dg_tp_documento.ReadOnly = True
        Me.dg_tp_documento.RowHeadersVisible = False
        Me.dg_tp_documento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_tp_documento.Size = New System.Drawing.Size(197, 229)
        Me.dg_tp_documento.TabIndex = 0
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Image = Global.SistemaAsdi.My.Resources.Resources.Delete
        Me.btn_Borrar.Location = New System.Drawing.Point(91, 113)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(72, 44)
        Me.btn_Borrar.TabIndex = 6
        Me.tooltip_tp_documento.SetToolTip(Me.btn_Borrar, "Borrar")
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(91, 163)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(72, 56)
        Me.btn_Cancelar.TabIndex = 5
        Me.tooltip_tp_documento.SetToolTip(Me.btn_Cancelar, "Cancelar")
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(16, 163)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(69, 56)
        Me.btn_Guardar.TabIndex = 4
        Me.tooltip_tp_documento.SetToolTip(Me.btn_Guardar, "Guardar")
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = Global.SistemaAsdi.My.Resources.Resources.Pencil
        Me.btn_Editar.Location = New System.Drawing.Point(16, 113)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(72, 47)
        Me.btn_Editar.TabIndex = 3
        Me.tooltip_tp_documento.SetToolTip(Me.btn_Editar, "Editar")
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Image = Global.SistemaAsdi.My.Resources.Resources.__1
        Me.btn_Agregar.Location = New System.Drawing.Point(16, 60)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(147, 47)
        Me.btn_Agregar.TabIndex = 2
        Me.tooltip_tp_documento.SetToolTip(Me.btn_Agregar, "Agregar")
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'txt_tp_documento
        '
        Me.txt_tp_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tp_documento.Location = New System.Drawing.Point(16, 35)
        Me.txt_tp_documento.Name = "txt_tp_documento"
        Me.txt_tp_documento.Size = New System.Drawing.Size(147, 22)
        Me.txt_tp_documento.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo de Documento"
        '
        'lbl_tp_documento
        '
        Me.lbl_tp_documento.AutoSize = True
        Me.lbl_tp_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tp_documento.Location = New System.Drawing.Point(58, 9)
        Me.lbl_tp_documento.Name = "lbl_tp_documento"
        Me.lbl_tp_documento.Size = New System.Drawing.Size(276, 18)
        Me.lbl_tp_documento.TabIndex = 0
        Me.lbl_tp_documento.Text = "LISTA DE TIPO DE DOCUMENTOS"
        '
        'frm_tp_documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(373, 261)
        Me.Controls.Add(Me.lbl_tp_documento)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tp_documento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipo de Documentos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dg_tp_documento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbl_tp_documento As System.Windows.Forms.Label
    Friend WithEvents dg_tp_documento As System.Windows.Forms.DataGridView
    Friend WithEvents txt_tp_documento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents tooltip_tp_documento As System.Windows.Forms.ToolTip
End Class
