Imports Datos
Imports Negocio

Public Class cls_ln_tramite
    Private obj_datos As cls_dt_tramite

    Public Sub New()
        obj_datos = New cls_dt_tramite
    End Sub

    Public Sub Add_Tramite(ByVal obj_tramite As cls_n_tramite)
        obj_datos.Add_Tramite(obj_tramite)
    End Sub

    Public Sub Update_Tramite(ByVal obj_tramite As cls_n_tramite)
        obj_datos.Update_Tramite(obj_tramite)
    End Sub

    Public Sub Delete_Tramite(ByVal obj_tramite As cls_n_tramite)
        obj_datos.Delete_Tramite(obj_tramite)
    End Sub

End Class
