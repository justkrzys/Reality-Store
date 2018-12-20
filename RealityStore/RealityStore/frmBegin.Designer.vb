<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBegin
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(77, 111)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(151, 55)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Reaity Store"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(18, 41)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(272, 20)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to the Reality Store!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Click ""Start Reality Store"" to begin"
        '
        'frmBegin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(308, 208)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnStart)
        Me.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmBegin"
        Me.Text = "Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
