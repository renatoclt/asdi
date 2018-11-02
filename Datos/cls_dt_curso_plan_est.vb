Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_curso_plan_est
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Update_Curso_Plan_Est(ByVal obj_curso_plan_est As cls_n_curso_plan_est, ByVal pertenece As Boolean)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_curso_plan_est_agregar_borrar"

        Dim id_curso As New MySqlParameter("?v_id_curso", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_curso.Value = obj_curso_plan_est.Curso_Plan_Codigo_Curso
        id_curso.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_curso)

        Dim id_plan_est As New MySqlParameter("?v_id_plan_est", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_plan_est.Value = obj_curso_plan_est.Curso_Plan_Codigo_Plan
        id_plan_est.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_plan_est)

        Dim v_pertenece As New MySqlParameter("?v_pertenece", MySql.Data.MySqlClient.MySqlDbType.Int16)
        v_pertenece.Value = pertenece
        v_pertenece.Direction = ParameterDirection.Input
        comando.Parameters.Add(v_pertenece)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

End Class
