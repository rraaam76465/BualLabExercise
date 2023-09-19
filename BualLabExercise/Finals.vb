Public Class Finals
    Inherits Form
    Public Property MidtermGradeValue As Double
    Private Sub MidtermMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Text = MidtermGradeValue.ToString("F2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim midtermGrade As Double
        Dim attendance As Double
        Dim recitation As Double
        Dim quiz As Double
        Dim labExercise As Double
        Dim finalExam As Double

        ' Parse user input from TextBoxes
        If Double.TryParse(TextBox7.Text, midtermGrade) AndAlso
           Double.TryParse(TextBox1.Text, attendance) AndAlso
           Double.TryParse(TextBox2.Text, recitation) AndAlso
           Double.TryParse(TextBox3.Text, quiz) AndAlso
           Double.TryParse(TextBox4.Text, labExercise) AndAlso
           Double.TryParse(TextBox5.Text, finalExam) Then
            ' Calculate tentative final grade using the provided formula
            Dim tentativeFinalGrade As Double = 0.05 * attendance + 0.05 * recitation + 0.2 * quiz + 0.3 * labExercise + 0.4 * finalExam

            ' Calculate final grade using the provided formula
            Dim finalGrade As Double = (midtermGrade + 2 * tentativeFinalGrade) / 3

            ' Display the computed final grade in TextBoxFinalGrade
            TextBox6.Text = tentativeFinalGrade.ToString("F2")
            TextBox8.Text = finalGrade.ToString("F2")
        Else
            ' Handle invalid input
            MessageBox.Show("Please enter valid numeric values for all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox8.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub
End Class

