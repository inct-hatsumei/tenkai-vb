<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BluetoothSpp = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.LogSaveBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.RcpDataTbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OprTimeTbox = New System.Windows.Forms.TextBox()
        Me.AcelZTbox = New System.Windows.Forms.TextBox()
        Me.AcelYTbox = New System.Windows.Forms.TextBox()
        Me.AcelXTbox = New System.Windows.Forms.TextBox()
        Me.AdvTbox = New System.Windows.Forms.TextBox()
        Me.LonTbox = New System.Windows.Forms.TextBox()
        Me.TrafTbox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LatTbox = New System.Windows.Forms.TextBox()
        Me.BtryTbox = New System.Windows.Forms.TextBox()
        Me.TempTbox = New System.Windows.Forms.TextBox()
        Me.MemUseTbox = New System.Windows.Forms.TextBox()
        Me.CpuUseTbox = New System.Windows.Forms.TextBox()
        Me.DataNoTbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MissTimeTbox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TrafStatBar = New System.Windows.Forms.ProgressBar()
        Me.TrafStatLbl = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.Mission = New System.Windows.Forms.ToolStripMenuItem()
        Me.MissionStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.MissionFinish = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareLock = New System.Windows.Forms.ToolStripMenuItem()
        Me.Config = New System.Windows.Forms.ToolStripMenuItem()
        Me.BluetoothConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogSaveConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.UIConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutlierConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemStat = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatteryStat = New System.Windows.Forms.ToolStripMenuItem()
        Me.OSInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.AndroidAppHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroundSoftHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MissionMan = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckList = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroubleShooting = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.JstTbox = New System.Windows.Forms.TextBox()
        Me.JstClock = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BluetoothSpp
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.ExitBtn)
        Me.GroupBox3.Controls.Add(Me.LogSaveBtn)
        Me.GroupBox3.Controls.Add(Me.ClearBtn)
        Me.GroupBox3.Controls.Add(Me.RcpDataTbox)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Green
        Me.GroupBox3.Location = New System.Drawing.Point(12, 823)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1874, 186)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "受信データ"
        '
        'ExitBtn
        '
        Me.ExitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitBtn.BackColor = System.Drawing.Color.Black
        Me.ExitBtn.Location = New System.Drawing.Point(1725, 145)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(143, 34)
        Me.ExitBtn.TabIndex = 2
        Me.ExitBtn.Text = "終了"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'LogSaveBtn
        '
        Me.LogSaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogSaveBtn.BackColor = System.Drawing.Color.Black
        Me.LogSaveBtn.Location = New System.Drawing.Point(1725, 105)
        Me.LogSaveBtn.Name = "LogSaveBtn"
        Me.LogSaveBtn.Size = New System.Drawing.Size(143, 34)
        Me.LogSaveBtn.TabIndex = 3
        Me.LogSaveBtn.Text = "ログ保存"
        Me.LogSaveBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearBtn.BackColor = System.Drawing.Color.Black
        Me.ClearBtn.Location = New System.Drawing.Point(1725, 65)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(143, 34)
        Me.ClearBtn.TabIndex = 4
        Me.ClearBtn.Text = "クリア"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'RcpDataTbox
        '
        Me.RcpDataTbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RcpDataTbox.BackColor = System.Drawing.Color.Black
        Me.RcpDataTbox.Location = New System.Drawing.Point(7, 25)
        Me.RcpDataTbox.Multiline = True
        Me.RcpDataTbox.Name = "RcpDataTbox"
        Me.RcpDataTbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RcpDataTbox.Size = New System.Drawing.Size(1712, 154)
        Me.RcpDataTbox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.OprTimeTbox)
        Me.GroupBox1.Controls.Add(Me.AcelZTbox)
        Me.GroupBox1.Controls.Add(Me.AcelYTbox)
        Me.GroupBox1.Controls.Add(Me.AcelXTbox)
        Me.GroupBox1.Controls.Add(Me.AdvTbox)
        Me.GroupBox1.Controls.Add(Me.LonTbox)
        Me.GroupBox1.Controls.Add(Me.TrafTbox)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LatTbox)
        Me.GroupBox1.Controls.Add(Me.BtryTbox)
        Me.GroupBox1.Controls.Add(Me.TempTbox)
        Me.GroupBox1.Controls.Add(Me.MemUseTbox)
        Me.GroupBox1.Controls.Add(Me.CpuUseTbox)
        Me.GroupBox1.Controls.Add(Me.DataNoTbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 446)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "機体状況"
        '
        'OprTimeTbox
        '
        Me.OprTimeTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OprTimeTbox.BackColor = System.Drawing.Color.Black
        Me.OprTimeTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OprTimeTbox.Location = New System.Drawing.Point(138, 366)
        Me.OprTimeTbox.Name = "OprTimeTbox"
        Me.OprTimeTbox.ReadOnly = True
        Me.OprTimeTbox.Size = New System.Drawing.Size(174, 25)
        Me.OprTimeTbox.TabIndex = 19
        Me.OprTimeTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AcelZTbox
        '
        Me.AcelZTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcelZTbox.BackColor = System.Drawing.Color.Black
        Me.AcelZTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AcelZTbox.Location = New System.Drawing.Point(138, 335)
        Me.AcelZTbox.Name = "AcelZTbox"
        Me.AcelZTbox.ReadOnly = True
        Me.AcelZTbox.Size = New System.Drawing.Size(174, 25)
        Me.AcelZTbox.TabIndex = 18
        Me.AcelZTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AcelYTbox
        '
        Me.AcelYTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcelYTbox.BackColor = System.Drawing.Color.Black
        Me.AcelYTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AcelYTbox.Location = New System.Drawing.Point(138, 304)
        Me.AcelYTbox.Name = "AcelYTbox"
        Me.AcelYTbox.ReadOnly = True
        Me.AcelYTbox.Size = New System.Drawing.Size(174, 25)
        Me.AcelYTbox.TabIndex = 17
        Me.AcelYTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AcelXTbox
        '
        Me.AcelXTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcelXTbox.BackColor = System.Drawing.Color.Black
        Me.AcelXTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AcelXTbox.Location = New System.Drawing.Point(138, 273)
        Me.AcelXTbox.Name = "AcelXTbox"
        Me.AcelXTbox.ReadOnly = True
        Me.AcelXTbox.Size = New System.Drawing.Size(174, 25)
        Me.AcelXTbox.TabIndex = 16
        Me.AcelXTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AdvTbox
        '
        Me.AdvTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvTbox.BackColor = System.Drawing.Color.Black
        Me.AdvTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AdvTbox.Location = New System.Drawing.Point(138, 242)
        Me.AdvTbox.Name = "AdvTbox"
        Me.AdvTbox.ReadOnly = True
        Me.AdvTbox.Size = New System.Drawing.Size(174, 25)
        Me.AdvTbox.TabIndex = 15
        Me.AdvTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LonTbox
        '
        Me.LonTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LonTbox.BackColor = System.Drawing.Color.Black
        Me.LonTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LonTbox.Location = New System.Drawing.Point(138, 211)
        Me.LonTbox.Name = "LonTbox"
        Me.LonTbox.ReadOnly = True
        Me.LonTbox.Size = New System.Drawing.Size(174, 25)
        Me.LonTbox.TabIndex = 14
        Me.LonTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TrafTbox
        '
        Me.TrafTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrafTbox.BackColor = System.Drawing.Color.Black
        Me.TrafTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TrafTbox.Location = New System.Drawing.Point(138, 397)
        Me.TrafTbox.Name = "TrafTbox"
        Me.TrafTbox.ReadOnly = True
        Me.TrafTbox.Size = New System.Drawing.Size(174, 25)
        Me.TrafTbox.TabIndex = 1
        Me.TrafTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 400)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "総通信量(KB)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "メモリー使用率"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "CPU使用率"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "動作可能時間"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "バッテリー温度"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "バッテリー残量"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "加速度Z"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "加速度Y"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "加速度X"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "高度"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "東経"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "北緯"
        '
        'LatTbox
        '
        Me.LatTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LatTbox.BackColor = System.Drawing.Color.Black
        Me.LatTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LatTbox.Location = New System.Drawing.Point(138, 180)
        Me.LatTbox.Name = "LatTbox"
        Me.LatTbox.ReadOnly = True
        Me.LatTbox.Size = New System.Drawing.Size(174, 25)
        Me.LatTbox.TabIndex = 1
        Me.LatTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtryTbox
        '
        Me.BtryTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtryTbox.BackColor = System.Drawing.Color.Black
        Me.BtryTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BtryTbox.Location = New System.Drawing.Point(138, 149)
        Me.BtryTbox.Name = "BtryTbox"
        Me.BtryTbox.ReadOnly = True
        Me.BtryTbox.Size = New System.Drawing.Size(174, 25)
        Me.BtryTbox.TabIndex = 1
        Me.BtryTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TempTbox
        '
        Me.TempTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TempTbox.BackColor = System.Drawing.Color.Black
        Me.TempTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TempTbox.Location = New System.Drawing.Point(138, 118)
        Me.TempTbox.Name = "TempTbox"
        Me.TempTbox.ReadOnly = True
        Me.TempTbox.Size = New System.Drawing.Size(174, 25)
        Me.TempTbox.TabIndex = 1
        Me.TempTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MemUseTbox
        '
        Me.MemUseTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemUseTbox.BackColor = System.Drawing.Color.Black
        Me.MemUseTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MemUseTbox.Location = New System.Drawing.Point(138, 87)
        Me.MemUseTbox.Name = "MemUseTbox"
        Me.MemUseTbox.ReadOnly = True
        Me.MemUseTbox.Size = New System.Drawing.Size(174, 25)
        Me.MemUseTbox.TabIndex = 1
        Me.MemUseTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CpuUseTbox
        '
        Me.CpuUseTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CpuUseTbox.BackColor = System.Drawing.Color.Black
        Me.CpuUseTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CpuUseTbox.Location = New System.Drawing.Point(138, 56)
        Me.CpuUseTbox.Name = "CpuUseTbox"
        Me.CpuUseTbox.ReadOnly = True
        Me.CpuUseTbox.Size = New System.Drawing.Size(174, 25)
        Me.CpuUseTbox.TabIndex = 1
        Me.CpuUseTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataNoTbox
        '
        Me.DataNoTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataNoTbox.BackColor = System.Drawing.Color.Black
        Me.DataNoTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DataNoTbox.Location = New System.Drawing.Point(138, 25)
        Me.DataNoTbox.Name = "DataNoTbox"
        Me.DataNoTbox.ReadOnly = True
        Me.DataNoTbox.Size = New System.Drawing.Size(174, 25)
        Me.DataNoTbox.TabIndex = 1
        Me.DataNoTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "データナンバー"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MissTimeTbox)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Green
        Me.GroupBox5.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(319, 65)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ミッション基準時間"
        '
        'MissTimeTbox
        '
        Me.MissTimeTbox.BackColor = System.Drawing.Color.Black
        Me.MissTimeTbox.ForeColor = System.Drawing.Color.Green
        Me.MissTimeTbox.Location = New System.Drawing.Point(6, 24)
        Me.MissTimeTbox.Name = "MissTimeTbox"
        Me.MissTimeTbox.ReadOnly = True
        Me.MissTimeTbox.Size = New System.Drawing.Size(306, 25)
        Me.MissTimeTbox.TabIndex = 0
        Me.MissTimeTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(337, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1549, 783)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "機体姿勢"
        '
        'TrafStatBar
        '
        Me.TrafStatBar.Location = New System.Drawing.Point(11, 42)
        Me.TrafStatBar.Name = "TrafStatBar"
        Me.TrafStatBar.Size = New System.Drawing.Size(301, 20)
        Me.TrafStatBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.TrafStatBar.TabIndex = 20
        Me.TrafStatBar.Visible = False
        '
        'TrafStatLbl
        '
        Me.TrafStatLbl.AutoSize = True
        Me.TrafStatLbl.BackColor = System.Drawing.Color.Transparent
        Me.TrafStatLbl.Location = New System.Drawing.Point(47, 21)
        Me.TrafStatLbl.Name = "TrafStatLbl"
        Me.TrafStatLbl.Size = New System.Drawing.Size(77, 18)
        Me.TrafStatLbl.TabIndex = 22
        Me.TrafStatLbl.Text = "OFFLINE"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.TrafStatLbl)
        Me.GroupBox6.Controls.Add(Me.TrafStatBar)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Green
        Me.GroupBox6.Location = New System.Drawing.Point(12, 631)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(319, 186)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "通信状況"
        '
        'MenuBar
        '
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mission, Me.Config, Me.SystemStat, Me.Help})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1898, 32)
        Me.MenuBar.TabIndex = 4
        Me.MenuBar.Text = "MenuStrip1"
        '
        'Mission
        '
        Me.Mission.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MissionStart, Me.MissionFinish, Me.SoftwareLock})
        Me.Mission.Name = "Mission"
        Me.Mission.Size = New System.Drawing.Size(80, 28)
        Me.Mission.Text = "ミッション"
        '
        'MissionStart
        '
        Me.MissionStart.Name = "MissionStart"
        Me.MissionStart.Size = New System.Drawing.Size(211, 30)
        Me.MissionStart.Text = "ミッション開始"
        '
        'MissionFinish
        '
        Me.MissionFinish.Name = "MissionFinish"
        Me.MissionFinish.Size = New System.Drawing.Size(211, 30)
        Me.MissionFinish.Text = "ミッション終了"
        '
        'SoftwareLock
        '
        Me.SoftwareLock.Name = "SoftwareLock"
        Me.SoftwareLock.Size = New System.Drawing.Size(211, 30)
        Me.SoftwareLock.Text = "ソフトウエアロック"
        '
        'Config
        '
        Me.Config.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BluetoothConfig, Me.LogSaveConfig, Me.UIConfig, Me.OutlierConfig})
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(58, 28)
        Me.Config.Text = "設定"
        '
        'BluetoothConfig
        '
        Me.BluetoothConfig.Name = "BluetoothConfig"
        Me.BluetoothConfig.Size = New System.Drawing.Size(250, 30)
        Me.BluetoothConfig.Text = "Bluetooth通信設定"
        '
        'LogSaveConfig
        '
        Me.LogSaveConfig.Name = "LogSaveConfig"
        Me.LogSaveConfig.Size = New System.Drawing.Size(250, 30)
        Me.LogSaveConfig.Text = "ログ保存先設定"
        '
        'UIConfig
        '
        Me.UIConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackToolStripMenuItem, Me.WhiteToolStripMenuItem})
        Me.UIConfig.Name = "UIConfig"
        Me.UIConfig.Size = New System.Drawing.Size(250, 30)
        Me.UIConfig.Text = "UI設定"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(144, 30)
        Me.BlackToolStripMenuItem.Text = "Black"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(144, 30)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'OutlierConfig
        '
        Me.OutlierConfig.Name = "OutlierConfig"
        Me.OutlierConfig.Size = New System.Drawing.Size(250, 30)
        Me.OutlierConfig.Text = "異常値設定"
        '
        'SystemStat
        '
        Me.SystemStat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BatteryStat, Me.OSInfo})
        Me.SystemStat.Name = "SystemStat"
        Me.SystemStat.Size = New System.Drawing.Size(149, 28)
        Me.SystemStat.Text = "システムステータス"
        '
        'BatteryStat
        '
        Me.BatteryStat.Name = "BatteryStat"
        Me.BatteryStat.Size = New System.Drawing.Size(227, 30)
        Me.BatteryStat.Text = "バッテリーステータス"
        '
        'OSInfo
        '
        Me.OSInfo.Name = "OSInfo"
        Me.OSInfo.Size = New System.Drawing.Size(227, 30)
        Me.OSInfo.Text = "OS情報"
        '
        'Help
        '
        Me.Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AndroidAppHelp, Me.GroundSoftHelp, Me.MissionMan, Me.CheckList, Me.TroubleShooting, Me.About})
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(66, 28)
        Me.Help.Text = "ヘルプ"
        '
        'AndroidAppHelp
        '
        Me.AndroidAppHelp.Name = "AndroidAppHelp"
        Me.AndroidAppHelp.Size = New System.Drawing.Size(244, 30)
        Me.AndroidAppHelp.Text = "Androidアプリヘルプ"
        '
        'GroundSoftHelp
        '
        Me.GroundSoftHelp.Name = "GroundSoftHelp"
        Me.GroundSoftHelp.Size = New System.Drawing.Size(244, 30)
        Me.GroundSoftHelp.Text = "地上局ソフトヘルプ"
        '
        'MissionMan
        '
        Me.MissionMan.Name = "MissionMan"
        Me.MissionMan.Size = New System.Drawing.Size(244, 30)
        Me.MissionMan.Text = "ミッション手順書"
        '
        'CheckList
        '
        Me.CheckList.Name = "CheckList"
        Me.CheckList.Size = New System.Drawing.Size(244, 30)
        Me.CheckList.Text = "チェックリスト"
        '
        'TroubleShooting
        '
        Me.TroubleShooting.Name = "TroubleShooting"
        Me.TroubleShooting.Size = New System.Drawing.Size(244, 30)
        Me.TroubleShooting.Text = "トラブルシューティング"
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(244, 30)
        Me.About.Text = "About"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.JstTbox)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Green
        Me.GroupBox4.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(319, 63)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "日本標準時"
        '
        'JstTbox
        '
        Me.JstTbox.BackColor = System.Drawing.Color.Black
        Me.JstTbox.ForeColor = System.Drawing.Color.Green
        Me.JstTbox.Location = New System.Drawing.Point(6, 24)
        Me.JstTbox.Name = "JstTbox"
        Me.JstTbox.Size = New System.Drawing.Size(306, 25)
        Me.JstTbox.TabIndex = 0
        Me.JstTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'JstClock
        '
        Me.JstClock.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "Main"
        Me.Text = "てんかい地上局ソフト"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BluetoothSpp As IO.Ports.SerialPort
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ExitBtn As Button
    Friend WithEvents LogSaveBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents RcpDataTbox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LatTbox As TextBox
    Friend WithEvents BtryTbox As TextBox
    Friend WithEvents TempTbox As TextBox
    Friend WithEvents MemUseTbox As TextBox
    Friend WithEvents CpuUseTbox As TextBox
    Friend WithEvents DataNoTbox As TextBox
    Friend WithEvents TrafTbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents MissTimeTbox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OprTimeTbox As TextBox
    Friend WithEvents AcelZTbox As TextBox
    Friend WithEvents AcelYTbox As TextBox
    Friend WithEvents AcelXTbox As TextBox
    Friend WithEvents AdvTbox As TextBox
    Friend WithEvents LonTbox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TrafStatBar As ProgressBar
    Friend WithEvents TrafStatLbl As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents Mission As ToolStripMenuItem
    Friend WithEvents Config As ToolStripMenuItem
    Friend WithEvents BluetoothConfig As ToolStripMenuItem
    Friend WithEvents LogSaveConfig As ToolStripMenuItem
    Friend WithEvents UIConfig As ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemStat As ToolStripMenuItem
    Friend WithEvents BatteryStat As ToolStripMenuItem
    Friend WithEvents Help As ToolStripMenuItem
    Friend WithEvents AndroidAppHelp As ToolStripMenuItem
    Friend WithEvents GroundSoftHelp As ToolStripMenuItem
    Friend WithEvents MissionMan As ToolStripMenuItem
    Friend WithEvents CheckList As ToolStripMenuItem
    Friend WithEvents TroubleShooting As ToolStripMenuItem
    Friend WithEvents About As ToolStripMenuItem
    Friend WithEvents MissionStart As ToolStripMenuItem
    Friend WithEvents MissionFinish As ToolStripMenuItem
    Friend WithEvents SoftwareLock As ToolStripMenuItem
    Friend WithEvents OSInfo As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents JstTbox As TextBox
    Friend WithEvents JstClock As Timer
    Friend WithEvents OutlierConfig As ToolStripMenuItem
End Class
