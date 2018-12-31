Imports Negocio

Public Class frm_venta_concepto
    Dim obj As New Cls_Matricula
    Dim form_Alumno_buscar_ As New frm_alumno_buscar
    Dim frm_alumno_buscar_activo As Boolean = False
    Dim id_alumno_ficha As String
    Dim monto As String
    Dim obje As New Cls_Tramite
    Dim _precio As Double
    Dim nom_curso As String
    Dim nom_grupo As String
    Dim seccion As String
    Dim horario_grupo As String
    Dim num_telefono As String
    Dim id_persona As String

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        form_Alumno_buscar_ = New frm_alumno_buscar
        form_Alumno_buscar_.Show()
        form_Alumno_buscar_.Formnulario_Venta_Concepto(Me, "frm_venta_concepto")
        frm_alumno_buscar_activo = True

    End Sub

    Private Sub frm_venta_concepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_codigo_recibo.Text = obj.generar_codigo_correlativo()
    End Sub

    Private Sub frm_venta_concepto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        frm_principal.frm_ventas_concepto_activo = False
    End Sub
    Public Sub Informacion(ByVal obj_alumno As cls_n_view_alumnos)
        frm_alumno_buscar_activo = False
        id_alumno_ficha = obj_alumno.View_Alumno_Codigo_Alumno
        txt_nombre.Text = obj_alumno.View_Alumno_Nombre
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        If (txt_nombre.Text = "" Or txt_concepto.Text = "") Then
            MessageBox.Show("Llene todos los datos", "SistemaAsdi")
        Else
            Dim Msg As Integer
            Msg = MessageBox.Show("Desea imprimir el recibo", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (Msg = vbYes) Then

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
                Me.Close()
            End If
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim num As String = _correlativo_boleta
        Dim x As Integer = recibo_x
        Dim y As Integer = recibo_y
        e.Graphics.DrawString(num, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 110, y + 40)
        e.Graphics.DrawString(txt_nombre.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 60)
        e.Graphics.DrawString("OTROS CONCEPTOS: " + txt_concepto.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 110)
        e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 335, y + 40)
        e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 335, y + 170)
        e.Graphics.DrawString("S/. " + monto, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 335, y + 230)
        e.Graphics.DrawString("S/. 0.00", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 335, y + 190)
        e.Graphics.DrawString(Convert.ToString(obj.Letras(monto)) + " /100 ", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 80)
        e.Graphics.DrawString(Convert.ToString(Now.ToString("yyyy-MM-dd")), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 325, y + 80)
        e.Graphics.DrawString(nom_curso, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 140)
        e.Graphics.DrawString(nom_grupo, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 155)
        e.Graphics.DrawString(seccion, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 170)
        e.Graphics.DrawString(horario_grupo, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 185)
        e.Graphics.DrawString("-----Obs.", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 200)
        e.Graphics.DrawString(num_telefono, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 215)
        e.Graphics.DrawString(id_persona, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 230)
        e.Graphics.DrawString("Usuario: " + nombre_usuario, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 150, y + 240)
    End Sub
End Class