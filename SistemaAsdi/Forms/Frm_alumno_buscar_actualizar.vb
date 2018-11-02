Public Class Frm_alumno_buscar_actualizar
    Dim obj As New Cls_Matricula
    Dim id_alu_fic As Integer
    Dim id_matri As Integer
    Dim nombre As String
    Private frm_matricula_ As frm_actualizar_matricula
    Private frm_tramite_ As Frm_venta_separatas
    Private frm_ventas_ As frm_ventas_otros
    Private form_buscar_alumno As String

    Private Sub Frm_alumno_buscar_actualizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_periodo(cbx_periodo)
        obj.Mostrar_alumnos(dg_alumno, Convert.ToString(cbx_periodo.SelectedValue))
    End Sub
    Public Sub Formnulario_Matricular(ByVal frm As frm_actualizar_matricula, ByVal form_buscar_alumno_ As String)
        frm_matricula_ = frm
        form_buscar_alumno = form_buscar_alumno_
    End Sub
    Public Sub Formnulario_Tramitar(ByVal frm As Frm_venta_separatas, ByVal form_buscar_alumno_ As String)
        frm_tramite_ = frm
        form_buscar_alumno = form_buscar_alumno_
    End Sub
    Public Sub Formnulario_Ventas(ByVal frm As frm_ventas_otros, ByVal form_buscar_alumno_ As String)
        frm_ventas_ = frm
        form_buscar_alumno = form_buscar_alumno_
    End Sub
    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Select Case form_buscar_alumno
            Case "frm_matricula"
                frm_actualizar_matricula.frm_alumno_buscar_activo = False
                frm_actualizar_matricula.Buscar_nombre_persona(Convert.ToString(id_alu_fic), Convert.ToString(cbx_periodo.SelectedValue), id_matri)
                frm_actualizar_matricula.Cargar_Datos()
                txt_nombre.Clear()
            Case "frm_tramite"
                Frm_venta_separatas.frm_alumno_buscar_activo = False
                Frm_venta_separatas.Buscar_nombre_persona(Convert.ToString(id_alu_fic), Convert.ToString(cbx_periodo.SelectedValue))
                txt_nombre.Clear()
            Case "frm_ventas"
                frm_ventas_otros.frm_alumno_buscar_activo = False
                frm_ventas_otros.Buscar_nombre_persona(Convert.ToString(id_alu_fic), Convert.ToString(cbx_periodo.SelectedValue))
                txt_nombre.Clear()
        End Select
        Me.Close()
    End Sub

    Private Sub dg_alumno_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_alumno.CellContentClick
        Try
            Dim i As Integer
            Dim resp As Integer
            i = dg_alumno.CurrentRow.Index
            nombre = dg_alumno.Item(0, i).Value
            id_alu_fic = dg_alumno.Item(3, i).Value
            id_matri = dg_alumno.Item(4, i).Value
            resp = MsgBox(nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Alumno Seleccionado")
            If (resp = vbYes) Then
                btn_Aceptar.Enabled = True
                txt_nombre.Text = nombre
                btn_Aceptar.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        obj.Buscar_alumnos(dg_alumno, Convert.ToString(txt_nombre.Text), Convert.ToString(cbx_periodo.SelectedValue))
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        obj.Mostrar_alumnos(dg_alumno, Convert.ToString(cbx_periodo.SelectedValue))
    End Sub
End Class