<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.men_principal = New System.Windows.Forms.MenuStrip
        Me.men_princ_inicio = New System.Windows.Forms.ToolStripMenuItem
        Me.men_inic_ingresar = New System.Windows.Forms.ToolStripMenuItem
        Me.men_inic_cambio_contrasenia = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.men_inic_session = New System.Windows.Forms.ToolStripMenuItem
        Me.men_inic_salir = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_matricular = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_caja = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_modif = New System.Windows.Forms.ToolStripMenuItem
        Me.men_modif_bol = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.men_modif_fichalum = New System.Windows.Forms.ToolStripMenuItem
        Me.men_modif_fichaprofe = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.men_modif_matric = New System.Windows.Forms.ToolStripMenuItem
        Me.men_modif_mover = New System.Windows.Forms.ToolStripMenuItem
        Me.men_modif_notas = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_tramites = New System.Windows.Forms.ToolStripMenuItem
        Me.men_tram_entregar = New System.Windows.Forms.ToolStripMenuItem
        Me.men_tram_list = New System.Windows.Forms.ToolStripMenuItem
        Me.men_tram_reg = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_registrar = New System.Windows.Forms.ToolStripMenuItem
        Me.men_reg_alumnos = New System.Windows.Forms.ToolStripMenuItem
        Me.men_reg_docentes = New System.Windows.Forms.ToolStripMenuItem
        Me.men_reg_trabajador = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.men_reg_cursos = New System.Windows.Forms.ToolStripMenuItem
        Me.men_reg_cur_cursos_oferados = New System.Windows.Forms.ToolStripMenuItem
        Me.men_reg_cur_cursos_grupos = New System.Windows.Forms.ToolStripMenuItem
        Me.men_reg_periodo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.men_reg_notas = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_listas = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_alumnos = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_alum_curso = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_alum_docente = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_alum_horario = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_alum_periodo = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_cur = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_cur_hora = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_cur_per = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_doce = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_doce_cur = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_doce_horario = New System.Windows.Forms.ToolStripMenuItem
        Me.men_list_doce_periodo = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_adm = New System.Windows.Forms.ToolStripMenuItem
        Me.men_adm_permisos = New System.Windows.Forms.ToolStripMenuItem
        Me.men_adm_reportes = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_configuracion = New System.Windows.Forms.ToolStripMenuItem
        Me.men_conf_aulas = New System.Windows.Forms.ToolStripMenuItem
        Me.men_conf_cursos = New System.Windows.Forms.ToolStripMenuItem
        Me.men_conf_cur_plan = New System.Windows.Forms.ToolStripMenuItem
        Me.men_cur_plan_agregar = New System.Windows.Forms.ToolStripMenuItem
        Me.men_cur_plan_editar = New System.Windows.Forms.ToolStripMenuItem
        Me.men_conf_horario = New System.Windows.Forms.ToolStripMenuItem
        Me.men_conf_plan_est = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.men_conf_tp_alum = New System.Windows.Forms.ToolStripMenuItem
        Me.men_conf_tp_documento = New System.Windows.Forms.ToolStripMenuItem
        Me.men_conf_tp_tram = New System.Windows.Forms.ToolStripMenuItem
        Me.men_princ_acerca = New System.Windows.Forms.ToolStripMenuItem
        Me.br_estado = New System.Windows.Forms.StatusStrip
        Me.lbl_estado_conect = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_estado_login = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_periodo = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_periodo_selecionado = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_estado_p = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_estado_periodo = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_usuario_ = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_usuario_estado = New System.Windows.Forms.ToolStripStatusLabel
        Me.men_conf_separata = New System.Windows.Forms.ToolStripMenuItem
        Me.men_principal.SuspendLayout()
        Me.br_estado.SuspendLayout()
        Me.SuspendLayout()
        '
        'men_principal
        '
        Me.men_principal.BackColor = System.Drawing.SystemColors.MenuBar
        Me.men_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_princ_inicio, Me.men_princ_matricular, Me.men_princ_caja, Me.men_princ_modif, Me.men_princ_tramites, Me.men_princ_registrar, Me.men_princ_listas, Me.men_princ_adm, Me.men_princ_configuracion, Me.men_princ_acerca})
        Me.men_principal.Location = New System.Drawing.Point(0, 0)
        Me.men_principal.Name = "men_principal"
        Me.men_principal.Size = New System.Drawing.Size(815, 24)
        Me.men_principal.TabIndex = 0
        Me.men_principal.Text = "MenuStrip1"
        '
        'men_princ_inicio
        '
        Me.men_princ_inicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_inic_ingresar, Me.men_inic_cambio_contrasenia, Me.ToolStripSeparator6, Me.men_inic_session, Me.men_inic_salir})
        Me.men_princ_inicio.Name = "men_princ_inicio"
        Me.men_princ_inicio.Size = New System.Drawing.Size(48, 20)
        Me.men_princ_inicio.Text = "&Inicio"
        '
        'men_inic_ingresar
        '
        Me.men_inic_ingresar.Name = "men_inic_ingresar"
        Me.men_inic_ingresar.Size = New System.Drawing.Size(195, 22)
        Me.men_inic_ingresar.Text = "&Ingresar"
        '
        'men_inic_cambio_contrasenia
        '
        Me.men_inic_cambio_contrasenia.Name = "men_inic_cambio_contrasenia"
        Me.men_inic_cambio_contrasenia.Size = New System.Drawing.Size(195, 22)
        Me.men_inic_cambio_contrasenia.Text = "Cambio de Contraseña"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(192, 6)
        '
        'men_inic_session
        '
        Me.men_inic_session.Name = "men_inic_session"
        Me.men_inic_session.Size = New System.Drawing.Size(195, 22)
        Me.men_inic_session.Text = "C&errar Sesión"
        '
        'men_inic_salir
        '
        Me.men_inic_salir.Name = "men_inic_salir"
        Me.men_inic_salir.Size = New System.Drawing.Size(195, 22)
        Me.men_inic_salir.Text = "&Salir"
        '
        'men_princ_matricular
        '
        Me.men_princ_matricular.Name = "men_princ_matricular"
        Me.men_princ_matricular.Size = New System.Drawing.Size(73, 20)
        Me.men_princ_matricular.Text = "&Matrícular"
        '
        'men_princ_caja
        '
        Me.men_princ_caja.Name = "men_princ_caja"
        Me.men_princ_caja.Size = New System.Drawing.Size(42, 20)
        Me.men_princ_caja.Text = "Caja"
        '
        'men_princ_modif
        '
        Me.men_princ_modif.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_modif_bol, Me.ToolStripSeparator1, Me.men_modif_fichalum, Me.men_modif_fichaprofe, Me.ToolStripSeparator2, Me.men_modif_matric, Me.men_modif_mover, Me.men_modif_notas})
        Me.men_princ_modif.Name = "men_princ_modif"
        Me.men_princ_modif.Size = New System.Drawing.Size(100, 20)
        Me.men_princ_modif.Text = "M&odificaciones"
        '
        'men_modif_bol
        '
        Me.men_modif_bol.Name = "men_modif_bol"
        Me.men_modif_bol.Size = New System.Drawing.Size(231, 22)
        Me.men_modif_bol.Text = "Boletas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(228, 6)
        '
        'men_modif_fichalum
        '
        Me.men_modif_fichalum.Name = "men_modif_fichalum"
        Me.men_modif_fichalum.Size = New System.Drawing.Size(231, 22)
        Me.men_modif_fichalum.Text = "Ficha del Alumno"
        '
        'men_modif_fichaprofe
        '
        Me.men_modif_fichaprofe.Name = "men_modif_fichaprofe"
        Me.men_modif_fichaprofe.Size = New System.Drawing.Size(231, 22)
        Me.men_modif_fichaprofe.Text = "Ficha del Docente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(228, 6)
        '
        'men_modif_matric
        '
        Me.men_modif_matric.Name = "men_modif_matric"
        Me.men_modif_matric.Size = New System.Drawing.Size(231, 22)
        Me.men_modif_matric.Text = "Matrícula del Alumno"
        '
        'men_modif_mover
        '
        Me.men_modif_mover.Name = "men_modif_mover"
        Me.men_modif_mover.Size = New System.Drawing.Size(231, 22)
        Me.men_modif_mover.Text = "Mover Alumnos a Otro Grupo"
        '
        'men_modif_notas
        '
        Me.men_modif_notas.Name = "men_modif_notas"
        Me.men_modif_notas.Size = New System.Drawing.Size(231, 22)
        Me.men_modif_notas.Text = "Notas"
        '
        'men_princ_tramites
        '
        Me.men_princ_tramites.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_tram_entregar, Me.men_tram_list, Me.men_tram_reg})
        Me.men_princ_tramites.Name = "men_princ_tramites"
        Me.men_princ_tramites.Size = New System.Drawing.Size(65, 20)
        Me.men_princ_tramites.Text = "T&rámites"
        '
        'men_tram_entregar
        '
        Me.men_tram_entregar.Name = "men_tram_entregar"
        Me.men_tram_entregar.Size = New System.Drawing.Size(164, 22)
        Me.men_tram_entregar.Text = "&Entregar Trámite"
        '
        'men_tram_list
        '
        Me.men_tram_list.Name = "men_tram_list"
        Me.men_tram_list.Size = New System.Drawing.Size(164, 22)
        Me.men_tram_list.Text = "&Lista de Trámites"
        '
        'men_tram_reg
        '
        Me.men_tram_reg.Name = "men_tram_reg"
        Me.men_tram_reg.Size = New System.Drawing.Size(164, 22)
        Me.men_tram_reg.Text = "&Registrar Trámite"
        '
        'men_princ_registrar
        '
        Me.men_princ_registrar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_reg_alumnos, Me.men_reg_docentes, Me.men_reg_trabajador, Me.ToolStripSeparator4, Me.men_reg_cursos, Me.men_reg_periodo, Me.ToolStripSeparator5, Me.men_reg_notas})
        Me.men_princ_registrar.Name = "men_princ_registrar"
        Me.men_princ_registrar.Size = New System.Drawing.Size(65, 20)
        Me.men_princ_registrar.Text = "&Registrar"
        '
        'men_reg_alumnos
        '
        Me.men_reg_alumnos.Name = "men_reg_alumnos"
        Me.men_reg_alumnos.Size = New System.Drawing.Size(142, 22)
        Me.men_reg_alumnos.Text = "&Alumnos"
        '
        'men_reg_docentes
        '
        Me.men_reg_docentes.Name = "men_reg_docentes"
        Me.men_reg_docentes.Size = New System.Drawing.Size(142, 22)
        Me.men_reg_docentes.Text = "&Docentes"
        '
        'men_reg_trabajador
        '
        Me.men_reg_trabajador.Name = "men_reg_trabajador"
        Me.men_reg_trabajador.Size = New System.Drawing.Size(142, 22)
        Me.men_reg_trabajador.Text = "&Trabajadores"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(139, 6)
        '
        'men_reg_cursos
        '
        Me.men_reg_cursos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_reg_cur_cursos_oferados, Me.men_reg_cur_cursos_grupos})
        Me.men_reg_cursos.Name = "men_reg_cursos"
        Me.men_reg_cursos.Size = New System.Drawing.Size(142, 22)
        Me.men_reg_cursos.Text = "&Ciclos"
        '
        'men_reg_cur_cursos_oferados
        '
        Me.men_reg_cur_cursos_oferados.Name = "men_reg_cur_cursos_oferados"
        Me.men_reg_cur_cursos_oferados.Size = New System.Drawing.Size(193, 22)
        Me.men_reg_cur_cursos_oferados.Text = "Aperturados de &Ciclos "
        '
        'men_reg_cur_cursos_grupos
        '
        Me.men_reg_cur_cursos_grupos.Name = "men_reg_cur_cursos_grupos"
        Me.men_reg_cur_cursos_grupos.Size = New System.Drawing.Size(193, 22)
        Me.men_reg_cur_cursos_grupos.Text = "Apertura de G&rupos"
        '
        'men_reg_periodo
        '
        Me.men_reg_periodo.Name = "men_reg_periodo"
        Me.men_reg_periodo.Size = New System.Drawing.Size(142, 22)
        Me.men_reg_periodo.Text = "P&eriodos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(139, 6)
        '
        'men_reg_notas
        '
        Me.men_reg_notas.Name = "men_reg_notas"
        Me.men_reg_notas.Size = New System.Drawing.Size(142, 22)
        Me.men_reg_notas.Text = "&Notas"
        '
        'men_princ_listas
        '
        Me.men_princ_listas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_list_alumnos, Me.men_list_cur, Me.men_list_doce})
        Me.men_princ_listas.Name = "men_princ_listas"
        Me.men_princ_listas.Size = New System.Drawing.Size(48, 20)
        Me.men_princ_listas.Text = "&Listas"
        '
        'men_list_alumnos
        '
        Me.men_list_alumnos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_list_alum_curso, Me.men_list_alum_docente, Me.men_list_alum_horario, Me.men_list_alum_periodo})
        Me.men_list_alumnos.Name = "men_list_alumnos"
        Me.men_list_alumnos.Size = New System.Drawing.Size(166, 22)
        Me.men_list_alumnos.Text = "&Lista de Alumnos"
        '
        'men_list_alum_curso
        '
        Me.men_list_alum_curso.Name = "men_list_alum_curso"
        Me.men_list_alum_curso.Size = New System.Drawing.Size(139, 22)
        Me.men_list_alum_curso.Text = "Por Ciclo"
        '
        'men_list_alum_docente
        '
        Me.men_list_alum_docente.Name = "men_list_alum_docente"
        Me.men_list_alum_docente.Size = New System.Drawing.Size(139, 22)
        Me.men_list_alum_docente.Text = "Por Docente"
        '
        'men_list_alum_horario
        '
        Me.men_list_alum_horario.Name = "men_list_alum_horario"
        Me.men_list_alum_horario.Size = New System.Drawing.Size(139, 22)
        Me.men_list_alum_horario.Text = "Por Horario"
        '
        'men_list_alum_periodo
        '
        Me.men_list_alum_periodo.Name = "men_list_alum_periodo"
        Me.men_list_alum_periodo.Size = New System.Drawing.Size(139, 22)
        Me.men_list_alum_periodo.Text = "Por Periodo"
        '
        'men_list_cur
        '
        Me.men_list_cur.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_list_cur_hora, Me.men_list_cur_per})
        Me.men_list_cur.Name = "men_list_cur"
        Me.men_list_cur.Size = New System.Drawing.Size(166, 22)
        Me.men_list_cur.Text = "Li&sta de Ciclos"
        '
        'men_list_cur_hora
        '
        Me.men_list_cur_hora.Name = "men_list_cur_hora"
        Me.men_list_cur_hora.Size = New System.Drawing.Size(136, 22)
        Me.men_list_cur_hora.Text = "Por Horario"
        '
        'men_list_cur_per
        '
        Me.men_list_cur_per.Name = "men_list_cur_per"
        Me.men_list_cur_per.Size = New System.Drawing.Size(136, 22)
        Me.men_list_cur_per.Text = "Por Periodo"
        '
        'men_list_doce
        '
        Me.men_list_doce.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_list_doce_cur, Me.men_list_doce_horario, Me.men_list_doce_periodo})
        Me.men_list_doce.Name = "men_list_doce"
        Me.men_list_doce.Size = New System.Drawing.Size(166, 22)
        Me.men_list_doce.Text = "L&ista de Docentes"
        '
        'men_list_doce_cur
        '
        Me.men_list_doce_cur.Name = "men_list_doce_cur"
        Me.men_list_doce_cur.Size = New System.Drawing.Size(136, 22)
        Me.men_list_doce_cur.Text = "Por Ciclo"
        '
        'men_list_doce_horario
        '
        Me.men_list_doce_horario.Name = "men_list_doce_horario"
        Me.men_list_doce_horario.Size = New System.Drawing.Size(136, 22)
        Me.men_list_doce_horario.Text = "Por Horario"
        '
        'men_list_doce_periodo
        '
        Me.men_list_doce_periodo.Name = "men_list_doce_periodo"
        Me.men_list_doce_periodo.Size = New System.Drawing.Size(136, 22)
        Me.men_list_doce_periodo.Text = "Por Periodo"
        '
        'men_princ_adm
        '
        Me.men_princ_adm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_adm_permisos, Me.men_adm_reportes})
        Me.men_princ_adm.Name = "men_princ_adm"
        Me.men_princ_adm.Size = New System.Drawing.Size(100, 20)
        Me.men_princ_adm.Text = "&Administración"
        '
        'men_adm_permisos
        '
        Me.men_adm_permisos.Name = "men_adm_permisos"
        Me.men_adm_permisos.Size = New System.Drawing.Size(217, 22)
        Me.men_adm_permisos.Text = "&Modificar datos y permisos"
        '
        'men_adm_reportes
        '
        Me.men_adm_reportes.Name = "men_adm_reportes"
        Me.men_adm_reportes.Size = New System.Drawing.Size(217, 22)
        Me.men_adm_reportes.Text = "&Reportes"
        '
        'men_princ_configuracion
        '
        Me.men_princ_configuracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_conf_aulas, Me.men_conf_cursos, Me.men_conf_cur_plan, Me.men_conf_horario, Me.men_conf_plan_est, Me.men_conf_separata, Me.ToolStripSeparator3, Me.men_conf_tp_alum, Me.men_conf_tp_documento, Me.men_conf_tp_tram})
        Me.men_princ_configuracion.Name = "men_princ_configuracion"
        Me.men_princ_configuracion.Size = New System.Drawing.Size(95, 20)
        Me.men_princ_configuracion.Text = "&Configuración"
        '
        'men_conf_aulas
        '
        Me.men_conf_aulas.Name = "men_conf_aulas"
        Me.men_conf_aulas.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_aulas.Text = "&Aulas"
        '
        'men_conf_cursos
        '
        Me.men_conf_cursos.Name = "men_conf_cursos"
        Me.men_conf_cursos.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_cursos.Text = "&Ciclos"
        '
        'men_conf_cur_plan
        '
        Me.men_conf_cur_plan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_cur_plan_agregar, Me.men_cur_plan_editar})
        Me.men_conf_cur_plan.Name = "men_conf_cur_plan"
        Me.men_conf_cur_plan.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_cur_plan.Text = "C&iclos de Planes de Estudios"
        '
        'men_cur_plan_agregar
        '
        Me.men_cur_plan_agregar.Name = "men_cur_plan_agregar"
        Me.men_cur_plan_agregar.Size = New System.Drawing.Size(221, 22)
        Me.men_cur_plan_agregar.Text = "&Agregar Ciclos"
        '
        'men_cur_plan_editar
        '
        Me.men_cur_plan_editar.Name = "men_cur_plan_editar"
        Me.men_cur_plan_editar.Size = New System.Drawing.Size(221, 22)
        Me.men_cur_plan_editar.Text = "&Editar el Orden de los Ciclos"
        '
        'men_conf_horario
        '
        Me.men_conf_horario.Name = "men_conf_horario"
        Me.men_conf_horario.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_horario.Text = "&Horarios"
        '
        'men_conf_plan_est
        '
        Me.men_conf_plan_est.Name = "men_conf_plan_est"
        Me.men_conf_plan_est.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_plan_est.Text = "&Planes de Estudio"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(219, 6)
        '
        'men_conf_tp_alum
        '
        Me.men_conf_tp_alum.Name = "men_conf_tp_alum"
        Me.men_conf_tp_alum.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_tp_alum.Text = "T&ipos de Alumnos"
        '
        'men_conf_tp_documento
        '
        Me.men_conf_tp_documento.Name = "men_conf_tp_documento"
        Me.men_conf_tp_documento.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_tp_documento.Text = "&Tipos de Documentos"
        '
        'men_conf_tp_tram
        '
        Me.men_conf_tp_tram.Name = "men_conf_tp_tram"
        Me.men_conf_tp_tram.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_tp_tram.Text = "Ti&pos de Trámites"
        '
        'men_princ_acerca
        '
        Me.men_princ_acerca.Name = "men_princ_acerca"
        Me.men_princ_acerca.Size = New System.Drawing.Size(71, 20)
        Me.men_princ_acerca.Text = "&Acerca de"
        '
        'br_estado
        '
        Me.br_estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_estado_conect, Me.lbl_estado_login, Me.lbl_periodo, Me.lbl_periodo_selecionado, Me.lbl_estado_p, Me.lbl_estado_periodo, Me.lbl_usuario_, Me.lbl_usuario_estado})
        Me.br_estado.Location = New System.Drawing.Point(0, 432)
        Me.br_estado.Name = "br_estado"
        Me.br_estado.Size = New System.Drawing.Size(815, 22)
        Me.br_estado.TabIndex = 8
        Me.br_estado.Text = "StatusStrip"
        '
        'lbl_estado_conect
        '
        Me.lbl_estado_conect.Name = "lbl_estado_conect"
        Me.lbl_estado_conect.Size = New System.Drawing.Size(48, 17)
        Me.lbl_estado_conect.Text = "Estado: "
        '
        'lbl_estado_login
        '
        Me.lbl_estado_login.ForeColor = System.Drawing.Color.Red
        Me.lbl_estado_login.Name = "lbl_estado_login"
        Me.lbl_estado_login.Size = New System.Drawing.Size(82, 17)
        Me.lbl_estado_login.Text = "Desconectado"
        '
        'lbl_periodo
        '
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(57, 17)
        Me.lbl_periodo.Text = "Periodo:  "
        '
        'lbl_periodo_selecionado
        '
        Me.lbl_periodo_selecionado.ForeColor = System.Drawing.Color.Red
        Me.lbl_periodo_selecionado.Name = "lbl_periodo_selecionado"
        Me.lbl_periodo_selecionado.Size = New System.Drawing.Size(48, 17)
        Me.lbl_periodo_selecionado.Text = "0000-00"
        '
        'lbl_estado_p
        '
        Me.lbl_estado_p.Name = "lbl_estado_p"
        Me.lbl_estado_p.Size = New System.Drawing.Size(111, 17)
        Me.lbl_estado_p.Text = "Estado del Periodo: "
        '
        'lbl_estado_periodo
        '
        Me.lbl_estado_periodo.ForeColor = System.Drawing.Color.Red
        Me.lbl_estado_periodo.Name = "lbl_estado_periodo"
        Me.lbl_estado_periodo.Size = New System.Drawing.Size(93, 17)
        Me.lbl_estado_periodo.Text = "Abierto/Cerrado"
        '
        'lbl_usuario_
        '
        Me.lbl_usuario_.Name = "lbl_usuario_"
        Me.lbl_usuario_.Size = New System.Drawing.Size(50, 17)
        Me.lbl_usuario_.Text = "Usuario:"
        '
        'lbl_usuario_estado
        '
        Me.lbl_usuario_estado.ForeColor = System.Drawing.Color.Red
        Me.lbl_usuario_estado.Name = "lbl_usuario_estado"
        Me.lbl_usuario_estado.Size = New System.Drawing.Size(66, 17)
        Me.lbl_usuario_estado.Text = "Sin Usuario"
        '
        'men_conf_separata
        '
        Me.men_conf_separata.Name = "men_conf_separata"
        Me.men_conf_separata.Size = New System.Drawing.Size(222, 22)
        Me.men_conf_separata.Text = "&Separatas"
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaAsdi.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(815, 454)
        Me.Controls.Add(Me.br_estado)
        Me.Controls.Add(Me.men_principal)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.men_principal
        Me.Name = "frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Académico de Asdi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.men_principal.ResumeLayout(False)
        Me.men_principal.PerformLayout()
        Me.br_estado.ResumeLayout(False)
        Me.br_estado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents men_principal As System.Windows.Forms.MenuStrip
    Friend WithEvents men_princ_inicio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_inic_ingresar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_inic_salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_princ_registrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_reg_alumnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_reg_docentes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_reg_cursos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_reg_cur_cursos_oferados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_reg_cur_cursos_grupos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_princ_adm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_adm_permisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_princ_acerca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_adm_reportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_princ_listas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_alumnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_alum_curso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_alum_horario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_alum_docente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_alum_periodo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_doce As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_doce_cur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_doce_horario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_doce_periodo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_princ_matricular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents br_estado As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_estado_conect As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_estado_login As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents men_princ_configuracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_conf_horario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_conf_tp_documento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_conf_cursos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_conf_aulas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_conf_tp_alum As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_conf_tp_tram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_periodo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_periodo_selecionado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents men_conf_plan_est As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_cur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_cur_per As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_list_cur_hora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_reg_notas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_estado_p As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_estado_periodo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_usuario_ As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_usuario_estado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents men_princ_tramites As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_tram_reg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_tram_list As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_tram_entregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_conf_cur_plan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_cur_plan_agregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_cur_plan_editar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_princ_modif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_modif_mover As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_modif_fichalum As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_modif_fichaprofe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_modif_matric As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_reg_trabajador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_modif_bol As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_modif_notas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_inic_cambio_contrasenia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_princ_caja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_inic_session As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_reg_periodo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents men_conf_separata As System.Windows.Forms.ToolStripMenuItem

End Class
