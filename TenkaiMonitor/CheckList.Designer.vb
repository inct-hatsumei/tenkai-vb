<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckList
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
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
		Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label1.Location = New System.Drawing.Point(13, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(180, 24)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "機体・パラシュート"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label2.Location = New System.Drawing.Point(13, 201)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(68, 24)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "センサ"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label3.Location = New System.Drawing.Point(13, 345)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(61, 24)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "ソフト"
		'
		'CheckedListBox1
		'
		Me.CheckedListBox1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.CheckedListBox1.FormattingEnabled = True
		Me.CheckedListBox1.Items.AddRange(New Object() {"機体に歪み、亀裂等の異常はないか", "パラシュートとの接続は正常か", "パラシュートのひもに絡まりはないか", "パラシュートに亀裂等はないか", "パラシュートのたたみ方は規定通りか", "重心にずれはないか"})
		Me.CheckedListBox1.Location = New System.Drawing.Point(17, 40)
		Me.CheckedListBox1.Name = "CheckedListBox1"
		Me.CheckedListBox1.Size = New System.Drawing.Size(720, 158)
		Me.CheckedListBox1.TabIndex = 1
		'
		'CheckedListBox2
		'
		Me.CheckedListBox2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.CheckedListBox2.FormattingEnabled = True
		Me.CheckedListBox2.Items.AddRange(New Object() {"ArduinoのLEDは点灯しているか", "ジャイロセンサのLEDは点灯しているか", "リード線の接続は正常か", "microSDカードはリセットしたか"})
		Me.CheckedListBox2.Location = New System.Drawing.Point(17, 228)
		Me.CheckedListBox2.Name = "CheckedListBox2"
		Me.CheckedListBox2.Size = New System.Drawing.Size(720, 114)
		Me.CheckedListBox2.TabIndex = 2
		'
		'CheckedListBox3
		'
		Me.CheckedListBox3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.CheckedListBox3.FormattingEnabled = True
		Me.CheckedListBox3.Items.AddRange(New Object() {"モニタリングソフトの各設定項目は適切に設定されているか", "Androidアプリの各設定項目(Bluetooth,GPS)は適切に設定されているか", "送受信テストは正常に行えたか"})
		Me.CheckedListBox3.Location = New System.Drawing.Point(17, 372)
		Me.CheckedListBox3.Name = "CheckedListBox3"
		Me.CheckedListBox3.Size = New System.Drawing.Size(720, 114)
		Me.CheckedListBox3.TabIndex = 3
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(915, 40)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(227, 57)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "全項目チェック"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'CheckList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1154, 501)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.CheckedListBox3)
		Me.Controls.Add(Me.CheckedListBox2)
		Me.Controls.Add(Me.CheckedListBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.Name = "CheckList"
		Me.Text = "チェックリスト"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents CheckedListBox1 As CheckedListBox
	Friend WithEvents CheckedListBox2 As CheckedListBox
	Friend WithEvents CheckedListBox3 As CheckedListBox
	Friend WithEvents Button1 As Button
End Class
