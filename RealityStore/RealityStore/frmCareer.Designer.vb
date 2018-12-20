<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCareer
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
        Me.cmbCareer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMonthlyIncome = New System.Windows.Forms.Label()
        Me.txtYearlySalary = New System.Windows.Forms.TextBox()
        Me.txtMonthlySalaries = New System.Windows.Forms.TextBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblNetSalary = New System.Windows.Forms.Label()
        Me.txtNetMonthly = New System.Windows.Forms.TextBox()
        Me.txtNetSalary = New System.Windows.Forms.TextBox()
        Me.lblNetMonthly = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbCareer
        '
        Me.cmbCareer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCareer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCareer.FormattingEnabled = True
        Me.cmbCareer.Items.AddRange(New Object() {"AC, Heating & Cooling Technicians", "Accountant & Auditors", "Actors", "Actuary", "Addictions Counselors", "Adult & Vocational Teachers/Career Counselor", "Advertising, Marketing, Sales", "Aerospace Engineer", "Air Traffic Controller (Trainee)", "Animal Caretakers", "Archaeologist / Paleontologist", "Architect", "Associate Professor/Professor", "Athletic Trainer", "Automotive Body Repair", "Automotive Service Technicians/Mechanic", "Bank Teller", "Barbers, Stylists, Cosmetologists", "Bartender", "Biochemists", "Biologists", "Biomedical Engineer", "Broadcast Announcer", "Bus Driver", "Career/Employment Counselors", "Carpenters", "Cartoonists/Animators/Illustrator", "Cashiers", "Chef/Caterer", "Chemical Engineer", "Chemists", "Chiropractor", "Choreographer", "Civil Engineer", "Clergy", "Commercial Airline Pilot", "Computer Network Specialist", "Computer Programmer", "Computer Software Engineer", "Computer/Office Machine Technician", "Construction Heavy Equipment Operator", "Cooks", "Corrections Officers", "Counter & Retail Sales", "Court Clerks", "Court Reporter", "Criminologist", "Customer Service Representative", "Dancer", "Dental Assistant", "Dental Hygienists", "Dentists", "Detectives/Private Investigator", "Diesel Technicians", "Dietician/Nutritionist", "Drafter", "Economist", "Electrical & Electronic Engineers", "Electricians", "Elementary School Teacher", "Environmental Consultant", "Event Planner", "Farmer", "Fashion Designer", "Federal Agent", "Film/Video Editor", "Financial Institution Manager/Account Manager", "Fire Fighters", "Flight Attendant", "Floral Designer/Stylists", "Food Inspector", "Food Service/Waiter/Waitress", "Forensic Scientist", "Forest, Conservation Worker/Officer", "Funeral Director", "Geologist", "Graphic Designers", "Health Care Administrators", "Health Records Professional", "High School Teachers", "Hotel/Motel Managers", "Human Resource Specialist", "Industrial Machinery Mechanics", "Insurance Agent/Broker", "Insurance Claim Adjuster", "Interior Designer", "Journalist", "Landscape & Grounds Managers", "Landscape Architect", "Lawyers", "Librarian", "Licensed Practical Nurse", "Machinist", "Mail Carrier", "Maintenance and Repair Worker", "Maintenance/Custodian", "Management Analysts & Consultants", "Marine Biologist", "Mechanical Engineer", "Medical Assistant", "Medical Laboratory Technician", "Merchandise Displayer/Stylist", "Meteorologist", "Military/Armed Forces-Stipend for Off-Base Salary Included", "Military/Armed Forces (Officer)-Stipend for Off-Base Salary Included", "Musicians", "Nuclear Engineer", "Nuclear Medicine Technologist", "Nurse's Aide", "Occupational Therapists", "Operations Research Analysts", "Optician", "Orthodontist", "Paralegal", "Paramedic", "Park Ranger/Warden", "Personal Shopper", "Personal Trainer", "Pharmacists", "Photographers", "Physical Therapists", "Physicians (Resident)", "Pilot/Co-pilot", "Pipefitters & Steamfitters", "Plumbers", "Police Officers", "Preschool Teachers & Child Care Worker", "Print Journalist", "Psychologists", "Radiation Therapist", "Real Estate Agents", "Receptionists", "Recreation Director", "Recreational Therapists", "Registered Nurse", "Reporters", "Research Analyst (Financial)", "Respiratory Therapist & Technicians", "Restaurant and Food Service Managers", "Retail Salesperson", "Secretaries/Legal", "Security Consultants & Technicians", "Social Workers", "Special Education Teachers", "Speech-Language Pathologists", "Sports Agent", "Stationary Engineer", "Statistician", "Surgical Technologists", "Surveyor", "Teacher Aide", "Technical Computer Support Specialists", "Theater/Lighting/Sound Technicians", "Trader/Stock Exchange", "Travel Agents", "Truck Drivers", "Urban and Regional Planners", "Veterinarians", "Video Game Developer", "Webmasters", "Website Designer", "Writer", "Zoologist/Wildlife Biologists"})
        Me.cmbCareer.Location = New System.Drawing.Point(151, 21)
        Me.cmbCareer.Name = "cmbCareer"
        Me.cmbCareer.Size = New System.Drawing.Size(357, 21)
        Me.cmbCareer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select your occupation:"
        '
        'lblMonthlyIncome
        '
        Me.lblMonthlyIncome.AutoSize = True
        Me.lblMonthlyIncome.Location = New System.Drawing.Point(39, 64)
        Me.lblMonthlyIncome.Name = "lblMonthlyIncome"
        Me.lblMonthlyIncome.Size = New System.Drawing.Size(115, 13)
        Me.lblMonthlyIncome.TabIndex = 2
        Me.lblMonthlyIncome.Text = "Gross Monthly Income:"
        '
        'txtYearlySalary
        '
        Me.txtYearlySalary.Location = New System.Drawing.Point(151, 85)
        Me.txtYearlySalary.Name = "txtYearlySalary"
        Me.txtYearlySalary.ReadOnly = True
        Me.txtYearlySalary.Size = New System.Drawing.Size(114, 20)
        Me.txtYearlySalary.TabIndex = 3
        Me.txtYearlySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonthlySalaries
        '
        Me.txtMonthlySalaries.Location = New System.Drawing.Point(151, 52)
        Me.txtMonthlySalaries.Name = "txtMonthlySalaries"
        Me.txtMonthlySalaries.ReadOnly = True
        Me.txtMonthlySalaries.Size = New System.Drawing.Size(114, 20)
        Me.txtMonthlySalaries.TabIndex = 4
        Me.txtMonthlySalaries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(39, 104)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(69, 13)
        Me.lblSalary.TabIndex = 5
        Me.lblSalary.Text = "Gross Salary:"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(246, 137)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblNetSalary
        '
        Me.lblNetSalary.AutoSize = True
        Me.lblNetSalary.Location = New System.Drawing.Point(314, 104)
        Me.lblNetSalary.Name = "lblNetSalary"
        Me.lblNetSalary.Size = New System.Drawing.Size(59, 13)
        Me.lblNetSalary.TabIndex = 10
        Me.lblNetSalary.Text = "Net Salary:"
        '
        'txtNetMonthly
        '
        Me.txtNetMonthly.Location = New System.Drawing.Point(426, 52)
        Me.txtNetMonthly.Name = "txtNetMonthly"
        Me.txtNetMonthly.ReadOnly = True
        Me.txtNetMonthly.Size = New System.Drawing.Size(114, 20)
        Me.txtNetMonthly.TabIndex = 9
        Me.txtNetMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetSalary
        '
        Me.txtNetSalary.Location = New System.Drawing.Point(426, 85)
        Me.txtNetSalary.Name = "txtNetSalary"
        Me.txtNetSalary.ReadOnly = True
        Me.txtNetSalary.Size = New System.Drawing.Size(114, 20)
        Me.txtNetSalary.TabIndex = 8
        Me.txtNetSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNetMonthly
        '
        Me.lblNetMonthly.AutoSize = True
        Me.lblNetMonthly.Location = New System.Drawing.Point(314, 64)
        Me.lblNetMonthly.Name = "lblNetMonthly"
        Me.lblNetMonthly.Size = New System.Drawing.Size(105, 13)
        Me.lblNetMonthly.TabIndex = 7
        Me.lblNetMonthly.Text = "Net Monthly Income:"
        '
        'frmCareer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 173)
        Me.Controls.Add(Me.lblNetSalary)
        Me.Controls.Add(Me.txtNetMonthly)
        Me.Controls.Add(Me.txtNetSalary)
        Me.Controls.Add(Me.lblNetMonthly)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.txtMonthlySalaries)
        Me.Controls.Add(Me.txtYearlySalary)
        Me.Controls.Add(Me.lblMonthlyIncome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCareer)
        Me.Name = "frmCareer"
        Me.Text = "Choose Your Career"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCareer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyIncome As System.Windows.Forms.Label
    Friend WithEvents txtYearlySalary As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthlySalaries As System.Windows.Forms.TextBox
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents lblNetSalary As System.Windows.Forms.Label
    Friend WithEvents txtNetMonthly As System.Windows.Forms.TextBox
    Friend WithEvents txtNetSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblNetMonthly As System.Windows.Forms.Label
End Class
