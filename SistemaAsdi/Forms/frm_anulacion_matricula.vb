Public Class frm_anulacion_matricula
    Dim obj As New Cls_Matricula
    Dim obj1 As New Cls_Anulacion_Matricula
    Public id_alu_fic As Integer
    Public nombre As String
    Public id_matricula As Integer
    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_anulacion_matricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_periodo(Cbx_ciclo)
    End Sub

    Private Sub cbx_plan_estudio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plan_estudio.SelectedIndexChanged
        obj.Llenar_curso_ofertado(cbx_curso_ofertado, Convert.ToString(cbx_plan_estudio.SelectedValue), Convert.ToString(cbx_ciclo.SelectedValue))
    End Sub

    Private Sub cbx_ciclo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_ciclo.SelectedIndexChanged
        obj.Llenar_plan_estudio(cbx_plan_estudio, Convert.ToString(cbx_ciclo.SelectedValue))
    End Sub

    Private Sub cbx_curso_ofertado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_curso_ofertado.SelectedIndexChanged
        Mostrar_alumnos_des()
    End Sub

    Private Sub DgvAlumnos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvAlumnos.CellClick
        Dim i As Integer
        Dim resp As Integer
        i = DgvAlumnos.CurrentRow.Index
        id_alu_fic = DgvAlumnos.Item(0, i).Value
        nombre = DgvAlumnos.Item(1, i).Value
        id_matricula = DgvAlumnos.Item(2, i).Value
        resp = MsgBox(nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Alumno Seleccionado")
        If (resp = vbYes) Then
            txt_nomalum.Text = nombre
        End If
    End Sub

    Public Sub Mostrar_alumnos_des()
        txt_nomalum.Clear()
        obj1.Mostrar_alumnos_matricula(DgvAlumnos, Convert.ToString(cbx_ciclo.SelectedValue), Convert.ToString(cbx_curso_ofertado.SelectedValue))
    End Sub
    Private Sub btn_anulacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_anulacion.Click
        If txt_nomalum.Text = "" Then
            MsgBox("Seleccione un alumno")
        Else
            Dim resp As Integer
            resp = MsgBox("Desea anular la matricula del alumno(a): " + nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Asdi")
            If (resp = vbYes) Then
                obj1.Anulacion_de_Matricula(id_matricula)
                MsgBox("Se anulo la matricula")
                Mostrar_alumnos_des()
            End If
        End If
        
    End Sub

    Private Sub btn_desmat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_desmat.Click
        If txt_nomalum.Text = "" Then
            MsgBox("Seleccione un alumno")
        Else
            Dim resp As Integer
            resp = MsgBox("Desea desmatricular al alumno(a): " + nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Asdi")
            If (resp = vbYes) Then
                obj1.Desmatricular(id_matricula)
                MsgBox("Se desmatriculo el alumno")
                txt_nomalum.Clear()
                Mostrar_alumnos_des()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_nomalum.Text = "" Then
            MsgBox("Seleccione un alumno para tranferir la matricula")
        Else
            frm_transferencia_matricula.ShowDialog()
        End If
    End Sub
End Class