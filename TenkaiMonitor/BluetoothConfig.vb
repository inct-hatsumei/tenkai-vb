Public Class BluetoothConfig
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        My.Settings.BluetoothPort = PortNumUd.Value
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub BluetoothConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PortNumUd.Value = My.Settings.BluetoothPort
    End Sub
End Class