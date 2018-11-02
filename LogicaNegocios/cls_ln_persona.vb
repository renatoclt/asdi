Imports Datos
Imports Negocio

Public Class cls_ln_persona
    Private obj_datos As cls_dt_persona

    Public Sub New()
        obj_datos = New cls_dt_persona
    End Sub

    Public Sub Add_Persona(ByVal obj_persona As cls_n_persona)
        obj_datos.Add_Persona(obj_persona)
    End Sub

    Public Sub Update_Persona(ByVal obj_persona As cls_n_persona)
        obj_datos.Update_Persona(obj_persona)
    End Sub

    Public Sub Delete_Persona(ByVal obj_persona As cls_n_persona)
        obj_datos.Delete_Persona(obj_persona)
    End Sub

    Public Function Get_Persona(ByVal id_persona As Integer) As cls_n_persona
        Return obj_datos.Get_Persona(id_persona)
    End Function

    Public Function Login_Persona(ByVal obj_persona As cls_n_persona) As Integer
        Return obj_datos.Login_Persona(obj_persona)
    End Function

End Class
