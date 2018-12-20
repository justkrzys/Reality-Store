<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnding
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
        Me.lblEnding = New System.Windows.Forms.Label()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnding
        '
        Me.lblEnding.AutoSize = True
        Me.lblEnding.Location = New System.Drawing.Point(74, 78)
        Me.lblEnding.Name = "lblEnding"
        Me.lblEnding.Size = New System.Drawing.Size(50, 13)
        Me.lblEnding.TabIndex = 0
        Me.lblEnding.Text = "Outcome"
        '
        'btnRetry
        '
        Me.btnRetry.Location = New System.Drawing.Point(218, 203)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(75, 23)
        Me.btnRetry.TabIndex = 1
        Me.btnRetry.Text = "Retry"
        Me.btnRetry.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(364, 203)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmEnding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 262)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.lblEnding)
        Me.Name = "frmEnding"
        Me.Text = "Ending"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnding As System.Windows.Forms.Label
    Friend WithEvents btnRetry As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
End Class
