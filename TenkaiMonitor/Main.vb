Imports System.Text
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Main
    Dim SjisEnc As Encoding = Encoding.GetEncoding("Shift_JIS")
    Dim PortNo As String
    Dim DataNo As Integer = 0
    Dim byteNum As Integer = 0
    'グラフ関連
    Dim AcelDataSet As New DataSet
    Dim AcelDataTable As New DataTable
    Dim AcelDataTableRow As DataRow
    Dim AcelDatasetDelete As Boolean = False
    Dim ProcDataSet As New DataSet
    Dim ProcDataTable As New DataTable
    Dim ProcDataTableRow As DataRow
    Dim ProcDatasetDelete As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeColor(My.Settings.Color)
        InitializeAcelChart()
        JstClock.Enabled = True
    End Sub
    Delegate Sub DataDelegate(ByVal sdata As String)
    Private Sub BluetoothSpp_DataReceived(ByVal sender As Object, ByVal e As EventArgs) Handles BluetoothSpp.DataReceived
        Dim ReceivedData As String = " " '受信データ用変数を宣言します 
        Try
            ReceivedData = BluetoothSpp.ReadExisting    'データを受信します 
        Catch ex As Exception
            ReceivedData = ex.Message   '例外処理を行います 
        End Try 'Invokeメソッドにより実行されるメソッドへのデリゲートの宣言を行い、受信データを表示します 
        Dim adre As New DataDelegate(AddressOf Display)
        Invoke(adre, ReceivedData)
    End Sub
    Private Sub Display(ByVal ReceivedData As String)
        byteNum += SjisEnc.GetByteCount(ReceivedData)
        DataNo += 1
        Dim ReceivedDataObj As Object
        ReceivedDataObj = Split(ReceivedData, ",")
        MissTimeTbox.Text = ReceivedDataObj(0)

        DataNoTbox.Text = DataNo
        CpuUseTbox.Text = ReceivedDataObj(1)
        MemUseTbox.Text = ReceivedDataObj(2)
        TempTbox.Text = ReceivedDataObj(3)
        BtryTbox.Text = ReceivedDataObj(4)
        LatTbox.Text = ReceivedDataObj(5)
        LonTbox.Text = ReceivedDataObj(6)
        AdvTbox.Text = ReceivedDataObj(7)
        AcelXTbox.Text = ReceivedDataObj(8)
        AcelYTbox.Text = ReceivedDataObj(9)
        AcelZTbox.Text = ReceivedDataObj(10)
        RcpDataTbox.Text =
            MissTimeTbox.Text & "," & CpuUseTbox.Text & "," &
            MemUseTbox.Text & "," & TempTbox.Text & "," &
            BtryTbox.Text & "," & LatTbox.Text & "," &
            LonTbox.Text & "," & AdvTbox.Text & "," &
            AcelXTbox.Text & "," & AcelYTbox.Text & "," &
            AcelZTbox.Text & "," & vbCrLf & RcpDataTbox.Text
        TrafTbox.Text = byteNum / 1024
        showAcelChart(AcelXTbox.Text, AcelYTbox.Text, AcelZTbox.Text)
        showProcChart(CpuUseTbox.Text, MemUseTbox.Text)
    End Sub
    Private Sub ClearBtn_Click_1(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Media.SystemSounds.Exclamation.Play()
        If MessageBox.Show("クリアしますか?", "確認ダイアログ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) = DialogResult.Yes Then
            DataNoTbox.Text = ""
            CpuUseTbox.Text = ""
            MemUseTbox.Text = ""
            TempTbox.Text = ""
            BtryTbox.Text = ""
            LatTbox.Text = ""
            LonTbox.Text = ""
            AdvTbox.Text = ""
            AcelXTbox.Text = ""
            AcelYTbox.Text = ""
            AcelZTbox.Text = ""
            OprTimeTbox.Text = ""
            TrafTbox.Text = ""
            RcpDataTbox.Text = ""
            SendComTBox.Text = ""
            DataNo = 0
            '初期化
            AcelChart.Series.Clear()
            ProcChart.Series.Clear()
        End If
    End Sub
    Private Sub ExitBtn_Click_1(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Close()
    End Sub
    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        My.Settings.Color = Color.Black
        ChangeColor(Color.Black)
    End Sub
    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        My.Settings.Color = Color.White
        ChangeColor(Color.White)
    End Sub
    Private Sub LogSaveConfig_Click(sender As Object, e As EventArgs) Handles LogSaveConfig.Click
        Dim LogSaveConf As New LogSaveConfig()
        LogSaveConf.ShowDialog(Me)
        LogSaveConf.Dispose()
    End Sub
    Private Sub BluetoothConfig_Click(sender As Object, e As EventArgs) Handles BluetoothConfig.Click
        Dim BTConf As New BluetoothConfig()
        BTConf.ShowDialog(Me)
        BTConf.Dispose()
    End Sub
    Private Function ChangeColor(bgcolor As Color)
        Me.BackColor = bgcolor
        MissTimeTbox.BackColor = bgcolor
        DataNoTbox.BackColor = bgcolor
        CpuUseTbox.BackColor = bgcolor
        MemUseTbox.BackColor = bgcolor
        TempTbox.BackColor = bgcolor
        BtryTbox.BackColor = bgcolor
        LatTbox.BackColor = bgcolor
        LonTbox.BackColor = bgcolor
        AdvTbox.BackColor = bgcolor
        AcelXTbox.BackColor = bgcolor
        AcelYTbox.BackColor = bgcolor
        AcelZTbox.BackColor = bgcolor
        OprTimeTbox.BackColor = bgcolor
        TrafTbox.BackColor = bgcolor
        RcpDataTbox.BackColor = bgcolor
        JstTbox.BackColor = bgcolor
        ClearBtn.BackColor = bgcolor
        LogSaveBtn.BackColor = bgcolor
        ExitBtn.BackColor = bgcolor
        SendComTBox.BackColor = bgcolor
        SendComBtn.BackColor = bgcolor
        CancelComBtn.BackColor = bgcolor
        GroupBox1.BackColor = bgcolor
        GroupBox2.BackColor = bgcolor
        GroupBox3.BackColor = bgcolor
        GroupBox4.BackColor = bgcolor
        GroupBox5.BackColor = bgcolor
        GroupBox6.BackColor = bgcolor

        AcelChart.ChartAreas(0).BackColor = bgcolor
    End Function
    Private Function BluetoothConnect(connect As Boolean) As Boolean
        PortNo = My.Settings.BluetoothPort
        Try
            If connect = True Then
                If BluetoothSpp.IsOpen = True Then
                    MsgBox(PortNo & "はすでにオープンされています。")
                    Return True
                End If
                BluetoothSpp.PortName = PortNo
                BluetoothSpp.Open()
                BluetoothSpp.Encoding = Encoding.GetEncoding(65001)
                Return True
            ElseIf connect = False
                BluetoothSpp.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub BatteryStat_Click(sender As Object, e As EventArgs) Handles BatteryStat.Click
        Dim BatteryStat As New BatteryStat()
        BatteryStat.ShowDialog(Me)
        BatteryStat.Dispose()
    End Sub
    Private Sub OSInfo_Click(sender As Object, e As EventArgs) Handles OSInfo.Click
        Dim osinfo As New OSInfo()
        osinfo.ShowDialog(Me)
        osinfo.Dispose()
    End Sub
    Private Sub JstClock_Tick(sender As Object, e As EventArgs) Handles JstClock.Tick
        JstTbox.Text = Date.Now.ToString("yyyy年MM月dd日　HH時mm分ss秒")
    End Sub
    Private Sub OutlierConfig_Click(sender As Object, e As EventArgs) Handles OutlierConfig.Click
        Dim outlierconfig As New Outlier()
        outlierconfig.ShowDialog(Me)
        outlierconfig.Dispose()
    End Sub
    Private Sub MissionStart_Click(sender As Object, e As EventArgs) Handles MissionStart.Click
        If BluetoothConnect(True) = True Then
            MsgBox("Connect Success")
        Else
            Media.SystemSounds.Exclamation.Play()
            MsgBox("Connect Error")
        End If
    End Sub
    Private Sub MissionFinish_Click(sender As Object, e As EventArgs) Handles MissionFinish.Click
        If BluetoothConnect(False) = True Then
            MsgBox("Disconnect Success")
        Else
            MsgBox("Disconnect Error")
        End If
    End Sub
    Private Function showProcChart(cpu As String, mem As String)
        'データの追加
        ProcDataTableRow = ProcDataSet.Tables(0).NewRow
        ProcDataTableRow(0) = Date.Now.ToString("HH:mm:ss")
        ProcDataTableRow(1) = Single.Parse(cpu)
        ProcDataTableRow(2) = Single.Parse(mem)

        ProcDataSet.Tables(0).Rows.Add(ProcDataTableRow)

        If ProcDataSet.Tables(0).Rows.Count = 21 And ProcDatasetDelete = False Then
            ProcDataSet.Tables(0).Rows(0).Delete()
        End If

        'Chartコントロールにデータソースを設定
        ProcChart.DataSource = ProcDataSet
        ProcChart.DataBind()
    End Function
    Private Function showAcelChart(AcelX As String, AcelY As String, AcelZ As String)

        'データの追加
        AcelDataTableRow = AcelDataSet.Tables(0).NewRow
        AcelDataTableRow(0) = Date.Now.ToString("HH:mm:ss")
        AcelDataTableRow(1) = Single.Parse(AcelX)
        AcelDataTableRow(2) = Single.Parse(AcelY)
        AcelDataTableRow(3) = Single.Parse(AcelZ)

        AcelDataSet.Tables(0).Rows.Add(AcelDataTableRow)

        If AcelDataSet.Tables(0).Rows.Count = 21 And AcelDatasetDelete = False Then
            AcelDataSet.Tables(0).Rows(0).Delete()
        End If

        'Chartコントロールにデータソースを設定
        AcelChart.DataSource = AcelDataSet
        AcelChart.DataBind()
    End Function
    Private Function InitializeAcelChart()
        '初期化
        AcelChart.Series.Clear()
        ProcChart.Series.Clear()

        '列の作成
        AcelDataTable.Columns.Add("数値", Type.GetType("System.String"))
        AcelDataTable.Columns.Add("X軸", Type.GetType("System.Single"))
        AcelDataTable.Columns.Add("Y軸", Type.GetType("System.Single"))
        AcelDataTable.Columns.Add("Z軸", Type.GetType("System.Single"))
        AcelDataSet.Tables.Add(AcelDataTable)

        ProcDataTable.Columns.Add("数値", Type.GetType("System.String"))
        ProcDataTable.Columns.Add("CPU使用率", Type.GetType("System.Single"))
        ProcDataTable.Columns.Add("メモリ使用率", Type.GetType("System.Single"))
        ProcDataSet.Tables.Add(ProcDataTable)
        'Chartコントロールにタイトルを設定
        AcelChart.Titles.Add("機体姿勢").ForeColor = Color.Green
        ProcChart.Titles.Add("プロセス情報").ForeColor = Color.Green

        'グラフの種類,系列,軸の設定
        For I As Integer = 1 To AcelDataSet.Tables(0).Columns.Count - 1
            '列名の取得
            Dim columnName As String = AcelDataSet.Tables(0).Columns(I).ColumnName

            '系列の設定
            AcelChart.Series.Add(columnName)

            'グラフの種類を折れ線グラフにする
            AcelChart.Series(columnName).ChartType = SeriesChartType.Spline
            'X軸
            AcelChart.Series(columnName).XValueMember = AcelDataSet.Tables(0).Columns(0).ColumnName.ToString
            AcelChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
            AcelChart.ChartAreas(0).AxisX.MinorGrid.Enabled = False

            'Y軸
            AcelChart.Series(columnName).YValueMembers = columnName
        Next

        'グラフの種類,系列,軸の設定
        For I As Integer = 1 To ProcDataSet.Tables(0).Columns.Count - 1
            '列名の取得
            Dim columnName As String = ProcDataSet.Tables(0).Columns(I).ColumnName

            '系列の設定
            ProcChart.Series.Add(columnName)

            'グラフの種類を折れ線グラフにする
            ProcChart.Series(columnName).ChartType = SeriesChartType.Line
            'X軸
            ProcChart.Series(columnName).XValueMember = ProcDataSet.Tables(0).Columns(0).ColumnName.ToString
            ProcChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
            ProcChart.ChartAreas(0).AxisX.MinorGrid.Enabled = False

            'Y軸
            ProcChart.Series(columnName).YValueMembers = columnName
        Next

        'X軸タイトル
        AcelChart.ChartAreas(0).AxisX.Title = "時刻"

        'X軸タイトル
        ProcChart.ChartAreas(0).AxisX.Title = "時刻"
    End Function
    Private Function sendCommand(com As String) As Boolean
        If com = "" Then
            Return False
        End If
        Try
            BluetoothSpp.Write(com)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Media.SystemSounds.Exclamation.Play()
        If MessageBox.Show("終了しますか?", "確認ダイアログ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        Else
            Return
        End If
    End Sub

    Private Sub SendComBtn_Click(sender As Object, e As EventArgs) Handles SendComBtn.Click
        If sendCommand(SendComTBox.Text) = False Then
            MsgBox("送信に失敗しました。")
        Else
            SendComTBox.Text = ""
        End If
    End Sub

    Private Sub CancelComBtn_Click(sender As Object, e As EventArgs) Handles CancelComBtn.Click
        SendComTBox.Text = ""
    End Sub
End Class
