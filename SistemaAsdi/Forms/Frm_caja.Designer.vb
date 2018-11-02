<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_caja))
        Me.TLentrada = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LvEntrada = New System.Windows.Forms.ListView()
        Me.DTPfinal = New System.Windows.Forms.DateTimePicker()
        Me.DTPinicial = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Imprimir = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_tipo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TLentrada
        '
        Me.TLentrada.AutoSize = True
        Me.TLentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLentrada.ForeColor = System.Drawing.Color.Black
        Me.TLentrada.Location = New System.Drawing.Point(824, 606)
        Me.TLentrada.Name = "TLentrada"
        Me.TLentrada.Size = New System.Drawing.Size(19, 20)
        Me.TLentrada.TabIndex = 925
        Me.TLentrada.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(650, 601)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 25)
        Me.Label7.TabIndex = 924
        Me.Label7.Text = "Total Ingreso:"
        '
        'LvEntrada
        '
        Me.LvEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvEntrada.FullRowSelect = True
        Me.LvEntrada.GridLines = True
        Me.LvEntrada.HideSelection = False
        Me.LvEntrada.Location = New System.Drawing.Point(31, 127)
        Me.LvEntrada.Name = "LvEntrada"
        Me.LvEntrada.Size = New System.Drawing.Size(910, 454)
        Me.LvEntrada.TabIndex = 923
        Me.LvEntrada.UseCompatibleStateImageBehavior = False
        '
        'DTPfinal
        '
        Me.DTPfinal.CustomFormat = "yyyy-MM-dd"
        Me.DTPfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPfinal.Location = New System.Drawing.Point(372, 81)
        Me.DTPfinal.Name = "DTPfinal"
        Me.DTPfinal.Size = New System.Drawing.Size(146, 24)
        Me.DTPfinal.TabIndex = 918
        '
        'DTPinicial
        '
        Me.DTPinicial.CustomFormat = "yyyy-MM-dd"
        Me.DTPinicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPinicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPinicial.Location = New System.Drawing.Point(116, 81)
        Me.DTPinicial.Name = "DTPinicial"
        Me.DTPinicial.Size = New System.Drawing.Size(146, 24)
        Me.DTPinicial.TabIndex = 917
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(810, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 31)
        Me.Button1.TabIndex = 919
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(291, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 922
        Me.Label4.Text = "Hasta el:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 921
        Me.Label3.Text = "Desde el:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(361, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 29)
        Me.Label2.TabIndex = 920
        Me.Label2.Text = "CONTROL DE CAJA"
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.BackgroundImage = CType(resources.GetObject("btn_Imprimir.BackgroundImage"), System.Drawing.Image)
        Me.btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Imprimir.Location = New System.Drawing.Point(31, 592)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(55, 50)
        Me.btn_Imprimir.TabIndex = 926
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.SistemaAsdi.My.Resources.Resources._Error
        Me.btn_Cancelar.Location = New System.Drawing.Point(92, 592)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(61, 50)
        Me.btn_Cancelar.TabIndex = 927
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(550, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 928
        Me.Label1.Text = "Tipo:"
        '
        'Cb_tipo
        '
        Me.Cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_tipo.FormattingEnabled = True
        Me.Cb_tipo.Items.AddRange(New Object() {"Detallado", "Resumido"})
        Me.Cb_tipo.Location = New System.Drawing.Point(602, 81)
        Me.Cb_tipo.Name = "Cb_tipo"
        Me.Cb_tipo.Size = New System.Drawing.Size(146, 21)
        Me.Cb_tipo.TabIndex = 929
        '
        'Frm_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 656)
        Me.Controls.Add(Me.Cb_tipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Imprimir)
        Me.Controls.Add(Me.TLentrada)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LvEntrada)
        Me.Controls.Add(Me.DTPfinal)
        Me.Controls.Add(Me.DTPinicial)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TLentrada As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LvEntrada As System.Windows.Forms.ListView
    Friend WithEvents DTPfinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPinicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cb_tipo As System.Windows.Forms.ComboBox
End Class
