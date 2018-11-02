Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_aula
    Private obj_aula As cls_n_aula
    Private obj_ln_aula As cls_ln_aula
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_aula As Integer
    Private aula As String
    Private capacidad As Decimal

    Private Sub Cargar()
        id_aula = -1
        esta_agregando = False
        esta_editando = False
        obj_aula = New cls_n_aula
        obj_ln_aula = New cls_ln_aula
        txt_aula.Text = ""
        txt_capacidad.Text = ""
        dg_aula.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_aula.Enabled = False
        txt_capacidad.Enabled = False
    End Sub

    Private Sub Cargar_datos()
        dg_aula.DataSource = obj_ln_aula.List_Aula
        dg_aula.Columns(0).HeaderText = "Codigo"
        dg_aula.Columns(0).Visible = False
        dg_aula.Columns(0).Width = 20

        dg_aula.Columns(1).HeaderText = "Aula"
        dg_aula.Columns(1).Width = 110
        dg_aula.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_aula.Columns(2).HeaderText = "Capacidad"
        dg_aula.Columns(2).Width = 60
        dg_aula.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_aula.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_aula.List_Aula.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Borrar.Enabled = True
        End If
    End Sub

    Private Sub frm_aula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If ((Trim(txt_aula.Text) <> "") And (Trim(txt_capacidad.Text) <> "")) Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = vbYes) Then
                    obj_aula.Aula_Nombre = StrConv(Trim(txt_aula.Text), vbProperCase)
                    obj_aula.Aula_Capacidad = Trim(txt_capacidad.Text)
                    obj_ln_aula.Add_Aula(obj_aula)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar la Aula, y la Capacidad", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_aula.Focus()
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = vbYes) Then
                obj_aula.Aula_Codigo = id_aula
                obj_aula.Aula_Nombre = StrConv(Trim(txt_aula.Text), vbProperCase)
                obj_aula.Aula_Capacidad = Trim(txt_capacidad.Text)
                obj_ln_aula.Update_Aula(obj_aula)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_aula.Enabled = True
        txt_aula.Text = ""
        txt_aula.Focus()
        txt_capacidad.Enabled = True
        txt_capacidad.Text = 0
        dg_aula.Enabled = False
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

    Private Sub dg_aula_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_aula.CellContentClick, dg_aula.CellClick
        Dim i As Integer
        i = dg_aula.CurrentRow.Index
        id_aula = dg_aula.Item(0, i).Value
        txt_aula.Text = dg_aula.Item(1, i).Value.ToString
        txt_capacidad.Text = dg_aula.Item(2, i).Value
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_aula <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_aula.Enabled = True
            txt_capacidad.Enabled = True
            dg_aula.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
        Else
            MsgBox("Debe elegir un aula para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_aula <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = vbYes) Then
                obj_aula.Aula_Codigo = id_aula
                obj_aula.Aula_Nombre = txt_aula.Text
                obj_aula.Aula_Capacidad = txt_capacidad.Text
                obj_ln_aula.Delete_Aula(obj_aula)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un aula para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_aula_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_aula_activo = False
    End Sub
End Class