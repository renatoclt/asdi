Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_tp_documento
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Tipo_Documento(ByVal obj_tp_documento As cls_n_tp_documento)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_documento_agregar"

        Dim tp_documento As New MySqlParameter("?v_tp_documento", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tp_documento.Value = obj_tp_documento.Documento_Nombre
        tp_documento.Direction = ParameterDirection.Input
        comando.Parameters.Add(tp_documento)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Tipo_Documento(ByVal obj_tp_documento As cls_n_tp_documento)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_documento_actualizar"

        Dim id_tp_documento As New MySqlParameter("?v_id_tp_documento", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_documento.Value = obj_tp_documento.Documento_Codigo
        id_tp_documento.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_documento)

        Dim tp_documento As New MySqlParameter("?v_tp_documento", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tp_documento.Value = obj_tp_documento.Documento_Nombre
        tp_documento.Direction = ParameterDirection.Input
        comando.Parameters.Add(tp_documento)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Tipo_Documento(ByVal obj_tp_documento As cls_n_tp_documento)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_tp_documento_borrar"

        Dim id_tp_documento As New MySqlParameter("?v_id_tp_documento", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_documento.Value = obj_tp_documento.Documento_Codigo
        id_tp_documento.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_documento)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function Get_Tipo_Documento(ByVal id_tp_documento As Integer) As cls_n_tp_documento
        Dim DataReader As MySqlDataReader
        Dim obj_tp_documento As New cls_n_tp_documento
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "Select id_tp_documento, tp_documento from tipo_documento WHERE id_tp_documento = " + id_tp_documento.ToString + " order by id_tp_documento asc"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_tp_documento.Documento_Codigo = DataReader(0)
            obj_tp_documento.Documento_Nombre = DataReader(1)
        End While
        conn.Close()
        Return obj_tp_documento
    End Function

    Public Function List_Tipo_Documento() As List(Of cls_n_tp_documento)
        Dim list_tp_documento As New List(Of cls_n_tp_documento)
        Dim DataReader As MySqlDataReader
        Dim obj_tp_documento As cls_n_tp_documento
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "Select id_tp_documento, tp_documento from tipo_documento order by id_tp_documento asc"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_tp_documento = New cls_n_tp_documento
            obj_tp_documento.Documento_Codigo = DataReader(0)
            obj_tp_documento.Documento_Nombre = DataReader(1)
            list_tp_documento.Add(obj_tp_documento)
        End While
        conn.Close()
        Return list_tp_documento
    End Function

End Class
