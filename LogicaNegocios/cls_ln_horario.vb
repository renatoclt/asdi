Imports Datos
Imports Negocio

Public Class cls_ln_horario
    Private obj_datos As cls_dt_horario

    Public Sub New()
        obj_datos = New cls_dt_horario
    End Sub

    Public Sub Add_Horario(ByVal obj_horario As cls_n_horario)
        obj_datos.Add_Horario(obj_horario)
    End Sub

    Public Sub Update_Horario(ByVal obj_horario As cls_n_horario)
        obj_datos.Update_Horario(obj_horario)
    End Sub

    Public Sub Delete_Horario(ByVal obj_horario As cls_n_horario)
        obj_datos.Delete_Horario(obj_horario)
    End Sub

    Public Function List_Horario() As List(Of cls_n_horario)
        Return obj_datos.List_Horario
    End Function

    Public Function List_Horario_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_horario)
        Return obj_datos.List_Horario_Por_Periodo(id_periodo)
    End Function
End Class
