Imports System.Configuration
Imports Negocio
Imports LogicaNegocios

Public Class frm_modificar_trabajador
    Private obj_n_view_trabajador As cls_n_view_trabajadores
    Private obj_ln_view_trabajador As cls_ln_view_trabajadores
    Private obj_n_persona As cls_n_persona
    Private obj_n_persona_anexo As cls_n_persona_anexo
    Private obj_n_profesor_ficha As cls_n_profesor_ficha
    Private obj_ln_persona As cls_ln_persona
    Private obj_ln_persona_anexo As cls_ln_persona_anexo
    Private obj_ln_trabajador_ficha As cls_ln_trabajador_ficha
    Private id_trabajador_ficha As Integer
    Private id_persona As Integer
    Private nombre As String
    Private usuario As String
    Private contrasenia As String
    Private activo As Boolean
    Private frm_ingreso_trabajadores_ As frm_ingreso_trabajadores
    Public frm_ingreso_trabajadores_activo As Boolean = False

    Private Sub Cargar()
        obj_ln_view_trabajador = New cls_ln_view_trabajadores
        obj_ln_persona = New cls_ln_persona
        obj_ln_persona_anexo = New cls_ln_persona_anexo
        obj_ln_trabajador_ficha = New cls_ln_trabajador_ficha
    End Sub

    Private Sub Cargar_datos()
        dg_trabajador.DataSource = obj_ln_view_trabajador.Buscar_View_Trabajadores_Todos_Nombres("")
        dg_trabajador.Columns(0).HeaderText = "Codigo_Persona"
        dg_trabajador.Columns(0).Visible = False
        dg_trabajador.Columns(0).Width = 100
        dg_trabajador.Columns(1).HeaderText = "Codigo_Alumno_Ficha"
        dg_trabajador.Columns(1).Visible = False
        dg_trabajador.Columns(1).Width = 130
        dg_trabajador.Columns(2).HeaderText = "Nombre del Alumno"
        dg_trabajador.Columns(2).Width = 250
        dg_trabajador.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_trabajador.Columns(3).HeaderText = "Usuario"
        dg_trabajador.Columns(3).Width = 80
        dg_trabajador.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_trabajador.Columns(4).HeaderText = "Contraseña"
        dg_trabajador.Columns(4).Visible = False
        dg_trabajador.Columns(4).Width = 150
        dg_trabajador.Columns(5).HeaderText = "Activo"
        dg_trabajador.Columns(5).Visible = False
        dg_trabajador.Columns(5).Width = 80
        dg_trabajador.Columns(6).HeaderText = "Activo"
        dg_trabajador.Columns(6).Width = 50
        dg_trabajador.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_trabajador.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        btn_Editar.Enabled = False
    End Sub

    Private Sub frm_modificar_trabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Cargar_datos()
    End Sub

    Private Sub dg_trabajador_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_trabajador.CellContentClick, dg_trabajador.CellClick
        Dim i As Integer
        Dim resp As Integer
        i = dg_trabajador.CurrentRow.Index
        id_persona = dg_trabajador.Item(0, i).Value
        id_trabajador_ficha = dg_trabajador.Item(1, i).Value
        nombre = dg_trabajador.Item(2, i).Value
        usuario = dg_trabajador.Item(3, i).Value
        contrasenia = dg_trabajador.Item(4, i).Value
        activo = dg_trabajador.Item(5, i).Value
        resp = MsgBox(nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Trabajador Seleccionado")
        If (resp = vbYes) Then
            btn_Editar.Enabled = True
            txt_nombre.Text = nombre
            btn_Editar.Focus()
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        dg_trabajador.DataSource = obj_ln_view_trabajador.Buscar_View_Trabajadores_Todos_Nombres(txt_nombre.Text)
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        If (Not frm_ingreso_trabajadores_activo) Then
            frm_ingreso_trabajadores_ = New frm_ingreso_trabajadores
            frm_ingreso_trabajadores_.Show()
            frm_ingreso_trabajadores_.Modificar(id_persona, Me)
            frm_ingreso_trabajadores_activo = True
        Else
            frm_ingreso_trabajadores_.Modificar(id_persona, Me)
            frm_ingreso_trabajadores_.Activate()
        End If
    End Sub

    Private Sub frm_modificar_trabajador_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.frm_modificar_trabajador_activo = False
    End Sub
End Class