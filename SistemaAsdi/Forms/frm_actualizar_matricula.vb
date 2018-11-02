Imports System.Configuration
Imports Negocio
Imports LogicaNegocios
Public Class frm_actualizar_matricula
    Dim obj As New Cls_Matricula
    Dim id_alumno_ficha As Integer
    Private obj_ln_view_curso_grupos As cls_ln_view_curso_grupos
    Private id_plan_est As Integer
    Private id_periodo As Integer
    Private id_matricula As Integer
    Private ciclo As Integer
    Private cd As String
    Dim id_grupo As Integer
    Dim nom_curso As String
    Private frm_alumno_buscar_ As Frm_alumno_buscar_actualizar
    Public frm_alumno_buscar_activo As Boolean = False

    Public Sub Buscar_nombre_persona(ByVal a As String, ByVal b As String, ByVal c As Integer)
        txt_nombre.Text = obj.consulta_nombre_persona(a)
        txt_tipo_alumno.Text = obj.consulta_tipo_alumno(a)
        txt_plan_estudio.Text = obj.consulta_plan_estudios(a)
        txt_codigo_alumno.Text = a
        id_plan_est = Convert.ToInt32(obj.consulta_id_plan_estudios(a))
        id_alumno_ficha = Convert.ToInt32(a)
        'id_matricula = Convert.ToInt32(obj.consulta_id_matricula_actualizar(a, b))
        id_matricula = c
        id_grupo = obj.Obtener_id_grupo_curso1(a, b, Convert.ToString(id_matricula))
        ciclo = Convert.ToInt32(obj.consulta_curso_nombre2(id_grupo))
        nom_curso = Convert.ToString(obj.consulta_curso_nombre(Convert.ToString(id_grupo)))
        txtnomcur.Text = nom_curso
        txt_ciclo.Text = Convert.ToString(ciclo)

        TxtIdMatricula.Text = Convert.ToString(id_matricula)
        cbx_periodo.SelectedValue = b
        cd = "Ok"
    End Sub
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If (Not frm_alumno_buscar_activo) Then
            limpiar()
            frm_alumno_buscar_ = New Frm_alumno_buscar_actualizar
            frm_alumno_buscar_.Show()
            frm_alumno_buscar_.Formnulario_Matricular(Me, "frm_matricula")
            frm_alumno_buscar_activo = True
        Else
            frm_alumno_buscar_.Activate()
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_actualizar_matricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_periodo(cbx_periodo)
    End Sub
    Public Sub Cargar_Datos()
        obj.Llenar_grupo_curso(cbx_cursos, Convert.ToString(ciclo), Convert.ToString(id_plan_est), Convert.ToString(cbx_periodo.SelectedValue))
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If cd = "Ok" Then
            Cargar_Datos()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If (MessageBox.Show("Desea actualizar los datos de Matricula", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            If obj.Verificar_Periodo(cbx_periodo.SelectedValue) >= 1 Then
                obj.Actualizar_matricula(id_matricula, Convert.ToInt32(cbx_cursos.SelectedValue), Convert.ToInt32(cbx_periodo.SelectedValue))
                MsgBox("Se actualizaron los datos")
                limpiar()
            Else
                MsgBox("El Periodo ya caduco")
            End If
          
        End If
    End Sub
    Public Sub limpiar()
        txt_nombre.Clear()
        txt_tipo_alumno.Clear()
        txt_plan_estudio.Clear()
        txt_codigo_alumno.Clear()
        TxtIdMatricula.Clear()
        txtnomcur.Clear()
        id_plan_est = 0
        id_alumno_ficha = 0
        id_matricula = 0
        ciclo = 0
        txt_ciclo.Clear()
        cd = "No"
        Cargar_Datos()
    End Sub
End Class