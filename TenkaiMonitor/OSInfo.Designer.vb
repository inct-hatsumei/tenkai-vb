﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OSInfo
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
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.OsInfoTbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.Location = New System.Drawing.Point(223, 167)
        Me.OkBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(96, 25)
        Me.OkBtn.TabIndex = 3
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'OsInfoTbox
        '
        Me.OsInfoTbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OsInfoTbox.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OsInfoTbox.Location = New System.Drawing.Point(13, 8)
        Me.OsInfoTbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OsInfoTbox.Multiline = True
        Me.OsInfoTbox.Name = "OsInfoTbox"
        Me.OsInfoTbox.ReadOnly = True
        Me.OsInfoTbox.Size = New System.Drawing.Size(308, 156)
        Me.OsInfoTbox.TabIndex = 2
        '
        'OSInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 199)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.OsInfoTbox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "OSInfo"
        Me.Text = "OS情報"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OkBtn As Button
    Friend WithEvents OsInfoTbox As TextBox
End Class
