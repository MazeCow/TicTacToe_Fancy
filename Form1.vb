Imports System.Runtime.InteropServices

Public Class Form1


#Region "TitleBar"
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub CustomTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles titleBar.MouseDown, titleBar.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#Region "Exit Button"
    Private Sub btnExitEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.BackgroundImage = My.Resources.x_hover
    End Sub
    Private Sub btnExitExit(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackgroundImage = My.Resources.x_default
    End Sub
    Private Sub btnExitMouseDown(sender As Object, e As EventArgs) Handles btnExit.MouseDown
        btnExit.BackgroundImage = My.Resources.x_hold
    End Sub

    Private Sub btnExitMouseUp(sender As Object, e As EventArgs) Handles btnExit.MouseUp
        btnExit.BackgroundImage = My.Resources.x_default
    End Sub
#End Region

#Region "Minimize Button"
    Private Sub btnMinEnter(sender As Object, e As EventArgs) Handles btnMinimize.MouseEnter
        sender.BackgroundImage = My.Resources.minimize_hover
    End Sub
    Private Sub btnMinExit(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        sender.BackgroundImage = My.Resources.minimize_default
    End Sub
    Private Sub btnMinMouseDown(sender As Object, e As EventArgs) Handles btnMinimize.MouseDown
        sender.BackgroundImage = My.Resources.minimize_hold
    End Sub

    Private Sub btnMinMouseUp(sender As Object, e As EventArgs) Handles btnMinimize.MouseUp
        sender.BackgroundImage = My.Resources.minimize_default
    End Sub
#End Region

#End Region

    Private _current_player_turn As String = "X"
    Private Property current_players_turn As String
        Get
            Return _current_player_turn
        End Get
        Set(value As String)
            _current_player_turn = value
        End Set
    End Property

    Private Sub switchplayer()
        If current_players_turn = "O" Then
            current_players_turn = "X"
        ElseIf current_players_turn = "X" Then
            current_players_turn = "O"
        End If
        lblTurn.Text = current_players_turn & "'s Turn"
    End Sub

    Function CheckCoordinatesExistInArray(arr As Control(,), targetX As Integer, targetY As Integer) As Boolean
        For i As Integer = 0 To arr.GetUpperBound(0)
            For j As Integer = 0 To arr.GetUpperBound(1)
                If i = targetX AndAlso j = targetY Then
                    Return True
                End If
            Next
        Next

        Return False
    End Function

    Private last_three_pics(2) As PictureBox
    Private Function check_for_win(coords As Array) As Boolean
        Dim type As String = cells(coords(0), coords(1)).Tag
        Dim count As Integer
        Dim winner As Boolean = False

        Dim move_x As Integer
        Dim move_y As Integer



        Dim diagonal As Array = {coords(0) - 2, coords(1) + 2}
        count = 0
        move_x = 1
        move_y = -1
        For i As Integer = 0 To 4
            If CheckCoordinatesExistInArray(cells, diagonal(0), diagonal(1)) AndAlso cells(diagonal(0), diagonal(1)).Tag = type Then
                last_three_pics(count) = cells(diagonal(0), diagonal(1))
                count += 1
            Else
                count = 0
            End If
            If count = 3 Then
                Return True
            End If
            diagonal(0) += move_x
            diagonal(1) += move_y
        Next

        Dim verticle As Array = {coords(0), coords(1) + 2}
        count = 0
        move_x = 0
        move_y = -1
        For i As Integer = 0 To 4
            If CheckCoordinatesExistInArray(cells, verticle(0), verticle(1)) AndAlso cells(verticle(0), verticle(1)).Tag = type Then
                last_three_pics(count) = cells(verticle(0), verticle(1))
                count += 1
            Else
                count = 0
            End If
            If count = 3 Then
                Return True
            End If
            verticle(0) += move_x
            verticle(1) += move_y
        Next

        Dim horizontal As Array = {coords(0) - 2, coords(1)}
        count = 0
        move_x = 1
        move_y = 0
        For i As Integer = 0 To 4
            If CheckCoordinatesExistInArray(cells, horizontal(0), horizontal(1)) AndAlso cells(horizontal(0), horizontal(1)).Tag = type Then
                last_three_pics(count) = cells(horizontal(0), horizontal(1))
                count += 1
            Else
                count = 0
            End If
            If count = 3 Then
                Return True
            End If
            horizontal(0) += move_x
            horizontal(1) += move_y
        Next



        Return False
    End Function

    Private Sub cell_hover(sender As PictureBox, e As EventArgs)
        If sender.Tag = "" Then
            If current_players_turn = "X" Then
                sender.BackgroundImage = My.Resources.cross_hover
            ElseIf current_players_turn = "O" Then
                sender.BackgroundImage = My.Resources.circle_hover
            End If
        End If
    End Sub

    Private Sub cell_leave(sender As PictureBox, e As EventArgs)
        If sender.Tag = "" Then
            sender.BackgroundImage = My.Resources.empty
        End If
    End Sub
    Private Sub cell_click(sender As PictureBox, e As EventArgs)
        If sender.Tag = "" Then
            Dim coords As Array = pic_to_coords(sender)
            If current_players_turn = "X" Then
                sender.Tag = "X"
                sender.BackgroundImage = My.Resources.cross_placed
            ElseIf current_players_turn = "O" Then
                sender.Tag = "O"
                sender.BackgroundImage = My.Resources.circle_placed
            End If
            If check_for_win(coords) Then
                Console.WriteLine(current_players_turn & " won")
                For Each pictureBox In last_three_pics
                    If current_players_turn = "X" Then
                        pictureBox.BackgroundImage = My.Resources.cross_win
                    ElseIf current_players_turn = "O" Then
                        pictureBox.BackgroundImage = My.Resources.circle_win
                    End If

                Next
            Else
                switchplayer()
            End If

        End If
    End Sub

    Private cells(2, 2) As Control

    Private Function pic_to_coords(picturebox As PictureBox) As Array
        Dim coords(2) As String
        coords = picturebox.Name.Split(",")
        Return coords
    End Function

    Private Sub populate_array()
        'populates picturebox array and the board
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                Dim cell As New PictureBox
                With cell
                    .Name = String.Format("{0},{1}", x, y)
                    .BackgroundImage = My.Resources.empty
                    .AutoSize = False
                    .Size = New Size(101, 101)
                    .BackgroundImageLayout = ImageLayout.Stretch
                    .Margin = New Padding(3, 3, 3, 3)
                    .BackColor = Color.Red
                End With
                AddHandler cell.MouseEnter, AddressOf cell_hover
                AddHandler cell.MouseLeave, AddressOf cell_leave
                AddHandler cell.Click, AddressOf cell_click
                cells(x, y) = cell
                board.Controls.Add(cell)

            Next
        Next
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim browserMenuRenderer As New BrowserMenuRenderer()
        'SettingsToolStripMenuItem.DropDown.Renderer = browserMenuRenderer
        lblTurn.Text = current_players_turn & "'s Turn"
        populate_array()
    End Sub
End Class