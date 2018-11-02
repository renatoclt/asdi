Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_separata
    Private obj_n_separata_curso As cls_n_view_separata_curso
    Private obj_ln_separata_curso As cls_ln_view_separata_curso
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_separata As Integer
    Private id_curso As Integer
    Private curso As String
    Private separata As String
    Private costo As Decimal
    Private activo As Boolean
    Dim obj As New Cls_Separata

    Private Sub Cargar()
        id_separata = -1
        id_curso = -1
        esta_agregando = False
        esta_editando = False
        obj_ln_separata_curso = New cls_ln_view_separata_curso
        txt_curso.Text = ""
        txt_separata.Text = ""
        txt_costo.Text = ""
        dg_separata.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_separata.Enabled = False
        txt_costo.Enabled = False
        chk_activo.Checked = False
        chk_activo.Enabled = False
        CbCurso.Visible = False
    End Sub

    Private Sub Cargar_Datos()
        dg_separata.DataSource = obj_ln_separata_curso.List_Separata_Curso
        dg_separata.Columns(0).HeaderText = "Codigo separata"
        dg_separata.Columns(0).Visible = False
        dg_separata.Columns(0).Width = 20

        dg_separata.Columns(1).HeaderText = "Codigo curso"
        dg_separata.Columns(1).Visible = False
        dg_separata.Columns(1).Width = 20

        dg_separata.Columns(2).HeaderText = "Ciclo" 'Curso
        dg_separata.Columns(2).Width = 180
        dg_separata.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_separata.Columns(3).HeaderText = "Separata" 'Separata
        dg_separata.Columns(3).Width = 150
        dg_separata.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_separata.Columns(4).HeaderText = "Activo"
        dg_separata.Columns(4).Visible = False
        dg_separata.Columns(4).Width = 20

        dg_separata.Columns(5).HeaderText = "Activo"
        dg_separata.Columns(5).Width = 60
        dg_separata.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_separata.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_separata.Columns(6).HeaderText = "Costo"
        dg_separata.Columns(6).Width = 60
        dg_separata.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_separata.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_separata_curso.List_Separata_Curso.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Borrar.Enabled = True
        End If
    End Sub

    Private Sub frm_separata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If (Trim(txt_separata.Text) <> "") Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = vbYes) Then
                    id_curso = CbCurso.SelectedValue
                    MsgBox(id_curso)
                    obj_n_separata_curso = New cls_n_view_separata_curso
                    obj_n_separata_curso.View_Separata_Curso_Curso_Codigo = id_curso
                    obj_n_separata_curso.View_Separata_Curso_Separata_Nombre = StrConv(Trim(txt_separata.Text), vbProperCase)
                    obj_n_separata_curso.View_Separata_Curso_Separata_Costo = Convert.ToDecimal(txt_costo.Text)
                    obj_n_separata_curso.View_Separata_Curso_Separata_Activo = chk_activo.Checked
                    obj_ln_separata_curso.Add_Separata_Curso(obj_n_separata_curso)
                    Cargar()
                    Cargar_Datos()
                End If
            Else
                MsgBox("Debe llenar la Separata, y el Costo", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_separata.Focus()
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = vbYes) Then
                obj_n_separata_curso = New cls_n_view_separata_curso
                obj_n_separata_curso.View_Separata_Curso_Separata_Codigo = id_separata
                obj_n_separata_curso.View_Separata_Curso_Curso_Codigo = id_curso
                obj_n_separata_curso.View_Separata_Curso_Separata_Nombre = StrConv(Trim(txt_separata.Text), vbProperCase)
                obj_n_separata_curso.View_Separata_Curso_Separata_Costo = txt_costo.Text
                obj_n_separata_curso.View_Separata_Curso_Separata_Activo = chk_activo.Checked
                obj_ln_separata_curso.Update_Separata_Curso(obj_n_separata_curso)
                Cargar()
                Cargar_Datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        CbCurso.Visible = True
        obj.Llenar_curso(CbCurso)
        obj.Autocomplementar_Curso(CbCurso)
        esta_editando = False
        esta_agregando = True
        txt_separata.Enabled = True
        txt_separata.Text = ""
        'txt_separata.Focus()
        CbCurso.Focus()
        txt_costo.Enabled = True
        txt_costo.Text = 0.0
        chk_activo.Enabled = True
        chk_activo.Checked = True
        dg_separata.Enabled = False
        btn_Agregar.Enabled = False
        btn_Editar.Enabled = False
        btn_Borrar.Enabled = False
        btn_Cancelar.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Cargar()
        Cargar_Datos()
    End Sub

    Private Sub dg_separata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_separata.CellContentClick, dg_separata.CellDoubleClick, dg_separata.CellContentDoubleClick, dg_separata.CellClick
        Dim i As Integer
        i = dg_separata.CurrentRow.Index
        id_separata = dg_separata.Item(0, i).Value
        txt_curso.Text = dg_separata.Item(2, i).Value.ToString
        txt_separata.Text = dg_separata.Item(3, i).Value.ToString
        chk_activo.Checked = dg_separata.Item(4, i).Value
        txt_costo.Text = dg_separata.Item(6, i).Value
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_separata <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_separata.Enabled = True
            txt_costo.Enabled = True
            chk_activo.Enabled = True
            dg_separata.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir una separata para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_separata <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = vbYes) Then
                obj_n_separata_curso = New cls_n_view_separata_curso
                obj_n_separata_curso.View_Separata_Curso_Separata_Codigo = id_separata
                obj_ln_separata_curso.Delete_Separata_Curso(obj_n_separata_curso)
                Cargar()
                Cargar_Datos()
            End If
        Else
            MsgBox("Debe elegir una separata para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_separata_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_separata_activo = False
    End Sub

End Class