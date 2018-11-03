Public Class frm_matricula_examen
    Private frm_alumno_buscar_ As frm_alumno_buscar
    Public frm_alumno_buscar_activo As Boolean = False
    Dim obj As New Cls_Matricula
    Dim id_alumno_ficha As Integer
    Dim num_telefono As String
    Dim id_persona As String
    Dim id_plan_estudio As String
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        frm_alumno_buscar_activo = False
        'frm_alumno_buscar.ShowDialog()
        If (Not frm_alumno_buscar_activo) Then
            frm_alumno_buscar_ = New frm_alumno_buscar
            frm_alumno_buscar_.Show()
            frm_alumno_buscar_.Formnulario_Matricular_Examen(Me, "frm_matricula_examen")
            frm_alumno_buscar_activo = True
        Else
            frm_alumno_buscar_.Activate()
        End If
    End Sub
    Public Sub Buscar_nombre_persona(ByVal a As String)
        txt_nombre.Text = obj.consulta_nombre_persona(a)
        txt_tipo_alumno.Text = obj.consulta_tipo_alumno(a)
        txt_plan_estudio.Text = obj.consulta_plan_estudios(a)
        id_alumno_ficha = Convert.ToInt32(a)
        id_plan_estudio = obj.consulta_id_plan_estudios(a)
        obj.Llenar_horario(CbHorario, Convert.ToString(id_plan_estudio))
    End Sub

    Private Sub frm_matricula_examen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_periodo(cbx_periodo)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'obj.guardar_datos_matricula(id_alumno_ficha, Convert.ToInt32(cbx_periodo.SelectedValue), TxtObservaciones.Text, txt_nombre.Text, Convert.ToInt32(CbHorario.SelectedValue))

        If (MessageBox.Show("Desea imprimir el recibo", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            obj.guardar_datos_matricula(id_alumno_ficha, Convert.ToInt32(cbx_periodo.SelectedValue), TxtObservaciones.Text, txt_nombre.Text, Convert.ToInt32(CbHorario.SelectedValue))
            PrintDialog1.Document = PrintDocument1
            Dim TamaoPersonal As Printing.PaperSize
            Dim Ancho As Short
            Dim Alto As Short
            Ancho = 500
            Alto = 400
            TamaoPersonal = New Printing.PaperSize("A4", Ancho, Alto)

            'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = 9
            PrintDocument1.DefaultPageSettings.PaperSize = TamaoPersonal
            'PrintDocument1.DefaultPageSettings.Landscape = True
            PrintDocument1.PrinterSettings.PrinterName = _impresora_a_usar
            PrintDocument1.Print()
            'End If
            limpiar()
        End If


    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Public Sub limpiar()
        txt_nombre.Clear()
        txt_tipo_alumno.Clear()
        txt_plan_estudio.Clear()
        TxtObservaciones.Clear()
        id_alumno_ficha = 0
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim num As String = _correlativo_boleta
        Dim x As Integer = recibo_x
        Dim y As Integer = recibo_y
        Dim costo As String = obj.consulta_costo_horario(Convert.ToString(CbHorario.SelectedValue))
        num_telefono = Convert.ToString(obj.consulta_num_telefono(Convert.ToString(id_alumno_ficha)))
        id_persona = Convert.ToString(obj.consulta_id_persona(Convert.ToString(id_alumno_ficha)))

        e.Graphics.DrawString(num, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 110, y + 40)
        e.Graphics.DrawString(txt_nombre.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 60)

        e.Graphics.DrawString("MENSUALIDAD", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 110)
        e.Graphics.DrawString(String.Format("{0:C}", Convert.ToDouble(costo)), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 40)
        e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble(costo))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 170)
        e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble(costo))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 230)
        e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble("0"))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 190)

        e.Graphics.DrawString(Convert.ToString(obj.Letras(Convert.ToString(costo))) + " /100 ", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 80)
        e.Graphics.DrawString(Convert.ToString(Now.ToString("yyyy-MM-dd")), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 80)
        'e.Graphics.DrawString(nom_curso, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 50, 190)
        'e.Graphics.DrawString(nom_grupo, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 50, 205)
        'e.Graphics.DrawString(Convert.ToString(Txt_seccion.Text), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 50, 220)
        e.Graphics.DrawString(CbHorario.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 185)
        e.Graphics.DrawString("-----Obs.", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 200)
        e.Graphics.DrawString(num_telefono, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 215)
        e.Graphics.DrawString(id_persona, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 230)
        e.Graphics.DrawString("Usuario: " + nombre_usuario, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 150, y + 240)

    End Sub
End Class