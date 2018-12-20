<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFood
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
        Me.cmbOption = New System.Windows.Forms.ComboBox()
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.lblOption2 = New System.Windows.Forms.Label()
        Me.lblOption3 = New System.Windows.Forms.Label()
        Me.lblOption1a = New System.Windows.Forms.Label()
        Me.lblOption2a = New System.Windows.Forms.Label()
        Me.lblOption3a = New System.Windows.Forms.Label()
        Me.txtFood = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblOption1b = New System.Windows.Forms.Label()
        Me.lblOption2b = New System.Windows.Forms.Label()
        Me.lblOption3b = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbOption
        '
        Me.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOption.FormattingEnabled = True
        Me.cmbOption.Items.AddRange(New Object() {"Option 1", "Option 2", "Option 3"})
        Me.cmbOption.Location = New System.Drawing.Point(149, 222)
        Me.cmbOption.Name = "cmbOption"
        Me.cmbOption.Size = New System.Drawing.Size(121, 21)
        Me.cmbOption.TabIndex = 0
        '
        'lblOption1
        '
        Me.lblOption1.AutoSize = True
        Me.lblOption1.Location = New System.Drawing.Point(25, 29)
        Me.lblOption1.Name = "lblOption1"
        Me.lblOption1.Size = New System.Drawing.Size(50, 13)
        Me.lblOption1.TabIndex = 1
        Me.lblOption1.Text = "Option 1:"
        '
        'lblOption2
        '
        Me.lblOption2.AutoSize = True
        Me.lblOption2.Location = New System.Drawing.Point(186, 29)
        Me.lblOption2.Name = "lblOption2"
        Me.lblOption2.Size = New System.Drawing.Size(50, 13)
        Me.lblOption2.TabIndex = 2
        Me.lblOption2.Text = "Option 2:"
        '
        'lblOption3
        '
        Me.lblOption3.AutoSize = True
        Me.lblOption3.Location = New System.Drawing.Point(358, 29)
        Me.lblOption3.Name = "lblOption3"
        Me.lblOption3.Size = New System.Drawing.Size(50, 13)
        Me.lblOption3.TabIndex = 3
        Me.lblOption3.Text = "Option 3:"
        '
        'lblOption1a
        '
        Me.lblOption1a.AutoSize = True
        Me.lblOption1a.Location = New System.Drawing.Point(25, 59)
        Me.lblOption1a.Name = "lblOption1a"
        Me.lblOption1a.Size = New System.Drawing.Size(70, 117)
        Me.lblOption1a.TabIndex = 4
        Me.lblOption1a.Text = "Whole Foods" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mariano’s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trader Joe’s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Red Lobster" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Giordanos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Benihanas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PF Chang" &
    "s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Starbucks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Capital Grill"
        '
        'lblOption2a
        '
        Me.lblOption2a.AutoSize = True
        Me.lblOption2a.Location = New System.Drawing.Point(186, 59)
        Me.lblOption2a.Name = "lblOption2a"
        Me.lblOption2a.Size = New System.Drawing.Size(81, 117)
        Me.lblOption2a.TabIndex = 5
        Me.lblOption2a.Text = "Jewel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Berkots" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Meijer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chili’s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Olive Garden" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chipotle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Panda Express" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aurelio’s" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dunkin’ Donuts"
        '
        'lblOption3a
        '
        Me.lblOption3a.AutoSize = True
        Me.lblOption3a.Location = New System.Drawing.Point(358, 59)
        Me.lblOption3a.Name = "lblOption3a"
        Me.lblOption3a.Size = New System.Drawing.Size(65, 91)
        Me.lblOption3a.TabIndex = 6
        Me.lblOption3a.Text = "Aldi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WalMart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Food 4 Less" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "McDonald’s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Taco Bell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Subway" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pizza Hut"
        '
        'txtFood
        '
        Me.txtFood.Location = New System.Drawing.Point(288, 222)
        Me.txtFood.Name = "txtFood"
        Me.txtFood.Size = New System.Drawing.Size(100, 20)
        Me.txtFood.TabIndex = 7
        '
        'btnContinue
        '
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(231, 300)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 8
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblOption1b
        '
        Me.lblOption1b.AutoSize = True
        Me.lblOption1b.Location = New System.Drawing.Point(113, 59)
        Me.lblOption1b.Name = "lblOption1b"
        Me.lblOption1b.Size = New System.Drawing.Size(55, 78)
        Me.lblOption1b.TabIndex = 9
        Me.lblOption1b.Text = "Groceries," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "personal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "care and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eating out" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "once a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "week"
        '
        'lblOption2b
        '
        Me.lblOption2b.AutoSize = True
        Me.lblOption2b.Location = New System.Drawing.Point(285, 59)
        Me.lblOption2b.Name = "lblOption2b"
        Me.lblOption2b.Size = New System.Drawing.Size(55, 78)
        Me.lblOption2b.TabIndex = 10
        Me.lblOption2b.Text = "Groceries," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "personal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "care and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eating out" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "once a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "week"
        '
        'lblOption3b
        '
        Me.lblOption3b.AutoSize = True
        Me.lblOption3b.Location = New System.Drawing.Point(441, 59)
        Me.lblOption3b.Name = "lblOption3b"
        Me.lblOption3b.Size = New System.Drawing.Size(58, 52)
        Me.lblOption3b.TabIndex = 11
        Me.lblOption3b.Text = "Groceris" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and eating" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "out once a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "week"
        '
        'frmFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 335)
        Me.Controls.Add(Me.lblOption3b)
        Me.Controls.Add(Me.lblOption2b)
        Me.Controls.Add(Me.lblOption1b)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtFood)
        Me.Controls.Add(Me.lblOption3a)
        Me.Controls.Add(Me.lblOption2a)
        Me.Controls.Add(Me.lblOption1a)
        Me.Controls.Add(Me.lblOption3)
        Me.Controls.Add(Me.lblOption2)
        Me.Controls.Add(Me.lblOption1)
        Me.Controls.Add(Me.cmbOption)
        Me.Name = "frmFood"
        Me.Text = "Groceries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbOption As ComboBox
    Friend WithEvents lblOption1 As Label
    Friend WithEvents lblOption2 As Label
    Friend WithEvents lblOption3 As Label
    Friend WithEvents lblOption1a As Label
    Friend WithEvents lblOption2a As Label
    Friend WithEvents lblOption3a As Label
    Friend WithEvents txtFood As TextBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblOption1b As Label
    Friend WithEvents lblOption2b As Label
    Friend WithEvents lblOption3b As Label
End Class
