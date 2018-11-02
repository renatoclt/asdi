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
    Dim obj As New Cls_Matricula
    Dim obj1 As New Cls_Anulacion_Matricula

    Public Sub Cargar()
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

    Public Sub Cargar_Datos()
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
        txtnom_cu.Text = obj1.consulta_nombre_curso_a(ciclo)

        If obj.Verificar_matricula(Convert.ToString(id_alumno_ficha), Convert.ToString(ciclo), Convert.ToString(id_periodo)) >= 1 Then
            If obj.Verificar_otro_ciclo(id_alumno_ficha) >= 1 Then
                txt_ciclo.Text = obj.Verificar_otro_ciclo(id_alumno_ficha)
                ciclo = obj.Verificar_otro_ciclo(id_alumno_ficha)
                txtnom_cu.Text = obj1.consulta_nombre_curso_a(ciclo)
            End If
        End If
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
        id_periodo = cbx_periodo.SelectedValue
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'Dim Msg As Integer
        'Msg = MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Guardar?")
        'If (Msg = vbYes) Then
        If txt_nombre.Text = "" Or cbx_cursos.Text = "" Then
            MsgBox("ERROR: Seleccione los datos para la Matricula")
        Else
            If obj.Verificar_Periodo(cbx_periodo.SelectedValue) >= 1 Then
                If obj.Verificar_matricula(Convert.ToString(id_alumno_ficha), Convert.ToString(txt_ciclo.Text), Convert.ToString(cbx_periodo.SelectedValue)) >= 1 Then
                    MsgBox("El alumno ya se matriculo")
                    limpiar()
                Else
                    If obj.Verificar_matricula_reservada(Convert.ToString(id_alumno_ficha), Convert.ToString(cbx_periodo.SelectedValue)) >= 1 Then
                        If (MessageBox.Show("Desea actualizar datos de la Matricula Reservada", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                            obj.Actualizar_matricula_reservada(Convert.ToString(id_alumno_ficha), Convert.ToString(cbx_periodo.SelectedValue), Convert.ToString(cbx_cursos.SelectedValue))
                            MsgBox("Se actualizaron datos")
                            limpiar()
                        End If
                    Else
                        Try
                            Dim obj_matricula = New cls_n_matricula
                            obj_matricula.Matricula_Alumno_Codigo = id_alumno_ficha
                            obj_matricula.Matricula_Curso_Grupo_Codigo = cbx_cursos.SelectedValue
                            obj_matricula.Matricula_Periodo_Codigo = cbx_periodo.SelectedValue
                            obj_matricula.Matricula_Fecha_Creacion = Now()
                            obj_ln_matricula.Add_Matricula(obj_matricula)
                            'En el caso de alumnos becados
                            If txt_tipo_alumno.Text = "Becado" Then
                                Dim a As String = "BECADO"
                                Dim b As String = obj.consulta_id_matricula(Convert.ToString(id_alumno_ficha), Convert.ToString(cbx_cursos.SelectedValue), Convert.ToString(cbx_periodo.SelectedValue))
                                obj.guardar_asistencia(a, b)
                                MsgBox("Se Matriculo el alumno becado")
                            Else
                                Matricula_Imprimir_datos()
                            End If
                            'Me.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                End If
            Else
                MsgBox("El Periodo ya caduco")
            End If
          
        End If
        'End If
    End Sub
    Public Sub Matricula_Imprimir_datos()
        Dim _horario As String
        frm_matricula_imprimir.id_matricula_imp = Convert.ToInt32(obj.consulta_id_matricula(Convert.ToString(id_alumno_ficha), Convert.ToString(cbx_cursos.SelectedValue), Convert.ToString(cbx_periodo.SelectedValue)))
        frm_matricula_imprimir.id_curso_imp = Convert.ToInt32(obj.consulta_curso_grupo(Convert.ToString(cbx_cursos.SelectedValue)))
        frm_matricula_imprimir.nom_curso = Convert.ToString(obj.consulta_curso_nombre(Convert.ToString(cbx_cursos.SelectedValue)))
        frm_matricula_imprimir.nom_grupo = Convert.ToString(obj.consulta_nombre_grupo(Convert.ToString(cbx_cursos.SelectedValue)))
        _horario = Convert.ToString(obj.consulta_horario(Convert.ToString(cbx_cursos.SelectedValue)))
        frm_matricula_imprimir.horario_grupo = _horario
        frm_matricula_imprimir.num_telefono = Convert.ToString(obj.consulta_num_telefono(Convert.ToString(id_alumno_ficha)))
        frm_matricula_imprimir.id_persona = Convert.ToString(obj.consulta_id_persona(Convert.ToString(id_alumno_ficha)))
        frm_matricula_imprimir.id_curso_grupo = Convert.ToInt32(cbx_cursos.SelectedValue)
        frm_matricula_imprimir.id_alumno_ficha = id_alumno_ficha
        frm_matricula_imprimir.txt_nombre.Text = txt_nombre.Text
        frm_matricula_imprimir.Txt_horario.Text = _horario
        frm_matricula_imprimir.Txt_seccion.Text = obj.consulta_aula(Convert.ToString(cbx_cursos.SelectedValue))
        frm_matricula_imprimir.TxtMonto.Text = obj.consulta_costo_id_grupo(Convert.ToString(cbx_cursos.SelectedValue))
        frm_matricula_imprimir.txt_ciclo.Text = cbx_periodo.Text

        limpiar()
        frm_matricula_imprimir.ShowDialog()
    End Sub
    Public Sub limpiar()
        txt_nombre.Clear()
        txt_tipo_alumno.Clear()
        txt_plan_estudio.Clear()
        txt_codigo_alumno.Clear()
        txt_ciclo.Clear()
        txtnom_cu.Clear()
        Cargar()
        Cargar_Datos()
    End Sub
    Private Sub frm_matricula_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_matricula_activo = False
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        frm_principal.frm_matricula_activo = False
        Me.Close()
    End Sub

End Class

