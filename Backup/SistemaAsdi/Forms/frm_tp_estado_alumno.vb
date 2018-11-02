Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_tp_estado_alumno
    Private obj_tp_estado_alumno As cls_n_tp_estado_alumno
    Private obj_ln_tp_estado_alumno As cls_ln_tp_estado_alumno
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_tp_estado_alumno As Integer
    Private tp_estado_alumno As String

    Private Sub Cargar()
        id_tp_estado_alumno = -1
        esta_agregando = False
        esta_editando = False
        obj_tp_estado_alumno = New cls_n_tp_estado_alumno
        obj_ln_tp_estado_alumno = New cls_ln_tp_estado_alumno
        txt_tp_estado_alumno.Text = ""
        dg_tp_estado_alumno.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_tp_estado_alumno.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_tp_estado_alumno.DataSource = obj_ln_tp_estado_alumno.List_Tipo_Estado_Alumno
        dg_tp_estado_alumno.Columns(0).HeaderText = "Codigo"
        dg_tp_estado_alumno.Columns(0).Visible = False
        dg_tp_estado_alumno.Columns(0).Width = 20

        dg_tp_estado_alumno.Columns(1).HeaderText = "Estados del Alumno"
        dg_tp_estado_alumno.Columns(1).Width = 200
        dg_tp_estado_alumno.Columns(1).Width = dg_tp_estado_alumno.Width - 10
        dg_tp_estado_alumno.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_tp_estado_alumno.List_Tipo_Estado_Alumno.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Borrar.Enabled = True
        End If
    End Sub

    Private Sub frm_tp_estado_alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If (txt_tp_estado_alumno.Text <> "") Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = 6) Then
                    obj_tp_estado_alumno.Tipo_Estado_Alumno_Nombre = txt_tp_estado_alumno.Text
                    obj_ln_tp_estado_alumno.Add_Tipo_Estado_Alumno(obj_tp_estado_alumno)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar el estado del Alumno", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_tp_estado_alumno.Focus()
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = 6) Then
                obj_tp_estado_alumno.Tipo_Estado_Alumno_Codigo = id_tp_estado_alumno
                obj_tp_estado_alumno.Tipo_Estado_Alumno_Nombre = txt_tp_estado_alumno.Text
                obj_ln_tp_estado_alumno.Update_Tipo_Estado_Alumno(obj_tp_estado_alumno)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_tp_estado_alumno.Enabled = True
        txt_tp_estado_alumno.Text = ""
        txt_tp_estado_alumno.Focus()
        dg_tp_estado_alumno.Enabled = False
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

    Private Sub dg_tp_tramite_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_tp_estado_alumno.CellContentClick, dg_tp_estado_alumno.CellClick
        Dim i As Integer
        i = dg_tp_estado_alumno.CurrentRow.Index
        id_tp_estado_alumno = dg_tp_estado_alumno.Item(0, i).Value
        txt_tp_estado_alumno.Text = dg_tp_estado_alumno.Item(1, i).Value.ToString
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_tp_estado_alumno <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_tp_estado_alumno.Enabled = True
            dg_tp_estado_alumno.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir un estado del alumno para editar para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_tp_estado_alumno <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                obj_tp_estado_alumno.Tipo_Estado_Alumno_Codigo = id_tp_estado_alumno
                obj_tp_estado_alumno.Tipo_Estado_Alumno_Nombre = txt_tp_estado_alumno.Text
                obj_ln_tp_estado_alumno.Delete_Tipo_Estado_Alumno(obj_tp_estado_alumno)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un estado del alumno para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_tp_estado_alumno_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_tp_estado_alumno_activo = False
    End Sub
End Class