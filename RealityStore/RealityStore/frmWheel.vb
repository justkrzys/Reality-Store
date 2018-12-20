Option Strict On
Public Class frmWheel
    Private Sub frmWheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWheel.Text = ""
    End Sub

    Private Sub btnWheel_Click(sender As Object, e As EventArgs) Handles btnWheel.Click
        Dim dblWheel As Double
        Dim intWheel As Integer
        Randomize()
        intWheel = CInt(Rnd() * 15 + 1)
        Select Case intWheel
            Case 1
                dblWheel = 25
                lblWheel.Text = "You received a $25.00 ,ail-in rebate."
                txtWheel.Text = Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = dblWheel
            Case 2
                dblWheel = 200
                lblWheel.Text = "You owe $200.00 on your credit card."
                txtWheel.Text = "-" & Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = -dblWheel
            Case 3
                dblWheel = 200
                lblWheel.Text = "You received $200.00 for your tax refund."
                txtWheel.Text = Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = dblWheel
            Case 4
                dblWheel = 200
                lblWheel.Text = "You paid $200.00 towards your property taxes."
                txtWheel.Text = "-" & Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = -dblWheel
            Case 5
                dblWheel = 100
                lblWheel.Text = "You received a $100.00 bonus from your employer."
                txtWheel.Text = Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = dblWheel
            Case 6
                dblWheel = 300
                lblWheel.Text = "You paid $300.00 towards your student loans."
                txtWheel.Text = "-" & Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = -dblWheel
            Case 7
                dblWheel = 50
                lblWheel.Text = "You received $50.00 for your birthday."
                txtWheel.Text = Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = dblWheel
            Case 8
                dblWheel = 100
                lblWheel.Text = "You made a $100.00 donation to charity."
                txtWheel.Text = "-" & Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = -dblWheel
            Case 9
                dblWheel = 20
                lblWheel.Text = "You found $20.00 in your pocket."
                txtWheel.Text = Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = dblWheel
            Case 10
                dblWheel = 50
                lblWheel.Text = "You bought a gift for your best friend for $50.00."
                txtWheel.Text = "-" & Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = -dblWheel
            Case 11
                dblWheel = 500
                lblWheel.Text = "You inherited $500.00 from your long-lost Aunt Betty."
                txtWheel.Text = Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = dblWheel
            Case 12
                dblWheel = 125
                lblWheel.Text = "You paid the vet $125.00 for your dog's annual vaccinations."
                txtWheel.Text = "-" & Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = -dblWheel
            Case 13
                dblWheel = 200
                lblWheel.Text = "You received $200.00 from a stock dividend."
                txtWheel.Text = Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = dblWheel
            Case 14
                dblWheel = 300
                lblWheel.Text = "You went to a wedding and gave the happy couple $300.00"
                txtWheel.Text = "-" & Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = -dblWheel
            Case 15
                dblWheel = 150
                lblWheel.Text = "You received $150.00 for a holiday gift."
                txtWheel.Text = Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = dblWheel
            Case 16
                dblWheel = 300
                lblWheel.Text = "You paid a $300.00 doctor's bill."
                txtWheel.Text = "-" & Format$(Convert.ToString(dblWheel), "Currency")
                Income.dblWheelOfFortune = -dblWheel
        End Select
        btnWheel.Enabled = False
        btnContinue.Enabled = True
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmMain.Show()
        Me.Hide()
        Income.dblDispose = Income.dblUsableIncome - (Income.dblChildcare + Income.dblClothing + Income.dblFood + Income.dblHousingCost + Income.dblRecreation + Income.dblTransportation + Income.dblUtilities) + Income.dblNetSpouseIncome + Income.dblWheelOfFortune
        If Income.dblDispose < 0 Then
            frmMain.txtUse.Text = "-" & Format$(Convert.ToString(-Income.dblDispose), "Currency")
        Else
            frmMain.txtUse.Text = Format$(Convert.ToString(Income.dblDispose), "Currency")
        End If
        frmMain.btnWheelOfFortune.Enabled = False
        If frmMain.btnCareer.Enabled = False And frmMain.btnChildcare.Enabled = False And frmMain.btnClothing.Enabled = False And frmMain.btnFood.Enabled = False And frmMain.btnHousing.Enabled = False And frmMain.btnLeisure.Enabled = False And frmMain.btnTransportation.Enabled = False And frmMain.btnUtilities.Enabled = False And frmMain.btnWheelOfFortune.Enabled = False And frmMain.btnRndChild.Enabled = False And frmMain.btnRndSpouse.Enabled = False Then
            frmMain.btnEnding.Enabled = True
        End If
    End Sub
End Class