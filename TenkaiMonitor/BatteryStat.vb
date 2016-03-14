Public Class BatteryStat
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Close()
    End Sub

    Private Sub BatteryStat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AC電源の状態
        Dim pls As PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus
        Select Case pls
            Case PowerLineStatus.Offline
                BtryStatTbox.Text += "AC電源がオフラインです" & vbCrLf
                Exit Select
            Case PowerLineStatus.Online
                BtryStatTbox.Text += "AC電源がオンラインです" & vbCrLf
                Exit Select
            Case PowerLineStatus.Unknown
                BtryStatTbox.Text += "AC電源の状態は不明です" & vbCrLf
                Exit Select
        End Select

        'バッテリーの充電状態を取得する
        Dim bcs As BatteryChargeStatus =
            SystemInformation.PowerStatus.BatteryChargeStatus
        If bcs = BatteryChargeStatus.Unknown Then
            BtryStatTbox.Text += "不明です" & vbCrLf
        Else
            If (bcs And BatteryChargeStatus.High) =
                BatteryChargeStatus.High Then
                BtryStatTbox.Text += "充電レベルは、高い(66%より上)です" & vbCrLf
            End If
            If (bcs And BatteryChargeStatus.Low) =
                BatteryChargeStatus.Low Then
                BtryStatTbox.Text += "充電レベルは、低い(33%未満)です" & vbCrLf
            End If
            If (bcs And BatteryChargeStatus.Critical) =
                BatteryChargeStatus.Critical Then
                BtryStatTbox.Text += "充電レベルは、最低(5%未満)です" & vbCrLf
            End If
            If (bcs And BatteryChargeStatus.Charging) =
                BatteryChargeStatus.Charging Then
                BtryStatTbox.Text += "充電中です" & vbCrLf
            End If
            If (bcs And BatteryChargeStatus.NoSystemBattery) =
                BatteryChargeStatus.NoSystemBattery Then
                BtryStatTbox.Text += "バッテリーが存在しません" & vbCrLf
            End If
        End If

        'バッテリー残量（割合）
        Dim blp As Single = SystemInformation.PowerStatus.BatteryLifePercent
        BtryStatTbox.Text += "バッテリー残量は、" & blp * 100 & "%です" & vbCrLf

        'バッテリー残量（時間）
        Dim blr As Integer = SystemInformation.PowerStatus.BatteryLifeRemaining
        If -1 < blr Then
            BtryStatTbox.Text += "バッテリー残り時間は、" & blr & "秒です" & vbCrLf
        Else
            'AC電源がオンラインの時など
            BtryStatTbox.Text += "バッテリー残り時間は、不明です" & vbCrLf
        End If

        'バッテリーがフル充電された時の持ち時間（バッテリー駆動可能時間）
        Dim bfl As Integer = SystemInformation.PowerStatus.BatteryFullLifetime
        If -1 < bfl Then
            BtryStatTbox.Text += "バッテリー駆動可能時間は、" & bfl & "秒です" & vbCrLf
        Else
            BtryStatTbox.Text += "バッテリー駆動可能時間は、不明です" & vbCrLf
        End If
    End Sub
End Class