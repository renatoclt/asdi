Public Class frm_cd_separata

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If (MessageBox.Show("Desea guardar los cambios", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\Data\Data.txt", txtCD.Text & ControlChars.NewLine & _
            TxtSeparata.Text & ControlChars.NewLine, False)
            _precio_cd = Convert.ToDouble(txtCD.Text)
            _precio_separata = Convert.ToDouble(TxtSeparata.Text)
            MsgBox("Se guardo la informacion")
        End If
    End Sub

    Private Sub frm_cd_separata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCD.Text = Format(_precio_cd, "##0.00")
        TxtSeparata.Text = Format(_precio_separata, "##0.00")
    End Sub
End Class