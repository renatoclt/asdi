Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_modificar_profesor
    Private obj_n_view_profesor As cls_n_view_profesores
    Private obj_ln_view_profesor As cls_ln_view_profesores
    Private obj_n_persona As cls_n_persona
    Private obj_n_persona_anexo As cls_n_persona_anexo
    Private obj_n_profesor_ficha As cls_n_profesor_ficha
    Private obj_ln_persona As cls_ln_persona
    Private obj_ln_persona_anexo As cls_ln_persona_anexo
    Private obj_ln_profesor_ficha As cls_ln_profesor_ficha
    Private id_profesor_ficha As Integer
    Private id_persona As Integer
    Private nombre As String
    Private estado As Boolean
    Private frm_ingreso_profesores_ As frm_ingreso_profesores
    Public frm_ingreso_profesores_activo As Boolean = False

    Private Sub Cargar()
        obj_ln_view_profesor = New cls_ln_view_profesores
        obj_ln_persona = New cls_ln_persona
        obj_ln_persona_anexo = New cls_ln_persona_anexo
        obj_ln_profesor_ficha = New cls_ln_profesor_ficha
    End Sub

    Private Sub Cargar_datos()
        dg_profesor.DataSource = obj_ln_view_profesor.Buscar_View_Profesores_Todos_Nombres("")
        dg_profesor.Columns(0).HeaderText = "Codigo_Persona"
        dg_profesor.Columns(0).Visible = False
        dg_profesor.Columns(0).Width = 100
        dg_profesor.Columns(1).HeaderText = "Codigo_Alumno_Ficha"
        dg_profesor.Columns(1).Visible = False
        dg_profesor.Columns(1).Width = 150
        dg_profesor.Columns(2).HeaderText = "Nombre del Alumno"
        dg_profesor.Columns(2).Width = 280
        dg_profesor.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_profesor.Columns(3).HeaderText = "Estado"
        dg_profesor.Columns(3).Visible = False
        dg_profesor.Columns(3).Width = 80
        dg_profesor.Columns(4).HeaderText = "Estado"
        dg_profesor.Columns(4).Width = 60
        dg_profesor.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_profesor.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        btn_Editar.Enabled = False
    End Sub

    Private Sub frm_modificar_profesor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub dg_profesor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_profesor.CellContentClick, dg_profesor.CellClick
        Dim i As Integer
        Dim resp As Integer
        i = dg_profesor.CurrentRow.Index
        id_persona = dg_profesor.Item(0, i).Value
        id_profesor_ficha = dg_profesor.Item(1, i).Value
        nombre = dg_profesor.Item(2, i).Value
        estado = dg_profesor.Item(3, i).Value
        resp = MsgBox(nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Docente Seleccionado")
        If (resp = vbYes) Then
            btn_Editar.Enabled = True
            txt_nombre.Text = nombre
            btn_Editar.Focus()
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        dg_profesor.DataSource = obj_ln_view_profesor.Buscar_View_Profesores_Todos_Nombres(txt_nombre.Text)
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (Not frm_ingreso_profesores_activo) Then
            frm_ingreso_profesores_ = New frm_ingreso_profesores
            frm_ingreso_profesores_.Show()
            frm_ingreso_profesores_.Modificar(id_persona, Me)
            frm_ingreso_profesores_activo = True
        Else
            frm_ingreso_profesores_.Modificar(id_persona, Me)
            frm_ingreso_profesores_.Activate()
        End If
    End Sub

    Private Sub frm_modificar_profesor_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_modificar_profesor_activo = False
    End Sub
End Class