Imports Datos
Imports Negocio

Public Class cls_ln_view_curso_grupos
    Private obj_datos As cls_dt_view_curso_grupos

    Public Sub New()
        obj_datos = New cls_dt_view_curso_grupos
    End Sub
    Public Sub Add_Curso_Grupo(ByVal obj_view_curso_grupos As cls_n_view_curso_grupos)
        obj_datos.Add_Curso_Grupo(obj_view_curso_grupos)
    End Sub

    Public Sub Update_Curso_Grupo(ByVal obj_view_curso_grupos As cls_n_view_curso_grupos)
        obj_datos.Update_Curso_Grupo(obj_view_curso_grupos)
    End Sub

    Public Sub Delete_Curso_Grupo(ByVal obj_view_curso_grupos As cls_n_view_curso_grupos)
        obj_datos.Delete_Curso_Grupo(obj_view_curso_grupos)
    End Sub

    Public Function List_View_Cursos_Grupos(ByVal id_curso_ofertado As Integer, ByVal id_horario As Integer) As List(Of cls_n_view_curso_grupos)
        Return obj_datos.List_View_Cursos_Grupos(id_curso_ofertado, id_horario)
    End Function

    Public Function List_View_Cursos_Grupos_Matricula(ByVal id_alumno_ficha As Integer, ByVal id_periodo As Integer, ByVal ciclo As Integer) As List(Of cls_n_view_curso_grupos)
        Return obj_datos.List_View_Cursos_Grupos_Matricula(id_alumno_ficha, id_periodo, ciclo)
    End Function

    Public Function List_Curso_Grupo_Por_Periodo_Curso_Y_Horario(ByVal id_periodo As Integer, ByVal id_curso As Integer, ByVal id_horario As Integer) As List(Of cls_n_view_curso_grupos)
        Return obj_datos.List_Curso_Grupo_Por_Periodo_Curso_Y_Horario(id_periodo, id_curso, id_horario)
    End Function

    Public Function List_Curso_Grupo_Por_Periodo_Curso_Horario_Y_Grupo(ByVal id_periodo As Integer, ByVal id_curso As Integer, ByVal id_horario As Integer, ByVal id_curso_grupo As Integer) As List(Of cls_n_view_curso_grupos)
        Return obj_datos.List_Curso_Grupo_Por_Periodo_Curso_Horario_Y_Grupo(id_periodo, id_curso, id_horario, id_curso_grupo)
    End Function
End Class


