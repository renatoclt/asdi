Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_periodo
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Periodo(ByVal obj_periodo As cls_n_periodo)
        Try
            conn = objConexion.Open
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "prc_periodo_agregar"

            Dim periodo As New MySqlParameter("?v_periodo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            periodo.Value = obj_periodo.Periodo_Nombre
            periodo.Direction = ParameterDirection.Input
            comando.Parameters.Add(periodo)

            Dim estado As New MySqlParameter("?v_estado", MySql.Data.MySqlClient.MySqlDbType.Int16)
            estado.Value = obj_periodo.Periodo_Estado_Boolean
            estado.Direction = ParameterDirection.Input
            comando.Parameters.Add(estado)

            Dim regular As New MySqlParameter("?v_regular", MySql.Data.MySqlClient.MySqlDbType.Int16)
            regular.Value = obj_periodo.Periodo_Regular_Boolean
            regular.Direction = ParameterDirection.Input
            comando.Parameters.Add(regular)

            Dim fecha_inicio As New MySqlParameter("?v_fecha_inicio", MySql.Data.MySqlClient.MySqlDbType.Date)
            fecha_inicio.Value = obj_periodo.Periodo_Fecha_Inicio
            fecha_inicio.Direction = ParameterDirection.Input
            comando.Parameters.Add(fecha_inicio)

            Dim fecha_fin As New MySqlParameter("?v_fecha_fin", MySql.Data.MySqlClient.MySqlDbType.Date)
            fecha_fin.Value = obj_periodo.Periodo_Fecha_Fin
            fecha_fin.Direction = ParameterDirection.Input
            comando.Parameters.Add(fecha_fin)

            comando.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Update_Periodo(ByVal obj_periodo As cls_n_periodo)
        Try
            conn = objConexion.Open
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "prc_periodo_actualizar"

            Dim id_periodo As New MySqlParameter("?v_id_periodo", MySql.Data.MySqlClient.MySqlDbType.Int16)
            id_periodo.Value = obj_periodo.Periodo_Codigo
            id_periodo.Direction = ParameterDirection.Input
            comando.Parameters.Add(id_periodo)

            Dim periodo As New MySqlParameter("?v_periodo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            periodo.Value = obj_periodo.Periodo_Nombre
            periodo.Direction = ParameterDirection.Input
            comando.Parameters.Add(periodo)

            Dim estado As New MySqlParameter("?v_estado", MySql.Data.MySqlClient.MySqlDbType.Int16)
            estado.Value = obj_periodo.Periodo_Estado_Boolean
            estado.Direction = ParameterDirection.Input
            comando.Parameters.Add(estado)

            Dim regular As New MySqlParameter("?v_regular", MySql.Data.MySqlClient.MySqlDbType.Int16)
            regular.Value = obj_periodo.Periodo_Regular_Boolean
            regular.Direction = ParameterDirection.Input
            comando.Parameters.Add(regular)

            Dim fecha_inicio As New MySqlParameter("?v_fecha_inicio", MySql.Data.MySqlClient.MySqlDbType.Date)
            fecha_inicio.Value = obj_periodo.Periodo_Fecha_Inicio
            fecha_inicio.Direction = ParameterDirection.Input
            comando.Parameters.Add(fecha_inicio)

            Dim fecha_fin As New MySqlParameter("?v_fecha_fin", MySql.Data.MySqlClient.MySqlDbType.Date)
            fecha_fin.Value = obj_periodo.Periodo_Fecha_Fin
            fecha_fin.Direction = ParameterDirection.Input
            comando.Parameters.Add(fecha_fin)

            comando.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Delete_Periodo(ByVal obj_periodo As cls_n_periodo)
        Try
            conn = objConexion.Open
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "prc_periodo_borrar"

            Dim periodo As New MySqlParameter("?v_id_periodo", MySql.Data.MySqlClient.MySqlDbType.Int16)
            periodo.Value = obj_periodo.Periodo_Codigo
            periodo.Direction = ParameterDirection.Input
            comando.Parameters.Add(periodo)

            comando.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Actual_Periodo(ByVal obj_periodo As cls_n_periodo) As Integer
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_periodo_actual"

        Dim periodo As New MySqlParameter("?v_id_periodo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        periodo.Value = obj_periodo.Periodo_Codigo
        periodo.Direction = ParameterDirection.Output
        comando.Parameters.Add(periodo)

        comando.ExecuteNonQuery()
        conn.Close()

        Return periodo.Value
    End Function

    Public Function List_Periodo() As List(Of cls_n_periodo)
        Dim list_tp_documento As New List(Of cls_n_periodo)
        Dim DataReader As MySqlDataReader
        Dim obj_periodo As cls_n_periodo
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_periodo, periodo, (case estado when 1 then 'Abierto' when 0 then 'Cerrado' end) as estado, (case regular when 1 then 'Si' when 0 then 'No' end) as regular, fecha_inicio, fecha_fin FROM periodo ORDER BY id_periodo ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_periodo = New cls_n_periodo
            obj_periodo.Periodo_Codigo = DataReader(0)
            obj_periodo.Periodo_Nombre = DataReader(1)
            obj_periodo.Periodo_Estado = DataReader(2)
            obj_periodo.Periodo_Regular = DataReader(3)
            obj_periodo.Periodo_Fecha_Inicio = DataReader(4)
            obj_periodo.Periodo_Fecha_Fin = DataReader(5)
            list_tp_documento.Add(obj_periodo)
        End While
        conn.Close()
        Return list_tp_documento
    End Function
    Public Function List_PeriodoCB() As List(Of cls_n_periodo)
        Dim list_tp_documento As New List(Of cls_n_periodo)
        Dim DataReader As MySqlDataReader
        Dim obj_periodo As cls_n_periodo
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_periodo as id_periodo, periodo as periodo FROM periodo  where estado = 1"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_periodo = New cls_n_periodo
            obj_periodo.Periodo_Codigo = DataReader(0)
            obj_periodo.Periodo_Nombre = DataReader(1)
            list_tp_documento.Add(obj_periodo)
        End While
        conn.Close()
        Return list_tp_documento
    End Function

    Public Function List_Periodo_Abierto() As List(Of cls_n_periodo)
        Dim list_tp_documento As New List(Of cls_n_periodo)
        Dim DataReader As MySqlDataReader
        Dim obj_periodo As cls_n_periodo
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_periodo, periodo, (case estado when 1 then 'Abierto' when 0 then 'Cerrado' end) as estado, (case regular when 1 then 'Si' when 0 then 'No' end) as regular, fecha_inicio, fecha_fin FROM periodo  WHERE estado = true "
        'comando.CommandText = "SELECT id_periodo, periodo, (case estado when 1 then 'Abierto' when 0 then 'Cerrado' end) as estado, (case regular when 1 then 'Si' when 0 then 'No' end) as regular, fecha_inicio, fecha_fin FROM periodo  WHERE estado = true ORDER BY periodo DESC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_periodo = New cls_n_periodo
            obj_periodo.Periodo_Codigo = DataReader(0)
            obj_periodo.Periodo_Nombre = DataReader(1)
            obj_periodo.Periodo_Estado = DataReader(2)
            obj_periodo.Periodo_Regular = DataReader(3)
            obj_periodo.Periodo_Fecha_Inicio = DataReader(4)
            obj_periodo.Periodo_Fecha_Fin = DataReader(5)
            list_tp_documento.Add(obj_periodo)
        End While
        conn.Close()
        Return list_tp_documento
    End Function

    Public Function List_Periodo_Cerrado() As List(Of cls_n_periodo)
        Dim list_tp_documento As New List(Of cls_n_periodo)
        Dim DataReader As MySqlDataReader
        Dim obj_periodo As cls_n_periodo
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_periodo, periodo, (case estado when 1 then 'Abierto' when 0 then 'Cerrado' end) as estado, (case regular when 1 then 'Si' when 0 then 'No' end) as regular, fecha_inicio, fecha_fin FROM periodo  WHERE estado = false ORDER BY periodo DESC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_periodo = New cls_n_periodo
            obj_periodo.Periodo_Codigo = DataReader(0)
            obj_periodo.Periodo_Nombre = DataReader(1)
            obj_periodo.Periodo_Estado = DataReader(2)
            obj_periodo.Periodo_Regular = DataReader(3)
            obj_periodo.Periodo_Fecha_Inicio = DataReader(4)
            obj_periodo.Periodo_Fecha_Fin = DataReader(5)
            list_tp_documento.Add(obj_periodo)
        End While
        conn.Close()
        Return list_tp_documento
    End Function

    Public Function Get_Periodo(ByVal obj_periodo As cls_n_periodo) As cls_n_periodo
        Dim DataReader As MySqlDataReader
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_periodo, periodo, (case estado when 1 then 'Abierto' when 0 then 'Cerrado' end) as estado, (case regular when 1 then 'Si' when 0 then 'No' end) as regular, fecha_inicio, fecha_fin FROM periodo  WHERE id_periodo = " + obj_periodo.Periodo_Codigo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_periodo.Periodo_Codigo = DataReader(0)
            obj_periodo.Periodo_Nombre = DataReader(1)
            obj_periodo.Periodo_Estado = DataReader(2)
            obj_periodo.Periodo_Regular = DataReader(3)
            obj_periodo.Periodo_Fecha_Inicio = DataReader(4)
            obj_periodo.Periodo_Fecha_Fin = DataReader(5)
        End While
        conn.Close()
        Return obj_periodo
    End Function



End Class
