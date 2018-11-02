<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_periodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_periodo))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dg_periodo = New System.Windows.Forms.DataGridView
        Me.dtp_fecha_fin = New System.Windows.Forms.DateTimePicker
        Me.dtp_fecha_inicio = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chk_regular = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chk_estado = New System.Windows.Forms.CheckBox
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.txt_periodo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_periodo = New System.Windows.Forms.Label
        Me.tooltip_periodo = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dg_periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dg_periodo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtp_fecha_fin)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtp_fecha_inicio)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chk_regular)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chk_estado)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Borrar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Guardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Editar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Agregar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_periodo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(635, 395)
        Me.SplitContainer1.SplitterDistance = 467
        Me.SplitContainer1.TabIndex = 0
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
        Me.dg_periodo.Size = New System.Drawing.Size(467, 395)
        Me.dg_periodo.TabIndex = 0
        '
        'dtp_fecha_fin
        '
        Me.dtp_fecha_fin.CustomFormat = "yyyy/MM/dd"
        Me.dtp_fecha_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fecha_fin.Location = New System.Drawing.Point(14, 199)
        Me.dtp_fecha_fin.Name = "dtp_fecha_fin"
        Me.dtp_fecha_fin.Size = New System.Drawing.Size(134, 20)
        Me.dtp_fecha_fin.TabIndex = 21
        '
        'dtp_fecha_inicio
        '
        Me.dtp_fecha_inicio.CustomFormat = "yyyy/MM/dd"
        Me.dtp_fecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fecha_inicio.Location = New System.Drawing.Point(14, 147)
        Me.dtp_fecha_inicio.Name = "dtp_fecha_inicio"
        Me.dtp_fecha_inicio.Size = New System.Drawing.Size(134, 20)
        Me.dtp_fecha_inicio.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "FECHA DE FIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "FECHA DE INICIO"
        '
        'chk_regular
        '
        Me.chk_regular.AutoSize = True
        Me.chk_regular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_regular.ForeColor = System.Drawing.Color.Red
        Me.chk_regular.Location = New System.Drawing.Point(43, 106)
        Me.chk_regular.Name = "chk_regular"
        Me.chk_regular.Size = New System.Drawing.Size(93, 17)
        Me.chk_regular.TabIndex = 16
        Me.chk_regular.Text = "text_regular"
        Me.chk_regular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "REGULAR"
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_estado.ForeColor = System.Drawing.Color.Red
        Me.chk_estado.Location = New System.Drawing.Point(44, 67)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(92, 17)
        Me.chk_estado.TabIndex = 14
        Me.chk_estado.Text = "text_estado"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Image = Global.SistemaAsdi.My.Resources.Resources.Delete
        Me.btn_Borrar.Location = New System.Drawing.Point(84, 283)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(72, 47)
        Me.btn_Borrar.TabIndex = 13
        Me.tooltip_periodo.SetToolTip(Me.btn_Borrar, "Borrar")
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(85, 333)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(72, 56)
        Me.btn_Cancelar.TabIndex = 12
        Me.tooltip_periodo.SetToolTip(Me.btn_Cancelar, "Cancelar")
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 333)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(72, 56)
        Me.btn_Guardar.TabIndex = 11
        Me.tooltip_periodo.SetToolTip(Me.btn_Guardar, "Guardar")
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = Global.SistemaAsdi.My.Resources.Resources.Pencil
        Me.btn_Editar.Location = New System.Drawing.Point(6, 283)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(72, 47)
        Me.btn_Editar.TabIndex = 10
        Me.tooltip_periodo.SetToolTip(Me.btn_Editar, "Editar")
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Image = Global.SistemaAsdi.My.Resources.Resources.__1
        Me.btn_Agregar.Location = New System.Drawing.Point(6, 230)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(147, 47)
        Me.btn_Agregar.TabIndex = 9
        Me.tooltip_periodo.SetToolTip(Me.btn_Agregar, "Agregar")
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'txt_periodo
        '
        Me.txt_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_periodo.Location = New System.Drawing.Point(6, 21)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(147, 22)
        Me.txt_periodo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ESTADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PERIODO"
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(220, 9)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(172, 18)
        Me.lbl_periodo.TabIndex = 1
        Me.lbl_periodo.Text = "LISTA DE PERIODOS"
        '
        'frm_periodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(636, 428)
        Me.Controls.Add(Me.lbl_periodo)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_periodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Periodos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dg_periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dg_periodo As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents chk_estado As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents txt_periodo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_regular As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tooltip_periodo As System.Windows.Forms.ToolTip
    Friend WithEvents dtp_fecha_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_fin As System.Windows.Forms.DateTimePicker
End Class
