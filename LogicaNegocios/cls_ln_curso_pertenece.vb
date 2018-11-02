Imports Datos
Imports Negocio

Public Class cls_ln_curso_pertenece
    Private obj_datos As cls_dt_curso_pertenece

    Public Sub New()
        obj_datos = New cls_dt_curso_pertenece
    End Sub

    Public Function Buscar_View_Cursos(ByVal id_plan_est As Integer) As List(Of cls_n_curso_pertenece)
        Return obj_datos.Buscar_View_Cursos(id_plan_est)
    End Function

    Public Function Buscar_View_Cursos() As List(Of cls_n_curso_pertenece)
        Return obj_datos.Buscar_View_Cursos()
    End Function
End Class
