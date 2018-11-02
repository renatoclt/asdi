Imports MySql.Data.MySqlClient
Public Class Cls_Horario
    Dim obj As New Conexion
    'registrar horario
    Public Sub Llenar_plan_estudio(ByVal a As ComboBox)
        Dim sql As String = "SELECT id_plan_est, plan_estudio FROM plan_estudio"
        Dim c As String = "id_plan_est"
        Dim d As String = "plan_estudio"
        obj.LlenarCombobox(a, sql, c, d)
    End Sub
    'apertura grupos
    Public Sub Llenar_horario(ByVal a As ComboBox, ByVal b As String)
        Dim sql As String = "SELECT id_horario, horario FROM horario where id_plan_est ='" & b & "'"
        Dim c As String = "id_horario"
        Dim d As String = "horario"
        obj.LlenarCombobox(a, sql, c, d)
    End Sub
End Class
