Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_view_curso_grupos
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Sub Add_Curso_Grupo(ByVal obj_view_curso_grupos As cls_n_view_curso_grupos)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_curso_grupo_agregar"
        comando.Parameters.Clear()

        Dim id_aula As New MySqlParameter("?v_id_aula", MySql.Data.MySqlClient.MySqlDbType.Int16)
        If (obj_view_curso_grupos.View_Curso_Grupo_Aula_Codigo = -1) Then
            id_aula.Value = DBNull.Value
        Else
            id_aula.Value = obj_view_curso_grupos.View_Curso_Grupo_Aula_Codigo
        End If
        id_aula.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_aula)

        Dim id_profesor_ficha As New MySqlParameter("?v_id_profesor_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        If (obj_view_curso_grupos.View_Curso_Grupo_Profesor_Codigo = -1) Then
            id_aula.Value = DBNull.Value
        Else
            id_profesor_ficha.Value = obj_view_curso_grupos.View_Curso_Grupo_Profesor_Codigo
        End If
        id_profesor_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_profesor_ficha)

        Dim nombre_grupo As New MySqlParameter("?v_nombre_grupo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nombre_grupo.Value = obj_view_curso_grupos.View_Curso_Grupo_Nombre
        nombre_grupo.Direction = ParameterDirection.Input
        comando.Parameters.Add(nombre_grupo)

        Dim id_curso_ofertado As New MySqlParameter("?v_id_curso_ofertado", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_curso_ofertado.Value = obj_view_curso_grupos.View_Curso_Grupo_Curso_Ofertado_Codigo
        id_curso_ofertado.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_curso_ofertado)

        Dim id_horario As New MySqlParameter("?v_id_horario", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_horario.Value = obj_view_curso_grupos.View_Curso_Grupo_Horario_Codigo
        id_horario.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_horario)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Update_Curso_Grupo(ByVal obj_view_curso_grupos As cls_n_view_curso_grupos)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_curso_grupo_actualizar"
        comando.Parameters.Clear()

        Dim id_curso_grupo As New MySqlParameter("?v_id_curso_grupo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_curso_grupo.Value = obj_view_curso_grupos.View_Curso_Grupo_Codigo
        id_curso_grupo.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_curso_grupo)

        Dim id_aula As New MySqlParameter("?v_id_aula", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_aula.Value = obj_view_curso_grupos.View_Curso_Grupo_Aula_Codigo
        id_aula.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_aula)

        Dim id_profesor_ficha As New MySqlParameter("?v_id_profesor_ficha", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_profesor_ficha.Value = obj_view_curso_grupos.View_Curso_Grupo_Profesor_Codigo
        id_profesor_ficha.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_profesor_ficha)

        Dim nombre_grupo As New MySqlParameter("?v_nombre_grupo", MySql.Data.MySqlClient.MySqlDbType.VarChar)
        nombre_grupo.Value = obj_view_curso_grupos.View_Curso_Grupo_Nombre
        nombre_grupo.Direction = ParameterDirection.Input
        comando.Parameters.Add(nombre_grupo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub Delete_Curso_Grupo(ByVal obj_view_curso_grupos As cls_n_view_curso_grupos)
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "prc_curso_grupo_borrar"
        comando.Parameters.Clear()

        Dim id_curso_grupo As New MySqlParameter("?v_id_curso_grupo", MySql.Data.MySqlClient.MySqlDbType.Int16)
        id_curso_grupo.Value = obj_view_curso_grupos.View_Curso_Grupo_Codigo
        id_curso_grupo.Direction = ParameterDirection.Input
        comando.Parameters.Add(id_curso_grupo)

        comando.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function List_View_Cursos_Grupos(ByVal id_curso_ofertado As Integer, ByVal id_horario As Integer) As List(Of cls_n_view_curso_grupos)
        Dim lista_view_curso_grupo As New List(Of cls_n_view_curso_grupos)
        Dim DataReader As MySqlDataReader
        Dim obj_view_curso_grupo As cls_n_view_curso_grupos
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_curso_grupo, id_profesor_ficha, profesor, id_curso_ofertado, curso_ofertado, id_horario, horario, id_aula, aula, nombre_grupo, matriculados FROM view_curso_grupos WHERE id_curso_ofertado = " + id_curso_ofertado.ToString + " and id_horario = " + id_horario.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_curso_grupo = New cls_n_view_curso_grupos
            obj_view_curso_grupo.View_Curso_Grupo_Codigo = DataReader(0)
            obj_view_curso_grupo.View_Curso_Grupo_Profesor_Codigo = DataReader(1)
            obj_view_curso_grupo.View_Curso_Grupo_Profesor = DataReader(2)
            obj_view_curso_grupo.View_Curso_Grupo_Curso_Ofertado_Codigo = DataReader(3)
            obj_view_curso_grupo.View_Curso_Grupo_Curso_Ofertado = DataReader(4)
            obj_view_curso_grupo.View_Curso_Grupo_Horario_Codigo = DataReader(5)
            obj_view_curso_grupo.View_Curso_Grupo_Horario = DataReader(6)
            obj_view_curso_grupo.View_Curso_Grupo_Aula_Codigo = DataReader(7)
            obj_view_curso_grupo.View_Curso_Grupo_Aula = DataReader(8)
            obj_view_curso_grupo.View_Curso_Grupo_Nombre = DataReader(9)
            obj_view_curso_grupo.View_Curso_Grupo_Matriculados = DataReader(10)
            lista_view_curso_grupo.Add(obj_view_curso_grupo)
        End While
        conn.Close()
        Return lista_view_curso_grupo
    End Function

    Public Function List_View_Cursos_Grupos_Matricula(ByVal id_plan_est As Integer, ByVal id_periodo As Integer, ByVal ciclo As Integer) As List(Of cls_n_view_curso_grupos)
        Dim lista_view_curso_grupo As New List(Of cls_n_view_curso_grupos)
        Dim DataReader As MySqlDataReader
        Dim obj_view_curso_grupo As cls_n_view_curso_grupos
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select id_curso_grupo, grupo from view_matricula_grupos where orden = " + ciclo.ToString + " and id_plan_est = " + id_plan_est.ToString + " and id_periodo = " + id_periodo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_curso_grupo = New cls_n_view_curso_grupos
            obj_view_curso_grupo.View_Curso_Grupo_Codigo = DataReader(0)
            obj_view_curso_grupo.View_Curso_Grupo_Nombre = DataReader(1)
            lista_view_curso_grupo.Add(obj_view_curso_grupo)
        End While
        conn.Close()
        Return lista_view_curso_grupo
    End Function

    Public Function List_Curso_Grupo_Por_Periodo_Curso_Y_Horario(ByVal id_periodo As Integer, ByVal id_curso As Integer, ByVal id_horario As Integer) As List(Of cls_n_view_curso_grupos)
        Dim lista_view_curso_grupo As New List(Of cls_n_view_curso_grupos)
        Dim DataReader As MySqlDataReader
        Dim obj_view_curso_grupo As cls_n_view_curso_grupos
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select cg.id_curso_grupo, cg.nombre_grupo from curso_grupo cg, curso_ofertado co where cg.id_curso_ofertado = co.id_curso_ofertado and co.id_periodo = " + id_periodo.ToString + " and co.id_curso = " + id_curso.ToString + " and cg.id_horario = " + id_horario.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_curso_grupo = New cls_n_view_curso_grupos
            obj_view_curso_grupo.View_Curso_Grupo_Codigo = DataReader(0)
            obj_view_curso_grupo.View_Curso_Grupo_Nombre = DataReader(1)
            lista_view_curso_grupo.Add(obj_view_curso_grupo)
        End While
        conn.Close()
        Return lista_view_curso_grupo
    End Function

    Public Function List_Curso_Grupo_Por_Periodo_Curso_Horario_Y_Grupo(ByVal id_periodo As Integer, ByVal id_curso As Integer, ByVal id_horario As Integer, ByVal id_curso_grupo As Integer) As List(Of cls_n_view_curso_grupos)
        Dim lista_view_curso_grupo As New List(Of cls_n_view_curso_grupos)
        Dim DataReader As MySqlDataReader
        Dim obj_view_curso_grupo As cls_n_view_curso_grupos
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select cg.id_curso_grupo, cg.nombre_grupo from curso_grupo cg, curso_ofertado co where cg.id_curso_ofertado = co.id_curso_ofertado and co.id_periodo = " + id_periodo.ToString + " and co.id_curso = " + id_curso.ToString + " and cg.id_horario = " + id_horario.ToString + " and cg.id_curso_grupo <> " + id_curso_grupo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_curso_grupo = New cls_n_view_curso_grupos
            obj_view_curso_grupo.View_Curso_Grupo_Codigo = DataReader(0)
            obj_view_curso_grupo.View_Curso_Grupo_Nombre = DataReader(1)
            lista_view_curso_grupo.Add(obj_view_curso_grupo)
        End While
        conn.Close()
        Return lista_view_curso_grupo
    End Function

End Class





