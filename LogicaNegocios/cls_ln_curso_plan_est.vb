Imports Datos
Imports Negocio

Public Class cls_ln_curso_plan_est
    Private obj_datos As cls_dt_curso_plan_est

    Public Sub New()
        obj_datos = New cls_dt_curso_plan_est
    End Sub

    Public Sub Update_Curso_Plan_Est(ByVal obj_curso_plan_est As cls_n_curso_plan_est, ByVal pertenece As Boolean)
        obj_datos.Update_Curso_Plan_Est(obj_curso_plan_est, pertenece)
    End Sub
End Class
