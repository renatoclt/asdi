Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_view_trabajadores
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    Public Function Buscar_View_Trabajadores_Todos_Nombres(ByVal nombre As String) As List(Of cls_n_view_trabajadores)
        Dim list_trabajadores As New List(Of cls_n_view_trabajadores)
        Dim DataReader As MySqlDataReader
        Dim obj_view_trabajador As cls_n_view_trabajadores
        conn = objConexion.Open
        comando.Connection = conn
        comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT id_persona, id_trabajador_ficha, nombre, usuario, contrasenia, activo FROM view_trabajadores WHERE nombre like '%" + nombre + "%' ORDER BY nombre ASC"
        DataReader = comando.ExecuteReader
        While DataReader.Read
            obj_view_trabajador = New cls_n_view_trabajadores
            obj_view_trabajador.View_Trabajadores_Codigo_Persona = DataReader(0)
            obj_view_trabajador.View_Trabajadores_Codigo_Trabajador = DataReader(1)
            obj_view_trabajador.View_Trabajadores_Trabajador_Nombre = DataReader(2)
            obj_view_trabajador.View_Trabajadores_Usuario = DataReader(3)
            obj_view_trabajador.View_Trabajadores_Contrasenia = DataReader(4)
            obj_view_trabajador.View_Trabajadores_Activo = DataReader(5)
            list_trabajadores.Add(obj_view_trabajador)
        End While
        conn.Close()
        Return list_trabajadores
    End Function
End Class
