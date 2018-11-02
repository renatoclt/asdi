Imports Datos
Imports Negocio

Public Class cls_ln_curso_ofertado
    Private obj_datos As cls_dt_curso_ofertado

    Public Sub New()
        obj_datos = New cls_dt_curso_ofertado
    End Sub

    Public Sub Update_Curso_Ofertado(ByVal id_curso As Integer, ByVal id_periodo As Integer, ByVal ofertado As Boolean)
        obj_datos.Update_Curso_Ofertado(id_curso, id_periodo, ofertado)
    End Sub

    Public Function List_Curso_Ofertado(ByVal id_periodo As Integer, ByVal id_plan_estudio As Integer) As List(Of cls_n_curso_ofertado)
        Return obj_datos.List_Curso_Ofertado(id_periodo, id_plan_estudio)
    End Function

    Public Function List_View_Curso_Ofertado(ByVal id_periodo As Integer, ByVal id_plan_estudio As Integer) As List(Of cls_n_curso_ofertado)
        Return obj_datos.List_View_Curso_Ofertado(id_periodo, id_plan_estudio)
    End Function

End Class
