Imports Datos
Imports Negocio

Public Class cls_ln_tp_rol
    Private obj_datos As cls_dt_tp_rol

    Public Sub New()
        obj_datos = New cls_dt_tp_rol
    End Sub

    Public Sub Add_Tipo_Rol(ByVal obj_tp_rol As cls_n_tp_rol)
        obj_datos.Add_Tipo_Rol(obj_tp_rol)
    End Sub

    Public Sub Update_Tipo_Rol(ByVal obj_tp_rol As cls_n_tp_rol)
        obj_datos.Update_Tipo_Rol(obj_tp_rol)
    End Sub

    Public Sub Delete_Tipo_Rol(ByVal obj_tp_rol As cls_n_tp_rol)
        obj_datos.Delete_Tipo_Rol(obj_tp_rol)
    End Sub

    Public Function List_Tipo_Rol() As List(Of cls_n_tp_rol)
        Return obj_datos.List_Tipo_Rol
    End Function
End Class
