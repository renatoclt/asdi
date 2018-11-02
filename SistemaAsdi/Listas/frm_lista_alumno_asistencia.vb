Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_lista_alumno_asistencia
    Dim obj As New Cls_Notas
    Private frm_rpt_listas_ As frm_rpt_listas
    Public frm_rpt_listas_activo As Boolean = False
    'select c.curso, v.horario, vp.id_profesor_ficha, vp.nombre, v.id_alumno_ficha, v.nombre from view_alumno_profesor v, curso_ofertado co, curso c, curso_grupo cg, view_profesores vp, matricula m , horario h where m.id_alumno_ficha = v.id_alumno_ficha and m.id_curso_grupo= cg.id_curso_grupo and co.id_curso_ofertado = cg.id_curso_ofertado and cg.id_profesor_ficha = vp.id_profesor_ficha and cg.id_horario = h.id_horario and cg.id_profesor_ficha = v.id_profesor_ficha and co.id_periodo = m.id_periodo and c.id_curso = co.id_curso and co.id_periodo = 9  and cg.id_horario = 1 and v.id_profesor_ficha = 7 and c.id_curso = 2 group by v.id_alumno_ficha;
    'Select id_periodo, periodo from periodo where estado =1;
    'SELECT h.id_horario, h.horario FROM curso_grupo c, curso_ofertado o, horario h where h.id_horario = c.id_horario and  o.id_periodo =11 group by h.id_horario;
    'SELECT v.id_profesor_ficha, v.nombre FROM curso_grupo c, curso_ofertado o, horario h, view_profesores v where c.id_curso_ofertado = o.id_curso_ofertado and v.id_profesor_ficha =c.id_profesor_ficha and h.id_horario = c.id_horario and o.id_periodo =9 and h.id_horario = 1 group by v.id_profesor_ficha ;
    'select c.id_curso, c.curso from view_alumno_profesor v, curso_ofertado co, curso c, curso_grupo cg, view_profesores vp, matricula m , horario h where m.id_alumno_ficha = v.id_alumno_ficha and m.id_curso_grupo= cg.id_curso_grupo and co.id_curso_ofertado = cg.id_curso_ofertado and cg.id_profesor_ficha = vp.id_profesor_ficha and cg.id_horario = h.id_horario and cg.id_profesor_ficha = v.id_profesor_ficha and co.id_periodo = m.id_periodo and c.id_curso = co.id_curso and co.id_periodo = 9  and cg.id_horario = 1 and v.id_profesor_ficha = 7 ;

    Private Sub frm_lista_alumno_asistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_periodo(cbx_periodo)
    End Sub
    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        'cbx_horario.Text = ""
        obj.Llenar_horario_asistencia(cbx_horario, Convert.ToString(cbx_periodo.SelectedValue))
    End Sub
    Private Sub cbx_horario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_horario.SelectedIndexChanged
        'cbx_profesor.Text = ""
        obj.Llenar_profesor_asistencia(cbx_profesor, Convert.ToString(cbx_periodo.SelectedValue), Convert.ToString(cbx_horario.SelectedValue))
    End Sub
    Private Sub cbx_profesor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_profesor.SelectedIndexChanged
        'cbx_curso_ofertado.Text = ""
        obj.Llenar_ciclo_asistencia(cbx_curso_ofertado, Convert.ToString(cbx_periodo.SelectedValue), Convert.ToString(cbx_horario.SelectedValue), Convert.ToString(cbx_profesor.SelectedValue))
    End Sub
    Private Sub cbx_curso_ofertado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_curso_ofertado.SelectedIndexChanged
        obj.Mostrar_Alumnos_asistencia(DgvAlumnos, Convert.ToString(cbx_periodo.SelectedValue), Convert.ToString(cbx_horario.SelectedValue), Convert.ToString(cbx_profesor.SelectedValue), Convert.ToString(cbx_curso_ofertado.SelectedValue))
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Dim dt As New DataTable
        Dim rptDoc As ReportDocument
        Dim numCols As Integer
        With dt
            .Columns.Add("curso")
            .Columns.Add("horario")
            .Columns.Add("id_alumno")
            .Columns.Add("nombre_alumno")
            .Columns.Add("id_profesor")
            .Columns.Add("nombre_profesor")
            .Columns.Add("aula")
        End With

        Dim row As DataRow
        numCols = DgvAlumnos.ColumnCount
        For Each filaDatos As DataGridViewRow In DgvAlumnos.Rows
            row = dt.NewRow()
            For i As Integer = 0 To numCols - 1
                row(i) = filaDatos.Cells(i).Value
            Next
            dt.Rows.Add(row)
        Next

        rptDoc = New rpt_alumno_asistencia
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim rptDoc As ReportDocument
        Dim numCols As Integer
        With dt
            .Columns.Add("curso")
            .Columns.Add("horario")
            .Columns.Add("id_alumno")
            .Columns.Add("nombre_alumno")
            .Columns.Add("id_profesor")
            .Columns.Add("nombre_profesor")
            .Columns.Add("aula")
        End With

        Dim row As DataRow
        numCols = DgvAlumnos.ColumnCount
        For Each filaDatos As DataGridViewRow In DgvAlumnos.Rows
            row = dt.NewRow()
            For i As Integer = 0 To numCols - 1
                row(i) = filaDatos.Cells(i).Value
            Next
            dt.Rows.Add(row)
        Next

        rptDoc = New rpt_lista_alumno_asistencia
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