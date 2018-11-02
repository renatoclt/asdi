Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_tp_estado_alumno
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Tipo_Estado_Alumno(ByVal obj_tp_estado_alumno As cls_n_tp_estado_alumno)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_estado_alumno_agregar"

        Dim tp_est_alum As New MySqlParameter("?v_tp_est_alum", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tp_est_alum.Value = obj_tp_estado_alumno.Tipo_Estado_Alumno_Nombre
        tp_est_alum.Direction = ParameterDirection.Input
        comando.Parameters.Add(tp_est_alum)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Tipo_Estado_Alumno(ByVal obj_tp_estado_alumno As cls_n_tp_estado_alumno)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_estado_alumno_actualizar"

        Dim id_tp_est_alum As New MySqlParameter("?v_id_tp_est_alum", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_est_alum.Value = obj_tp_estado_alumno.Tipo_Estado_Alumno_Codigo
        id_tp_est_alum.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_est_alum)

        Dim tp_est_alum As New MySqlParameter("?v_tp_est_alum", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tp_est_alum.Value = obj_tp_estado_alumno.Tipo_Estado_Alumno_Nombre
        tp_est_alum.Direction = ParameterDirection.Input
        comando.Parameters.Add(tp_est_alum)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Tipo_Estado_Alumno(ByVal obj_tp_estado_alumno As cls_n_tp_estado_alumno)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_estado_alumno_borrar"

        Dim id_tp_est_alum As New MySqlParameter("?v_id_tp_est_alum", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_est_alum.Value = obj_tp_estado_alumno.Tipo_Estado_Alumno_Codigo
        id_tp_est_alum.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_est_alum)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function Get_Tipo_Estado_Alumno(ByVal id_tp_est_alum As Integer) As cls_n_tp_estado_alumno
        Dim DataReader As MySqlDataReader
        Dim obj_tp_estado_alumno As New cls_n_tp_estado_alumno
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_tp_est_alum, tp_est_alum FROM tipo_estado_alumno WHERE id_tp_est_alum = " + id_tp_est_alum.ToString + " ORDER BY id_tp_est_alum ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_tp_estado_alumno.Tipo_Estado_Alumno_Codigo = DataReader(0)
            obj_tp_estado_alumno.Tipo_Estado_Alumno_Nombre = DataReader(1)
        End While
        conn.Close()
        Return obj_tp_estado_alumno
    End Function

    Public Function List_Tipo_Estado_Alumno() As List(Of cls_n_tp_estado_alumno)
        Dim list_tipo_estado_alumnos As New List(Of cls_n_tp_estado_alumno)
        Dim DataReader As MySqlDataReader
        Dim obj_tp_estado_alumno As cls_n_tp_estado_alumno
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_tp_est_alum, tp_est_alum FROM tipo_estado_alumno ORDER BY id_tp_est_alum ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_tp_estado_alumno = New cls_n_tp_estado_alumno
            obj_tp_estado_alumno.Tipo_Estado_Alumno_Codigo = DataReader(0)
            obj_tp_estado_alumno.Tipo_Estado_Alumno_Nombre = DataReader(1)
            list_tipo_estado_alumnos.Add(obj_tp_estado_alumno)
        End While
        conn.Close()
        Return list_tipo_estado_alumnos
    End Function
End Class
