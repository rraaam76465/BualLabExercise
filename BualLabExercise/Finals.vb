Public Class Finals
    Inherits Form
    Public Property MidtermGradeValue As Double
    Private Sub MidtermMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Text = MidtermGradeValue.ToString("F2")
    End Sub



End Class

