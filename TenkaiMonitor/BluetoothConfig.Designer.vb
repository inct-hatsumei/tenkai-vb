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
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMポート"
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.Location = New System.Drawing.Point(102, 73)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(100, 37)
        Me.OkBtn.TabIndex = 3
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(208, 73)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(100, 37)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'BluetoothSppPorts
        '
        Me.BluetoothSppPorts.FormattingEnabled = True
        Me.BluetoothSppPorts.Location = New System.Drawing.Point(107, 6)
        Me.BluetoothSppPorts.Name = "BluetoothSppPorts"
        Me.BluetoothSppPorts.Size = New System.Drawing.Size(201, 26)
        Me.BluetoothSppPorts.TabIndex = 4
        '
        'BluetoothConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 122)
        Me.Controls.Add(Me.BluetoothSppPorts)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BluetoothConfig"
        Me.Text = "BluetoothConfig"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents OkBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents BluetoothSppPorts As ComboBox
    Friend WithEvents BluetoothSppConfig As IO.Ports.SerialPort
End Class
