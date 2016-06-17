<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatteryStat
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
        Me.BtryStatTbox = New System.Windows.Forms.TextBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtryStatTbox
        '
        Me.BtryStatTbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtryStatTbox.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtryStatTbox.Location = New System.Drawing.Point(8, 9)
        Me.BtryStatTbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtryStatTbox.Multiline = True
        Me.BtryStatTbox.Name = "BtryStatTbox"
        Me.BtryStatTbox.ReadOnly = True
        Me.BtryStatTbox.Size = New System.Drawing.Size(308, 156)
        Me.BtryStatTbox.TabIndex = 0
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.Location = New System.Drawing.Point(218, 167)
        Me.OkBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(96, 25)
        Me.OkBtn.TabIndex = 1
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'BatteryStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 201)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.BtryStatTbox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BatteryStat"
        Me.Text = "バッテリー情報"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtryStatTbox As TextBox
    Friend WithEvents OkBtn As Button
End Class
