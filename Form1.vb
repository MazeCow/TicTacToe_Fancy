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
        If Not menuopen Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        End If

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If Not menuopen Then
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If Not menuopen Then
            Me.Close()
        End If

    End Sub

#Region "Exit Button"
    Private Sub btnExitEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        If Not menuopen Then
            btnExit.BackgroundImage = My.Resources.x_hover
        End If
    End Sub
    Private Sub btnExitExit(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        If Not menuopen Then
            btnExit.BackgroundImage = My.Resources.x_default
        End If
    End Sub
    Private Sub btnExitMouseDown(sender As Object, e As EventArgs) Handles btnExit.MouseDown
        If Not menuopen Then
            btnExit.BackgroundImage = My.Resources.x_hold
        End If
    End Sub

    Private Sub btnExitMouseUp(sender As Object, e As EventArgs) Handles btnExit.MouseUp
        If Not menuopen Then
            btnExit.BackgroundImage = My.Resources.x_default
        End If
    End Sub
#End Region

#Region "Minimize Button"
    Private Sub btnMinEnter(sender As Object, e As EventArgs) Handles btnMinimize.MouseEnter
        If Not menuopen Then
            sender.BackgroundImage = My.Resources.minimize_hover
        End If

    End Sub
    Private Sub btnMinExit(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        If Not menuopen Then
            sender.BackgroundImage = My.Resources.minimize_default
        End If

    End Sub
    Private Sub btnMinMouseDown(sender As Object, e As EventArgs) Handles btnMinimize.MouseDown
        If Not menuopen Then
            sender.BackgroundImage = My.Resources.minimize_hold
        End If

    End Sub

    Private Sub btnMinMouseUp(sender As Object, e As EventArgs) Handles btnMinimize.MouseUp
        If Not menuopen Then
            sender.BackgroundImage = My.Resources.minimize_default
        End If

    End Sub
#End Region

#End Region



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

        Dim diagonal2 As Array = {coords(0) - 2, coords(1) - 2}
        count = 0
        move_x = 1
        move_y = 1
        For i As Integer = 0 To 4
            If CheckCoordinatesExistInArray(cells, diagonal2(0), diagonal2(1)) AndAlso cells(diagonal2(0), diagonal2(1)).Tag = type Then
                last_three_pics(count) = cells(diagonal2(0), diagonal2(1))
                count += 1
            Else
                count = 0
            End If
            If count = 3 Then
                Return True
            End If
            diagonal2(0) += move_x
            diagonal2(1) += move_y
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


    'Edit this function to return the coordinates of an almost win
    Private Function check_for_block() As PictureBox
        If cells(0, 2).Tag = "X" AndAlso cells(1, 2).Tag = "X" AndAlso cells(2, 2).Tag = "" Then
            Return cells(2, 2)
        ElseIf cells(0, 2).Tag = "X" AndAlso cells(2, 2).Tag = "X" AndAlso cells(1, 2).Tag = "" Then
            Return cells(1, 2)
        ElseIf cells(1, 2).Tag = "X" AndAlso cells(2, 2).Tag = "X" AndAlso cells(0, 2).Tag = "" Then
            Return cells(0, 2)

        ElseIf cells(0, 1).Tag = "X" AndAlso cells(1, 1).Tag = "X" AndAlso cells(2, 1).Tag = "" Then
            Return cells(2, 1)
        ElseIf cells(0, 1).Tag = "X" AndAlso cells(2, 1).Tag = "X" AndAlso cells(1, 1).Tag = "" Then
            Return cells(1, 1)
        ElseIf cells(1, 1).Tag = "X" AndAlso cells(2, 1).Tag = "X" AndAlso cells(0, 1).Tag = "" Then
            Return cells(0, 1)

        ElseIf cells(0, 0).Tag = "X" AndAlso cells(1, 0).Tag = "X" AndAlso cells(2, 0).Tag = "" Then
            Return cells(2, 0)
        ElseIf cells(0, 0).Tag = "X" AndAlso cells(2, 0).Tag = "X" AndAlso cells(1, 0).Tag = "" Then
            Return cells(1, 0)
        ElseIf cells(1, 0).Tag = "X" AndAlso cells(2, 0).Tag = "X" AndAlso cells(0, 0).Tag = "" Then
            Return cells(0, 0)




        ElseIf cells(0, 0).Tag = "X" AndAlso cells(0, 1).Tag = "X" AndAlso cells(0, 2).Tag = "" Then
            Return cells(0, 2)
        ElseIf cells(0, 0).Tag = "X" AndAlso cells(0, 2).Tag = "X" AndAlso cells(0, 1).Tag = "" Then
            Return cells(0, 1)
        ElseIf cells(0, 1).Tag = "X" AndAlso cells(0, 2).Tag = "X" AndAlso cells(0, 0).Tag = "" Then
            Return cells(0, 0)

        ElseIf cells(1, 0).Tag = "X" AndAlso cells(1, 1).Tag = "X" AndAlso cells(1, 2).Tag = "" Then
            Return cells(1, 2)
        ElseIf cells(1, 0).Tag = "X" AndAlso cells(1, 2).Tag = "X" AndAlso cells(1, 1).Tag = "" Then
            Return cells(1, 1)
        ElseIf cells(1, 1).Tag = "X" AndAlso cells(1, 2).Tag = "X" AndAlso cells(1, 0).Tag = "" Then
            Return cells(1, 0)

        ElseIf cells(2, 0).Tag = "X" AndAlso cells(2, 1).Tag = "X" AndAlso cells(2, 2).Tag = "" Then
            Return cells(2, 2)
        ElseIf cells(2, 0).Tag = "X" AndAlso cells(2, 2).Tag = "X" AndAlso cells(2, 1).Tag = "" Then
            Return cells(2, 1)
        ElseIf cells(2, 1).Tag = "X" AndAlso cells(2, 2).Tag = "X" AndAlso cells(2, 0).Tag = "" Then
            Return cells(2, 0)



        ElseIf cells(0, 2).Tag = "X" AndAlso cells(2, 0).Tag = "X" AndAlso cells(1, 1).Tag = "" Then
            Return cells(1, 1)
        ElseIf cells(0, 2).Tag = "X" AndAlso cells(1, 1).Tag = "X" AndAlso cells(2, 0).Tag = "" Then
            Return cells(2, 0)
        ElseIf cells(1, 1).Tag = "X" AndAlso cells(0, 2).Tag = "X" AndAlso cells(0, 2).Tag = "" Then
            Return cells(0, 2)

        ElseIf cells(2, 2).Tag = "X" AndAlso cells(0, 0).Tag = "X" AndAlso cells(1, 1).Tag = "" Then
            Return cells(1, 1)
        ElseIf cells(1, 1).Tag = "X" AndAlso cells(2, 2).Tag = "X" AndAlso cells(0, 0).Tag = "" Then
            Return cells(0, 0)
        ElseIf cells(0, 0).Tag = "X" AndAlso cells(1, 1).Tag = "X" AndAlso cells(2, 2).Tag <> "X" AndAlso cells(2, 2).Tag <> "O" Then
            Return cells(2, 2)
        End If

        Return Nothing
    End Function

    Private Function check_for_winspot() As PictureBox
        If cells(0, 2).Tag = "O" AndAlso cells(1, 2).Tag = "O" AndAlso cells(2, 2).Tag <> "X" AndAlso cells(2, 2).Tag <> "O" Then
            Return cells(2, 2)
        ElseIf cells(0, 2).Tag = "O" AndAlso cells(2, 2).Tag = "O" AndAlso cells(1, 2).Tag <> "X" AndAlso cells(1, 2).Tag <> "O" Then
            Return cells(1, 2)
        ElseIf cells(1, 2).Tag = "O" AndAlso cells(2, 2).Tag = "O" AndAlso cells(0, 2).Tag <> "X" AndAlso cells(0, 2).Tag <> "O" Then
            Return cells(0, 2)

        ElseIf cells(0, 1).Tag = "O" AndAlso cells(1, 1).Tag = "O" AndAlso cells(2, 1).Tag <> "X" AndAlso cells(2, 1).Tag <> "O" Then
            Return cells(2, 1)
        ElseIf cells(0, 1).Tag = "O" AndAlso cells(2, 1).Tag = "O" AndAlso cells(1, 1).Tag <> "X" AndAlso cells(1, 1).Tag <> "O" Then
            Return cells(1, 1)
        ElseIf cells(1, 1).Tag = "O" AndAlso cells(2, 1).Tag = "O" AndAlso cells(0, 1).Tag <> "X" AndAlso cells(0, 1).Tag <> "O" Then
            Return cells(0, 1)

        ElseIf cells(0, 0).Tag = "O" AndAlso cells(1, 0).Tag = "O" AndAlso cells(2, 0).Tag <> "X" AndAlso cells(2, 0).Tag <> "O" Then
            Return cells(2, 0)
        ElseIf cells(0, 0).Tag = "O" AndAlso cells(2, 0).Tag = "O" AndAlso cells(1, 0).Tag <> "X" AndAlso cells(1, 0).Tag <> "O" Then
            Return cells(1, 0)
        ElseIf cells(1, 0).Tag = "O" AndAlso cells(2, 0).Tag = "O" AndAlso cells(0, 0).Tag <> "X" AndAlso cells(0, 0).Tag <> "O" Then
            Return cells(0, 0)




        ElseIf cells(0, 0).Tag = "O" AndAlso cells(0, 1).Tag = "O" AndAlso cells(0, 2).Tag <> "X" AndAlso cells(0, 1).Tag <> "O" Then
            Return cells(0, 2)
        ElseIf cells(0, 0).Tag = "O" AndAlso cells(0, 2).Tag = "O" AndAlso cells(0, 1).Tag <> "X" AndAlso cells(0, 1).Tag <> "O" Then
            Return cells(0, 1)
        ElseIf cells(0, 1).Tag = "O" AndAlso cells(0, 2).Tag = "O" AndAlso cells(0, 0).Tag <> "X" AndAlso cells(0, 0).Tag <> "O" Then
            Return cells(0, 0)

        ElseIf cells(1, 0).Tag = "O" AndAlso cells(1, 1).Tag = "O" AndAlso cells(1, 2).Tag <> "X" AndAlso cells(1, 2).Tag <> "O" Then
            Return cells(1, 2)
        ElseIf cells(1, 0).Tag = "O" AndAlso cells(1, 2).Tag = "O" AndAlso cells(1, 1).Tag <> "X" AndAlso cells(1, 1).Tag <> "O" Then
            Return cells(1, 1)
        ElseIf cells(1, 1).Tag = "O" AndAlso cells(1, 2).Tag = "O" AndAlso cells(1, 0).Tag <> "X" AndAlso cells(1, 0).Tag <> "O" Then
            Return cells(1, 0)

        ElseIf cells(2, 0).Tag = "O" AndAlso cells(2, 1).Tag = "O" AndAlso cells(2, 2).Tag <> "X" AndAlso cells(2, 2).Tag <> "O" Then
            Return cells(2, 2)
        ElseIf cells(2, 0).Tag = "O" AndAlso cells(2, 2).Tag = "O" AndAlso cells(2, 1).Tag <> "X" AndAlso cells(2, 1).Tag <> "O" Then
            Return cells(2, 1)
        ElseIf cells(2, 1).Tag = "O" AndAlso cells(2, 2).Tag = "O" AndAlso cells(2, 0).Tag <> "X" AndAlso cells(2, 0).Tag <> "O" Then
            Return cells(2, 0)



        ElseIf cells(0, 2).Tag = "O" AndAlso cells(2, 0).Tag = "O" AndAlso cells(1, 1).Tag <> "X" AndAlso cells(1, 1).Tag <> "O" Then
            Return cells(1, 1)
        ElseIf cells(0, 2).Tag = "O" AndAlso cells(1, 1).Tag = "O" AndAlso cells(2, 0).Tag <> "X" AndAlso cells(2, 0).Tag <> "O" Then
            Return cells(2, 0)
        ElseIf cells(1, 1).Tag = "O" AndAlso cells(0, 2).Tag = "O" AndAlso cells(0, 2).Tag <> "X" AndAlso cells(0, 2).Tag <> "O" Then
            Return cells(0, 2)

        ElseIf cells(2, 2).Tag = "O" AndAlso cells(0, 0).Tag = "O" AndAlso cells(1, 1).Tag <> "X" AndAlso cells(1, 1).Tag <> "O" Then
            Return cells(1, 1)
        ElseIf cells(1, 1).Tag = "O" AndAlso cells(2, 2).Tag = "O" AndAlso cells(0, 0).Tag <> "X" AndAlso cells(0, 0).Tag <> "O" Then
            Return cells(0, 0)
        ElseIf cells(0, 0).Tag = "O" AndAlso cells(1, 1).Tag = "O" AndAlso cells(2, 2).Tag <> "X" AndAlso cells(2, 2).Tag <> "O" Then
            Return cells(2, 2)
        End If

        Return Nothing
    End Function

    Private Function CheckForTie() As Boolean
        Dim tie As Boolean = True
        For Each item In cells
            If item.Tag = "" Or item.Tag = Nothing Then
                tie = False
            End If
        Next
        Return tie
    End Function

    Private Sub cell_hover(sender As PictureBox, e As EventArgs)
        Console.WriteLine("TAG: " & sender.Tag)
        If Not menuopen Then
            If sender.Tag = "" Then
                If current_players_turn = "X" Then
                    sender.BackgroundImage = My.Resources.cross_hover
                ElseIf current_players_turn = "O" Then
                    sender.BackgroundImage = My.Resources.circle_hover
                End If
            End If
        End If
    End Sub

    Private Sub cell_leave(sender As PictureBox, e As EventArgs)
        If Not menuopen Then
            If sender.Tag = "" Then
                sender.BackgroundImage = My.Resources.empty
            End If
        End If
    End Sub

    Private Sub addwin(player As String)
        If player = "X" Then
            Dim win As Integer
            Integer.TryParse(lblXWins.Text, win)
            win += 1
            lblXWins.Text = win
        ElseIf player = "O" Then
            Dim win As Integer
            Integer.TryParse(lblOWins.Text, win)
            win += 1
            lblOWins.Text = win
        End If
    End Sub
    Private Sub cell_click(sender As PictureBox, e As EventArgs)
        If Not menuopen Then
            If sender.Tag = "" Then


                If current_mode = "two" Then
                    Dim coords As Array = pic_to_coords(sender)
                    If current_players_turn = "X" Then
                        sender.Tag = "X"
                        sender.BackgroundImage = My.Resources.cross_placed
                    ElseIf current_players_turn = "O" Then
                        sender.Tag = "O"
                        sender.BackgroundImage = My.Resources.circle_placed
                    End If
                    If check_for_win(coords) Then
                        For Each pictureBox In last_three_pics
                            If current_players_turn = "X" Then
                                pictureBox.BackgroundImage = My.Resources.cross_win
                            ElseIf current_players_turn = "O" Then
                                pictureBox.BackgroundImage = My.Resources.circle_win
                            End If
                        Next
                        MessageBox.Show(String.Format("{0} won!", current_players_turn), "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        addwin(current_players_turn)
                        populate_array()
                    Else
                        switchplayer()
                        If CheckForTie() Then
                            MessageBox.Show(String.Format("Nobody won!", current_players_turn), "Tie!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            populate_array()
                        End If
                    End If


                ElseIf current_mode = "single" Then
                    Dim coords As Array = pic_to_coords(sender)
                    If current_players_turn = "X" Then
                        sender.Tag = "X"
                        sender.BackgroundImage = My.Resources.cross_placed
                    ElseIf current_players_turn = "O" Then
                        sender.Tag = "O"
                        sender.BackgroundImage = My.Resources.circle_placed
                    End If
                    If check_for_win(coords) Then
                        For Each pictureBox In last_three_pics
                            If current_players_turn = "X" Then
                                pictureBox.BackgroundImage = My.Resources.cross_win
                            ElseIf current_players_turn = "O" Then
                                pictureBox.BackgroundImage = My.Resources.circle_win
                            End If
                        Next
                        MessageBox.Show(String.Format("{0} won!", current_players_turn), "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        addwin(current_players_turn)
                        populate_array()
                    Else
                        switchplayer()
                        If CheckForTie() Then
                            MessageBox.Show(String.Format("Nobody won!", current_players_turn), "Tie!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            populate_array()
                        Else
                            If current_players_turn = "O" Then
                                ComputerDefense()
                            End If
                        End If
                    End If


                End If
            End If
        End If
    End Sub

    Private Sub ComputerDefense()
        Dim foundmove As PictureBox = check_for_winspot()
        If foundmove Is Nothing Then
            foundmove = check_for_block()
        End If

        If foundmove Is Nothing Then
            Dim choices As Array = GetAllEmptys()
            Dim randomIndex As Integer = New Random().Next(0, choices.Length)
            cell_click(choices(randomIndex), EventArgs.Empty)
        Else
            cell_click(foundmove, EventArgs.Empty)
        End If
    End Sub

    Private Function GetAllXs() As Array
        Dim sells As New List(Of PictureBox)
        For Each cell In cells
            If cell.Tag = "X" Then
                sells.Add(cell)
            End If
        Next
        Return sells.ToArray
    End Function

    Private Function GetAllEmptys() As Array
        Dim sells As New List(Of PictureBox)
        For Each cell In cells
            If cell.Tag = "" Then
                sells.Add(cell)
            End If
        Next
        Return sells.ToArray
    End Function

    'This function was made by chatgpt
    Function IsLocationInArray(array As Control(,), row As Integer, col As Integer) As Boolean
        ' Returns True if the location (row, col) exists in the two-dimensional array.
        ' Returns False otherwise.
        Dim num_rows As Integer = array.GetLength(0)
        If num_rows = 0 Then
            Return False ' Empty array, so location cannot exist.
        End If
        Dim num_cols As Integer = array.GetLength(1)
        If row < 0 OrElse row >= num_rows OrElse col < 0 OrElse col >= num_cols Then
            Return False ' Out of bounds, so location cannot exist.
        End If
        Return True
    End Function






    Private Function pic_to_coords(picturebox As PictureBox) As Array
        Dim coords(2) As String
        coords = picturebox.Name.Split(",")
        Return coords
    End Function


    Private _current_player_turn As String = "X"
    Public Property current_players_turn As String
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

    Private Sub switch_starting_player()
        If optnO.Checked Then
            optnO.Checked = False
            optnO.CheckState = CheckState.Unchecked
            optnX.Checked = True
            optnX.CheckState = CheckState.Checked
            starting_player = "X"
        ElseIf optnX.Checked Then
            optnX.Checked = False
            optnX.CheckState = CheckState.Unchecked
            optnO.Checked = True
            optnO.CheckState = CheckState.Checked
            starting_player = "O"
        End If
    End Sub

    Private _starting_player As String = "X"
    Property starting_player As String
        Get
            Return _starting_player
        End Get
        Set(value As String)
            _starting_player = value
        End Set
    End Property

    Public Xwins As Integer = 0
    Public Owins As Integer = 0
    Public menuopen As Boolean = False

    Private cells(2, 2) As Control

    Public Sub populate_array()
        menuopen = False
        current_players_turn = starting_player
        lblTurn.Text = current_players_turn & "'s Turn"
        board.Controls.Clear()
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
        If current_mode = "single" AndAlso starting_player = "O" Then
            ComputerDefense()
        End If
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_array()
        titleBar.Renderer = New CustomRenderer2()
    End Sub



    Property current_mode As String
        Get
            If optnSingle.Checked Then
                Return "single"
            ElseIf optnTwo.Checked Then
                Return "two"
            End If
        End Get
        Set(value As String)
            current_mode = current_mode
        End Set
    End Property

    Private Sub switch_player_modes()
        If optnSingle.Checked Then
            optnSingle.Checked = False
            optnSingle.CheckState = CheckState.Unchecked
            optnTwo.Checked = True
            optnTwo.CheckState = CheckState.Checked
        ElseIf optnTwo.Checked Then
            optnSingle.Checked = True
            optnSingle.CheckState = CheckState.Checked
            optnTwo.Checked = False
            optnTwo.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub SinglePlayer_Click(sender As ToolStripMenuItem, e As EventArgs) Handles optnSingle.Click, optnTwo.Click
        If Not sender.Checked Then
            switch_player_modes()
            populate_array()
        End If
    End Sub

    Private Sub optnO_Click(sender As ToolStripMenuItem, e As EventArgs) Handles optnX.Click, optnO.Click
        If Not sender.Checked Then
            switch_starting_player()
            populate_array()
        End If
    End Sub

    '--------------------------------------------------------------------------------'
End Class



#Region "DropDownStyling"
Public Class CustomRenderer
    Inherits ToolStripProfessionalRenderer


    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim myColor As Color = Color.FromArgb(31, 31, 31)
        Dim myBrush As SolidBrush = New SolidBrush(myColor)
        Dim menuItem = TryCast(e.Item, ToolStripMenuItem)
        If menuItem IsNot Nothing Then
            If menuItem.Selected OrElse menuItem.Pressed Then
                ' Set the background color to the desired color when the item is selected or pressed.
                e.Graphics.FillRectangle(myBrush, e.Item.ContentRectangle)
            Else
                ' Set the background color to the default color when the item is not selected or pressed.
                e.Graphics.FillRectangle(myBrush, e.Item.ContentRectangle)
            End If
        End If
    End Sub
End Class

Public Class CustomRenderer2
    Inherits ToolStripProfessionalRenderer
    Dim myColor As Color = Color.FromArgb(31, 31, 31)
    Dim myBrush As SolidBrush = New SolidBrush(myColor)

    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
        MyBase.OnRenderItemText(e)

        Dim menuItem = TryCast(e.Item, ToolStripMenuItem)
        If menuItem IsNot Nothing Then
            e.TextColor = Color.White ' set the text color for the menu item
        End If
    End Sub

    Protected Overrides Sub OnRenderDropDownButtonBackground(e As ToolStripItemRenderEventArgs)
        MyBase.OnRenderDropDownButtonBackground(e)

        Dim menuItem = TryCast(e.Item, ToolStripMenuItem)
        If menuItem IsNot Nothing Then
            ' set the background color for the drop-down button
            e.Graphics.FillRectangle(myBrush, e.Item.ContentRectangle)
        End If
    End Sub
    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        MyBase.OnRenderMenuItemBackground(e)

        Dim menuItem = TryCast(e.Item, ToolStripMenuItem)
        If menuItem IsNot Nothing Then
            If menuItem.Selected OrElse menuItem.Pressed Then
                ' set the background color for the selected or pressed menu item
                e.Graphics.FillRectangle(myBrush, e.Item.ContentRectangle)
            Else
                ' set the default background color for the menu item
                e.Graphics.FillRectangle(myBrush, e.Item.ContentRectangle)
            End If
        End If
    End Sub



End Class

#End Region
