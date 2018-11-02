Imports System.Configuration
Imports Negocio
Imports LogicaNegocios
Public Class frm_transferencia_matricula
    Dim obj As New Cls_Matricula
    Dim obj1 As New Cls_Anulacion_Matricula
    Dim id_alu_fic As Integer
    Dim nombre As String
    Dim id_matricula As Integer

    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private obj_ln_periodo As cls_ln_periodo
    Private id_alumno_ficha As Integer
    Private id_plan_estudio As Integer
    Private ciclo As Integer
    Dim nom_curso As String
    Dim nom_alumno As String
    Private frm_alumno_buscar_ As frm_alumno_buscar
    Public frm_alumno_buscar_activo As Boolean = False
    Public Sub Cargar()
        obj_ln_plan_estudio = New cls_ln_plan_estudio
        obj_ln_periodo = New cls_ln_periodo

        id_alu_fic = frm_anulacion_matricula.id_alu_fic
        nombre = frm_anulacion_matricula.nombre
        id_matricula = frm_anulacion_matricula.id_matricula
        txtnom_t.Text = nombre
        Txt_idmat.Text = id_matricula
        cbx_periodo.DataSource = obj_ln_periodo.List_Periodo_Abierto()
        cbx_periodo.DisplayMember = "Periodo_Nombre"
        cbx_periodo.ValueMember = "Periodo_Codigo"
    End Sub

    Private Sub frm_transferencia_matricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0.98
        Cargar()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        limpiar()
        frm_anulacion_matricula.Mostrar_alumnos_des()
        Me.Close()
    End Sub
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If (Not frm_alumno_buscar_activo) Then
            frm_alumno_buscar_ = New frm_alumno_buscar
            frm_alumno_buscar_.Show()
            frm_alumno_buscar_.Formnulario_Tranferencia_Matricula(Me, "frm_transferencia_matricula")
            frm_alumno_buscar_activo = True
        Else
            frm_alumno_buscar_.Activate()
        End If
    End Sub
    Public Sub Informacion(ByVal obj_alumno As cls_n_view_alumnos)
        GroupBox1.Enabled = True
        btn_Guardar.Enabled = True
        frm_alumno_buscar_activo = False
        id_alumno_ficha = obj_alumno.View_Alumno_Codigo_Alumno
        txt_codigo_alumno.Text = obj_alumno.View_Alumno_Codigo_Alumno
        nom_alumno = obj_alumno.View_Alumno_Nombre
        txt_nombre.Text = nom_alumno
        txt_tipo_alumno.Text = obj_alumno.View_Alumno_Estado
        txt_ciclo.Text = obj_alumno.View_Alumno_Ciclo
        ciclo = obj_alumno.View_Alumno_Ciclo
        nom_curso = Convert.ToString(obj1.consulta_nombre_curso_a(ciclo))
        txtnomcur.Text = nom_curso
        txt_plan_estudio.Text = obj_ln_plan_estudio.Get_Plan_Estudio_Por_Ficha_Alumno(id_alumno_ficha).Plan_Nombre
        id_plan_estudio = obj_ln_plan_estudio.Get_Plan_Estudio_Por_Ficha_Alumno(id_alumno_ficha).Plan_Codigo
        cbx_cursos.Focus()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If txt_nombre.Text = "" Or cbx_cursos.Text = "" Then
            MsgBox("ERROR: Seleccione los datos para la Matricula")
        Else
            If obj.Verificar_Periodo(cbx_periodo.SelectedValue) >= 1 Then
                If obj.Verificar_matricula(Convert.ToString(id_alumno_ficha), Convert.ToString(txt_ciclo.Text), Convert.ToString(cbx_periodo.SelectedValue)) >= 1 Then
                    MsgBox("El alumno ya se matriculo")
                    limpiar()
                Else
                    obj1.TransferirMatricula(id_matricula, ciclo, Convert.ToInt32(cbx_cursos.SelectedValue), nom_alumno, id_alumno_ficha, Convert.ToInt32(cbx_periodo.SelectedValue))
                    MsgBox("Se tranferio la Matricula")
                    limpiar()
                End If
            End If
        End If
    End Sub
    Public Sub limpiar()
        txt_nombre.Clear()
        txt_tipo_alumno.Clear()
        txt_plan_estudio.Clear()
        txt_codigo_alumno.Clear()
        txt_ciclo.Clear()
        txtnomcur.Clear()
        ciclo = 0
        id_alumno_ficha = 0
        id_plan_estudio = 0
        Cargar_Datos()
        GroupBox1.Enabled = False
        btn_Guardar.Enabled = False
    End Sub
    Public Sub Cargar_Datos()
        obj.Llenar_grupo_curso(cbx_cursos, Convert.ToString(ciclo), Convert.ToString(id_plan_estudio), Convert.ToString(cbx_periodo.SelectedValue))
    End Sub
    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        Cargar_Datos()
    End Sub
End Class