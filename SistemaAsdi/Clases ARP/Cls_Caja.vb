Imports MySql.Data.MySqlClient
Public Class Cls_Caja
    Dim obj As New Conexion
    Public Sub llenar_listview_detallado(ByVal b As ListView)
        With b
            b.Clear()
            .View = View.Details
            .Columns.Add("Nro", 50)
            .Columns.Add("Nombre Alumno", 155)
            .Columns.Add("Concepto", 85)
            .Columns.Add("Grupo", 45)

            '.Columns.Add("Aula", 35)
            '.Columns.Add("Fecha", 75)
            .Columns.Add("Hora", 60)
            .Columns.Add("Nro Boleta", 62)

            .Columns.Add("Monto", 72)
            .Columns.Add("Descuento", 70)
            .Columns.Add("Total", 72)
            .Columns.Add("Acumulado", 75)

        End With
    End Sub
    Public Sub llenar_listview_concepto(ByVal b As ListView)
        With b
            b.Clear()
            .View = View.Details
            .Columns.Add("Concepto", 170)
            .Columns.Add("Total", 90)
        End With
    End Sub
    Public Function mostrarDatosCaja(ByVal a As ListView, ByVal b As String, ByVal c As String, ByVal d As Label)
        'Dim sql As String = "SELECT b.id_boleta, b.nombre, r.concepto, c.nombre_grupo, u.aula, r.fecha_creacion, r.hora, b.nro_boleta, r.monto, r.descuento, r.total  FROM boleta b, recibo r, curso_grupo c, aula u where if (r.id_curso_grupo ='0', '1'= c.id_curso_grupo, r.id_curso_grupo =c.id_curso_grupo) and u.id_aula =c.id_aula and r.fecha_creacion BETWEEN '" & b & "' AND '" & c & "' and b.id_recibo =r.id_recibo group by b.nro_boleta"
        Dim sql As String = "SELECT b.id_boleta, b.nombre, r.concepto, c.nombre_grupo, r.hora, b.nro_boleta, r.monto, r.descuento, r.total  FROM boleta b, recibo r, curso_grupo c, aula u where if (r.id_curso_grupo ='0', '1'= c.id_curso_grupo, r.id_curso_grupo =c.id_curso_grupo) and u.id_aula =c.id_aula and r.fecha_creacion BETWEEN '" & b & "' AND '" & c & "' and b.id_recibo =r.id_recibo group by b.nro_boleta"
        Dim Dr As MySqlDataReader
        Dim con As Double
        Dim n As Integer
        Try
            a.Items.Clear()
            obj.conectar()
            Dr = obj.consulta1(sql)
            Dim item As New ListViewItem
            While Dr.Read()
                item = a.Items.Add(CStr(Dr("id_boleta")))
                item.SubItems.Add(CStr(Dr("nombre")))
                item.SubItems.Add(CStr(Dr("concepto")))
                item.SubItems.Add(CStr(Dr("nombre_grupo")))
                'item.SubItems.Add(CStr(Dr("aula")))
                'item.SubItems.Add(CStr(Dr("fecha_creacion")))
                item.SubItems.Add(CStr(Dr("hora")))
                item.SubItems.Add(CStr(Dr("nro_boleta")))
                item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(CStr(Dr("monto")))))
                item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(CStr(Dr("descuento")))))
                item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(CStr(Dr("total")))))
                con = String.Format("{0:C}", Convert.ToDouble(CStr(Dr("total")) + con))
                item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(con)))
                d.Text = String.Format("{0:C}", Convert.ToDouble(con))
                n = n + 1
                correlativo_final = CStr(Dr("id_boleta"))
                correlativo_inicial = correlativo_final - (n - 1)
            End While
            obj.desconectar()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            'cmd = Nothing
            Dr = Nothing
        End Try
        Return a
    End Function
    Public Function mostrarDatosCaja_Concepto(ByVal a As ListView, ByVal b As String, ByVal c As String, ByVal d As Label)
        Dim sql As String = "SELECT b.id_boleta, b.nombre, r.concepto, c.nombre_grupo, r.hora, b.nro_boleta, r.monto, r.descuento, r.total  FROM boleta b, recibo r, curso_grupo c, aula u where if (r.id_curso_grupo ='0', '1'= c.id_curso_grupo, r.id_curso_grupo =c.id_curso_grupo) and u.id_aula =c.id_aula and r.fecha_creacion BETWEEN '" & b & "' AND '" & c & "' and b.id_recibo =r.id_recibo group by b.nro_boleta"
        Dim Dr As MySqlDataReader
        Dim con As Double
        Dim n As Integer
        Try
            obj.conectar()
            Dr = obj.consulta1(sql)
            While Dr.Read()
                n = n + 1
                correlativo_final = CStr(Dr("id_boleta"))
                correlativo_inicial = correlativo_final - (n - 1)
            End While
            obj.desconectar()

            sql = "SELECT r.concepto, sum(r.total) as total FROM boleta b, recibo r, curso_grupo c, aula u where if (r.id_curso_grupo ='0', '1'= c.id_curso_grupo, r.id_curso_grupo =c.id_curso_grupo) and u.id_aula =c.id_aula and r.fecha_creacion BETWEEN '" & b & "' AND '" & c & "' and b.id_recibo =r.id_recibo and r.concepto <> 'Anulada' group by r.concepto"
            a.Items.Clear()
            obj.conectar()
            Dr = obj.consulta1(sql)
            Dim item As New ListViewItem
            While Dr.Read()
                item = a.Items.Add(CStr(Dr("concepto")))
                item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(CStr(Dr("total")))))
                con = String.Format("{0:C}", Convert.ToDouble(CStr(Dr("total")) + con))
                d.Text = String.Format("{0:C}", Convert.ToDouble(con))
            End While
            obj.desconectar()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            'cmd = Nothing
            Dr = Nothing
        End Try
        Return a
    End Function
    Public Function generar_codigo_boleta(ByVal rpta As Integer)
        Dim r As String = ""
        If rpta < 10 Then
            r = "00000" & rpta
        ElseIf rpta >= 10 And rpta < 100 Then
            r = "0000" & rpta
        ElseIf rpta >= 100 And rpta < 1000 Then
            r = "000" & rpta
        ElseIf rpta >= 1000 And rpta < 10000 Then
            r = "00" & rpta
        ElseIf rpta >= 10000 And rpta < 100000 Then
            r = "0" & rpta
        End If
        Return r
    End Function
End Class
