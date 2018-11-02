Public Class frm_otro_ciclo
    Dim obj As New Cls_Matricula
    Dim otro As Double
    Private Sub cbx_plan_est_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plan_est.SelectedIndexChanged
        Llenar_ciclo()
    End Sub
    Public Sub Llenar_ciclo()
        obj.Llenar_ciclo_con_planest1(cb_ciclo, Convert.ToString(cbx_plan_est.SelectedValue))
    End Sub

    Private Sub frm_otro_ciclo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_tipo_alumno(cbx_tp_est_alumno)
        obj.Llenar_plan_estudio(cbx_plan_est)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (MessageBox.Show("Desea agregar el otro ciclo opcional", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            otro = 1
            frm_ingreso_alumnos.Otro_curso_opcional(otro, Convert.ToInt32(cb_ciclo.SelectedValue))
            Me.Close()
        End If
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class