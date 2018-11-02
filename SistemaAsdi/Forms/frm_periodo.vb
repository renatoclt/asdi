Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_periodo
    Private obj_n_periodo As cls_n_periodo
    Private obj_ln_periodo As cls_ln_periodo
    Private esta_editando As Boolean
    Private esta_agregando As Boolean
    Private id_periodo As Integer
    Private periodo As String
    Private estado As Boolean
    Private regular As Boolean


    Private Sub Cargar()
        id_periodo = -1
        esta_agregando = False
        esta_editando = False
        obj_n_periodo = New cls_n_periodo
        obj_ln_periodo = New cls_ln_periodo
        txt_periodo.Text = ""
        dg_periodo.Enabled = True
        btn_Agregar.Enabled = True
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        txt_periodo.Enabled = False
        chk_estado.Enabled = False
        chk_estado.Text = ""
        chk_regular.Enabled = False
        chk_regular.Text = ""
        dtp_fecha_inicio.Enabled = False
        dtp_fecha_fin.Enabled = False
    End Sub

    Private Sub Cargar_datos() 
        dg_periodo.DataSource = obj_ln_periodo.List_Periodo
        dg_periodo.Columns(0).HeaderText = "Codigo"
        dg_periodo.Columns(0).Visible = False
        dg_periodo.Columns(0).Width = 20

        dg_periodo.Columns(1).HeaderText = "Periodo"
        dg_periodo.Columns(1).Width = 100
        dg_periodo.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_periodo.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_periodo.Columns(2).HeaderText = "Estado"
        dg_periodo.Columns(2).Width = 80
        dg_periodo.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_periodo.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_periodo.Columns(3).HeaderText = "Regular"
        dg_periodo.Columns(3).Width = 50
        dg_periodo.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_periodo.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_periodo.Columns(4).HeaderText = "Fecha de Inicio"
        dg_periodo.Columns(4).Width = 110
        dg_periodo.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_periodo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_periodo.Columns(5).HeaderText = "Fecha de Fin"
        dg_periodo.Columns(5).Width = 110
        dg_periodo.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_periodo.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_periodo.List_Periodo.Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
        Else
            btn_Editar.Enabled = True
            btn_Borrar.Enabled = True
        End If

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If (Trim(txt_periodo.Text) <> "") Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = vbYes) Then
                    obj_n_periodo.Periodo_Nombre = StrConv(Trim(txt_periodo.Text), vbProperCase)
                    obj_n_periodo.Periodo_Estado_Boolean(chk_estado.Checked)
                    obj_n_periodo.Periodo_Regular_Boolean(chk_regular.Checked)
                    obj_n_periodo.Periodo_Fecha_Inicio = dtp_fecha_inicio.Value
                    obj_n_periodo.Periodo_Fecha_Fin = dtp_fecha_fin.Value
                    obj_ln_periodo.Add_Periodo(obj_n_periodo)
                    Cargar()
                    Cargar_datos()
                End If
            Else
                MsgBox("Debe llenar el Nombre del Periodo", MsgBoxStyle.Exclamation, "Advertencia!!")
                txt_periodo.Focus()
            End If
        End If
        If (esta_editando) Then
            obj_n_periodo.Periodo_Nombre = txt_periodo.Text
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = 6) Then
                obj_n_periodo.Periodo_Codigo = id_periodo
                obj_n_periodo.Periodo_Nombre = StrConv(Trim(txt_periodo.Text), vbProperCase)
                obj_n_periodo.Periodo_Estado_Boolean(chk_estado.Checked)
                obj_n_periodo.Periodo_Regular_Boolean(chk_regular.Checked)
                obj_n_periodo.Periodo_Fecha_Inicio = dtp_fecha_inicio.Value
                obj_n_periodo.Periodo_Fecha_Fin = dtp_fecha_fin.Value
                obj_ln_periodo.Update_Periodo(obj_n_periodo)
                Cargar()
                Cargar_datos()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_editando = False
        esta_agregando = True
        txt_periodo.Enabled = True
        txt_periodo.Text = ""
        dg_periodo.Enabled = False
        btn_Agregar.Enabled = False
        btn_Editar.Enabled = False
        btn_Borrar.Enabled = False
        btn_Cancelar.Enabled = True
        btn_Guardar.Enabled = True
        chk_estado.Enabled = True
        chk_estado.Text = "Abierto"
        chk_regular.Enabled = True
        chk_regular.Text = "Si"
        dtp_fecha_inicio.Enabled = True
        dtp_fecha_fin.Enabled = True
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub dg_periodo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_periodo.CellContentClick, dg_periodo.CellClick
        Dim i As Integer
        i = dg_periodo.CurrentRow.Index
        id_periodo = dg_periodo.Item(0, i).Value
        periodo = dg_periodo.Item(1, i).Value.ToString
        If (dg_periodo.Item(2, i).Value = "Abierto") Then
            estado = True
            chk_estado.Text = "Abierto"
            chk_estado.Checked = True
        Else
            estado = False
            chk_estado.Text = "Cerrado"
            chk_estado.Checked = False
        End If

        If (dg_periodo.Item(3, i).Value = "Si") Then
            regular = True
            chk_regular.Text = "Si"
            chk_regular.Checked = True
        Else
            regular = False
            chk_regular.Text = "No"
            chk_regular.Checked = False
        End If
        txt_periodo.Text = periodo
        dtp_fecha_inicio.Value = dg_periodo.Item(4, i).Value
        dtp_fecha_fin.Value = dg_periodo.Item(5, i).Value
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (id_periodo <> -1) Then
            esta_editando = True
            esta_agregando = False
            txt_periodo.Enabled = True
            dg_periodo.Enabled = False
            btn_Agregar.Enabled = False
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            btn_Cancelar.Enabled = True
            btn_Guardar.Enabled = True
            chk_estado.Enabled = True
            chk_regular.Enabled = True
            dtp_fecha_inicio.Enabled = True
            dtp_fecha_fin.Enabled = True
        Else
            MsgBox("Debe elegir un periodo para editar", MsgBoxStyle.Exclamation, "Advertencia!!!")
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_periodo <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                obj_n_periodo.Periodo_Nombre = txt_periodo.Text
                obj_n_periodo.Periodo_Codigo = id_periodo
                obj_n_periodo.Periodo_Estado_Boolean(chk_estado.Checked)
                obj_n_periodo.Periodo_Regular_Boolean(chk_regular.Checked)
                obj_n_periodo.Periodo_Fecha_Inicio = dtp_fecha_inicio.Value
                obj_n_periodo.Periodo_Fecha_Fin = dtp_fecha_fin.Value
                obj_ln_periodo.Delete_Periodo(obj_n_periodo)
                Cargar()
                Cargar_datos()
            End If
        Else
            MsgBox("Debe elegir un periodo para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub frm_periodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub chk_estado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_estado.CheckedChanged, chk_estado.CheckStateChanged
        If (chk_estado.Checked) Then
            chk_estado.Text = "Abierto"
            estado = True
        Else
            chk_estado.Text = "Cerrado"
            estado = False
        End If
    End Sub

    Private Sub chk_regular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_regular.CheckedChanged, chk_regular.CheckStateChanged, chk_regular.Click
        If (chk_regular.Checked) Then
            chk_regular.Text = "Si"
            regular = True
        Else
            chk_regular.Text = "No"
            regular = False
        End If
    End Sub

    Private Sub frm_periodo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_periodo_activo = False
    End Sub

End Class