Imports MySql.Data.MySqlClient
Imports Negocio
Imports Conecion
Imports System.Configuration

Public Class cls_dt_alumno_ficha
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Alumno(ByVal obj_alumno As cls_n_alumno_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_alumno_agregar"

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_alumno.Alumno_Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        Dim id_plan_est As New MySqlParameter("?v_id_plan_est", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_plan_est.Value = obj_alumno.Alumno_Plan_Estudio
        id_plan_est.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_plan_est)

        Dim ciclo As New MySqlParameter("?v_ciclo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        ciclo.Value = obj_alumno.Alumno_Ciclo
        ciclo.Direction = ParameterDirection.Input
        comando.Parameters.Add(ciclo)

        Dim periodo_inicio As New MySqlParameter("?v_periodo_inicio", MySql.Data.MySqlClient.MySqlDbType.Int16)
        periodo_inicio.Value = obj_alumno.Alumno_Periodo_Inicio
        periodo_inicio.Direction = ParameterDirection.Input
        comando.Parameters.Add(periodo_inicio)

        Dim periodo_fin As New MySqlParameter("?v_periodo_fin", MySql.Data.MySqlClient.MySqlDbType.Int16)
        periodo_fin.Value = obj_alumno.Alumno_Periodo_Fin
        periodo_fin.Direction = ParameterDirection.Input
        comando.Parameters.Add(periodo_fin)

        Dim id_tp_est_alum As New MySqlParameter("?v_id_tp_est_alum", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_est_alum.Value = obj_alumno.Alumno_Tipo_Alumno
        id_tp_est_alum.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_est_alum)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Alumno(ByVal obj_alumno As cls_n_alumno_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_alumno_actualizar"


        Dim id_alumno_ficha As New MySqlParameter("?v_id_alumno_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_alumno_ficha.Value = obj_alumno.Alumno_Codigo
        id_alumno_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_alumno_ficha)

        Dim id_persona As New MySqlParameter("?v_id_persona", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_persona.Value = obj_alumno.Alumno_Persona_Codigo
        id_persona.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_persona)

        Dim id_plan_est As New MySqlParameter("?v_id_plan_est", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_plan_est.Value = obj_alumno.Alumno_Plan_Estudio
        id_plan_est.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_plan_est)

        Dim ciclo As New MySqlParameter("?v_ciclo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        ciclo.Value = obj_alumno.Alumno_Ciclo
        ciclo.Direction = ParameterDirection.Input
        comando.Parameters.Add(ciclo)

        Dim id_tp_est_alum As New MySqlParameter("?v_id_tp_est_alum", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_tp_est_alum.Value = obj_alumno.Alumno_Tipo_Alumno
        id_tp_est_alum.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_tp_est_alum)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Alumno(ByVal obj_alumno As cls_n_alumno_ficha)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_alumno_borrar"

        Dim id_alumno_ficha As New MySqlParameter("?v_id_alumno_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_alumno_ficha.Value = obj_alumno.Alumno_Codigo
        id_alumno_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_alumno_ficha)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function Get_Alumno(ByVal id_persona As Integer) As cls_n_alumno_ficha
        Dim DataReader As MySqlDataReader
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_alumno_ficha, id_persona, id_plan_est, ciclo, periodo_inicio, periodo_fin, id_tp_est_alum FROM alumno_ficha WHERE id_persona = " + id_persona.ToString
        DataReader = comando.ExecuteReader
        Dim obj_alumno As New cls_n_alumno_ficha
        While DataReader.Read
            obj_alumno.Alumno_Codigo = DataReader(0)
            obj_alumno.Alumno_Persona_Codigo = DataReader(1)
            obj_alumno.Alumno_Plan_Estudio = DataReader(2)
            obj_alumno.Alumno_Ciclo = DataReader(3)
            obj_alumno.Alumno_Periodo_Inicio = DataReader(4)
            obj_alumno.Alumno_Periodo_Fin = DataReader(5)
            obj_alumno.Alumno_Tipo_Alumno = DataReader(6)
        End While
        conn.Close()
        Return obj_alumno
    End Function

    Public Function List_Alumno() As List(Of cls_n_alumno_ficha)
        Dim list_alumnos As New List(Of cls_n_alumno_ficha)
        Dim DataReader As MySqlDataReader
        Dim obj_alumno As cls_n_alumno_ficha
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_alumno_ficha, id_persona, id_plan_est, ciclo, periodo_inicio, periodo_fin, id_tp_est_alum FROM alumno_ficha ORDER BY id_alumno_ficha ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_alumno = New cls_n_alumno_ficha
            obj_alumno.Alumno_Codigo = DataReader(0)
            obj_alumno.Alumno_Persona_Codigo = DataReader(1)
            obj_alumno.Alumno_Plan_Estudio = DataReader(2)
            obj_alumno.Alumno_Ciclo = DataReader(3)
            obj_alumno.Alumno_Periodo_Inicio = DataReader(4)
            obj_alumno.Alumno_Periodo_Fin = DataReader(5)
            obj_alumno.Alumno_Tipo_Alumno = DataReader(6)
            list_alumnos.Add(obj_alumno)
        End While
        conn.Close()
        Return list_alumnos
    End Function

End Class
