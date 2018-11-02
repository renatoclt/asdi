<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tp_estado_alumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tp_estado_alumno))
        Me.lbl_tp_alumno_estado = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dg_tp_estado_alumno = New System.Windows.Forms.DataGridView
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.txt_tp_estado_alumno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dg_tp_estado_alumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_tp_alumno_estado
        '
        Me.lbl_tp_alumno_estado.AutoSize = True
        Me.lbl_tp_alumno_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tp_alumno_estado.Location = New System.Drawing.Point(63, 9)
        Me.lbl_tp_alumno_estado.Name = "lbl_tp_alumno_estado"
        Me.lbl_tp_alumno_estado.Size = New System.Drawing.Size(269, 18)
        Me.lbl_tp_alumno_estado.TabIndex = 4
        Me.lbl_tp_alumno_estado.Text = "TIPO DE ESTADOS DEL ALUMNO"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 38)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dg_tp_estado_alumno)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Borrar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Guardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Editar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Agregar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_tp_estado_alumno)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(402, 219)
        Me.SplitContainer1.SplitterDistance = 225
        Me.SplitContainer1.TabIndex = 5
        '
        'dg_tp_estado_alumno
        '
        Me.dg_tp_estado_alumno.AllowUserToAddRows = False
        Me.dg_tp_estado_alumno.AllowUserToDeleteRows = False
        Me.dg_tp_estado_alumno.AllowUserToOrderColumns = True
        Me.dg_tp_estado_alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tp_estado_alumno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_tp_estado_alumno.Location = New System.Drawing.Point(0, 0)
        Me.dg_tp_estado_alumno.Name = "dg_tp_estado_alumno"
        Me.dg_tp_estado_alumno.ReadOnly = True
        Me.dg_tp_estado_alumno.RowHeadersVisible = False
        Me.dg_tp_estado_alumno.Size = New System.Drawing.Size(225, 219)
        Me.dg_tp_estado_alumno.TabIndex = 0
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Image = Global.SistemaAsdi.My.Resources.Resources.Delete
        Me.btn_Borrar.Location = New System.Drawing.Point(94, 111)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(69, 47)
        Me.btn_Borrar.TabIndex = 40
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(94, 164)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(69, 50)
        Me.btn_Cancelar.TabIndex = 39
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.Save
        Me.btn_Guardar.Location = New System.Drawing.Point(17, 164)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(71, 50)
        Me.btn_Guardar.TabIndex = 38
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = Global.SistemaAsdi.My.Resources.Resources.Pencil
        Me.btn_Editar.Location = New System.Drawing.Point(17, 111)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(71, 47)
        Me.btn_Editar.TabIndex = 37
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Image = Global.SistemaAsdi.My.Resources.Resources.__1
        Me.btn_Agregar.Location = New System.Drawing.Point(16, 58)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(147, 47)
        Me.btn_Agregar.TabIndex = 36
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'txt_tp_estado_alumno
        '
        Me.txt_tp_estado_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tp_estado_alumno.Location = New System.Drawing.Point(16, 21)
        Me.txt_tp_estado_alumno.Name = "txt_tp_estado_alumno"
        Me.txt_tp_estado_alumno.Size = New System.Drawing.Size(147, 22)
        Me.txt_tp_estado_alumno.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "ESTADO DEL ALUMNO"
        '
        'frm_tp_estado_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(406, 257)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lbl_tp_alumno_estado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tp_estado_alumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipos de Alumno"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dg_tp_estado_alumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tp_alumno_estado As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents txt_tp_estado_alumno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg_tp_estado_alumno As System.Windows.Forms.DataGridView
End Class
