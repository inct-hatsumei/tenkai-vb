﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TroubleShooting
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
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.SuspendLayout()
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.Size = New System.Drawing.Size(1307, 842)
		Me.WebBrowser1.TabIndex = 0
		Me.WebBrowser1.Url = New System.Uri("file:///D:\workspace\CANSAT2016\tenkai-vb\TenkaiMonitor\TroubleShooting.html", System.UriKind.Absolute)
		'
		'TroubleShooting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1307, 842)
		Me.Controls.Add(Me.WebBrowser1)
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.Name = "TroubleShooting"
		Me.Text = "トラブルシューティング"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents WebBrowser1 As WebBrowser
End Class
