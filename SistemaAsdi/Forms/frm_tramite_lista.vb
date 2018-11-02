Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_tramite_lista
    Private obj_n_view_tramites As cls_n_view_tramites
    Private obj_ln_view_tramites As cls_ln_view_tramites
    Private obj_n_tp_tramite As cls_n_tp_tramite
    Private obj_ln_tp_tramite As cls_ln_tp_tramite
    Private tramite As String
    Private nombre As String
    Private por_tipo As Boolean = False
    Private seleccionar As Boolean = False
    Private por_nombre As Boolean = False

    Private Sub Cargar()
        obj_n_view_tramites = New cls_n_view_tramites
        obj_ln_view_tramites = New cls_ln_view_tramites
        obj_n_tp_tramite = New cls_n_tp_tramite
        obj_ln_tp_tramite = New cls_ln_tp_tramite
        tramite = ""
        txt_nombre.Text= ""
    End Sub

    Private Sub CargarDatos()
        cbx_tp_tramite.DataSource = obj_ln_tp_tramite.List_Tipo_Tramite
        cbx_tp_tramite.DisplayMember = "Tipo_Tramite_Nombre"
        cbx_tp_tramite.ValueMember = "Tipo_Tramite_Codgio"
        cbx_tp_tramite.SelectedItem = Nothing

        dg_tramites.DataSource = obj_ln_view_tramites.Buscar_View_Tramites
        dg_tramites.Columns(0).HeaderText = "Codigo de Trámite"
        dg_tramites.Columns(0).Width = 90
        dg_tramites.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_tramites.Columns(1).HeaderText = "Nombre del Alumno"
        dg_tramites.Columns(1).Width = 150
        dg_tramites.Columns(2).HeaderText = "Trámite"
        dg_tramites.Columns(2).Width = 80
        dg_tramites.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_tramites.Columns(3).HeaderText = "Fecha de Creación"
        dg_tramites.Columns(3).Width = 140
        dg_tramites.Columns(4).HeaderText = "Entregado"
        dg_tramites.Columns(4).Width = 60
        dg_tramites.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_tramites.Columns(5).HeaderText = "Fecha de Entrega"
        dg_tramites.Columns(5).Width = 140
    End Sub

    Private Sub frm_tramite_lista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        CargarDatos()
        seleccionar = True
    End Sub

    Private Sub cbx_tp_tramite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_tp_tramite.SelectedIndexChanged
        Dim i As Integer = -2
        If (seleccionar) Then
            obj_n_tp_tramite = cbx_tp_tramite.SelectedItem
            por_tipo = True
            tramite = obj_n_tp_tramite.Tipo_Tramite_Nombre
        End If
        Datos()
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        nombre = txt_nombre.Text
        Datos()
    End Sub

    Private Sub Datos()
        dg_tramites.DataSource = obj_ln_view_tramites.Buscar_View_Tramites(nombre)
        If (por_tipo) Then
            dg_tramites.DataSource = obj_ln_view_tramites.Buscar_View_Tramites(tramite, nombre)
        End If
    End Sub

    Private Sub frm_tramite_lista_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_tramite_lista_activo = False
    End Sub
End Class