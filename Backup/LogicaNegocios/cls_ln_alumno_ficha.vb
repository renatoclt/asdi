Imports Datos
Imports Negocio

Public Class cls_ln_alumno_ficha
    Private obj_datos As cls_dt_alumno_ficha

    Public Sub New()
        obj_datos = New cls_dt_alumno_ficha
    End Sub

    Public Sub Add_Alumno(ByVal obj_alumno As cls_n_alumno_ficha)
        obj_datos.Add_Alumno(obj_alumno)
    End Sub

    Public Sub Update_Alumno(ByVal obj_alumno As cls_n_alumno_ficha)
        obj_datos.Update_Alumno(obj_alumno)
    End Sub

    Public Sub Delete_Alumno(ByVal obj_alumno As cls_n_alumno_ficha)
        obj_datos.Delete_Alumno(obj_alumno)
    End Sub

    Public Function Get_Alumno(ByVal id_persona As Integer) As cls_n_alumno_ficha
        Return obj_datos.Get_Alumno(id_persona)
    End Function

    Public Function List_Alumno() As List(Of cls_n_alumno_ficha)
        Return obj_datos.List_Alumno
    End Function
End Class
