Public Class frmDashBoard

    Private Sub YouthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YouthToolStripMenuItem.Click
        frmYouthData.Show()
        Me.Enabled = False
    End Sub

    Private Sub VistitorFirstTimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistitorFirstTimerToolStripMenuItem.Click
        frmFirstTimers.Show()
        Me.Enabled = False
    End Sub

    Private Sub EvangelismToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvangelismToolStripMenuItem.Click
        frmEvangelism.Show()
        Me.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class