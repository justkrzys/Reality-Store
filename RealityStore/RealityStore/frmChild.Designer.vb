<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChild
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
        Me.cmbChildcare = New System.Windows.Forms.ComboBox()
        Me.txtChildcare = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbChildcare
        '
        Me.cmbChildcare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChildcare.FormattingEnabled = True
        Me.cmbChildcare.Items.AddRange(New Object() {"Daycare", "Family/Friend", "One Parent Not Working"})
        Me.cmbChildcare.Location = New System.Drawing.Point(26, 16)
        Me.cmbChildcare.Name = "cmbChildcare"
        Me.cmbChildcare.Size = New System.Drawing.Size(179, 21)
        Me.cmbChildcare.TabIndex = 0
        '
        'txtChildcare
        '
        Me.txtChildcare.Location = New System.Drawing.Point(65, 64)
        Me.txtChildcare.Name = "txtChildcare"
        Me.txtChildcare.ReadOnly = True
        Me.txtChildcare.Size = New System.Drawing.Size(100, 20)
        Me.txtChildcare.TabIndex = 1
        '
        'btnContinue
        '
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(78, 114)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 149)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtChildcare)
        Me.Controls.Add(Me.cmbChildcare)
        Me.Name = "frmChild"
        Me.Text = "Childcare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbChildcare As ComboBox
    Friend WithEvents txtChildcare As TextBox
    Friend WithEvents btnContinue As Button
End Class
