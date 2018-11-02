Imports Datos
Imports Negocio

Public Class cls_ln_view_separata_curso
    Private obj_datos As cls_dt_view_separata_curso

    Public Sub New()
        obj_datos = New cls_dt_view_separata_curso
    End Sub

    Public Sub Add_Separata_Curso(ByVal obj_view_separata_curso As cls_n_view_separata_curso)
        obj_datos.Add_Separata_Curso(obj_view_separata_curso)
    End Sub

    Public Sub Update_Separata_Curso(ByVal obj_view_separata_curso As cls_n_view_separata_curso)
        obj_datos.Update_Separata_Curso(obj_view_separata_curso)
    End Sub

    Public Sub Delete_Separata_Curso(ByVal obj_view_separata_curso As cls_n_view_separata_curso)
        obj_datos.Delete_Separata_Curso(obj_view_separata_curso)
    End Sub

    Public Function List_Separata_Curso() As List(Of cls_n_view_separata_curso)
        Return obj_datos.List_Separata_Curso
    End Function

End Class
