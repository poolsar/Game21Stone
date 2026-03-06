<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelStones = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonTake1 = New System.Windows.Forms.Button()
        Me.ButtonTake2 = New System.Windows.Forms.Button()
        Me.ButtonTake3 = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ListBoxLog = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitle.Location = New System.Drawing.Point(12, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(107, 30)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Камни 21"
        '
        'LabelStones
        '
        Me.LabelStones.AutoSize = True
        Me.LabelStones.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelStones.Location = New System.Drawing.Point(16, 57)
        Me.LabelStones.Name = "LabelStones"
        Me.LabelStones.Size = New System.Drawing.Size(156, 20)
        Me.LabelStones.TabIndex = 1
        Me.LabelStones.Text = "Осталось камней: 21"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(16, 120)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(194, 15)
        Me.LabelStatus.TabIndex = 2
        Me.LabelStatus.Text = "Ваш ход. Возьмите 1-3 камня."
        '
        'ButtonTake1
        '
        Me.ButtonTake1.Location = New System.Drawing.Point(20, 88)
        Me.ButtonTake1.Name = "ButtonTake1"
        Me.ButtonTake1.Size = New System.Drawing.Size(75, 25)
        Me.ButtonTake1.TabIndex = 3
        Me.ButtonTake1.Text = "Взять 1"
        Me.ButtonTake1.UseVisualStyleBackColor = True
        '
        'ButtonTake2
        '
        Me.ButtonTake2.Location = New System.Drawing.Point(101, 88)
        Me.ButtonTake2.Name = "ButtonTake2"
        Me.ButtonTake2.Size = New System.Drawing.Size(75, 25)
        Me.ButtonTake2.TabIndex = 4
        Me.ButtonTake2.Text = "Взять 2"
        Me.ButtonTake2.UseVisualStyleBackColor = True
        '
        'ButtonTake3
        '
        Me.ButtonTake3.Location = New System.Drawing.Point(182, 88)
        Me.ButtonTake3.Name = "ButtonTake3"
        Me.ButtonTake3.Size = New System.Drawing.Size(75, 25)
        Me.ButtonTake3.TabIndex = 5
        Me.ButtonTake3.Text = "Взять 3"
        Me.ButtonTake3.UseVisualStyleBackColor = True
        '
        'ButtonNew
        '
        Me.ButtonNew.Location = New System.Drawing.Point(263, 88)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(100, 25)
        Me.ButtonNew.TabIndex = 6
        Me.ButtonNew.Text = "Новая игра"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ListBoxLog
        '
        Me.ListBoxLog.FormattingEnabled = True
        Me.ListBoxLog.ItemHeight = 15
        Me.ListBoxLog.Location = New System.Drawing.Point(20, 146)
        Me.ListBoxLog.Name = "ListBoxLog"
        Me.ListBoxLog.Size = New System.Drawing.Size(430, 184)
        Me.ListBoxLog.TabIndex = 7
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 336)
        Me.ProgressBar1.Maximum = 21
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(434, 24)
        Me.ProgressBar1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 380)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ListBoxLog)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.ButtonTake3)
        Me.Controls.Add(Me.ButtonTake2)
        Me.Controls.Add(Me.ButtonTake1)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.LabelStones)
        Me.Controls.Add(Me.LabelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Камни 21"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelStones As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ButtonTake1 As Button
    Friend WithEvents ButtonTake2 As Button
    Friend WithEvents ButtonTake3 As Button
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ListBoxLog As ListBox
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
