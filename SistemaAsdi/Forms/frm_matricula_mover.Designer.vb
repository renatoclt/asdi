<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_matricula_mover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_matricula_mover))
        Me.lbl_aula = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbx_horario = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_periodo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_curso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.cbx_grupo_origen = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lchk_grupo_origen = New System.Windows.Forms.CheckedListBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.cbx_grupo_destino = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lchk_grupo_destino = New System.Windows.Forms.CheckedListBox()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_aula
        '
        Me.lbl_aula.AutoSize = True
        Me.lbl_aula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aula.Location = New System.Drawing.Point(235, 9)
        Me.lbl_aula.Name = "lbl_aula"
        Me.lbl_aula.Size = New System.Drawing.Size(250, 18)
        Me.lbl_aula.TabIndex = 3
        Me.lbl_aula.Text = "CAMBIO DE TURNO/ HORARIO"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 35)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_horario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_periodo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_curso)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(739, 478)
        Me.SplitContainer1.SplitterDistance = 99
        Me.SplitContainer1.TabIndex = 4
        '
        'cbx_horario
        '
        Me.cbx_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_horario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_horario.FormattingEnabled = True
        Me.cbx_horario.Location = New System.Drawing.Point(187, 37)
        Me.cbx_horario.Name = "cbx_horario"
        Me.cbx_horario.Size = New System.Drawing.Size(318, 23)
        Me.cbx_horario.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "HORARIO"
        '
        'cbx_periodo
        '
        Me.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodo.FormattingEnabled = True
        Me.cbx_periodo.Location = New System.Drawing.Point(186, 6)
        Me.cbx_periodo.Name = "cbx_periodo"
        Me.cbx_periodo.Size = New System.Drawing.Size(318, 23)
        Me.cbx_periodo.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "MES"
        '
        'cbx_curso
        '
        Me.cbx_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_curso.FormattingEnabled = True
        Me.cbx_curso.Location = New System.Drawing.Point(186, 71)
        Me.cbx_curso.Name = "cbx_curso"
        Me.cbx_curso.Size = New System.Drawing.Size(318, 23)
        Me.cbx_curso.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CICLO"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbx_grupo_origen)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lchk_grupo_origen)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(739, 375)
        Me.SplitContainer2.SplitterDistance = 316
        Me.SplitContainer2.TabIndex = 0
        '
        'cbx_grupo_origen
        '
        Me.cbx_grupo_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_grupo_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_grupo_origen.FormattingEnabled = True
        Me.cbx_grupo_origen.Location = New System.Drawing.Point(48, 23)
        Me.cbx_grupo_origen.Name = "cbx_grupo_origen"
        Me.cbx_grupo_origen.Size = New System.Drawing.Size(214, 23)
        Me.cbx_grupo_origen.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "GRUPO ORIGEN"
        '
        'lchk_grupo_origen
        '
        Me.lchk_grupo_origen.FormattingEnabled = True
        Me.lchk_grupo_origen.Location = New System.Drawing.Point(0, 52)
        Me.lchk_grupo_origen.Name = "lchk_grupo_origen"
        Me.lchk_grupo_origen.Size = New System.Drawing.Size(313, 319)
        Me.lchk_grupo_origen.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_Guardar)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.cbx_grupo_destino)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel2.Controls.Add(Me.lchk_grupo_destino)
        Me.SplitContainer3.Size = New System.Drawing.Size(419, 375)
        Me.SplitContainer3.SplitterDistance = 94
        Me.SplitContainer3.TabIndex = 0
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.SistemaAsdi.My.Resources.Resources.right
        Me.btn_Guardar.Location = New System.Drawing.Point(7, 173)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(81, 61)
        Me.btn_Guardar.TabIndex = 28
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'cbx_grupo_destino
        '
        Me.cbx_grupo_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_grupo_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_grupo_destino.FormattingEnabled = True
        Me.cbx_grupo_destino.Location = New System.Drawing.Point(56, 23)
        Me.cbx_grupo_destino.Name = "cbx_grupo_destino"
        Me.cbx_grupo_destino.Size = New System.Drawing.Size(214, 23)
        Me.cbx_grupo_destino.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "GRUPO DESTINO"
        '
        'lchk_grupo_destino
        '
        Me.lchk_grupo_destino.FormattingEnabled = True
        Me.lchk_grupo_destino.Location = New System.Drawing.Point(3, 52)
        Me.lchk_grupo_destino.Name = "lchk_grupo_destino"
        Me.lchk_grupo_destino.Size = New System.Drawing.Size(315, 319)
        Me.lchk_grupo_destino.TabIndex = 0
        '
        'frm_matricula_mover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(742, 513)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lbl_aula)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_matricula_mover"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Turno / Horario"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_aula As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lchk_grupo_origen As System.Windows.Forms.CheckedListBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lchk_grupo_destino As System.Windows.Forms.CheckedListBox
    Friend WithEvents cbx_curso As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbx_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cbx_grupo_origen As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_grupo_destino As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_horario As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
