<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuParent
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(menuParent))
        MenuStrip = New MenuStrip()
        FileMenu = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        EditMenu = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        ViewMenu = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripMenuItem()
        ToolsMenu = New ToolStripMenuItem()
        ToolStrip = New ToolStrip()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripButton1 = New ToolStripButton()
        ToolStripButton2 = New ToolStripButton()
        ToolStripButton3 = New ToolStripButton()
        ToolStripButton4 = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        ToolStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Items.AddRange(New ToolStripItem() {FileMenu, EditMenu, ViewMenu, ToolsMenu})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(7, 2, 0, 2)
        MenuStrip.Size = New Size(737, 24)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' FileMenu
        ' 
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2})
        FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(37, 20)
        FileMenu.Text = "&File"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl + N"
        ToolStripMenuItem1.Size = New Size(188, 22)
        ToolStripMenuItem1.Text = "Student Info"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.ShortcutKeyDisplayString = "Ctrl + O"
        ToolStripMenuItem2.Size = New Size(188, 22)
        ToolStripMenuItem2.Text = "Subject Info"
        ' 
        ' EditMenu
        ' 
        EditMenu.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem3, ToolStripMenuItem4, ToolStripMenuItem5})
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(53, 20)
        EditMenu.Text = "&Period"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.ShortcutKeyDisplayString = "Ctrl + P"
        ToolStripMenuItem3.Size = New Size(171, 22)
        ToolStripMenuItem3.Text = "Prelim"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.ShortcutKeyDisplayString = "Ctrl + M"
        ToolStripMenuItem4.Size = New Size(171, 22)
        ToolStripMenuItem4.Text = "Midterm"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.ShortcutKeyDisplayString = "Ctrl + F"
        ToolStripMenuItem5.Size = New Size(171, 22)
        ToolStripMenuItem5.Text = "Final"
        ' 
        ' ViewMenu
        ' 
        ViewMenu.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem6, ToolStripMenuItem7})
        ViewMenu.Name = "ViewMenu"
        ViewMenu.Size = New Size(126, 20)
        ViewMenu.Text = "&Student Information"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(148, 22)
        ToolStripMenuItem6.Text = "About Author"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(148, 22)
        ToolStripMenuItem7.Text = "About System"
        ' 
        ' ToolsMenu
        ' 
        ToolsMenu.Name = "ToolsMenu"
        ToolsMenu.Size = New Size(42, 20)
        ToolsMenu.Text = "&Quit"
        ' 
        ' ToolStrip
        ' 
        ToolStrip.Items.AddRange(New ToolStripItem() {ToolStripSeparator1, ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripButton4, ToolStripSeparator2})
        ToolStrip.Location = New Point(0, 24)
        ToolStrip.Name = "ToolStrip"
        ToolStrip.Size = New Size(737, 25)
        ToolStrip.TabIndex = 6
        ToolStrip.Text = "ToolStrip"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 22)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(23, 22)
        ToolStripButton3.Text = "ToolStripButton3"
        ' 
        ' ToolStripButton4
        ' 
        ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        ToolStripButton4.ImageTransparentColor = Color.Magenta
        ToolStripButton4.Name = "ToolStripButton4"
        ToolStripButton4.Size = New Size(23, 22)
        ToolStripButton4.Text = "ToolStripButton4"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' StatusStrip
        ' 
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel})
        StatusStrip.Location = New Point(0, 501)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 16, 0)
        StatusStrip.Size = New Size(737, 22)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(39, 17)
        ToolStripStatusLabel.Text = "Status"
        ' 
        ' menuParent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(737, 523)
        Controls.Add(ToolStrip)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 3, 4, 3)
        Name = "menuParent"
        Text = "menuParent"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ToolStrip.ResumeLayout(False)
        ToolStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents ToolsMenu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
End Class
