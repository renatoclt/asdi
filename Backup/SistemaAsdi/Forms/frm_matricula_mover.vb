Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_matricula_mover
    Private obj_ln_periodo As cls_ln_periodo
    Private obj_ln_horario As cls_ln_horario
    Private obj_ln_curso As cls_ln_curso
    Private obj_ln_view_curso_grupo As cls_ln_view_curso_grupos
    Private obj_ln_view_alumnos_grupo As cls_ln_view_alumnos
    Private lista_alumno_grupo_origen As List(Of cls_n_matricula)
    Private lista_alumno_grupo_destino As List(Of cls_n_matricula)
    Private id_periodo As Integer = -1
    Private periodo As String = ""
    Private id_horario As Integer = -1
    Private horario As String = ""
    Private id_curso As Integer = -1
    Private curso As String = ""
    Private id_matricula As Integer = -1
    Private id_curso_grupo_origen As Integer = -1
    Private curso_grupo_origen As String = ""
    Private id_curso_grupo_destino As Integer = -1
    Private curso_grupo_destino As String = ""
    Private seleccionar_periodo As Boolean = False
    Private seleccionar_horario As Boolean = False
    Private seleccionar_curso As Boolean = False
    Private seleccionar_grupo_origen As Boolean = False
    Private seleccionar_grupo_destino As Boolean = False

    Private Sub Cargar()
        obj_ln_periodo = New cls_ln_periodo
        obj_ln_horario = New cls_ln_horario
        obj_ln_curso = New cls_ln_curso
        obj_ln_view_curso_grupo = New cls_ln_view_curso_grupos
        obj_ln_view_alumnos_grupo = New cls_ln_view_alumnos
        lista_alumno_grupo_origen = New List(Of cls_n_matricula)
        lista_alumno_grupo_destino = New List(Of cls_n_matricula)
        cbx_horario.Enabled = False
        cbx_curso.Enabled = False
        cbx_grupo_origen.Enabled = False
        cbx_grupo_destino.Enabled = False
        lchk_grupo_origen.Enabled = False
        lchk_grupo_destino.Enabled = False
        btn_Guardar.Enabled = False
        id_periodo = -1
        periodo = ""
        id_horario = -1
        horario = ""
        id_curso = -1
        curso = ""
        id_matricula = -1
        id_curso_grupo_origen = -1
        curso_grupo_origen = ""
        id_curso_grupo_destino = -1
        curso_grupo_destino = ""
        seleccionar_curso = False
        seleccionar_horario = False
        seleccionar_periodo = False
        seleccionar_grupo_origen = False
        seleccionar_grupo_destino = False
    End Sub

    Private Sub Cargar_Datos()
        cbx_periodo.DataSource = obj_ln_periodo.List_Periodo_Abierto
        cbx_periodo.DisplayMember = "Periodo_Nombre"
        cbx_periodo.ValueMember = "Periodo_Codigo"
        cbx_periodo.SelectedItem = Nothing
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If (seleccionar_periodo) Then
            id_periodo = cbx_periodo.SelectedValue
            periodo = cbx_periodo.Text

            cbx_horario.DataSource = obj_ln_horario.List_Horario_Por_Periodo(id_periodo)
            cbx_horario.DisplayMember = "Horario_Nombre"
            cbx_horario.ValueMember = "Horario_Codigo"
            cbx_horario.SelectedItem = Nothing

            If (obj_ln_horario.List_Horario_Por_Periodo(id_periodo).Count = 0) Then
                cbx_horario.Enabled = False
            Else
                cbx_horario.Enabled = True
            End If

            seleccionar_horario = False
            seleccionar_curso = False
            seleccionar_grupo_origen = False
            seleccionar_grupo_destino = False
        End If
    End Sub

    Private Sub frm_matricula_mover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
    End Sub

    Private Sub cbx_periodo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_periodo.MouseClick
        seleccionar_periodo = True
    End Sub

    Private Sub cbx_curso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_curso.SelectedIndexChanged
        If (seleccionar_curso) Then
            id_curso = cbx_curso.SelectedValue
            curso = cbx_curso.Text

            cbx_grupo_origen.DataSource = obj_ln_view_curso_grupo.List_Curso_Grupo_Por_Periodo_Curso_Y_Horario(id_periodo, id_curso, id_horario)
            cbx_grupo_origen.DisplayMember = "View_Curso_Grupo_Nombre"
            cbx_grupo_origen.ValueMember = "View_Curso_Grupo_Codigo"
            cbx_grupo_origen.SelectedItem = Nothing
            If (obj_ln_view_curso_grupo.List_Curso_Grupo_Por_Periodo_Curso_Y_Horario(id_periodo, id_curso, id_horario).Count < 2) Then
                cbx_grupo_origen.Enabled = False
            Else
                cbx_grupo_origen.Enabled = True
            End If

        End If
        seleccionar_grupo_origen = False
        seleccionar_grupo_destino = False
    End Sub

    Private Sub cbx_curso_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_curso.MouseClick
        seleccionar_curso = True
    End Sub

    Private Sub cbx_horario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_horario.SelectedIndexChanged
        If (seleccionar_horario) Then
            id_horario = cbx_horario.SelectedValue
            horario = cbx_horario.Text

            cbx_curso.DataSource = obj_ln_curso.List_Curso_Por_Periodo_Y_Horario(id_periodo, id_horario)
            cbx_curso.DisplayMember = "Curso_Nombre"
            cbx_curso.ValueMember = "Curso_Codigo"
            cbx_curso.SelectedItem = Nothing

            If (obj_ln_curso.List_Curso_Por_Periodo_Y_Horario(id_periodo, id_horario).Count = 0) Then
                cbx_curso.Enabled = False
            Else
                cbx_curso.Enabled = True
            End If
        End If
        seleccionar_curso = False
        seleccionar_grupo_origen = False
        seleccionar_grupo_destino = False
    End Sub

    Private Sub cbx_horario_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_horario.MouseClick
        seleccionar_horario = True
    End Sub

    Private Sub cbx_grupo_origen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_grupo_origen.SelectedIndexChanged
        If (seleccionar_grupo_origen) Then
            id_curso_grupo_origen = cbx_grupo_origen.SelectedValue
            curso_grupo_origen = cbx_grupo_origen.Text

            cbx_grupo_destino.DataSource = obj_ln_view_curso_grupo.List_Curso_Grupo_Por_Periodo_Curso_Horario_Y_Grupo(id_periodo, id_curso, id_horario, id_curso_grupo_origen)
            cbx_grupo_destino.DisplayMember = "View_Curso_Grupo_Nombre"
            cbx_grupo_destino.ValueMember = "View_Curso_Grupo_Codigo"
            cbx_grupo_destino.SelectedItem = Nothing

            If (obj_ln_view_curso_grupo.List_Curso_Grupo_Por_Periodo_Curso_Horario_Y_Grupo(id_periodo, id_curso, id_horario, id_curso_grupo_origen).Count = 0) Then
                cbx_grupo_destino.Enabled = False
            Else
                cbx_grupo_destino.Enabled = True
            End If

        End If
        seleccionar_grupo_destino = False
    End Sub

    Private Sub cbx_grupo_origen_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_grupo_origen.MouseClick
        seleccionar_grupo_origen = True
    End Sub

    Private Sub cbx_grupo_destino_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_grupo_destino.MouseClick
        seleccionar_grupo_destino = True
    End Sub

    Private Sub cbx_grupo_destino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_grupo_destino.SelectedIndexChanged
        If (seleccionar_grupo_destino) Then
            id_curso_grupo_destino = cbx_grupo_destino.SelectedValue
            curso_grupo_destino = cbx_grupo_destino.Text

            lista_alumno_grupo_origen = obj_ln_view_alumnos_grupo.List_View_Alumnos_Nombres_Curso_Grupo(id_curso_grupo_origen)
            lchk_grupo_origen.Items.Clear()
            For Each alum As cls_n_matricula In lista_alumno_grupo_origen
                lchk_grupo_origen.Items.Add(alum.Matricula_Alumno_Nombre, False)
            Next
            If (lista_alumno_grupo_origen.Count = 0) Then
                lchk_grupo_origen.Enabled = False
            Else
                lchk_grupo_origen.Enabled = True
            End If

            lchk_grupo_destino.Items.Clear()
            lista_alumno_grupo_destino = obj_ln_view_alumnos_grupo.List_View_Alumnos_Nombres_Curso_Grupo(id_curso_grupo_destino)
            For Each alum As cls_n_matricula In lista_alumno_grupo_destino
                lchk_grupo_destino.Items.Add(alum.Matricula_Alumno_Nombre, True)
            Next
            If (lista_alumno_grupo_destino.Count = 0) Then
                lchk_grupo_destino.Enabled = False
            Else
                lchk_grupo_destino.Enabled = True
            End If
        End If
    End Sub

    Private Sub lchk_grupo_origen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lchk_grupo_origen.SelectedIndexChanged
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim obj_ln_matricula As New cls_ln_matricula
        Dim Msg As Integer
        Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
        If (Msg = vbYes) Then
            For i = 0 To lchk_grupo_origen.Items.Count - 1
                If (lchk_grupo_origen.GetItemChecked(i)) Then
                    Dim obj_matricula As New cls_n_matricula
                    id_matricula = lista_alumno_grupo_origen.Item(i).Matricula_Codigo
                    obj_matricula.Matricula_Codigo = lista_alumno_grupo_origen.Item(i).Matricula_Codigo
                    obj_matricula.Matricula_Curso_Grupo_Codigo = id_curso_grupo_destino
                    obj_ln_matricula.Update_Matricula(obj_matricula)
                    MsgBox(id_matricula)
                End If
            Next

            For i = 0 To lchk_grupo_destino.Items.Count - 1
                If (Not lchk_grupo_destino.GetItemChecked(i)) Then
                    Dim obj_matricula As New cls_n_matricula
                    obj_matricula.Matricula_Codigo = lista_alumno_grupo_destino.Item(i).Matricula_Codigo
                    obj_matricula.Matricula_Curso_Grupo_Codigo = id_curso_grupo_origen
                    obj_ln_matricula.Update_Matricula(obj_matricula)
                End If
            Next

            lista_alumno_grupo_origen = obj_ln_view_alumnos_grupo.List_View_Alumnos_Nombres_Curso_Grupo(id_curso_grupo_origen)
            lchk_grupo_origen.Items.Clear()
            For Each alum As cls_n_matricula In lista_alumno_grupo_origen
                lchk_grupo_origen.Items.Add(alum.Matricula_Alumno_Nombre, False)
            Next
            If (lista_alumno_grupo_origen.Count = 0) Then
                lchk_grupo_origen.Enabled = False
            Else
                lchk_grupo_origen.Enabled = True
            End If

            lchk_grupo_destino.Items.Clear()
            lista_alumno_grupo_destino = obj_ln_view_alumnos_grupo.List_View_Alumnos_Nombres_Curso_Grupo(id_curso_grupo_destino)
            For Each alum As cls_n_matricula In lista_alumno_grupo_destino
                lchk_grupo_destino.Items.Add(alum.Matricula_Alumno_Nombre, True)
            Next
            If (lista_alumno_grupo_destino.Count = 0) Then
                lchk_grupo_destino.Enabled = False
            Else
                lchk_grupo_destino.Enabled = True
            End If
            btn_Guardar.Enabled = False
        End If
    End Sub

    Private Sub frm_matricula_mover_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_matricula_mover_activo = False
    End Sub
End Class