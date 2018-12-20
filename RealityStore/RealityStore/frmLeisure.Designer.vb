<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeisure
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
        Me.cmbVacation = New System.Windows.Forms.ComboBox()
        Me.cmbMovies = New System.Windows.Forms.ComboBox()
        Me.cmbSports = New System.Windows.Forms.ComboBox()
        Me.cmbGym = New System.Windows.Forms.ComboBox()
        Me.cmbConcert = New System.Windows.Forms.ComboBox()
        Me.lblVacation = New System.Windows.Forms.Label()
        Me.lblMovies = New System.Windows.Forms.Label()
        Me.lblSports = New System.Windows.Forms.Label()
        Me.lblGym = New System.Windows.Forms.Label()
        Me.lblConcert = New System.Windows.Forms.Label()
        Me.lblLeisure = New System.Windows.Forms.Label()
        Me.txtVacation = New System.Windows.Forms.TextBox()
        Me.txtMovie = New System.Windows.Forms.TextBox()
        Me.txtSport = New System.Windows.Forms.TextBox()
        Me.txtGym = New System.Windows.Forms.TextBox()
        Me.txtConcert = New System.Windows.Forms.TextBox()
        Me.txtLeisure = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbVacation
        '
        Me.cmbVacation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVacation.FormattingEnabled = True
        Me.cmbVacation.Items.AddRange(New Object() {"7 day vacation", "Weekend Getaway", "Overnight Getaway", "None"})
        Me.cmbVacation.Location = New System.Drawing.Point(73, 24)
        Me.cmbVacation.Name = "cmbVacation"
        Me.cmbVacation.Size = New System.Drawing.Size(255, 21)
        Me.cmbVacation.TabIndex = 0
        '
        'cmbMovies
        '
        Me.cmbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMovies.FormattingEnabled = True
        Me.cmbMovies.Items.AddRange(New Object() {"I - pic movie / IMAX", "Movie Theater", "Rent movies", "None"})
        Me.cmbMovies.Location = New System.Drawing.Point(73, 64)
        Me.cmbMovies.Name = "cmbMovies"
        Me.cmbMovies.Size = New System.Drawing.Size(255, 21)
        Me.cmbMovies.TabIndex = 1
        '
        'cmbSports
        '
        Me.cmbSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSports.FormattingEnabled = True
        Me.cmbSports.Items.AddRange(New Object() {"Baseball game premium seats", "Baseball game general seats", "Baseball game  upper deck seats", "None"})
        Me.cmbSports.Location = New System.Drawing.Point(73, 104)
        Me.cmbSports.Name = "cmbSports"
        Me.cmbSports.Size = New System.Drawing.Size(255, 21)
        Me.cmbSports.TabIndex = 2
        '
        'cmbGym
        '
        Me.cmbGym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGym.FormattingEnabled = True
        Me.cmbGym.Items.AddRange(New Object() {"Lifetime Fitness", "LA Fitness (includes classes)", "Cardinal Fitness", "None"})
        Me.cmbGym.Location = New System.Drawing.Point(73, 144)
        Me.cmbGym.Name = "cmbGym"
        Me.cmbGym.Size = New System.Drawing.Size(255, 21)
        Me.cmbGym.TabIndex = 3
        '
        'cmbConcert
        '
        Me.cmbConcert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConcert.FormattingEnabled = True
        Me.cmbConcert.Items.AddRange(New Object() {"Front row/pit", "Reserved seating", "Lawn seat", "None"})
        Me.cmbConcert.Location = New System.Drawing.Point(73, 184)
        Me.cmbConcert.Name = "cmbConcert"
        Me.cmbConcert.Size = New System.Drawing.Size(255, 21)
        Me.cmbConcert.TabIndex = 4
        '
        'lblVacation
        '
        Me.lblVacation.AutoSize = True
        Me.lblVacation.Location = New System.Drawing.Point(16, 28)
        Me.lblVacation.Name = "lblVacation"
        Me.lblVacation.Size = New System.Drawing.Size(52, 13)
        Me.lblVacation.TabIndex = 5
        Me.lblVacation.Text = "Vacation:"
        '
        'lblMovies
        '
        Me.lblMovies.AutoSize = True
        Me.lblMovies.Location = New System.Drawing.Point(24, 68)
        Me.lblMovies.Name = "lblMovies"
        Me.lblMovies.Size = New System.Drawing.Size(44, 13)
        Me.lblMovies.TabIndex = 6
        Me.lblMovies.Text = "Movies:"
        '
        'lblSports
        '
        Me.lblSports.AutoSize = True
        Me.lblSports.Location = New System.Drawing.Point(28, 108)
        Me.lblSports.Name = "lblSports"
        Me.lblSports.Size = New System.Drawing.Size(40, 13)
        Me.lblSports.TabIndex = 7
        Me.lblSports.Text = "Sports:"
        '
        'lblGym
        '
        Me.lblGym.AutoSize = True
        Me.lblGym.Location = New System.Drawing.Point(37, 148)
        Me.lblGym.Name = "lblGym"
        Me.lblGym.Size = New System.Drawing.Size(31, 13)
        Me.lblGym.TabIndex = 8
        Me.lblGym.Text = "Gym:"
        '
        'lblConcert
        '
        Me.lblConcert.AutoSize = True
        Me.lblConcert.Location = New System.Drawing.Point(21, 188)
        Me.lblConcert.Name = "lblConcert"
        Me.lblConcert.Size = New System.Drawing.Size(47, 13)
        Me.lblConcert.TabIndex = 9
        Me.lblConcert.Text = "Concert:"
        '
        'lblLeisure
        '
        Me.lblLeisure.AutoSize = True
        Me.lblLeisure.Location = New System.Drawing.Point(103, 235)
        Me.lblLeisure.Name = "lblLeisure"
        Me.lblLeisure.Size = New System.Drawing.Size(34, 13)
        Me.lblLeisure.TabIndex = 10
        Me.lblLeisure.Text = "Total:"
        '
        'txtVacation
        '
        Me.txtVacation.Location = New System.Drawing.Point(334, 24)
        Me.txtVacation.Name = "txtVacation"
        Me.txtVacation.ReadOnly = True
        Me.txtVacation.Size = New System.Drawing.Size(100, 20)
        Me.txtVacation.TabIndex = 11
        '
        'txtMovie
        '
        Me.txtMovie.Location = New System.Drawing.Point(334, 64)
        Me.txtMovie.Name = "txtMovie"
        Me.txtMovie.ReadOnly = True
        Me.txtMovie.Size = New System.Drawing.Size(100, 20)
        Me.txtMovie.TabIndex = 12
        '
        'txtSport
        '
        Me.txtSport.Location = New System.Drawing.Point(334, 104)
        Me.txtSport.Name = "txtSport"
        Me.txtSport.ReadOnly = True
        Me.txtSport.Size = New System.Drawing.Size(100, 20)
        Me.txtSport.TabIndex = 13
        '
        'txtGym
        '
        Me.txtGym.Location = New System.Drawing.Point(334, 144)
        Me.txtGym.Name = "txtGym"
        Me.txtGym.ReadOnly = True
        Me.txtGym.Size = New System.Drawing.Size(100, 20)
        Me.txtGym.TabIndex = 14
        '
        'txtConcert
        '
        Me.txtConcert.Location = New System.Drawing.Point(334, 184)
        Me.txtConcert.Name = "txtConcert"
        Me.txtConcert.ReadOnly = True
        Me.txtConcert.Size = New System.Drawing.Size(100, 20)
        Me.txtConcert.TabIndex = 15
        '
        'txtLeisure
        '
        Me.txtLeisure.Location = New System.Drawing.Point(143, 231)
        Me.txtLeisure.Name = "txtLeisure"
        Me.txtLeisure.ReadOnly = True
        Me.txtLeisure.Size = New System.Drawing.Size(100, 20)
        Me.txtLeisure.TabIndex = 16
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(273, 230)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 17
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmLeisure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 263)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtLeisure)
        Me.Controls.Add(Me.txtConcert)
        Me.Controls.Add(Me.txtGym)
        Me.Controls.Add(Me.txtSport)
        Me.Controls.Add(Me.txtMovie)
        Me.Controls.Add(Me.txtVacation)
        Me.Controls.Add(Me.lblLeisure)
        Me.Controls.Add(Me.lblConcert)
        Me.Controls.Add(Me.lblGym)
        Me.Controls.Add(Me.lblSports)
        Me.Controls.Add(Me.lblMovies)
        Me.Controls.Add(Me.lblVacation)
        Me.Controls.Add(Me.cmbConcert)
        Me.Controls.Add(Me.cmbGym)
        Me.Controls.Add(Me.cmbSports)
        Me.Controls.Add(Me.cmbMovies)
        Me.Controls.Add(Me.cmbVacation)
        Me.Name = "frmLeisure"
        Me.Text = "Recreation and Leisure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbVacation As ComboBox
    Friend WithEvents cmbMovies As ComboBox
    Friend WithEvents cmbSports As ComboBox
    Friend WithEvents cmbGym As ComboBox
    Friend WithEvents cmbConcert As ComboBox
    Friend WithEvents lblVacation As Label
    Friend WithEvents lblMovies As Label
    Friend WithEvents lblSports As Label
    Friend WithEvents lblGym As Label
    Friend WithEvents lblConcert As Label
    Friend WithEvents lblLeisure As Label
    Friend WithEvents txtVacation As TextBox
    Friend WithEvents txtMovie As TextBox
    Friend WithEvents txtSport As TextBox
    Friend WithEvents txtGym As TextBox
    Friend WithEvents txtConcert As TextBox
    Friend WithEvents txtLeisure As TextBox
    Friend WithEvents btnContinue As Button
End Class
