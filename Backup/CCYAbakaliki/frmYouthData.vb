Public Class frmYouthData

    Private Sub CheckedListBox1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To Me.CheckedListBox1.Items.Count - 1 Step 1
                If i <> e.Index Then
                    Me.CheckedListBox1.SetItemChecked(i, False)
                End If
            Next i
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim clb As CheckedListBox = CheckedListBox1
        If clb.GetItemCheckState(3) = CheckState.Checked And clb.SelectedItem.ToString = "Others" Then
            txtOther.Enabled = True
        Else : txtOther.Enabled = False
        End If
        ' ''get the selected item index
        ''Dim si As Integer = CheckedListBox1.SelectedIndex
        ''If (si <> -1) Then
        ''    For i As Integer = 0 To CheckedListBox1.Items.Count - 1
        ''        'get the selected item checked state
        ''        If CheckedListBox1.GetItemCheckState(3) = CheckState.Checked Then
        ''            txtOther.Enabled = True
        ''        Else
        ''            txtOther.Enabled = False
        ''        End If
        ''    Next
        ''End If
        'If CheckedListBox1.GetItemCheckState(3) = CheckState.Checked Then
        '    txtOther.Enabled = True
        'Else
        '    txtOther.Enabled = False
        'End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmDashBoard.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim con, dt As New dbCodes
        con.dbconnect()
        dt.dbtime()
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.Connection = con.cn
        cmd.CommandText = "insert into tblYouthDetails (Name, Address, PhoneNumber, DoB, Email, Facebook," _
& " Whatsapp, YouthUnit, DatePost) values (@N,@A,@P,@D,@E,@F,@W,@Y,@DT)"
        cmd.Parameters.AddWithValue("@N", txtNames.Text)
        cmd.Parameters.AddWithValue("@A", txtAddress.Text)
        cmd.Parameters.AddWithValue("@P", txtPN.Text)
        cmd.Parameters.AddWithValue("@D", DateTimePicker1.Text)
        cmd.Parameters.AddWithValue("@E", txtEmail.Text)
        cmd.Parameters.AddWithValue("@F", txtFacebook.Text)
        cmd.Parameters.AddWithValue("@W", txtWhatsapp.Text)
        If txtOther.Enabled = True Then
            cmd.Parameters.AddWithValue("@Y", txtOther.Text)
        Else
            cmd.Parameters.AddWithValue("@Y", CheckedListBox1.SelectedItem)
        End If
        cmd.Parameters.AddWithValue("@DT", dt.SysDate)
        cmd.ExecuteScalar()
        MsgBox("Youth Registered", MsgBoxStyle.OkOnly, Title:="Youth Registration")
        btnCA_Click(sender, EventArgs.Empty)
        'btnCA.PerformClick() - this works
        ''Dim a As Object = New Object : Dim b As System.EventArgs = New System.EventArgs()
        ''btnCA_Click(a, b) - this also works
    End Sub

    Private Sub btnCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCA.Click
        txtAddress.Clear()
        txtEmail.Clear()
        txtFacebook.Clear()
        txtNames.Clear()
        txtOther.Clear()
        txtPN.Clear()
        txtWhatsapp.Clear()
        DateTimePicker1.Value = DateTime.Today
        If CheckedListBox1.GetItemCheckState(0) = CheckState.Checked Then
            CheckedListBox1.SetItemCheckState(0, CheckState.Unchecked)
        ElseIf CheckedListBox1.GetItemCheckState(1) = CheckState.Checked Then
            CheckedListBox1.SetItemCheckState(1, CheckState.Unchecked)
        ElseIf CheckedListBox1.GetItemCheckState(2) = CheckState.Checked Then
            CheckedListBox1.SetItemCheckState(2, CheckState.Unchecked)
        ElseIf CheckedListBox1.GetItemCheckState(3) = CheckState.Checked Then
            CheckedListBox1.SetItemCheckState(3, CheckState.Unchecked)
        ElseIf CheckedListBox1.GetItemCheckState(4) = CheckState.Checked Then
            CheckedListBox1.SetItemCheckState(4, CheckState.Unchecked)
            'ElseIf CheckedListBox1.GetItemCheckState(5) = CheckState.Checked Then
            '    CheckedListBox1.SetItemCheckState(5, CheckState.Unchecked)
        End If
        'For a As Integer = 0 To CheckedListBox1.Items.Count
        '    CheckedListBox1.SetItemCheckState(a, CheckState.Unchecked)
        'Next
        'For a As Integer = 0 To CheckedListBox1.CheckedItems.Count
        '    Do While CheckedListBox1.GetItemCheckState(a) = CheckState.Checked
        '        CheckedListBox1.SetItemCheckState(a, CheckState.Unchecked)
        '    Loop
        'Next
        'For a As Integer = 0 To CheckedListBox1.CheckedItems.Count
        'Dim a As Integer = CheckedListBox1.CheckedItems.Count
        'Do Until CheckedListBox1.GetItemCheckState(a) = CheckState.Unchecked
        '    CheckedListBox1.SetItemCheckState(a, CheckState.Unchecked)
        'Loop
        'Next a
    End Sub
End Class
