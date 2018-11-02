Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_curso_plan_est
    Private obj_n_plan_est As cls_n_plan_estudio
    Private obj_ln_plan_est As cls_ln_plan_estudio
    Private obj_n_view_cursos As cls_n_curso_pertenece
    Private obj_ln_view_cursos As cls_ln_curso_pertenece
    Private obj_n_curso_plan_est As cls_n_curso_plan_est
    Private obj_ln_curso_plan_est As cls_ln_curso_plan_est
    Private id_plan_est As Integer
    Private id_curso As Integer
    Private order As Integer
    Private seleccionado As Boolean = False
    Private pertenece As Boolean

    Private Sub Cargar()
        obj_n_plan_est = New cls_n_plan_estudio
        obj_ln_plan_est = New cls_ln_plan_estudio
        obj_ln_view_cursos = New cls_ln_curso_pertenece
        btn_Cancelar.Enabled = False
        btn_Guardar.Enabled = False
        chk_list_cursos.Enabled = False
    End Sub

    Private Sub Cargar_Datos()
        cbx_plan_est.DataSource = obj_ln_plan_est.List_Plan_Estudio
        cbx_plan_est.DisplayMember = "Plan_Nombre"
        cbx_plan_est.ValueMember = "Plan_Codigo"
        cbx_plan_est.SelectedItem = Nothing

        For Each obj As cls_n_curso_pertenece In obj_ln_view_cursos.Buscar_View_Cursos()
            chk_list_cursos.Items.Add(obj.Curso_Pertenece_Nombre, obj.Curso_Pertenece_Pertenece)
        Next
    End Sub

    Private Sub frm_curso_plan_est_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
        seleccionado = True
    End Sub

    Private Sub cbx_plan_est_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plan_est.SelectedIndexChanged
        If (seleccionado) Then
            chk_list_cursos.Items.Clear()
            obj_n_plan_est = cbx_plan_est.SelectedItem
            id_plan_est = obj_n_plan_est.Plan_Codigo

            For Each obj As cls_n_curso_pertenece In obj_ln_view_cursos.Buscar_View_Cursos(id_plan_est)
                chk_list_cursos.Items.Add(obj.Curso_Pertenece_Nombre, obj.Curso_Pertenece_Pertenece)
            Next

            chk_list_cursos.Enabled = True
            btn_Guardar.Enabled = True
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (seleccionado) Then
            Msg = MsgBox("Desea Guardar el los Cursos?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = vbYes) Then
                obj_n_plan_est = cbx_plan_est.SelectedItem
                id_plan_est = obj_n_plan_est.Plan_Codigo

                For i = 0 To chk_list_cursos.Items.Count - 1
                    obj_n_view_cursos = New cls_n_curso_pertenece
                    obj_n_view_cursos = obj_ln_view_cursos.Buscar_View_Cursos().Item(i)

                    obj_n_curso_plan_est = New cls_n_curso_plan_est
                    obj_n_curso_plan_est.Curso_Plan_Codigo_Curso = obj_n_view_cursos.Curso_Pertenece_Codigo
                    obj_n_curso_plan_est.Curso_Plan_Codigo_Plan = id_plan_est
                    pertenece = chk_list_cursos.GetItemChecked(i)

                    obj_ln_curso_plan_est = New cls_ln_curso_plan_est
                    obj_ln_curso_plan_est.Update_Curso_Plan_Est(obj_n_curso_plan_est, pertenece)
                Next
                Me.Close()
            End If
        Else
            MsgBox("Debe seleccionar un plan de estudios", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_curso_plan_est_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_curso_plan_est_activo = False
    End Sub
End Class