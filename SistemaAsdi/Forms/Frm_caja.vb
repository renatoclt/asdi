Public Class Frm_caja
    Dim obj As New Cls_Caja
    Dim tipo As String
    'SELECT * FROM tipo_tramite t;
    'SELECT * FROM boleta b;
    'SELECT * FROM recibo r;
    'SELECT * FROM matricula m;
    'SELECT * FROM curso_grupo c;
    'SELECT * FROM alumno_ficha a;
    'SELECT * FROM persona p;
    'SELECT * FROM aula u;
    'SELECT p.nombres, m.id_periodo, c.nombre_grupo, c.id_horario, u.aula, b.fecha_creacion, b.nro_boleta from persona p, alumno_ficha a, matricula m, recibo r, boleta b, curso_grupo c, aula u where  p.id_persona = a.id_persona and  a.id_alumno_ficha = m.id_alumno_ficha and r.id_matricula = m.id_matricula and b.id_recibo = r.id_recibo and b.fecha_creacion BETWEEN '2014-03-03' AND '2014-03-05' and c.id_curso_grupo = m.id_curso_grupo and c.id_aula = u.id_aula;
    'SELECT b.id_boleta, b.nombre, r.concepto, c.nombre_grupo, u.aula, r.fecha_creacion, r.hora, b.nro_boleta, r.monto, r.descuento, r.total  FROM boleta b, recibo r, curso_grupo c, aula u where b.id_recibo =r.id_recibo and c.id_curso_grupo=r.id_curso_grupo and u.id_aula =c.id_aula and r.fecha_creacion BETWEEN '2014-03-03' AND '2014-03-06' ;

    Private Sub Frm_caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TLentrada.Text = "0"
        If Cb_tipo.Text = "" Then
            MsgBox("Porfavor seleccionar un tipo")
        ElseIf Cb_tipo.Text = "Detallado" Then
            obj.llenar_listview_detallado(LvEntrada)
            obj.mostrarDatosCaja(LvEntrada, DTPinicial.Text, DTPfinal.Text, TLentrada)
            tipo = "Detallado"
        ElseIf Cb_tipo.Text = "Resumido" Then
            obj.llenar_listview_concepto(LvEntrada)
            obj.mostrarDatosCaja_Concepto(LvEntrada, DTPinicial.Text, DTPfinal.Text, TLentrada)
            If LvEntrada.Items.Count = 0 Then
                tipo = "Resumido Vacio"
            ElseIf LvEntrada.Items.Count >= 1 Then
                tipo = "Resumido"
            End If
        End If
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        Dim PrintPreview As New PrintPreviewDialog
        PrintPreview.Document = PrintDocument1
        'PrintDocument1.DefaultPageSettings.Landscape = True
        'PrintPreview.ShowDialog()
        PrintDocument1.PrinterSettings.PrinterName = _impresora_a_usar
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If LvEntrada.View = View.Details Then
            PrintDetails(e)
        End If
    End Sub
    Private Sub PrintDetails(ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        If tipo = "Resumido Vacio" Then
            e.Graphics.DrawString("MOVIMIENTOS CAJA - ASDI", New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, 60, 20)
            e.Graphics.DrawString("________________________________________________________________________________", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 32)
            e.Graphics.DrawString("Tipo: Resumido", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 50)
            e.Graphics.DrawString(Label3.Text + " " + DTPinicial.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 240, 50)
            e.Graphics.DrawString(Label4.Text + " " + DTPfinal.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 50)
            'e.Graphics.DrawString(Label8.Text + " " + CbTipoPag.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 50)
            e.Graphics.DrawString("Hora: " + Now.ToString("HH:mm:ss"), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 70)
            e.Graphics.DrawString("Fecha: " + Now.ToString("yyyy-MM-dd"), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 240, 70)
            'e.Graphics.DrawString("Boletas Serie del " + Convert.ToString(correlativo_inicial) + " al " + Convert.ToString(correlativo_final), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 500, 70)
            e.Graphics.DrawString("________________________________________________________________________________", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 75)
            e.Graphics.DrawString("CUMPLIMOS CON INFORMAR QUE EN EL PRESENTE DIA, NO HUBO INGRESOS EN CAJA", New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, 60, 100)
            e.Graphics.DrawString("     __________________     __________________     __________________", New Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 170)
            e.Graphics.DrawString("                Tesoreria                            Operador                             V B°", New Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 190)
            e.Graphics.DrawString("                                                           Informes y Matriculas", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 210)
            e.Graphics.DrawString("Dpto. Informatica", New Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 60, 230)
        Else
            Static LastIndex As Integer = 0
            Static CurrentPage As Integer = 0
            'Getting the current dpi so the textleftpad
            'will be the same on a different dpi than
            'the 96 i'm using. Won't make much of a difference though.
            Dim DpiGraphics As Graphics = Me.CreateGraphics
            Dim DpiX As Integer = DpiGraphics.DpiX
            Dim DpiY As Integer = DpiGraphics.DpiY
            DpiGraphics.Dispose()
            Dim X, Y As Integer
            Dim ImageWidth As Integer
            Dim TextRect As Rectangle = Rectangle.Empty
            Dim TextLeftPad As Single = CSng(4 * (DpiX / 96)) '4 pixel pad on the left.
            Dim ColumnHeaderHeight As Single = CSng(LvEntrada.Font.Height + (10 * (DpiX / 96))) '5 pixel pad on the top an bottom
            Dim StringFormat As New StringFormat
            Dim PageNumberWidth As Single = e.Graphics.MeasureString(CStr(CurrentPage), LvEntrada.Font).Width
            'Specify the text should be drawn in the center of the line and
            'that the text should not be wrapped and the text should show
            'ellipsis would cut off.
            StringFormat.FormatFlags = StringFormatFlags.NoWrap
            StringFormat.Trimming = StringTrimming.EllipsisCharacter
            StringFormat.LineAlignment = StringAlignment.Center
            CurrentPage += 1
            'Start the x and y at the top left margin.
            'X = CInt(e.MarginBounds.X)
            X = CInt(60)
            Y = CInt(e.MarginBounds.Y)
            If tipo = "Detallado" Then
                e.Graphics.DrawString("MOVIMIENTOS CAJA - ASDI", New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, 60, 20)
                e.Graphics.DrawString("__________________________________________________________________________________________________________", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 32)
                e.Graphics.DrawString("Tipo: Detallado", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 50)
                e.Graphics.DrawString(Label3.Text + " " + DTPinicial.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 240, 50)
                e.Graphics.DrawString(Label4.Text + " " + DTPfinal.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 50)
                'e.Graphics.DrawString(Label8.Text + " " + CbTipoPag.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 50)
                e.Graphics.DrawString("Hora: " + Now.ToString("HH:mm:ss"), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 70)
                e.Graphics.DrawString("Fecha: " + Now.ToString("yyyy-MM-dd"), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 240, 70)
                e.Graphics.DrawString("Boletas Serie del " + Convert.ToString(obj.generar_codigo_boleta(correlativo_inicial)) + " al " + Convert.ToString(obj.generar_codigo_boleta(correlativo_final)), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 70)
                e.Graphics.DrawString("__________________________________________________________________________________________________________", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 75)
                'e.Graphics.DrawString(Label9.Text + " " + LblTick.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 500, 70)
            ElseIf tipo = "Resumido" Then
                e.Graphics.DrawString("MOVIMIENTOS CAJA - ASDI", New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, 60, 20)
                e.Graphics.DrawString("________________________________________________________________________________", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 32)
                e.Graphics.DrawString("Tipo: Resumido", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 50)
                e.Graphics.DrawString(Label3.Text + " " + DTPinicial.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 240, 50)
                e.Graphics.DrawString(Label4.Text + " " + DTPfinal.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 50)
                'e.Graphics.DrawString(Label8.Text + " " + CbTipoPag.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 50)
                e.Graphics.DrawString("Hora: " + Now.ToString("HH:mm:ss"), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 70)
                e.Graphics.DrawString("Fecha: " + Now.ToString("yyyy-MM-dd"), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 240, 70)
                e.Graphics.DrawString("Boletas Serie del " + Convert.ToString(obj.generar_codigo_boleta(correlativo_inicial)) + " al " + Convert.ToString(obj.generar_codigo_boleta(correlativo_final)), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 70)
                e.Graphics.DrawString("________________________________________________________________________________", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, 75)
                'e.Graphics.DrawString(Label9.Text + " " + LblTick.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 440, 70)
            End If

            'Draw the column headers
            For ColumnIndex As Integer = 0 To LvEntrada.Columns.Count - 1
                TextRect.X = X
                TextRect.Y = Y
                TextRect.Width = LvEntrada.Columns(ColumnIndex).Width
                TextRect.Height = ColumnHeaderHeight
                e.Graphics.FillRectangle(Brushes.LightGray, TextRect)
                e.Graphics.DrawRectangle(Pens.DarkGray, TextRect)
                'TextLeftPad adds a little padding from the gridline.
                'Add it to the left and subtract it from the right.
                TextRect.X += TextLeftPad
                TextRect.Width -= TextLeftPad
                e.Graphics.DrawString(LvEntrada.Columns(ColumnIndex).Text, LvEntrada.Font, Brushes.Black, TextRect, StringFormat)
                'Move the x position over the width of the column width.
                'Since I subtracted some padding add the padding back
                'when offsetting.
                X += TextRect.Width + TextLeftPad
            Next
            'Just drew the headers. Move the Y down the height
            'of the column headers.
            Y += ColumnHeaderHeight
            'Now draw the items. If this is the first page then the
            'last index will be zero. If its not then the last index
            'will be the last index we tried to draw but had no room.
            For i = LastIndex To LvEntrada.Items.Count - 1
                With LvEntrada.Items(i)
                    'Start the x at the pages left margin.
                    'X = CInt(e.MarginBounds.X)
                    X = CInt(60)
                    'Check for Last Line
                    If Y + .Bounds.Height > e.MarginBounds.Bottom Then
                        'This item won't fit.
                        'subtract 1 from i so the next time this sub
                        'is entered we can start with this item.
                        LastIndex = i - 1
                        e.HasMorePages = True
                        StringFormat.Dispose()
                        'Draw the current page number before leaving.
                        e.Graphics.DrawString(CStr(CurrentPage), LvEntrada.Font, Brushes.Black, (e.PageBounds.Width - PageNumberWidth) / 2, e.PageBounds.Bottom - LvEntrada.Font.Height * 2)
                        Exit Sub
                    End If
                    'Print Images.
                    'The image width is used so we can draw the gridline
                    'around the image about to be drawn. You'll see it
                    'below.
                    ImageWidth = 0
                    If LvEntrada.SmallImageList IsNot Nothing Then
                        'If the image key is set then draw the image
                        'with the key . If not draw the image with the
                        'index. A tiny bit of validation would be good.
                        If Not String.IsNullOrEmpty(.ImageKey) Then
                            e.Graphics.DrawImage(LvEntrada.SmallImageList.Images(.ImageKey), X, Y)
                        ElseIf .ImageIndex >= 0 Then
                            e.Graphics.DrawImage(LvEntrada.SmallImageList.Images(.ImageIndex), X, Y)
                        End If
                        ImageWidth = LvEntrada.SmallImageList.ImageSize.Width
                    End If
                    'Now draw the subitems. using the columns count so the
                    'grid lines can be drawn. If used the subitems count then
                    'the table would not be full if some subitems where less
                    'than others.
                    For ColumnIndex As Integer = 0 To LvEntrada.Columns.Count - 1
                        TextRect.X = X
                        TextRect.Y = Y
                        TextRect.Width = LvEntrada.Columns(ColumnIndex).Width
                        TextRect.Height = .Bounds.Height
                        If LvEntrada.GridLines Then
                            'e.Graphics.DrawRectangle(Pens.DarkGray, TextRect)
                            e.Graphics.DrawRectangle(Pens.White, TextRect)
                        End If
                        'If an image is drawn then shift over the x to
                        'accomadate its width. If this was shifted before
                        'now then the gridline with draw rect above would be
                        ' on the wrong side of the image.
                        If ColumnIndex = 0 Then TextRect.X += ImageWidth
                        'Add a little padding from the gridline.
                        TextRect.X += TextLeftPad
                        TextRect.Width -= TextLeftPad
                        If ColumnIndex < .SubItems.Count Then
                            'This item has at least the same number of
                            'subitems as the current column index.
                            e.Graphics.DrawString(.SubItems(ColumnIndex).Text, LvEntrada.Font, Brushes.Black, TextRect, StringFormat)
                        End If
                        'Shift the x of the width of this subitem.
                        'Add some padding to the left side of the text
                        'so need to add it back.
                        X += TextRect.Width + TextLeftPad
                    Next
                    'Set the next line
                    Y += .Bounds.Height
                End With
            Next
            'Draw the final page number.
            If tipo = "Detallado" Then
                e.Graphics.DrawString(Label7.Text + " " + TLentrada.Text, New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, 60, Y + 10)
                e.Graphics.DrawString("Dpto. Informatica", New Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 60, Y + 50)
                e.Graphics.DrawString(CStr(CurrentPage), LvEntrada.Font, Brushes.Black, (e.PageBounds.Width - PageNumberWidth) / 2, e.PageBounds.Bottom - LvEntrada.Font.Height * 2)
            ElseIf tipo = "Resumido" Then
                e.Graphics.DrawString(Label7.Text + " " + TLentrada.Text, New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, 60, Y + 10)
                e.Graphics.DrawString("________________________________________________________________________________", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 60, Y + 30)
                e.Graphics.DrawString("Resumen de Comprobantes Emitidos", New Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, Y + 70)
                e.Graphics.DrawString("Boletas Serie ..............   Del: ............. Al: ..............", New Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, Y + 90)
                e.Graphics.DrawString("     __________________     __________________     __________________", New Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, Y + 150)
                e.Graphics.DrawString("                Tesoreria                            Operador                             V B°", New Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, Y + 170)
                e.Graphics.DrawString("                                                           Informes y Matriculas", New Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 60, Y + 210)
                e.Graphics.DrawString("Dpto. Informatica", New Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 60, Y + 230)
            End If
            StringFormat.Dispose()
            LastIndex = 0
            CurrentPage = 0
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub
End Class