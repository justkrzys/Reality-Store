<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClothing
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
        Me.cmbClothes = New System.Windows.Forms.ComboBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.txtClothes = New System.Windows.Forms.TextBox()
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.lblOption2 = New System.Windows.Forms.Label()
        Me.lblOption3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbClothes
        '
        Me.cmbClothes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClothes.FormattingEnabled = True
        Me.cmbClothes.Items.AddRange(New Object() {"Option 1", "Option 2", "Option 3"})
        Me.cmbClothes.Location = New System.Drawing.Point(47, 177)
        Me.cmbClothes.Name = "cmbClothes"
        Me.cmbClothes.Size = New System.Drawing.Size(121, 21)
        Me.cmbClothes.TabIndex = 0
        '
        'btnContinue
        '
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(135, 234)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'txtClothes
        '
        Me.txtClothes.Location = New System.Drawing.Point(197, 177)
        Me.txtClothes.Name = "txtClothes"
        Me.txtClothes.Size = New System.Drawing.Size(100, 20)
        Me.txtClothes.TabIndex = 2
        '
        'lblOption1
        '
        Me.lblOption1.AutoSize = True
        Me.lblOption1.Location = New System.Drawing.Point(46, 28)
        Me.lblOption1.Name = "lblOption1"
        Me.lblOption1.Size = New System.Drawing.Size(50, 13)
        Me.lblOption1.TabIndex = 3
        Me.lblOption1.Text = "Option 1:"
        '
        'lblOption2
        '
        Me.lblOption2.AutoSize = True
        Me.lblOption2.Location = New System.Drawing.Point(150, 28)
        Me.lblOption2.Name = "lblOption2"
        Me.lblOption2.Size = New System.Drawing.Size(50, 13)
        Me.lblOption2.TabIndex = 4
        Me.lblOption2.Text = "Option 2:"
        '
        'lblOption3
        '
        Me.lblOption3.AutoSize = True
        Me.lblOption3.Location = New System.Drawing.Point(240, 28)
        Me.lblOption3.Name = "lblOption3"
        Me.lblOption3.Size = New System.Drawing.Size(50, 13)
        Me.lblOption3.TabIndex = 5
        Me.lblOption3.Text = "Option 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 78)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hollister" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Buckle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Foot Locker" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pink" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abercrombie & Fitch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Banana Republic"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 78)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Champs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Target" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "American Eagle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GAP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "H&M" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zumiez"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 91)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "175" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Old Navy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wal­Mart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Forever 21" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Meijer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Payless" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discovery"
        '
        'frmClothing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 275)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblOption3)
        Me.Controls.Add(Me.lblOption2)
        Me.Controls.Add(Me.lblOption1)
        Me.Controls.Add(Me.txtClothes)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.cmbClothes)
        Me.Name = "frmClothing"
        Me.Text = "Clothing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbClothes As ComboBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents txtClothes As TextBox
    Friend WithEvents lblOption1 As Label
    Friend WithEvents lblOption2 As Label
    Friend WithEvents lblOption3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
