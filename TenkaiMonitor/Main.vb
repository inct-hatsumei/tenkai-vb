Imports System.Text
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Main
    Dim SjisEnc As Encoding = Encoding.GetEncoding("Shift_JIS")
    Dim PortNo As String
    Dim DataNo As Integer = 0
    Dim byteNum As Integer = 0
    'グラフ関連
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim dtRow As DataRow
    Dim DatasetDelete As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeColor(My.Settings.Color)
        InitializeChart()
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
        TrafStatBar.Visible = True
        byteNum += SjisEnc.GetByteCount(ReceivedData)
        DataNo += 1
        Dim A As Object
        A = Split(ReceivedData, ",")
        MissTimeTbox.Text = A(0)

        DataNoTbox.Text = DataNo
        CpuUseTbox.Text = A(1)
        MemUseTbox.Text = A(2)
        TempTbox.Text = A(3)
        BtryTbox.Text = A(4)
        LatTbox.Text = A(5)
        LonTbox.Text = A(6)
        AdvTbox.Text = A(7)
        AcelXTbox.Text = A(8)
        AcelYTbox.Text = A(9)
        AcelZTbox.Text = A(10)
        RcpDataTbox.Text =
            MissTimeTbox.Text & "," & CpuUseTbox.Text & "," &
            MemUseTbox.Text & "," & TempTbox.Text & "," &
            BtryTbox.Text & "," & LatTbox.Text & "," &
            LonTbox.Text & "," & AdvTbox.Text & "," &
            AcelXTbox.Text & "," & AcelYTbox.Text & "," &
            AcelZTbox.Text & "," & vbCrLf & RcpDataTbox.Text
        TrafTbox.Text = byteNum / 1024
        showGravChart(AcelXTbox.Text, AcelYTbox.Text, AcelZTbox.Text)
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
            DataNo = 0
            TrafStatBar.Visible = False
            '初期化
            Chart1.Series.Clear()
        End If
    End Sub
    Private Sub ExitBtn_Click_1(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Media.SystemSounds.Exclamation.Play()
        If MessageBox.Show("終了しますか?", "確認ダイアログ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If
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
        GroupBox1.BackColor = bgcolor
        GroupBox2.BackColor = bgcolor
        GroupBox3.BackColor = bgcolor
        GroupBox5.BackColor = bgcolor
        GroupBox6.BackColor = bgcolor
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
                TrafStatBar.Visible = False
                TrafStatLbl.Text = "OFFLINE"
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
    Private Function showGravChart(gravX As String, gravY As String, gravZ As String)

        'データの追加
        dtRow = ds.Tables(0).NewRow
        dtRow(0) = Date.Now.ToString("HH:mm:ss")
        dtRow(1) = Single.Parse(gravX)
        dtRow(2) = Single.Parse(gravY)
        dtRow(3) = Single.Parse(gravZ)

        ds.Tables(0).Rows.Add(dtRow)

        If ds.Tables(0).Rows.Count = 21 And DatasetDelete = False Then
            ds.Tables(0).Rows(0).Delete()
        End If

        'Chartコントロールにデータソースを設定
        Chart1.DataSource = ds
        Chart1.DataBind()
    End Function
    Private Function InitializeChart()
        '初期化
        Chart1.Series.Clear()

        '列の作成
        dt.Columns.Add("数値", Type.GetType("System.String"))
        dt.Columns.Add("X軸", Type.GetType("System.Single"))
        dt.Columns.Add("Y軸", Type.GetType("System.Single"))
        dt.Columns.Add("Z軸", Type.GetType("System.Single"))
        ds.Tables.Add(dt)
        'Chartコントロールにタイトルを設定
        Chart1.Titles.Add("機体姿勢")

        'グラフの種類,系列,軸の設定
        For I As Integer = 1 To ds.Tables(0).Columns.Count - 1
            '列名の取得
            Dim columnName As String = ds.Tables(0).Columns(I).ColumnName

            '系列の設定
            Chart1.Series.Add(columnName)

            'グラフの種類を折れ線グラフにする
            Chart1.Series(columnName).ChartType = SeriesChartType.Spline
            'X軸
            Chart1.Series(columnName).XValueMember = ds.Tables(0).Columns(0).ColumnName.ToString
            Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
            Chart1.ChartAreas(0).AxisX.MinorGrid.Enabled = False

            'Y軸
            Chart1.Series(columnName).YValueMembers = columnName
        Next

        'X軸タイトル
        Chart1.ChartAreas(0).AxisX.Title = "時刻"
    End Function
End Class
