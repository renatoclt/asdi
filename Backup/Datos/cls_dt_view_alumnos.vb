Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_view_alumnos
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Function Buscar_View_Alumnos_Nombres(ByVal nombre As String) As List(Of cls_n_view_alumnos)
        Dim list_alumnos As New List(Of cls_n_view_alumnos)
        Dim DataReader As MySqlDataReader
        Dim obj_view_alumno As cls_n_view_alumnos
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_persona, id_alumno_ficha, nombre, ciclo, periodo_inicio, estado FROM view_alumnos WHERE LOWER(nombre) like '%" + nombre + "%' ORDER BY nombre ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_alumno = New cls_n_view_alumnos
            obj_view_alumno.View_Alumno_Codigo_Persona = DataReader(0)
            obj_view_alumno.View_Alumno_Codigo_Alumno = DataReader(1)
            obj_view_alumno.View_Alumno_Nombre = DataReader(2)
            obj_view_alumno.View_Alumno_Ciclo = DataReader(3)
            obj_view_alumno.View_Alumno_Periodo_Inicio = DataReader(4)
            obj_view_alumno.View_Alumno_Estado = DataReader(5)
            list_alumnos.Add(obj_view_alumno)
        End While
        conn.Close()
        Return list_alumnos
    End Function

    Public Function Obtener_View_Alumnos(ByVal id_alumno_ficha As Integer) As cls_n_view_alumnos
        Dim DataReader As MySqlDataReader
        Dim obj_view_alumno As New cls_n_view_alumnos
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_persona, id_alumno_ficha, nombre, ciclo, periodo_inicio, estado FROM view_alumnos WHERE id_alumno_ficha = " + id_alumno_ficha.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_alumno.View_Alumno_Codigo_Persona = DataReader(0)
            obj_view_alumno.View_Alumno_Codigo_Alumno = DataReader(1)
            obj_view_alumno.View_Alumno_Nombre = DataReader(2)
            obj_view_alumno.View_Alumno_Ciclo = DataReader(3)
            obj_view_alumno.View_Alumno_Periodo_Inicio = DataReader(4)
            obj_view_alumno.View_Alumno_Estado = DataReader(5)
        End While
        conn.Close()
        Return obj_view_alumno
    End Function

    Public Function Lista_Alumnos_Por_Profesor(ByVal id_profesor_ficha As Integer) As List(Of cls_n_alumno_reporte)
        Dim list_alumnos As New List(Of cls_n_alumno_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_reporte_alumno As cls_n_alumno_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_alumno_ficha, nombre, nombre_grupo, horario FROM view_alumno_profesor WHERE id_profesor_ficha = " + id_profesor_ficha.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_reporte_alumno = New cls_n_alumno_reporte
            obj_reporte_alumno.Reporte_Alumno_Codigo = DataReader(0)
            obj_reporte_alumno.Reporte_Alumno_Nombre = DataReader(1)
            obj_reporte_alumno.Reporte_Grupo_Nombre = DataReader(2)
            obj_reporte_alumno.Reporte_Horario = DataReader(3)
            list_alumnos.Add(obj_reporte_alumno)
        End While
        conn.Close()
        Return list_alumnos
    End Function

    Public Function Lista_Alumnos_Por_Curso_Ofertado(ByVal id_curso_ofertado As Integer) As List(Of cls_n_alumno_reporte)
        Dim list_alumnos As New List(Of cls_n_alumno_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_reporte_alumno As cls_n_alumno_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_alumno_ficha, nombre, nombre_grupo, horario FROM view_alumno_curso WHERE id_curso_ofertado = " + id_curso_ofertado.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_reporte_alumno = New cls_n_alumno_reporte
            obj_reporte_alumno.Reporte_Alumno_Codigo = DataReader(0)
            obj_reporte_alumno.Reporte_Alumno_Nombre = DataReader(1)
            obj_reporte_alumno.Reporte_Grupo_Nombre = DataReader(2)
            obj_reporte_alumno.Reporte_Horario = DataReader(3)
            list_alumnos.Add(obj_reporte_alumno)
        End While
        conn.Close()
        Return list_alumnos
    End Function

    Public Function Lista_Alumnos_Por_Horario(ByVal id_horario As Integer) As List(Of cls_n_alumno_reporte)
        Dim list_alumnos As New List(Of cls_n_alumno_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_reporte_alumno As cls_n_alumno_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_alumno_ficha, nombre, nombre_grupo, curso FROM view_alumno_horario WHERE id_horario = " + id_horario.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_reporte_alumno = New cls_n_alumno_reporte
            obj_reporte_alumno.Reporte_Alumno_Codigo = DataReader(0)
            obj_reporte_alumno.Reporte_Alumno_Nombre = DataReader(1)
            obj_reporte_alumno.Reporte_Grupo_Nombre = DataReader(2)
            obj_reporte_alumno.Reporte_Horario = DataReader(3)
            list_alumnos.Add(obj_reporte_alumno)
        End While
        conn.Close()
        Return list_alumnos
    End Function

    Public Function Lista_Alumnos_Por_Periodo(ByVal id_periodo As Integer) As List(Of cls_n_alumno_reporte)
        Dim list_alumnos As New List(Of cls_n_alumno_reporte)
        Dim DataReader As MySqlDataReader
        Dim obj_reporte_alumno As cls_n_alumno_reporte
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_alumno_ficha, nombre, nombre_grupo, horario FROM view_alumno_periodo WHERE id_periodo = " + id_periodo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_reporte_alumno = New cls_n_alumno_reporte
            obj_reporte_alumno.Reporte_Alumno_Codigo = DataReader(0)
            obj_reporte_alumno.Reporte_Alumno_Nombre = DataReader(1)
            obj_reporte_alumno.Reporte_Grupo_Nombre = DataReader(2)
            obj_reporte_alumno.Reporte_Horario = DataReader(3)
            list_alumnos.Add(obj_reporte_alumno)
        End While
        conn.Close()
        Return list_alumnos
    End Function

    Public Function List_View_Alumnos_Nombres_Curso_Grupo(ByVal id_curso_grupo As Integer) As List(Of cls_n_matricula)
        Dim list_alumnos As New List(Of cls_n_matricula)
        Dim DataReader As MySqlDataReader
        Dim obj_matricula As cls_n_matricula
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "select m.id_matricula, m.id_curso_grupo, va.nombre from matricula m, curso_grupo cg, view_alumnos va where m.id_curso_grupo = cg.id_curso_grupo and m.id_alumno_ficha = va.id_alumno_ficha and m.id_curso_grupo = " + id_curso_grupo.ToString
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_matricula = New cls_n_matricula
            obj_matricula.Matricula_Codigo = DataReader(0)
            obj_matricula.Matricula_Curso_Grupo_Codigo = DataReader(1)
            obj_matricula.Matricula_Alumno_Nombre = DataReader(2)
            list_alumnos.Add(obj_matricula)
        End While
        conn.Close()
        Return list_alumnos
    End Function

End Class