Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_cursos_ofertados
    Private obj_n_periodo As cls_n_periodo
    Private obj_ln_periodo As cls_ln_periodo
    Private obj_n_plan_estudio As cls_n_plan_estudio
    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private obj_n_curso_ofertado As cls_n_curso_ofertado
    Private obj_ln_curso_ofertado As cls_ln_curso_ofertado
    Private id_curso As Integer
    Private id_periodo As Integer
    Private id_plan_estudio As Integer
    Private curso As String
    Private seleccionado_plan As Boolean = False
    Private seleccionado_periodo As Boolean = False
    Private ofertado As Boolean

    Private Sub Cargar()
        obj_n_periodo = New cls_n_periodo
        obj_ln_periodo = New cls_ln_periodo
        obj_n_plan_estudio = New cls_n_plan_estudio
        obj_ln_plan_estudio = New cls_ln_plan_estudio
        obj_ln_curso_ofertado = New cls_ln_curso_ofertado
        btn_Cancelar.Enabled = False
        btn_Guardar.Enabled = False
        cbx_periodo.Enabled = False
        id_periodo = -1
        id_plan_estudio = -1
        chk_cursos.Items.Clear()
    End Sub

    Private Sub Cargar_Datos()
        cbx_plan_estudio.DataSource = obj_ln_plan_estudio.List_Plan_Estudio
        cbx_plan_estudio.DisplayMember = "Plan_Nombre"
        cbx_plan_estudio.ValueMember = "Plan_Codigo"
        cbx_plan_estudio.SelectedItem = Nothing

        'cbx_periodo.DataSource = obj_ln_periodo.List_Periodo
        cbx_periodo.DataSource = obj_ln_periodo.List_Periodo_Abierto
        cbx_periodo.DisplayMember = "Periodo_Nombre"
        cbx_periodo.ValueMember = "Periodo_Codigo"
        cbx_periodo.SelectedItem = Nothing

    End Sub

    Private Sub frm_cursos_ofertados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
        seleccionado_plan = True
    End Sub

    Private Sub cbx_plan_estudio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plan_estudio.SelectedIndexChanged
        If (seleccionado_plan) Then
            cbx_periodo.Enabled = True
            obj_n_plan_estudio = cbx_plan_estudio.SelectedItem
            id_plan_estudio = obj_n_plan_estudio.Plan_Codigo
            obj_ln_curso_ofertado = New cls_ln_curso_ofertado
            If (seleccionado_periodo) Then
                chk_cursos.Items.Clear()
                For Each obj As cls_n_curso_ofertado In obj_ln_curso_ofertado.List_Curso_Ofertado(id_periodo, id_plan_estudio)
                    'chk_cursos.Items.Add(obj.Curso_Ofertado_Curso_Nombre, obj.Curso_Ofertado_Ofertado)
                Next
            End If
            seleccionado_periodo = True
        End If
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If (seleccionado_periodo) Then
            obj_n_periodo = cbx_periodo.SelectedItem
            id_periodo = obj_n_periodo.Periodo_Codigo
            chk_cursos.Items.Clear()
            obj_ln_curso_ofertado = New cls_ln_curso_ofertado
            For Each obj As cls_n_curso_ofertado In obj_ln_curso_ofertado.List_Curso_Ofertado(id_periodo, id_plan_estudio)
                chk_cursos.Items.Add(obj.Curso_Ofertado_Curso_Nombre, obj.Curso_Ofertado_Ofertado)
            Next
            chk_cursos.Enabled = True
        End If
    End Sub

    Private Sub chk_cursos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cursos.SelectedIndexChanged
        btn_Guardar.Enabled = True
        btn_Cancelar.Enabled = True
    End Sub


    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (seleccionado_periodo And seleccionado_plan) Then
            Msg = MsgBox("Desea Guardar el los Cursos?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = vbYes) Then
                obj_n_plan_estudio = cbx_plan_estudio.SelectedItem
                id_plan_estudio = obj_n_plan_estudio.Plan_Codigo


                For i = 0 To chk_cursos.Items.Count - 1
                    obj_n_curso_ofertado = New cls_n_curso_ofertado
                    obj_n_curso_ofertado = obj_ln_curso_ofertado.List_Curso_Ofertado(id_periodo, id_plan_estudio).Item(i)
                    id_curso = obj_n_curso_ofertado.Curso_Ofertado_Curso_Codigo

                    obj_n_periodo = cbx_periodo.SelectedItem
                    id_periodo = obj_n_periodo.Periodo_Codigo

                    ofertado = chk_cursos.GetItemChecked(i)

                    obj_ln_curso_ofertado = New cls_ln_curso_ofertado
                    obj_ln_curso_ofertado.Update_Curso_Ofertado(id_curso, id_periodo, ofertado)
                Next
                btn_Guardar.Enabled = False
            End If
        Else
            MsgBox("Debe seleccionar un plan de estudios y un periodo", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_cursos_ofertados_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_cursos_ofertados_activo = False
    End Sub
End Class