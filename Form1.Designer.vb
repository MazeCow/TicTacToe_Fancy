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
        Me.tsmiPlayer = New System.Windows.Forms.ToolStripMenuItem()
        Me.optnSingle = New System.Windows.Forms.ToolStripMenuItem()
        Me.optnTwo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStartingPiece = New System.Windows.Forms.ToolStripMenuItem()
        Me.optnX = New System.Windows.Forms.ToolStripMenuItem()
        Me.optnO = New System.Windows.Forms.ToolStripMenuItem()
        Me.board = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOWins = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblXWins = New System.Windows.Forms.Label()
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
        Me.titleBar.Padding = New System.Windows.Forms.Padding(0)
        Me.titleBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.titleBar.Size = New System.Drawing.Size(345, 24)
        Me.titleBar.TabIndex = 0
        Me.titleBar.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPlayer, Me.tsmiStartingPiece})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'tsmiPlayer
        '
        Me.tsmiPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.tsmiPlayer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.optnSingle, Me.optnTwo})
        Me.tsmiPlayer.ForeColor = System.Drawing.Color.White
        Me.tsmiPlayer.Name = "tsmiPlayer"
        Me.tsmiPlayer.Padding = New System.Windows.Forms.Padding(0)
        Me.tsmiPlayer.Size = New System.Drawing.Size(157, 20)
        Me.tsmiPlayer.Text = "Player Mode"
        Me.tsmiPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'optnSingle
        '
        Me.optnSingle.AutoSize = False
        Me.optnSingle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.optnSingle.ForeColor = System.Drawing.Color.White
        Me.optnSingle.Name = "optnSingle"
        Me.optnSingle.Size = New System.Drawing.Size(180, 22)
        Me.optnSingle.Text = "Single Player (P vs. C)"
        '
        'optnTwo
        '
        Me.optnTwo.AutoSize = False
        Me.optnTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.optnTwo.Checked = True
        Me.optnTwo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optnTwo.ForeColor = System.Drawing.Color.White
        Me.optnTwo.Name = "optnTwo"
        Me.optnTwo.Size = New System.Drawing.Size(180, 22)
        Me.optnTwo.Text = "Two Player (P vs. P)"
        '
        'tsmiStartingPiece
        '
        Me.tsmiStartingPiece.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.tsmiStartingPiece.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.optnX, Me.optnO})
        Me.tsmiStartingPiece.ForeColor = System.Drawing.Color.White
        Me.tsmiStartingPiece.Name = "tsmiStartingPiece"
        Me.tsmiStartingPiece.Padding = New System.Windows.Forms.Padding(0)
        Me.tsmiStartingPiece.Size = New System.Drawing.Size(157, 20)
        Me.tsmiStartingPiece.Text = "Starting Piece"
        '
        'optnX
        '
        Me.optnX.AutoSize = False
        Me.optnX.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.optnX.Checked = True
        Me.optnX.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optnX.ForeColor = System.Drawing.Color.White
        Me.optnX.Name = "optnX"
        Me.optnX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optnX.Size = New System.Drawing.Size(180, 22)
        Me.optnX.Text = "X"
        '
        'optnO
        '
        Me.optnO.AutoSize = False
        Me.optnO.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.optnO.ForeColor = System.Drawing.Color.White
        Me.optnO.Name = "optnO"
        Me.optnO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optnO.Size = New System.Drawing.Size(180, 22)
        Me.optnO.Text = "O"
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
        Me.Label2.Location = New System.Drawing.Point(19, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X Wins:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(188, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 37)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "O Wins:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOWins
        '
        Me.lblOWins.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblOWins.ForeColor = System.Drawing.Color.White
        Me.lblOWins.Location = New System.Drawing.Point(289, 412)
        Me.lblOWins.Name = "lblOWins"
        Me.lblOWins.Size = New System.Drawing.Size(34, 37)
        Me.lblOWins.TabIndex = 8
        Me.lblOWins.Text = "0"
        Me.lblOWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblXWins
        '
        Me.lblXWins.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblXWins.ForeColor = System.Drawing.Color.White
        Me.lblXWins.Location = New System.Drawing.Point(120, 412)
        Me.lblXWins.Name = "lblXWins"
        Me.lblXWins.Size = New System.Drawing.Size(34, 37)
        Me.lblXWins.TabIndex = 9
        Me.lblXWins.Text = "0"
        Me.lblXWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(345, 471)
        Me.Controls.Add(Me.lblXWins)
        Me.Controls.Add(Me.lblOWins)
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
    Friend WithEvents lblOWins As Label
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiPlayer As ToolStripMenuItem
    Friend WithEvents optnSingle As ToolStripMenuItem
    Friend WithEvents optnTwo As ToolStripMenuItem
    Friend WithEvents tsmiStartingPiece As ToolStripMenuItem
    Friend WithEvents optnX As ToolStripMenuItem
    Friend WithEvents optnO As ToolStripMenuItem
    Friend WithEvents lblXWins As Label
End Class
