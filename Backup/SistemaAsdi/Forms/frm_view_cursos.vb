Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_view_cursos
    Private obj_n_view_cursos As cls_n_view_cursos
    Private obj_ln_view_cursos As cls_ln_view_cursos
    Private obj_n_plan_estudio As cls_n_plan_estudio
    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private id_plan_est As Integer
    Private seleccionado As Boolean = False
    Private celda As DataGridViewCell
    Private error_editar As Boolean

    Private Sub Cargar()
        obj_ln_view_cursos = New cls_ln_view_cursos
        obj_n_plan_estudio = New cls_n_plan_estudio
        obj_ln_plan_estudio = New cls_ln_plan_estudio
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
    End Sub

    Private Sub Cargar_Datos()
        cbx_plan_estudio.DataSource = obj_ln_plan_estudio.List_Plan_Estudio
        cbx_plan_estudio.DisplayMember = "Plan_Nombre"
        cbx_plan_estudio.ValueMember = "Plan_Codigo"
        cbx_plan_estudio.SelectedItem = Nothing

        dg_view_cursos.DataSource = obj_ln_view_cursos.List_View_Cursos(0)
        dg_view_cursos.Columns(0).HeaderText = "Codigo"
        dg_view_cursos.Columns(0).Visible = False
        dg_view_cursos.Columns(0).Width = 50
        dg_view_cursos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_view_cursos.Columns(0).ReadOnly = True

        dg_view_cursos.Columns(1).HeaderText = "Codigo Plan"
        dg_view_cursos.Columns(1).Visible = False
        dg_view_cursos.Columns(1).Width = 60
        dg_view_cursos.Columns(1).ReadOnly = True
        dg_view_cursos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_view_cursos.Columns(2).HeaderText = "Plan de Estudios"
        dg_view_cursos.Columns(2).ReadOnly = True
        dg_view_cursos.Columns(2).Width = 160
        dg_view_cursos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_view_cursos.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_view_cursos.Columns(3).HeaderText = "Codigo Curso"
        dg_view_cursos.Columns(3).Visible = False
        dg_view_cursos.Columns(3).Width = 60
        dg_view_cursos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_view_cursos.Columns(3).ReadOnly = True

        dg_view_cursos.Columns(4).HeaderText = "Ciclo"
        dg_view_cursos.Columns(4).Width = 235
        dg_view_cursos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_view_cursos.Columns(4).ReadOnly = True
        dg_view_cursos.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_view_cursos.Columns(5).HeaderText = "Orden"
        dg_view_cursos.Columns(5).Width = 60
        dg_view_cursos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_view_cursos.Columns(5).DefaultCellStyle.ForeColor = Color.Red
        dg_view_cursos.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub frm_view_cursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
        seleccionado = True
    End Sub

    Private Function Verificar() As Boolean
        error_editar = True
        For Each row As DataGridViewRow In dg_view_cursos.Rows
            If (IsNumeric(row.Cells(5).Value)) Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point)
            Else
                row.DefaultCellStyle.ForeColor = Color.Red
                row.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.25, FontStyle.Bold, GraphicsUnit.Point)
                error_editar = error_editar And False
            End If
        Next
        Return error_editar
    End Function

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (seleccionado And Verificar()) Then
            Msg = MsgBox("Desea Guardar el orden de los ciclos?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = vbYes) Then
                For Each row As DataGridViewRow In dg_view_cursos.Rows
                    obj_n_view_cursos = New cls_n_view_cursos
                    obj_n_view_cursos.View_Cursos_Codigo = row.Cells(0).Value
                    obj_n_view_cursos.View_Cursos_Orden = row.Cells(5).Value

                    obj_ln_view_cursos = New cls_ln_view_cursos
                    obj_ln_view_cursos.Update_View_Cursos(obj_n_view_cursos)
                Next
                obj_n_plan_estudio = cbx_plan_estudio.SelectedItem
                id_plan_est = obj_n_plan_estudio.Plan_Codigo
                dg_view_cursos.DataSource = obj_ln_view_cursos.List_View_Cursos(id_plan_est)
                btn_Guardar.Enabled = False
            End If
        Else
            MsgBox("Alguno(s) de los valores ingresados estan errados", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub cbx_plan_estudio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plan_estudio.SelectedIndexChanged
        If (seleccionado) Then
            obj_n_plan_estudio = cbx_plan_estudio.SelectedItem
            id_plan_est = obj_n_plan_estudio.Plan_Codigo

            dg_view_cursos.DataSource = obj_ln_view_cursos.List_View_Cursos(id_plan_est)
            btn_Guardar.Enabled = False
            btn_Cancelar.Enabled = True
        End If
    End Sub

    Private Sub dg_view_cursos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_view_cursos.CellEndEdit
        btn_Guardar.Enabled = True
        If (Not IsNumeric(dg_view_cursos.CurrentCell().Value)) Then
            celda = dg_view_cursos.CurrentCell()
            MsgBox("El valor Ingresado no es un número.", vbCritical, "Error de Ingreso")
            dg_view_cursos.Rows(celda.RowIndex()).DefaultCellStyle.ForeColor = Color.Red
            dg_view_cursos.Rows(celda.RowIndex()).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.25, FontStyle.Bold, GraphicsUnit.Point)
        End If
    End Sub

    Private Sub frm_view_cursos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_view_cursos_activo = False
    End Sub
End Class