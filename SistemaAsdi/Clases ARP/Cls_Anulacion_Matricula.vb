Public Class Cls_Anulacion_Matricula
    Dim obj As New Conexion
    Public Sub Mostrar_alumnos(ByVal a As DataGridView)
        Dim sql As String = "select m.id_alumno_ficha, concat(concat(p.apellido_paterno,_latin1' ',p.apellido_materno),_latin1', ',p.nombres)AS Nombre, m.id_periodo from matricula m, persona p, alumno_ficha a where a.id_alumno_ficha = m.id_alumno_ficha and p.id_persona = a.id_persona and `m`.`reservada` = '1' order by `nombre`"
        obj.VerRegistro1(a, sql)
        a.Columns(0).Width = 70
        a.Columns(1).Width = 200
    End Sub
    Public Sub Desmatricular(ByVal a As Integer)
        Try
            Dim _id_horario As Integer
            Dim sql As String = "select h.id_horario from curso_grupo h, matricula m where m.id_curso_grupo = h.id_curso_grupo and id_matricula ='" & a & "'"
            _id_horario = obj.consulta(sql)
            sql = "UPDATE matricula set id_curso_grupo = '0', reservada =1, id_horario ='" & _id_horario & "'  where id_matricula ='" & a & "'"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Anulacion_de_Matricula(ByVal a As Integer)
        Try
            Dim _id_recibo As Integer
            Dim sql As String = "select id_recibo from recibo where id_matricula ='" & a & "' and separata=0"
            _id_recibo = obj.consulta(sql)
            sql = "UPDATE recibo set id_matricula = 0 , monto = 0, descuento = 0, total = 0, curso = 0, separata =0, id_tramite =0, id_curso=0, id_separata =0, concepto ='Anulada', hora='00:00:00'  where id_recibo ='" & _id_recibo & "'"
            obj.consulta(sql)
            sql = "UPDATE boleta set fecha_creacion='0000-00-00', nombre='Anulada', total = 0, id_alumno_ficha= null where id_recibo='" & _id_recibo & "'"
            obj.consulta(sql)
            sql = "DELETE FROM matricula where id_matricula ='" & a & "'"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Mostrar_alumnos_matricula(ByVal a As DataGridView, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT id_alumno_ficha, nombre, id_matricula FROM view_alumno_separatas where id_periodo ='" & b & "' and id_curso_grupo ='" & c & "'"
        obj.VerRegistro1(a, sql)
        a.Columns(0).Width = 90
        a.Columns(1).Width = 150
        a.Columns(2).Width = 90
    End Sub
    Public Function consulta_nombre_curso_a(ByVal a As Integer)
        Dim sql As String = "Select c.curso from curso c where c.id_curso ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Sub Llenar_programa(ByVal a As ComboBox)
        Dim sql As String = "SELECT p.id_programa, p.nombre FROM programa p"
        Dim c As String = "id_programa"
        Dim d As String = "nombre"
        obj.LlenarCombobox(a, sql, c, d)
    End Sub
    Public Sub TransferirMatricula(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal nom As String, ByVal id As Integer, ByVal per As Integer)
        Try
            Dim _promedio_final As Integer = 0
            Dim _fecha_creacion As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim _aprobo As Double = 0
            Dim _reserva As Double = 0
            Dim _anulada As Double = 0
            Dim _id_horario As Integer = 0
            Dim _observaciones As String = "Matricula trasferida"
            Dim _separata_m As String = "N"
            Dim _id_recibo As Integer
            Dim _id_asistencia As Integer
            Dim sql As String = "select id_recibo from recibo where id_matricula ='" & a & "' and separata=0"
            _id_recibo = obj.consulta(sql)

            sql = "Insert into matricula( id_alumno_ficha, id_curso_grupo, promedio_final, id_periodo, fecha_creacion, aprobo,reservada, anulada, observaciones, id_horario, separata) values('" & id & "','" & c & "','" & _promedio_final & "','" & per & "', '" & _fecha_creacion & "', '" & _aprobo & "', '" & _reserva & "', '" & _anulada & "','" & _observaciones & "','" & _id_horario & "','" & _separata_m & "' )"
            obj.consulta(sql)
            sql = "SELECT id_matricula FROM matricula WHERE id_alumno_ficha='" & id & "' and id_periodo='" & per & "' and fecha_creacion='" & _fecha_creacion & "' "
            Dim _id_matricula As Integer = obj.consulta(sql)

            _id_asistencia = obtener_id_asistencia(a)
            sql = "UPDATE asistencia set id_matricula ='" & _id_matricula & "' where id_asistencia ='" & _id_asistencia & "'"
            obj.consulta(sql)

            sql = "UPDATE recibo set id_matricula ='" & _id_matricula & "', id_curso='" & b & "', id_curso_grupo='" & c & "' where id_recibo ='" & _id_recibo & "'"
            obj.consulta(sql)
            sql = "UPDATE boleta set nombre='" & nom & "', id_alumno_ficha= '" & id & "' where id_recibo='" & _id_recibo & "'"
            obj.consulta(sql)
            sql = "DELETE FROM matricula where id_matricula ='" & a & "'"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function obtener_id_asistencia(ByVal a As String)
        Dim sql As String = "select id_asistencia from asistencia where id_matricula ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
End Class
