Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_persona
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion


    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Persona(ByRef obj_persona As cls_n_persona)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_persona_agregar"

        Dim nombres As New MySqlParameter("?v_nombres", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nombres.Value = obj_persona.Persona_Nombres
        nombres.Direction = ParameterDirection.Input
        comando.Parameters.Add(nombres)

        Dim apellido_paterno As New MySqlParameter("?v_apellido_paterno", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        apellido_paterno.Value = obj_persona.Persona_Apellido_Paterno
        apellido_paterno.Direction = ParameterDirection.Input
        comando.Parameters.Add(apellido_paterno)

        Dim apellido_materno As New MySqlParameter("?v_apellido_materno", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        apellido_materno.Value = obj_persona.Persona_Apellido_Materno
        apellido_materno.Direction = ParameterDirection.Input
        comando.Parameters.Add(apellido_materno)

        Dim fecha_nacimiento As New MySqlParameter("?v_fecha_nacimiento", MySql.Data.MySqlClient.MySqlDbType.Date)
        fecha_nacimiento.Value = obj_persona.Persona_Fecha_Nacimiento
        fecha_nacimiento.Direction = ParameterDirection.Input
        comando.Parameters.Add(fecha_nacimiento)

        Dim id_tp_documento As New MySqlParameter("?v_id_tp_documento", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_documento.Value = obj_persona.Persona_Id_Tp_Documento
        id_tp_documento.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_documento)

        Dim nro_documento As New MySqlParameter("?v_nro_documento", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nro_documento.Value = obj_persona.Persona_Nro_Documento
        nro_documento.Direction = ParameterDirection.Input
        comando.Parameters.Add(nro_documento)

        Dim usuario As New MySqlParameter("?v_usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        usuario.Value = obj_persona.Persona_Usuario
        usuario.Direction = ParameterDirection.Input
        comando.Parameters.Add(usuario)

        Dim contrasenia As New MySqlParameter("?v_contrasenia", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        contrasenia.Value = obj_persona.Persona_Contrasenia
        contrasenia.Direction = ParameterDirection.Input
        comando.Parameters.Add(contrasenia)

        Dim correo_institucional As New MySqlParameter("?v_correo_institucional", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        correo_institucional.Value = obj_persona.Persona_Correo_Institucional
        correo_institucional.Direction = ParameterDirection.Input
        comando.Parameters.Add(correo_institucional)

        Dim correo_personal As New MySqlParameter("?v_correo_personal", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        correo_personal.Value = obj_persona.Persona_Correo_Personal
        correo_personal.Direction = ParameterDirection.Input
        comando.Parameters.Add(correo_personal)

        Dim telefono_fijo As New MySqlParameter("?v_telefono_fijo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        telefono_fijo.Value = obj_persona.Persona_Telefono_Fijo
        telefono_fijo.Direction = ParameterDirection.Input
        comando.Parameters.Add(telefono_fijo)

        Dim telefono_celular As New MySqlParameter("?v_telefono_celular", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        telefono_celular.Value = obj_persona.Persona_Telefono_Celular
        telefono_celular.Direction = ParameterDirection.Input
        comando.Parameters.Add(telefono_celular)

        Dim direccion As New MySqlParameter("?v_direccion", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        direccion.Value = obj_persona.Persona_Direccion
        direccion.Direction = ParameterDirection.Input
        comando.Parameters.Add(direccion)

        Dim sexo As New MySqlParameter("?v_sexo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        sexo.Value = obj_persona.Persona_Sexo
        sexo.Direction = ParameterDirection.Input
        comando.Parameters.Add(sexo)

        Dim tipo As New MySqlParameter("?v_tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tipo.Value = obj_persona.Persona_Tipo
        tipo.Direction = ParameterDirection.Input
        comando.Parameters.Add(tipo)

        comando.ExecuteNonQuery()

        comando.CommandType = CommandType.Text
        comando.CommandText = "select last_insert_id()"
        obj_persona.Persona_Codigo = comando.ExecuteScalar()
        
        conn.Close()
    End Sub

    Public Sub Update_Persona(ByVal obj_persona As cls_n_persona)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_persona_actualizar"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_persona.Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        Dim nombres As New MySqlParameter("?v_nombres", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nombres.Value = obj_persona.Persona_Nombres
        nombres.Direction = ParameterDirection.Input
        comando.Parameters.Add(nombres)

        Dim apellido_paterno As New MySqlParameter("?v_apellido_paterno", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        apellido_paterno.Value = obj_persona.Persona_Apellido_Paterno
        apellido_paterno.Direction = ParameterDirection.Input
        comando.Parameters.Add(apellido_paterno)

        Dim apellido_materno As New MySqlParameter("?v_apellido_materno", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        apellido_materno.Value = obj_persona.Persona_Apellido_Materno
        apellido_materno.Direction = ParameterDirection.Input
        comando.Parameters.Add(apellido_materno)

        Dim fecha_nacimiento As New MySqlParameter("?v_fecha_nacimiento", MySql.Data.MySqlClient.MySqlDbType.Date)
        fecha_nacimiento.Value = obj_persona.Persona_Fecha_Nacimiento
        fecha_nacimiento.Direction = ParameterDirection.Input
        comando.Parameters.Add(fecha_nacimiento)

        Dim id_tp_documento As New MySqlParameter("?v_id_tp_documento", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_documento.Value = obj_persona.Persona_Id_Tp_Documento
        id_tp_documento.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_documento)

        Dim nro_documento As New MySqlParameter("?v_nro_documento", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nro_documento.Value = obj_persona.Persona_Nro_Documento
        nro_documento.Direction = ParameterDirection.Input
        comando.Parameters.Add(nro_documento)

        Dim usuario As New MySqlParameter("?v_usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        usuario.Value = obj_persona.Persona_Usuario
        usuario.Direction = ParameterDirection.Input
        comando.Parameters.Add(usuario)

        Dim contrasenia As New MySqlParameter("?v_contrasenia", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        contrasenia.Value = obj_persona.Persona_Contrasenia
        contrasenia.Direction = ParameterDirection.Input
        comando.Parameters.Add(contrasenia)

        Dim correo_institucional As New MySqlParameter("?v_correo_institucional", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        correo_institucional.Value = obj_persona.Persona_Correo_Institucional
        correo_institucional.Direction = ParameterDirection.Input
        comando.Parameters.Add(correo_institucional)

        Dim correo_personal As New MySqlParameter("?v_correo_personal", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        correo_personal.Value = obj_persona.Persona_Correo_Personal
        correo_personal.Direction = ParameterDirection.Input
        comando.Parameters.Add(correo_personal)

        Dim telefono_fijo As New MySqlParameter("?v_telefono_fijo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        telefono_fijo.Value = obj_persona.Persona_Telefono_Fijo
        telefono_fijo.Direction = ParameterDirection.Input
        comando.Parameters.Add(telefono_fijo)

        Dim telefono_celular As New MySqlParameter("?v_telefono_celular", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        telefono_celular.Value = obj_persona.Persona_Telefono_Celular
        telefono_celular.Direction = ParameterDirection.Input
        comando.Parameters.Add(telefono_celular)

        Dim direccion As New MySqlParameter("?v_direccion", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        direccion.Value = obj_persona.Persona_Direccion
        direccion.Direction = ParameterDirection.Input
        comando.Parameters.Add(direccion)

        Dim sexo As New MySqlParameter("?v_sexo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        sexo.Value = obj_persona.Persona_Sexo
        sexo.Direction = ParameterDirection.Input
        comando.Parameters.Add(sexo)

        Dim tipo As New MySqlParameter("?v_tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        tipo.Value = obj_persona.Persona_Tipo
        tipo.Direction = ParameterDirection.Input
        comando.Parameters.Add(tipo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Persona(ByVal obj_persona As cls_n_persona)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_persona_borrar"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_persona.Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function Get_Persona(ByVal id_persona As Integer) As cls_n_persona
        Dim DataReader As MySqlDataReader
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_persona, nombres, apellido_paterno, apellido_materno, fecha_nacimiento, id_tp_documento, nro_documento, usuario, contrasenia, correo_institucional, correo_personal, telefono_fijo, telefono_celular, direccion, sexo, tipo FROM persona where id_persona = " + id_persona.ToString
        DataReader = comando.ExecuteReader
        Dim obj_persona As New cls_n_persona
        While DataReader.Read
            obj_persona.Persona_Codigo = DataReader(0)
            obj_persona.Persona_Nombres = DataReader(1)
            obj_persona.Persona_Apellido_Paterno = DataReader(2)
            obj_persona.Persona_Apellido_Materno = DataReader(3)
            obj_persona.Persona_Fecha_Nacimiento = DataReader(4)
            obj_persona.Persona_Id_Tp_Documento = DataReader(5)
            obj_persona.Persona_Nro_Documento = DataReader(6)
            obj_persona.Persona_Usuario = DataReader(7)
            obj_persona.Persona_Contrasenia = DataReader(8)
            obj_persona.Persona_Correo_Institucional = DataReader(9)
            obj_persona.Persona_Correo_Personal = DataReader(10)
            obj_persona.Persona_Telefono_Fijo = DataReader(11)
            obj_persona.Persona_Telefono_Celular = DataReader(12)
            obj_persona.Persona_Direccion = DataReader(13)
            obj_persona.Persona_Sexo = DataReader(14)
            obj_persona.Persona_Tipo = DataReader(15)
        End While
        conn.Close()
        Return obj_persona
    End Function

    Public Function Login_Persona(ByVal obj_persona As cls_n_persona) As Integer
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_login"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_persona.Persona_Codigo
        id_persona.Direction = ParameterDirection.Output
        comando.Parameters.Add(id_persona)

        Dim usuario As New MySqlParameter("?v_usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        usuario.Value = obj_persona.Persona_Usuario
        usuario.Direction = ParameterDirection.Input
        comando.Parameters.Add(usuario)

        Dim contrasenia As New MySqlParameter("?v_contrasenia", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        contrasenia.Value = obj_persona.Persona_Contrasenia
        contrasenia.Direction = ParameterDirection.Input
        comando.Parameters.Add(contrasenia)

        comando.ExecuteNonQuery()
        conn.Close()

        Return id_persona.Value
    End Function



End Class
