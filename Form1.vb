Public Class Form1

    Dim stones As Integer
    Dim turnPlayer As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        NewGame()
    End Sub

    Private Sub NewGame()
        stones = 21
        turnPlayer = True

        ListBoxLog.Items.Clear()
        SetPlayerButtonsEnabled(True)
        ButtonNew.Enabled = True

        LabelStatus.Text = "Ваш ход. Возьмите 1-3 камня."
        UpdateGameView()
    End Sub

    Private Sub UpdateGameView()
        LabelStones.Text = "Осталось камней: " & stones
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 21
        ProgressBar1.Value = stones
    End Sub

    Private Sub SetPlayerButtonsEnabled(enabled As Boolean)
        ButtonTake1.Enabled = enabled
        ButtonTake2.Enabled = enabled
        ButtonTake3.Enabled = enabled
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        NewGame()
    End Sub

    Private Sub ButtonTake1_Click(sender As Object, e As EventArgs) Handles ButtonTake1.Click
        PlayerTake(1)
    End Sub

    Private Sub ButtonTake2_Click(sender As Object, e As EventArgs) Handles ButtonTake2.Click
        PlayerTake(2)
    End Sub

    Private Sub ButtonTake3_Click(sender As Object, e As EventArgs) Handles ButtonTake3.Click
        PlayerTake(3)
    End Sub

    Private Sub PlayerTake(take As Integer)
        If Not turnPlayer Then
            Return
        End If

        If take < 1 OrElse take > 3 OrElse take > stones Then
            LabelStatus.Text = "Неверный ход. Нельзя взять больше оставшихся камней."
            Return
        End If

        stones -= take
        ListBoxLog.Items.Add("Игрок взял: " & take & ", осталось: " & stones)
        UpdateGameView()

        If stones = 0 Then
            EndGame("Вы выиграли")
            Return
        End If

        turnPlayer = False
        LabelStatus.Text = "Ход компьютера..."
        ComputerTurn()
    End Sub

    Private Sub ComputerTurn()
        Dim take As Integer = (stones - 1) Mod 4

        If take < 1 OrElse take > 3 Then
            take = CInt(Int(Rnd() * 3)) + 1
        End If

        While take < 1 OrElse take > 3 OrElse take > stones
            take = CInt(Int(Rnd() * 3)) + 1
        End While

        stones -= take
        ListBoxLog.Items.Add("Компьютер взял: " & take & ", осталось: " & stones)
        UpdateGameView()

        If stones = 0 Then
            EndGame("Вы проиграли")
            Return
        End If

        turnPlayer = True
        LabelStatus.Text = "Ваш ход. Возьмите 1-3 камня."
    End Sub

    Private Sub EndGame(message As String)
        LabelStatus.Text = message
        SetPlayerButtonsEnabled(False)
        turnPlayer = False
    End Sub

End Class
