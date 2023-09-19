Public Class Prelims
    'Compute
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim attendance As Double
        Dim recitation As Double
        Dim quiz As Double
        Dim labExercise As Double
        Dim prelimExam As Double
        Dim prelimGrade As Double

        If Double.TryParse(TextBox1.Text, attendance) AndAlso
        Double.TryParse(TextBox2.Text, recitation) AndAlso
        Double.TryParse(TextBox3.Text, quiz) AndAlso
        Double.TryParse(TextBox4.Text, labExercise) AndAlso
        Double.TryParse(TextBox5.Text, prelimExam) Then
            ' prelim grade formula
            prelimGrade = 0.05 * attendance + 0.05 * recitation + 0.2 * quiz + 0.3 * labExercise + 0.4 * prelimExam


            TextBox6.Text = prelimGrade.ToString("F2")
        Else

            MessageBox.Show("Please enter valid numeric values for all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'Midterm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim midtermForm As New Midterm()

        Dim prelimGrade As Double
        If Double.TryParse(TextBox6.Text, prelimGrade) Then
            midtermForm.PrelimGradeValue = prelimGrade
        End If

        midtermForm.MdiParent = Me.MdiParent
        midtermForm.StartPosition = FormStartPosition.CenterScreen
        midtermForm.Show()
        Me.Close()


    End Sub
    'New Data
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub


End Class