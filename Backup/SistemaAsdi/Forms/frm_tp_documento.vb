Imports System.Configuration
Imports Negocio
Imports LogicaNegocios


Public Class frm_tp_documento
    Private obj_n_tp_documento As cls_n_tp_documento
    Private obj_ln_tp_documento As cls_ln_tp_documento
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_tp_documento As Integer
    Private tp_documento As String

    Private Sub Cargar()
        id_tp_documento = -1
        esta_agregando = False
        esta_editando = False
        obj_n_tp_documento = New cls_n_tp_documento
        obj_ln_tp_documento = New cls_ln_tp_documento
        txt_tp_documento.Text = ""
        dg_tp_documento.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_tp_documento.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_tp_documento.DataSource = obj_ln_tp_documento.List_Tipo_Documento
        dg_tp_documento.Columns(0).HeaderText = "Codigo"
        dg_tp_documento.Columns(0).Visible = False

        dg_tp_documento.Columns(1).HeaderText = "Documento"
        dg_tp_documento.Columns(1).Width = dg_tp_documento.Width - 10
        dg_tp_documento.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_tp_documento.List_Tipo_Documento.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Borrar.Enabled = True
        End If
    End Sub

    Private Sub frm_tp_documento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If (txt_tp_documento.Text <> "") Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = 6) Then
                    obj_n_tp_documento.Documento_Nombre = txt_tp_documento.Text
                    obj_ln_tp_documento.Add_Tipo_Documento(obj_n_tp_documento)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar el Tipo de Documento", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_tp_documento.Focus()
            End If
        End If
        If (esta_editando) Then
            obj_n_tp_documento.Documento_Nombre = txt_tp_documento.Text
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = 6) Then
                obj_n_tp_documento.Documento_Nombre = txt_tp_documento.Text
                obj_n_tp_documento.Documento_Codigo = id_tp_documento
                obj_ln_tp_documento.Update_Tipo_Documento(obj_n_tp_documento)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_tp_documento.Enabled = True
        txt_tp_documento.Text = ""
        btn_Agregar.Enabled = False
        btn_Editar.Enabled = False
        btn_Borrar.Enabled = False
        btn_Cancelar.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Cargar()
    End Sub

    Private Sub dg_tp_documento_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_tp_documento.CellContentClick, dg_tp_documento.CellClick
        Dim i As Integer
        i = dg_tp_documento.CurrentRow.Index
        tp_documento = dg_tp_documento.Item(1, i).Value.ToString
        id_tp_documento = dg_tp_documento.Item(0, i).Value
        txt_tp_documento.Text = tp_documento
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_tp_documento <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_tp_documento.Enabled = True
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir un documento para editar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_tp_documento <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                obj_n_tp_documento.Documento_Nombre = txt_tp_documento.Text
                obj_n_tp_documento.Documento_Codigo = id_tp_documento
                obj_ln_tp_documento.Delete_Tipo_Documento(obj_n_tp_documento)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un documento para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_tp_documento_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_tp_documento_activo = False
    End Sub
End Class