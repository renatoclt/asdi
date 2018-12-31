Public Class frm_ventas_otros
    Dim obj As New Cls_Matricula
    Dim obje As New Cls_Tramite
    Dim id_alumno_ficha As Integer
    Dim id_periodo As Integer
    Dim id_grupo As Integer

    Private frm_alumno_buscar_ As Frm_alumno_buscar_actualizar
    Public frm_alumno_buscar_activo As Boolean = False
    Dim monto As String

    Dim nom_curso As String
    Dim nom_grupo As String
    Dim seccion As String
    Dim horario_grupo As String
    Dim num_telefono As String
    Dim id_persona As String
    Dim id_matricula_imp As Integer
    Dim id_curso_imp As Integer
    Dim id_curso_grupo As Integer
    Dim observaciones As String
    Dim _precio As Double
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If (Not frm_alumno_buscar_activo) Then
            frm_alumno_buscar_ = New Frm_alumno_buscar_actualizar
            frm_alumno_buscar_.Show()
            'frm_alumno_buscar_.Formnulario_Ventas(Me, "frm_ventas")
            frm_alumno_buscar_activo = True
        Else
            frm_alumno_buscar_.Activate()
        End If
    End Sub
    Public Sub Buscar_nombre_persona(ByVal a As String, ByVal b As String)
        txt_nombre.Text = obj.consulta_nombre_persona(a)
        id_alumno_ficha = Convert.ToInt32(a)
        id_periodo = Convert.ToInt32(b)
        id_grupo = obj.Obtener_id_grupo_curso(a, b)
        txt_ciclo.Text = Convert.ToString(obj.consulta_curso_nombre2(id_grupo))
        id_curso_grupo = Convert.ToInt32(id_grupo)
        nom_curso = Convert.ToString(obj.consulta_curso_nombre(Convert.ToString(id_grupo)))
        txtnomcur.Text = nom_curso
        nom_grupo = Convert.ToString(obj.consulta_nombre_grupo(Convert.ToString(id_grupo)))
        seccion = Convert.ToString(obj.consulta_aula(Convert.ToString(id_grupo)))
        horario_grupo = Convert.ToString(obj.consulta_horario(Convert.ToString(id_grupo)))
        num_telefono = Convert.ToString(obj.consulta_num_telefono(Convert.ToString(id_alumno_ficha)))
        id_persona = Convert.ToString(obj.consulta_id_persona(Convert.ToString(id_alumno_ficha)))
        id_matricula_imp = Convert.ToInt32(obj.consulta_id_matricula(Convert.ToString(id_alumno_ficha), Convert.ToString(id_grupo), Convert.ToString(id_periodo)))
        id_curso_imp = Convert.ToInt32(obj.consulta_curso_grupo(Convert.ToString(id_grupo)))
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Try
            If txt_nombre.Text = "" Or txtConcepto.Text = "" Or txt_precio.Text = "" Then
                MsgBox("Llene todos los datos")
            Else
                If (MessageBox.Show("Desea imprimir el recibo", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Dim TamaoPersonal As Printing.PaperSize
                    Dim Ancho As Short
                    Dim Alto As Short
                    Ancho = 500
                    Alto = 400
                    TamaoPersonal = New Printing.PaperSize("A4", Ancho, Alto)
                    _precio = Convert.ToDouble(txt_precio.Text)

                    monto = Convert.ToString(Format(_precio, "##0.00"))
                    obje.guardar_datos_recibo_ventas(Convert.ToDouble(monto), Convert.ToString(txt_nombre.Text), id_alumno_ficha)
                    PrintDialog1.Document = PrintDocument1
                    PrintDocument1.DefaultPageSettings.PaperSize = TamaoPersonal
                    PrintDocument1.PrinterSettings.PrinterName = _impresora_a_usar
                    PrintDocument1.Print()

                    limpiar()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiar()
        txt_nombre.Clear()
        txt_ciclo.Clear()
        txtConcepto.Clear()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim num As String = _correlativo_boleta
        Dim x As Integer = recibo_x
        Dim y As Integer = recibo_y
        e.Graphics.DrawString(num, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 110, y + 40)
        e.Graphics.DrawString(txt_nombre.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 60)

        e.Graphics.DrawString("OTROS CONCEPTOS: " + txtConcepto.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 110)
        e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 40)
        e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 170)
        e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 230)
        e.Graphics.DrawString("S/. 0.00", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 190)
        e.Graphics.DrawString(Convert.ToString(obj.Letras(monto)) + " /100 ", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 80)

        e.Graphics.DrawString(Convert.ToString(Now.ToString("yyyy-MM-dd")), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 80)
        e.Graphics.DrawString(nom_curso, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 140)
        e.Graphics.DrawString(nom_grupo, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 155)
        e.Graphics.DrawString(seccion, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 170)
        e.Graphics.DrawString(horario_grupo, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 185)
        e.Graphics.DrawString("-----Obs.", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 200)
        e.Graphics.DrawString(num_telefono, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 215)
        e.Graphics.DrawString(id_persona, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 230)
        e.Graphics.DrawString("Usuario: " + nombre_usuario, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 150, y + 240)

    End Sub

    Private Sub frm_ventas_otros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_codigo_recibo.Text = obj.generar_codigo_correlativo()
        _correlativo_boleta = txt_codigo_recibo.Text
    End Sub
End Class