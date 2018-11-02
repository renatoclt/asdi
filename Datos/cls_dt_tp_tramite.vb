Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_tp_tramite
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Tipo_Tramite(ByVal obj_tp_tramite As cls_n_tp_tramite)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_tramite_agregar"

        Dim tp_tramite As New MySqlParameter("?v_tp_tramite", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tp_tramite.Value = obj_tp_tramite.Tipo_Tramite_Nombre
        tp_tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(tp_tramite)

        Dim costo As New MySqlParameter("?v_costo", MySql.Data.MySqlClient.MySqlDbType.Decimal)
        costo.Value = obj_tp_tramite.Tipo_Tramite_Costo
        costo.Direction = ParameterDirection.Input
        comando.Parameters.Add(costo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Tipo_Tramite(ByVal obj_tp_tramite As cls_n_tp_tramite)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_tramite_actualizar"

        Dim id_tp_tramite As New MySqlParameter("?v_id_tp_tramite", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_tramite.Value = obj_tp_tramite.Tipo_Tramite_Codgio
        id_tp_tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_tramite)

        Dim tp_tramite As New MySqlParameter("?v_tp_tramite", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tp_tramite.Value = obj_tp_tramite.Tipo_Tramite_Nombre
        tp_tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(tp_tramite)

        Dim costo As New MySqlParameter("?v_costo", MySql.Data.MySqlClient.MySqlDbType.Decimal)
        costo.Value = obj_tp_tramite.Tipo_Tramite_Costo
        costo.Direction = ParameterDirection.Input
        comando.Parameters.Add(costo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Tipo_Tramite(ByVal obj_tp_tramite As cls_n_tp_tramite)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_tramite_borrar"

        Dim id_tp_tramite As New MySqlParameter("?v_id_tp_tramite", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_tramite.Value = obj_tp_tramite.Tipo_Tramite_Codgio
        id_tp_tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_tramite)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_Tipo_Tramite() As List(Of cls_n_tp_tramite)
        Dim list_tipo_tramites As New List(Of cls_n_tp_tramite)
        Dim DataReader As MySqlDataReader
        Dim obj_tp_tramite As cls_n_tp_tramite
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_tp_tramite, tp_tramite, costo FROM tipo_tramite ORDER BY id_tp_tramite ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_tp_tramite = New cls_n_tp_tramite
            obj_tp_tramite.Tipo_Tramite_Codgio = DataReader(0)
            obj_tp_tramite.Tipo_Tramite_Nombre = DataReader(1)
            obj_tp_tramite.Tipo_Tramite_Costo = DataReader(2)
            list_tipo_tramites.Add(obj_tp_tramite)
        End While
        conn.Close()
        Return list_tipo_tramites
    End Function
End Class
