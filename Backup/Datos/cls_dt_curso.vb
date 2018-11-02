Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_curso
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Curso(ByVal obj_curso As cls_n_curso)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_curso_agregar"

        Dim curso As New MySqlParameter("?v_curso", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        curso.Value = obj_curso.Curso_Nombre
        curso.Direction = ParameterDirection.Input
        comando.Parameters.Add(curso)

        Dim abreviatura As New MySqlParameter("?v_abreviatura", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        abreviatura.Value = obj_curso.Curso_Abreviatura
        abreviatura.Direction = ParameterDirection.Input
        comando.Parameters.Add(abreviatura)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Curso(ByVal obj_curso As cls_n_curso)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_curso_actualizar"

        Dim id_curso As New MySqlParameter("?v_id_curso", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_curso.Value = obj_curso.Curso_Codigo
        id_curso.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_curso)

        Dim curso As New MySqlParameter("?v_curso", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        curso.Value = obj_curso.Curso_Nombre
        curso.Direction = ParameterDirection.Input
        comando.Parameters.Add(curso)

        Dim abreviatura As New MySqlParameter("?v_abreviatura", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        abreviatura.Value = obj_curso.Curso_Abreviatura
        abreviatura.Direction = ParameterDirection.Input
        comando.Parameters.Add(abreviatura)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Curso(ByVal obj_curso As cls_n_curso)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_curso_borrar"

        Dim id_curso As New MySqlParameter("?v_id_curso", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_curso.Value = obj_curso.Curso_Codigo
        id_curso.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_curso)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_Curso() As List(Of cls_n_curso)
        Dim list_cursos As New List(Of cls_n_curso)
        Dim DataReader As MySqlDataReader
        Dim obj_curso As cls_n_curso
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_curso, curso, abreviatura FROM curso ORDER BY id_curso ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_curso = New cls_n_curso
            obj_curso.Curso_Codigo = DataReader(0)
            obj_curso.Curso_Nombre = DataReader(1)
            obj_curso.Curso_Abreviatura = DataReader(2)
            list_cursos.Add(obj_curso)
        End While
        conn.Close()
        Return list_cursos
    End Function

    Public Function List_Curso_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_curso)
        Dim list_cursos As New List(Of cls_n_curso)
        Dim DataReader As MySqlDataReader
        Dim obj_curso As cls_n_curso
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT c.id_curso, c.curso, c.abreviatura FROM curso c, curso_ofertado co WHERE co.id_curso = c.id_curso AND co.id_periodo = " + id_periodo.ToString + " ORDER BY c.id_curso ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_curso = New cls_n_curso
            obj_curso.Curso_Codigo = DataReader(0)
            obj_curso.Curso_Nombre = DataReader(1)
            obj_curso.Curso_Abreviatura = DataReader(2)
            list_cursos.Add(obj_curso)
        End While
        conn.Close()
        Return list_cursos
    End Function

    Public Function List_Curso_Por_Periodo_Y_Horario(ByVal id_periodo As Integer, ByVal id_horario As Integer) As List(Of cls_n_curso)
        Dim list_cursos As New List(Of cls_n_curso)
        Dim DataReader As MySqlDataReader
        Dim obj_curso As cls_n_curso
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select distinct c.id_curso, c.curso, c.abreviatura from curso c, curso_ofertado co, curso_grupo cg where c.id_curso = co.id_curso and co.id_curso_ofertado = cg.id_curso_ofertado and co.id_periodo = " + id_periodo.ToString + " and cg.id_horario = " + id_horario.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_curso = New cls_n_curso
            obj_curso.Curso_Codigo = DataReader(0)
            obj_curso.Curso_Nombre = DataReader(1)
            obj_curso.Curso_Abreviatura = DataReader(2)
            list_cursos.Add(obj_curso)
        End While
        conn.Close()
        Return list_cursos
    End Function



End Class
