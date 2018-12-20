Option Strict On
Public Class frmTransport
    Dim dblSurprise, dblInsurance As Double
    Dim intTSurprise As Integer
    Private Sub frmTransport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSurprise.Text = ""
     
    End Sub

    Private Sub cmbTransportation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTransportation.SelectedIndexChanged
        Select Case cmbTransportation.SelectedIndex
            Case 0
                Income.dblTransportation = 800
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 125
                    Else
                        dblInsurance = 220
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 90
                    Else
                        dblInsurance = 160
                    End If
                End If
            Case 1
                Income.dblTransportation = 600
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 110
                    Else
                        dblInsurance = 200
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 80
                    Else
                        dblInsurance = 130
                    End If
                End If
            Case 2
                Income.dblTransportation = 500
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 100
                    Else
                        dblInsurance = 180
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 65
                    Else
                        dblInsurance = 120
                    End If
                End If
            Case 3
                Income.dblTransportation = 450
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 90
                    Else
                        dblInsurance = 170
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 60
                    Else
                        dblInsurance = 115
                    End If
                End If
            Case 4
                Income.dblTransportation = 400
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 80
                    Else
                        dblInsurance = 155
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 60
                    Else
                        dblInsurance = 110
                    End If
                End If
            Case 5
                Income.dblTransportation = 375
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 75
                    Else
                        dblInsurance = 145
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 55
                    Else
                        dblInsurance = 105
                    End If
                End If
            Case 6
                Income.dblTransportation = 300
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 70
                    Else
                        dblInsurance = 130
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 50
                    Else
                        dblInsurance = 95
                    End If
                End If
            Case 7
                Income.dblTransportation = 280
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 65
                    Else
                        dblInsurance = 115
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 45
                    Else
                        dblInsurance = 90
                    End If
                End If
            Case 8
                Income.dblTransportation = 300
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 55
                    Else
                        dblInsurance = 100
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 40
                    Else
                        dblInsurance = 75
                    End If
                End If
            Case 9
                Income.dblTransportation = 250
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 50
                    Else
                        dblInsurance = 95
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 35
                    Else
                        dblInsurance = 70
                    End If
                End If
            Case 10
                Income.dblTransportation = 230
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 50
                    Else
                        dblInsurance = 95
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 35
                    Else
                        dblInsurance = 50
                    End If
                End If
            Case 11
                Income.dblTransportation = 190
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 45
                    Else
                        dblInsurance = 90
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 30
                    Else
                        dblInsurance = 65
                    End If
                End If
            Case 12
                Income.dblTransportation = 205
        End Select
        If chkInsurance.Checked = True Then
            txtMonthlyCost.Text = Format$(Convert.ToString(dblSurprise + Income.dblTransportation + dblInsurance), "Currency")
        Else
            txtMonthlyCost.Text = Format$(Convert.ToString(dblSurprise + Income.dblTransportation), "Currency")
        End If
    
        btnSurprise.Enabled = True
    End Sub

    Private Sub btnSurprise_Click(sender As Object, e As EventArgs) Handles btnSurprise.Click
        Randomize()
        If chkInsurance.Checked = False Then
            txtMonthlyCost.Text = Format$(Convert.ToString(Income.dblTransportation), "Currency")
        Else
            txtMonthlyCost.Text = Format$(Convert.ToString(Income.dblTransportation + dblInsurance), "Currency")
        End If
        If cmbTransportation.SelectedIndex <> 12 Then
            intTSurprise = CInt(Rnd() * 7)
            Select Case intTSurprise
                Case 0
                    lblSurprise.Text = "Your insurance company issued you a check for $100 as part of a good driver discount"
                    dblSurprise = -100
                Case 1
                    lblSurprise.Text = "Happy birthday! You receive a $25 coupon redeemable for a free oil change at A1 Oil Lube>"
                    dblSurprise = -25
                Case 2
                    lblSurprise.Text = "You receive a $20 rebate check for buying new tires."
                    dblSurprise = -20
                Case 3
                    lblSurprise.Text = "You bought a new car battery, and receive a $5 check for recycling your old car battery."
                    dblSurprise = -5
                Case 4
                    lblSurprise.Text = "You parked in a no-parking zone. You receive a ticket for $50."
                    dblSurprise = 50
                Case 5
                    dblSurprise = 35
                    lblSurprise.Text = "You need to replace your car headlight and will have to pay $35."
                Case 6
                    lblSurprise.Text = "You received a $75 moving violation citation."
                    dblSurprise = 75
                Case 7
                    lblSurprise.Text = "Your car needs a tune-up and the cost is $100."
                    dblSurprise = 100
            End Select
        ElseIf cmbTransportation.SelectedIndex = 12 Then
            Select Case intTSurprise
                Case 0
                    dblSurprise = 20
                    lblSurprise.Text = "Metra increased their fares. You will have to pay an addition $20 per month."
                Case 1
                    dblSurprise = 20
                    lblSurprise.Text = "You missed the transfer CTA bus to work. You will have to pay $20 for a taxi."
                Case 2
                    dblSurprise = 102
                    lblSurprise.Text = "You decided to get away for the weekend. The rental car costs $102."
                Case 3
                    dblSurprise = 15
                    lblSurprise.Text = "CTA increased their fares. You will have to pay an additional $15 per month."
                Case 4
                    dblSurprise = -205
                    lblSurprise.Text = "Your employer has decided to fully compensate your transportation costs. You receive a check for $205."
                Case 5
                    dblSurprise = -100
                    lblSurprise.Text = "Your employer has decided to partially compensate your transportation costs. You will receive a check for $100."
                Case 6
                    dblSurprise = -50
                    lblSurprise.Text = "Your employer has decided to partially compensate your transportation costs. You will receive a check for $50."
                Case 7
                    dblSurprise = -25
                    lblSurprise.Text = "Your employer has decided to partially compensate your transportation costs. You will receive a check for $25."
            End Select
        Else
            MsgBox("You must select a transportation option.", , "Input Error")
        End If
        If chkInsurance.Checked = True Then
            txtMonthlyCost.Text = Format$(Convert.ToString(dblSurprise + Income.dblTransportation + dblInsurance), "Currency")
        Else
            txtMonthlyCost.Text = Format$(Convert.ToString(dblSurprise + Income.dblTransportation), "Currency")
        End If
        btnContinue.Enabled = True
        cmbTransportation.Enabled = False
    End Sub

    Private Sub chkInsurance_CheckedChanged(sender As Object, e As EventArgs) Handles chkInsurance.CheckedChanged
        Select Case cmbTransportation.SelectedIndex
            Case 0
                Income.dblTransportation = 800
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 125
                    Else
                        dblInsurance = 220
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 90
                    Else
                        dblInsurance = 160
                    End If
                End If
            Case 1
                Income.dblTransportation = 600
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 110
                    Else
                        dblInsurance = 200
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 80
                    Else
                        dblInsurance = 130
                    End If
                End If
            Case 2
                Income.dblTransportation = 500
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 100
                    Else
                        dblInsurance = 180
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 65
                    Else
                        dblInsurance = 120
                    End If
                End If
            Case 3
                Income.dblTransportation = 450
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 90
                    Else
                        dblInsurance = 170
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 60
                    Else
                        dblInsurance = 115
                    End If
                End If
            Case 4
                Income.dblTransportation = 400
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 80
                    Else
                        dblInsurance = 155
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 60
                    Else
                        dblInsurance = 110
                    End If
                End If
            Case 5
                Income.dblTransportation = 375
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 75
                    Else
                        dblInsurance = 145
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 55
                    Else
                        dblInsurance = 105
                    End If
                End If
            Case 6
                Income.dblTransportation = 300
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 70
                    Else
                        dblInsurance = 130
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 50
                    Else
                        dblInsurance = 95
                    End If
                End If
            Case 7
                Income.dblTransportation = 280
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 65
                    Else
                        dblInsurance = 115
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 45
                    Else
                        dblInsurance = 90
                    End If
                End If
            Case 8
                Income.dblTransportation = 300
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 55
                    Else
                        dblInsurance = 100
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 40
                    Else
                        dblInsurance = 75
                    End If
                End If
            Case 9
                Income.dblTransportation = 250
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 50
                    Else
                        dblInsurance = 95
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 35
                    Else
                        dblInsurance = 70
                    End If
                End If
            Case 10
                Income.dblTransportation = 230
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 50
                    Else
                        dblInsurance = 95
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 35
                    Else
                        dblInsurance = 50
                    End If
                End If
            Case 11
                Income.dblTransportation = 190
                If Income.intGender = 1 Then
                    If Income.intSpouse = 1 Then
                        dblInsurance = 45
                    Else
                        dblInsurance = 90
                    End If
                Else
                    If Income.intSpouse = 1 Then
                        dblInsurance = 30
                    Else
                        dblInsurance = 65
                    End If
                End If
            Case 12
                Income.dblTransportation = 205
        End Select
        If chkInsurance.Checked = True Then
            txtMonthlyCost.Text = Format$((Income.dblTransportation + dblInsurance - dblSurprise), "Currency")
        ElseIf chkInsurance.Checked = False Then
            txtMonthlyCost.Text = Format$((Income.dblTransportation - dblSurprise), "Currency")
        End If
        If Income.intGender = 0 Then
            frmGender.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub grpSex_Enter(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmMain.Show()
        Me.Hide()
        frmMain.btnTransportation.Enabled = False
        If chkInsurance.Checked = True Then
            Income.dblTransportation = Income.dblTransportation + dblInsurance - dblSurprise
        Else
            Income.dblTransportation = Income.dblTransportation - dblSurprise
        End If
        Income.dblDispose = Income.dblUsableIncome - (Income.dblChildcare + Income.dblClothing + Income.dblFood + Income.dblHousingCost + Income.dblRecreation + Income.dblTransportation + Income.dblUtilities) + Income.dblNetSpouseIncome + Income.dblWheelOfFortune
        If Income.dblDispose < 0 Then
            frmMain.txtUse.Text = "-" & Format$(Convert.ToString(-Income.dblDispose), "Currency")
        Else
            frmMain.txtUse.Text = Format$(Convert.ToString(Income.dblDispose), "Currency")
        End If
        If frmMain.btnCareer.Enabled = False And frmMain.btnChildcare.Enabled = False And frmMain.btnClothing.Enabled = False And frmMain.btnFood.Enabled = False And frmMain.btnHousing.Enabled = False And frmMain.btnLeisure.Enabled = False And frmMain.btnTransportation.Enabled = False And frmMain.btnUtilities.Enabled = False And frmMain.btnWheelOfFortune.Enabled = False And frmMain.btnRndChild.Enabled = False And frmMain.btnRndSpouse.Enabled = False Then
            frmMain.btnEnding.Enabled = True
        End If
    End Sub
End Class