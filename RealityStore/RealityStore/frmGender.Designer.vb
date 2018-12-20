<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGender
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
        Me.btnMale = New System.Windows.Forms.Button()
        Me.btnFemale = New System.Windows.Forms.Button()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMale
        '
        Me.btnMale.Location = New System.Drawing.Point(40, 96)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(75, 23)
        Me.btnMale.TabIndex = 0
        Me.btnMale.Text = "Male"
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnFemale
        '
        Me.btnFemale.Location = New System.Drawing.Point(170, 96)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(75, 23)
        Me.btnFemale.TabIndex = 1
        Me.btnFemale.Text = "Female"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(103, 42)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(79, 13)
        Me.lblGender.TabIndex = 2
        Me.lblGender.Text = "Select your sex"
        '
        'frmGender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 136)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.btnMale)
        Me.Name = "frmGender"
        Me.Text = "frmGender"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMale As System.Windows.Forms.Button
    Friend WithEvents btnFemale As System.Windows.Forms.Button
    Friend WithEvents lblGender As System.Windows.Forms.Label
End Class
