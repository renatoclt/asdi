Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_matricula
    Private obj_ln_matricula As cls_ln_matricula
    Private obj_ln_view_curso_grupos As cls_ln_view_curso_grupos
    Private obj_ln_periodo As cls_ln_periodo
    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private frm_alumno_buscar_ As frm_alumno_buscar
    Private frm_alumno_buscar_activo As Boolean = False
    Private seleccionando_periodo As Boolean
    Private seleccionando_curso_grupo As Boolean
    Private id_periodo As Integer
    Private id_alumno_ficha As Integer
    Private id_plan_est As Integer
    Private id_curso_grupo As Integer
    Private ciclo As Integer

    Private Sub Cargar()
        obj_ln_matricula = New cls_ln_matricula
        obj_ln_view_curso_grupos = New cls_ln_view_curso_grupos
        obj_ln_periodo = New cls_ln_periodo
        obj_ln_plan_estudio = New cls_ln_plan_estudio
        id_periodo = -1
        id_alumno_ficha = -1
        id_plan_est = -1
        id_curso_grupo = -1
        ciclo = -1
        seleccionando_periodo = False
        seleccionando_curso_grupo = False

        cbx_periodo.DataSource = obj_ln_periodo.List_Periodo_Abierto()
        cbx_periodo.DisplayMember = "Periodo_Nombre"
        cbx_periodo.ValueMember = "Periodo_Codigo"
    End Sub

    Private Sub Cargar_Datos()
        id_periodo = cbx_periodo.SelectedValue
        cbx_cursos.DataSource = obj_ln_view_curso_grupos.List_View_Cursos_Grupos_Matricula(id_plan_est, id_periodo, ciclo)
        cbx_cursos.DisplayMember = "View_Curso_Grupo_Nombre"
        cbx_cursos.ValueMember = "View_Curso_Grupo_Codigo"
        cbx_cursos.SelectedItem = Nothing
    End Sub

    Public Sub Informacion(ByVal obj_alumno As cls_n_view_alumnos)
        frm_alumno_buscar_activo = False
        id_alumno_ficha = obj_alumno.View_Alumno_Codigo_Alumno
        txt_codigo_alumno.Text = obj_alumno.View_Alumno_Codigo_Alumno
        txt_nombre.Text = obj_alumno.View_Alumno_Nombre
        txt_tipo_alumno.Text = obj_alumno.View_Alumno_Estado
        txt_ciclo.Text = obj_alumno.View_Alumno_Ciclo
        ciclo = obj_alumno.View_Alumno_Ciclo
        txt_plan_estudio.Text = obj_ln_plan_estudio.Get_Plan_Estudio_Por_Ficha_Alumno(id_alumno_ficha).Plan_Nombre
        id_plan_est = obj_ln_plan_estudio.Get_Plan_Estudio_Por_Ficha_Alumno(id_alumno_ficha).Plan_Codigo
        Cargar_Datos()
        cbx_cursos.Focus()
    End Sub

    Private Sub frm_matricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_Datos()
    End Sub

    Private Sub cbx_periodo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbx_periodo.MouseClick
        seleccionando_periodo = True
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If (seleccionando_periodo) Then
            Cargar_Datos()
        End If
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If (Not frm_alumno_buscar_activo) Then
            frm_alumno_buscar_ = New frm_alumno_buscar
            frm_alumno_buscar_.Show()
            frm_alumno_buscar_.Formnulario_Matricular(Me, "frm_matricula")
            frm_alumno_buscar_activo = True
        Else
            frm_alumno_buscar_.Activate()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Msg As Integer
        Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
        If (Msg = vbYes) Then
            Dim obj_matricula = New cls_n_matricula
            obj_matricula.Matricula_Alumno_Codigo = id_alumno_ficha
            obj_matricula.Matricula_Curso_Grupo_Codigo = cbx_cursos.SelectedValue
            obj_matricula.Matricula_Periodo_Codigo = cbx_periodo.SelectedValue
            obj_matricula.Matricula_Fecha_Creacion = Now()
            obj_ln_matricula.Add_Matricula(obj_matricula)
            Me.Close()
        End If
    End Sub

    Private Sub frm_matricula_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_matricula_activo = False
    End Sub

End Class

