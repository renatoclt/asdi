Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_tp_tramite
    Private obj_tp_tramite As cls_n_tp_tramite
    Private obj_ln_tp_tramite As cls_ln_tp_tramite
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_tp_tramite As Integer
    Private tp_tramite As String
    Private costo As Decimal

    Private Sub Cargar()
        id_tp_tramite = -1
        costo = 0.0
        esta_agregando = False
        esta_editando = False
        obj_tp_tramite = New cls_n_tp_tramite
        obj_ln_tp_tramite = New cls_ln_tp_tramite
        txt_tp_tramite.Text = ""
        txt_costo.Text = ""
        dg_tp_tramite.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_tp_tramite.Enabled = False
        txt_costo.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_tp_tramite.DataSource = obj_ln_tp_tramite.List_Tipo_Tramite
        dg_tp_tramite.Columns(0).HeaderText = "Codigo"
        dg_tp_tramite.Columns(0).Visible = False
        dg_tp_tramite.Columns(0).Width = 20

        dg_tp_tramite.Columns(1).HeaderText = "Tipo de Tramite"
        dg_tp_tramite.Columns(1).Width = 170
        dg_tp_tramite.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_tp_tramite.Columns(2).HeaderText = "Costo"
        dg_tp_tramite.Columns(2).Width = 60
        dg_tp_tramite.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_tp_tramite.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_tp_tramite.List_Tipo_Tramite.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Editar.Enabled = True
        End If
    End Sub

    Private Sub frm_tp_tramite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If (Trim(txt_tp_tramite.Text) <> "") Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = 6) Then
                    obj_tp_tramite.Tipo_Tramite_Nombre = txt_tp_tramite.Text
                    obj_tp_tramite.Tipo_Tramite_Costo = txt_costo.Text
                    obj_ln_tp_tramite.Add_Tipo_Tramite(obj_tp_tramite)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar el tipo de trámite", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_tp_tramite.Focus()
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = 6) Then
                obj_tp_tramite.Tipo_Tramite_Codgio = id_tp_tramite
                obj_tp_tramite.Tipo_Tramite_Nombre = txt_tp_tramite.Text
                obj_tp_tramite.Tipo_Tramite_Costo = txt_costo.Text
                obj_ln_tp_tramite.Update_Tipo_Tramite(obj_tp_tramite)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_tp_tramite.Enabled = True
        txt_tp_tramite.Text = ""
        txt_tp_tramite.Focus()
        txt_costo.Enabled = True
        txt_costo.Text = ""
        dg_tp_tramite.Enabled = False
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

    Private Sub dg_tp_tramite_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_tp_tramite.CellContentClick, dg_tp_tramite.CellClick
        Dim i As Integer
        i = dg_tp_tramite.CurrentRow.Index
        id_tp_tramite = dg_tp_tramite.Item(0, i).Value
        txt_tp_tramite.Text = dg_tp_tramite.Item(1, i).Value.ToString
        txt_costo.Text = dg_tp_tramite.Item(2, i).Value
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_tp_tramite <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_tp_tramite.Enabled = True
            txt_costo.Enabled = True
            dg_tp_tramite.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir un tipo de trámite para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_tp_tramite <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                obj_tp_tramite.Tipo_Tramite_Codgio = id_tp_tramite
                obj_tp_tramite.Tipo_Tramite_Nombre = txt_tp_tramite.Text
                obj_tp_tramite.Tipo_Tramite_Costo = txt_costo.Text
                obj_ln_tp_tramite.Delete_Tipo_Tramite(obj_tp_tramite)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un tipo de trámite para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_tp_tramite_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_tp_tramite_activo = False
    End Sub
End Class