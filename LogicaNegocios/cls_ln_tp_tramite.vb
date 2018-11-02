Imports Datos
Imports Negocio

Public Class cls_ln_tp_tramite
    Private obj_datos As cls_dt_tp_tramite

    Public Sub New()
        obj_datos = New cls_dt_tp_tramite
    End Sub

    Public Sub Add_Tipo_Tramite(ByVal obj_tp_tramite As cls_n_tp_tramite)
        obj_datos.Add_Tipo_Tramite(obj_tp_tramite)
    End Sub

    Public Sub Update_Tipo_Tramite(ByVal obj_tp_tramite As cls_n_tp_tramite)
        obj_datos.Update_Tipo_Tramite(obj_tp_tramite)
    End Sub

    Public Sub Delete_Tipo_Tramite(ByVal obj_tp_tramite As cls_n_tp_tramite)
        obj_datos.Delete_Tipo_Tramite(obj_tp_tramite)
    End Sub

    Public Function List_Tipo_Tramite() As List(Of cls_n_tp_tramite)
        Return obj_datos.List_Tipo_Tramite
    End Function
End Class
