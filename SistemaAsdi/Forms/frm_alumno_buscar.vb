Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_alumno_buscar
    Private obj_n_view_alumno As cls_n_view_alumnos
    Private obj_ln_view_alumno As cls_ln_view_alumnos
    Private obj_n_persona As cls_n_persona
    Private obj_n_persona_anexo As cls_n_persona_anexo
    Private obj_n_alumno_ficha As cls_n_alumno_ficha
    Private obj_ln_persona As cls_ln_persona
    Private obj_ln_persona_anexo As cls_ln_persona_anexo
    Private obj_ln_alumno_ficha As cls_ln_alumno_ficha
    Private obj_ln_plan_estudio As cls_ln_plan_estudio

    Private frm_matricula_ As frm_matricula
    Private frm_tramite_ As frm_tramite
    Private frm_matricula_examen As frm_matricula_examen
    Private frm_transferencia_matricula As frm_transferencia_matricula

    Private form_buscar_alumno As String

    Private id_alumno_ficha As Integer
    Private nombre As String

    Private Sub Cargar()
        obj_ln_view_alumno = New cls_ln_view_alumnos
        obj_ln_persona = New cls_ln_persona
        obj_ln_persona_anexo = New cls_ln_persona_anexo
        obj_ln_alumno_ficha = New cls_ln_alumno_ficha
        form_buscar_alumno = ""
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
        btn_Aceptar.Enabled = False
    End Sub

    Public Sub Formnulario_Matricular(ByVal frm As frm_matricula, ByVal form_buscar_alumno_ As String)
        frm_matricula_ = frm
        form_buscar_alumno = form_buscar_alumno_
    End Sub

    Public Sub Formnulario_Tramitar(ByVal frm As frm_tramite, ByVal form_buscar_alumno_ As String)
        frm_tramite_ = frm
        form_buscar_alumno = form_buscar_alumno_
    End Sub

    Public Sub Formnulario_Matricular_Examen(ByVal frm As frm_matricula_examen, ByVal form_buscar_alumno_ As String)
        frm_matricula_examen = frm
        form_buscar_alumno = form_buscar_alumno_
    End Sub

    Public Sub Formnulario_Tranferencia_Matricula(ByVal frm As frm_transferencia_matricula, ByVal form_buscar_alumno_ As String)
        frm_transferencia_matricula = frm
        form_buscar_alumno = form_buscar_alumno_
    End Sub

    Private Sub frm_alumno_buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0.93
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        dg_alumno.DataSource = obj_ln_view_alumno.Buscar_View_Alumnos_Nombres(txt_nombre.Text)
    End Sub

    Private Sub dg_alumno_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_alumno.CellClick, dg_alumno.CellDoubleClick, dg_alumno.CellContentDoubleClick, dg_alumno.CellContentClick
        Dim i As Integer
        Dim resp As Integer
        i = dg_alumno.CurrentRow.Index
        id_alumno_ficha = dg_alumno.Item(1, i).Value
        nombre = dg_alumno.Item(2, i).Value
        resp = MsgBox(nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Alumno Seleccionado")
        If (resp = vbYes) Then
            btn_Aceptar.Enabled = True
            txt_nombre.Text = nombre 
            btn_Aceptar.Focus()
        End If
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Select Case form_buscar_alumno
            Case "frm_tramite"
                frm_tramite_.Informacion(obj_ln_view_alumno.Obtener_View_Alumnos(id_alumno_ficha))
            Case "frm_matricula"
                frm_matricula_.Informacion(obj_ln_view_alumno.Obtener_View_Alumnos(id_alumno_ficha))
            Case "frm_matricula_examen"
                frm_matricula_examen.frm_alumno_buscar_activo = False
                frm_matricula_examen.Buscar_nombre_persona(Convert.ToString(id_alumno_ficha))
            Case "frm_transferencia_matricula"
                frm_transferencia_matricula.frm_alumno_buscar_activo = False
                frm_transferencia_matricula.Informacion(obj_ln_view_alumno.Obtener_View_Alumnos(id_alumno_ficha))
        End Select
        Me.Close()
    End Sub

End Class