Imports MySql.Data.MySqlClient
Public Class Cls_Separata
    Dim obj As New Conexion
    Public Sub Llenar_curso(ByVal a As ComboBox)
        Dim sql As String = "Select id_curso, curso From curso"
        Dim b As String = "id_curso"
        Dim c As String = "curso"
        obj.LlenarCombobox(a, sql, b, c)
    End Sub
    Public Sub Autocomplementar_Curso(ByVal a As ComboBox)
        Dim sql As String = "SELECT * FROM curso"
        Dim n As String = "curso"
        obj.conectar()
        a.AutoCompleteCustomSource = obj.Autocompletar(sql, n)
        a.AutoCompleteMode = AutoCompleteMode.Suggest
        a.AutoCompleteSource = AutoCompleteSource.CustomSource
        obj.desconectar()
    End Sub
End Class
