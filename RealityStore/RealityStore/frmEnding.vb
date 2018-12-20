Public Class frmEnding

    Private Sub frmEnding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEnding.Text = ""
        If Income.dblDispose < 0 Then
            lblEnding.Text = "Sorry, you ran out of money. You were kicked out of your house, lost your job, and died alone in the streets because of your crippling debt and unpaid loans. Want to try again?"
        Else
            lblEnding.Text = "Congratulations! You managed to sustain yourself with the income you earned! Want to play again?"
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        frmBegin.Close()
        frmCareer.Close()
        frmChild.Close()
        frmClothing.Close()
        frmFood.Close()
        frmHousing.Close()
        frmLeisure.Close()
        frmMain.Close()
        frmTransport.Close()
        frmUtilities.Close()
        frmWheel.Close()
        frmGender.Close()
        Me.Close()
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        frmBegin.Close()
        frmCareer.Close()
        frmChild.Close()
        frmClothing.Close()
        frmFood.Close()
        frmHousing.Close()
        frmLeisure.Close()
        frmMain.Close()
        frmTransport.Close()
        frmUtilities.Close()
        frmBegin.Show()
        frmWheel.Close()
        frmGender.Close()
        Income.dblChildcare = 0
        Income.dblClothing = 0
        Income.dblDispose = 0
        Income.dblFood = 0
        Income.dblHousingCost = 0
        Income.dblMonthly = 0
        Income.dblNetSpouseIncome = 0
        Income.dblRecreation = 0
        Income.dblSpouseIncome = 0
        Income.dblTransportation = 0
        Income.dblUsableIncome = 0
        Income.dblUtilities = 0
        Income.dblWheelOfFortune = 0
        Income.dblYearly = 0
        Income.intChild = 0
        Income.intSpouse = 0
        Income.intSpouseOccupation = 0
        Income.intGender = 0
        Me.Close()
    End Sub
End Class