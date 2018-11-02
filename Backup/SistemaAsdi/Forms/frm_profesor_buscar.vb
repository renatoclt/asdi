Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_profesor_buscar
    Private obj_n_view_profesor As cls_n_view_profesores
    Private obj_ln_view_profesor As cls_ln_view_profesores
    Private id_profesor_ficha As Integer
    Private id_persona As Integer
    Private nombre As String
    Private estado As String

    Private Sub Cargar()
        obj_n_view_profesor = New cls_n_view_profesores
        obj_ln_view_profesor = New cls_ln_view_profesores
    End Sub

    Private Sub Cargar_datos()
        dg_profesor.DataSource = obj_ln_view_profesor.Buscar_View_Profesores_Activos_Nombres("")
        dg_profesor.Columns(0).HeaderText = "Codigo_Persona"
        dg_profesor.Columns(0).Visible = False
        dg_profesor.Columns(0).Width = 100
        dg_profesor.Columns(1).HeaderText = "Codigo_Profesor_Ficha"
        dg_profesor.Columns(1).Visible = False
        dg_profesor.Columns(1).Width = 150
        dg_profesor.Columns(2).HeaderText = "Nombre del Alumno"
        dg_profesor.Columns(2).Width = dg_profesor.Width - 20
        dg_profesor.Columns(3).Width = 80
        dg_profesor.Columns(3).HeaderText = "Estado"
        dg_profesor.Columns(3).Width = 60
        dg_profesor.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_profesor.Columns(3).Visible = False
        btn_Aceptar.Enabled = False
        Global_variables.id_profesor_ficha = Nothing
        Global_variables.id_persona = Nothing
    End Sub

    Private Sub frm_profesor_buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        dg_profesor.DataSource = obj_ln_view_profesor.Buscar_View_Profesores_Activos_Nombres(txt_nombre.Text)
    End Sub

    Private Sub dg_profesor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_profesor.CellClick, dg_profesor.CellDoubleClick, dg_profesor.CellContentDoubleClick, dg_profesor.CellContentClick
        Dim i As Integer
        Dim resp As Integer
        i = dg_profesor.CurrentRow.Index
        id_persona = dg_profesor.Item(0, i).Value
        id_profesor_ficha = dg_profesor.Item(1, i).Value
        nombre = dg_profesor.Item(2, i).Value
        estado = dg_profesor.Item(3, i).Value
        resp = MsgBox(nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Docente Seleccionado")
        If (resp = vbYes) Then
            btn_Aceptar.Enabled = True
            txt_nombre.Text = nombre
            btn_Aceptar.Focus()
        End If
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Global_variables.id_persona = Me.id_persona
        Global_variables.id_alumno_ficha = Me.id_profesor_ficha
        If (Global_variables.form_buscar_alumno = "frm_curso_grupo") Then
            'frm_principal.frm_tramite_.txt_nombre.Text = nombre
            'frm_principal.frm_tramite_.frm_alumno_buscar_activo = False
            'frm_principal.frm_tramite_.btn_Guardar.Focus()
        End If
        Me.Close()
    End Sub

End Class