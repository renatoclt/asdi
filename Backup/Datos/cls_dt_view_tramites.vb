Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_view_tramites
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Function Buscar_View_Tramites() As List(Of cls_n_view_tramites)
        Dim list_tramites As New List(Of cls_n_view_tramites)
        Dim DataReader As MySqlDataReader
        Dim obj_view_tramite As cls_n_view_tramites
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_tramite, nombre, tramite, fecha_creacion, entregado, fecha_entregado FROM view_tramites ORDER BY id_tramite ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_tramite = New cls_n_view_tramites
            obj_view_tramite.View_Tramite_Codigo_Tramite = DataReader(0)
            obj_view_tramite.View_Tramite_Nombre_Alumno = DataReader(1)
            obj_view_tramite.View_Tramite_Tramite_Nombre = DataReader(2)
            obj_view_tramite.View_Tramite_Fecha_Creacion = DataReader(3)
            obj_view_tramite.View_Tramite_Entregado = DataReader(4)
            obj_view_tramite.View_Tramite_Fecha_Entregado = DataReader(5)
            list_tramites.Add(obj_view_tramite)
        End While
        conn.Close()
        Return list_tramites
    End Function

    Public Function Buscar_View_Tramites(ByVal tramite As String, ByVal nombre As String) As List(Of cls_n_view_tramites)
        Dim list_tramites As New List(Of cls_n_view_tramites)
        Dim DataReader As MySqlDataReader
        Dim obj_view_tramite As cls_n_view_tramites
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_tramite, nombre, tramite, fecha_creacion, entregado, fecha_entregado FROM view_tramites WHERE tramite like '%" + tramite + "%' AND nombre like '%" + nombre + "%' ORDER BY id_tramite ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_tramite = New cls_n_view_tramites
            obj_view_tramite.View_Tramite_Codigo_Tramite = DataReader(0)
            obj_view_tramite.View_Tramite_Nombre_Alumno = DataReader(1)
            obj_view_tramite.View_Tramite_Tramite_Nombre = DataReader(2)
            obj_view_tramite.View_Tramite_Fecha_Creacion = DataReader(3)
            obj_view_tramite.View_Tramite_Entregado = DataReader(4)
            obj_view_tramite.View_Tramite_Fecha_Entregado = DataReader(5)
            list_tramites.Add(obj_view_tramite)
        End While
        conn.Close()
        Return list_tramites
    End Function

    Public Function Buscar_View_Tramites(ByVal nombre As String) As List(Of cls_n_view_tramites)
        Dim list_tramites As New List(Of cls_n_view_tramites)
        Dim DataReader As MySqlDataReader
        Dim obj_view_tramite As cls_n_view_tramites
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_tramite, nombre, tramite, fecha_creacion, entregado, fecha_entregado FROM view_tramites WHERE nombre like '%" + nombre + "%' ORDER BY id_tramite ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_tramite = New cls_n_view_tramites
            obj_view_tramite.View_Tramite_Codigo_Tramite = DataReader(0)
            obj_view_tramite.View_Tramite_Nombre_Alumno = DataReader(1)
            obj_view_tramite.View_Tramite_Tramite_Nombre = DataReader(2)
            obj_view_tramite.View_Tramite_Fecha_Creacion = DataReader(3)
            obj_view_tramite.View_Tramite_Entregado = DataReader(4)
            obj_view_tramite.View_Tramite_Fecha_Entregado = DataReader(5)
            list_tramites.Add(obj_view_tramite)
        End While
        conn.Close()
        Return list_tramites
    End Function

    Public Function Buscar_View_Tramites_No(ByVal nombre As String) As List(Of cls_n_view_tramites)
        Dim list_tramites As New List(Of cls_n_view_tramites)
        Dim DataReader As MySqlDataReader
        Dim obj_view_tramite As cls_n_view_tramites
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_tramite, nombre, tramite, fecha_creacion, entregado, fecha_entregado FROM view_tramites WHERE nombre like '%" + nombre + "%' and entregado = 'No' ORDER BY id_tramite ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_tramite = New cls_n_view_tramites
            obj_view_tramite.View_Tramite_Codigo_Tramite = DataReader(0)
            obj_view_tramite.View_Tramite_Nombre_Alumno = DataReader(1)
            obj_view_tramite.View_Tramite_Tramite_Nombre = DataReader(2)
            obj_view_tramite.View_Tramite_Fecha_Creacion = DataReader(3)
            obj_view_tramite.View_Tramite_Entregado = DataReader(4)
            obj_view_tramite.View_Tramite_Fecha_Entregado = DataReader(5)
            list_tramites.Add(obj_view_tramite)
        End While
        conn.Close()
        Return list_tramites
    End Function

End Class
