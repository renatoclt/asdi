Imports Datos
Imports Negocio

Public Class cls_ln_view_profesores
    Private obj_datos As cls_dt_view_profesores

    Public Sub New()
        obj_datos = New cls_dt_view_profesores
    End Sub

    Public Function Buscar_View_Profesores_Activos_Nombres(ByVal nombre As String) As List(Of cls_n_view_profesores)
        Return obj_datos.Buscar_View_Profesores_Activos_Nombres(nombre)
    End Function

    Public Function List_View_Profesores_Activos() As List(Of cls_n_view_profesores)
        Return obj_datos.List_View_Profesores_Activos()
    End Function

    Public Function Buscar_View_Profesores_Todos_Nombres(ByVal nombre As String) As List(Of cls_n_view_profesores)
        Return obj_datos.Buscar_View_Profesores_Todos_Nombres(nombre)
    End Function

    Public Function List_View_Profesores_Por_Periodo(ByVal id_periodo As Integer, ByVal id_plan_est As Integer) As List(Of cls_n_view_profesores)
        Return obj_datos.List_View_Profesores_Por_Periodo(id_periodo, id_plan_est)
    End Function

    Public Function List_Profesores_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_profesor_reporte)
        Return obj_datos.List_Profesores_Por_Periodo(id_periodo)
    End Function

    Public Function List_Profesores_Por_Periodo_Y_Curso(ByVal id_periodo As Integer, ByVal id_curso As Integer) As List(Of cls_n_profesor_reporte)
        Return obj_datos.List_Profesores_Por_Periodo_Y_Curso(id_periodo, id_curso)
    End Function

    Public Function List_Profesores_Por_Periodo_Y_Horario(ByVal id_periodo As Integer, ByVal id_horario As Integer) As List(Of cls_n_profesor_reporte)
        Return obj_datos.List_Profesores_Por_Periodo_Y_Horario(id_periodo, id_horario)
    End Function
End Class