Public Class CheckList
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If CheckedListBox1.CheckedItems.Count = 5 And
			CheckedListBox2.CheckedItems.Count = 3 And
			CheckedListBox3.CheckedItems.Count = 3 Then
			MsgBox("全項目が満たされています")
			Close()
		Else
			For i = 0 To CheckedListBox1.Items.Count - 1
				If (CheckedListBox1.GetItemChecked(i) = False) Then
					MsgBox(Label1.Text & "の「" & CheckedListBox1.Items(i).ToString & "」が満たされていません" &
						   vbCrLf & "すぐに確認してください")
				End If
			Next
			For i = 0 To CheckedListBox2.Items.Count - 1
				If (CheckedListBox2.GetItemChecked(i) = False) Then
					MsgBox(Label2.Text & "の「" & CheckedListBox2.Items(i).ToString & "」が満たされていません" &
						   vbCrLf & "すぐに確認してください")
				End If
			Next
			For i = 0 To CheckedListBox3.Items.Count - 1
				If (CheckedListBox3.GetItemChecked(i) = False) Then
					MsgBox(Label3.Text & "の「" & CheckedListBox3.Items(i).ToString & "」が満たされていません" &
						   vbCrLf & "すぐに確認してください")
				End If
			Next
		End If
	End Sub
End Class