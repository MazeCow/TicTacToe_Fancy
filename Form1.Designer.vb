<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.titleBar = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.board = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblXWins = New System.Windows.Forms.Label()
        Me.lblYWins = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TwoPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.titleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleBar
        '
        Me.titleBar.AutoSize = False
        Me.titleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.titleBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.titleBar.Location = New System.Drawing.Point(0, 0)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.titleBar.Size = New System.Drawing.Size(345, 24)
        Me.titleBar.TabIndex = 0
        Me.titleBar.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.TwoPlayerToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ToolStripMenuItem1.Checked = True
        Me.ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem1.Text = "Two Player"
        Me.ToolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'board
        '
        Me.board.Location = New System.Drawing.Point(12, 74)
        Me.board.Name = "board"
        Me.board.Size = New System.Drawing.Size(321, 321)
        Me.board.TabIndex = 3
        '
        'lblTurn
        '
        Me.lblTurn.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTurn.ForeColor = System.Drawing.Color.White
        Me.lblTurn.Location = New System.Drawing.Point(76, 31)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(195, 37)
        Me.lblTurn.TabIndex = 4
        Me.lblTurn.Text = "__'s Turn"
        Me.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X Wins"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(211, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 37)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Y Wins"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblXWins
        '
        Me.lblXWins.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblXWins.ForeColor = System.Drawing.Color.White
        Me.lblXWins.Location = New System.Drawing.Point(28, 450)
        Me.lblXWins.Name = "lblXWins"
        Me.lblXWins.Size = New System.Drawing.Size(104, 37)
        Me.lblXWins.TabIndex = 7
        Me.lblXWins.Text = "0"
        Me.lblXWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYWins
        '
        Me.lblYWins.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblYWins.ForeColor = System.Drawing.Color.White
        Me.lblYWins.Location = New System.Drawing.Point(211, 450)
        Me.lblYWins.Name = "lblYWins"
        Me.lblYWins.Size = New System.Drawing.Size(104, 37)
        Me.lblYWins.TabIndex = 8
        Me.lblYWins.Text = "0"
        Me.lblYWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(296, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(26, 24)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(321, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(24, 24)
        Me.btnExit.TabIndex = 1
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TwoPlayerToolStripMenuItem
        '
        Me.TwoPlayerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TwoPlayerToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TwoPlayerToolStripMenuItem.Name = "TwoPlayerToolStripMenuItem"
        Me.TwoPlayerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TwoPlayerToolStripMenuItem.Text = "Single Player"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(345, 501)
        Me.Controls.Add(Me.lblYWins)
        Me.Controls.Add(Me.lblXWins)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTurn)
        Me.Controls.Add(Me.board)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.titleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.titleBar
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.titleBar.ResumeLayout(False)
        Me.titleBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titleBar As MenuStrip
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents board As FlowLayoutPanel
    Friend WithEvents lblTurn As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblXWins As Label
    Friend WithEvents lblYWins As Label
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TwoPlayerToolStripMenuItem As ToolStripMenuItem
End Class
