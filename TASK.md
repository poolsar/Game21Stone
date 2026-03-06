# TASK.md

## Task

Modify the existing **VB.NET WinForms** implementation of the game **"Камни 21"** so that the application shows a **visual pile of stones** instead of relying only on a horizontal `ProgressBar`.

The goal is to keep the project **simple enough for a beginner programming exercise**, while making the interface look more like an actual stack or pile of stones.

Do **not** redesign the whole application. This is a **modification of the current implementation**, not a new project.

---

## Current project context

The project already contains:

- `Form1`
- game state variables:
  - `stones As Integer`
  - `turnPlayer As Boolean`
- buttons:
  - `ButtonTake1`
  - `ButtonTake2`
  - `ButtonTake3`
  - `ButtonNew`
- labels:
  - `LabelStones`
  - `LabelStatus`
- move log:
  - `ListBoxLog`
- current visual indicator:
  - `ProgressBar1`

The existing game logic is already mostly implemented and should be **preserved**.

---

## Main modification goal

Replace or supplement the current progress display with a **simple visual pile of 21 stones**.

The easiest acceptable implementation is:

- create **21 small controls** that represent stones
- arrange them on the form in rows so they look like a pile
- when stones are removed, some of these controls become hidden

This must be simple and easy to understand for beginner students.

---

## Required implementation approach

### 1. Add 21 visual stone controls to the form

Use one of these options:

#### Preferred option
Use **21 Label controls**

or

#### Also acceptable
Use **21 PictureBox controls**

For simplicity, prefer **Label controls** unless the project already uses images.

---

## Control naming

The stone controls must be named exactly:

- `Stone1`
- `Stone2`
- `Stone3`
- `Stone4`
- `Stone5`
- `Stone6`
- `Stone7`
- `Stone8`
- `Stone9`
- `Stone10`
- `Stone11`
- `Stone12`
- `Stone13`
- `Stone14`
- `Stone15`
- `Stone16`
- `Stone17`
- `Stone18`
- `Stone19`
- `Stone20`
- `Stone21`

These controls should be placed manually on the form in a stacked arrangement.

---

## Suggested layout of the stone pile

Arrange the stone controls approximately like this:

```text
                Stone21

            Stone19 Stone20

         Stone16 Stone17 Stone18

      Stone12 Stone13 Stone14 Stone15

   Stone7 Stone8 Stone9 Stone10 Stone11

Stone1 Stone2 Stone3 Stone4 Stone5 Stone6
```

This creates a simple triangular pile with 21 stones total.

The exact pixel positions do not need to be perfect, but the result should visually resemble a pile.

---

## Visual style of stone controls

If using `Label` controls:

- set a small fixed size, for example around `30x20` or `32x24`
- `BackColor = Color.Silver` or `Color.Gray`
- `BorderStyle = FixedSingle`
- `Text = ""`

Optional simple improvements:
- slightly different sizes are acceptable
- place them inside a panel, for example `PanelStones`, if convenient
- use a title label like `Куча камней`

Do not add complex custom drawing, animations, or graphics libraries.

---

## 2. Add an array for stone controls

In `Form1`, add a new field:

```vbnet
Dim stoneViews() As Control
```

This array will store references to all 21 stone controls.

---

## 3. Initialize the array in Form1_Load

In `Form1_Load`, after `Randomize()`, assign all stone controls to the array.

Use this exact structure:

```vbnet
stoneViews = New Control() {
    Stone1, Stone2, Stone3, Stone4, Stone5, Stone6,
    Stone7, Stone8, Stone9, Stone10, Stone11,
    Stone12, Stone13, Stone14, Stone15,
    Stone16, Stone17, Stone18,
    Stone19, Stone20,
    Stone21
}
```

Keep the order exactly like this so the visual pile disappears from top to bottom when stones are removed.

---

## 4. Modify UpdateGameView()

Update the existing `UpdateGameView()` procedure so it not only updates `LabelStones` and `ProgressBar1`, but also shows or hides stone controls.

Required behavior:

- if there are 21 stones, all stone controls are visible
- if there are 20 stones, one stone is hidden
- if there are 10 stones, only 10 stones are visible
- if there are 0 stones, all stone controls are hidden

Use a simple `For` loop.

Recommended implementation:

```vbnet
Private Sub UpdateGameView()
    LabelStones.Text = "Осталось камней: " & stones

    ProgressBar1.Minimum = 0
    ProgressBar1.Maximum = 21
    ProgressBar1.Value = stones

    Dim i As Integer
    For i = 0 To stoneViews.Length - 1
        If i < stones Then
            stoneViews(i).Visible = True
        Else
            stoneViews(i).Visible = False
        End If
    Next
End Sub
```

This is simple and suitable for a beginner project.

---

## 5. Keep ProgressBar1 or remove it

Two acceptable variants are allowed:

### Variant A, keep ProgressBar1
- keep the current progress bar
- also add the visual stone pile
- this is the easiest and safest option

### Variant B, remove ProgressBar1 from the visual interface
- if removed from the form, also remove or adjust the code in `UpdateGameView()`

Preferred option: **keep ProgressBar1** and add the stone pile in addition to it.

---

## 6. Preserve the existing game logic

Do not rewrite the whole program.

Keep:
- `NewGame()`
- `SetPlayerButtonsEnabled()`
- `PlayerTake()`
- `ComputerTurn()`
- `EndGame()`

Only make the minimum required changes to support the visual pile and fix obvious logic mistakes.

---

## 7. Fix the game-ending messages

The rules of this game say:

- the player who takes the **last stone loses**

That means the current implementation has the win/lose result reversed.

Fix it as follows:

### In PlayerTake()
After the player removes stones:

```vbnet
If stones = 0 Then
    EndGame("Вы проиграли. Вы взяли последний камень.")
    Return
End If
```

### In ComputerTurn()
After the computer removes stones:

```vbnet
If stones = 0 Then
    EndGame("Вы выиграли. Компьютер взял последний камень.")
    Return
End If
```

This correction is required.

---

## 8. Keep the code beginner-friendly

Important constraints:

- keep code simple
- do not use inheritance or custom controls
- do not use advanced drawing with `Graphics`
- do not use animation
- do not introduce extra classes
- do not use collections if an array is enough
- do not replace the current structure with a more advanced architecture

The code should remain understandable for students learning basic programming and WinForms.

---

## 9. Expected final behavior

After modification, the application should:

1. start with 21 visible stones
2. reduce the visible pile after each move
3. still show remaining stone count in `LabelStones`
4. allow the player to take 1, 2, or 3 stones using the existing buttons
5. log moves in `ListBoxLog`
6. correctly detect win/lose according to the rule:
   - whoever takes the last stone loses
7. reset everything correctly when `ButtonNew` is pressed

---

## 10. Deliverables

Produce the modified code for `Form1.vb` and describe any required designer changes.

At minimum, the implementation must include:

- new field:
  - `Dim stoneViews() As Control`
- initialization of `stoneViews` in `Form1_Load`
- updated `UpdateGameView()`
- corrected end-game messages
- instructions or code assumptions for adding `Stone1` through `Stone21` controls in the designer

---

## 11. Important note for implementation

If the code generator cannot modify the WinForms designer automatically, it should still:

- update `Form1.vb`
- clearly state that the designer must contain controls named `Stone1` through `Stone21`

The code should assume those controls exist.

---

## Summary

Modify the existing WinForms game so that it visually displays a pile of 21 stones using 21 simple controls that are shown and hidden based on the number of stones left. Keep the code easy for beginners, preserve the current structure, and fix the incorrect win/lose logic.
