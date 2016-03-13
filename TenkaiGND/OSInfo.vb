Public Class OSInfo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Close()
    End Sub

    Private Sub OSInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OSの情報を取得する
        Dim os As System.OperatingSystem = System.Environment.OSVersion

        'OSの情報を表示する
        OsInfoTbox.Text += "OS情報:" & os.ToString() & vbCrLf
        'Windows 8.1では、「Microsoft Windows NT 6.2.9200.0」

        '次のようにしても同じ（.NET Framework 2.0以降）
        'TextBox1.Text += os.VersionString & vbCrLf

        'OSのバージョンを表示する
        OsInfoTbox.Text += "OSバージョン:" & os.Version.ToString() & vbCrLf
        'Windows 8では、「6.2.9200.0」

        'OSの各バージョン情報を表示する
        'OSのPlatformIDを表示する
        OsInfoTbox.Text += "OS PlatformID:" & os.Platform.ToString() & vbCrLf
        'Windows 8では、「Win32NT」

        'OSのメジャーバージョン番号を表示する
        OsInfoTbox.Text += "OSメジャーバージョン番号:" & os.Version.Major.ToString() & vbCrLf
        'Windows 8では、「6」

        'OSのマイナーバージョン番号を表示する
        OsInfoTbox.Text += "OSマイナーバージョン番号:" & os.Version.Minor.ToString() & vbCrLf
        'Windows 8では、「2」

        'OSのビルド番号を表示する
        OsInfoTbox.Text += "OSビルド番号:" & os.Version.Build.ToString() & vbCrLf
        'Windows 8では、「9200」

        'OSのリビジョン番号を表示する
        OsInfoTbox.Text += "OSリビジョン番号:" & os.Version.Revision.ToString() & vbCrLf
        'Windows 8では、「0」

        'OSのサービスパックのバージョンを表示する（.NET Framework 2.0以降）
        OsInfoTbox.Text += "OSサービスパックバージョン:" & os.ServicePack.ToString() & vbCrLf
        'Windows 8では、空の文字列

        'OSのメジャーリビジョン番号を表示する（.NET Framework 2.0以降）
        OsInfoTbox.Text += "OSメジャーリビジョン番号:" & os.Version.MajorRevision.ToString() & vbCrLf
        'Windows 8では、「0」

        'OSのマイナーリビジョン番号を表示する（.NET Framework 2.0以降）
        OsInfoTbox.Text += "OSマイナーリビジョン番号:" & os.Version.MinorRevision.ToString() & vbCrLf
    End Sub
End Class