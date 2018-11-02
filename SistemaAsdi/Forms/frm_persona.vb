Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_persona_profesor
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    '--------------Persona
    Private obj_n_persona As cls_n_persona
    Private obj_ln_persona As cls_ln_persona
    Private id_persona As Integer
    Private nombres As String
    Private apellido_paterno As String
    Private apellido_materno As String
    Private fecha_nacimiento As String  'verificar convertirlo a DATE para ser utilizado para obj
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

    Private Sub Cargar()
        id_persona = -1
        esta_agregando = False
        esta_editando = False
        obj_n_persona = New cls_n_persona
        obj_ln_persona = New cls_ln_persona
        obj_n_persona_anexo = New cls_n_persona_anexo
        obj_ln_persona_anexo = New cls_ln_persona_anexo
        obj_n_tp_documento = New cls_n_tp_documento
        obj_ln_tp_documento = New cls_ln_tp_documento
        txt_id_persona.Text = ""
        txt_nombres.Text = ""
        txt_ap_paterno.Text = ""
        txt_ap_materno.Text = ""
        txt_fch_nacimiento.Text = ""
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
        txt_nombre_mabre.Text = ""
        txt_contacto_emergencia.Text = ""
        txt_fono_emergencia.Text = ""
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        cbx_tp_documento.DataSource = obj_ln_tp_documento.List_Tipo_Documento
        cbx_tp_documento.DisplayMember = "Documento_Nombre"
        cbx_tp_documento.ValueMember = "Documento_Codigo"
    End Sub

    Private Sub frm_persona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub




End Class