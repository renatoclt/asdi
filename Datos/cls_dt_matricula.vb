Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_matricula
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Matricula(ByVal obj_matricula As cls_n_matricula)
        Try
            conn = objConexion.Open
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "prc_matricula_agregar"

            Dim id_alumno_ficha As New MySqlParameter("?v_id_alumno_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
            id_alumno_ficha.Value = obj_matricula.Matricula_Alumno_Codigo
            id_alumno_ficha.Direction = ParameterDirection.Input
            comando.Parameters.Add(id_alumno_ficha)

            Dim id_curso_grupo As New MySqlParameter("?v_id_curso_grupo", MySql.Data.MySqlClient.MySqlDbType.Int16)
            id_curso_grupo.Value = obj_matricula.Matricula_Curso_Grupo_Codigo
            id_curso_grupo.Direction = ParameterDirection.Input
            comando.Parameters.Add(id_curso_grupo)

            Dim id_periodo As New MySqlParameter("?v_id_periodo", MySql.Data.MySqlClient.MySqlDbType.Int16)
            id_periodo.Value = obj_matricula.Matricula_Periodo_Codigo
            id_periodo.Direction = ParameterDirection.Input
            comando.Parameters.Add(id_periodo)

            Dim fecha_creacion As New MySqlParameter("?v_fecha_creacion", MySql.Data.MySqlClient.MySqlDbType.DateTime)
            fecha_creacion.Value = obj_matricula.Matricula_Fecha_Creacion
            fecha_creacion.Direction = ParameterDirection.Input
            comando.Parameters.Add(fecha_creacion)

            comando.ExecuteNonQuery()
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Update_Matricula(ByVal obj_matricula As cls_n_matricula)
        Try
            conn = objConexion.Open
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "prc_matricula_actualizar"

            Dim id_matricula As New MySqlParameter("?v_id_matricula", MySql.Data.MySqlClient.MySqlDbType.Int16)
            id_matricula.Value = obj_matricula.Matricula_Codigo
            id_matricula.Direction = ParameterDirection.Input
            comando.Parameters.Add(id_matricula)

            Dim id_curso_grupo As New MySqlParameter("?v_id_curso_grupo", MySql.Data.MySqlClient.MySqlDbType.Int16)
            id_curso_grupo.Value = obj_matricula.Matricula_Curso_Grupo_Codigo
            id_curso_grupo.Direction = ParameterDirection.Input
            comando.Parameters.Add(id_curso_grupo)

            comando.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Delete_Matricula(ByVal obj_matricula As cls_n_matricula)
        Try
            conn = objConexion.Open
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "prc_matricula_borrar"

            Dim id_matricula As New MySqlParameter("?v_id_matricula", MySql.Data.MySqlClient.MySqlDbType.Int16)
            id_matricula.Value = obj_matricula.Matricula_Codigo
            id_matricula.Direction = ParameterDirection.Input
            comando.Parameters.Add(id_matricula)

            comando.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
