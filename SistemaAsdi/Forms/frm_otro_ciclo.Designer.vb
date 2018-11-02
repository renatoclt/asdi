<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_otro_ciclo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_otro_ciclo))
        Me.cbx_plan_est = New System.Windows.Forms.ComboBox()
        Me.cbx_tp_est_alumno = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cb_ciclo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbx_plan_est
        '
        Me.cbx_plan_est.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_plan_est.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_plan_est.FormattingEnabled = True
        Me.cbx_plan_est.Location = New System.Drawing.Point(139, 63)
        Me.cbx_plan_est.Name = "cbx_plan_est"
        Me.cbx_plan_est.Size = New System.Drawing.Size(225, 24)
        Me.cbx_plan_est.TabIndex = 30
        '
        'cbx_tp_est_alumno
        '
        Me.cbx_tp_est_alumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tp_est_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_tp_est_alumno.FormattingEnabled = True
        Me.cbx_tp_est_alumno.Location = New System.Drawing.Point(139, 22)
        Me.cbx_tp_est_alumno.Name = "cbx_tp_est_alumno"
        Me.cbx_tp_est_alumno.Size = New System.Drawing.Size(225, 24)
        Me.cbx_tp_est_alumno.TabIndex = 29
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 71)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "PLAN DE ESTUDIOS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "TIPO DE ALUMNO"
        '
        'cb_ciclo
        '
        Me.cb_ciclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ciclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_ciclo.FormattingEnabled = True
        Me.cb_ciclo.Location = New System.Drawing.Point(139, 102)
        Me.cb_ciclo.Name = "cb_ciclo"
        Me.cb_ciclo.Size = New System.Drawing.Size(225, 24)
        Me.cb_ciclo.TabIndex = 40
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 110)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 13)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "CICLO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 34)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 34)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_otro_ciclo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 203)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_ciclo)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbx_plan_est)
        Me.Controls.Add(Me.cbx_tp_est_alumno)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_otro_ciclo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ASDI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbx_plan_est As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_tp_est_alumno As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cb_ciclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
