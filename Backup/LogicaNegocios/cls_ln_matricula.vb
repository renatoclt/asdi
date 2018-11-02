Imports Datos
Imports Negocio

Public Class cls_ln_matricula
    Private obj_datos As cls_dt_matricula

    Public Sub New()
        obj_datos = New cls_dt_matricula
    End Sub

    Public Sub Add_Matricula(ByVal obj_matricula As cls_n_matricula)
        obj_datos.Add_Matricula(obj_matricula)
    End Sub

    Public Sub Update_Matricula(ByVal obj_matricula As cls_n_matricula)
        obj_datos.Update_Matricula(obj_matricula)
    End Sub

    Public Sub Delete_Matricula(ByVal obj_matricula As cls_n_matricula)
        obj_datos.Delete_Matricula(obj_matricula)
    End Sub
End Class
