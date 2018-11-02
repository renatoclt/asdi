Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class cls_conexion
    Private Port As String
    Private Server As String
    Private Database As String
    Private User As String
    Private Password As String

    Public Sub New()
        Dim reg As New cls_registro
        Try
            Port = reg.Leer("Port")
            Server = reg.Leer("Server")
            Database = "asdi" 'reg.Leer("Database")
            User = reg.Leer("User")
            Password = reg.Leer("Password")
        Catch ex As Exception
            MsgBox("No se puede leer los parametros de coneccion")
        End Try

    End Sub

    Public Function Open() As MySqlConnection
        Dim StringConnection As String
        Dim conn As MySqlConnection
        StringConnection = "Server=" + Server + ";Port=" + Port + ";Database=" + Database + ";Uid=" + User + ";Pwd=" + Password + ";Pooling=True;"
        conn = New MySqlConnection(StringConnection)
        conn.Open()
        Return conn
    End Function

End Class
