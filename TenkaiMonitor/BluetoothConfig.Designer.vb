<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BluetoothConfig
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.BluetoothSppPorts = New System.Windows.Forms.ComboBox()
        Me.BluetoothSppConfig = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMポート"
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.Location = New System.Drawing.Point(61, 49)
        Me.OkBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(60, 25)
        Me.OkBtn.TabIndex = 3
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(125, 49)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(60, 25)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'BluetoothSppPorts
        '
        Me.BluetoothSppPorts.FormattingEnabled = True
        Me.BluetoothSppPorts.Location = New System.Drawing.Point(64, 4)
        Me.BluetoothSppPorts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BluetoothSppPorts.Name = "BluetoothSppPorts"
        Me.BluetoothSppPorts.Size = New System.Drawing.Size(122, 20)
        Me.BluetoothSppPorts.TabIndex = 4
        '
        'BluetoothConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 81)
        Me.Controls.Add(Me.BluetoothSppPorts)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BluetoothConfig"
        Me.Text = "Bluetooth通信設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents OkBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents BluetoothSppPorts As ComboBox
    Friend WithEvents BluetoothSppConfig As IO.Ports.SerialPort
End Class
