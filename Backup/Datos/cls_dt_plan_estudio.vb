Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_plan_estudio
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Plan_Estudio(ByVal obj_plan_estudio As cls_n_plan_estudio)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_plan_estudio_agregar"

        Dim plan_estudio As New MySqlParameter("?v_plan_estudio", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        plan_estudio.Value = obj_plan_estudio.Plan_Nombre
        plan_estudio.Direction = ParameterDirection.Input
        comando.Parameters.Add(plan_estudio)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Plan_Estudio(ByVal obj_plan_estudio As cls_n_plan_estudio)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_plan_estudio_actualizar"

        Dim id_plan_est As New MySqlParameter("?v_id_plan_est", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_plan_est.Value = obj_plan_estudio.Plan_Codigo
        id_plan_est.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_plan_est)

        Dim plan_estudio As New MySqlParameter("?v_plan_estudio", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        plan_estudio.Value = obj_plan_estudio.Plan_Nombre
        plan_estudio.Direction = ParameterDirection.Input
        comando.Parameters.Add(plan_estudio)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Plan_Estudio(ByVal obj_plan_estudio As cls_n_plan_estudio)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_plan_estudio_borrar"

        Dim id_plan_est As New MySqlParameter("?v_id_plan_est", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_plan_est.Value = obj_plan_estudio.Plan_Codigo
        id_plan_est.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_plan_est)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function Get_Plan_Estudio(ByVal id_plan_est As Integer) As cls_n_plan_estudio
        Dim DataReader As MySqlDataReader
        Dim obj_plan_estudio As New cls_n_plan_estudio
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_plan_est, plan_estudio FROM plan_estudio WHERE id_plan_est = " + id_plan_est.ToString + " ORDER BY id_plan_est ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_plan_estudio.Plan_Codigo = DataReader(0)
            obj_plan_estudio.Plan_Nombre = DataReader(1)
        End While
        conn.Close()
        Return obj_plan_estudio
    End Function

    Public Function Get_Plan_Estudio_Por_Ficha_Alumno(ByVal id_alumno_ficha As Integer) As cls_n_plan_estudio
        Dim DataReader As MySqlDataReader
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT pl.id_plan_est, pl.plan_estudio FROM plan_estudio pl, alumno_ficha af WHERE pl.id_plan_est = af.id_plan_est and af.id_alumno_ficha = " + id_alumno_ficha.ToString
        DataReader = comando.ExecuteReader
        Dim obj_plan_estudio = New cls_n_plan_estudio
        While DataReader.Read
            obj_plan_estudio = New cls_n_plan_estudio
            obj_plan_estudio.Plan_Codigo = DataReader(0)
            obj_plan_estudio.Plan_Nombre = DataReader(1)
        End While
        conn.Close()
        Return obj_plan_estudio
    End Function

    Public Function List_Plan_Estudio() As List(Of cls_n_plan_estudio)
        Dim list_plan_estudios As New List(Of cls_n_plan_estudio)
        Dim DataReader As MySqlDataReader
        Dim obj_plan_estudio As cls_n_plan_estudio
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_plan_est, plan_estudio FROM plan_estudio ORDER BY id_plan_est ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_plan_estudio = New cls_n_plan_estudio
            obj_plan_estudio.Plan_Codigo = DataReader(0)
            obj_plan_estudio.Plan_Nombre = DataReader(1)
            list_plan_estudios.Add(obj_plan_estudio)
        End While
        conn.Close()
        Return list_plan_estudios
    End Function

    Public Function List_Plan_Estudio_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_plan_estudio)
        Dim list_plan_estudios As New List(Of cls_n_plan_estudio)
        Dim DataReader As MySqlDataReader
        Dim obj_plan_estudio As cls_n_plan_estudio
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select distinct ple.id_plan_est, ple.plan_estudio from plan_estudio ple, curso_plan_est cpl, curso_ofertado co where ple.id_plan_est = cpl.id_plan_est and cpl.id_curso = co.id_curso and co.id_periodo = " + id_periodo.ToString + " order by ple.plan_estudio"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_plan_estudio = New cls_n_plan_estudio
            obj_plan_estudio.Plan_Codigo = DataReader(0)
            obj_plan_estudio.Plan_Nombre = DataReader(1)
            list_plan_estudios.Add(obj_plan_estudio)
        End While
        conn.Close()
        Return list_plan_estudios
    End Function
End Class
