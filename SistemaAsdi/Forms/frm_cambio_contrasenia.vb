Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_cambio_contrasenia
    Dim contrasenia As String
    Dim mensaje As String = ""

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        If (Trim(txt_constrasenia.Text).Length <> 0) Then
            If (Trim(txt_constrasenia.Text) = Trim(txt_contrasenia_repetir.Text)) Then
                contrasenia = Trim(txt_constrasenia.Text)
                Dim obj_ln_persona As New cls_ln_persona
                Global_variables.persona_trabajador.Persona_Contrasenia = contrasenia
                obj_ln_persona.Update_Persona(Global_variables.persona_trabajador)
                MsgBox("Se cambio exitosamente la contraseña", MsgBoxStyle.Information, "Cambio de Contraseña")
                Me.Close()
            Else
                mensaje = "Las contraseñas no son iguales"
            End If
        Else
            mensaje = "Ingrese una nueva contraseña"
        End If
        lbl_mensaje.Text = mensaje
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_cambio_constrasenia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_mensaje.Text = mensaje
        lbl_usuario.Text = Global_variables.persona_trabajador.Persona_Usuario
    End Sub

    Private Sub frm_cambio_contrasenia_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_cambio_contrasenia_activo = False
    End Sub
End Class