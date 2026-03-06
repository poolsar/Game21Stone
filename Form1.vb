Public Class Form1

    Dim stones As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        stones = 21
        NewGame()
    End Sub

    Private Sub NewGame()
        stones = 21

        ListBoxLog.Items.Clear()

        ButtonTake1.Enabled = True
        ButtonTake2.Enabled = True
        ButtonTake3.Enabled = True

        LabelStatus.Text = "Ваш ход. Возьмите 1-3 камня."
        LabelStones.Text = "Осталось камней: " & stones

        ShowStones()
    End Sub

    Private Sub ShowStones()
        Stone1.Visible = False
        Stone2.Visible = False
        Stone3.Visible = False
        Stone4.Visible = False
        Stone5.Visible = False
        Stone6.Visible = False
        Stone7.Visible = False
        Stone8.Visible = False
        Stone9.Visible = False
        Stone10.Visible = False
        Stone11.Visible = False
        Stone12.Visible = False
        Stone13.Visible = False
        Stone14.Visible = False
        Stone15.Visible = False
        Stone16.Visible = False
        Stone17.Visible = False
        Stone18.Visible = False
        Stone19.Visible = False
        Stone20.Visible = False
        Stone21.Visible = False

        If stones >= 1 Then Stone1.Visible = True
        If stones >= 2 Then Stone2.Visible = True
        If stones >= 3 Then Stone3.Visible = True
        If stones >= 4 Then Stone4.Visible = True
        If stones >= 5 Then Stone5.Visible = True
        If stones >= 6 Then Stone6.Visible = True
        If stones >= 7 Then Stone7.Visible = True
        If stones >= 8 Then Stone8.Visible = True
        If stones >= 9 Then Stone9.Visible = True
        If stones >= 10 Then Stone10.Visible = True
        If stones >= 11 Then Stone11.Visible = True
        If stones >= 12 Then Stone12.Visible = True
        If stones >= 13 Then Stone13.Visible = True
        If stones >= 14 Then Stone14.Visible = True
        If stones >= 15 Then Stone15.Visible = True
        If stones >= 16 Then Stone16.Visible = True
        If stones >= 17 Then Stone17.Visible = True
        If stones >= 18 Then Stone18.Visible = True
        If stones >= 19 Then Stone19.Visible = True
        If stones >= 20 Then Stone20.Visible = True
        If stones >= 21 Then Stone21.Visible = True
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        NewGame()
    End Sub

    Private Sub ButtonTake1_Click(sender As Object, e As EventArgs) Handles ButtonTake1.Click
        If stones < 1 Then
            LabelStatus.Text = "Нельзя взять столько."
            Exit Sub
        End If

        stones = stones - 1
        ListBoxLog.Items.Add("Игрок взял: 1, осталось: " & stones)
        LabelStones.Text = "Осталось камней: " & stones
        ShowStones()

        If stones = 0 Then
            LabelStatus.Text = "Вы проиграли. Вы взяли последний камень."
            ButtonTake1.Enabled = False
            ButtonTake2.Enabled = False
            ButtonTake3.Enabled = False
            Exit Sub
        End If

        ComputerTurn()
    End Sub

    Private Sub ButtonTake2_Click(sender As Object, e As EventArgs) Handles ButtonTake2.Click
        If stones < 2 Then
            LabelStatus.Text = "Нельзя взять столько."
            Exit Sub
        End If

        stones = stones - 2
        ListBoxLog.Items.Add("Игрок взял: 2, осталось: " & stones)
        LabelStones.Text = "Осталось камней: " & stones
        ShowStones()

        If stones = 0 Then
            LabelStatus.Text = "Вы проиграли. Вы взяли последний камень."
            ButtonTake1.Enabled = False
            ButtonTake2.Enabled = False
            ButtonTake3.Enabled = False
            Exit Sub
        End If

        ComputerTurn()
    End Sub

    Private Sub ButtonTake3_Click(sender As Object, e As EventArgs) Handles ButtonTake3.Click
        If stones < 3 Then
            LabelStatus.Text = "Нельзя взять столько."
            Exit Sub
        End If

        stones = stones - 3
        ListBoxLog.Items.Add("Игрок взял: 3, осталось: " & stones)
        LabelStones.Text = "Осталось камней: " & stones
        ShowStones()

        If stones = 0 Then
            LabelStatus.Text = "Вы проиграли. Вы взяли последний камень."
            ButtonTake1.Enabled = False
            ButtonTake2.Enabled = False
            ButtonTake3.Enabled = False
            Exit Sub
        End If

        ComputerTurn()
    End Sub

    Private Sub ComputerTurn()
        Dim take As Integer

        LabelStatus.Text = "Ход компьютера..."

        take = Int(Rnd() * 3) + 1

        While take > stones
            take = Int(Rnd() * 3) + 1
        End While

        stones = stones - take
        ListBoxLog.Items.Add("Компьютер взял: " & take & ", осталось: " & stones)
        LabelStones.Text = "Осталось камней: " & stones
        ShowStones()

        If stones = 0 Then
            LabelStatus.Text = "Вы выиграли. Компьютер взял последний камень."
            ButtonTake1.Enabled = False
            ButtonTake2.Enabled = False
            ButtonTake3.Enabled = False
            Exit Sub
        End If

        LabelStatus.Text = "Ваш ход. Возьмите 1-3 камня."
    End Sub

End Class