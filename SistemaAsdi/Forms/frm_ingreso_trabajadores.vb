Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_ingreso_trabajadores
    Private fecha_validad As Boolean

    '--------------Persona
    Private obj_n_persona As cls_n_persona
    Private obj_ln_persona As cls_ln_persona
    Private id_persona As Integer
    Private nombres As String
    Private apellido_paterno As String
    Private apellido_materno As String
    Private fecha_nacimiento As Date  'verificar convertirlo a DATE para ser utilizado para obj
    Private id_tp_documento As Integer
    Private nro_documento As String
    Private usuario As String
    Private contrasenia As String
    Private correo_institucional As String
    Private correo_personal As String
    Private telefono_fijo As String
    Private telefono_celular As String
    Private direccion As String
    Private sexo As Char
    Private tipo As Char

    '------ Persona Anexo
    Private obj_n_persona_anexo As cls_n_persona_anexo
    Private obj_ln_persona_anexo As cls_ln_persona_anexo
    Private lugar_nacimiento As String
    Private nombre_padre As String
    Private nombre_madre As String
    Private contacto_emergencia As String
    Private telefono_emergencia As String

    '------ Tp Documento
    Private obj_n_tp_documento As cls_n_tp_documento
    Private obj_ln_tp_documento As cls_ln_tp_documento

    '------ Trabajador
    Private obj_n_trabajador As cls_n_trabajador_ficha
    Private obj_ln_trabajador As cls_ln_trabajador_ficha
    Private id_trabajador As Integer
    Private activo As Boolean
    Private tramite As Boolean
    Private caja As Boolean
    Private notas As Boolean
    Private matriculas As Boolean
    Private boletas As Boolean
    Private adminitrador As Boolean
    Private super As Boolean

    Private esta_agregando As Boolean = False
    Private esta_editando As Boolean = False

    Private frm_modificar_trabajador_ As frm_modificar_trabajador

    Public Sub Modificar(ByVal id_persona_ As Integer, ByVal frm As frm_modificar_trabajador)
        frm_modificar_trabajador_ = New frm_modificar_trabajador
        frm_modificar_trabajador_ = frm
        esta_agregando = False
        esta_editando = True
        Cargar()
        Cargar_datos()
        obj_n_persona = obj_ln_persona.Get_Persona(id_persona_)
        obj_n_persona_anexo = obj_ln_persona_anexo.Get_Persona_Anexo(id_persona_)
        obj_n_trabajador = obj_ln_trabajador.Get_Trabajador(id_persona_)
        id_persona = obj_n_persona.Persona_Codigo
        txt_id_persona.Text = obj_n_persona.Persona_Codigo
        txt_nombres.Text = obj_n_persona.Persona_Nombres
        txt_ap_paterno.Text = obj_n_persona.Persona_Apellido_Paterno
        txt_ap_materno.Text = obj_n_persona.Persona_Apellido_Materno
        dtp_fch_nacimiento.Value = obj_n_persona.Persona_Fecha_Nacimiento
        txt_nro_documento.Text = obj_n_persona.Persona_Nro_Documento
        txt_usuario.Text = obj_n_persona.Persona_Usuario
        txt_contraseña.Text = obj_n_persona.Persona_Contrasenia
        txt_correo_institucional.Text = obj_n_persona.Persona_Correo_Institucional
        txt_correo_personal.Text = obj_n_persona.Persona_Correo_Personal
        txt_fono_fijo.Text = obj_n_persona.Persona_Telefono_Fijo
        txt_fono_celular.Text = obj_n_persona.Persona_Telefono_Celular
        txt_direccion.Text = obj_n_persona.Persona_Direccion
        If (Not String.Compare(obj_n_persona.Persona_Sexo, "M")) Then
            rdb_masculino.Checked = True
            rdb_femenino.Checked = False
        Else
            rdb_masculino.Checked = False
            rdb_femenino.Checked = True
        End If
        txt_lugar_nacimiento.Text = obj_n_persona_anexo.Persona_Anexo_Lugar_Nacimiento
        txt_nombre_padre.Text = obj_n_persona_anexo.Persona_Anexo_Nombre_Padre
        txt_nombre_madre.Text = obj_n_persona_anexo.Persona_Anexo_Nombre_Padre
        txt_contacto_emergencia.Text = obj_n_persona_anexo.Persona_Anexo_Contacto_Emergencia
        txt_fono_emergencia.Text = obj_n_persona_anexo.Persona_Anexo_Telefono_Emergencia
        cbx_tp_documento.Text = obj_ln_tp_documento.Get_Tipo_Documento(obj_n_persona.Persona_Id_Tp_Documento).Documento_Nombre
        If (obj_n_trabajador.Trabajador_Activo) Then rdb_si.Checked = True
        If (Not obj_n_trabajador.Trabajador_Activo) Then rdb_no.Checked = True
        chk_tramites.Checked = obj_n_trabajador.Trabajador_Tramite
        chk_caja.Checked = obj_n_trabajador.Trabajador_Caja
        chk_matriculas.Checked = obj_n_trabajador.Trabajador_Matriculas
        chk_notas.Checked = obj_n_trabajador.Trabajador_Notas
        chk_recibos.Checked = obj_n_trabajador.Trabajador_Boletas
        chk_super.Checked = obj_n_trabajador.Trabajador_Super
        chk_administrador.Checked = obj_n_trabajador.Trabajador_Administrador
    End Sub

    Private Sub Cargar()
        id_persona = -1
        obj_n_persona = New cls_n_persona
        obj_ln_persona = New cls_ln_persona
        obj_n_persona_anexo = New cls_n_persona_anexo
        obj_ln_persona_anexo = New cls_ln_persona_anexo
        obj_n_tp_documento = New cls_n_tp_documento
        obj_ln_tp_documento = New cls_ln_tp_documento
        obj_n_trabajador = New cls_n_trabajador_ficha
        obj_ln_trabajador = New cls_ln_trabajador_ficha
        txt_id_persona.Text = ""
        txt_nombres.Text = ""
        txt_ap_paterno.Text = ""
        txt_ap_materno.Text = ""
        fecha_validad = False
        txt_nro_documento.Text = ""
        txt_usuario.Text = ""
        txt_contraseña.Text = ""
        txt_correo_institucional.Text = ""
        txt_correo_personal.Text = ""
        txt_fono_fijo.Text = ""
        txt_fono_celular.Text = ""
        txt_direccion.Text = ""
        txt_lugar_nacimiento.Text = ""
        txt_nombre_padre.Text = ""
        txt_nombre_madre.Text = ""
        txt_contacto_emergencia.Text = ""
        txt_fono_emergencia.Text = ""
        btn_Guardar.Enabled = True
        btn_Cancelar.Enabled = True
        rdb_masculino.Select()
        sexo = "M"
        rdb_no.Select()
        activo = False
        chk_administrador.Enabled = False
        chk_super.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        cbx_tp_documento.DataSource = obj_ln_tp_documento.List_Tipo_Documento
        cbx_tp_documento.DisplayMember = "Documento_Nombre"
        cbx_tp_documento.ValueMember = "Documento_Codigo"
    End Sub

    Private Sub frm_ingreso_trabajadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
        esta_agregando = True
        esta_editando = False
    End Sub

    Private Sub Obtener()
        '---- persona
        nombres = StrConv(Trim(txt_nombres.Text), vbProperCase)
        apellido_paterno = StrConv(Trim(txt_ap_paterno.Text), vbProperCase)
        apellido_materno = StrConv(Trim(txt_ap_materno.Text), vbProperCase)
        fecha_nacimiento = dtp_fch_nacimiento.Value
        'para el combox
        obj_n_tp_documento = cbx_tp_documento.SelectedItem

        id_tp_documento = obj_n_tp_documento.Documento_Codigo
        nro_documento = Trim(txt_nro_documento.Text)
        usuario = Trim(txt_usuario.Text)
        contrasenia = Trim(txt_contraseña.Text)
        correo_institucional = LCase(txt_correo_institucional.Text)
        correo_personal = LCase(txt_correo_personal.Text)
        telefono_fijo = Trim(txt_fono_fijo.Text)
        telefono_celular = Trim(txt_fono_celular.Text)
        direccion = StrConv(Trim(txt_direccion.Text), vbProperCase)
        tipo = "T" 'Trabajador
        '--- persona anexo
        lugar_nacimiento = StrConv(Trim(txt_lugar_nacimiento.Text), vbProperCase)
        nombre_padre = StrConv(Trim(txt_nombre_padre.Text), vbProperCase)
        nombre_madre = StrConv(Trim(txt_nombre_madre.Text), vbProperCase)
        contacto_emergencia = StrConv(Trim(txt_contacto_emergencia.Text), vbProperCase)
        telefono_emergencia = Trim(txt_fono_emergencia.Text)
        '--- trabajador
        tramite = chk_tramites.Checked
        caja = chk_caja.Checked
        notas = chk_notas.Checked
        matriculas = chk_matriculas.Checked
        boletas = chk_recibos.Checked
        adminitrador = chk_administrador.Checked
        super = chk_super.Checked
        If (rdb_no.Checked) Then activo = False
        If (rdb_si.Checked) Then activo = True
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click, btn_guardar_1.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If ((txt_nombres.Text <> "") And (txt_ap_paterno.Text <> "") And (txt_ap_materno.Text <> "")) Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                Obtener()
                If (Msg = 6) Then
                    '------- insertar en persona
                    obj_n_persona.Persona_Codigo = id_persona
                    obj_n_persona.Persona_Nombres = nombres
                    obj_n_persona.Persona_Apellido_Paterno = apellido_paterno
                    obj_n_persona.Persona_Apellido_Materno = apellido_materno
                    obj_n_persona.Persona_Fecha_Nacimiento = fecha_nacimiento
                    obj_n_persona.Persona_Id_Tp_Documento = id_tp_documento
                    obj_n_persona.Persona_Nro_Documento = nro_documento
                    If (usuario.Length = 0) Then
                        usuario = nro_documento
                    End If
                    obj_n_persona.Persona_Usuario = usuario
                    If (contrasenia.Length = 0) Then
                        contrasenia = "Abc123"
                    End If
                    obj_n_persona.Persona_Contrasenia = contrasenia
                    obj_n_persona.Persona_Correo_Institucional = correo_institucional
                    obj_n_persona.Persona_Correo_Personal = correo_personal
                    obj_n_persona.Persona_Telefono_Fijo = telefono_fijo
                    obj_n_persona.Persona_Telefono_Celular = telefono_celular
                    obj_n_persona.Persona_Direccion = direccion
                    obj_n_persona.Persona_Sexo = sexo
                    obj_n_persona.Persona_Tipo = tipo
                    obj_ln_persona.Add_Persona(obj_n_persona)
                    id_persona = obj_n_persona.Persona_Codigo

                    '------- insertar en persona anexo
                    obj_n_persona_anexo.Persona_Anexo_Persona_Codigo = id_persona
                    obj_n_persona_anexo.Persona_Anexo_Lugar_Nacimiento = lugar_nacimiento
                    obj_n_persona_anexo.Persona_Anexo_Nombre_Padre = nombre_padre
                    obj_n_persona_anexo.Persona_Anexo_Nombre_Madre = nombre_madre
                    obj_n_persona_anexo.Persona_Anexo_Contacto_Emergencia = contacto_emergencia
                    obj_n_persona_anexo.Persona_Anexo_Telefono_Emergencia = telefono_emergencia
                    obj_ln_persona_anexo.Update_Persona_Anexo(obj_n_persona_anexo)

                    '------- insertar en trabajador
                    obj_n_trabajador.Trabajador_Persona_Codigo = id_persona
                    obj_n_trabajador.Trabajador_Activo = activo
                    obj_n_trabajador.Trabajador_Administrador = adminitrador
                    obj_n_trabajador.Trabajador_Caja = caja
                    obj_n_trabajador.Trabajador_Matriculas = matriculas
                    obj_n_trabajador.Trabajador_Notas = notas
                    obj_n_trabajador.Trabajador_Super = super
                    obj_n_trabajador.Trabajador_Tramite = tramite
                    obj_n_trabajador.Trabajador_Boletas = boletas
                    obj_ln_trabajador.Add_Trabajador(obj_n_trabajador)

                    Me.Close()
                End If
            Else
                MsgBox("Debe llenar la Información requerida (*) ", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_nombres.Focus()
            End If
        End If
        If (esta_editando) Then
            If ((txt_nombres.Text <> "") And (txt_ap_paterno.Text <> "") And (txt_ap_materno.Text <> "")) Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                Obtener()
                If (Msg = 6) Then
                    '------- insertar en persona
                    obj_n_persona.Persona_Codigo = id_persona
                    obj_n_persona.Persona_Nombres = nombres
                    obj_n_persona.Persona_Apellido_Paterno = apellido_paterno
                    obj_n_persona.Persona_Apellido_Materno = apellido_materno
                    obj_n_persona.Persona_Fecha_Nacimiento = fecha_nacimiento
                    obj_n_persona.Persona_Id_Tp_Documento = id_tp_documento
                    obj_n_persona.Persona_Nro_Documento = nro_documento
                    If (usuario.Length = 0) Then
                        usuario = nro_documento
                    End If
                    obj_n_persona.Persona_Usuario = usuario
                    If (contrasenia.Length = 0) Then
                        contrasenia = "Abc123"
                    End If
                    obj_n_persona.Persona_Contrasenia = contrasenia
                    obj_n_persona.Persona_Correo_Institucional = correo_institucional
                    obj_n_persona.Persona_Correo_Personal = correo_personal
                    obj_n_persona.Persona_Telefono_Fijo = telefono_fijo
                    obj_n_persona.Persona_Telefono_Celular = telefono_celular
                    obj_n_persona.Persona_Direccion = direccion
                    obj_n_persona.Persona_Sexo = sexo
                    obj_n_persona.Persona_Tipo = tipo
                    obj_ln_persona.Update_Persona(obj_n_persona)
                    id_persona = obj_n_persona.Persona_Codigo

                    '------- insertar en persona anexo
                    obj_n_persona_anexo.Persona_Anexo_Persona_Codigo = id_persona
                    obj_n_persona_anexo.Persona_Anexo_Lugar_Nacimiento = lugar_nacimiento
                    obj_n_persona_anexo.Persona_Anexo_Nombre_Padre = nombre_padre
                    obj_n_persona_anexo.Persona_Anexo_Nombre_Madre = nombre_madre
                    obj_n_persona_anexo.Persona_Anexo_Contacto_Emergencia = contacto_emergencia
                    obj_n_persona_anexo.Persona_Anexo_Telefono_Emergencia = telefono_emergencia
                    obj_ln_persona_anexo.Update_Persona_Anexo(obj_n_persona_anexo)

                    '------- insertar en trabajador
                    obj_n_trabajador.Trabajador_Persona_Codigo = id_persona
                    obj_n_trabajador.Trabajador_Activo = activo
                    obj_n_trabajador.Trabajador_Administrador = adminitrador
                    obj_n_trabajador.Trabajador_Caja = caja
                    obj_n_trabajador.Trabajador_Matriculas = matriculas
                    obj_n_trabajador.Trabajador_Notas = notas
                    obj_n_trabajador.Trabajador_Super = super
                    obj_n_trabajador.Trabajador_Tramite = tramite
                    obj_n_trabajador.Trabajador_Boletas = boletas
                    obj_ln_trabajador.Update_Trabajador(obj_n_trabajador)

                    frm_modificar_trabajador_.frm_ingreso_trabajadores_activo = False
                    Me.Close()
                End If
            Else
                MsgBox("Debe llenar la Información requerida (*) ", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_nombres.Focus()
            End If
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click, btn_cancelar_1.Click
        Cargar()
        Cargar_datos()
        Me.Close()
    End Sub

    Private Sub dtp_fch_nacimineto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fch_nacimiento.ValueChanged
        fecha_validad = True
    End Sub

    Private Sub frm_ingreso_trabajores_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_ingreso_trabajadores_activo = False
    End Sub

    Private Sub rdb_masculino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_masculino.CheckedChanged
        sexo = "M"
    End Sub

    Private Sub rdb_femenino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_femenino.CheckedChanged
        sexo = "F"
    End Sub

    Private Sub rdb_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_si.CheckedChanged
        activo = True
    End Sub

    Private Sub rdb_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_no.CheckedChanged
        activo = False
    End Sub

    Public Sub Roles_super_usuario(ByVal activo As Boolean)
        chk_administrador.Enabled = activo
        chk_super.Enabled = activo
    End Sub
End Class