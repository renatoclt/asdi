Imports System.Data
Imports Mysql.Data
Imports MySql.Data.MySqlClient

Module Conection
    Public StringConnection As String = "Server=localhost; user id=asdi; password=asdi; database=asdi;"
    Public Connection As MySqlConnection
    Public Command As MySqlCommand
    Public CommandBuilder As MySqlCommandBuilder
    Public DataReader As MySqlDataReader

    Public Sub MysqlConnect()
        Try
            Connection = New MySqlConnection
            Connection.ConnectionString = StringConnection
            Connection.Open()
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub

    Public Sub MysqlDisconnect()
        Try
            Connection.Close()
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub

    Public Function ExecuteProcedure(ByVal Procedure As String) As MySqlDataReader
        Try
            Command = New MySqlCommand
            Command.CommandText = Procedure
            Command.CommandType = CommandType.StoredProcedure
            Command.Connection = Connection
            DataReader = Command.ExecuteReader()
            Return DataReader
        Catch ex As Exception
            Debug.Print(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function ExecuteProcedure(ByVal Procedure As String, ByVal ParamArray parameters() As String) As MySqlDataReader
        Dim Indice As Integer
        Try
            Command = New MySqlCommand
            Command.CommandText = Procedure
            Command.CommandType = CommandType.StoredProcedure
            Command.Connection = Connection
            'para los parametros
            'CommandBuilder.DeriveParameters(Command)
            For Indice = 0 To parameters.Length - 1
                CType(Command.Parameters(Indice), MySqlParameter).Value = parameters(Indice)
            Next
            DataReader = Command.ExecuteReader
            Return DataReader
        Catch ex As Exception
            Debug.Print(ex.ToString)
            Return Nothing
        End Try
    End Function


End Module
