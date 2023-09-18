Imports System.Windows.Forms

Public Class menuParent
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        StudentInfo.MdiParent = Me
        StudentInfo.WindowState = FormWindowState.Normal
        StudentInfo.Show()

    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        SubjectInfo.MdiParent = Me
        SubjectInfo.WindowState = FormWindowState.Normal
        SubjectInfo.Show()

    End Sub




    Private Sub ToolsMenu_Click(sender As Object, e As EventArgs) Handles ToolsMenu.Click
        Close()
    End Sub

End Class
