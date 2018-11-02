Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_curso
    Private obj_n_curso As cls_n_curso
    Private obj_ln_curso As cls_ln_curso
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_curso As Integer
    Private curso As String
    Private abreviatura As Decimal

    Private Sub Cargar()
        id_curso = -1
        esta_agregando = False
        esta_editando = False
        obj_n_curso = New cls_n_curso
        obj_ln_curso = New cls_ln_curso
        txt_curso.Text = ""
        txt_abreviatura.Text = ""
        dg_curso.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_curso.Enabled = False
        txt_abreviatura.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_curso.DataSource = obj_ln_curso.List_Curso
        dg_curso.Columns(0).HeaderText = "Codigo"
        dg_curso.Columns(0).Visible = False
        dg_curso.Columns(0).Width = 20

        dg_curso.Columns(1).HeaderText = "Ciclo"
        dg_curso.Columns(1).Width = 130
        dg_curso.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_curso.Columns(2).HeaderText = "Abreviatura"
        dg_curso.Columns(2).Width = 65
        dg_curso.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_curso.List_Curso.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Borrar.Enabled = False
        End If
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If ((txt_curso.Text <> "") And (txt_abreviatura.Text <> "")) Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = 6) Then
                    obj_n_curso.Curso_Nombre = StrConv(txt_curso.Text, vbProperCase)
                    obj_n_curso.Curso_Abreviatura = UCase(txt_abreviatura.Text)
                    obj_ln_curso.Add_Curso(obj_n_curso)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar el Ciclo y la Abreviatura", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_curso.Focus()
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = 6) Then
                obj_n_curso.Curso_Codigo = id_curso
                obj_n_curso.Curso_Nombre = StrConv(txt_curso.Text, vbProperCase)
                obj_n_curso.Curso_Abreviatura = UCase(txt_abreviatura.Text)
                obj_ln_curso.Update_Curso(obj_n_curso)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_curso.Enabled = True
        txt_curso.Text = ""
        txt_curso.Focus()
        txt_abreviatura.Enabled = True
        txt_abreviatura.Text = ""
        dg_curso.Enabled = False
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

    Private Sub dg_curso_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_curso.CellContentClick, dg_curso.CellClick
        Dim i As Integer
        i = dg_curso.CurrentRow.Index
        id_curso = dg_curso.Item(0, i).Value
        txt_curso.Text = dg_curso.Item(1, i).Value.ToString
        txt_abreviatura.Text = dg_curso.Item(2, i).Value
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_curso <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_curso.Enabled = True
            txt_abreviatura.Enabled = True
            dg_curso.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir un Ciclo para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_curso <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                obj_n_curso.Curso_Codigo = id_curso
                obj_n_curso.Curso_Nombre = txt_curso.Text
                obj_n_curso.Curso_Abreviatura = txt_abreviatura.Text
                obj_ln_curso.Delete_Curso(obj_n_curso)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un Ciclo para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_curso_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_curso_activo = False
    End Sub
End Class