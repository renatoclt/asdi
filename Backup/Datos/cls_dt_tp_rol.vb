Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_tp_rol
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Tipo_Rol(ByVal obj_tp_rol As cls_n_tp_rol)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_rol_agregar"

        Dim tp_rol As New MySqlParameter("?v_tp_rol", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tp_rol.Value = obj_tp_rol.Tipo_Rol_Nombre
        tp_rol.Direction = ParameterDirection.Input
        comando.Parameters.Add(tp_rol)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Tipo_Rol(ByVal obj_tp_rol As cls_n_tp_rol)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_rol_actualizar"

        Dim id_tp_rol As New MySqlParameter("?v_id_tp_rol", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_rol.Value = obj_tp_rol.Tipo_Rol_Codigo
        id_tp_rol.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_rol)

        Dim tp_rol As New MySqlParameter("?v_tp_rol", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tp_rol.Value = obj_tp_rol.Tipo_Rol_Nombre
        tp_rol.Direction = ParameterDirection.Input
        comando.Parameters.Add(tp_rol)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Tipo_Rol(ByVal obj_tp_rol As cls_n_tp_rol)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_rol_borrar"

        Dim id_tp_rol As New MySqlParameter("?v_id_tp_rol", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_rol.Value = obj_tp_rol.Tipo_Rol_Codigo
        id_tp_rol.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_rol)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_Tipo_Rol() As List(Of cls_n_tp_rol)
        Dim list_tipo_roles As New List(Of cls_n_tp_rol)
        Dim DataReader As MySqlDataReader
        Dim obj_tp_tramite As cls_n_tp_rol
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_tp_rol, tp_rol FROM tipo_rol ORDER BY id_tp_rol ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_tp_tramite = New cls_n_tp_rol
            obj_tp_tramite.Tipo_Rol_Codigo = DataReader(0)
            obj_tp_tramite.Tipo_Rol_Nombre = DataReader(1)
            list_tipo_roles.Add(obj_tp_tramite)
        End While
        conn.Close()
        Return list_tipo_roles
    End Function
End Class
