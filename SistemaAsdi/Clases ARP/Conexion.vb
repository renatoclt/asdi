Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports Conecion

Public Class Conexion
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public conexion As New cls_conexion
    Public Sub conectar()
        Try
            con.ConnectionString = "Database= " + conexion.Database + " ;Data Source=" + conexion.Server + ";User Id=" + conexion.User + ";Password=" + conexion.Password
            'ASDI
            'con.ConnectionString = "Database=asdi ;Data Source=192.168.1.43;User Id=asdi;Password=YES"
            'CODICE
            'con.ConnectionString = "server=192.168.1.41;Port=3306;User Id=prueba1;database=codice;pwd=YES"
            'con.ConnectionString = "server=192.168.1.38;Port=3306;User Id=codiceBD;database=codice;pwd=YES"
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub desconectar()
        Try
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function consulta_login(ByVal a As TextBox, ByVal b As TextBox)
        Dim rpta As String = "Select count(*)from usuario where id_usuario='" & a.Text & "' and contraseña='" & b.Text & "'"
        Return rpta
    End Function

    Public Function consulta(ByVal sql As String)
        conectar()
        cmd.Connection = con
        cmd.CommandText = sql
        Dim rpta As String = cmd.ExecuteScalar()
        desconectar()
        Return rpta
    End Function
    Public Function consulta1(ByVal sql As String)
        cmd.Connection = con
        cmd.CommandText = sql
        Dim Dr As MySqlDataReader = cmd.ExecuteReader
        Return Dr
    End Function

    Public Function GenerarCodigo(ByVal sql As String, ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String)
        Dim rpta As Integer = consulta(sql) + 1
        Dim r As String = ""
        If rpta <= 0 Then
            r = "000001"
        ElseIf rpta < 10 Then
            r = a & rpta
        ElseIf rpta >= 10 And rpta < 100 Then
            r = b & rpta
        ElseIf rpta >= 100 And rpta < 1000 Then
            r = c & rpta
        ElseIf rpta >= 1000 And rpta < 10000 Then
            r = d & rpta
        ElseIf rpta >= 10000 And rpta < 100000 Then
            r = e & rpta
        End If
        Return r
    End Function
    Public Function GenerarCodigo1(ByVal sql As String, ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String)
        Dim rpta As Integer = consulta(sql) + 1
        Dim r As String = ""
        If rpta < 10 Then
            r = a & rpta
        ElseIf rpta >= 10 And rpta < 100 Then
            r = b & rpta
        ElseIf rpta >= 100 And rpta < 1000 Then
            r = c & rpta
        ElseIf rpta >= 1000 And rpta < 10000 Then
            r = d & rpta
        End If
        Return r
    End Function

    Public Sub LlenarCombobox(ByVal a As ComboBox, ByVal sql As String, ByVal b As String, ByVal c As String)
        Try
            conectar()
            Dim da As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds)
            a.DataSource = ds.Tables(0)
            a.ValueMember = b
            a.DisplayMember = c
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LlenarCombobox1(ByVal a As ComboBox, ByVal sql As String, ByVal b As String, ByVal c As String)
        Try
            Dim da As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds)
            a.DataSource = ds.Tables(0)
            a.ValueMember = b
            a.DisplayMember = c
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub VerRegistro(ByVal a As DataGridView, ByVal sql As String)
        'conectar()
        Try
            Dim da As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds)
            a.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'desconectar()
        End Try
    End Sub
    Public Sub VerRegistro1(ByVal a As DataGridView, ByVal sql As String)
        conectar()
        Try
            Dim da As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds)
            a.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Sub

    Public Function Autocompletar(ByVal sql As String, ByVal n As String)
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row(n)))
        Next
        Return coleccion
    End Function

End Class
