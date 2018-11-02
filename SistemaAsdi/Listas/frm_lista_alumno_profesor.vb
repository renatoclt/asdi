Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_lista_alumno_profesor
    Private obj_n_periodo As cls_n_periodo
    Private obj_ln_periodo As cls_ln_periodo
    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private obj_ln_view_profesores As cls_ln_view_profesores
    Private obj_ln_view_alumnos As cls_ln_view_alumnos
    Private id_periodo As Integer
    Private id_profesor_ficha As Integer
    Private profesor As String = ""
    Private seleccionar_periodo As Boolean = False
    Private seleccionar_profesor As Boolean = False
    Private seleccionar_plan As Boolean = False
    Private frm_rpt_listas_ As frm_rpt_listas
    Public frm_rpt_listas_activo As Boolean = False
    Private id_plan_est As Integer

    Private Sub Cargar()
        obj_n_periodo = New cls_n_periodo
        obj_ln_periodo = New cls_ln_periodo
        obj_ln_plan_estudio = New cls_ln_plan_estudio
        obj_ln_view_profesores = New cls_ln_view_profesores
        obj_ln_view_alumnos = New cls_ln_view_alumnos
        cbx_profesor.Enabled = False
        cbx_plan_estudios.Enabled = False
        dg_alumnos.Enabled = False
        seleccionar_periodo = False
        seleccionar_profesor = False
        seleccionar_plan = False
        btn_reporte.Enabled = False
        id_periodo = -1
        id_profesor_ficha = -1
        id_plan_est = -1
    End Sub

    Private Sub Cargar_Datos()
        cbx_periodo.DataSource = obj_ln_periodo.List_PeriodoCB
        cbx_periodo.DisplayMember = "Periodo_Nombre"
        cbx_periodo.ValueMember = "Periodo_Codigo"
        cbx_periodo.SelectedItem = Nothing
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If (seleccionar_periodo) Then
            id_periodo = cbx_periodo.SelectedValue

            cbx_plan_estudios.DataSource = obj_ln_plan_estudio.List_Plan_Estudio_Por_Periodo(id_periodo)
            cbx_plan_estudios.DisplayMember = "Plan_Nombre"
            cbx_plan_estudios.ValueMember = "Plan_Codigo"
            cbx_plan_estudios.SelectedItem = Nothing

            If (obj_ln_plan_estudio.List_Plan_Estudio_Por_Periodo(id_periodo).Count = 0) Then
                cbx_plan_estudios.Enabled = False
            Else
                cbx_plan_estudios.Enabled = True
            End If
            cbx_profesor.SelectedItem = Nothing
            'If (obj_ln_view_profesores.List_View_Profesores_Por_Periodo(id_periodo, id_plan_est).Count = 0) Then
            '    cbx_profesor.Enabled = False
            'Else
            '    cbx_profesor.Enabled = True
            'End If
            seleccionar_profesor = False
            seleccionar_plan = False
            btn_reporte.Enabled = False
        End If
    End Sub

    Private Sub cbx_profesor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_profesor.SelectedIndexChanged

        If (seleccionar_profesor) Then
            id_profesor_ficha = cbx_profesor.SelectedValue
            profesor = cbx_profesor.Text
            id_plan_est = cbx_plan_estudios.SelectedValue

            If (id_profesor_ficha <> -1) Then
                dg_alumnos.DataSource = obj_ln_view_alumnos.Lista_Alumnos_Por_Profesor(id_profesor_ficha, id_plan_est)
                If (obj_ln_view_alumnos.Lista_Alumnos_Por_Profesor(id_profesor_ficha, id_plan_est).Count = 0) Then
                    dg_alumnos.Enabled = False
                    btn_reporte.Enabled = False
                Else
                    dg_alumnos.Enabled = True
                    btn_reporte.Enabled = True
                End If
            End If

            dg_alumnos.Columns(0).HeaderText = "Codigo"
            dg_alumnos.Columns(0).Visible = True
            dg_alumnos.Columns(0).Width = 100
            dg_alumnos.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_alumnos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_alumnos.Columns(1).HeaderText = "Alumno"
            dg_alumnos.Columns(1).Visible = True
            dg_alumnos.Columns(1).Width = 200
            dg_alumnos.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_alumnos.Columns(2).HeaderText = "Grupo"
            dg_alumnos.Columns(2).Visible = True
            dg_alumnos.Columns(2).Width = 100
            dg_alumnos.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg_alumnos.Columns(3).HeaderText = "Horario"
            dg_alumnos.Columns(3).Visible = True
            dg_alumnos.Columns(3).Width = 100
            dg_alumnos.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Dim dt As New DataTable
        Dim rptDoc As ReportDocument
        With dt
            .Columns.Add("id_alumno_ficha")
            .Columns.Add("nombre")
            .Columns.Add("nombre_grupo")
            .Columns.Add("horario")
            .Columns.Add("profesor")
        End With

        For Each row As DataGridViewRow In dg_alumnos.Rows
            dt.Rows.Add(row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, profesor)
        Next

        rptDoc = New rpt_lista_alumno_profesor
        rptDoc.SetDataSource(dt)

        If (Not frm_rpt_listas_activo) Then
            frm_rpt_listas_ = New frm_rpt_listas
            frm_rpt_listas_.crv_reportes.ReportSource = rptDoc
            frm_rpt_listas_.SetFrom(Me)
            frm_rpt_listas_.Show()
            ' frm_rpt_listas_activo = True
        Else
            frm_rpt_listas_.Activate()
        End If
    End Sub

    Private Sub cbx_profesor_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_profesor.MouseClick
        seleccionar_profesor = True
    End Sub

    Private Sub frm_lista_alumno_profesor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
        seleccionar_periodo = True
    End Sub

    Private Sub frm_lista_alumno_profesor_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_lista_alumno_profesor_activo = False
    End Sub

    Private Sub cbx_plan_estudios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plan_estudios.SelectedIndexChanged
        If (seleccionar_plan) Then
            obj_n_periodo = cbx_periodo.SelectedItem
            id_periodo = obj_n_periodo.Periodo_Codigo
            id_plan_est = cbx_plan_estudios.SelectedValue

            cbx_profesor.DataSource = obj_ln_view_profesores.List_View_Profesores_Por_Periodo(id_periodo, id_plan_est)
            cbx_profesor.DisplayMember = "View_Profesores_Profesor_Nombre"
            cbx_profesor.ValueMember = "View_Profesores_Codigo_Profesor"
            cbx_profesor.SelectedItem = Nothing

            If (obj_ln_view_profesores.List_View_Profesores_Por_Periodo(id_periodo, id_plan_est).Count = 0) Then
                cbx_profesor.Enabled = False
            Else
                cbx_profesor.Enabled = True
            End If
            seleccionar_profesor = False
            btn_reporte.Enabled = False
        End If
    End Sub

    Private Sub cbx_plan_estudios_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_plan_estudios.MouseClick
        seleccionar_plan = True
    End Sub
End Class