Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_tramite_entregar
    Private obj_n_view_tramites As cls_n_view_tramites
    Private obj_ln_view_tramites As cls_ln_view_tramites
    Private obj_n_tramite As cls_n_tramite
    Private obj_ln_tramite As cls_ln_tramite
    Private id_tramite As Integer
    Private nombre As String
    Private tramite As String
    Private entregado As Boolean = False
    Private seleccionado As Boolean = False

    Dim obj As New Cls_Matricula
    Dim obje As New Cls_Tramite
    Dim id_alumno_ficha As Integer
    Dim num_telefono As String
    Dim id_persona As String
    Dim costo_s As Double
    Dim nom_persona As String

    Private Sub Cargar()
        obj_n_view_tramites = New cls_n_view_tramites
        obj_ln_view_tramites = New cls_ln_view_tramites
        obj_n_tramite = New cls_n_tramite
        obj_ln_tramite = New cls_ln_tramite
        txt_alumno.Enabled = False
        txt_tramite.Enabled = False
        dtp_fecha_entrega.Enabled = False
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        chk_entregado.Enabled = False
        chk_entregado.Text = ""
        txt_alumno.Text = ""
        txt_tramite.Text = ""
    End Sub

    Private Sub Cargar_Datos()
        dg_tramites.DataSource = obj_ln_view_tramites.Buscar_View_Tramites_No(txt_nombre.Text)
        dg_tramites.Columns(0).HeaderText = "Codigo"
        dg_tramites.Columns(0).Width = 45
        dg_tramites.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_tramites.Columns(1).HeaderText = "Nombre del Alumno"
        dg_tramites.Columns(1).Width = 120
        dg_tramites.Columns(2).HeaderText = "Trámite"
        dg_tramites.Columns(2).Width = 80
        dg_tramites.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_tramites.Columns(3).HeaderText = "Fecha de Creación"
        dg_tramites.Columns(3).Width = 130
        dg_tramites.Columns(4).HeaderText = "Entregado"
        dg_tramites.Columns(4).Width = 60
        dg_tramites.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_tramites.Columns(5).HeaderText = "Fecha de Entrega"
        dg_tramites.Columns(5).Width = 140
        dg_tramites.Columns(5).Visible = False
    End Sub

    Private Sub frm_tramite_entregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        dg_tramites.DataSource = obj_ln_view_tramites.Buscar_View_Tramites_No(txt_nombre.Text)
        If (obj_ln_view_tramites.Buscar_View_Tramites_No(txt_nombre.Text).Count = 0) Then
            btn_Cancelar.Enabled = False
            btn_Guardar.Enabled = False
        Else
            btn_Guardar.Enabled = True
            btn_Cancelar.Enabled = True
        End If
        chk_entregado.Text = ""
        chk_entregado.Enabled = False
        chk_entregado.Checked = False
        txt_alumno.Text = ""
        txt_tramite.Text = ""
        seleccionado = False
    End Sub

    Private Sub dg_tramites_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_tramites.CellContentClick, dg_tramites.CellDoubleClick, dg_tramites.CellContentDoubleClick, dg_tramites.CellClick
        Dim i As Integer
        i = dg_tramites.CurrentRow.Index
        id_tramite = dg_tramites.Item(0, i).Value
        nombre = dg_tramites.Item(1, i).Value
        tramite = dg_tramites.Item(2, i).Value
        chk_entregado.Enabled = True
        If (dg_tramites.Item(4, i).Value.ToString <> "No") Then
            entregado = True
            chk_entregado.Text = "Si"
        Else
            entregado = False
            chk_entregado.Text = "No"
        End If
        chk_entregado.Checked = entregado
        txt_alumno.Text = nombre.ToString
        txt_tramite.Text = tramite.ToString
        seleccionado = True
        btn_Guardar.Enabled = True
        btn_Cancelar.Enabled = True
    End Sub

    Private Sub chk_entregado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_entregado.CheckedChanged
        If (chk_entregado.Checked) Then
            chk_entregado.Text = "Si"
        Else
            chk_entregado.Text = "No"
        End If
        entregado = chk_entregado.Checked
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (seleccionado) Then
            If chk_entregado.Text = "Si" Then
                Msg = MsgBox(" Desea Guardar/Imprimir ", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = vbYes) Then
                    PrintDialog1.Document = PrintDocument1
                    Dim TamaoPersonal As Printing.PaperSize
                    Dim Ancho As Short
                    Dim Alto As Short
                    Ancho = 500
                    Alto = 400
                    TamaoPersonal = New Printing.PaperSize("A4", Ancho, Alto)

                    obj_n_tramite.Tramite_Codigo = id_tramite
                    obj_n_tramite.Tramite_Fecha_Entregado = dtp_fecha_entrega.Value
                    obj_n_tramite.Tramite_Entregado = entregado
                    obj_ln_tramite.Update_Tramite(obj_n_tramite)

                    id_alumno_ficha = Convert.ToUInt32(obje.consulta_id_alumno_ficha(Convert.ToString(id_tramite)))
                    costo_s = Convert.ToDouble(obje.consulta_costo(Convert.ToString(id_tramite)))
                    num_telefono = Convert.ToString(obj.consulta_num_telefono(Convert.ToString(id_alumno_ficha)))
                    id_persona = Convert.ToString(obj.consulta_id_persona(Convert.ToString(id_alumno_ficha)))
                    nom_persona = obj.consulta_nombre_persona(id_alumno_ficha)
                    obje.guardar_datos_recibo(costo_s, nom_persona, id_tramite, id_alumno_ficha)

                    'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'PrintDocument1.DefaultPageSettings.PaperSize.RawKind = 9
                    PrintDocument1.DefaultPageSettings.PaperSize = TamaoPersonal
                    'PrintDocument1.DefaultPageSettings.Landscape = True
                    PrintDocument1.PrinterSettings.PrinterName = _impresora_a_usar
                    PrintDocument1.Print()
                    'End If
                    Cargar()
                    Cargar_Datos()
                Else
                    chk_entregado.Text = ""
                    chk_entregado.Enabled = False
                    chk_entregado.Checked = False
                    txt_alumno.Text = ""
                    txt_tramite.Text = ""
                    seleccionado = False
                End If
            End If
        Else
            MsgBox("Debe seleccionar un trámite", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_tramite_entregar_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_tramite_entregar_activo = False
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim num As String = _correlativo_boleta
        Dim x As Integer = recibo_x
        Dim y As Integer = recibo_y
        Dim nom_documento As String = obje.consulta_nombre_documento(id_tramite)

        e.Graphics.DrawString(num, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 110, y + 40)
        e.Graphics.DrawString(nom_persona, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 60)

        e.Graphics.DrawString("TRAMITE " + nom_documento, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 110)
        e.Graphics.DrawString(String.Format("{0:C}", Convert.ToDouble(costo_s)), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 40)
        e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble(costo_s))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 170)
        e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble(costo_s))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 230)
        e.Graphics.DrawString(Convert.ToString(String.Format("{0:C}", Convert.ToDouble("0"))), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 360, y + 190)

        e.Graphics.DrawString(Convert.ToString(obj.Letras(Convert.ToString(costo_s))) + " /100 ", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 80)
        e.Graphics.DrawString(Convert.ToString(Now.ToString("yyyy-MM-dd")), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 350, y + 80)
        'e.Graphics.DrawString(nom_curso, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 50, 190)
        'e.Graphics.DrawString(nom_grupo, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 50, 205)
        'e.Graphics.DrawString(Convert.ToString(Txt_seccion.Text), New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 50, 220)
        'e.Graphics.DrawString(CbHorario.Text, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, 50, 235)
        e.Graphics.DrawString("-----Obs.", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 200)
        e.Graphics.DrawString(num_telefono, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 215)
        e.Graphics.DrawString(id_persona, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x, y + 230)
        e.Graphics.DrawString("Usuario: " + nombre_usuario, New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, x + 150, y + 240)

    End Sub
End Class