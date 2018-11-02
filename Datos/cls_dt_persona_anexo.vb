Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_persona_anexo
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Persona_Anexo(ByVal obj_persona_anexo As cls_n_persona_anexo)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_persona_anexo_agregar"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_persona_anexo.Persona_Anexo_Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        Dim lugar_nacimiento As New MySqlParameter("?v_lugar_nacimiento", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        lugar_nacimiento.Value = obj_persona_anexo.Persona_Anexo_Lugar_Nacimiento
        lugar_nacimiento.Direction = ParameterDirection.Input
        comando.Parameters.Add(lugar_nacimiento)

        Dim nombre_padre As New MySqlParameter("?v_nombre_padre", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nombre_padre.Value = obj_persona_anexo.Persona_Anexo_Nombre_Padre
        nombre_padre.Direction = ParameterDirection.Input
        comando.Parameters.Add(nombre_padre)

        Dim nombre_madre As New MySqlParameter("?v_nombre_madre", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nombre_madre.Value = obj_persona_anexo.Persona_Anexo_Nombre_Madre
        nombre_madre.Direction = ParameterDirection.Input
        comando.Parameters.Add(nombre_madre)

        Dim contacto_emergencia As New MySqlParameter("?v_contacto_emergencia", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        contacto_emergencia.Value = obj_persona_anexo.Persona_Anexo_Contacto_Emergencia
        contacto_emergencia.Direction = ParameterDirection.Input
        comando.Parameters.Add(contacto_emergencia)

        Dim telefono_emergencia As New MySqlParameter("?v_telefono_emergencia", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        telefono_emergencia.Value = obj_persona_anexo.Persona_Anexo_Telefono_Emergencia
        telefono_emergencia.Direction = ParameterDirection.Input
        comando.Parameters.Add(telefono_emergencia)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Persona_Anexo(ByVal obj_persona_anexo As cls_n_persona_anexo)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_persona_anexo_actualizar"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_persona_anexo.Persona_Anexo_Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        Dim lugar_nacimiento As New MySqlParameter("?v_lugar_nacimiento", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        lugar_nacimiento.Value = obj_persona_anexo.Persona_Anexo_Lugar_Nacimiento
        lugar_nacimiento.Direction = ParameterDirection.Input
        comando.Parameters.Add(lugar_nacimiento)

        Dim nombre_padre As New MySqlParameter("?v_nombre_padre", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nombre_padre.Value = obj_persona_anexo.Persona_Anexo_Nombre_Padre
        nombre_padre.Direction = ParameterDirection.Input
        comando.Parameters.Add(nombre_padre)

        Dim nombre_madre As New MySqlParameter("?v_nombre_madre", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nombre_madre.Value = obj_persona_anexo.Persona_Anexo_Nombre_Madre
        nombre_madre.Direction = ParameterDirection.Input
        comando.Parameters.Add(nombre_madre)

        Dim contacto_emergencia As New MySqlParameter("?v_contacto_emergencia", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        contacto_emergencia.Value = obj_persona_anexo.Persona_Anexo_Contacto_Emergencia
        contacto_emergencia.Direction = ParameterDirection.Input
        comando.Parameters.Add(contacto_emergencia)

        Dim telefono_emergencia As New MySqlParameter("?v_telefono_emergencia", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        telefono_emergencia.Value = obj_persona_anexo.Persona_Anexo_Telefono_Emergencia
        telefono_emergencia.Direction = ParameterDirection.Input
        comando.Parameters.Add(telefono_emergencia)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Persona_Anexo(ByVal obj_persona_anexo As cls_n_persona_anexo)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_persona_anexo_borrar"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_persona_anexo.Persona_Anexo_Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function Get_Persona_Anexo(ByVal id_persona As Integer) As cls_n_persona_anexo
        Dim DataReader As MySqlDataReader
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_persona, lugar_nacimiento, nombre_padre, nombre_madre, contacto_emergencia, telefono_emergencia, foto FROM persona_anexo where id_persona = " + id_persona.ToString
        DataReader = comando.ExecuteReader
        Dim obj_persona_anexo As New cls_n_persona_anexo
        While DataReader.Read
            obj_persona_anexo.Persona_Anexo_Persona_Codigo = DataReader(0)
            obj_persona_anexo.Persona_Anexo_Lugar_Nacimiento = DataReader(1)
            obj_persona_anexo.Persona_Anexo_Nombre_Padre = DataReader(2)
            obj_persona_anexo.Persona_Anexo_Nombre_Madre = DataReader(3)
            obj_persona_anexo.Persona_Anexo_Contacto_Emergencia = DataReader(4)
            obj_persona_anexo.Persona_Anexo_Telefono_Emergencia = DataReader(5)
        End While
        conn.Close()
        Return obj_persona_anexo
    End Function

    Public Function List_Persona_Anexo() As List(Of cls_n_persona_anexo)
        Dim list_personas_anexo As New List(Of cls_n_persona_anexo)
        Return list_personas_anexo
    End Function


End Class
