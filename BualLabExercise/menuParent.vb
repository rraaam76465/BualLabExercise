Imports System.Windows.Forms

Public Class menuParent
    'Student Info
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        StudentInfo.MdiParent = Me
        StudentInfo.StartPosition = FormStartPosition.CenterScreen
        StudentInfo.WindowState = FormWindowState.Normal
        StudentInfo.Show()

    End Sub
    'Subject Info
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        SubjectInfo.MdiParent = Me
        SubjectInfo.StartPosition = FormStartPosition.CenterScreen
        SubjectInfo.WindowState = FormWindowState.Normal
        SubjectInfo.Show()

    End Sub
    'Prelims
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        Prelims.MdiParent = Me
        Prelims.StartPosition = FormStartPosition.CenterScreen
        Prelims.WindowState = FormWindowState.Normal
        Prelims.Show()

    End Sub
    ' Midterm
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click

        Midterm.MdiParent = Me
        Midterm.StartPosition = FormStartPosition.CenterScreen
        Midterm.WindowState = FormWindowState.Normal
        Midterm.Show()

    End Sub


    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click

        Finals.MdiParent = Me
        Finals.StartPosition = FormStartPosition.CenterScreen
        Finals.WindowState = FormWindowState.Normal
        Finals.Show()

    End Sub










    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Prelims.MdiParent = Me
        Prelims.StartPosition = FormStartPosition.CenterScreen
        Prelims.WindowState = FormWindowState.Normal
        Prelims.Show()

    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Midterm.MdiParent = Me
        Midterm.StartPosition = FormStartPosition.CenterScreen
        Midterm.WindowState = FormWindowState.Normal
        Midterm.Show()

    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Finals.MdiParent = Me
        Finals.StartPosition = FormStartPosition.CenterScreen
        Finals.WindowState = FormWindowState.Normal
        Finals.Show()

    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub

    'Quit
    Private Sub ToolsMenu_Click(sender As Object, e As EventArgs) Handles ToolsMenu.Click
        Close()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        AboutSystem.MdiParent = Me
        AboutSystem.StartPosition = FormStartPosition.CenterScreen
        AboutSystem.WindowState = FormWindowState.Normal
        AboutSystem.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Author.MdiParent = Me
        Author.StartPosition = FormStartPosition.CenterScreen
        Author.WindowState = FormWindowState.Normal
        Author.Show()
    End Sub
End Class
