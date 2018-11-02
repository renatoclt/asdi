Imports MySql.Data.MySqlClient
Public Class Cls_Tramite
    Dim obj As New Conexion
    Public Function consulta_id_alumno_ficha(ByVal a As String)
        Dim sql As String = "SELECT t.id_alumno_ficha FROM tramite t WHERE t.id_tramite ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_costo(ByVal a As String)
        Dim sql As String = "SELECT p.costo FROM tramite t, tipo_tramite p  WHERE p.id_tp_tramite = t.id_tp_tramite and t.id_tramite ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_nombre_documento(ByVal a As String)
        Dim sql As String = "SELECT p.tp_tramite FROM tramite t, tipo_tramite p  WHERE p.id_tp_tramite = t.id_tp_tramite and t.id_tramite ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function generar_codigo_correlativo()
        Dim sql As String = "SELECT COUNT(*) from boleta"
        Dim a As String = "00000"
        Dim b As String = "0000"
        Dim c As String = "000"
        Dim d As String = "00"
        Dim e As String = "0"
        Dim rpta As String = obj.GenerarCodigo(sql, a, b, c, d, e)
        Return rpta
    End Function
    Public Sub guardar_datos_recibo(ByVal a As Double, ByVal b As String, ByVal c As Integer, ByVal d As Integer)
        Try
            Dim _id_matricula As Integer = Nothing
            Dim _id_curso_grupo As Integer = Nothing
            Dim _monto As Double = a
            Dim _descuento As Double = 0
            Dim _total As Double = a
            Dim _fecha_creacion_2 As String = Now.ToString("yyyy-MM-dd")
            Dim _hora As String = Now.ToString("HH:mm:ss")
            Dim _curso As Double = Nothing
            Dim _separata As Double = Nothing
            Dim sql As String = "SELECT p.tp_tramite FROM tramite t, tipo_tramite p  WHERE p.id_tp_tramite = t.id_tp_tramite and t.id_tramite ='" & c & "'"
            Dim _concepto As String = obj.consulta(sql)

            Dim _id_alumno_ficha As Integer = d
            Dim _nombre As String = b
            Dim _id_tranmite As Integer = c
            Dim _tranmite As Double = 1
            Dim _id_curso As Integer = Nothing
            Dim _id_separata As Integer = Nothing
            Dim _nro_boleta As String = generar_codigo_correlativo()
            _correlativo_boleta = _nro_boleta
            sql = "Insert into recibo( id_matricula, monto, descuento, total, fecha_creacion, curso, separata, id_tramite, tramite, id_curso,id_separata, concepto, hora, id_curso_grupo) values('" & _id_matricula & "','" & _monto & "','" & _descuento & "','" & _total & "', '" & _fecha_creacion_2 & "', '" & _curso & "', '" & _separata & "', '" & _id_tranmite & "', '" & _tranmite & "', '" & _id_curso & "', '" & _id_separata & "', '" & _concepto & "', '" & _hora & "', '" & _id_curso_grupo & "')"
            obj.consulta(sql)
            sql = "SELECT id_recibo from recibo where id_matricula ='" & _id_matricula & "' and monto = '" & _monto & "' and descuento = '" & _descuento & "' and total = '" & _total & "' and fecha_creacion = '" & _fecha_creacion_2 & "' and curso = '" & _curso & "' and separata = '" & _separata & "' and id_tramite = '" & _id_tranmite & "' and tramite = '" & _tranmite & "' and id_curso = '" & _id_curso & "' and id_separata = '" & _id_separata & "' and concepto ='" & _concepto & "' and hora='" & _hora & "' and id_curso_grupo='" & _id_curso_grupo & "' "
            Dim _id_recibo As Integer = obj.consulta(sql)
            sql = "Insert into boleta(id_recibo, nro_boleta, total, fecha_creacion, nombre, id_alumno_ficha) values('" & _id_recibo & "','" & _nro_boleta & "','" & _total & "','" & _fecha_creacion_2 & "','" & _nombre & "','" & _id_alumno_ficha & "')"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub guardar_datos_recibo_ventas(ByVal a As Double, ByVal b As String, ByVal c As Integer)
        Try
            Dim _id_matricula As Integer = Nothing
            Dim _id_curso_grupo As Integer = Nothing
            Dim _monto As Double = a
            Dim _descuento As Double = 0
            Dim _total As Double = a
            Dim _fecha_creacion_2 As String = Now.ToString("yyyy-MM-dd")
            Dim _hora As String = Now.ToString("HH:mm:ss")
            Dim _curso As Double = Nothing
            Dim _separata As Double = Nothing
            Dim _concepto As String = "Otros"

            Dim _id_alumno_ficha As Integer = c
            Dim _nombre As String = b
            Dim _id_tranmite As Integer = Nothing
            Dim _tranmite As Double = 1
            Dim _id_curso As Integer = Nothing
            Dim _id_separata As Integer = Nothing
            Dim _nro_boleta As String = generar_codigo_correlativo()
            _correlativo_boleta = _nro_boleta
            Dim sql As String = "Insert into recibo( id_matricula, monto, descuento, total, fecha_creacion, curso, separata, id_tramite, tramite, id_curso,id_separata, concepto, hora, id_curso_grupo) values('" & _id_matricula & "','" & _monto & "','" & _descuento & "','" & _total & "', '" & _fecha_creacion_2 & "', '" & _curso & "', '" & _separata & "', '" & _id_tranmite & "', '" & _tranmite & "', '" & _id_curso & "', '" & _id_separata & "', '" & _concepto & "', '" & _hora & "', '" & _id_curso_grupo & "')"
            obj.consulta(sql)
            sql = "SELECT id_recibo from recibo where id_matricula ='" & _id_matricula & "' and monto = '" & _monto & "' and descuento = '" & _descuento & "' and total = '" & _total & "' and fecha_creacion = '" & _fecha_creacion_2 & "' and curso = '" & _curso & "' and separata = '" & _separata & "' and id_tramite = '" & _id_tranmite & "' and tramite = '" & _tranmite & "' and id_curso = '" & _id_curso & "' and id_separata = '" & _id_separata & "' and concepto ='" & _concepto & "' and hora='" & _hora & "' and id_curso_grupo='" & _id_curso_grupo & "' "
            Dim _id_recibo As Integer = obj.consulta(sql)
            sql = "Insert into boleta(id_recibo, nro_boleta, total, fecha_creacion, nombre, id_alumno_ficha) values('" & _id_recibo & "','" & _nro_boleta & "','" & _total & "','" & _fecha_creacion_2 & "','" & _nombre & "','" & _id_alumno_ficha & "')"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
