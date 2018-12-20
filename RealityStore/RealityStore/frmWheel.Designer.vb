<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWheel
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
        Me.btnWheel = New System.Windows.Forms.Button()
        Me.lblWheel = New System.Windows.Forms.Label()
        Me.txtWheel = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWheel
        '
        Me.btnWheel.Location = New System.Drawing.Point(251, 44)
        Me.btnWheel.Name = "btnWheel"
        Me.btnWheel.Size = New System.Drawing.Size(104, 75)
        Me.btnWheel.TabIndex = 0
        Me.btnWheel.Text = "Click to Spin!"
        Me.btnWheel.UseVisualStyleBackColor = True
        '
        'lblWheel
        '
        Me.lblWheel.AutoSize = True
        Me.lblWheel.Location = New System.Drawing.Point(198, 169)
        Me.lblWheel.Name = "lblWheel"
        Me.lblWheel.Size = New System.Drawing.Size(50, 13)
        Me.lblWheel.TabIndex = 1
        Me.lblWheel.Text = "Outcome"
        '
        'txtWheel
        '
        Me.txtWheel.Location = New System.Drawing.Point(253, 229)
        Me.txtWheel.Name = "txtWheel"
        Me.txtWheel.ReadOnly = True
        Me.txtWheel.Size = New System.Drawing.Size(100, 20)
        Me.txtWheel.TabIndex = 2
        Me.txtWheel.Text = "$0.00"
        Me.txtWheel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnContinue
        '
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(266, 275)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 3
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmWheel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 310)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtWheel)
        Me.Controls.Add(Me.lblWheel)
        Me.Controls.Add(Me.btnWheel)
        Me.Name = "frmWheel"
        Me.Text = "Wheel of Fortune"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWheel As Button
    Friend WithEvents lblWheel As Label
    Friend WithEvents txtWheel As TextBox
    Friend WithEvents btnContinue As Button
End Class
