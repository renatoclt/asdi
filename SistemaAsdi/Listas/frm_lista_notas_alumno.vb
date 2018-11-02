Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_lista_notas_alumno
    Dim obj As New Cls_Notas
    Private frm_rpt_listas_ As frm_rpt_listas
    Public frm_rpt_listas_activo As Boolean = False
    Private Sub frm_lista_notas_alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_Alumnos(Cb_Alumno)
        obj.Autocomplementar_Alumno(Cb_Alumno)
    End Sub

    Private Sub Cb_Alumno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Alumno.SelectedIndexChanged
        obj.Mostrar_Alumnos(DgvNotas, Convert.ToString(Cb_Alumno.SelectedValue))
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Dim dt As New DataTable
        Dim rptDoc As ReportDocument
        Dim numCols As Integer
        With dt
            .Columns.Add("id_alumno_ficha")
            .Columns.Add("nombre")
            .Columns.Add("id_curso")
            .Columns.Add("nombre_grupo")
            .Columns.Add("curso")
            .Columns.Add("fecha_creacion")
            .Columns.Add("promedio_final")
            .Columns.Add("id_programa")
            .Columns.Add("programa")
        End With

        Dim row As DataRow
        numCols = DgvNotas.ColumnCount
        For Each filaDatos As DataGridViewRow In DgvNotas.Rows
            row = dt.NewRow()
            For i As Integer = 0 To numCols - 1
                row(i) = filaDatos.Cells(i).Value
            Next
            dt.Rows.Add(row)
        Next

        rptDoc = New rpt_alumno_notas
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