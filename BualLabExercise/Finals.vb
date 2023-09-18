Public Class Finals
    Inherits Form
    Public Property MidtermGradeValue As Double
    Private Sub MidtermMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Text = MidtermGradeValue.ToString("F2")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



    End Sub


End Class

