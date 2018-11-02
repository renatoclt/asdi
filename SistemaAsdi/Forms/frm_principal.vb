Public Class frm_principal
    '---- formulario 
    Private frm_horario_ As frm_horario
    Private frm_acerca_de_ As frm_acerca_de
    Private frm_login_ As frm_login
    Private frm_cambio_contrasenia_ As frm_cambio_contrasenia
    Private frm_periodo_ As frm_periodo
    Private frm_tp_documento_ As frm_tp_documento
    Private frm_ingreso_alumno_ As frm_ingreso_alumnos
    Private frm_ingreso_profesores_ As frm_ingreso_profesores
    Private frm_ingreso_trabajadores_ As frm_ingreso_trabajadores
    Private frm_curso_ As frm_curso
    Private frm_aula_ As frm_aula
    Private frm_tp_estado_alumno_ As frm_tp_estado_alumno
    Private frm_tp_tramite_ As frm_tp_tramite
    Private frm_plan_estudio_ As frm_plan_estudio
    Public frm_periodo_selected_ As frm_periodo_selected
    Private frm_alumno_buscar_ As frm_alumno_buscar
    Public frm_tramite_ As frm_tramite
    Private frm_tramite_lista_ As frm_tramite_lista
    Private frm_tramite_entregar_ As frm_tramite_entregar
    Private frm_curso_plan_est_ As frm_curso_plan_est
    Private frm_view_cursos_ As frm_view_cursos
    Private frm_cursos_ofertados_ As frm_cursos_ofertados
    Private frm_curso_grupo_ As frm_curso_grupo
    Public frm_matricula_ As frm_matricula
    Public frm_lista_alumno_profesor_ As frm_lista_alumno_profesor
    Public frm_lista_alumno_periodo_ As frm_lista_alumno_periodo
    Public frm_lista_alumno_curso_ As frm_lista_alumno_curso
    Public frm_lista_alumno_horario_ As frm_lista_alumno_horario
    Public frm_lista_profesor_curso_ As frm_lista_profesor_curso
    Public frm_lista_profesor_horario_ As frm_lista_profesor_horario
    Public frm_lista_profesor_periodo_ As frm_lista_profesor_periodo
    Public frm_lista_curso_horario_ As frm_lista_curso_horario
    Public frm_lista_curso_periodo_ As frm_lista_curso_periodo
    Private frm_modificar_alumno_ As frm_modificar_alumno
    Private frm_modificar_profesor_ As frm_modificar_profesor
    Private frm_modificar_trabajador_ As frm_modificar_trabajador
    Private frm_matricula_mover_ As frm_matricula_mover
    Private frm_separata_ As frm_separata




    '---- variables de instancias
    Public frm_horario_activo As Boolean = False
    Public frm_acerca_de_activo As Boolean = False
    Public frm_login_activo As Boolean = False
    Public frm_cambio_contrasenia_activo As Boolean = False
    Public frm_periodo_activo As Boolean = False
    Public frm_tp_documento_activo As Boolean = False
    Public frm_ingreso_alumnos_activo As Boolean = False
    Public frm_ingreso_profesores_activo As Boolean = False
    Public frm_ingreso_trabajadores_activo As Boolean = False
    Public frm_curso_activo As Boolean = False
    Public frm_aula_activo As Boolean = False
    Public frm_tp_estado_alumno_activo As Boolean = False
    Public frm_tp_tramite_activo As Boolean = False
    Public frm_plan_estudio_activo As Boolean = False
    Public frm_periodo_selected_activo As Boolean = False
    Public frm_alumno_buscar_activo As Boolean = False
    Public frm_tramite_activo As Boolean = False
    Public frm_tramite_lista_activo As Boolean = False
    Public frm_tramite_entregar_activo As Boolean = False
    Public frm_curso_plan_est_activo As Boolean = False
    Public frm_view_cursos_activo As Boolean = False
    Public frm_cursos_ofertados_activo As Boolean = False
    Public frm_curso_grupo_activo As Boolean = False
    Public frm_matricula_activo As Boolean = False
    Public frm_lista_alumno_profesor_activo As Boolean = False
    Public frm_lista_alumno_curso_activo As Boolean = False
    Public frm_lista_alumno_periodo_activo As Boolean = False
    Public frm_lista_alumno_horario_activo As Boolean = False
    Public frm_lista_profesor_curso_activo As Boolean = False
    Public frm_lista_profesor_horario_activo As Boolean = False
    Public frm_lista_profesor_periodo_activo As Boolean = False
    Public frm_lista_curso_horario_activo As Boolean = False
    Public frm_lista_curso_periodo_activo As Boolean = False
    Public frm_modificar_alumno_activo As Boolean = False
    Public frm_modificar_profesor_activo As Boolean = False
    Public frm_modificar_trabajador_activo As Boolean = False
    Public frm_matricula_mover_activo As Boolean = False
    Public frm_separata_activo As Boolean = False



    Public Sub load_menus(ByVal activo As Boolean)
        '---- menu inicio
        men_inic_ingresar.Enabled = Not activo
        men_inic_cambio_contrasenia.Enabled = activo
        men_ciclos_2.Enabled = activo
        men_mes_2.Enabled = activo
        men_inic_session.Enabled = activo
        men_inic_salir.Enabled = activo
        '---- menu matricular
        men_princ_matricular.Enabled = activo
        '---- menu caja
        men_princ_caja.Enabled = activo
        '---- menu modificar
        men_modif_fichalum.Enabled = activo
        men_modif_fichaprofe.Enabled = activo
        men_modif_matric.Enabled = activo
        men_modif_mover.Enabled = activo
        men_modificar_matricula.Enabled = activo
        men_anulacion_mat.Enabled = activo
        men_mat_espera.Enabled = activo
        'men_modif_bol.Enabled = activo
        men_princ_modif.Enabled = activo
        '---- menu tramite
        men_tram_entregar.Enabled = activo
        men_tram_list.Enabled = activo
        men_tram_reg.Enabled = activo
        men_princ_tramites.Enabled = activo
        '---- menu registrar
        men_reg_periodo.Enabled = activo
        men_reg_alumnos.Enabled = activo
        men_reg_docentes.Enabled = activo
        men_reg_trabajador.Enabled = activo
        men_reg_notas.Enabled = activo
        men_reg_cur_cursos_grupos.Enabled = activo
        men_reg_cur_cursos_oferados.Enabled = activo
        men_reg_cursos.Enabled = activo
        men_princ_registrar.Enabled = activo
        men_venta_sep.Enabled = activo
        men_venta_otros.Enabled = activo
        '---- menu lista
        men_princ_listas.Enabled = activo
        '---- menu administrar
        men_princ_adm.Enabled = activo
        '--- menu configuracion
        men_conf_horario.Enabled = activo
        men_conf_tp_documento.Enabled = activo
        men_conf_cursos.Enabled = activo
        men_conf_aulas.Enabled = activo
        men_conf_tp_alum.Enabled = activo
        men_conf_tp_tram.Enabled = activo
        men_conf_plan_est.Enabled = activo
        men_conf_cur_plan.Enabled = activo
        men_cur_plan_agregar.Enabled = activo
        men_cur_plan_editar.Enabled = activo
        men_cd_separata.Enabled = activo
        men_impresora.Enabled = activo
        'men_conf_separata.Enabled = activo
        men_princ_configuracion.Enabled = activo
        '---- variables
    End Sub

    Public Sub load_menu_usuario()
        load_menus(False)
        If (Global_variables.trabajador.Trabajador_Matriculas) Then
            '---- menu matricular
            men_princ_matricular.Enabled = True
            '---- menu general
            men_princ_modif.Enabled = True
            '-----
            men_reg_alumnos.Enabled = True
            men_reg_docentes.Enabled = True
            '-----
            men_modif_fichalum.Enabled = True
            men_modif_fichaprofe.Enabled = True
            '-----
            men_conf_cursos.Enabled = True
            men_conf_aulas.Enabled = True
            men_conf_cur_plan.Enabled = True
            '-----
            men_cur_plan_agregar.Enabled = True
            men_cur_plan_editar.Enabled = True
            '-----
            men_modif_matric.Enabled = True
            men_modif_mover.Enabled = True
            men_modificar_matricula.Enabled = True
            men_anulacion_mat.Enabled = True
            men_mat_espera.Enabled = True
            '-----
            men_ciclos_2.Enabled = True
            men_mes_2.Enabled = True
            Men_apertura_ciclos.Enabled = True
            Men_apertura_grupos.Enabled = True
            '---- menu Reportes
            men_princ_listas.Enabled = True
        End If
        If (Global_variables.trabajador.Trabajador_Caja) Then
            '--- menu caja
            men_princ_caja.Enabled = True
        End If
        If (Global_variables.trabajador.Trabajador_Tramite) Then
            '---- menu tramite
            men_princ_tramites.Enabled = True
            men_tram_entregar.Enabled = True
            men_tram_list.Enabled = True
            men_tram_reg.Enabled = True
            men_venta_sep.Enabled = True
            men_venta_otros.Enabled = True
        End If
        If (Global_variables.trabajador.Trabajador_Notas) Then
            '---- menu registrar
            men_princ_registrar.Enabled = True
            men_reg_notas.Enabled = True
        End If
        If (Global_variables.trabajador.Trabajador_Boletas) Then
            '--- menu configuracion
            men_princ_configuracion.Enabled = True
            men_conf_plan_est.Enabled = True
            men_conf_tp_tram.Enabled = True
            men_conf_tp_alum.Enabled = True
            men_conf_tp_documento.Enabled = True
            men_conf_horario.Enabled = True
            men_conf_tp_tram.Enabled = True
            men_cd_separata.Enabled = True
            men_impresora.Enabled = True
        End If
        If (Global_variables.trabajador.Trabajador_Super) Then
            load_menus(True)
        End If
        If (Global_variables.trabajador.Trabajador_Administrador) Then
            load_menus(True)
        End If
        
        men_inic_ingresar.Enabled = False
        men_inic_cambio_contrasenia.Enabled = True
        men_inic_session.Enabled = True
        men_inic_salir.Enabled = True
    End Sub

    Public Sub load_informacion()
        lbl_estado_login.Text = "Conectado"
        lbl_periodo_selecionado.Text = Global_variables.periodo_sesion.Periodo_Nombre
        lbl_estado_periodo.Text = Global_variables.periodo_sesion.Periodo_Estado
        lbl_usuario_estado.Text = Trim(Global_variables.persona_trabajador.Persona_Nombres + " " + Global_variables.persona_trabajador.Persona_Apellido_Paterno + " " + Global_variables.persona_trabajador.Persona_Apellido_Materno)
        nombre_usuario = Trim(Global_variables.persona_trabajador.Persona_Nombres)
        Me.Text = "Sistema Académico de Asdi - " + Global_variables.periodo_sesion.Periodo_Nombre
    End Sub

    Private Sub frm_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data()
        load_menus(False)
        Me.Text = "Sistema Académico de Asdi"
        If (Not frm_login_activo) Then
            frm_login_ = New frm_login
            frm_login_.Show()
            frm_login_.MdiParent = Me
            frm_login_activo = True
        Else
            frm_login_.Activate()
        End If
    End Sub

    Private Sub frm_principal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim i As Integer
        i = MsgBox("Esta Ud. seguro que desea salir?", vbYesNo + vbQuestion, "Salir")
        If i = vbYes Then
            For Each frm As Form In Me.MdiChildren
                frm.Close()
            Next
        ElseIf i = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub men_inic_session_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_inic_session.Click
        load_menus(False)
        lbl_estado_login.Text = "Desconectado"
        lbl_periodo_selecionado.Text = "0000-00"
        lbl_estado_periodo.Text = "Abierto/Cerrado"
        lbl_usuario_estado.Text = "Sin Usuario"
        Me.Text = "Sistema Académico de Asdi"
    End Sub

    Private Sub men_conf_horario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_conf_horario.Click
        'If (Not frm_horario_activo) Then
        '    frm_horario_ = New frm_horario
        '    frm_horario_.Show()
        '    frm_horario_.MdiParent = Me
        '    frm_horario_activo = True
        'Else
        '    frm_horario_.Activate()
        'End If
        frm_horario.Show()
    End Sub

    Private Sub men_princ_acerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_princ_acerca.Click
        If (Not frm_acerca_de_activo) Then
            frm_acerca_de_ = New frm_acerca_de
            frm_acerca_de_.Show()
            frm_acerca_de_.MdiParent = Me
            frm_acerca_de_activo = True
        Else
            frm_acerca_de_.Activate()
        End If
    End Sub

    Private Sub men_inic_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_inic_salir.Click
        Dim msg As Integer
        msg = MsgBox("Esta Ud. seguro que desea salir?", vbYesNo + vbQuestion, "Salir")
        If msg = vbYes Then
            For Each frm As Form In Me.MdiChildren
                frm.Close()
            Next
            load_menus(False)
            lbl_estado_login.Text = "Desconectado"
            lbl_periodo_selecionado.Text = "0000-00"
            lbl_estado_periodo.Text = "Abierto/Cerrado"
            lbl_usuario_estado.Text = "Sin Usuario"
            Me.Close()
        End If
    End Sub

    Private Sub men_inic_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_inic_ingresar.Click
        load_menus(False)
        If (Not frm_login_activo) Then
            frm_login_ = New frm_login
            frm_login_.Show()
            frm_login_.MdiParent = Me
            frm_login_activo = True
        Else
            frm_login_.Activate()
        End If
    End Sub

    Private Sub men_reg_periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_reg_periodo.Click
        If (Not frm_periodo_activo) Then
            frm_periodo_ = New frm_periodo
            frm_periodo_.Show()
            frm_periodo_.MdiParent = Me
            frm_periodo_activo = True
        Else
            frm_periodo_.Activate()
        End If
    End Sub

    Private Sub men_conf_tp_documento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_conf_tp_documento.Click
        'If (Not frm_tp_documento_activo) Then
        '    frm_tp_documento_ = New frm_tp_documento
        '    frm_tp_documento_.Show()
        '    frm_tp_documento_.MdiParent = Me
        '    frm_tp_documento_activo = True
        'Else
        '    frm_tp_documento_.Activate()
        'End If
        frm_tp_documento.Show()
    End Sub

    Private Sub men_conf_cursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub men_conf_aulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Not frm_aula_activo) Then
            frm_aula_ = New frm_aula
            frm_aula_.Show()
            frm_aula_.MdiParent = Me
            frm_aula_activo = True
        Else
            frm_aula_.Activate()
        End If
    End Sub

    Private Sub men_conf_tp_alum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_conf_tp_alum.Click
        'If (Not frm_tp_estado_alumno_activo) Then
        '    frm_tp_estado_alumno_ = New frm_tp_estado_alumno
        '    frm_tp_estado_alumno_.Show()
        '    frm_tp_estado_alumno_.MdiParent = Me
        '    frm_tp_documento_activo = True
        'Else
        '    frm_tp_estado_alumno_.Activate()
        'End If
        frm_tp_estado_alumno.Show()
    End Sub

    Private Sub men_conf_tp_tram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_conf_tp_tram.Click
        'If (Not frm_tp_tramite_activo) Then
        '    frm_tp_tramite_ = New frm_tp_tramite
        '    frm_tp_tramite_.Show()
        '    frm_tp_tramite_.MdiParent = Me
        '    frm_tp_tramite_activo = True
        'Else
        '    frm_tp_tramite_.Activate()
        'End If
        frm_tp_tramite.Show()
    End Sub

    Private Sub men_conf_plan_est_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_conf_plan_est.Click
        'If (Not frm_plan_estudio_activo) Then
        '    frm_plan_estudio_ = New frm_plan_estudio
        '    frm_plan_estudio_.Show()
        '    frm_plan_estudio_.MdiParent = Me
        '    frm_plan_estudio_activo = True
        'Else
        '    frm_plan_estudio_.Activate()
        'End If
        frm_plan_estudio.Show()
    End Sub

    Private Sub men_inic_periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Not frm_periodo_selected_activo) Then
            frm_periodo_selected_ = New frm_periodo_selected
            frm_periodo_selected_.Show()
            frm_periodo_selected_.MdiParent = Me
            frm_periodo_selected_activo = True
        Else
            frm_periodo_selected_.Activate()
        End If
    End Sub

    Private Sub men_tram_reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_tram_reg.Click
        If (Not frm_tramite_activo) Then
            frm_tramite_ = New frm_tramite
            frm_tramite_.Show()
            frm_tramite_.MdiParent = Me
            frm_tramite_activo = True
        Else
            frm_tramite_.Activate()
        End If
    End Sub

    Private Sub men_tram_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_tram_list.Click
        If (Not frm_tramite_lista_activo) Then
            frm_tramite_lista_ = New frm_tramite_lista
            frm_tramite_lista_.Show()
            frm_tramite_lista_.MdiParent = Me
            frm_tramite_lista_activo = True
        Else
            frm_tramite_lista_.Activate()
        End If
    End Sub

    Private Sub men_tram_entregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_tram_entregar.Click
        If (Not frm_tramite_entregar_activo) Then
            frm_tramite_entregar_ = New frm_tramite_entregar
            frm_tramite_entregar_.Show()
            frm_tramite_entregar_.MdiParent = Me
            frm_tramite_entregar_activo = True
        Else
            frm_tramite_entregar_.Activate()
        End If
    End Sub

    Private Sub men_cur_plan_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub men_cur_plan_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub men_reg_cur_cursos_oferados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_reg_cur_cursos_oferados.Click
        If (Not frm_cursos_ofertados_activo) Then
            frm_cursos_ofertados_ = New frm_cursos_ofertados
            frm_cursos_ofertados_.Show()
            frm_cursos_ofertados_.MdiParent = Me
            frm_cursos_ofertados_activo = True
        Else
            frm_cursos_ofertados_.Activate()
        End If
    End Sub

    Private Sub men_reg_cur_cursos_grupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_reg_cur_cursos_grupos.Click
        If (Not frm_curso_grupo_activo) Then
            frm_curso_grupo_ = New frm_curso_grupo
            frm_curso_grupo_.Show()
            frm_curso_grupo_.MdiParent = Me
            frm_curso_grupo_activo = True
        Else
            frm_curso_grupo_.Activate()
        End If
    End Sub

    Private Sub men_princ_matricular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_princ_matricular.Click
        If (Not frm_matricula_activo) Then
            frm_matricula_ = New frm_matricula
            frm_matricula_.Show()
            frm_matricula_.MdiParent = Me
            frm_matricula_activo = True
        Else
            frm_matricula_.Activate()
        End If
    End Sub

    Private Sub men_list_alum_docente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_alum_docente.Click
        If (Not frm_lista_alumno_profesor_activo) Then
            frm_lista_alumno_profesor_ = New frm_lista_alumno_profesor
            frm_lista_alumno_profesor_.Show()
            frm_lista_alumno_profesor_.MdiParent = Me
            frm_lista_alumno_profesor_activo = True
        Else
            frm_lista_alumno_profesor_.Activate()
        End If
    End Sub

    Private Sub men_list_alum_curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_alum_curso.Click
        If (Not frm_lista_alumno_curso_activo) Then
            frm_lista_alumno_curso_ = New frm_lista_alumno_curso
            frm_lista_alumno_curso_.Show()
            frm_lista_alumno_curso_.MdiParent = Me
            frm_lista_alumno_curso_activo = True
        Else
            frm_lista_alumno_curso_.Activate()
        End If
    End Sub

    Private Sub men_list_alum_horario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_alum_horario.Click
        If (Not frm_lista_alumno_horario_activo) Then
            frm_lista_alumno_horario_ = New frm_lista_alumno_horario
            frm_lista_alumno_horario_.Show()
            frm_lista_alumno_horario_.MdiParent = Me
            frm_lista_alumno_horario_activo = True
        Else
            frm_lista_alumno_horario_.Activate()
        End If
    End Sub

    Private Sub men_list_alum_periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_alum_periodo.Click
        If (Not frm_lista_alumno_periodo_activo) Then
            frm_lista_alumno_periodo_ = New frm_lista_alumno_periodo
            frm_lista_alumno_periodo_.Show()
            frm_lista_alumno_periodo_.MdiParent = Me
            frm_lista_alumno_periodo_activo = True
        Else
            frm_lista_alumno_periodo_.Activate()
        End If
    End Sub

    Private Sub men_list_doce_cur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_doce_cur.Click
        If (Not frm_lista_profesor_curso_activo) Then
            frm_lista_profesor_curso_ = New frm_lista_profesor_curso
            frm_lista_profesor_curso_.Show()
            frm_lista_profesor_curso_.MdiParent = Me
            frm_lista_profesor_curso_activo = True
        Else
            frm_lista_profesor_curso_.Activate()
        End If
    End Sub

    Private Sub men_list_doce_horario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_doce_horario.Click
        If (Not frm_lista_profesor_horario_activo) Then
            frm_lista_profesor_horario_ = New frm_lista_profesor_horario
            frm_lista_profesor_horario_.Show()
            frm_lista_profesor_horario_.MdiParent = Me
            frm_lista_profesor_horario_activo = True
        Else
            frm_lista_profesor_horario_.Activate()
        End If
    End Sub

    Private Sub men_list_doce_periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_doce_periodo.Click
        If (Not frm_lista_profesor_periodo_activo) Then
            frm_lista_profesor_periodo_ = New frm_lista_profesor_periodo
            frm_lista_profesor_periodo_.Show()
            frm_lista_profesor_periodo_.MdiParent = Me
            frm_lista_profesor_periodo_activo = True
        Else
            frm_lista_profesor_periodo_.Activate()
        End If
    End Sub

    Private Sub men_list_cur_hora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_cur_hora.Click
        If (Not frm_lista_curso_horario_activo) Then
            frm_lista_curso_horario_ = New frm_lista_curso_horario
            frm_lista_curso_horario_.Show()
            frm_lista_curso_horario_.MdiParent = Me
            frm_lista_curso_horario_activo = True
        Else
            frm_lista_curso_horario_.Activate()
        End If
    End Sub

    Private Sub men_list_cur_per_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_list_cur_per.Click
        If (Not frm_lista_curso_periodo_activo) Then
            frm_lista_curso_periodo_ = New frm_lista_curso_periodo
            frm_lista_curso_periodo_.Show()
            frm_lista_curso_periodo_.MdiParent = Me
            frm_lista_curso_periodo_activo = True
        Else
            frm_lista_curso_periodo_.Activate()
        End If
    End Sub

    Private Sub men_inic_cambio_contrasenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_inic_cambio_contrasenia.Click
        If (Not frm_cambio_contrasenia_activo) Then
            frm_cambio_contrasenia_ = New frm_cambio_contrasenia
            frm_cambio_contrasenia_.Show()
            frm_cambio_contrasenia_.MdiParent = Me
            frm_cambio_contrasenia_activo = True
        Else
            frm_cambio_contrasenia_.Activate()
        End If
    End Sub

    Private Sub men_modif_fichalum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_modif_fichalum.Click
        If (Not frm_modificar_alumno_activo) Then
            frm_modificar_alumno_ = New frm_modificar_alumno
            frm_modificar_alumno_.Show()
            frm_modificar_alumno_.MdiParent = Me
            frm_modificar_alumno_activo = True
        Else
            frm_modificar_alumno_.Activate()
        End If
    End Sub

    Private Sub men_modif_fichaprofe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_modif_fichaprofe.Click
        If (Not frm_modificar_profesor_activo) Then
            frm_modificar_profesor_ = New frm_modificar_profesor
            frm_modificar_profesor_.Show()
            frm_modificar_profesor_.MdiParent = Me
            frm_modificar_profesor_activo = True
        Else
            frm_modificar_profesor_.Activate()
        End If
    End Sub

    Private Sub men_modif_mover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_modif_mover.Click
        If (Not frm_matricula_mover_activo) Then
            frm_matricula_mover_ = New frm_matricula_mover
            frm_matricula_mover_.Show()
            frm_matricula_mover_.MdiParent = Me
            frm_matricula_mover_activo = True
        Else
            frm_matricula_mover_.Activate()
        End If
    End Sub

    Private Sub men_adm_permisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_adm_permisos.Click
        If (Not frm_modificar_trabajador_activo) Then
            frm_modificar_trabajador_ = New frm_modificar_trabajador
            frm_modificar_trabajador_.Show()
            frm_modificar_trabajador_.MdiParent = Me
            frm_modificar_trabajador_activo = True
        Else
            frm_modificar_trabajador_.Activate()
        End If
    End Sub

    'Private Sub men_conf_separata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_conf_separata.Click
    '    If (Not frm_separata_activo) Then
    '        frm_separata_ = New frm_separata
    '        frm_separata_.Show()
    '        frm_separata_.MdiParent = Me
    '        frm_separata_activo = True
    '    Else
    '        frm_separata_.Activate()
    '    End If
    'End Sub

    Private Sub men_modif_matric_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_modif_matric.Click
        frm_matricula_examen.Show()
    End Sub

    Private Sub men_modif_notas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_notas.Show()
    End Sub

    Private Sub men_princ_caja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_princ_caja.Click
        Frm_caja.ShowDialog()
    End Sub

    Private Sub ModificarMatriculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_modificar_matricula.Click
        frm_actualizar_matricula.Show()
    End Sub

    Private Sub VentaSeparatasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_venta_sep.Click
        Frm_venta_separatas.Show()
    End Sub

    Private Sub ListaNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaNotasToolStripMenuItem.Click
        frm_lista_notas_alumno.ShowDialog()
    End Sub

    Private Sub ListaAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaAsistenciaToolStripMenuItem.Click
        frm_lista_alumno_asistencia.Show()
    End Sub

    Private Sub men_reg_notas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_reg_notas.Click
        frm_notas.Show()
    End Sub

    Private Sub CDSeparataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_cd_separata.Click
        frm_cd_separata.Show()
    End Sub
    Public Sub data()
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "\Data\Data.txt") Then
            Dim reader As New System.IO.StreamReader(Application.StartupPath + "\Data\Data.txt")
            frm_cd_separata.txtCD.Text = reader.ReadLine
            _precio_cd = Convert.ToDouble(frm_cd_separata.txtCD.Text)
            frm_cd_separata.TxtSeparata.Text = reader.ReadLine
            _precio_separata = Convert.ToDouble(frm_cd_separata.TxtSeparata.Text)
            reader.Close()
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\Data\Data.txt", frm_cd_separata.txtCD.Text & ControlChars.NewLine & _
        frm_cd_separata.TxtSeparata.Text & ControlChars.NewLine, False)
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "\Data\Impresora.txt") Then
            Dim reader As New System.IO.StreamReader(Application.StartupPath + "\Data\Impresora.txt")
            frm_impresora.TxtImpresora.Text = reader.ReadLine
            _impresora_a_usar = Convert.ToString(frm_impresora.TxtImpresora.Text)
            reader.Close()
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\Data\Impresora.txt", frm_impresora.TxtImpresora.Text & ControlChars.NewLine, False)
        End If

    End Sub

    Private Sub ListaMatriculasSeparadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaMatriculasSeparadasToolStripMenuItem.Click
        frm_lista_matricula_separada.Show()
    End Sub

    Private Sub ListaSeparatasVendidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaSeparatasVendidasToolStripMenuItem.Click
        frm_lista_alumnos_separatas.Show()
    End Sub

    Private Sub ImpresoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_impresora.Click
        frm_impresora.Show()
    End Sub

    Private Sub ListaDePagosPorAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDePagosPorAlumnoToolStripMenuItem.Click
        frm_lista_alumnos_pagos.Show()
    End Sub

    Private Sub VentaOtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_venta_otros.Click
        frm_ventas_otros.Show()
    End Sub

    Private Sub men_adm_reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_adm_reportes.Click
        Frm_Anulacion_Boletas.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Men_apertura_ciclos.Click
        If (Not frm_cursos_ofertados_activo) Then
            frm_cursos_ofertados_ = New frm_cursos_ofertados
            frm_cursos_ofertados_.Show()
            frm_cursos_ofertados_.MdiParent = Me
            frm_cursos_ofertados_activo = True
        Else
            frm_cursos_ofertados_.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Men_apertura_grupos.Click
        If (Not frm_curso_grupo_activo) Then
            frm_curso_grupo_ = New frm_curso_grupo
            frm_curso_grupo_.Show()
            frm_curso_grupo_.MdiParent = Me
            frm_curso_grupo_activo = True
        Else
            frm_curso_grupo_.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_mes_2.Click
        frm_mes.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_reg_alumnos.Click
        If (Not frm_ingreso_alumnos_activo) Then
            frm_ingreso_alumno_ = New frm_ingreso_alumnos
            frm_ingreso_alumno_.Show()
            frm_ingreso_alumno_.MdiParent = Me
            frm_ingreso_alumnos_activo = True
        Else
            frm_ingreso_alumno_.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_reg_docentes.Click
        If (Not frm_ingreso_profesores_activo) Then
            frm_ingreso_profesores_ = New frm_ingreso_profesores
            frm_ingreso_profesores_.Show()
            frm_ingreso_profesores_.MdiParent = Me
            frm_ingreso_profesores_activo = True
        Else
            frm_ingreso_alumno_.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_reg_trabajador.Click
        If (Not frm_ingreso_trabajadores_activo) Then
            frm_ingreso_trabajadores_ = New frm_ingreso_trabajadores
            frm_ingreso_trabajadores_.Show()
            frm_ingreso_trabajadores_.MdiParent = Me
            frm_ingreso_trabajadores_activo = True
            frm_ingreso_trabajadores_.Roles_super_usuario(Global_variables.trabajador.Trabajador_Super)
        Else
            frm_ingreso_trabajadores_.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_conf_aulas.Click
        If (Not frm_aula_activo) Then
            frm_aula_ = New frm_aula
            frm_aula_.Show()
            frm_aula_.MdiParent = Me
            frm_aula_activo = True
        Else
            frm_aula_.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_conf_cursos.Click
        If (Not frm_curso_activo) Then
            frm_curso_ = New frm_curso
            frm_curso_.Show()
            frm_curso_.MdiParent = Me
            frm_curso_activo = True
        Else
            frm_curso_.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_cur_plan_agregar.Click
        If (Not frm_curso_plan_est_activo) Then
            frm_curso_plan_est_ = New frm_curso_plan_est
            frm_curso_plan_est_.Show()
            frm_curso_plan_est_.MdiParent = Me
            frm_curso_plan_est_activo = True
        Else
            frm_curso_plan_est_.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_cur_plan_editar.Click
        If (Not frm_view_cursos_activo) Then
            frm_view_cursos_ = New frm_view_cursos
            frm_view_cursos_.Show()
            frm_view_cursos_.MdiParent = Me
            frm_view_cursos_activo = True
        Else
            frm_view_cursos_.Activate()
        End If
    End Sub

    Private Sub AnulacionDeMatriculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_anulacion_mat.Click
        frm_anulacion_matricula.Show()
    End Sub

    Private Sub men_mat_espera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_mat_espera.Click
        frm_modificar_matricula_espera.Show()
    End Sub
End Class
