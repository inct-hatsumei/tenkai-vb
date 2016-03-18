Public Class BluetoothConfig
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        My.Settings.BluetoothPort = BluetoothSppPorts.Text
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub BluetoothConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BluetoothSppPorts.Text = My.Settings.BluetoothPort
    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles BluetoothSppPorts.DropDown
        Dim PortList As String() = BluetoothSppConfig.GetPortNames()
        Dim port As String
        BluetoothSppPorts.Items.Clear()
        For Each port In PortList
            BluetoothSppPorts.Items.Add(port)
        Next port
    End Sub
End Class