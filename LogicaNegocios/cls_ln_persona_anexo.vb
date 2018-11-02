Imports Datos
Imports Negocio

Public Class cls_ln_persona_anexo
    Private obj_datos As cls_dt_persona_anexo

    Public Sub New()
        obj_datos = New cls_dt_persona_anexo
    End Sub

    Public Sub Add_Persona_Anexo(ByVal obj_persona_anexo As cls_n_persona_anexo)
        obj_datos.Add_Persona_Anexo(obj_persona_anexo)
    End Sub

    Public Sub Update_Persona_Anexo(ByVal obj_persona_anexo As cls_n_persona_anexo)
        obj_datos.Update_Persona_Anexo(obj_persona_anexo)
    End Sub

    Public Sub Delete_Persona_Anexo(ByVal obj_persona_anexo As cls_n_persona_anexo)
        obj_datos.Delete_Persona_Anexo(obj_persona_anexo)
    End Sub

    Public Function Get_Persona_Anexo(ByVal id_persona As Integer) As cls_n_persona_anexo
        Return obj_datos.Get_Persona_Anexo(id_persona)
    End Function

    Public Function List_Persona_Anexo() As List(Of cls_n_persona_anexo)
        Return obj_datos.List_Persona_Anexo
    End Function
End Class
