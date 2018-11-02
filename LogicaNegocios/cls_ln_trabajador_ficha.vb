Imports Datos
Imports Negocio

Public Class cls_ln_trabajador_ficha
    Private obj_datos As cls_dt_trabajador_ficha

    Public Sub New()
        obj_datos = New cls_dt_trabajador_ficha
    End Sub

    Public Sub Add_Trabajador(ByVal obj_trabajador As cls_n_trabajador_ficha)
        obj_datos.Add_Trabajador(obj_trabajador)
    End Sub

    Public Sub Update_Trabajador(ByVal obj_trabajador As cls_n_trabajador_ficha)
        obj_datos.Update_Trabajador(obj_trabajador)
    End Sub

    Public Sub Delete_Trabajador(ByVal obj_trabajador As cls_n_trabajador_ficha)
        obj_datos.Delete_Trabajador(obj_trabajador)
    End Sub

    Public Function List_Trabajador() As List(Of cls_n_trabajador_ficha)
        Return obj_datos.List_Trabajador
    End Function

    Public Function Get_Trabajador(ByVal id_persona As Integer) As cls_n_trabajador_ficha
        Return obj_datos.Get_Trabajador(id_persona)
    End Function
End Class
