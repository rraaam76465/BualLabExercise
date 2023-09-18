<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prelims
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(503, 199)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "COMPUTE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(503, 242)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "MIDTERM"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(503, 285)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "NEW DATA"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(121, 121)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 3
        Label1.Text = "Attendance :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(121, 164)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 4
        Label2.Text = "Recitation :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(121, 207)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.No
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 5
        Label3.Text = "Quiz :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(121, 250)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.No
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 6
        Label4.Text = "Lab Exercises :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(121, 293)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(79, 15)
        Label5.TabIndex = 7
        Label5.Text = "Prelim Exam :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(441, 121)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(81, 15)
        Label6.TabIndex = 8
        Label6.Text = "Prelim Grade :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(221, 118)
        TextBox1.Name = "TextBox1"
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(221, 161)
        TextBox2.Name = "TextBox2"
        TextBox2.RightToLeft = RightToLeft.No
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(221, 204)
        TextBox3.Name = "TextBox3"
        TextBox3.RightToLeft = RightToLeft.No
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(221, 247)
        TextBox4.Name = "TextBox4"
        TextBox4.RightToLeft = RightToLeft.No
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(221, 290)
        TextBox5.Name = "TextBox5"
        TextBox5.RightToLeft = RightToLeft.No
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 13
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(537, 118)
        TextBox6.Name = "TextBox6"
        TextBox6.RightToLeft = RightToLeft.No
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 14
        ' 
        ' Prelims
        ' 
        AccessibleName = "Prelims"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Prelims"
        RightToLeft = RightToLeft.No
        StartPosition = FormStartPosition.Manual
        Text = "Prelims"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
