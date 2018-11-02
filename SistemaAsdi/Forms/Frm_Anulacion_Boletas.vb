Public Class Frm_Anulacion_Boletas
    Dim obj As New Cls_Matricula
    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        If obj.Verificar_boleta(Convert.ToString(Txtnum_recibo.Text)) = 1 Then
            If MsgBox("Desea anular la boleta", vbOKCancel, "CONFIRMACION") = vbOK Then
                obj.Anulacion_Boleta(Convert.ToString(Txtnum_recibo.Text))
                Dim num_bo As String = Txtnum_recibo.Text
                Txtnum_recibo.Clear()
                MsgBox("La boleta numero: " + num_bo + " a sido anulada")
            End If
        Else
            MsgBox("El codigo ingresado no existe")
        End If
    End Sub
End Class