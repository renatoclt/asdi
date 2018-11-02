Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_periodo_selected
    Private obj_n_periodo As cls_n_periodo
    Private obj_ln_periodo As cls_ln_periodo
    Private id_periodo As Integer
    Private periodo As String
    Private estado As Boolean
    Private regular As Boolean

    Private Sub Cargar()
        id_periodo = -1
        obj_n_periodo = New cls_n_periodo
        obj_ln_periodo = New cls_ln_periodo
        dg_periodo.Enabled = True
        btn_Seleccionar.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_periodo.DataSource = obj_ln_periodo.List_Periodo
        dg_periodo.Columns(0).HeaderText = "Codigo"
        dg_periodo.Columns(0).Visible = False
        dg_periodo.Columns(0).Width = 20
        dg_periodo.Columns(1).HeaderText = "Periodo"
        dg_periodo.Columns(1).Width = 100
        dg_periodo.Columns(2).HeaderText = "Estado"
        dg_periodo.Columns(2).Width = 80
        dg_periodo.Columns(3).HeaderText = "Regular"
        dg_periodo.Columns(3).Width = 50
    End Sub

    Private Sub frm_periodo_selected_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Seleccionar.Click
        frm_principal.lbl_periodo_selecionado.Text = periodo
        If (estado) Then
            frm_principal.lbl_estado_periodo.Text = "Abierto"
        Else
            frm_principal.lbl_estado_periodo.Text = "Cerrado"
        End If
        Global_variables.periodo_sesion.Periodo_Codigo = id_periodo
        Global_variables.id_periodo_estado = estado
        'frm_principal.men_inic_periodo.Text = "&Cambiar Periodo"
        'frm_principal.men_inic_periodo.Enabled = False
        frm_principal.load_menus(True)
        Me.Close()
    End Sub

    Private Sub dg_periodo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_periodo.CellContentClick, dg_periodo.CellDoubleClick, dg_periodo.CellContentDoubleClick, dg_periodo.CellClick
        Dim i As Integer
        i = dg_periodo.CurrentRow.Index
        id_periodo = dg_periodo.Item(0, i).Value
        periodo = dg_periodo.Item(1, i).Value.ToString
        If (dg_periodo.Item(2, i).Value = "Abierto") Then
            estado = True
        Else
            estado = False
        End If
        If (dg_periodo.Item(3, i).Value = "Si") Then
            regular = True
        Else
            regular = False
        End If
        lbl_periodo_selecionado.Text = periodo
        btn_Seleccionar.Enabled = True
    End Sub

    Private Sub frm_periodo_selected_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_periodo_selected_activo = False
    End Sub

End Class