Imports Datos
Imports Negocio

Public Class cls_ln_periodo
    Private obj_datos As cls_dt_periodo

    Public Sub New()
        obj_datos = New cls_dt_periodo
    End Sub

    Public Sub Add_Periodo(ByVal obj_periodo As cls_n_periodo)
        obj_datos.Add_Periodo(obj_periodo)
    End Sub

    Public Sub Update_Periodo(ByVal obj_periodo As cls_n_periodo)
        obj_datos.Update_Periodo(obj_periodo)
    End Sub

    Public Sub Delete_Periodo(ByVal obj_periodo As cls_n_periodo)
        obj_datos.Delete_Periodo(obj_periodo)
    End Sub

    Public Function Actual_Periodo(ByVal obj_periodo As cls_n_periodo) As Integer
        Return obj_datos.Actual_Periodo(obj_periodo)
    End Function

    Public Function List_Periodo() As List(Of cls_n_periodo)
        Return obj_datos.List_Periodo
    End Function

    Public Function List_Periodo_Abierto() As List(Of cls_n_periodo)
        Return obj_datos.List_Periodo_Abierto
    End Function

    Public Function List_Periodo_Cerrado() As List(Of cls_n_periodo)
        Return obj_datos.List_Periodo_Cerrado
    End Function

    Public Function Get_Periodo(ByVal obj_periodo As cls_n_periodo) As cls_n_periodo
        Return obj_datos.Get_Periodo(obj_periodo)
    End Function

End Class
