Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_profesor_ficha
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Profesor(ByVal obj_profesor As cls_n_profesor_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_profesor_agregar"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_profesor.Profesor_Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        Dim estado As New MySqlParameter("?v_estado", MySql.Data.MySqlClient.MySqlDbType.Int16)
        estado.Value = obj_profesor.Profesor_Estado
        estado.Direction = ParameterDirection.Input
        comando.Parameters.Add(estado)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Profesor(ByVal obj_profesor As cls_n_profesor_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_profesor_actualizar"

        Dim id_profesor_ficha As New MySqlParameter("?v_id_profesor_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_profesor_ficha.Value = obj_profesor.Profesor_Codigo
        id_profesor_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_profesor_ficha)

        Dim estado As New MySqlParameter("?v_estado", MySql.Data.MySqlClient.MySqlDbType.Int16)
        estado.Value = obj_profesor.Profesor_Estado
        estado.Direction = ParameterDirection.Input
        comando.Parameters.Add(estado)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Profesor(ByVal obj_profesor As cls_n_profesor_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_profesor_borrar"

        Dim id_profesor_ficha As New MySqlParameter("?v_id_profesor_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_profesor_ficha.Value = obj_profesor.Profesor_Codigo
        id_profesor_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_profesor_ficha)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function Get_Profesor(ByVal id_persona As Integer) As cls_n_profesor_ficha
        Dim DataReader As MySqlDataReader
        Dim obj_profesor As New cls_n_profesor_ficha
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_profesor_ficha, id_persona, estado FROM profesor_ficha WHERE id_persona = " + id_persona.ToString + " ORDER BY id_profesor_ficha ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_profesor.Profesor_Codigo = DataReader(0)
            obj_profesor.Profesor_Persona_Codigo = DataReader(1)
            obj_profesor.Profesor_Estado = DataReader(2)
        End While
        conn.Close()
        Return obj_profesor
    End Function

    Public Function List_Profesor() As List(Of cls_n_profesor_ficha)
        Dim list_profesores As New List(Of cls_n_profesor_ficha)
        Dim DataReader As MySqlDataReader
        Dim obj_profesor As cls_n_profesor_ficha
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_profesor_ficha, id_persona, estado FROM profesor_ficha ORDER BY id_profesor_ficha ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_profesor = New cls_n_profesor_ficha
            obj_profesor.Profesor_Codigo = DataReader(0)
            obj_profesor.Profesor_Persona_Codigo = DataReader(1)
            obj_profesor.Profesor_Estado = DataReader(2)
            list_profesores.Add(obj_profesor)
        End While
        conn.Close()
        Return list_profesores
    End Function

End Class
