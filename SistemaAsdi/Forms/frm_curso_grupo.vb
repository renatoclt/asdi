Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_curso_grupo
    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private obj_ln_periodo As cls_ln_periodo
    Private obj_ln_curso_ofertado As cls_ln_curso_ofertado
    Private obj_ln_horario As cls_ln_horario
    Private obj_ln_view_curso_grupos As cls_ln_view_curso_grupos
    Private obj_ln_aula As cls_ln_aula
    Private obj_ln_view_profesores As cls_ln_view_profesores
    Private obj_n_view_curso_grupos As cls_n_view_curso_grupos
    Private seleccionado_plan As Boolean = False
    Private seleccionado_periodo As Boolean = False
    Private seleccionado_horario As Boolean = False
    Private id_plan_estudio As Integer
    Private id_periodo As Integer
    Private id_horario As Integer
    Private id_curso_ofertado As Integer
    Private id_aula As Integer
    Private id_profesor_ficha As Integer
    Private id_curso_grupo As Integer
    Private nombre_grupo As String
    Private matriculados As Integer
    Private esta_agregando As Boolean
    Private esta_editando As Boolean
    Dim obj As New Cls_Horario
    Dim thorario As String

    Private Sub Cargar()
        obj_ln_plan_estudio = New cls_ln_plan_estudio
        obj_ln_periodo = New cls_ln_periodo
        obj_ln_curso_ofertado = New cls_ln_curso_ofertado
        obj_ln_horario = New cls_ln_horario
        obj_ln_view_curso_grupos = New cls_ln_view_curso_grupos
        obj_ln_aula = New cls_ln_aula
        obj_ln_view_profesores = New cls_ln_view_profesores
        id_plan_estudio = -1
        id_periodo = -1
        id_horario = -1
        id_curso_ofertado = -1
        id_curso_grupo = -1
        id_aula = -1
        id_profesor_ficha = -1
        matriculados = 0
        txt_curso_ofertado.Text = ""
        txt_nombre_grupo.Text = ""
        txt_horario.Text = ""
        txt_matriculados.Text = ""
        nombre_grupo = ""
        cbx_profesor.Enabled = False
        cbx_aula.Enabled = False
        txt_nombre_grupo.ReadOnly = True
        btn_Guardar.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Editar.Enabled = False
        btn_Agregar.Enabled = False
        btn_Borrar.Enabled = False
        esta_agregando = False
        esta_editando = False
    End Sub

    Private Sub Cargar_Datos()
        cbx_plan_estudio.DataSource = obj_ln_plan_estudio.List_Plan_Estudio
        cbx_plan_estudio.DisplayMember = "Plan_Nombre"
        cbx_plan_estudio.ValueMember = "Plan_Codigo"
        cbx_plan_estudio.SelectedItem = Nothing

        cbx_periodo.DataSource = obj_ln_periodo.List_Periodo_Abierto
        cbx_periodo.DisplayMember = "Periodo_Nombre"
        cbx_periodo.ValueMember = "Periodo_Codigo"
        cbx_periodo.SelectedItem = Nothing

        'cbx_horario.DataSource = obj_ln_horario.List_Horario
        'cbx_horario.DisplayMember = "Horario_Nombre"
        'cbx_horario.ValueMember = "Horario_Codigo"
        'cbx_horario.SelectedItem = Nothing


        'cbx_aula.DataSource = obj_ln_aula.List_Aula_y_Capacidad
        cbx_aula.DataSource = obj_ln_aula.List_Aula
        cbx_aula.DisplayMember = "Aula_Nombre"
        cbx_aula.ValueMember = "Aula_Codigo"
        cbx_aula.SelectedItem = Nothing

        cbx_profesor.DataSource = obj_ln_view_profesores.List_View_Profesores_Activos
        cbx_profesor.DisplayMember = "View_Profesores_Profesor_Nombre"
        cbx_profesor.ValueMember = "View_Profesores_Codigo_Profesor"
        cbx_profesor.SelectedItem = Nothing

    End Sub

    Private Sub Actualizar_Cursos()
        id_plan_estudio = cbx_plan_estudio.SelectedValue
        id_periodo = cbx_periodo.SelectedValue

        dg_curso_ofertado.DataSource = obj_ln_curso_ofertado.List_View_Curso_Ofertado(id_periodo, id_plan_estudio)
        dg_curso_ofertado.CurrentCell = Nothing

        dg_curso_ofertado.Columns(0).HeaderText = "Codigo Curso Ofertado"
        dg_curso_ofertado.Columns(0).Width = 20
        dg_curso_ofertado.Columns(0).Visible = False

        dg_curso_ofertado.Columns(1).HeaderText = "Codigo Ciclo" 'Id curso
        dg_curso_ofertado.Columns(1).Width = 20
        dg_curso_ofertado.Columns(1).Visible = False

        dg_curso_ofertado.Columns(2).HeaderText = "Ciclo" 'Curso
        dg_curso_ofertado.Columns(2).Width = dg_curso_ofertado.Width - 20
        dg_curso_ofertado.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_curso_ofertado.Columns(3).HeaderText = "Aperturado" 'Ofertado
        dg_curso_ofertado.Columns(3).Width = 60
        dg_curso_ofertado.Columns(3).Visible = False

        If (obj_ln_curso_ofertado.List_View_Curso_Ofertado(id_periodo, id_plan_estudio).Count = 0) Then
            dg_curso_ofertado.Enabled = False
        Else
            dg_curso_ofertado.Enabled = True
        End If
        id_curso_ofertado = -1

    End Sub

    Private Sub Actualizar_Grupos()
        id_horario = cbx_horario.SelectedValue
        'Dim thorario As String = cbx_horario.SelectedItem.ToString
        thorario = Convert.ToString(cbx_horario.Text)
        txt_horario.Text = thorario

        dg_curso_grupo.DataSource = obj_ln_view_curso_grupos.List_View_Cursos_Grupos(id_curso_ofertado, id_horario)
        dg_curso_grupo.CurrentCell = Nothing

        dg_curso_grupo.Columns(0).HeaderText = "Codigo Curso Grupo"
        dg_curso_grupo.Columns(0).Visible = False

        dg_curso_grupo.Columns(1).HeaderText = "Codigo Profesor"
        dg_curso_grupo.Columns(1).Visible = False

        dg_curso_grupo.Columns(2).HeaderText = "Profesor"
        dg_curso_grupo.Columns(2).Visible = True
        dg_curso_grupo.Columns(2).Width = 120
        dg_curso_grupo.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_curso_grupo.Columns(3).HeaderText = "Codigo Curso Ofertado"
        dg_curso_grupo.Columns(3).Visible = False

        dg_curso_grupo.Columns(4).HeaderText = "Ciclo Aperturado" 'Curso Ofertado
        dg_curso_grupo.Columns(4).Visible = True
        dg_curso_grupo.Columns(4).Width = 120
        dg_curso_grupo.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_curso_grupo.Columns(5).HeaderText = "Codigo horario"
        dg_curso_grupo.Columns(5).Visible = False

        dg_curso_grupo.Columns(6).HeaderText = "Horario"
        dg_curso_grupo.Columns(6).Visible = False

        dg_curso_grupo.Columns(7).HeaderText = "Codigo Aula"
        dg_curso_grupo.Columns(7).Visible = False

        dg_curso_grupo.Columns(8).HeaderText = "Aula"
        dg_curso_grupo.Columns(8).Visible = True
        dg_curso_grupo.Columns(8).Width = 100
        dg_curso_grupo.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_curso_grupo.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_curso_grupo.Columns(9).HeaderText = "Grupo"
        dg_curso_grupo.Columns(9).Visible = True
        dg_curso_grupo.Columns(9).Width = 100
        dg_curso_grupo.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_curso_grupo.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dg_curso_grupo.Columns(10).HeaderText = "Matriculados"
        dg_curso_grupo.Columns(10).Visible = True
        dg_curso_grupo.Columns(10).Width = 70
        dg_curso_grupo.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_curso_grupo.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If (obj_ln_view_curso_grupos.List_View_Cursos_Grupos(id_curso_ofertado, id_horario).Count = 0) Then
            btn_Editar.Enabled = False
            btn_Borrar.Enabled = False
            dg_curso_grupo.Enabled = False
        Else
            dg_curso_grupo.Enabled = True
        End If
        btn_Agregar.Enabled = True
    End Sub

    Private Sub DesBloquear(ByVal bloquear As Boolean)
        cbx_plan_estudio.Enabled = bloquear
        cbx_periodo.Enabled = bloquear
        dg_curso_ofertado.Enabled = bloquear
        cbx_horario.Enabled = bloquear
        dg_curso_grupo.Enabled = bloquear
        cbx_profesor.Enabled = Not bloquear
        cbx_aula.Enabled = Not bloquear
        txt_nombre_grupo.Enabled = Not bloquear
        btn_Guardar.Enabled = Not bloquear
        btn_Cancelar.Enabled = Not bloquear
        txt_nombre_grupo.ReadOnly = bloquear
    End Sub

    Private Sub Obtener()
        Dim i As Integer
        If (cbx_aula.SelectedIndex <> -1) Then
            id_aula = cbx_aula.SelectedValue
        Else
            id_aula = -1
        End If
        If (cbx_profesor.SelectedIndex <> -1) Then
            id_profesor_ficha = cbx_profesor.SelectedValue
        Else
            id_profesor_ficha = -1
        End If
        If (cbx_horario.SelectedValue <> -1) Then
            id_horario = cbx_horario.SelectedValue
        End If

        i = dg_curso_ofertado.CurrentRow.Index
        id_curso_ofertado = dg_curso_ofertado.Item(0, i).Value
        nombre_grupo = StrConv(Trim(txt_nombre_grupo.Text), vbProperCase)
        matriculados = txt_matriculados.Text
    End Sub

    Private Sub frm_curso_grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
    End Sub
    Private Sub frm_curso_grupo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_curso_grupo_activo = False
    End Sub

    Private Sub cbx_plan_estudio_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_plan_estudio.MouseClick
        seleccionado_plan = True
    End Sub

    Private Sub cbx_periodo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_periodo.MouseClick
        seleccionado_periodo = True
    End Sub

    Private Sub cbx_plan_estudio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plan_estudio.SelectedIndexChanged
        obj.Llenar_horario(cbx_horario, Convert.ToString(cbx_plan_estudio.SelectedValue))
        If (seleccionado_plan And seleccionado_periodo) Then
            Actualizar_Cursos()
        End If
        If (seleccionado_plan And seleccionado_periodo And seleccionado_horario) Then
            Actualizar_Grupos()
        End If
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If (seleccionado_plan And seleccionado_periodo) Then
            Actualizar_Cursos()
        End If
        If (seleccionado_plan And seleccionado_periodo And seleccionado_horario) Then
            Actualizar_Grupos()
        End If
    End Sub

    Private Sub cbx_horario_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_horario.MouseClick
        seleccionado_horario = True
    End Sub

    Private Sub cbx_horario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_horario.SelectedIndexChanged
        If (seleccionado_plan And seleccionado_periodo And seleccionado_horario) Then
            Actualizar_Grupos()
        End If
    End Sub

    Private Sub dg_curso_ofertado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_curso_ofertado.CellClick, dg_curso_ofertado.CellDoubleClick, dg_curso_ofertado.CellContentClick, dg_curso_ofertado.CellContentDoubleClick
        Dim i As Integer
        i = dg_curso_ofertado.CurrentRow.Index
        id_curso_ofertado = dg_curso_ofertado.Item(0, i).Value
        txt_curso_ofertado.Text = dg_curso_ofertado.Item(2, i).Value.ToString
        If (seleccionado_horario) Then
            Actualizar_Grupos()
        End If
        txt_matriculados.Text = ""
        cbx_profesor.SelectedItem = Nothing
        cbx_aula.SelectedItem = Nothing
    End Sub

    Private Sub dg_curso_grupo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_curso_grupo.CellContentClick, dg_curso_grupo.CellClick, dg_curso_grupo.CellDoubleClick, dg_curso_grupo.CellContentDoubleClick
        Dim i As Integer
        i = dg_curso_grupo.CurrentRow.Index
        id_curso_grupo = dg_curso_grupo.Item(0, i).Value
        cbx_profesor.SelectedItem = Nothing
        cbx_profesor.Text = dg_curso_grupo.Item(2, i).Value.ToString
        cbx_aula.Text = dg_curso_grupo.Item(8, i).Value.ToString
        txt_nombre_grupo.Text = dg_curso_grupo.Item(9, i).Value
        txt_matriculados.Text = dg_curso_grupo.Item(10, i).Value
        btn_Editar.Enabled = True
        btn_Borrar.Enabled = True
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        esta_agregando = True
        esta_editando = False
        btn_Agregar.Enabled = False
        btn_Borrar.Enabled = False
        btn_Editar.Enabled = False
        DesBloquear(False)
        txt_nombre_grupo.Text = ""
        txt_nombre_grupo.Focus()
        cbx_profesor.SelectedItem = Nothing
        cbx_aula.SelectedItem = Nothing
        txt_matriculados.Text = 0
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        esta_agregando = False
        esta_editando = True
        btn_Agregar.Enabled = False
        btn_Borrar.Enabled = False
        btn_Editar.Enabled = False
        DesBloquear(False)
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Msg As Integer
        If (id_curso_grupo <> -1) Then
            Msg = MsgBox("Desea Borrar?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Borrar?")
            If (Msg = 6) Then
                If (txt_matriculados.Text = 0) Then
                    Obtener()
                    obj_n_view_curso_grupos = New cls_n_view_curso_grupos
                    obj_n_view_curso_grupos.View_Curso_Grupo_Codigo = id_curso_grupo
                    obj_ln_view_curso_grupos.Delete_Curso_Grupo(obj_n_view_curso_grupos)

                    btn_Borrar.Enabled = False
                    btn_Editar.Enabled = False
                    DesBloquear(True)
                    Actualizar_Grupos()
                    id_curso_grupo = -1
                    cbx_profesor.SelectedItem = Nothing
                    cbx_aula.SelectedItem = Nothing
                    txt_nombre_grupo.Text = ""
                    txt_matriculados.Text = ""
                Else
                    MsgBox("Solo puede Borrar Grupos que no tienen matriculados", MsgBoxStyle.Exclamation, "Advertencia!!")
                End If
            End If

        Else
            MsgBox("Debe elegir un grupo para Borrar", MsgBoxStyle.Exclamation, "Advertencia!!")
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        btn_Editar.Enabled = True
        btn_Agregar.Enabled = True
        btn_Borrar.Enabled = True
        DesBloquear(True)
        Actualizar_Grupos()
        id_curso_grupo = -1
        cbx_profesor.SelectedItem = Nothing
        cbx_aula.SelectedItem = Nothing
        txt_nombre_grupo.Text = ""
        txt_matriculados.Text = ""
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        If (esta_agregando) Then
            If ((id_curso_ofertado <> -1) And (id_curso_ofertado <> -1) And (id_horario <> -1) And (Trim(txt_nombre_grupo.Text).Length <> 0)) Then
                Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
                If (Msg = vbYes) Then
                    Obtener()
                    obj_n_view_curso_grupos = New cls_n_view_curso_grupos
                    obj_n_view_curso_grupos.View_Curso_Grupo_Aula_Codigo = id_aula
                    obj_n_view_curso_grupos.View_Curso_Grupo_Profesor_Codigo = id_profesor_ficha
                    obj_n_view_curso_grupos.View_Curso_Grupo_Nombre = nombre_grupo
                    obj_n_view_curso_grupos.View_Curso_Grupo_Curso_Ofertado_Codigo = id_curso_ofertado
                    obj_n_view_curso_grupos.View_Curso_Grupo_Horario_Codigo = id_horario
                    obj_ln_view_curso_grupos.Add_Curso_Grupo(obj_n_view_curso_grupos)

                    btn_Borrar.Enabled = False
                    btn_Editar.Enabled = False
                    DesBloquear(True)
                    Actualizar_Grupos()
                    id_curso_grupo = -1
                    cbx_profesor.SelectedItem = Nothing
                    cbx_aula.SelectedItem = Nothing
                    txt_nombre_grupo.Text = ""
                    txt_matriculados.Text = ""
                End If
            Else
                MsgBox("Debe llenar el Nombre del Grupo?", MsgBoxStyle.Exclamation, "Advertencia!!")
            End If
        End If
        If (esta_editando) Then
            Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
            If (Msg = vbYes) Then
                Obtener()
                obj_n_view_curso_grupos = New cls_n_view_curso_grupos
                obj_n_view_curso_grupos.View_Curso_Grupo_Codigo = id_curso_grupo
                obj_n_view_curso_grupos.View_Curso_Grupo_Aula_Codigo = id_aula
                obj_n_view_curso_grupos.View_Curso_Grupo_Profesor_Codigo = id_profesor_ficha
                obj_n_view_curso_grupos.View_Curso_Grupo_Nombre = nombre_grupo
                obj_ln_view_curso_grupos.Update_Curso_Grupo(obj_n_view_curso_grupos)

                btn_Borrar.Enabled = False
                btn_Editar.Enabled = False
                DesBloquear(True)
                Actualizar_Grupos()
                id_curso_grupo = -1
                cbx_profesor.SelectedItem = Nothing
                cbx_aula.SelectedItem = Nothing
                txt_nombre_grupo.Text = ""
                txt_matriculados.Text = ""
            End If
        End If
    End Sub
End Class