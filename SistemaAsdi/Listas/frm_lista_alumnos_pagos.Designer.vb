<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lista_alumnos_pagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lista_alumnos_pagos))
        Me.Cb_Alumno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_alumnos = New System.Windows.Forms.Label()
        Me.DgvNotas = New System.Windows.Forms.DataGridView()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.cbx_periodo = New System.Windows.Forms.ComboBox()
        Me.DTPfinal = New System.Windows.Forms.DateTimePicker()
        Me.DTPinicial = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Gpb_2 = New System.Windows.Forms.GroupBox()
        Me.Gpb_1 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gpb_2.SuspendLayout()
        Me.Gpb_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cb_Alumno
        '
        Me.Cb_Alumno.FormattingEnabled = True
        Me.Cb_Alumno.Location = New System.Drawing.Point(99, 71)
        Me.Cb_Alumno.Name = "Cb_Alumno"
        Me.Cb_Alumno.Size = New System.Drawing.Size(257, 21)
        Me.Cb_Alumno.TabIndex = 931
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 930
        Me.Label1.Text = "Alumno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 932
        Me.Label2.Text = "Mes:"
        '
        'lbl_alumnos
        '
        Me.lbl_alumnos.AutoSize = True
        Me.lbl_alumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alumnos.Location = New System.Drawing.Point(207, 24)
        Me.lbl_alumnos.Name = "lbl_alumnos"
        Me.lbl_alumnos.Size = New System.Drawing.Size(295, 18)
        Me.lbl_alumnos.TabIndex = 934
        Me.lbl_alumnos.Text = "REPORTE DE PAGOS POR ALUMNO"
        '
        'DgvNotas
        '
        Me.DgvNotas.AllowUserToAddRows = False
        Me.DgvNotas.AllowUserToDeleteRows = False
        Me.DgvNotas.AllowUserToOrderColumns = True
        Me.DgvNotas.AllowUserToResizeRows = False
        Me.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNotas.Location = New System.Drawing.Point(-1, 198)
        Me.DgvNotas.Name = "DgvNotas"
        Me.DgvNotas.ReadOnly = True
        Me.DgvNotas.RowHeadersVisible = False
        Me.DgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNotas.Size = New System.Drawing.Size(718, 375)
        Me.DgvNotas.TabIndex = 935
        '
        'btn_reporte
        '
        Me.btn_reporte.Image = Global.SistemaAsdi.My.Resources.Resources.Bar_Chart
        Me.btn_reporte.Location = New System.Drawing.Point(634, 101)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(56, 58)
        Me.btn_reporte.TabIndex = 936
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'cbx_periodo
        '
        Me.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodo.FormattingEnabled = True
        Me.cbx_periodo.Location = New System.Drawing.Point(61, 26)
        Me.cbx_periodo.Name = "cbx_periodo"
        Me.cbx_periodo.Size = New System.Drawing.Size(132, 23)
        Me.cbx_periodo.TabIndex = 937
        '
        'DTPfinal
        '
        Me.DTPfinal.CustomFormat = "yyyy-MM-dd"
        Me.DTPfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPfinal.Location = New System.Drawing.Point(236, 26)
        Me.DTPfinal.Name = "DTPfinal"
        Me.DTPfinal.Size = New System.Drawing.Size(111, 24)
        Me.DTPfinal.TabIndex = 939
        '
        'DTPinicial
        '
        Me.DTPinicial.CustomFormat = "yyyy-MM-dd"
        Me.DTPinicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPinicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPinicial.Location = New System.Drawing.Point(50, 26)
        Me.DTPinicial.Name = "DTPinicial"
        Me.DTPinicial.Size = New System.Drawing.Size(111, 24)
        Me.DTPinicial.TabIndex = 938
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(173, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 941
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 18)
        Me.Label3.TabIndex = 940
        Me.Label3.Text = "De:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(391, 71)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 20)
        Me.RadioButton1.TabIndex = 942
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Por Mes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(475, 72)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(134, 20)
        Me.RadioButton2.TabIndex = 943
        Me.RadioButton2.Text = "Rango de Fechas"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Gpb_2
        '
        Me.Gpb_2.Controls.Add(Me.Label4)
        Me.Gpb_2.Controls.Add(Me.Label3)
        Me.Gpb_2.Controls.Add(Me.DTPinicial)
        Me.Gpb_2.Controls.Add(Me.DTPfinal)
        Me.Gpb_2.Location = New System.Drawing.Point(244, 97)
        Me.Gpb_2.Name = "Gpb_2"
        Me.Gpb_2.Size = New System.Drawing.Size(365, 62)
        Me.Gpb_2.TabIndex = 944
        Me.Gpb_2.TabStop = False
        Me.Gpb_2.Visible = False
        '
        'Gpb_1
        '
        Me.Gpb_1.Controls.Add(Me.cbx_periodo)
        Me.Gpb_1.Controls.Add(Me.Label2)
        Me.Gpb_1.Location = New System.Drawing.Point(27, 98)
        Me.Gpb_1.Name = "Gpb_1"
        Me.Gpb_1.Size = New System.Drawing.Size(211, 62)
        Me.Gpb_1.TabIndex = 945
        Me.Gpb_1.TabStop = False
        Me.Gpb_1.Visible = False
        '
        'frm_lista_alumnos_pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 575)
        Me.Controls.Add(Me.Gpb_1)
        Me.Controls.Add(Me.Gpb_2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.DgvNotas)
        Me.Controls.Add(Me.lbl_alumnos)
        Me.Controls.Add(Me.Cb_Alumno)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_lista_alumnos_pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Pagos por Alumnos"
        CType(Me.DgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gpb_2.ResumeLayout(False)
        Me.Gpb_2.PerformLayout()
        Me.Gpb_1.ResumeLayout(False)
        Me.Gpb_1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cb_Alumno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_alumnos As System.Windows.Forms.Label
    Friend WithEvents DgvNotas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents cbx_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents DTPfinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPinicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Gpb_2 As System.Windows.Forms.GroupBox
    Friend WithEvents Gpb_1 As System.Windows.Forms.GroupBox
End Class
