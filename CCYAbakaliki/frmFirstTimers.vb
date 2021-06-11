Public Class frmFirstTimers

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmDashBoard.Enabled = True
    End Sub
End Class