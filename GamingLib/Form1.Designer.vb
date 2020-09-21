<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopingCarteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurshasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.GamesToolStripMenuItem, Me.ConsoleToolStripMenuItem, Me.ShopingCarteToolStripMenuItem, Me.PurshasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(841, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewGameToolStripMenuItem, Me.EditAGameToolStripMenuItem, Me.DeleteAGameToolStripMenuItem})
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.GamesToolStripMenuItem.Text = "Games"
        '
        'ConsoleToolStripMenuItem
        '
        Me.ConsoleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewConsoleToolStripMenuItem, Me.EditAConsoleToolStripMenuItem, Me.DeleteAConsoleToolStripMenuItem})
        Me.ConsoleToolStripMenuItem.Name = "ConsoleToolStripMenuItem"
        Me.ConsoleToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ConsoleToolStripMenuItem.Text = "Console"
        '
        'AddNewConsoleToolStripMenuItem
        '
        Me.AddNewConsoleToolStripMenuItem.Name = "AddNewConsoleToolStripMenuItem"
        Me.AddNewConsoleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewConsoleToolStripMenuItem.Text = "Add New Console"
        '
        'AddNewGameToolStripMenuItem
        '
        Me.AddNewGameToolStripMenuItem.Name = "AddNewGameToolStripMenuItem"
        Me.AddNewGameToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewGameToolStripMenuItem.Text = "Add New Game"
        '
        'EditAGameToolStripMenuItem
        '
        Me.EditAGameToolStripMenuItem.Name = "EditAGameToolStripMenuItem"
        Me.EditAGameToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditAGameToolStripMenuItem.Text = "Edit a Game"
        '
        'DeleteAGameToolStripMenuItem
        '
        Me.DeleteAGameToolStripMenuItem.Name = "DeleteAGameToolStripMenuItem"
        Me.DeleteAGameToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteAGameToolStripMenuItem.Text = "Delete a Game"
        '
        'EditAConsoleToolStripMenuItem
        '
        Me.EditAConsoleToolStripMenuItem.Name = "EditAConsoleToolStripMenuItem"
        Me.EditAConsoleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditAConsoleToolStripMenuItem.Text = "Edit a Console"
        '
        'DeleteAConsoleToolStripMenuItem
        '
        Me.DeleteAConsoleToolStripMenuItem.Name = "DeleteAConsoleToolStripMenuItem"
        Me.DeleteAConsoleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteAConsoleToolStripMenuItem.Text = "Delete a Console"
        '
        'ShopingCarteToolStripMenuItem
        '
        Me.ShopingCarteToolStripMenuItem.Name = "ShopingCarteToolStripMenuItem"
        Me.ShopingCarteToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ShopingCarteToolStripMenuItem.Text = "Shoping Carte"
        '
        'PurshasToolStripMenuItem
        '
        Me.PurshasToolStripMenuItem.Name = "PurshasToolStripMenuItem"
        Me.PurshasToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.PurshasToolStripMenuItem.Text = "Purchase History"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(841, 471)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "GamingLib"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopingCarteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurshasToolStripMenuItem As ToolStripMenuItem
End Class
