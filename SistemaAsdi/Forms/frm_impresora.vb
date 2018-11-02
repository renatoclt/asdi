Public Class frm_impresora

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If (MessageBox.Show("Desea guardar los cambios", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\Data\Impresora.txt", TxtImpresora.Text & ControlChars.NewLine, False)
            _impresora_a_usar = Convert.ToString(TxtImpresora.Text)
            MsgBox("Se guardo la informacion")
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_impresora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtImpresora.Text = _impresora_a_usar
    End Sub
End Class