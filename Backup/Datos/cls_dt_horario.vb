Imports MySql.Data.MySqlClient
Imports Conecion
Imports Negocio
Imports System.Configuration

Public Class cls_dt_horario
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Horario(ByVal obj_horario As cls_n_horario)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_horario_agregar"

        Dim horario As New MySqlParameter("?v_horario", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        horario.Value = obj_horario.Horario_Nombre
        horario.Direction = ParameterDirection.Input
        comando.Parameters.Add(horario)

        Dim costo As New MySqlParameter("?v_costo", MySql.Data.MySqlClient.MySqlDbType.Decimal)
        costo.Value = obj_horario.Horario_Costo
        costo.Direction = ParameterDirection.Input
        comando.Parameters.Add(costo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Horario(ByVal obj_horario As cls_n_horario)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_horario_actualizar"

        Dim id_horario As New MySqlParameter("?v_id_horario", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_horario.Value = obj_horario.Horario_Codigo
        id_horario.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_horario)

        Dim horario As New MySqlParameter("?v_horario", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        horario.Value = obj_horario.Horario_Nombre
        horario.Direction = ParameterDirection.Input
        comando.Parameters.Add(horario)

        Dim costo As New MySqlParameter("?v_costo", MySql.Data.MySqlClient.MySqlDbType.Decimal)
        costo.Value = obj_horario.Horario_Costo
        costo.Direction = ParameterDirection.Input
        comando.Parameters.Add(costo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Horario(ByVal obj_horario As cls_n_horario)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_horario_borrar"

        Dim id_horario As New MySqlParameter("?v_id_horario", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_horario.Value = obj_horario.Horario_Codigo
        id_horario.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_horario)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_Horario() As List(Of cls_n_horario)
        Dim list_horarios As New List(Of cls_n_horario)
        Dim DataReader As MySqlDataReader
        Dim obj_horario As cls_n_horario
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_horario, horario, costo FROM horario ORDER BY id_horario ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_horario = New cls_n_horario
            obj_horario.Horario_Codigo = DataReader(0)
            obj_horario.Horario_Nombre = DataReader(1)
            obj_horario.Horario_Costo = DataReader(2)
            list_horarios.Add(obj_horario)
        End While
        conn.Close()
        Return list_horarios
    End Function

    Public Function List_Horario_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_horario)
        Dim list_horarios As New List(Of cls_n_horario)
        Dim DataReader As MySqlDataReader
        Dim obj_horario As cls_n_horario
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select distinct h.id_horario, h.horario, h.costo from curso_ofertado co, curso_grupo cg,horario h where co.id_curso_ofertado = cg.id_curso_ofertado and cg.id_horario = h.id_horario and co.id_periodo = " + id_periodo.ToString + " order by id_horario"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_horario = New cls_n_horario
            obj_horario.Horario_Codigo = DataReader(0)
            obj_horario.Horario_Nombre = DataReader(1)
            obj_horario.Horario_Costo = DataReader(2)
            list_horarios.Add(obj_horario)
        End While
        conn.Close()
        Return list_horarios
    End Function

    

End Class
