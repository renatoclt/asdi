Imports Datos
Imports Negocio

Public Class cls_ln_plan_estudio
    Private obj_datos As cls_dt_plan_estudio

    Public Sub New()
        obj_datos = New cls_dt_plan_estudio
    End Sub

    Public Sub Add_Plan_Estudio(ByVal obj_plan_estudio As cls_n_plan_estudio)
        obj_datos.Add_Plan_Estudio(obj_plan_estudio)
    End Sub

    Public Sub Update_Plan_Estudio(ByVal obj_plan_estudio As cls_n_plan_estudio)
        obj_datos.Update_Plan_Estudio(obj_plan_estudio)
    End Sub

    Public Sub Delete_Plan_Estudio(ByVal obj_plan_estudio As cls_n_plan_estudio)
        obj_datos.Delete_Plan_Estudio(obj_plan_estudio)
    End Sub

    Public Function Get_Plan_Estudio(ByVal id_plan_est As Integer) As cls_n_plan_estudio
        Return obj_datos.Get_Plan_Estudio(id_plan_est)
    End Function

    Public Function Get_Plan_Estudio_Por_Ficha_Alumno(ByVal id_alumno_ficha As Integer) As cls_n_plan_estudio
        Return obj_datos.Get_Plan_Estudio_Por_Ficha_Alumno(id_alumno_ficha)
    End Function

    Public Function List_Plan_Estudio() As List(Of cls_n_plan_estudio)
        Return obj_datos.List_Plan_Estudio
    End Function

    Public Function List_Plan_Estudio_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_plan_estudio)
        Return obj_datos.List_Plan_Estudio_Por_Periodo(id_periodo)
    End Function
End Class