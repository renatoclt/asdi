Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_view_profesores
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Function Buscar_View_Profesores_Activos_Nombres(ByVal nombre As String) As List(Of cls_n_view_profesores)
        Dim list_profesores As New List(Of cls_n_view_profesores)
        Dim DataReader As MySqlDataReader
        Dim obj_view_profesor As cls_n_view_profesores
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_persona, id_profesor_ficha, nombre, estado FROM view_profesores WHERE nombre like '%" + nombre + "%' AND estado = true ORDER BY nombre ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_profesor = New cls_n_view_profesores
            obj_view_profesor.View_Profesores_Codigo_Persona = DataReader(0)
            obj_view_profesor.View_Profesores_Codigo_Profesor = DataReader(1)
            obj_view_profesor.View_Profesores_Profesor_Nombre = DataReader(2)
            obj_view_profesor.View_Profesores_Estado = DataReader(3)
            list_profesores.Add(obj_view_profesor)
        End While
        conn.Close()
        Return list_profesores
    End Function

    Public Function List_View_Profesores_Activos() As List(Of cls_n_view_profesores)
        Dim list_profesores As New List(Of cls_n_view_profesores)
        Dim DataReader As MySqlDataReader
        Dim obj_view_profesor As cls_n_view_profesores
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_persona, id_profesor_ficha, nombre, estado FROM view_profesores WHERE estado = true ORDER BY nombre ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_profesor = New cls_n_view_profesores
            obj_view_profesor.View_Profesores_Codigo_Persona = DataReader(0)
            obj_view_profesor.View_Profesores_Codigo_Profesor = DataReader(1)
            obj_view_profesor.View_Profesores_Profesor_Nombre = DataReader(2)
            obj_view_profesor.View_Profesores_Estado = DataReader(3)
            list_profesores.Add(obj_view_profesor)
        End While
        conn.Close()
        Return list_profesores
    End Function

    Public Function Buscar_View_Profesores_Todos_Nombres(ByVal nombre As String) As List(Of cls_n_view_profesores)
        Dim list_profesores As New List(Of cls_n_view_profesores)
        Dim DataReader As MySqlDataReader
        Dim obj_view_profesor As cls_n_view_profesores
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_persona, id_profesor_ficha, nombre, estado FROM view_profesores WHERE nombre like '%" + nombre + "%' ORDER BY nombre ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_profesor = New cls_n_view_profesores
            obj_view_profesor.View_Profesores_Codigo_Persona = DataReader(0)
            obj_view_profesor.View_Profesores_Codigo_Profesor = DataReader(1)
            obj_view_profesor.View_Profesores_Profesor_Nombre = DataReader(2)
            obj_view_profesor.View_Profesores_Estado = DataReader(3)
            list_profesores.Add(obj_view_profesor)
        End While
        conn.Close()
        Return list_profesores
    End Function

    Public Function List_View_Profesores_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_view_profesores)
        Dim list_profesores As New List(Of cls_n_view_profesores)
        Dim DataReader As MySqlDataReader
        Dim obj_view_profesor As cls_n_view_profesores
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select vp.id_persona, vp.id_profesor_ficha, vp.nombre, vp.estado from curso_ofertado co, curso_grupo cg, view_profesores vp where co.id_curso_ofertado = cg.id_curso_ofertado and cg.id_profesor_ficha = vp.id_profesor_ficha and co.id_periodo = " + id_periodo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_profesor = New cls_n_view_profesores
            obj_view_profesor.View_Profesores_Codigo_Persona = DataReader(0)
            obj_view_profesor.View_Profesores_Codigo_Profesor = DataReader(1)
            obj_view_profesor.View_Profesores_Profesor_Nombre = DataReader(2)
            obj_view_profesor.View_Profesores_Estado = DataReader(3)
            list_profesores.Add(obj_view_profesor)
        End While
        conn.Close()
        Return list_profesores
    End Function

    Public Function List_Profesores_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_profesor_reporte)
        Dim list_profesores As New List(Of cls_n_profesor_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_view_profesor As cls_n_profesor_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_profesor_ficha, nombre, estado, curso, grupo, horario, aula, periodo FROM view_profesor_curso where id_periodo =" + id_periodo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_profesor = New cls_n_profesor_reporte
            obj_view_profesor.Reporte_Profesor_Codigo = DataReader(0)
            obj_view_profesor.Reporte_Profesor_Nombre = DataReader(1)
            obj_view_profesor.Reporte_Profesor_Estado  = DataReader(2)
            obj_view_profesor.Reporte_Profesor_Curso = DataReader(3)
            obj_view_profesor.Reporte_Profesor_Grupo = DataReader(4)
            obj_view_profesor.Reporte_Profesor_Horario = DataReader(5)
            obj_view_profesor.Reporte_Profesor_Aula = DataReader(6)
            obj_view_profesor.Reporte_Profesor_Periodo = DataReader(7)
            list_profesores.Add(obj_view_profesor)
        End While
        conn.Close()
        Return list_profesores
    End Function

    Public Function List_Profesores_Por_Periodo_Y_Curso(ByVal id_periodo As Integer, ByVal id_curso As Integer) As List(Of cls_n_profesor_reporte)
        Dim list_profesores As New List(Of cls_n_profesor_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_view_profesor As cls_n_profesor_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_profesor_ficha, nombre, estado, curso, grupo, horario, aula, periodo FROM view_profesor_curso where id_periodo =" + id_periodo.ToString + " and id_curso =" + id_curso.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_profesor = New cls_n_profesor_reporte
            obj_view_profesor.Reporte_Profesor_Codigo = DataReader(0)
            obj_view_profesor.Reporte_Profesor_Nombre = DataReader(1)
            obj_view_profesor.Reporte_Profesor_Estado = DataReader(2)
            obj_view_profesor.Reporte_Profesor_Curso = DataReader(3)
            obj_view_profesor.Reporte_Profesor_Grupo = DataReader(4)
            obj_view_profesor.Reporte_Profesor_Horario = DataReader(5)
            obj_view_profesor.Reporte_Profesor_Aula = DataReader(6)
            obj_view_profesor.Reporte_Profesor_Periodo = DataReader(7)
            list_profesores.Add(obj_view_profesor)
        End While
        conn.Close()
        Return list_profesores
    End Function

    Public Function List_Profesores_Por_Periodo_Y_Horario(ByVal id_periodo As Integer, ByVal id_horario As Integer) As List(Of cls_n_profesor_reporte)
        Dim list_profesores As New List(Of cls_n_profesor_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_view_profesor As cls_n_profesor_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_profesor_ficha, nombre, estado, curso, grupo, horario, aula, periodo FROM view_profesor_curso where id_periodo =" + id_periodo.ToString + " and id_horario =" + id_horario.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_profesor = New cls_n_profesor_reporte
            obj_view_profesor.Reporte_Profesor_Codigo = DataReader(0)
            obj_view_profesor.Reporte_Profesor_Nombre = DataReader(1)
            obj_view_profesor.Reporte_Profesor_Estado = DataReader(2)
            obj_view_profesor.Reporte_Profesor_Curso = DataReader(3)
            obj_view_profesor.Reporte_Profesor_Grupo = DataReader(4)
            obj_view_profesor.Reporte_Profesor_Horario = DataReader(5)
            obj_view_profesor.Reporte_Profesor_Aula = DataReader(6)
            obj_view_profesor.Reporte_Profesor_Periodo = DataReader(7)
            list_profesores.Add(obj_view_profesor)
        End While
        conn.Close()
        Return list_profesores
    End Function
End Class


