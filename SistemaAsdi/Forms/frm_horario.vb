Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_horario
    Private obj_n_horario As cls_n_horario
    Private obj_ln_horario As cls_ln_horario
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_horario As Integer
    Private horario As String
    Private costo As Decimal
    Dim obj As New Cls_Horario


    Private Sub Cargar()
        id_horario = -1
        esta_agregando = False
        esta_editando = False
        obj_n_horario = New cls_n_horario
        obj_ln_horario = New cls_ln_horario
        txt_horario.Text = ""
        txt_costo.Text = ""
        dg_horario.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_horario.Enabled = False
        txt_costo.Enabled = False
        Cb_Plan_Est.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_horario.DataSource = obj_ln_horario.List_Horario
        dg_horario.Columns(0).HeaderText = "Codigo"
        dg_horario.Columns(0).Visible = False
        dg_horario.Columns(0).Width = 20

        dg_horario.Columns(1).HeaderText = "Horario"
        dg_horario.Columns(1).Width = 130
        dg_horario.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_horario.Columns(2).HeaderText = "Costo"
        dg_horario.Columns(2).Width = 60
        dg_horario.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_horario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_horario.Columns(3).HeaderText = "Plan Estudios"
        dg_horario.Columns(3).Width = 80
        dg_horario.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_horario.Columns(4).HeaderText = "ID Plan Estudios"
        dg_horario.Columns(4).Visible = False
        dg_horario.Columns(4).Width = 20

        If (obj_ln_horario.List_Horario.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Borrar.Enabled = True
        End If
    End Sub

    Private Sub frm_horario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_plan_estudio(Cb_Plan_Est)
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If ((txt_horario.Text <> "") And (txt_costo.Text <> "")) Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = 6) Then
                    obj_n_horario.Horario_Nombre = txt_horario.Text
                    obj_n_horario.Horario_Costo = txt_costo.Text
                    obj_n_horario.Horario_Id_Plan_Est = Cb_Plan_Est.SelectedValue
                    obj_ln_horario.Add_Horario(obj_n_horario)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar el Horario, y Costo", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_horario.Focus()
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = 6) Then
                obj_n_horario.Horario_Codigo = id_horario
                obj_n_horario.Horario_Nombre = txt_horario.Text
                obj_n_horario.Horario_Costo = txt_costo.Text
                obj_n_horario.Horario_Id_Plan_Est = Cb_Plan_Est.SelectedValue
                obj_ln_horario.Update_Horario(obj_n_horario)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_horario.Enabled = True
        txt_horario.Text = ""
        txt_costo.Enabled = True
        txt_costo.Text = ""
        Cb_Plan_Est.Enabled = True
        dg_horario.Enabled = False
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

    Private Sub dg_horario_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_horario.CellContentClick, dg_horario.CellClick
        Dim i As Integer
        i = dg_horario.CurrentRow.Index
        id_horario = dg_horario.Item(0, i).Value
        txt_horario.Text = dg_horario.Item(1, i).Value.ToString
        txt_costo.Text = dg_horario.Item(2, i).Value

    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_horario <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_horario.Enabled = True
            txt_costo.Enabled = True
            Cb_Plan_Est.Enabled = True
            dg_horario.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir un horario para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_horario <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                obj_n_horario.Horario_Codigo = id_horario
                obj_n_horario.Horario_Nombre = txt_horario.Text
                obj_n_horario.Horario_Costo = txt_costo.Text
                obj_ln_horario.Delete_Horario(obj_n_horario)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un horario para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_horario_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_horario_activo = False
    End Sub

End Class
