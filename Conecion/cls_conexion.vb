Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class cls_conexion
    Public Port As String
    Public Server As String
    Public Database As String
    Public User As String
    Public Password As String

    Public Sub New()
        Dim reg As New cls_registro
        Try
            Port = "3306"
            Server = "192.168.1.112"
            Database = "asdi" 'reg.leer("database")
            User = "root"
            Password = "YES"

            'Port = "3306"
            'Server = "192.168.1.112"
            'Database = "asdi" 'reg.leer("database")
            'User = "asdi"
            'Password = "YES"


            'Port = "3306"
            'Server = "localhost"
            'Database = "asdi" 'reg.Leer("Database")
            'User = "root"
            'Password = ""
        Catch ex As Exception
            MsgBox("No se puede leer los parametros de coneccion")
        End Try

    End Sub

    Public Function Open() As MySqlConnection
        Dim StringConnection As String
        Dim conn As MySqlConnection
        StringConnection = "Server=" + Server + ";Port=" + Port + ";Database=" + Database + ";Uid=" + User + ";Pwd=" + Password + ";Pooling=True;"
        'StringConnection = "Database=asdi ;Data Source=localhost;User Id=root;Password=YES"
        conn = New MySqlConnection(StringConnection)
        conn.Open()
        Return conn
    End Function

End Class
