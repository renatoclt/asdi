Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_lista_matricula_separada
    Dim obj As New Cls_Matricula
    Private frm_rpt_listas_ As frm_rpt_listas
    Public frm_rpt_listas_activo As Boolean = False

    Private Sub frm_lista_matricula_separada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_periodo(Cbx_ciclo)
    End Sub

    Private Sub Cbx_ciclo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbx_ciclo.SelectedIndexChanged
        obj.Llenar_plan_estudio(Cbx_plan_est, Convert.ToString(Cbx_ciclo.SelectedValue))
    End Sub

    Private Sub Cbx_plan_est_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbx_plan_est.SelectedIndexChanged
        obj.Mostrar_matriculas_separadas(DgvMatriculaSep, Convert.ToString(Cbx_ciclo.SelectedValue), Convert.ToString(Cbx_plan_est.SelectedValue))
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Dim dt As New DataTable
        Dim rptDoc As ReportDocument
        Dim numCols As Integer
        With dt
            .Columns.Add("id_persona")
            .Columns.Add("nombre")
            .Columns.Add("curso")
            .Columns.Add("estado")
            .Columns.Add("horario")
        End With

        Dim row As DataRow
        numCols = DgvMatriculaSep.ColumnCount
        For Each filaDatos As DataGridViewRow In DgvMatriculaSep.Rows
            row = dt.NewRow()
            For i As Integer = 0 To numCols - 1
                row(i) = filaDatos.Cells(i).Value
            Next
            dt.Rows.Add(row)
        Next

        rptDoc = New rpt_lista_matricula_separada
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
End Class