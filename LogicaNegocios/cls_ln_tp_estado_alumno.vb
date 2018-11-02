Imports Datos
Imports Negocio

Public Class cls_ln_tp_estado_alumno
    Private obj_datos As cls_dt_tp_estado_alumno

    Public Sub New()
        obj_datos = New cls_dt_tp_estado_alumno
    End Sub

    Public Sub Add_Tipo_Estado_Alumno(ByVal obj_tp_estado_alumno As cls_n_tp_estado_alumno)
        obj_datos.Add_Tipo_Estado_Alumno(obj_tp_estado_alumno)
    End Sub

    Public Sub Update_Tipo_Estado_Alumno(ByVal obj_tp_estado_alumno As cls_n_tp_estado_alumno)
        obj_datos.Update_Tipo_Estado_Alumno(obj_tp_estado_alumno)
    End Sub

    Public Sub Delete_Tipo_Estado_Alumno(ByVal obj_tp_estado_alumno As cls_n_tp_estado_alumno)
        obj_datos.Delete_Tipo_Estado_Alumno(obj_tp_estado_alumno)
    End Sub

    Public Function Get_Tipo_Estado_Alumno(ByVal id_tp_est_alum As Integer) As cls_n_tp_estado_alumno
        Return obj_datos.Get_Tipo_Estado_Alumno(id_tp_est_alum)
    End Function

    Public Function List_Tipo_Estado_Alumno() As List(Of cls_n_tp_estado_alumno)
        Return obj_datos.List_Tipo_Estado_Alumno
    End Function
End Class
