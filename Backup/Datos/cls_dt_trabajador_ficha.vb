Imports MySql.Data.MySqlClient
Imports Negocio
Imports Conecion
Imports System.Configuration

Public Class cls_dt_trabajador_ficha
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Trabajador(ByVal obj_trabajador As cls_n_trabajador_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_trabajador_agregar"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_trabajador.Trabajador_Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        Dim activo As New MySqlParameter("?v_activo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        activo.Value = obj_trabajador.Trabajador_Activo
        activo.Direction = ParameterDirection.Input
        comando.Parameters.Add(activo)

        Dim tramite As New MySqlParameter("?v_tramite", MySql.Data.MySqlClient.MySqlDbType.Int16)
        tramite.Value = obj_trabajador.Trabajador_Tramite
        tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(tramite)

        Dim caja As New MySqlParameter("?v_caja", MySql.Data.MySqlClient.MySqlDbType.Int16)
        caja.Value = obj_trabajador.Trabajador_Caja
        caja.Direction = ParameterDirection.Input
        comando.Parameters.Add(caja)

        Dim notas As New MySqlParameter("?v_notas", MySql.Data.MySqlClient.MySqlDbType.Int16)
        notas.Value = obj_trabajador.Trabajador_Notas
        notas.Direction = ParameterDirection.Input
        comando.Parameters.Add(notas)

        Dim matriculas As New MySqlParameter("?v_matriculas", MySql.Data.MySqlClient.MySqlDbType.Int16)
        matriculas.Value = obj_trabajador.Trabajador_Matriculas
        matriculas.Direction = ParameterDirection.Input
        comando.Parameters.Add(matriculas)

        Dim administrador As New MySqlParameter("?v_administrador", MySql.Data.MySqlClient.MySqlDbType.Int16)
        administrador.Value = obj_trabajador.Trabajador_Administrador
        administrador.Direction = ParameterDirection.Input
        comando.Parameters.Add(administrador)

        Dim super As New MySqlParameter("?v_super", MySql.Data.MySqlClient.MySqlDbType.Int16)
        super.Value = obj_trabajador.Trabajador_Super
        super.Direction = ParameterDirection.Input
        comando.Parameters.Add(super)

        Dim boletas As New MySqlParameter("?v_boletas", MySql.Data.MySqlClient.MySqlDbType.Int16)
        boletas.Value = obj_trabajador.Trabajador_Boletas
        boletas.Direction = ParameterDirection.Input
        comando.Parameters.Add(boletas)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Trabajador(ByVal obj_trabajador As cls_n_trabajador_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_trabajador_actualizar"

        Dim id_trabajador_ficha As New MySqlParameter("?v_id_trabajador_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_trabajador_ficha.Value = obj_trabajador.Trabajador_Codigo
        id_trabajador_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_trabajador_ficha)

        Dim activo As New MySqlParameter("?v_activo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        activo.Value = obj_trabajador.Trabajador_Activo
        activo.Direction = ParameterDirection.Input
        comando.Parameters.Add(activo)

        Dim tramite As New MySqlParameter("?v_tramite", MySql.Data.MySqlClient.MySqlDbType.Int16)
        tramite.Value = obj_trabajador.Trabajador_Tramite
        tramite.Direction = ParameterDirection.Input
        comando.Parameters.Add(tramite)

        Dim caja As New MySqlParameter("?v_caja", MySql.Data.MySqlClient.MySqlDbType.Int16)
        caja.Value = obj_trabajador.Trabajador_Caja
        caja.Direction = ParameterDirection.Input
        comando.Parameters.Add(caja)

        Dim notas As New MySqlParameter("?v_notas", MySql.Data.MySqlClient.MySqlDbType.Int16)
        notas.Value = obj_trabajador.Trabajador_Notas
        notas.Direction = ParameterDirection.Input
        comando.Parameters.Add(notas)

        Dim matriculas As New MySqlParameter("?v_matriculas", MySql.Data.MySqlClient.MySqlDbType.Int16)
        matriculas.Value = obj_trabajador.Trabajador_Matriculas
        matriculas.Direction = ParameterDirection.Input
        comando.Parameters.Add(matriculas)

        Dim administrador As New MySqlParameter("?v_administrador", MySql.Data.MySqlClient.MySqlDbType.Int16)
        administrador.Value = obj_trabajador.Trabajador_Administrador
        administrador.Direction = ParameterDirection.Input
        comando.Parameters.Add(administrador)

        Dim super As New MySqlParameter("?v_super", MySql.Data.MySqlClient.MySqlDbType.Int16)
        super.Value = obj_trabajador.Trabajador_Super
        super.Direction = ParameterDirection.Input
        comando.Parameters.Add(super)

        Dim boletas As New MySqlParameter("?v_boletas", MySql.Data.MySqlClient.MySqlDbType.Int16)
        boletas.Value = obj_trabajador.Trabajador_Boletas
        boletas.Direction = ParameterDirection.Input
        comando.Parameters.Add(boletas)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Trabajador(ByVal obj_trabajador As cls_n_trabajador_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_trabajador_borrar"

        Dim id_trabajador_ficha As New MySqlParameter("?v_id_trabajador_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_trabajador_ficha.Value = obj_trabajador.Trabajador_Codigo
        id_trabajador_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_trabajador_ficha)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_Trabajador() As List(Of cls_n_trabajador_ficha)
        Dim list_trabajadores As New List(Of cls_n_trabajador_ficha)
        Dim DataReader As MySqlDataReader
        Dim obj_trabajador As cls_n_trabajador_ficha
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_trabajador_ficha, id_persona, activo, tramite, caja, notas, matriculas, administrador, super, boletas  FROM trabajador_ficha ORDER BY id_trabajador_ficha ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_trabajador = New cls_n_trabajador_ficha
            obj_trabajador.Trabajador_Codigo = DataReader(0)
            obj_trabajador.Trabajador_Persona_Codigo = DataReader(1)
            obj_trabajador.Trabajador_Activo = DataReader(2)
            obj_trabajador.Trabajador_Tramite = DataReader(3)
            obj_trabajador.Trabajador_Caja = DataReader(4)
            obj_trabajador.Trabajador_Notas = DataReader(5)
            obj_trabajador.Trabajador_Matriculas = DataReader(6)
            obj_trabajador.Trabajador_Administrador = DataReader(7)
            obj_trabajador.Trabajador_Super = DataReader(8)
            obj_trabajador.Trabajador_Boletas = DataReader(9)
            list_trabajadores.Add(obj_trabajador)
        End While
        conn.Close()
        Return list_trabajadores
    End Function

    Public Function Get_Trabajador(ByVal id_persona As Integer) As cls_n_trabajador_ficha
        Dim DataReader As MySqlDataReader
        Dim obj_trabajador As New cls_n_trabajador_ficha
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_trabajador_ficha, id_persona, activo, tramite, caja, notas, matriculas, administrador, super, boletas FROM trabajador_ficha WHERE id_persona = " + id_persona.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_trabajador.Trabajador_Codigo = DataReader(0)
            obj_trabajador.Trabajador_Persona_Codigo = DataReader(1)
            obj_trabajador.Trabajador_Activo = DataReader(2)
            obj_trabajador.Trabajador_Tramite = DataReader(3)
            obj_trabajador.Trabajador_Caja = DataReader(4)
            obj_trabajador.Trabajador_Notas = DataReader(5)
            obj_trabajador.Trabajador_Matriculas = DataReader(6)
            obj_trabajador.Trabajador_Administrador = DataReader(7)
            obj_trabajador.Trabajador_Super = DataReader(8)
            obj_trabajador.Trabajador_Boletas = DataReader(9)
        End While
        conn.Close()
        Return obj_trabajador
    End Function

End Class
