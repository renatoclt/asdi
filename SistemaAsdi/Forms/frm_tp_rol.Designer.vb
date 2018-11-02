<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tp_rol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tp_rol))
        Me.lbl_tp_alumno_estado = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dg_tp_rol = New System.Windows.Forms.DataGridView
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.txt_tp_rol = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dg_tp_rol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_tp_alumno_estado
        '
        Me.lbl_tp_alumno_estado.AutoSize = True
        Me.lbl_tp_alumno_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tp_alumno_estado.Location = New System.Drawing.Point(107, 9)
        Me.lbl_tp_alumno_estado.Name = "lbl_tp_alumno_estado"
        Me.lbl_tp_alumno_estado.Size = New System.Drawing.Size(135, 18)
        Me.lbl_tp_alumno_estado.TabIndex = 5
        Me.lbl_tp_alumno_estado.Text = "TIPO DE ROLES"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dg_tp_rol)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Borrar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Guardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Editar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Agregar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_tp_rol)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(374, 225)
        Me.SplitContainer1.SplitterDistance = 203
        Me.SplitContainer1.TabIndex = 6
        '
        'dg_tp_rol
        '
        Me.dg_tp_rol.AllowUserToAddRows = False
        Me.dg_tp_rol.AllowUserToDeleteRows = False
        Me.dg_tp_rol.AllowUserToOrderColumns = True
        Me.dg_tp_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tp_rol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_tp_rol.Location = New System.Drawing.Point(0, 0)
        Me.dg_tp_rol.Name = "dg_tp_rol"
        Me.dg_tp_rol.ReadOnly = True
        Me.dg_tp_rol.RowHeadersVisible = False
        Me.dg_tp_rol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_tp_rol.Size = New System.Drawing.Size(203, 225)
        Me.dg_tp_rol.TabIndex = 0
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Image = Global.SistemaAsdi.My.Resources.Resources.Delete
        Me.btn_Borrar.Location = New System.Drawing.Point(87, 112)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(69, 47)
        Me.btn_Borrar.TabIndex = 47
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(87, 165)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(69, 50)
        Me.btn_Cancelar.TabIndex = 46
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(10, 165)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(71, 50)
        Me.btn_Guardar.TabIndex = 45
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = Global.SistemaAsdi.My.Resources.Resources.Pencil
        Me.btn_Editar.Location = New System.Drawing.Point(10, 112)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(71, 47)
        Me.btn_Editar.TabIndex = 44
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Image = Global.SistemaAsdi.My.Resources.Resources.__1
        Me.btn_Agregar.Location = New System.Drawing.Point(9, 59)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(147, 47)
        Me.btn_Agregar.TabIndex = 43
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'txt_tp_rol
        '
        Me.txt_tp_rol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tp_rol.Location = New System.Drawing.Point(9, 21)
        Me.txt_tp_rol.Name = "txt_tp_rol"
        Me.txt_tp_rol.Size = New System.Drawing.Size(144, 22)
        Me.txt_tp_rol.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "ROL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_tp_rol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(375, 256)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lbl_tp_alumno_estado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tp_rol"
        Me.Text = "Roles"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dg_tp_rol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tp_alumno_estado As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dg_tp_rol As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents txt_tp_rol As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
