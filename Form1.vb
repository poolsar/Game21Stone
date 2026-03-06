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
        TextBoxTake.Text = ""
        TextBoxTake.Enabled = True
        ButtonTake.Enabled = True
        ButtonNew.Enabled = True

        LabelStatus.Text = "Ваш ход. Возьмите 1-3 камня."
        UpdateGameView()
        TextBoxTake.Focus()
    End Sub

    Private Sub UpdateGameView()
        LabelStones.Text = "Осталось камней: " & stones
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 21
        ProgressBar1.Value = stones
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        NewGame()
    End Sub

    Private Sub ButtonTake_Click(sender As Object, e As EventArgs) Handles ButtonTake.Click
        If Not turnPlayer Then
            Return
        End If

        Dim inputText As String = TextBoxTake.Text
        Dim take As Integer
        Dim valid As Boolean = False

        ' While loop for player input validation.
        While Not valid
            If Integer.TryParse(inputText, take) Then
                If take >= 1 AndAlso take <= 3 AndAlso take <= stones Then
                    valid = True
                End If
            End If

            If Not valid Then
                LabelStatus.Text = "Неверный ввод. Введите число от 1 до 3 (не больше остатка)."
                inputText = InputBox("Введите число от 1 до 3 (и не больше остатка камней).", "Камни 21", inputText)
                If inputText = "" Then
                    TextBoxTake.Focus()
                    TextBoxTake.SelectAll()
                    Exit Sub
                End If
                TextBoxTake.Text = inputText
            End If
        End While

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

        ' While loop for computer move validation.
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
        TextBoxTake.Text = ""
        TextBoxTake.Focus()
    End Sub

    Private Sub EndGame(message As String)
        LabelStatus.Text = message
        ButtonTake.Enabled = False
        TextBoxTake.Enabled = False
        turnPlayer = False
    End Sub

End Class
