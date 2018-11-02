﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_lista_profesor_periodo
    Private obj_ln_periodo As cls_ln_periodo
    Private obj_ln_view_profesores As cls_ln_view_profesores
    Private id_periodo As Integer
    Private periodo As String = ""
    Private seleccionar_periodo As Boolean = False
    Private frm_rpt_listas_ As frm_rpt_listas
    Public frm_rpt_listas_activo As Boolean = False

    Private Sub Cargar()
        obj_ln_periodo = New cls_ln_periodo
        obj_ln_view_profesores = New cls_ln_view_profesores
        dg_profesores.Enabled = False
        seleccionar_periodo = False
        btn_reporte.Enabled = False
        id_periodo = -1
    End Sub

    Private Sub Cargar_Datos()
        cbx_periodo.DataSource = obj_ln_periodo.List_PeriodoCB
        cbx_periodo.DisplayMember = "Periodo_Nombre"
        cbx_periodo.ValueMember = "Periodo_Codigo"
        cbx_periodo.SelectedItem = Nothing
    End Sub

    Private Sub frm_lista_profesor_periodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
    End Sub


    Private Sub cbx_periodo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_periodo.MouseClick
        seleccionar_periodo = True
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If (seleccionar_periodo) Then
            id_periodo = cbx_periodo.SelectedValue
            periodo = cbx_periodo.Text

            dg_profesores.DataSource = obj_ln_view_profesores.List_Profesores_Por_Periodo(id_periodo)

            dg_profesores.Columns(0).HeaderText = "Codigo"
            dg_profesores.Columns(0).Visible = True
            dg_profesores.Columns(0).Width = 50
            dg_profesores.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_profesores.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_profesores.Columns(1).HeaderText = "Profesor"
            dg_profesores.Columns(1).Visible = True
            dg_profesores.Columns(1).Width = 150
            dg_profesores.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_profesores.Columns(2).HeaderText = "Estado"
            dg_profesores.Columns(2).Visible = True
            dg_profesores.Columns(2).Width = 50
            dg_profesores.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_profesores.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_profesores.Columns(3).HeaderText = "Ciclo"
            dg_profesores.Columns(3).Visible = True
            dg_profesores.Columns(3).Width = 150
            dg_profesores.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_profesores.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_profesores.Columns(4).HeaderText = "Grupo"
            dg_profesores.Columns(4).Visible = True
            dg_profesores.Columns(4).Width = 50
            dg_profesores.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_profesores.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_profesores.Columns(5).HeaderText = "Horario"
            dg_profesores.Columns(5).Visible = True
            dg_profesores.Columns(5).Width = 100
            dg_profesores.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_profesores.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_profesores.Columns(6).HeaderText = "Aula"
            dg_profesores.Columns(6).Visible = True
            dg_profesores.Columns(6).Width = 60
            dg_profesores.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_profesores.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_profesores.Columns(7).HeaderText = "Periodo"
            dg_profesores.Columns(7).Visible = True
            dg_profesores.Columns(7).Width = 60
            dg_profesores.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_profesores.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            If (dg_profesores.Rows.Count = 0) Then
                dg_profesores.Enabled = False
                btn_reporte.Enabled = False
            Else
                dg_profesores.Enabled = True
                btn_reporte.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Dim dt As New DataTable
        Dim rptDoc As ReportDocument
        With dt
            .Columns.Add("id_profesor_ficha")
            .Columns.Add("nombre")
            .Columns.Add("estado")
            .Columns.Add("curso")
            .Columns.Add("grupo")
            .Columns.Add("horario")
            .Columns.Add("aula")
            .Columns.Add("periodo")
        End With

        For Each row As DataGridViewRow In dg_profesores.Rows
            dt.Rows.Add(row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString, row.Cells(6).Value.ToString, row.Cells(7).Value.ToString)
        Next

        rptDoc = New rpt_lista_profesor_periodo
        rptDoc.SetDataSource(dt)

        If (Not frm_rpt_listas_activo) Then
            frm_rpt_listas_ = New frm_rpt_listas
            frm_rpt_listas_.crv_reportes.ReportSource = rptDoc
            frm_rpt_listas_.SetFrom(Me)
            frm_rpt_listas_.Show()
            'frm_rpt_listas_activo = True
        Else
            frm_rpt_listas_.Activate()
        End If
    End Sub

    Private Sub frm_lista_profesor_periodo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_lista_profesor_periodo_activo = False
    End Sub
End Class