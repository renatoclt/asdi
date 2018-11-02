Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration
Imports Negocio
Imports LogicaNegocios
Imports RustemSoft.DataGridViewColumns
Imports System.Data

Public Class frm_lista_alumno_curso
    Private obj_ln_periodo As cls_ln_periodo
    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private obj_ln_curso_ofertado As cls_ln_curso_ofertado
    Private obj_ln_view_alumnos As cls_ln_view_alumnos
    Private id_periodo As Integer
    Private id_plan_estudio As Integer
    Private id_curso_ofertado As Integer
    Private curso As String = ""
    Private seleccionar_periodo As Boolean = False
    Private seleccionar_plan_estudio As Boolean = False
    Private seleccionar_curso_ofertado As Boolean = False
    Private frm_rpt_listas_ As frm_rpt_listas
    Public frm_rpt_listas_activo As Boolean = False

    Private Sub Cargar()
        obj_ln_periodo = New cls_ln_periodo
        obj_ln_plan_estudio = New cls_ln_plan_estudio
        obj_ln_curso_ofertado = New cls_ln_curso_ofertado
        obj_ln_view_alumnos = New cls_ln_view_alumnos
        cbx_plan_estudio.Enabled = False
        cbx_curso_ofertado.Enabled = False
        dg_alumnos.Enabled = False
        seleccionar_periodo = False
        seleccionar_plan_estudio = False
        seleccionar_curso_ofertado = False
        btn_reporte.Enabled = False
        id_periodo = -1
        id_plan_estudio = -1
        id_curso_ofertado = -1
    End Sub

    Private Sub Cargar_Datos()
        cbx_periodo.DataSource = obj_ln_periodo.List_PeriodoCB
        cbx_periodo.DisplayMember = "Periodo_Nombre"
        cbx_periodo.ValueMember = "Periodo_Codigo"
        cbx_periodo.SelectedItem = Nothing
    End Sub

    Private Sub frm_lista_alumno_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If (seleccionar_periodo) Then
            id_periodo = cbx_periodo.SelectedValue

            cbx_plan_estudio.DataSource = obj_ln_plan_estudio.List_Plan_Estudio_Por_Periodo(id_periodo)
            cbx_plan_estudio.DisplayMember = "Plan_Nombre"
            cbx_plan_estudio.ValueMember = "Plan_Codigo"
            cbx_plan_estudio.SelectedItem = Nothing

            If (obj_ln_plan_estudio.List_Plan_Estudio_Por_Periodo(id_periodo).Count = 0) Then
                cbx_plan_estudio.Enabled = False
            Else
                cbx_plan_estudio.Enabled = True
            End If
            seleccionar_plan_estudio = False
            seleccionar_curso_ofertado = False
            cbx_curso_ofertado.Enabled = False
            btn_reporte.Enabled = False
        End If
    End Sub

    Private Sub cbx_periodo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_periodo.MouseClick
        seleccionar_periodo = True
    End Sub

    Private Sub cbx_plan_estudio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plan_estudio.SelectedIndexChanged
        If (seleccionar_plan_estudio) Then
            id_plan_estudio = cbx_plan_estudio.SelectedValue

            cbx_curso_ofertado.DataSource = obj_ln_curso_ofertado.List_View_Curso_Ofertado(id_periodo, id_plan_estudio)
            cbx_curso_ofertado.DisplayMember = "Curso_Ofertado_Curso_Nombre"
            cbx_curso_ofertado.ValueMember = "Curso_Ofertado_Codigo"
            cbx_curso_ofertado.SelectedItem = Nothing

            If (obj_ln_curso_ofertado.List_View_Curso_Ofertado(id_periodo, id_plan_estudio).Count = 0) Then
                cbx_curso_ofertado.Enabled = False
            Else
                cbx_curso_ofertado.Enabled = True
            End If
            seleccionar_curso_ofertado = False
            btn_reporte.Enabled = False
        End If
    End Sub

    Private Sub cbx_plan_estudio_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_plan_estudio.MouseClick
        seleccionar_plan_estudio = True
    End Sub

    Private Sub cbx_curso_ofertado_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_curso_ofertado.MouseClick
        seleccionar_curso_ofertado = True
    End Sub

    Private Sub cbx_curso_ofertado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_curso_ofertado.SelectedIndexChanged
        If (seleccionar_curso_ofertado) Then
            id_curso_ofertado = cbx_curso_ofertado.SelectedValue
            curso = cbx_curso_ofertado.Text

            dg_alumnos.DataSource = obj_ln_view_alumnos.Lista_Alumnos_Por_Curso_Ofertado(id_curso_ofertado)


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

            If (dg_alumnos.RowCount = 0) Then
                btn_reporte.Enabled = False
            Else
                btn_reporte.Enabled = True
            End If
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
            dt.Rows.Add(row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, curso)
        Next

        rptDoc = New rpt_lista_alumno_curso
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

    Private Sub frm_lista_alumno_curso_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_lista_alumno_curso_activo = False
    End Sub

End Class