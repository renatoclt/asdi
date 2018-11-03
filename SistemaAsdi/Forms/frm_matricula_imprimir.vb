Public Class frm_matricula_imprimir
    Dim obj As New Cls_Matricula
    Public id_matricula_imp As Integer
    Public id_alumno_ficha As Integer
    Public id_curso_imp As Integer
    Public nom_curso As String
    Public nom_grupo As String
    Public horario_grupo As String
    Public num_telefono As String
    Public id_persona As String
    Public id_curso_grupo As Integer
    Dim separata_imprimir As Integer = 0
    Dim monto As String
    Dim observaciones As String
    Private Sub frm_matricula_imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Opacity = 0.93
        TxtMonto.Focus()
        LblImportePagar.Text = TxtMonto.Text
    End Sub
    Public Sub limpiar()
        TxtMonto.Clear()
        TxtDescuento.Text = "0.00"
        LblImportePagar.Text = "0.00"
        TxtObservaciones.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        separata_imprimir = 0
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Try
            obj.guardar_datos_recibo(id_matricula_imp, Convert.ToDouble(TxtMonto.Text), Convert.ToDouble(TxtDescuento.Text), Convert.ToDouble(LblImportePagar.Text), id_curso_imp, separata_imprimir, Convert.ToString(txt_nombre.Text), id_curso_grupo, TxtObservaciones.Text, id_alumno_ficha)
            Me.Close()
            'If (MessageBox.Show("Desea imprimir el recibo", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            '    obj.guardar_datos_recibo(id_matricula_imp, Convert.ToDouble(TxtMonto.Text), Convert.ToDouble(TxtDescuento.Text), Convert.ToDouble(LblImportePagar.Text), id_curso_imp, separata_imprimir, Convert.ToString(txt_nombre.Text), id_curso_grupo, TxtObservaciones.Text, id_alumno_ficha)
            '    PrintDialog1.Document = PrintDocument1
            '    Dim TamaoPersonal As Printing.PaperSize
            '    Dim Ancho As Short
            '    Dim Alto As Short
            '    Ancho = 500
            '    Alto = 400
            '    TamaoPersonal = New Printing.PaperSize("A4", Ancho, Alto)


            '    'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = 9
            '    PrintDocument1.DefaultPageSettings.PaperSize = TamaoPersonal
            '    'PrintDocument1.DefaultPageSettings.Landscape = True
            '    PrintDocument1.PrinterSettings.PrinterName = _impresora_a_usar
            '    PrintDocument1.Print()
            '    'End If
            '    If RadioButton1.Checked = True Then
            '        monto = Convert.ToString(Format(_precio_separata, "##0.00"))
            '        separata_imprimir = 1
            '        obj.guardar_datos_recibo(id_matricula_imp, Convert.ToDouble(monto), Convert.ToDouble(0), Convert.ToDouble(monto), id_curso_imp, separata_imprimir, Convert.ToString(txt_nombre.Text), id_curso_grupo, observaciones, id_alumno_ficha)
            '        PrintDialog1.Document = PrintDocument1
            '        'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = 9
            '        PrintDocument1.DefaultPageSettings.PaperSize = TamaoPersonal
            '        'PrintDocument1.DefaultPageSettings.Landscape = True
            '        'PrintPreview.ShowDialog()
            '        PrintDocument1.PrinterSettings.PrinterName = _impresora_a_usar
            '        PrintDocument1.Print()
            '    ElseIf RadioButton2.Checked = True Then
            '        monto = Convert.ToString(Format(_precio_cd + _precio_separata, "##0.00"))
            '        separata_imprimir = 2
            '        obj.guardar_datos_recibo(id_matricula_imp, Convert.ToDouble(monto), Convert.ToDouble(0), Convert.ToDouble(monto), id_curso_imp, separata_imprimir, Convert.ToString(txt_nombre.Text), id_curso_grupo, observaciones, id_alumno_ficha)
            '        PrintDialog1.Document = PrintDocument1
            '        'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = 9
            '        PrintDocument1.DefaultPageSettings.PaperSize = TamaoPersonal
            '        'PrintDocument1.DefaultPageSettings.Landscape = True
            '        'PrintPreview.ShowDialog()
            '        PrintDocument1.PrinterSettings.PrinterName = _impresora_a_usar
            '        PrintDocument1.Print()
            '    ElseIf RadioButton3.Checked = True Then
            '        monto = Convert.ToString(Format(_precio_cd, "##0.00"))
            '        separata_imprimir = 3
            '        obj.guardar_datos_recibo(id_matricula_imp, Convert.ToDouble(monto), Convert.ToDouble(0), Convert.ToDouble(monto), id_curso_imp, separata_imprimir, Convert.ToString(txt_nombre.Text), id_curso_grupo, observaciones, id_alumno_ficha)
            '        PrintDialog1.Document = PrintDocument1
            '        'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = 9
            '        PrintDocument1.DefaultPageSettings.PaperSize = TamaoPersonal
            '        'PrintDocument1.DefaultPageSettings.Landscape = True
            '        'PrintPreview.ShowDialog()
            '        PrintDocument1.PrinterSettings.PrinterName = _impresora_a_usar
            '        PrintDocument1.Print()
            '    End If
            '    limpiar()
            '    Me.Close()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim num As String = _correlativo_boleta
        Dim x As Integer = recibo_x
        Dim y As Integer = recibo_y
        e.Graphics.DrawString(num, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 110, y + 40)
        e.Graphics.DrawString(txt_nombre.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 60)
        If separata_imprimir = 1 Then
            e.Graphics.DrawString("SEPARATA", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 110)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 40)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 170)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 230)
            e.Graphics.DrawString("S/. 0.00", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 190)
            e.Graphics.DrawString(Convert.ToString(obj.Letras(monto)) + " /100 ", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 80)
        ElseIf separata_imprimir = 2 Then
            e.Graphics.DrawString("SEPARATA + CD", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 110)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 40)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 170)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 230)
            e.Graphics.DrawString("S/. 0.00", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 190)
            e.Graphics.DrawString(Convert.ToString(obj.Letras(monto)) + " /100 ", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 80)
        ElseIf separata_imprimir = 3 Then
            e.Graphics.DrawString("CD", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 110)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 40)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 170)
            e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 230)
            e.Graphics.DrawString("S/. 0.00", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 190)
            e.Graphics.DrawString(Convert.ToString(obj.Letras(monto)) + " /100 ", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 80)
        Else
            e.Graphics.DrawString("MENSUALIDAD", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 110)
            e.Graphics.DrawString(String.Format("{0:C}", Convert.ToDouble(LblImportePagar.Text)), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 40)
            e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble(TxtMonto.Text))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 170)
            e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble(LblImportePagar.Text))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 230)
            e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble(TxtDescuento.Text))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 190)
            e.Graphics.DrawString(Convert.ToString(obj.Letras(LblImportePagar.Text)) + " /100 ", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 80)
        End If
        e.Graphics.DrawString(Convert.ToString(Now.ToString("yyyy-MM-dd")), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 80)
        e.Graphics.DrawString(nom_curso, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 140)
        e.Graphics.DrawString(nom_grupo, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 155)
        e.Graphics.DrawString(Convert.ToString(Txt_seccion.Text), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 170)
        e.Graphics.DrawString(horario_grupo, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 185)
        e.Graphics.DrawString("-----Obs.", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 200)
        e.Graphics.DrawString(num_telefono, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 215)
        e.Graphics.DrawString(id_persona, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 230)
        e.Graphics.DrawString("Usuario: " + nombre_usuario, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 150, y + 240)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LblImportePagar.Text = String.Format("{0:N}", Convert.ToDouble(TxtMonto.Text - TxtDescuento.Text))
    End Sub
End Class