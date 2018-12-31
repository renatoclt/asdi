Imports MySql.Data.MySqlClient
Public Class Cls_Matricula
    Dim obj As New Conexion
    Public Sub guardar_datos_matricula(ByVal a As Integer, ByVal b As Integer, ByVal c As String, ByVal d As String, ByVal e As Integer, ByVal f As Double)
        Try
            Dim _id_alumno_ficha As Integer = a
            Dim _id_curso_grupo As Integer = Nothing
            Dim _promedio_final As Integer = 0
            Dim _id_periodo As Integer = b
            Dim _fecha_creacion As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim _aprobo As Double = 0
            Dim _reserva As Double = 1
            Dim _anulada As Double = 0
            Dim _observaciones As String = c
            Dim _id_horario As Integer = e
            Dim descuento_e As Double = f
            Dim _separata_m As String = "N"

            Dim sql As String = "Insert into matricula( id_alumno_ficha, id_curso_grupo, promedio_final, id_periodo, fecha_creacion, aprobo,reservada, anulada, observaciones, id_horario, separata) values('" & _id_alumno_ficha & "','" & _id_curso_grupo & "','" & _promedio_final & "','" & _id_periodo & "', '" & _fecha_creacion & "', '" & _aprobo & "', '" & _reserva & "', '" & _anulada & "','" & _observaciones & "','" & _id_horario & "','" & _separata_m & "' )"
            obj.consulta(sql)
            sql = "SELECT id_matricula FROM matricula WHERE id_alumno_ficha='" & _id_alumno_ficha & "' and id_periodo='" & _id_periodo & "' and id_horario='" & _id_horario & "' and reservada ='1'"
            Dim _id_matricula As Integer = obj.consulta(sql)
            sql = "SELECT costo FROM horario where id_horario = '" & _id_horario & "'"
            Dim _costo As Double = Convert.ToDouble(obj.consulta(sql))
            Dim _monto As Double = _costo - descuento_e
            Dim _descuento As Double = descuento_e
            Dim _total As Double = _costo
            Dim _fecha_creacion_2 As String = Now.ToString("yyyy-MM-dd")
            Dim _hora As String = Now.ToString("HH:mm:ss")
            Dim _curso As Double = Nothing
            Dim _separata As Double = Nothing
            Dim _concepto As String = "Separacion de Matricula"

            Dim _nombre As String = d
            Dim _id_tranmite As Integer = Nothing
            Dim _tranmite As Double = Nothing
            Dim _id_curso As Integer = Nothing
            Dim _id_separata As Integer = Nothing
            Dim _nro_boleta As String = generar_codigo_correlativo()
            _correlativo_boleta = _nro_boleta
            sql = "Insert into recibo( id_matricula, monto, descuento, total, fecha_creacion, curso, separata, id_tramite, tramite, id_curso,id_separata, concepto, hora, id_curso_grupo) values('" & _id_matricula & "','" & _monto & "','" & _descuento & "','" & _total & "', '" & _fecha_creacion_2 & "', '" & _curso & "', '" & _separata & "', '" & _id_tranmite & "', '" & _tranmite & "', '" & _id_curso & "', '" & _id_separata & "', '" & _concepto & "', '" & _hora & "', '" & _id_curso_grupo & "')"
            obj.consulta(sql)
            sql = "SELECT id_recibo from recibo where id_matricula ='" & _id_matricula & "' and monto = '" & _monto & "' and descuento = '" & _descuento & "' and total = '" & _total & "' and fecha_creacion = '" & _fecha_creacion_2 & "' and curso = '" & _curso & "' and separata = '" & _separata & "' and id_tramite = '" & _id_tranmite & "' and tramite = '" & _tranmite & "' and id_curso = '" & _id_curso & "' and id_separata = '" & _id_separata & "' and concepto ='" & _concepto & "' and hora='" & _hora & "' and id_curso_grupo='" & _id_curso_grupo & "' "
            Dim _id_recibo As Integer = obj.consulta(sql)
            sql = "Insert into boleta(id_recibo, nro_boleta, total, fecha_creacion, nombre, id_alumno_ficha) values('" & _id_recibo & "','" & _nro_boleta & "','" & _total & "','" & _fecha_creacion_2 & "','" & _nombre & "', '" & _id_alumno_ficha & "')"
            obj.consulta(sql)
            guardar_asistencia(_correlativo_boleta, _id_matricula)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub guardar_datos_recibo(ByVal a As Integer, ByVal b As Double, ByVal c As Double, ByVal d As Double, ByVal e As Integer, ByVal f As Integer, ByVal g As String, ByVal h As Integer, ByVal i As String, ByVal j As Integer)
        Try
            Dim _id_matricula As Integer = a
            Dim _monto As Double = b
            Dim _descuento As Double = c
            Dim _total As Double = d
            Dim _fecha_creacion As String = Now.ToString("yyyy-MM-dd")
            Dim _hora As String = Now.ToString("HH:mm:ss")
            Dim _curso As Double = Nothing
            Dim _separata As Double = Nothing
            Dim _concepto As String
            Dim _observaciones As String
            Dim _separata_m As String
            Dim sql As String

            Dim _nro_boleta As String = generar_codigo_correlativo()
            _correlativo_boleta = _nro_boleta

            If f >= 1 Then
                _separata = 1
                '_id_matricula = 0
                _concepto = "Separata"
                _separata_m = "S"
                sql = "UPDATE matricula set separata = '" & _separata_m & "'where id_matricula ='" & a & "'"
                obj.consulta(sql)
            Else
                _curso = 1
                _concepto = "Mensualidad"
                _observaciones = i
                sql = "UPDATE matricula set observaciones = '" & _observaciones & "'where id_matricula ='" & a & "'"
                obj.consulta(sql)
                guardar_asistencia(_correlativo_boleta, _id_matricula)
            End If
            Dim _nombre As String = g
            Dim _id_curso_grupo As Integer = h
            Dim _id_tranmite As Integer = Nothing
            Dim _tranmite As Double = Nothing
            Dim _id_curso As Integer = e
            Dim _id_separata As Integer = 1
            Dim _id_alumno_ficha As Integer = j

            sql = "Insert into recibo( id_matricula, monto, descuento, total, fecha_creacion, curso, separata, id_tramite, tramite, id_curso,id_separata, concepto, hora, id_curso_grupo) values('" & _id_matricula & "','" & _monto & "','" & _descuento & "','" & _total & "', '" & _fecha_creacion & "', '" & _curso & "', '" & _separata & "', '" & _id_tranmite & "', '" & _tranmite & "', '" & _id_curso & "', '" & _id_separata & "', '" & _concepto & "', '" & _hora & "', '" & _id_curso_grupo & "')"
            obj.consulta(sql)
            sql = "SELECT id_recibo from recibo where id_matricula ='" & _id_matricula & "' and monto = '" & _monto & "' and descuento = '" & _descuento & "' and total = '" & _total & "' and fecha_creacion = '" & _fecha_creacion & "' and curso = '" & _curso & "' and separata = '" & _separata & "' and id_tramite = '" & _id_tranmite & "' and tramite = '" & _tranmite & "' and id_curso = '" & _id_curso & "' and id_separata = '" & _id_separata & "' and concepto ='" & _concepto & "' and hora='" & _hora & "' and id_curso_grupo='" & _id_curso_grupo & "' "
            Dim _id_recibo As Integer = obj.consulta(sql)
            'MsgBox(_id_recibo)
            sql = "Insert into boleta(id_recibo, nro_boleta, total, fecha_creacion, nombre, id_alumno_ficha) values('" & _id_recibo & "','" & _nro_boleta & "','" & _total & "','" & _fecha_creacion & "','" & _nombre & "','" & _id_alumno_ficha & "')"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function guardar_asistencia(ByVal a As String, ByVal b As String)
        Dim sql As String = "Insert into asistencia( id_alumno_asistencia, id_matricula) values('" & a & "','" & b & "')"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_curso_grupo(ByVal a As String)
        Dim sql As String = "Select c.id_curso from curso c, curso_ofertado o, curso_grupo g where c.id_curso = o.id_curso and o.id_curso_ofertado = g.id_curso_ofertado and g.id_curso_grupo = '" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_curso_nombre(ByVal a As String)
        Dim sql As String = "Select c.curso from curso c, curso_ofertado o, curso_grupo g where c.id_curso = o.id_curso and o.id_curso_ofertado = g.id_curso_ofertado and g.id_curso_grupo = '" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_id_matricula(ByVal a As String, ByVal b As String, ByVal c As String)
        Dim sql As String = "Select id_matricula from matricula where id_alumno_ficha ='" & a & "' and id_curso_grupo ='" & b & "' and id_periodo= '" & c & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_aula(ByVal a As String)
        Dim sql As String = "select a.aula from curso_grupo c, aula a where c.id_aula = a.id_aula and c.id_curso_grupo ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_nombre_grupo(ByVal a As String)
        Dim sql As String = "select c.nombre_grupo from curso_grupo c where c.id_curso_grupo ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_horario(ByVal a As String)
        Dim sql As String = "select a.horario from curso_grupo c, horario a where c.id_horario = a.id_horario and c.id_curso_grupo ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_num_telefono(ByVal a As String)
        Dim sql As String = "SELECT p.telefono_fijo FROM persona p,alumno_ficha a,matricula m,recibo r where p.id_persona = a.id_persona and m.id_alumno_ficha = a.id_alumno_ficha and  r.id_matricula = m.id_matricula and m.id_alumno_ficha ='" & a & "' group by p.telefono_fijo"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_id_persona(ByVal a As String)
        Dim sql As String = "SELECT p.id_persona FROM persona p,alumno_ficha a,matricula m,recibo r where p.id_persona = a.id_persona and m.id_alumno_ficha = a.id_alumno_ficha and  r.id_matricula = m.id_matricula and m.id_alumno_ficha ='" & a & "' group by p.telefono_fijo"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_costo_horario(ByVal a As String)
        Dim sql As String = " SELECT costo FROM horario where id_horario = '" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_costo_id_grupo(ByVal a As String)
        Dim sql As String = "select a.costo from curso_grupo c, horario a where c.id_horario = a.id_horario and c.id_curso_grupo ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_id_matricula_actualizar(ByVal a As String, ByVal b As String)
        Dim sql As String = "Select id_matricula from matricula where id_alumno_ficha ='" & a & "' and id_periodo= '" & b & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_id_matricula_actualizar1(ByVal a As String, ByVal b As String)
        Dim sql As String = "Select id_matricula from matricula where id_alumno_ficha ='" & a & "' and id_periodo= '" & b & "' and reservada='1'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function generar_codigo_correlativo()
        'TODO comentar la siguiente linea al generar el instalador integer for xamp 
        'Dim sql As String = "SELECT MAX( castcast(nro_boleta as Integer)) FROM `boleta`"
        Dim sql As String = "SELECT MAX( cast(nro_boleta as Signed)) FROM `boleta`"
        Dim a As String = "00000"
        Dim b As String = "0000"
        Dim c As String = "000"
        Dim d As String = "00"
        Dim e As String = "0"
        Dim rpta As String = obj.GenerarCodigo(sql, a, b, c, d, e)
        Return rpta
    End Function
    Public Function Verificar_Periodo(ByVal a As String)
        Dim b As String = Now.ToString("yyyy-MM-dd")
        Dim sql As String = "SELECT COUNT(*) FROM periodo WHERE id_periodo='" & a & "' and fecha_inicio <='" & b & "' and '" & b & "'<= fecha_fin"
        Dim rpta As Integer = obj.consulta(sql)
        Return rpta
    End Function
    Public Function Verificar_otro_ciclo(ByVal a As Integer)
        Dim sql As String = "SELECT ciclo_alt FROM alumno_ficha WHERE otro_ciclo='1' and id_alumno_ficha ='" & a & "'"
        Dim rpta As Integer = obj.consulta(sql)
        Return rpta
    End Function

    Public Function Verificar_matricula(ByVal a As String, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT COUNT(*) FROM matricula m, curso_ofertado c, curso_grupo g WHERE m.id_curso_grupo = g.id_curso_grupo and c.id_curso_ofertado = g.id_curso_ofertado and m.id_alumno_ficha ='" & a & "' and c.id_curso='" & b & "' and m.id_periodo ='" & c & "'"
        Dim rpta As Integer = obj.consulta(sql)
        Return rpta
    End Function
    Public Function Verificar_matricula_reservada(ByVal a As String, ByVal b As String)
        Dim sql As String = "SELECT COUNT(*) FROM matricula m WHERE  m.id_alumno_ficha ='" & a & "' and m.id_periodo ='" & b & "' and m.reservada ='1'"
        Dim rpta As Integer = obj.consulta(sql)
        Return rpta
    End Function
    Public Sub Actualizar_matricula_reservada(ByVal a As String, ByVal b As String, ByVal c As String)
        Try
            Dim sql As String = "SELECT m.id_matricula FROM matricula m WHERE  m.id_alumno_ficha ='" & a & "' and m.id_periodo ='" & b & "' and m.reservada ='1'"
            Dim rpta As Integer = obj.consulta(sql)
            sql = "UPDATE matricula set id_curso_grupo = '" & c & "', reservada =0  where id_matricula ='" & rpta & "'"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Actualizar_matricula(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer)
        Try
            Dim sql As String = "UPDATE matricula set id_curso_grupo = '" & b & "', id_periodo = '" & c & "', reservada =0, id_horario = null   where id_matricula ='" & a & "'"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function Verificar_boleta(ByVal a As String)
        Dim sql As String = "SELECT COUNT(*) FROM boleta WHERE nro_boleta='" & a & "'"
        Dim rpta As Integer = obj.consulta(sql)
        Return rpta
    End Function

    Public Sub Anulacion_Boleta(ByVal a As String)
        Try
            Dim sql As String = "DELETE FROM matricula where id_matricula in ( select r.id_matricula from recibo r, boleta b where r.id_recibo = b.id_recibo and b.nro_boleta ='" & a & "')"
            obj.consulta(sql)
            sql = "UPDATE recibo set id_matricula = 0 , monto = 0, descuento = 0, total = 0, curso = 0, separata =0, id_tramite =0, id_curso=0, id_separata =0, concepto ='Anulada', hora='00:00:00'  where id_recibo = (select b.id_recibo from boleta b where b.nro_boleta ='" & a & "')"
            obj.consulta(sql)
            sql = "UPDATE boleta set fecha_creacion='0000-00-00', nombre='Anulada', total = 0 where nro_boleta='" & a & "'"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'pre matricula
    Public Function consulta_costo_id_horario(ByVal a As String)
        Dim sql As String = "SELECT t.tp_est_alum FROM alumno_ficha a, tipo_estado_alumno t where t.id_tp_est_alum = a.id_tp_est_alum and a.id_alumno_ficha ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_nombre_persona(ByVal a As String)
        Dim sql As String = "SELECT concat (p.apellido_paterno,' ', p.apellido_materno,', ', p.nombres) as nombre FROM alumno_ficha a, persona p where p.id_persona = a.id_persona and a.id_alumno_ficha ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_tipo_alumno(ByVal a As String)
        Dim sql As String = "SELECT t.tp_est_alum FROM alumno_ficha a, tipo_estado_alumno t where t.id_tp_est_alum = a.id_tp_est_alum and a.id_alumno_ficha ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_plan_estudios(ByVal a As String)
        Dim sql As String = "SELECT t.plan_estudio FROM alumno_ficha a, plan_estudio t where t.id_plan_est = a.id_plan_est and a.id_alumno_ficha ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_id_plan_estudios(ByVal a As String)
        Dim sql As String = "SELECT t.id_plan_est FROM alumno_ficha a, plan_estudio t where t.id_plan_est = a.id_plan_est and a.id_alumno_ficha ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_curso(ByVal a As String)
        Dim sql As String = "SELECT a.ciclo FROM alumno_ficha a, plan_estudio t where t.id_plan_est = a.id_plan_est and a.id_alumno_ficha ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_curso_nombre2(ByVal a As Integer)
        Dim sql As String = "Select c.id_curso from curso c, curso_ofertado o, curso_grupo g where c.id_curso = o.id_curso and o.id_curso_ofertado = g.id_curso_ofertado and g.id_curso_grupo ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Sub Llenar_periodo(ByVal a As ComboBox)
        Dim sql As String = "SELECT p.id_periodo as id_periodo, p.periodo as periodo FROM periodo p where p.estado = 1"
        Dim b As String = "id_periodo"
        Dim c As String = "periodo"
        obj.LlenarCombobox(a, sql, b, c)
    End Sub
    'Public Sub Llenar_horario(ByVal a As ComboBox)
    '    Dim sql As String = "SELECT id_horario, horario FROM horario"
    '    Dim b As String = "id_horario"
    '    Dim c As String = "horario"
    '    obj.LlenarCombobox(a, sql, b, c)
    'End Sub
    Public Sub Llenar_horario(ByVal a As ComboBox, ByVal b As String)
        Dim sql As String = "SELECT id_horario, horario FROM horario where id_plan_est ='" & b & "'"
        Dim c As String = "id_horario"
        Dim d As String = "horario"
        obj.LlenarCombobox(a, sql, c, d)
    End Sub
    Public Sub Llenar_grupo_curso(ByVal a As ComboBox, ByVal b As String, ByVal c As String, ByVal d As String)
        Dim sql As String = "select id_curso_grupo, grupo from view_matricula_grupos where orden = '" & b & "' and id_plan_est = '" & c & "' and id_periodo = '" & d & "'"
        Dim e As String = "id_curso_grupo"
        Dim f As String = "grupo"
        obj.LlenarCombobox(a, sql, e, f)
    End Sub
    Public Sub Llenar_ciclo_con_planest(ByVal a As ComboBox, ByVal b As String)
        Dim sql As String = "SELECT c.id_curso as id_curso, c.curso as curso FROM curso c, programa p, plan_estudio g where c.id_programa = p.id_programa and p.id_plan_est = g.id_plan_est and g.id_plan_est ='" & b & "'"
        Dim c As String = "id_curso"
        Dim d As String = "curso"
        obj.LlenarCombobox(a, sql, c, d)
    End Sub

    Public Sub Mostrar_alumnos(ByVal a As DataGridView, ByVal b As String)
        Dim sql As String = "select concat(concat(`p`.`apellido_paterno`,_latin1' ',`p`.`apellido_materno`),_latin1', ',`p`.`nombres`) AS `Nombre`,co.id_curso AS `Ciclo`,`est`.`tp_est_alum` AS `Estado`,`af`.`id_alumno_ficha` AS `Id_Alumno_Ficha`, m.id_matricula as id_matricula from (((`persona` `p` join `alumno_ficha` `af`) join `periodo` `pr`) join `tipo_estado_alumno` `est`), `matricula` `m`,curso_grupo cg , curso_ofertado co where ((`p`.`id_persona` = `af`.`id_persona`) and (`pr`.`id_periodo` = `af`.`periodo_inicio`) and (`af`.`id_tp_est_alum` = `est`.`id_tp_est_alum`) and (`p`.`tipo` = _latin1'A')) and `m`.`id_alumno_ficha` = `af`.`id_alumno_ficha` and m.id_curso_grupo = cg.id_curso_grupo and cg.id_curso_ofertado = co.id_curso_ofertado and`m`.`id_periodo` = '" & b & "' order by `nombre`"
        obj.VerRegistro(a, sql)
        a.Columns(0).Width = 200
        a.Columns(1).Width = 90
        a.Columns(2).Width = 100
        a.Columns(3).Visible = False
        a.Columns(4).Visible = False
    End Sub
    Public Sub Buscar_alumnos(ByVal a As DataGridView, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT v.nombre, co.id_curso as ciclo, v.estado, v.id_alumno_ficha, m.id_matricula as id_matricula FROM view_alumnos v, matricula m, curso_grupo cg , curso_ofertado co WHERE LOWER(nombre) like '%" & b & "%' and v.id_alumno_ficha = m.id_alumno_ficha and m.id_curso_grupo = cg.id_curso_grupo and cg.id_curso_ofertado = co.id_curso_ofertado and m.id_periodo='" & c & "' group by nombre ORDER BY nombre ASC"
        obj.VerRegistro(a, sql)
        a.Columns(0).Width = 200
        a.Columns(1).Width = 90
        a.Columns(2).Width = 100
        a.Columns(3).Visible = False
        a.Columns(4).Visible = False
    End Sub
    Public Function Obtener_id_grupo_curso(ByVal a As String, ByVal b As String)
        Dim sql As String = "SELECT id_curso_grupo FROM matricula WHERE id_alumno_ficha = '" & a & "' and id_periodo = '" & b & "'"
        Dim rpta As Integer = obj.consulta(sql)
        Return rpta
    End Function
    Public Function Obtener_id_grupo_curso1(ByVal a As String, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT id_curso_grupo FROM matricula WHERE id_alumno_ficha = '" & a & "' and id_periodo = '" & b & "' and id_matricula = '" & c & "'"
        Dim rpta As Integer = obj.consulta(sql)
        Return rpta
    End Function
    'Matricula separada
    Public Sub Llenar_plan_estudio(ByVal a As ComboBox, ByVal b As String)
        Dim sql As String = "Select distinct ple.id_plan_est as id_plan_est, ple.plan_estudio as plan_estudio from plan_estudio ple, curso_plan_est cpl, curso_ofertado co where ple.id_plan_est = cpl.id_plan_est and cpl.id_curso = co.id_curso and co.id_periodo = '" & b & "' order by ple.plan_estudio"
        Dim c As String = "id_plan_est"
        Dim d As String = "plan_estudio"
        obj.LlenarCombobox1(a, sql, c, d)
    End Sub
    Public Sub Mostrar_matriculas_separadas(ByVal a As DataGridView, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT id_persona, nombre, programa, estado, horario FROM view_matriculas_separadas where id_periodo='" & b & "' and id_plan_est ='" & c & "'"
        obj.VerRegistro(a, sql)
        a.Columns(0).Width = 70
        a.Columns(1).Width = 130
        a.Columns(2).Width = 120
        a.Columns(3).Width = 80
    End Sub
    'Ver separatas matricula
    Public Sub Llenar_curso_ofertado(ByVal a As ComboBox, ByVal b As String, ByVal c As String)
        'SELECT g.id_curso_grupo, v.curso FROM view_curso_ofertados v, curso_grupo g WHERE g.id_curso_ofertado = v.id_curso_ofertado and v.id_plan_est = '1' And v.id_periodo = '9';
        Dim sql As String = "select id_curso_grupo, grupo from view_matricula_grupos where id_plan_est ='" & b & "' and id_periodo ='" & c & "'"
        Dim d As String = "id_curso_grupo"
        Dim e As String = "grupo"
        obj.LlenarCombobox1(a, sql, d, e)
    End Sub
    Public Sub Mostrar_separatas_vendidas(ByVal a As DataGridView, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT id_alumno_ficha, nombre, separata, nombre_grupo, curso, horario FROM view_alumno_separatas where id_periodo ='" & b & "' and id_curso_grupo ='" & c & "'"
        obj.VerRegistro(a, sql)
        a.Columns(0).Width = 90
        a.Columns(1).Width = 150
        a.Columns(2).Width = 70
        a.Columns(3).Width = 70
        a.Columns(4).Width = 150
    End Sub
    'otro ciclo
    Public Sub Llenar_tipo_alumno(ByVal a As ComboBox)
        Dim sql As String = "SELECT id_tp_est_alum, tp_est_alum FROM tipo_estado_alumno"
        Dim c As String = "id_tp_est_alum"
        Dim d As String = "tp_est_alum"
        obj.LlenarCombobox(a, sql, c, d)
    End Sub
    Public Sub Llenar_plan_estudio(ByVal a As ComboBox)
        Dim sql As String = "SELECT id_plan_est, plan_estudio FROM plan_estudio"
        Dim c As String = "id_plan_est"
        Dim d As String = "plan_estudio"
        obj.LlenarCombobox(a, sql, c, d)
    End Sub
    Public Sub Llenar_ciclo_con_planest1(ByVal a As ComboBox, ByVal b As String)
        Dim sql As String = "SELECT c.id_curso as id_curso, c.curso as curso FROM curso c, programa p, plan_estudio g where c.id_programa = p.id_programa and p.id_plan_est = g.id_plan_est and g.id_plan_est ='" & b & "'"
        Dim c As String = "id_curso"
        Dim d As String = "curso"
        obj.LlenarCombobox1(a, sql, c, d)
    End Sub
    Public Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String
        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer
        flag = "N"
        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If
        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next
        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y
        If Len(dec) = 1 Then dec = dec & "0"
        '**********proceso de conversión***********
        flag = "N"
        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select
                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If
                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y
            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec
            Else
                Letras = palabras & " 00"
            End If
        Else
            Letras = ""
        End If
    End Function
End Class
