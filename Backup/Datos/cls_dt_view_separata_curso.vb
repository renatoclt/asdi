Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_view_separata_curso
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Separata_Curso(ByVal obj_view_separata_curso As cls_n_view_separata_curso)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_separata_agregar"
        comando.Parameters.Clear()

        Dim id_curso As New MySqlParameter("?v_id_curso", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_curso.Value = obj_view_separata_curso.View_Separata_Curso_Curso_Codigo
        id_curso.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_curso)

        Dim separata As New MySqlParameter("?v_separata", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        separata.Value = obj_view_separata_curso.View_Separata_Curso_Separata_Nombre
        separata.Direction = ParameterDirection.Input
        comando.Parameters.Add(separata)

        Dim costo As New MySqlParameter("?v_costo", MySql.Data.MySqlClient.MySqlDbType.Decimal)
        costo.Value = obj_view_separata_curso.View_Separata_Curso_Separata_Costo
        costo.Direction = ParameterDirection.Input
        comando.Parameters.Add(costo)

        Dim activo As New MySqlParameter("?v_activo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        activo.Value = obj_view_separata_curso.View_Separata_Curso_Separata_Activo
        activo.Direction = ParameterDirection.Input
        comando.Parameters.Add(activo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Separata_Curso(ByVal obj_view_separata_curso As cls_n_view_separata_curso)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_separata_actualizar"
        comando.Parameters.Clear()

        Dim id_separata As New MySqlParameter("?v_id_separata", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_separata.Value = obj_view_separata_curso.View_Separata_Curso_Separata_Codigo
        id_separata.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_separata)

        Dim separata As New MySqlParameter("?v_separata", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        separata.Value = obj_view_separata_curso.View_Separata_Curso_Separata_Nombre
        separata.Direction = ParameterDirection.Input
        comando.Parameters.Add(separata)

        Dim costo As New MySqlParameter("?v_costo", MySql.Data.MySqlClient.MySqlDbType.Decimal)
        costo.Value = obj_view_separata_curso.View_Separata_Curso_Separata_Costo
        costo.Direction = ParameterDirection.Input
        comando.Parameters.Add(costo)

        Dim activo As New MySqlParameter("?v_activo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        activo.Value = obj_view_separata_curso.View_Separata_Curso_Separata_Activo
        activo.Direction = ParameterDirection.Input
        comando.Parameters.Add(activo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Separata_Curso(ByVal obj_view_separata_curso As cls_n_view_separata_curso)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_separata_borrar"
        comando.Parameters.Clear()

        Dim id_separata As New MySqlParameter("?v_id_separata", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_separata.Value = obj_view_separata_curso.View_Separata_Curso_Separata_Codigo
        id_separata.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_separata)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_Separata_Curso() As List(Of cls_n_view_separata_curso)
        Dim list_separata As New List(Of cls_n_view_separata_curso)
        Dim DataReader As MySqlDataReader
        Dim obj_separata As cls_n_view_separata_curso
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_separata, id_curso, curso, separata, costo, activo FROM view_separata_curso ORDER BY id_separata ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_separata = New cls_n_view_separata_curso
            obj_separata.View_Separata_Curso_Separata_Codigo = DataReader(0)
            obj_separata.View_Separata_Curso_Curso_Codigo = DataReader(1)
            obj_separata.View_Separata_Curso_Curso_Nombre = DataReader(2)
            obj_separata.View_Separata_Curso_Separata_Nombre = DataReader(3)
            obj_separata.View_Separata_Curso_Separata_Costo = DataReader(4)
            obj_separata.View_Separata_Curso_Separata_Activo = DataReader(5)
            list_separata.Add(obj_separata)
        End While
        conn.Close()
        Return list_separata
    End Function

End Class
