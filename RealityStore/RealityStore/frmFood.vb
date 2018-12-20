Option Strict On
Public Class frmFood
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOption.SelectedIndexChanged
        Select Case cmbOption.SelectedIndex
            Case 0
                If Income.intSpouse = 1 And Income.intChild = 2 Then
                    Income.dblFood = 975
                ElseIf Income.intSpouse = 1 And Income.intChild = 1 Then
                    Income.dblFood = 900
                ElseIf Income.intSpouse = 0 And Income.intChild = 2 Then
                    Income.dblFood = 850
                ElseIf Income.intSpouse = 0 And Income.intChild = 1 Then
                    Income.dblFood = 775
                ElseIf Income.intSpouse = 1 And Income.intChild = 0 Then
                    Income.dblFood = 800
                ElseIf Income.intSpouse = 0 And Income.intChild = 0 Then
                    Income.dblFood = 550
                End If
                btnContinue.Enabled = True
            Case 1
                If Income.intSpouse = 1 And Income.intChild = 2 Then
                    Income.dblFood = 850
                ElseIf Income.intSpouse = 1 And Income.intChild = 1 Then
                    Income.dblFood = 775
                ElseIf Income.intSpouse = 0 And Income.intChild = 2 Then
                    Income.dblFood = 725
                ElseIf Income.intSpouse = 0 And Income.intChild = 1 Then
                    Income.dblFood = 650
                ElseIf Income.intSpouse = 1 And Income.intChild = 0 Then
                    Income.dblFood = 675
                ElseIf Income.intSpouse = 0 And Income.intChild = 0 Then
                    Income.dblFood = 475
                End If
                btnContinue.Enabled = True
            Case 2
                If Income.intSpouse = 1 And Income.intChild = 2 Then
                    Income.dblFood = 775
                ElseIf Income.intSpouse = 1 And Income.intChild = 1 Then
                    Income.dblFood = 700
                ElseIf Income.intSpouse = 0 And Income.intChild = 2 Then
                    Income.dblFood = 625
                ElseIf Income.intSpouse = 0 And Income.intChild = 1 Then
                    Income.dblFood = 450
                ElseIf Income.intSpouse = 1 And Income.intChild = 0 Then
                    Income.dblFood = 550
                ElseIf Income.intSpouse = 0 And Income.intChild = 0 Then
                    Income.dblFood = 350
                End If
                btnContinue.Enabled = True
            Case Else
                btnContinue.Enabled = False
        End Select
        txtFood.Text = Format$(Convert.ToString(Income.dblFood), "Currency")
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmMain.Show()
        Me.Hide()
        frmMain.btnFood.Enabled = False
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

    Private Sub frmFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class