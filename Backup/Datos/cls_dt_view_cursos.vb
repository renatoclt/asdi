Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_view_cursos
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Update_View_Cursos(ByVal obj_view_cursos As cls_n_view_cursos)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_curso_plan_est_actualizar"

        Dim id_cur_plan_est As New MySqlParameter("?v_id_cur_plan_est", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_cur_plan_est.Value = obj_view_cursos.View_Cursos_Codigo
        id_cur_plan_est.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_cur_plan_est)

        Dim orden As New MySqlParameter("?v_orden", MySql.Data.MySqlClient.MySqlDbType.Int16)
        orden.Value = obj_view_cursos.View_Cursos_Orden
        orden.Direction = ParameterDirection.Input
        comando.Parameters.Add(orden)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_View_Cursos(ByVal id_plan_est As Integer) As List(Of cls_n_view_cursos)
        Dim lista_view_cursos As New List(Of cls_n_view_cursos)
        Dim DataReader As MySqlDataReader
        Dim obj_view_cursos As cls_n_view_cursos
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_cur_plan_est, id_plan_est, plan_estudio, id_curso, curso, orden FROM view_cursos_plan_estudios where id_plan_est = " + id_plan_est.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_cursos = New cls_n_view_cursos
            obj_view_cursos.View_Cursos_Codigo = DataReader(0)
            obj_view_cursos.View_Cursos_Plan_Codigo = DataReader(1)
            obj_view_cursos.View_Cursos_Plan = DataReader(2)
            obj_view_cursos.View_Cursos_Curso_Codigo = DataReader(3)
            obj_view_cursos.View_Cursos_Curso = DataReader(4)
            obj_view_cursos.View_Cursos_Orden = DataReader(5)
            lista_view_cursos.Add(obj_view_cursos)
        End While
        conn.Close()
        Return lista_view_cursos
    End Function

    Public Function List_Cursos_Periodo_y_Horario(ByVal id_periodo As Integer, ByVal id_horario As Integer) As List(Of cls_n_curso_reporte)
        Dim lista_cursos As New List(Of cls_n_curso_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_cursos As cls_n_curso_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT periodo, curso, grupo, profesor, horario, aula, matriculados FROM view_curso_periodo v where id_periodo =" + id_periodo.ToString + " and id_horario =" + id_horario.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_cursos = New cls_n_curso_reporte
            obj_cursos.Reporte_Curso_Periodo = DataReader(0)
            obj_cursos.Reporte_Curso_Curso = DataReader(1)
            obj_cursos.Reporte_Curso_Grupo = DataReader(2)
            obj_cursos.Reporte_Curso_Profesor = DataReader(3)
            obj_cursos.Reporte_Curso_Horario = DataReader(4)
            obj_cursos.Reporte_Curso_Aula = DataReader(5)
            obj_cursos.Reporte_Curso_Matriculados = DataReader(6)
            lista_cursos.Add(obj_cursos)
        End While
        conn.Close()
        Return lista_cursos
    End Function

    Public Function List_Cursos_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_curso_reporte)
        Dim lista_cursos As New List(Of cls_n_curso_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_cursos As cls_n_curso_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT periodo, curso, grupo, profesor, horario, aula, matriculados FROM view_curso_periodo v where id_periodo =" + id_periodo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_cursos = New cls_n_curso_reporte
            obj_cursos.Reporte_Curso_Periodo = DataReader(0)
            obj_cursos.Reporte_Curso_Curso = DataReader(1)
            obj_cursos.Reporte_Curso_Grupo = DataReader(2)
            obj_cursos.Reporte_Curso_Profesor = DataReader(3)
            obj_cursos.Reporte_Curso_Horario = DataReader(4)
            obj_cursos.Reporte_Curso_Aula = DataReader(5)
            obj_cursos.Reporte_Curso_Matriculados = DataReader(6)
            lista_cursos.Add(obj_cursos)
        End While
        conn.Close()
        Return lista_cursos
    End Function
End Class
