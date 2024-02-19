<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminhomepage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adminhomepage))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Room1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Room2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KitchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ModifyUserToolStripMenuItem, Me.StatusToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.BackColor = System.Drawing.Color.OldLace
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AddUserToolStripMenuItem.Text = "Add user"
        '
        'ModifyUserToolStripMenuItem
        '
        Me.ModifyUserToolStripMenuItem.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ModifyUserToolStripMenuItem.Name = "ModifyUserToolStripMenuItem"
        Me.ModifyUserToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ModifyUserToolStripMenuItem.Text = "Modify/delete user"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.BackColor = System.Drawing.Color.OldLace
        Me.StatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserReportToolStripMenuItem, Me.StatusReportToolStripMenuItem})
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.StatusToolStripMenuItem.Text = "Report"
        '
        'UserReportToolStripMenuItem
        '
        Me.UserReportToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.UserReportToolStripMenuItem.Name = "UserReportToolStripMenuItem"
        Me.UserReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserReportToolStripMenuItem.Text = "User Report"
        '
        'StatusReportToolStripMenuItem
        '
        Me.StatusReportToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.StatusReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Room1ToolStripMenuItem, Me.Room2ToolStripMenuItem, Me.HallToolStripMenuItem, Me.KitchenToolStripMenuItem})
        Me.StatusReportToolStripMenuItem.Name = "StatusReportToolStripMenuItem"
        Me.StatusReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StatusReportToolStripMenuItem.Text = "Status Report"
        '
        'Room1ToolStripMenuItem
        '
        Me.Room1ToolStripMenuItem.BackColor = System.Drawing.Color.MintCream
        Me.Room1ToolStripMenuItem.Name = "Room1ToolStripMenuItem"
        Me.Room1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Room1ToolStripMenuItem.Text = "Room1"
        '
        'Room2ToolStripMenuItem
        '
        Me.Room2ToolStripMenuItem.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Room2ToolStripMenuItem.Name = "Room2ToolStripMenuItem"
        Me.Room2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Room2ToolStripMenuItem.Text = "Room 2"
        '
        'HallToolStripMenuItem
        '
        Me.HallToolStripMenuItem.BackColor = System.Drawing.Color.MintCream
        Me.HallToolStripMenuItem.Name = "HallToolStripMenuItem"
        Me.HallToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HallToolStripMenuItem.Text = "Hall"
        '
        'KitchenToolStripMenuItem
        '
        Me.KitchenToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk
        Me.KitchenToolStripMenuItem.Name = "KitchenToolStripMenuItem"
        Me.KitchenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KitchenToolStripMenuItem.Text = "Kitchen"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 727)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Adminhomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Adminhomepage"
        Me.Text = "Adminhomepage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Room1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Room2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KitchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
