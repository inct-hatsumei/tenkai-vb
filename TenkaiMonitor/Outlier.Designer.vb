<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Outlier
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CpuUseOutTbox = New System.Windows.Forms.TextBox()
        Me.MemUseOutTbox = New System.Windows.Forms.TextBox()
        Me.AcelOutTbox = New System.Windows.Forms.TextBox()
        Me.TempOutTbox = New System.Windows.Forms.TextBox()
        Me.BtryOutTbox = New System.Windows.Forms.TextBox()
        Me.OprTimeOutTbox = New System.Windows.Forms.TextBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU使用率異常値"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "メモリ使用率異常値"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "加速度異常値"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "機体温度異常値"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "バッテリー残量異常値"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "動作可能時間異常値"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(454, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "%以上"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(454, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "%以上"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(463, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "以上"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(445, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "℃以上"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(454, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "%未満"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(445, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 18)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "分未満"
        '
        'CpuUseOutTbox
        '
        Me.CpuUseOutTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CpuUseOutTbox.Location = New System.Drawing.Point(207, 5)
        Me.CpuUseOutTbox.Name = "CpuUseOutTbox"
        Me.CpuUseOutTbox.Size = New System.Drawing.Size(232, 25)
        Me.CpuUseOutTbox.TabIndex = 7
        Me.CpuUseOutTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MemUseOutTbox
        '
        Me.MemUseOutTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemUseOutTbox.Location = New System.Drawing.Point(207, 36)
        Me.MemUseOutTbox.Name = "MemUseOutTbox"
        Me.MemUseOutTbox.Size = New System.Drawing.Size(232, 25)
        Me.MemUseOutTbox.TabIndex = 7
        Me.MemUseOutTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AcelOutTbox
        '
        Me.AcelOutTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcelOutTbox.Location = New System.Drawing.Point(207, 67)
        Me.AcelOutTbox.Name = "AcelOutTbox"
        Me.AcelOutTbox.Size = New System.Drawing.Size(232, 25)
        Me.AcelOutTbox.TabIndex = 7
        Me.AcelOutTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TempOutTbox
        '
        Me.TempOutTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TempOutTbox.Location = New System.Drawing.Point(207, 97)
        Me.TempOutTbox.Name = "TempOutTbox"
        Me.TempOutTbox.Size = New System.Drawing.Size(232, 25)
        Me.TempOutTbox.TabIndex = 7
        Me.TempOutTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtryOutTbox
        '
        Me.BtryOutTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtryOutTbox.Location = New System.Drawing.Point(207, 128)
        Me.BtryOutTbox.Name = "BtryOutTbox"
        Me.BtryOutTbox.Size = New System.Drawing.Size(232, 25)
        Me.BtryOutTbox.TabIndex = 7
        Me.BtryOutTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OprTimeOutTbox
        '
        Me.OprTimeOutTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OprTimeOutTbox.Location = New System.Drawing.Point(207, 159)
        Me.OprTimeOutTbox.Name = "OprTimeOutTbox"
        Me.OprTimeOutTbox.Size = New System.Drawing.Size(232, 25)
        Me.OprTimeOutTbox.TabIndex = 7
        Me.OprTimeOutTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.Location = New System.Drawing.Point(167, 190)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(167, 42)
        Me.OkBtn.TabIndex = 8
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(340, 190)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(167, 42)
        Me.CancelBtn.TabIndex = 8
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Outlier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 244)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.OprTimeOutTbox)
        Me.Controls.Add(Me.BtryOutTbox)
        Me.Controls.Add(Me.TempOutTbox)
        Me.Controls.Add(Me.AcelOutTbox)
        Me.Controls.Add(Me.MemUseOutTbox)
        Me.Controls.Add(Me.CpuUseOutTbox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Outlier"
        Me.Text = "異常値設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CpuUseOutTbox As TextBox
    Friend WithEvents MemUseOutTbox As TextBox
    Friend WithEvents AcelOutTbox As TextBox
    Friend WithEvents TempOutTbox As TextBox
    Friend WithEvents BtryOutTbox As TextBox
    Friend WithEvents OprTimeOutTbox As TextBox
    Friend WithEvents OkBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
