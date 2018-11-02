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
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = vbYes) Then
                obj_n_tramite.Tramite_Codigo = id_tramite
                obj_n_tramite.Tramite_Fecha_Entregado = dtp_fecha_entrega.Value
                obj_n_tramite.Tramite_Entregado = entregado
                obj_ln_tramite.Update_Tramite(obj_n_tramite)
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
End Class