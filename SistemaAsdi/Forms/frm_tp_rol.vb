Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_tp_rol
    Private obj_tp_rol As cls_n_tp_rol
    Private obj_ln_tp_rol As cls_ln_tp_rol
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_tp_rol As Integer
    Private tp_rol As String

    Private Sub Cargar()
        id_tp_rol = -1
        esta_agregando = False
        esta_editando = False
        obj_tp_rol = New cls_n_tp_rol
        obj_ln_tp_rol = New cls_ln_tp_rol
        txt_tp_rol.Text = ""
        dg_tp_rol.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_tp_rol.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_tp_rol.DataSource = obj_ln_tp_rol.List_Tipo_Rol
        dg_tp_rol.Columns(0).HeaderText = "Codigo"
        dg_tp_rol.Columns(0).Visible = False
        dg_tp_rol.Columns(0).Width = 20
        dg_tp_rol.Columns(1).HeaderText = "Roles"
        dg_tp_rol.Columns(1).Width = 200
        If (obj_ln_tp_rol.List_Tipo_Rol.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Borrar.Enabled = True
        End If
    End Sub

    Private Sub frm_tp_rol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If (txt_tp_rol.Text <> "") Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = 6) Then
                    obj_tp_rol.Tipo_Rol_Nombre = txt_tp_rol.Text
                    obj_ln_tp_rol.Add_Tipo_Rol(obj_tp_rol)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar el tipo de rol", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_tp_rol.Focus()
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = 6) Then
                obj_tp_rol.Tipo_Rol_Codigo = id_tp_rol
                obj_tp_rol.Tipo_Rol_Nombre = txt_tp_rol.Text
                obj_ln_tp_rol.Update_Tipo_Rol(obj_tp_rol)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_tp_rol.Enabled = True
        txt_tp_rol.Text = ""
        txt_tp_rol.Focus()
        dg_tp_rol.Enabled = False
        btn_Agregar.Enabled = False
        btn_Editar.Enabled = False
        btn_Borrar.Enabled = False
        btn_Cancelar.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub dg_tp_tramite_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_tp_rol.CellContentClick, dg_tp_rol.CellClick
        Dim i As Integer
        i = dg_tp_rol.CurrentRow.Index
        id_tp_rol = dg_tp_rol.Item(0, i).Value
        txt_tp_rol.Text = dg_tp_rol.Item(1, i).Value.ToString
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_tp_rol <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_tp_rol.Enabled = True
            dg_tp_rol.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir un tipo de rol para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_tp_rol <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                obj_tp_rol.Tipo_Rol_Codigo = id_tp_rol
                obj_tp_rol.Tipo_Rol_Nombre = txt_tp_rol.Text
                obj_ln_tp_rol.Delete_Tipo_Rol(obj_tp_rol)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un tipo de rol para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

End Class