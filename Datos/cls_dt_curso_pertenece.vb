Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_curso_pertenece
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Function Buscar_View_Cursos(ByVal id_plan_est As Integer) As List(Of cls_n_curso_pertenece)
        Dim list_cursos As New List(Of cls_n_curso_pertenece)
        Dim DataReader As MySqlDataReader
        Dim obj_view_curso As cls_n_curso_pertenece
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select id_curso, concat(curso, ' ', concat('(',abreviatura,')')) as curso, if(fnc_curso_plan_est(id_curso, " + id_plan_est.ToString + " ) <> 0, true, false) as pertenece from curso order by curso"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_curso = New cls_n_curso_pertenece
            obj_view_curso.Curso_Pertenece_Codigo = DataReader(0)
            obj_view_curso.Curso_Pertenece_Nombre = DataReader(1)
            obj_view_curso.Curso_Pertenece_Pertenece = DataReader(2)
            list_cursos.Add(obj_view_curso)
        End While
        conn.Close()
        Return list_cursos
    End Function

    Public Function Buscar_View_Cursos() As List(Of cls_n_curso_pertenece)
        Dim list_cursos As New List(Of cls_n_curso_pertenece)
        Dim DataReader As MySqlDataReader
        Dim obj_view_curso As cls_n_curso_pertenece
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select id_curso, concat(curso, ' ', concat('(',abreviatura,')')) as curso, false as pertenece from curso order by curso"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_curso = New cls_n_curso_pertenece
            obj_view_curso.Curso_Pertenece_Codigo = DataReader(0)
            obj_view_curso.Curso_Pertenece_Nombre = DataReader(1)
            obj_view_curso.Curso_Pertenece_Pertenece = DataReader(2)
            list_cursos.Add(obj_view_curso)
        End While
        conn.Close()
        Return list_cursos
    End Function

End Class
