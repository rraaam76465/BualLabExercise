Public Class Midterm
    Inherits Form
    Public Property PrelimGradeValue As Double
    Private Sub MidtermMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Text = PrelimGradeValue.ToString("F2")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim attendance As Double
        Dim recitation As Double
        Dim quiz As Double
        Dim labExercise As Double
        Dim midtermExam As Double

        If Double.TryParse(TextBox1.Text, attendance) AndAlso
           Double.TryParse(TextBox2.Text, recitation) AndAlso
           Double.TryParse(TextBox3.Text, quiz) AndAlso
           Double.TryParse(TextBox4.Text, labExercise) AndAlso
           Double.TryParse(TextBox5.Text, midtermExam) Then

            Dim tentativeFinalGrade As Double = 0.05 * attendance + 0.05 * recitation + 0.2 * quiz + 0.3 * labExercise + 0.4 * midtermExam
            TextBox6.Text = tentativeFinalGrade.ToString("F2")

            Dim finalGrade As Double = (PrelimGradeValue + 2 * tentativeFinalGrade) / 3
            TextBox8.Text = finalGrade.ToString("F2")
        Else
            MessageBox.Show("Please enter valid numeric values for all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim finalsForm As New Finals()

        Dim midtermGrade As Double
        If Double.TryParse(TextBox8.Text, midtermGrade) Then
            finalsForm.MidtermGradeValue = midtermGrade
        End If

        finalsForm.MdiParent = Me.MdiParent
        finalsForm.StartPosition = FormStartPosition.CenterScreen
        finalsForm.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox8.Clear()

    End Sub

End Class