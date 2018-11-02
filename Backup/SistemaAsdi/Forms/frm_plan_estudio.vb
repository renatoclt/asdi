Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_plan_estudio

    Private obj_plan_estudio As cls_n_plan_estudio
    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_plan_est As Integer
    Private plan_estudio As String

    Private Sub Cargar()
        id_plan_est = -1
        esta_agregando = False
        esta_editando = False
        obj_plan_estudio = New cls_n_plan_estudio
        obj_ln_plan_estudio = New cls_ln_plan_estudio
        txt_plan_estudio.Text = ""
        dg_plan_estudio.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_plan_estudio.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_plan_estudio.DataSource = obj_ln_plan_estudio.List_Plan_Estudio
        dg_plan_estudio.Columns(0).HeaderText = "Codigo"
        dg_plan_estudio.Columns(0).Visible = False
        dg_plan_estudio.Columns(0).Width = 20

        dg_plan_estudio.Columns(1).HeaderText = "Plan de Estudios"
        dg_plan_estudio.Columns(1).Width = 150
        dg_plan_estudio.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_plan_estudio.List_Plan_Estudio.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Editar.Enabled = True
        End If
    End Sub

    Private Sub frm_plan_estudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If (txt_plan_estudio.Text <> "") Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = 6) Then
                    obj_plan_estudio.Plan_Nombre = txt_plan_estudio.Text
                    obj_ln_plan_estudio.Add_Plan_Estudio(obj_plan_estudio)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar el plan de estudios", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_plan_estudio.Focus()
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = 6) Then
                obj_plan_estudio.Plan_Codigo = id_plan_est
                obj_plan_estudio.Plan_Nombre = txt_plan_estudio.Text
                obj_ln_plan_estudio.Update_Plan_Estudio(obj_plan_estudio)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_plan_estudio.Enabled = True
        txt_plan_estudio.Text = ""
        txt_plan_estudio.Focus()
        dg_plan_estudio.Enabled = False
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

    Private Sub dg_plan_estudio_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_plan_estudio.CellContentClick, dg_plan_estudio.CellClick
        Dim i As Integer
        i = dg_plan_estudio.CurrentRow.Index
        id_plan_est = dg_plan_estudio.Item(0, i).Value
        txt_plan_estudio.Text = dg_plan_estudio.Item(1, i).Value.ToString
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_plan_est <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_plan_estudio.Enabled = True
            dg_plan_estudio.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir un Plan de estudios para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_plan_est <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                obj_plan_estudio.Plan_Codigo = id_plan_est
                obj_plan_estudio.Plan_Nombre = txt_plan_estudio.Text
                obj_ln_plan_estudio.Delete_Plan_Estudio(obj_plan_estudio)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un Plan de estudios para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_plan_estudio_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_plan_estudio_activo = False
    End Sub
End Class