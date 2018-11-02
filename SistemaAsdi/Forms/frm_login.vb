Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_login
    Dim mensaje As String
    Dim id_persona As Integer

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        mensaje = ""
        If (txt_usuario.Text.Length = 0) Then
            mensaje = "Ingrese su Usuario"
            If (txt_contrasenia.Text.Length = 0) Then
                mensaje += " y su Contraseña"
            End If
        Else
            If (txt_contrasenia.Text.Length = 0) Then
                mensaje += "Ingrese su Contraseña"
            Else
                Dim obj_n_persona As New cls_n_persona
                Dim obj_ln_persona As New cls_ln_persona
                Dim obj_n_persona_anexo As New cls_n_persona_anexo
                Dim obj_ln_persona_anexo As New cls_ln_persona_anexo
                obj_n_persona.Persona_Usuario = Trim(txt_usuario.Text)
                obj_n_persona.Persona_Contrasenia = Trim(txt_contrasenia.Text)
                id_persona = obj_ln_persona.Login_Persona(obj_n_persona)
                If (id_persona <> 0) Then
                    Dim obj_ln_trabajador As New cls_ln_trabajador_ficha
                    Dim obj_n_trabajador As New cls_n_trabajador_ficha
                    Global_variables.trabajador = obj_ln_trabajador.Get_Trabajador(id_persona)
                    Global_variables.persona_trabajador = obj_ln_persona.Get_Persona(id_persona)
                    Global_variables.persona_anexo_trabajador = obj_ln_persona_anexo.Get_Persona_Anexo(id_persona)
                    Periodo_Actual()
                    frm_principal.load_informacion()
                    frm_principal.load_menu_usuario()
                Else
                    mensaje = "Error de usuario/constraseña"
                End If
            End If
        End If
        lbl_mensaje.Text = mensaje
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_mensaje.Text = ""
    End Sub

    Private Sub frm_login_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_login_activo = False
    End Sub

    Private Sub Periodo_Actual()
        Dim obj_ln_periodo As New cls_ln_periodo
        Dim obj_n_periodo As New cls_n_periodo
        Dim id_periodo As Integer = obj_ln_periodo.Actual_Periodo(obj_n_periodo)
        Select Case id_periodo
            Case 0
                MsgBox("No hay un periodo vigente", MsgBoxStyle.Exclamation, "Advertencia!!")
            Case Else
                obj_n_periodo.Periodo_Codigo = id_periodo
                Global_variables.periodo_sesion = obj_ln_periodo.Get_Periodo(obj_n_periodo)
                MsgBox("El periodo vigente es: " + Global_variables.periodo_sesion.Periodo_Nombre, MsgBoxStyle.Exclamation, "Advertencia!!")
                Me.Close()
        End Select
    End Sub
End Class
