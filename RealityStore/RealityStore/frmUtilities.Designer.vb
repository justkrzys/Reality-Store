<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilities
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
        Me.txtUtilities = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.chkCell = New System.Windows.Forms.CheckBox()
        Me.chkTV = New System.Windows.Forms.CheckBox()
        Me.chkInternet = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtOption = New System.Windows.Forms.TextBox()
        Me.lblHousing = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUtilities
        '
        Me.txtUtilities.Location = New System.Drawing.Point(195, 164)
        Me.txtUtilities.Name = "txtUtilities"
        Me.txtUtilities.ReadOnly = True
        Me.txtUtilities.Size = New System.Drawing.Size(100, 20)
        Me.txtUtilities.TabIndex = 1
        '
        'btnContinue
        '
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(141, 206)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'chkCell
        '
        Me.chkCell.AutoSize = True
        Me.chkCell.Location = New System.Drawing.Point(236, 30)
        Me.chkCell.Name = "chkCell"
        Me.chkCell.Size = New System.Drawing.Size(70, 17)
        Me.chkCell.TabIndex = 3
        Me.chkCell.Text = " Cell: $50"
        Me.chkCell.UseVisualStyleBackColor = True
        '
        'chkTV
        '
        Me.chkTV.AutoSize = True
        Me.chkTV.Location = New System.Drawing.Point(236, 70)
        Me.chkTV.Name = "chkTV"
        Me.chkTV.Size = New System.Drawing.Size(98, 17)
        Me.chkTV.TabIndex = 4
        Me.chkTV.Text = "Television: $35"
        Me.chkTV.UseVisualStyleBackColor = True
        '
        'chkInternet
        '
        Me.chkInternet.AutoSize = True
        Me.chkInternet.Location = New System.Drawing.Point(236, 110)
        Me.chkInternet.Name = "chkInternet"
        Me.chkInternet.Size = New System.Drawing.Size(86, 17)
        Me.chkInternet.TabIndex = 5
        Me.chkInternet.Text = "Internet: $60"
        Me.chkInternet.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(61, 161)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtOption
        '
        Me.txtOption.Location = New System.Drawing.Point(25, 55)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.ReadOnly = True
        Me.txtOption.Size = New System.Drawing.Size(150, 20)
        Me.txtOption.TabIndex = 7
        '
        'lblHousing
        '
        Me.lblHousing.AutoSize = True
        Me.lblHousing.Location = New System.Drawing.Point(22, 30)
        Me.lblHousing.Name = "lblHousing"
        Me.lblHousing.Size = New System.Drawing.Size(49, 13)
        Me.lblHousing.TabIndex = 8
        Me.lblHousing.Text = "Housing:"
        '
        'frmUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 249)
        Me.Controls.Add(Me.lblHousing)
        Me.Controls.Add(Me.txtOption)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkInternet)
        Me.Controls.Add(Me.chkTV)
        Me.Controls.Add(Me.chkCell)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtUtilities)
        Me.Name = "frmUtilities"
        Me.Text = "Utilities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUtilities As TextBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents chkCell As CheckBox
    Friend WithEvents chkTV As CheckBox
    Friend WithEvents chkInternet As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtOption As TextBox
    Friend WithEvents lblHousing As System.Windows.Forms.Label
End Class
