Imports Datos
Imports Negocio

Public Class cls_ln_view_cursos
    Private obj_datos As cls_dt_view_cursos

    Public Sub New()
        obj_datos = New cls_dt_view_cursos
    End Sub

    Public Sub Update_View_Cursos(ByVal obj_view_cursos As cls_n_view_cursos)
        obj_datos.Update_View_Cursos(obj_view_cursos)
    End Sub

    Public Function List_View_Cursos(ByVal id_plan_est As Integer) As List(Of cls_n_view_cursos)
        Return obj_datos.List_View_Cursos(id_plan_est)
    End Function

    Public Function List_Cursos_Periodo_y_Horario(ByVal id_periodo As Integer, ByVal id_horario As Integer) As List(Of cls_n_curso_reporte)
        Return obj_datos.List_Cursos_Periodo_y_Horario(id_periodo, id_horario)
    End Function

    Public Function List_Cursos_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_curso_reporte)
        Return obj_datos.List_Cursos_Periodo(id_periodo)
    End Function
End Class
