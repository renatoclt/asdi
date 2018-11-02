Imports Datos
Imports Negocio

Public Class cls_ln_tp_documento
    Private obj_datos As cls_dt_tp_documento

    Public Sub New()
        obj_datos = New cls_dt_tp_documento
    End Sub

    Public Sub Add_Tipo_Documento(ByVal obj_tp_documento As cls_n_tp_documento)
        obj_datos.Add_Tipo_Documento(obj_tp_documento)
    End Sub

    Public Sub Update_Tipo_Documento(ByVal obj_tp_documento As cls_n_tp_documento)
        obj_datos.Update_Tipo_Documento(obj_tp_documento)
    End Sub

    Public Sub Delete_Tipo_Documento(ByVal obj_tp_documento As cls_n_tp_documento)
        obj_datos.Delete_Tipo_Documento(obj_tp_documento)
    End Sub

    Public Function Get_Tipo_Documento(ByVal id_tp_documento As Integer) As cls_n_tp_documento
        Return obj_datos.Get_Tipo_Documento(id_tp_documento)
    End Function

    Public Function List_Tipo_Documento() As List(Of cls_n_tp_documento)
        Return obj_datos.List_Tipo_Documento
    End Function

End Class
