Imports System.IO
Imports System.Text

Public Class LogSaveConfig
    Dim path As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SettingBtn.Click
        FolderBrowserDialog1.Description = "ログファイルを保存するディレクトリを選択してください。"
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.SelectedPath = "C: "
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            path = FolderBrowserDialog1.SelectedPath
            NewLogFolderTbox.Text = path
        End If
        FolderBrowserDialog1.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub LogSaveConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogFolderTbox.Text = My.Settings.LogSaveFolder
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        MsgBox(path)
        My.Settings.LogSaveFolder = path
        MsgBox(My.Settings.LogSaveFolder)
        Close()
    End Sub
End Class