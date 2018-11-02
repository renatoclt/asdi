Imports Datos
Imports Negocio

Public Class cls_ln_profesor_ficha
    Private obj_datos As cls_dt_profesor_ficha

    Public Sub New()
        obj_datos = New cls_dt_profesor_ficha
    End Sub

    Public Sub Add_Profesor(ByVal obj_profesor As cls_n_profesor_ficha)
        obj_datos.Add_Profesor(obj_profesor)
    End Sub

    Public Sub Update_Profesor(ByVal obj_profesor As cls_n_profesor_ficha)
        obj_datos.Update_Profesor(obj_profesor)
    End Sub

    Public Sub Delete_Profesor(ByVal obj_profesor As cls_n_profesor_ficha)
        obj_datos.Delete_Profesor(obj_profesor)
    End Sub

    Public Function Get_Profesor(ByVal id_persona As Integer) As cls_n_profesor_ficha
        Return obj_datos.Get_Profesor(id_persona)
    End Function

    Public Function List_Profesor() As List(Of cls_n_profesor_ficha)
        Return obj_datos.List_Profesor
    End Function
End Class
