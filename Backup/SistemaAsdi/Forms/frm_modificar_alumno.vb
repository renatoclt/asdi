Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_modificar_alumno
    Private obj_n_view_alumno As cls_n_view_alumnos
    Private obj_ln_view_alumno As cls_ln_view_alumnos
    Private obj_n_persona As cls_n_persona
    Private obj_n_persona_anexo As cls_n_persona_anexo
    Private obj_n_alumno_ficha As cls_n_alumno_ficha
    Private obj_ln_persona As cls_ln_persona
    Private obj_ln_persona_anexo As cls_ln_persona_anexo
    Private obj_ln_alumno_ficha As cls_ln_alumno_ficha
    Private obj_ln_plan_estudio As cls_ln_plan_estudio
    Private id_alumno_ficha As Integer
    Private id_persona As Integer
    Private nombre As String
    Private ciclo As Integer
    Private periodo_inicio As String
    Private estado As String
    Private frm_ingreso_alumnos_ As frm_ingreso_alumnos
    Public frm_ingreso_alumnos_activo As Boolean = False

    Private Sub Cargar()
        obj_ln_view_alumno = New cls_ln_view_alumnos
        obj_ln_persona = New cls_ln_persona
        obj_ln_persona_anexo = New cls_ln_persona_anexo
        obj_ln_alumno_ficha = New cls_ln_alumno_ficha
        obj_ln_plan_estudio = New cls_ln_plan_estudio
    End Sub

    Private Sub Cargar_datos()
        dg_alumno.DataSource = obj_ln_view_alumno.Buscar_View_Alumnos_Nombres("")
        dg_alumno.Columns(0).HeaderText = "Codigo_Persona"
        dg_alumno.Columns(0).Visible = False
        dg_alumno.Columns(0).Width = 100
        dg_alumno.Columns(1).HeaderText = "Codigo_Alumno_Ficha"
        dg_alumno.Columns(1).Visible = False
        dg_alumno.Columns(1).Width = 150
        dg_alumno.Columns(2).HeaderText = "Nombre del Alumno"
        dg_alumno.Columns(2).Width = 280
        dg_alumno.Columns(3).HeaderText = "Ciclo"
        dg_alumno.Columns(3).Width = 40
        dg_alumno.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_alumno.Columns(4).HeaderText = "Periodo"
        dg_alumno.Columns(4).Visible = False
        dg_alumno.Columns(5).Width = 80
        dg_alumno.Columns(5).HeaderText = "Estado"
        dg_alumno.Columns(5).Width = 60
        dg_alumno.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btn_Editar.Enabled = False
    End Sub

    Private Sub frm_modificar_alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub dg_alumno_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_alumno.CellContentClick, dg_alumno.CellClick
        Dim i As Integer
        Dim resp As Integer
        i = dg_alumno.CurrentRow.Index
        id_persona = dg_alumno.Item(0, i).Value
        id_alumno_ficha = dg_alumno.Item(1, i).Value
        nombre = dg_alumno.Item(2, i).Value
        ciclo = dg_alumno.Item(3, i).Value
        periodo_inicio = dg_alumno.Item(4, i).Value
        estado = dg_alumno.Item(5, i).Value
        resp = MsgBox(nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Alumno Seleccionado")
        If (resp = vbYes) Then
            btn_Editar.Enabled = True
            txt_nombre.Text = nombre
            btn_Editar.Focus()
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        dg_alumno.DataSource = obj_ln_view_alumno.Buscar_View_Alumnos_Nombres(txt_nombre.Text)
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (Not frm_ingreso_alumnos_activo) Then
            frm_ingreso_alumnos_ = New frm_ingreso_alumnos
            frm_ingreso_alumnos_.Show()
            frm_ingreso_alumnos_.Modificar(id_persona, Me)
            frm_ingreso_alumnos_activo = True
        Else
            frm_ingreso_alumnos_.Modificar(id_persona, Me)
            frm_ingreso_alumnos_.Activate()
        End If
    End Sub

    Private Sub frm_modificar_alumno_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_modificar_alumno_activo = False
    End Sub
End Class