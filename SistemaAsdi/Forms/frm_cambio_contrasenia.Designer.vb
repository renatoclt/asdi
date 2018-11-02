<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cambio_contrasenia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cambio_contrasenia))
        Me.lbl_mensaje = New System.Windows.Forms.Label
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_ok = New System.Windows.Forms.Button
        Me.txt_contrasenia_repetir = New System.Windows.Forms.TextBox
        Me.txt_constrasenia = New System.Windows.Forms.TextBox
        Me.lbl_constrasenia2 = New System.Windows.Forms.Label
        Me.lbl_constrasenia1 = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_usuario = New System.Windows.Forms.Label
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensaje.ForeColor = System.Drawing.Color.Red
        Me.lbl_mensaje.Location = New System.Drawing.Point(150, 101)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(53, 13)
        Me.lbl_mensaje.TabIndex = 16
        Me.lbl_mensaje.Text = "mensaje"
        Me.lbl_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(176, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(163, 13)
        Me.lbl_titulo.TabIndex = 15
        Me.lbl_titulo.Text = "CAMBIO DE CONTRASEÑA"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(262, 117)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(94, 23)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.Text = "&Cancel"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(162, 117)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(94, 23)
        Me.btn_ok.TabIndex = 13
        Me.btn_ok.Text = "&OK"
        '
        'txt_contrasenia_repetir
        '
        Me.txt_contrasenia_repetir.Location = New System.Drawing.Point(244, 79)
        Me.txt_contrasenia_repetir.Name = "txt_contrasenia_repetir"
        Me.txt_contrasenia_repetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contrasenia_repetir.Size = New System.Drawing.Size(120, 20)
        Me.txt_contrasenia_repetir.TabIndex = 12
        '
        'txt_constrasenia
        '
        Me.txt_constrasenia.Location = New System.Drawing.Point(244, 52)
        Me.txt_constrasenia.Name = "txt_constrasenia"
        Me.txt_constrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_constrasenia.Size = New System.Drawing.Size(120, 20)
        Me.txt_constrasenia.TabIndex = 10
        '
        'lbl_constrasenia2
        '
        Me.lbl_constrasenia2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_constrasenia2.Location = New System.Drawing.Point(141, 76)
        Me.lbl_constrasenia2.Name = "lbl_constrasenia2"
        Me.lbl_constrasenia2.Size = New System.Drawing.Size(97, 23)
        Me.lbl_constrasenia2.TabIndex = 11
        Me.lbl_constrasenia2.Text = "Repita:"
        Me.lbl_constrasenia2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_constrasenia1
        '
        Me.lbl_constrasenia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_constrasenia1.Location = New System.Drawing.Point(141, 50)
        Me.lbl_constrasenia1.Name = "lbl_constrasenia1"
        Me.lbl_constrasenia1.Size = New System.Drawing.Size(97, 23)
        Me.lbl_constrasenia1.TabIndex = 8
        Me.lbl_constrasenia1.Text = "Contraseña:"
        Me.lbl_constrasenia1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.SistemaAsdi.My.Resources.Resources.Login
        Me.LogoPictureBox.Location = New System.Drawing.Point(-1, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(136, 151)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.Red
        Me.lbl_usuario.Location = New System.Drawing.Point(259, 27)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(97, 23)
        Me.lbl_usuario.TabIndex = 18
        Me.lbl_usuario.Text = "Usuario:"
        Me.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_cambio_contrasenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(394, 152)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_contrasenia_repetir)
        Me.Controls.Add(Me.txt_constrasenia)
        Me.Controls.Add(Me.lbl_constrasenia2)
        Me.Controls.Add(Me.lbl_constrasenia1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_cambio_contrasenia"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambio de contraseña"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents txt_contrasenia_repetir As System.Windows.Forms.TextBox
    Friend WithEvents txt_constrasenia As System.Windows.Forms.TextBox
    Friend WithEvents lbl_constrasenia2 As System.Windows.Forms.Label
    Friend WithEvents lbl_constrasenia1 As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
End Class
