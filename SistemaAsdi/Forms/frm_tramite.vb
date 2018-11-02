Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_tramite
    Private obj_n_tramite As cls_n_tramite
    Private obj_ln_tramite As cls_ln_tramite
    Private obj_ln_tp_tramite As cls_ln_tp_tramite
    Private id_tramite As Integer
    Private id_alumno_ficha As Integer
    Private fecha_creacion As DateTime
    Private id_tp_tramite As Integer
    Private entregado As Boolean
    Private frm_alumno_buscar_ As frm_alumno_buscar
    Public frm_alumno_buscar_activo As Boolean = False
    Private seleccionado_tipo_tramite As Boolean = False

    Private Sub Cargar()
        obj_n_tramite = New cls_n_tramite
        obj_ln_tramite = New cls_ln_tramite
        obj_ln_tp_tramite = New cls_ln_tp_tramite
        txt_codigo_tramite.Text = ""
        txt_nombre.Text = ""
        id_alumno_ficha = -1
        id_tp_tramite = -1
        dtp_fecha_creacion.Enabled = False
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = True
    End Sub

    Private Sub Cargar_Datos()
        cbx_tp_tramite.DataSource = obj_ln_tp_tramite.List_Tipo_Tramite
        cbx_tp_tramite.DisplayMember = "Tipo_Tramite_Nombre"
        cbx_tp_tramite.ValueMember = "Tipo_Tramite_Codgio"

        cbx_tp_tramite.SelectedItem = Nothing
    End Sub

    Public Sub Informacion(ByVal obj_alumno As cls_n_view_alumnos)
        frm_alumno_buscar_activo = False
        id_alumno_ficha = obj_alumno.View_Alumno_Codigo_Alumno
        txt_nombre.Text = obj_alumno.View_Alumno_Nombre
        entregado = False
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If (Not frm_alumno_buscar_activo) Then
            frm_alumno_buscar_ = New frm_alumno_buscar
            frm_alumno_buscar_.Show()
            frm_alumno_buscar_.Formnulario_Tramitar(Me, "frm_tramite")
            frm_alumno_buscar_activo = True
        Else
            frm_alumno_buscar_.Activate()
        End If
    End Sub

    Private Sub frm_tramite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
    End Sub

    Private Sub frm_tramite_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_tramite_activo = False
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (seleccionado_tipo_tramite And Trim(txt_nombre.Text).Length <> 0) Then
            Msg = MsgBox("Desea Guardar el Trámite?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = vbYes) Then
                obj_n_tramite.Tramite_Alumno_Codigo = id_alumno_ficha
                obj_n_tramite.Tramite_Fecha_Creacion = dtp_fecha_creacion.Value
                obj_n_tramite.Tramite_Tipo_Tramite = cbx_tp_tramite.SelectedValue
                obj_n_tramite.Tramite_Entregado = entregado
                obj_ln_tramite.Add_Tramite(obj_n_tramite)
            End If
            Me.Close()
        Else
            MsgBox("Debe seleccionar un tipo de trámite y un alumno", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub cbx_tp_tramite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_tp_tramite.SelectedIndexChanged
        If (seleccionado_tipo_tramite) Then
            btn_Guardar.Enabled = True
        End If
    End Sub

    Private Sub cbx_tp_tramite_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_tp_tramite.MouseClick
        seleccionado_tipo_tramite = True
    End Sub
End Class