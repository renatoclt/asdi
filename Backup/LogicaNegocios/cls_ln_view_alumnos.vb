Imports Datos
Imports Negocio

Public Class cls_ln_view_alumnos
    Private obj_datos As cls_dt_view_alumnos

    Public Sub New()
        obj_datos = New cls_dt_view_alumnos
    End Sub

    Public Function Buscar_View_Alumnos_Nombres(ByVal nombres As String) As List(Of cls_n_view_alumnos)
        Return obj_datos.Buscar_View_Alumnos_Nombres(nombres)
    End Function

    Public Function Obtener_View_Alumnos(ByVal id_alumno_ficha As Integer) As cls_n_view_alumnos
        Return obj_datos.Obtener_View_Alumnos(id_alumno_ficha)
    End Function

    Public Function Lista_Alumnos_Por_Profesor(ByVal id_profesor_ficha As Integer) As List(Of cls_n_alumno_reporte)
        Return obj_datos.Lista_Alumnos_Por_Profesor(id_profesor_ficha)
    End Function

    Public Function Lista_Alumnos_Por_Curso_Ofertado(ByVal id_curso_ofertado As Integer) As List(Of cls_n_alumno_reporte)
        Return obj_datos.Lista_Alumnos_Por_Curso_Ofertado(id_curso_ofertado)
    End Function

    Public Function Lista_Alumnos_Por_Horario(ByVal id_horario As Integer) As List(Of cls_n_alumno_reporte)
        Return obj_datos.Lista_Alumnos_Por_Horario(id_horario)
    End Function

    Public Function Lista_Alumnos_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_alumno_reporte)
        Return obj_datos.Lista_Alumnos_Por_Periodo(id_periodo)
    End Function

    Public Function List_View_Alumnos_Nombres_Curso_Grupo(ByVal id_curso_grupo As Integer) As List(Of cls_n_matricula)
        Return obj_datos.List_View_Alumnos_Nombres_Curso_Grupo(id_curso_grupo)
    End Function
End Class
