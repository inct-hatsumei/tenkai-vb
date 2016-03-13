Public Class Outlier
    Private Sub NormalValueConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CpuUseOutTbox.Text = My.Settings.CpuOut
        MemUseOutTbox.Text = My.Settings.MemOut
        AcelOutTbox.Text = My.Settings.AcelOut
        TempOutTbox.Text = My.Settings.TempOut
        BtryOutTbox.Text = My.Settings.BtryOut
        OprTimeOutTbox.Text = My.Settings.OprtimeOut
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        My.Settings.CpuOut = CpuUseOutTbox.Text
        My.Settings.MemOut = MemUseOutTbox.Text
        My.Settings.AcelOut = AcelOutTbox.Text
        My.Settings.TempOut = TempOutTbox.Text
        My.Settings.BtryOut = BtryOutTbox.Text
        My.Settings.OprtimeOut = OprTimeOutTbox.Text
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub
End Class