Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_tramite
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Tramite(ByVal obj_tramite As cls_n_tramite)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tramite_agregar"

        Dim id_alumno_ficha As New MySqlParameter("?v_id_alumno_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_alumno_ficha.Value = obj_tramite.Tramite_Alumno_Codigo
        id_alumno_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_alumno_ficha)

        Dim fecha_creacion As New MySqlParameter("?v_fecha_creacion", MySql.Data.MySqlClient.MySqlDbType.DateTime)
        fecha_creacion.Value = obj_tramite.Tramite_Fecha_Creacion
        fecha_creacion.Direction = ParameterDirection.Input
        comando.Parameters.Add(fecha_creacion)

        Dim id_tp_tramite As New MySqlParameter("?v_id_tp_tramite", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_tramite.Value = obj_tramite.Tramite_Tipo_Tramite
        id_tp_tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_tramite)

        Dim entregado As New MySqlParameter("?v_entregado", MySql.Data.MySqlClient.MySqlDbType.UInt16)
        entregado.Value = obj_tramite.Tramite_Entregado
        entregado.Direction = ParameterDirection.Input
        comando.Parameters.Add(entregado)

        Dim fecha_entregado As New MySqlParameter("?v_fecha_entregado", MySql.Data.MySqlClient.MySqlDbType.DateTime)
        fecha_entregado.Value = Convert.ToDateTime("0001-01-01 01:01:01")
        fecha_entregado.Direction = ParameterDirection.Input
        comando.Parameters.Add(fecha_entregado)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Tramite(ByVal obj_tramite As cls_n_tramite)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tramite_actualizar"

        Dim id_tramite As New MySqlParameter("?v_id_tramite", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tramite.Value = obj_tramite.Tramite_Codigo
        id_tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tramite)

        Dim entregado As New MySqlParameter("?v_entregado", MySql.Data.MySqlClient.MySqlDbType.Int16)
        entregado.Value = obj_tramite.Tramite_Entregado
        entregado.Direction = ParameterDirection.Input
        comando.Parameters.Add(entregado)

        Dim fecha_entregado As New MySqlParameter("?v_fecha_entregado", MySql.Data.MySqlClient.MySqlDbType.DateTime)
        fecha_entregado.Value = obj_tramite.Tramite_Fecha_Entregado
        fecha_entregado.Direction = ParameterDirection.Input
        comando.Parameters.Add(fecha_entregado)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Tramite(ByVal obj_tramite As cls_n_tramite)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tramite_borrar"

        Dim id_tramite As New MySqlParameter("?v_id_tramite", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tramite.Value = obj_tramite.Tramite_Codigo
        id_tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tramite)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

End Class
