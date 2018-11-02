Imports MySql.Data.MySqlClient
Public Class Cls_Notas
    Dim obj As New Conexion
    Public Sub Llenar_horario(ByVal a As ComboBox, ByVal b As String)
        Dim sql As String = "SELECT h.id_horario as id_horario, h.horario as horario FROM horario h, curso_grupo g, matricula m, curso_ofertado c where c.id_curso_ofertado = g.id_curso_ofertado and g.id_curso_grupo = m.id_curso_grupo and h.id_horario = g.id_horario and c.id_periodo = m.id_periodo and m.id_periodo ='" & b & "' group by id_horario"
        Dim c As String = "id_horario"
        Dim d As String = "horario"
        obj.LlenarCombobox1(a, sql, c, d)
    End Sub
    Public Sub Llenar_periodo(ByVal a As ComboBox)
        Dim sql As String = "SELECT p.id_periodo as id_periodo, p.periodo as periodo FROM periodo p where p.estado = 1"
        Dim b As String = "id_periodo"
        Dim c As String = "periodo"
        obj.LlenarCombobox(a, sql, b, c)
    End Sub
    Public Sub Llenar_curso(ByVal a As ComboBox, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT g.id_curso_grupo as id_curso, concat( u.curso,_latin1'  -  ', g.nombre_grupo) as curso  FROM curso_ofertado c, curso u, curso_grupo g, matricula m where m.id_curso_grupo = g.id_curso_grupo and u.id_curso = c.id_curso and g.id_curso_ofertado = c.id_curso_ofertado and c.id_periodo ='" & b & "' and g.id_horario ='" & c & "' group by id_curso"
        Dim d As String = "id_curso"
        Dim e As String = "curso"
        obj.LlenarCombobox1(a, sql, d, e)
    End Sub
    Public Sub Llenar_aula(ByVal a As ComboBox, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT a.id_aula as id_aula, a.aula as aula FROM curso_grupo c, aula a where c.id_aula = a.id_aula and c.id_curso_ofertado ='" & b & "' and c.id_horario ='" & c & "'"
        Dim d As String = "id_aula"
        Dim e As String = "aula"
        obj.LlenarCombobox1(a, sql, d, e)
    End Sub
    Public Function consulta_nombre_persona(ByVal a As String)
        Dim sql As String = "SELECT concat (p.apellido_paterno,' ', p.apellido_materno,', ', p.nombres) as nombre FROM alumno_ficha a, persona p where p.id_persona = a.id_persona and a.id_alumno_ficha ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_aula(ByVal a As String)
        Dim sql As String = "select a.aula from curso_grupo c, aula a where c.id_aula = a.id_aula and c.id_curso_grupo ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Function consulta_profesor(ByVal a As String)
        Dim sql As String = "select concat (p.apellido_paterno,' ', p.apellido_materno,', ', p.nombres) as nombre from curso_grupo c, persona p, profesor_ficha a where c.id_profesor_ficha = a.id_profesor_ficha and p.id_persona = a.id_persona and c.id_curso_grupo ='" & a & "'"
        Dim rpta As String = obj.consulta(sql)
        Return rpta
    End Function
    Public Sub Actualizar_matricula_aprobacion()
        Try
            Dim sql As String = "UPDATE matricula m, alumno_ficha a set m.aprobo=1, a.ciclo= a.ciclo +1 where m.id_alumno_ficha = a.id_alumno_ficha and m.promedio_final >=14 and m.aprobo =0"
            obj.consulta(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Lista de Notas Alumnos
    Public Sub Llenar_Alumnos(ByVal a As ComboBox)
        Dim sql As String = "Select a.id_alumno_ficha as id_alumno_ficha, concat (p.apellido_paterno,' ',p.apellido_materno,' ',p.nombres) as nombre from persona p, alumno_ficha a where p.id_persona = a.id_persona order by nombre"
        Dim e As String = "id_alumno_ficha"
        Dim f As String = "nombre"
        obj.LlenarCombobox(a, sql, e, f)
    End Sub

    Public Sub Mostrar_Alumnos(ByVal a As DataGridView, ByVal b As String)
        'Dim sql As String = "SELECT id_alumno_ficha, nombre, id_curso, nombre_grupo, curso, fecha_creacion, promedio_final, id_programa, programa  from (Select a.id_alumno_ficha, concat (p.apellido_paterno,' ',p.apellido_materno,' ',p.nombres) as nombre, s.id_curso, c.nombre_grupo, s.curso, substring(m.fecha_creacion,1,7) as fecha_creacion, m.promedio_final, r.id_programa as id_programa, r.nombre as programa from persona p, alumno_ficha a, curso_grupo c, curso_ofertado o, matricula m, curso s, programa r where s.id_programa = r.id_programa and p.id_persona = a.id_persona and o.id_curso_ofertado = c.id_curso_ofertado and m.id_alumno_ficha = a.id_alumno_ficha and m.id_curso_grupo = c.id_curso_grupo and o.id_curso = s.id_curso order by s.curso , m.promedio_final DESC) as datos where id_alumno_ficha='" & b & "' group by curso"
        Dim sql As String = "SELECT id_alumno_ficha, nombre, id_curso, nombre_grupo, curso, fecha_creacion, promedio_final, id_programa, programa  from view_alumno_notas where id_alumno_ficha='" & b & "' group by curso"
        obj.VerRegistro(a, sql)
        a.Columns(0).Width = 50
        a.Columns(1).Width = 150
        a.Columns(2).Width = 50
        a.Columns(3).Width = 50
        a.Columns(4).Width = 150
        'a.Columns(5).Visible = False
        a.Columns(7).Width = 80
    End Sub
    Public Sub Autocomplementar_Alumno(ByVal a As ComboBox)
        Dim sql As String = "Select a.id_alumno_ficha as id_alumno_ficha, concat (p.apellido_paterno,' ',p.apellido_materno,' ',p.nombres) as nombre from persona p, alumno_ficha a where p.id_persona = a.id_persona order by nombre"
        Dim n As String = "nombre"
        obj.conectar()
        a.AutoCompleteCustomSource = obj.Autocompletar(sql, n)
        a.AutoCompleteMode = AutoCompleteMode.Suggest
        a.AutoCompleteSource = AutoCompleteSource.CustomSource
        obj.desconectar()
    End Sub
    'select vp.id_profesor_ficha, vp.nombre, v.id_alumno_ficha, v.nombre, v.horario from view_alumno_profesor v, curso_ofertado co, curso_grupo cg, view_profesores vp, matricula m , horario h where m.id_alumno_ficha = v.id_alumno_ficha and m.id_curso_grupo= cg.id_curso_grupo and co.id_curso_ofertado = cg.id_curso_ofertado and cg.id_profesor_ficha = vp.id_profesor_ficha and cg.id_horario = h.id_horario and cg.id_profesor_ficha = v.id_profesor_ficha and co.id_periodo = m.id_periodo and co.id_periodo = 9  and cg.id_horario = 1 and v.id_profesor_ficha =7 group by v.id_alumno_ficha;
    'Asistencia
    Public Sub Llenar_horario_asistencia(ByVal a As ComboBox, ByVal b As String)
        Dim sql As String = "SELECT h.id_horario as id_horario, h.horario as horario FROM curso_grupo c, curso_ofertado o, horario h where c.id_curso_ofertado = o.id_curso_ofertado and h.id_horario = c.id_horario and  o.id_periodo ='" & b & "' group by h.id_horario"
        Dim c As String = "id_horario"
        Dim d As String = "horario"
        obj.LlenarCombobox1(a, sql, c, d)
    End Sub
    Public Sub Llenar_profesor_asistencia(ByVal a As ComboBox, ByVal b As String, ByVal c As String)
        Dim sql As String = "SELECT v.id_profesor_ficha as id_profesor_ficha, v.nombre as nombre FROM curso_grupo c, curso_ofertado o, horario h, view_profesores v where c.id_curso_ofertado = o.id_curso_ofertado and v.id_profesor_ficha =c.id_profesor_ficha and h.id_horario = c.id_horario and o.id_periodo ='" & b & "' and h.id_horario = '" & c & "' group by v.id_profesor_ficha"
        Dim d As String = "id_profesor_ficha"
        Dim e As String = "nombre"
        obj.LlenarCombobox1(a, sql, d, e)
    End Sub
    Public Sub Llenar_ciclo_asistencia(ByVal a As ComboBox, ByVal b As String, ByVal c As String, ByVal d As String)
        'Dim sql As String = "select c.id_curso as id_curso, c.curso as curso from view_alumno_profesor v, curso_ofertado co, curso c, curso_grupo cg, view_profesores vp, matricula m , horario h where m.id_alumno_ficha = v.id_alumno_ficha and m.id_curso_grupo= cg.id_curso_grupo and co.id_curso_ofertado = cg.id_curso_ofertado and cg.id_profesor_ficha = vp.id_profesor_ficha and cg.id_horario = h.id_horario and cg.id_profesor_ficha = v.id_profesor_ficha and co.id_periodo = m.id_periodo and c.id_curso = co.id_curso and co.id_periodo = '" & b & "'  and cg.id_horario = '" & c & "' and v.id_profesor_ficha = '" & d & "' group by c.id_curso"
        Dim sql As String = "SELECT u.id_curso as id_curso, concat(u.curso,_latin1' - ',c.nombre_grupo) as curso FROM curso u, curso_grupo c, curso_ofertado o, horario h, view_profesores v where u.id_curso = o.id_curso and c.id_curso_ofertado = o.id_curso_ofertado and v.id_profesor_ficha =c.id_profesor_ficha and h.id_horario = c.id_horario and o.id_periodo ='" & b & "' and h.id_horario = '" & c & "' and v.id_profesor_ficha ='" & d & "' group by u.id_curso"
        Dim e As String = "id_curso"
        Dim f As String = "curso"
        obj.LlenarCombobox1(a, sql, e, f)
    End Sub

    Public Sub Mostrar_Alumnos_asistencia(ByVal a As DataGridView, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String)
        'Dim sql As String = "select c.curso, v.horario, v.id_alumno_ficha, v.nombre, vp.id_profesor_ficha, vp.nombre from view_alumno_profesor v, curso_ofertado co, curso c, curso_grupo cg, view_profesores vp, matricula m , horario h where m.id_alumno_ficha = v.id_alumno_ficha and m.id_curso_grupo= cg.id_curso_grupo and co.id_curso_ofertado = cg.id_curso_ofertado and cg.id_profesor_ficha = vp.id_profesor_ficha and cg.id_horario = h.id_horario and cg.id_profesor_ficha = v.id_profesor_ficha and co.id_periodo = m.id_periodo and c.id_curso = co.id_curso and co.id_periodo = '" & b & "'  and cg.id_horario = '" & c & "' and v.id_profesor_ficha = '" & d & "' and c.id_curso = '" & e & "' group by v.id_alumno_ficha"
        Dim sql As String = "select Curso, Horario, Id_alumno, Nombre_alumno, Id_profesor, Nombre_profesor, Aula from view_alumno_asistencia where id_periodo = '" & b & "'  and id_horario = '" & c & "' and id_profesor_ficha = '" & d & "' and id_curso = '" & e & "' group by nombre_alumno order by horario DESC"
        obj.VerRegistro(a, sql)
        a.Columns(0).Width = 150
        a.Columns(1).Width = 100
        a.Columns(2).Width = 70
        a.Columns(3).Width = 170
        a.Columns(4).Width = 70
        a.Columns(5).Width = 150
        a.Columns(6).Width = 70
    End Sub
    '------------ Lista Curso Periodo

    Public Sub Llenar_plan_est(ByVal a As ComboBox, ByVal b As String)
        Dim sql As String = "SELECT p.id_plan_est as id_plan_est, p.plan_estudio as plan_estudio FROM plan_estudio p, curso_plan_est c, curso_ofertado o, periodo e WHERE c.id_plan_est = p.id_plan_est and c.id_curso = o.id_curso and o.id_periodo = e.id_periodo and e.id_periodo ='" & b & "' group by p.id_plan_est"
        Dim c As String = "id_plan_est"
        Dim d As String = "plan_estudio"
        obj.LlenarCombobox(a, sql, c, d)
    End Sub
    '---------Mostrar Pagos x Alumnos
    Public Sub Mostrar_Pagos_Alumnos(ByVal a As DataGridView, ByVal b As String, ByVal c As String)
        Dim sql As String = "Select nro_boleta as Nro_Boleta, nombre as Nombre, concepto as Concepto, fecha_creacion as Fecha_Creacion, hora as Hora, monto as Monto, descuento as Descuento, total as Total  from view_alumno_pagos where id_alumno_ficha ='" & b & "' and id_periodo = '" & c & "'"
        'SELECT b.id_boleta, b.nombre, r.concepto, c.nombre_grupo, u.aula, r.fecha_creacion, r.hora, b.nro_boleta, r.monto, r.descuento, r.total  FROM boleta b, recibo r, curso_grupo c, aula u, periodo p where if (r.id_curso_grupo ='0', '1'= c.id_curso_grupo, r.id_curso_grupo =c.id_curso_grupo) and u.id_aula =c.id_aula and r.fecha_creacion BETWEEN p.fecha_inicio AND p.fecha_fin and b.id_recibo =r.id_recibo and b.id_alumno_ficha ='55' and p.id_periodo = '14' group by b.nro_boleta;
        obj.VerRegistro(a, sql)
        a.Columns(0).Width = 70
        a.Columns(1).Width = 180
        a.Columns(2).Width = 70
        a.Columns(3).Width = 90
        a.Columns(4).Width = 50
        a.Columns(5).Width = 50
        a.Columns(6).Width = 80
        a.Columns(7).Width = 80
    End Sub
    Public Sub Mostrar_Pagos_Alumnos_Rango_Fechas(ByVal a As DataGridView, ByVal b As String, ByVal c As String, ByVal d As String)
        Dim sql As String = "Select nro_boleta as Nro_Boleta, nombre as Nombre, concepto as Concepto, fecha_creacion as Fecha_Creacion, hora as Hora, monto as Monto, descuento as Descuento, total as Total  from view_alumno_pagos where id_alumno_ficha ='" & b & "' and fecha_creacion BETWEEN '" & c & "' AND '" & d & "'"
        obj.VerRegistro(a, sql)
        a.Columns(0).Width = 70
        a.Columns(1).Width = 180
        a.Columns(2).Width = 70
        a.Columns(3).Width = 90
        a.Columns(4).Width = 50
        a.Columns(5).Width = 50
        a.Columns(6).Width = 80
        a.Columns(7).Width = 80
    End Sub
    'ASISTENCIA
    'select `co`.`id_periodo` AS `id_periodo`,`cg`.`id_horario` AS `id_horario`,`v`.`id_profesor_ficha` AS `id_profesor_ficha`,`c`.`id_curso` AS `id_curso`,`c`.`curso` AS `Curso`,`a`.`aula` AS `Aula`,`v`.`horario` AS `Horario`,`r`.`id_recibo` AS `Id_alumno`,`v`.`nombre` AS `Nombre_alumno`,`vp`.`id_profesor_ficha` AS `Id_profesor`,`vp`.`nombre` AS `Nombre_profesor` from ((((((((`view_alumno_profesor` `v` join `curso_ofertado` `co`) join `curso` `c`) join `curso_grupo` `cg`) join `view_profesores` `vp`) join `matricula` `m`) join `horario` `h`) join `recibo` `r`) join `aula` `a`) where ((`r`.`id_matricula` = `m`.`id_matricula`) and (`a`.`id_aula` = `cg`.`id_aula`) and (`m`.`id_alumno_ficha` = `v`.`id_alumno_ficha`) and (`m`.`id_curso_grupo` = `cg`.`id_curso_grupo`) and (`co`.`id_curso_ofertado` = `cg`.`id_curso_ofertado`) and (`cg`.`id_profesor_ficha` = `vp`.`id_profesor_ficha`) and (`cg`.`id_horario` = `h`.`id_horario`) and (`cg`.`id_profesor_ficha` = `v`.`id_profesor_ficha`) and (`co`.`id_periodo` = `m`.`id_periodo`) and (`c`.`id_curso` = `co`.`id_curso`));

End Class
