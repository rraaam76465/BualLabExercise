<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Author
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(330, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 0
        Label1.Text = "About The Author"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(309, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 15)
        Label2.TabIndex = 1
        Label2.Text = "Name : Edrick Mar O. Bual"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(337, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(324, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 15)
        Label4.TabIndex = 3
        Label4.Text = "Contact Information"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(285, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(193, 15)
        Label5.TabIndex = 4
        Label5.Text = "Email : edrick.bual.coi@pcu.edu.ph"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(322, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 15)
        Label6.TabIndex = 5
        Label6.Text = "Github : rraaam76465"
        ' 
        ' Author
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Author"
        Text = "Author"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
