Imports Datos
Imports Negocio

Public Class cls_ln_aula
    Private obj_datos As cls_dt_aula

    Public Sub New()
        obj_datos = New cls_dt_aula
    End Sub

    Public Sub Add_Aula(ByVal obj_aula As cls_n_aula)
        obj_datos.Add_Aula(obj_aula)
    End Sub

    Public Sub Update_Aula(ByVal obj_aula As cls_n_aula)
        obj_datos.Update_Aula(obj_aula)
    End Sub

    Public Sub Delete_Aula(ByVal obj_aula As cls_n_aula)
        obj_datos.Delete_Aula(obj_aula)
    End Sub

    Public Function List_Aula() As List(Of cls_n_aula)
        Return obj_datos.List_Aula
    End Function

    Public Function List_Aula_y_Capacidad() As List(Of cls_n_aula)
        Return obj_datos.List_Aula_y_Capacidad
    End Function
End Class


