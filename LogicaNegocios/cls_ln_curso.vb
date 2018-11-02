Imports Datos
Imports Negocio

Public Class cls_ln_curso
    Private obj_datos As cls_dt_curso

    Public Sub New()
        obj_datos = New cls_dt_curso
    End Sub

    Public Sub Add_Curso(ByVal obj_curso As cls_n_curso)
        obj_datos.Add_Curso(obj_curso)
    End Sub

    Public Sub Update_Curso(ByVal obj_curso As cls_n_curso)
        obj_datos.Update_Curso(obj_curso)
    End Sub

    Public Sub Delete_Curso(ByVal obj_curso As cls_n_curso)
        obj_datos.Delete_Curso(obj_curso)
    End Sub

    Public Function List_Curso() As List(Of cls_n_curso)
        Return obj_datos.List_Curso
    End Function

    Public Function List_Curso_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_curso)
        Return obj_datos.List_Curso_Por_Periodo(id_periodo)
    End Function

    Public Function List_Curso_Por_Periodo_Y_Horario(ByVal id_periodo As Integer, ByVal id_horario As Integer) As List(Of cls_n_curso)
        Return obj_datos.List_Curso_Por_Periodo_Y_Horario(id_periodo, id_horario)
    End Function
End Class
