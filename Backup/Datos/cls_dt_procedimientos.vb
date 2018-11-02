Imports MySql.Data.MySqlClient
Imports Negocio
Imports System.Configuration
Imports Conecion

Public Class cls_dt_procedimientos
    Private conn As New MySqlConnection
    Private comando As New MySqlCommand
    Private objConexion As New cls_conexion

    Public Sub New()
        'conn = objConexion.Open
        'comando.Connection = conn
    End Sub

    'Public Function ExecuteProcedure(ByVal Procedure As String) As MySqlDataReader
    '    Dim DataReader As MySqlDataReader 
    '    conn = objConexion.Open
    '    comando.Connection = conn
    '    Try
    '        comando.CommandText = Procedure
    '        comando.CommandType = CommandType.StoredProcedure
    '        DataReader = comando.ExecuteReader()
    '        Return DataReader
    '    Catch ex As Exception
    '        Debug.Print(ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Function ExecuteProcedure(ByVal Procedure As String, ByVal ParamArray parameters() As String) As MySqlDataReader
    '    Dim DataReader As MySqlDataReader 
    '    Dim CommandBuilder As New MySqlCommandBuilder
    '    Dim Indice As Integer
    '    conn = objConexion.Open
    '    comando.Connection = conn
    '    Try
    '        comando.CommandText = Procedure
    '        comando.CommandType = CommandType.StoredProcedure
    '        'para los parametros
    '        CommandBuilder.DeriveParameters(comando)
    '        For Indice = 0 To parameters.Length - 1
    '            CType(comando.Parameters(Indice), MySqlParameter).Value = parameters(Indice)
    '        Next
    '        DataReader = comando.ExecuteReader
    '        Return DataReader
    '    Catch ex As Exception
    '        Debug.Print(ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function

End Class
