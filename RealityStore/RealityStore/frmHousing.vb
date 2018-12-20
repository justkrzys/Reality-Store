Option Strict On
Public Class frmHousing
    Dim dblInsurance As Double = 0
    Dim intHSurprise As Integer
    Dim dblSurprise As Double
    Private Sub cmbHousing_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHousing.SelectedIndexChanged
        Select Case cmbHousing.SelectedIndex
            Case 0
                Income.dblHousingCost = 4665.0
                dblInsurance = 160
                frmUtilities.txtOption.Text = "Option 1"
            Case 1
                Income.dblHousingCost = 3644.0
                dblInsurance = 120
                frmUtilities.txtOption.Text = "Option 2"
            Case 2
                Income.dblHousingCost = 3058.0
                dblInsurance = 100
                frmUtilities.txtOption.Text = "Option 3"
            Case 3
                Income.dblHousingCost = 2257.0
                dblInsurance = 90
                frmUtilities.txtOption.Text = "Option 4"
            Case 4
                Income.dblHousingCost = 1843.0
                dblInsurance = 70
                frmUtilities.txtOption.Text = "Option 5"
            Case 5
                Income.dblHousingCost = 1250.0
                dblInsurance = 50
                frmUtilities.txtOption.Text = "Option 6"
            Case 6
                Income.dblHousingCost = 1018.0
                dblInsurance = 44
                frmUtilities.txtOption.Text = "Option 7"
            Case 7
                Income.dblHousingCost = 1000.0
                dblInsurance = 40
                frmUtilities.txtOption.Text = "Option 8"
            Case 8
                Income.dblHousingCost = 900.0
                dblInsurance = 30
                frmUtilities.txtOption.Text = "Option 9"
            Case 9
                Income.dblHousingCost = 750.0
                dblInsurance = 20.0
                frmUtilities.txtOption.Text = "Option 10"
            Case 10
                Income.dblHousingCost = 550.0
                dblInsurance = 10
                frmUtilities.txtOption.Text = "Option 11"
            Case 11
                Income.dblHousingCost = 300.0
                dblInsurance = 0
                frmUtilities.txtOption.Text = "Option 12"
        End Select
        If chkInsurance.Checked = True Then
            txtMonthlyCost.Text = Format$((Income.dblHousingCost + dblInsurance), "Currency")
        Else
            txtMonthlyCost.Text = Format$((Income.dblHousingCost), "Currency")
        End If
        If cmbHousing.SelectedIndex <> -1 Then
            btnHousingSurprise.Enabled = True
        Else
            btnHousingSurprise.Enabled = False
        End If
    End Sub

    Private Sub txtMonthlyCost_TextChanged(sender As Object, e As EventArgs) Handles txtMonthlyCost.TextChanged

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmMain.Show()
        Me.Hide()
        frmMain.btnHousing.Enabled = False
        If chkInsurance.Checked = True Then
            Income.dblHousingCost = Income.dblHousingCost + dblInsurance - dblSurprise
        Else
            Income.dblHousingCost = Income.dblHousingCost - dblSurprise
        End If
        Income.dblDispose = Income.dblUsableIncome - (Income.dblChildcare + Income.dblClothing + Income.dblFood + Income.dblHousingCost + Income.dblRecreation + Income.dblTransportation + Income.dblUtilities) + Income.dblNetSpouseIncome + Income.dblWheelOfFortune
        If Income.dblDispose < 0 Then
            frmMain.txtUse.Text = "-" & Format$(Convert.ToString(-Income.dblDispose), "Currency")
        Else
            frmMain.txtUse.Text = Format$(Convert.ToString(Income.dblDispose), "Currency")
        End If
        frmMain.btnUtilities.Enabled = True
        If frmMain.btnCareer.Enabled = False And frmMain.btnChildcare.Enabled = False And frmMain.btnClothing.Enabled = False And frmMain.btnFood.Enabled = False And frmMain.btnHousing.Enabled = False And frmMain.btnLeisure.Enabled = False And frmMain.btnTransportation.Enabled = False And frmMain.btnUtilities.Enabled = False And frmMain.btnWheelOfFortune.Enabled = False And frmMain.btnRndChild.Enabled = False And frmMain.btnRndSpouse.Enabled = False Then
            frmMain.btnEnding.Enabled = True
        End If
    End Sub

    Private Sub lblOption2a_Click(sender As Object, e As EventArgs) Handles lblOption2a.Click

    End Sub

    Private Sub btnHousingSurprise_Click(sender As Object, e As EventArgs) Handles btnHousingSurprise.Click
        Randomize()
        If cmbHousing.SelectedIndex = 0 Or cmbHousing.SelectedIndex = 2 Or cmbHousing.SelectedIndex = 3 Or cmbHousing.SelectedIndex = 4 Or cmbHousing.SelectedIndex = 1 Or cmbHousing.SelectedIndex = 6 Or cmbHousing.SelectedIndex = 11 Then
            intHSurprise = CInt(Rnd() * 7)
            Select Case intHSurprise
                Case 0
                    lblSurprise.Text = "You overpaid the yearly escrow account for your electric bill. You will receive a check for $50"
                    dblSurprise = 50
                Case 1
                    lblSurprise.Text = "The city you live in has issued a tax rebate check for $85."
                    dblSurprise = 85
                Case 2
                    lblSurprise.Text = "You receive a rebate check from R&J Roofing Co. for $75"
                    dblSurprise = 75
                Case 3
                    lblSurprise.Text = "You had water damage in your home and received an insurance check in the amount of $100 for the replacement value of damages."
                    dblSurprise = 100
                Case 4
                    lblSurprise.Text = "You have tree damage from a windstorm. Debris removal cost is $50."
                    dblSurprise = -50
                Case 5
                    dblSurprise = -50
                    lblSurprise.Text = "You need to treat your lawn for grub control. The cost is $50."
                Case 6
                    lblSurprise.Text = "It's time for your furnace to be cleaned. You need to pay $75 dollars to Smith Furnace Co."
                    dblSurprise = -75
                Case 7
                    lblSurprise.Text = "You have no hot water! You need to replace your water heater and pay $200 to finance a new one."
                    dblSurprise = -200
            End Select
        ElseIf cmbHousing.SelectedIndex = 5 Or cmbHousing.SelectedIndex = 7 Or cmbHousing.SelectedIndex = 8 Or cmbHousing.SelectedIndex = 9 Or cmbHousing.SelectedIndex = 10 Then
            Select Case intHSurprise
                Case 0
                    dblSurprise = -75
                    lblSurprise.Text = "There has been an increase in your rent due to an increase in county taxes. You need to immediately pay your landlord $75."
                Case 1
                    dblSurprise = -50
                    lblSurprise.Text = "Your bedroom window is crackied, and you will need to replace it. You will need to pay $50."
                Case 2
                    dblSurprise = -65
                    lblSurprise.Text = "There is an infestation of ants! You must pay the $65 bill to Pest Control Co."
                Case 3
                    dblSurprise = -150
                    lblSurprise.Text = "Someone broke into your apartment! You will need to pay the $150 deductable for your renter's insurance."
                Case 4
                    dblSurprise = 75
                    lblSurprise.Text = "There has been a decrease in your rent due to a decrease in county taxes. You will receive a check for $75."
                Case 5
                    dblSurprise = 25
                    lblSurprise.Text = "You paid your rent two weeks in advance and received an advance payment discount for $25."
                Case 6
                    dblSurprise = 200
                    lblSurprise.Text = "Someone broke into your apartment and your renter's insurance claim has arrived. You receive a check for $200."
                Case 7
                    dblSurprise = 100
                    lblSurprise.Text = "You complated some maintainence around the complex and received a $100 discount on this month's rent."
            End Select
        Else
            MsgBox("You must select a housing option.", , "Input Error")
        End If
        btnHousingSurprise.Enabled = False
        btnContinue.Enabled = True
        cmbHousing.Enabled = False
        If chkInsurance.Checked = False Then
            txtMonthlyCost.Text = Format$(Convert.ToString(Income.dblHousingCost), "Currency")
        Else
            txtMonthlyCost.Text = Format$(Convert.ToString(Income.dblHousingCost - dblInsurance), "Currency")
        End If
    End Sub

    Private Sub frmHousing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSurprise.Text = ""
    End Sub

    Private Sub chkInsurance_CheckedChanged(sender As Object, e As EventArgs) Handles chkInsurance.CheckedChanged
        Select Case cmbHousing.SelectedIndex
            Case 0
                Income.dblHousingCost = 4665.0
                dblInsurance = 160
            Case 1
                Income.dblHousingCost = 3644.0
                dblInsurance = 120
            Case 2
                Income.dblHousingCost = 3058.0
                dblInsurance = 100
            Case 3
                Income.dblHousingCost = 2257.0
                dblInsurance = 90
            Case 4
                Income.dblHousingCost = 1843.0
                dblInsurance = 70
            Case 5
                Income.dblHousingCost = 1250.0
                dblInsurance = 50
            Case 6
                Income.dblHousingCost = 1018.0
                dblInsurance = 44
            Case 7
                Income.dblHousingCost = 1000.0
                dblInsurance = 40
            Case 8
                Income.dblHousingCost = 900.0
                dblInsurance = 30
            Case 9
                Income.dblHousingCost = 750.0
                dblInsurance = 20
            Case 10
                Income.dblHousingCost = 550.0
                dblInsurance = 10
            Case 11
                Income.dblHousingCost = 300.0
                dblInsurance = 0
        End Select
        If chkInsurance.Checked = True Then
            txtMonthlyCost.Text = Format$((Income.dblHousingCost + dblInsurance - dblSurprise), "Currency")
        ElseIf chkInsurance.Checked = False Then
            txtMonthlyCost.Text = Format$((Income.dblHousingCost - dblSurprise), "Currency")
        End If
    End Sub
End Class