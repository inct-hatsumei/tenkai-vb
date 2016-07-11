<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TenkaiMonitorSplash
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
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TenkaiMonitorSplash))
		Me.Version = New System.Windows.Forms.Label()
		Me.Copyright = New System.Windows.Forms.Label()
		Me.ApplicationTitle = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Version
		'
		Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Version.BackColor = System.Drawing.Color.Transparent
		Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Version.Location = New System.Drawing.Point(229, 162)
		Me.Version.Name = "Version"
		Me.Version.Size = New System.Drawing.Size(407, 27)
		Me.Version.TabIndex = 4
		Me.Version.Text = "バージョン1.0"
		Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Copyright
		'
		Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Copyright.BackColor = System.Drawing.Color.Transparent
		Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Copyright.Location = New System.Drawing.Point(12, 283)
		Me.Copyright.Name = "Copyright"
		Me.Copyright.Size = New System.Drawing.Size(624, 45)
		Me.Copyright.TabIndex = 5
		Me.Copyright.Text = "一関高専発明同好会"
		Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ApplicationTitle
		'
		Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
		Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ApplicationTitle.Location = New System.Drawing.Point(222, 26)
		Me.ApplicationTitle.Name = "ApplicationTitle"
		Me.ApplicationTitle.Size = New System.Drawing.Size(414, 136)
		Me.ApplicationTitle.TabIndex = 3
		Me.ApplicationTitle.Text = "てんかいモニタリングソフト"
		Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox1.Location = New System.Drawing.Point(16, 13)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
		Me.PictureBox1.TabIndex = 6
		Me.PictureBox1.TabStop = False
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(595, 13)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(40, 40)
		Me.Button1.TabIndex = 7
		Me.Button1.Text = "×"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TenkaiMonitorSplash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(648, 337)
		Me.ControlBox = False
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Version)
		Me.Controls.Add(Me.Copyright)
		Me.Controls.Add(Me.ApplicationTitle)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "TenkaiMonitorSplash"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Version As Label
	Friend WithEvents Copyright As Label
	Friend WithEvents ApplicationTitle As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button1 As Button
End Class
