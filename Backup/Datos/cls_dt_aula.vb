Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_aula
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Aula(ByVal obj_aula As cls_n_aula)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_aula_agregar"

        Dim aula As New MySqlParameter("?v_aula", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        aula.Value = obj_aula.Aula_Nombre
        aula.Direction = ParameterDirection.Input
        comando.Parameters.Add(aula)

        Dim capacidad As New MySqlParameter("?v_capacidad", MySql.Data.MySqlClient.MySqlDbType.Int16)
        capacidad.Value = obj_aula.Aula_Capacidad
        capacidad.Direction = ParameterDirection.Input
        comando.Parameters.Add(capacidad)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Aula(ByVal obj_aula As cls_n_aula)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_aula_actualizar"

        Dim id_aula As New MySqlParameter("?v_id_aula", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_aula.Value = obj_aula.Aula_Codigo
        id_aula.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_aula)

        Dim aula As New MySqlParameter("?v_aula", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        aula.Value = obj_aula.Aula_Nombre
        aula.Direction = ParameterDirection.Input
        comando.Parameters.Add(aula)

        Dim capacidad As New MySqlParameter("?v_capacidad", MySql.Data.MySqlClient.MySqlDbType.Float)
        capacidad.Value = obj_aula.Aula_Capacidad
        capacidad.Direction = ParameterDirection.Input
        comando.Parameters.Add(capacidad)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Aula(ByVal obj_aula As cls_n_aula)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_aula_borrar"

        Dim id_aula As New MySqlParameter("?v_id_aula", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_aula.Value = obj_aula.Aula_Codigo
        id_aula.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_aula)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_Aula() As List(Of cls_n_aula)
        Dim list_aulas As New List(Of cls_n_aula)
        Dim DataReader As MySqlDataReader
        Dim obj_aula As cls_n_aula
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_aula, aula, capacidad FROM aula ORDER BY id_aula ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_aula = New cls_n_aula
            obj_aula.Aula_Codigo = DataReader(0)
            obj_aula.Aula_Nombre = DataReader(1)
            obj_aula.Aula_Capacidad = DataReader(2)
            list_aulas.Add(obj_aula)
        End While
        conn.Close()
        Return list_aulas
    End Function

    Public Function List_Aula_y_Capacidad() As List(Of cls_n_aula)
        Dim list_aulas As New List(Of cls_n_aula)
        Dim DataReader As MySqlDataReader
        Dim obj_aula As cls_n_aula
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_aula, concat(aula, ' ', concat('(', capacidad, ')')) as aula FROM aula ORDER BY id_aula ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_aula = New cls_n_aula
            obj_aula.Aula_Codigo = DataReader(0)
            obj_aula.Aula_Nombre = DataReader(1)
            list_aulas.Add(obj_aula)
        End While
        conn.Close()
        Return list_aulas
    End Function

End Class



