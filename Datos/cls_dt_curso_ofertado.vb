Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_curso_ofertado
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Update_Curso_Ofertado(ByVal id_curso As Integer, ByVal id_periodo As Integer, ByVal ofertado As Boolean)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_cursos_ofertados_agregar_borrar"

        Dim v_id_curso As New MySqlParameter("?v_id_curso", MySql.Data.MySqlClient.MySqlDbType.Int16)
        v_id_curso.Value = id_curso
        v_id_curso.Direction = ParameterDirection.Input
        comando.Parameters.Add(v_id_curso)

        Dim v_id_periodo As New MySqlParameter("?v_id_periodo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        v_id_periodo.Value = id_periodo
        v_id_periodo.Direction = ParameterDirection.Input
        comando.Parameters.Add(v_id_periodo)

        Dim v_ofertado As New MySqlParameter("?v_ofertado", MySql.Data.MySqlClient.MySqlDbType.Int16)
        v_ofertado.Value = ofertado
        v_ofertado.Direction = ParameterDirection.Input
        comando.Parameters.Add(v_ofertado)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_Curso_Ofertado(ByVal id_periodo As Integer, ByVal id_plan_estudio As Integer) As List(Of cls_n_curso_ofertado)
        Dim list_cursos As New List(Of cls_n_curso_ofertado)
        Dim DataReader As MySqlDataReader
        Dim obj_curso_ofertado As cls_n_curso_ofertado
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select c.id_curso, concat(c.curso,' ',concat('(',c.abreviatura,')')) AS curso, if (fnc_curso_ofertado(c.id_curso," + id_periodo.ToString + ") <> 0, true, false) as ofertado from curso_plan_est cp, curso c where cp.id_curso = c.id_curso and cp.id_plan_est = " + id_plan_estudio.ToString + " order by cp.id_plan_est, cp.orden, curso"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_curso_ofertado = New cls_n_curso_ofertado
            obj_curso_ofertado.Curso_Ofertado_Curso_Codigo = DataReader(0)
            obj_curso_ofertado.Curso_Ofertado_Curso_Nombre = DataReader(1)
            obj_curso_ofertado.Curso_Ofertado_Ofertado = DataReader(2)
            list_cursos.Add(obj_curso_ofertado)
        End While
        conn.Close()
        Return list_cursos
    End Function

    Public Function List_View_Curso_Ofertado(ByVal id_periodo As Integer, ByVal id_plan_estudio As Integer) As List(Of cls_n_curso_ofertado)
        Dim list_cursos As New List(Of cls_n_curso_ofertado)
        Dim DataReader As MySqlDataReader
        Dim obj_curso_ofertado As cls_n_curso_ofertado
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_curso_ofertado, id_curso, curso, true FROM view_curso_ofertados WHERE id_plan_est = " + id_plan_estudio.ToString + " And id_periodo = " + id_periodo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_curso_ofertado = New cls_n_curso_ofertado
            obj_curso_ofertado.Curso_Ofertado_Codigo = DataReader(0)
            obj_curso_ofertado.Curso_Ofertado_Curso_Codigo = DataReader(1)
            obj_curso_ofertado.Curso_Ofertado_Curso_Nombre = DataReader(2)
            obj_curso_ofertado.Curso_Ofertado_Ofertado = DataReader(3)
            list_cursos.Add(obj_curso_ofertado)
        End While
        conn.Close()
        Return list_cursos
    End Function

End Class