Option Strict On
Public Class frmClothing
    Private Sub cmbClothes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClothes.SelectedIndexChanged
        Select Case cmbClothes.SelectedIndex
            Case 0
                If Income.intSpouse = 1 And Income.intChild = 2 Then
                    Income.dblClothing = 900
                ElseIf Income.intSpouse = 1 And Income.intChild = 1 Then
                    Income.dblClothing = 700
                ElseIf Income.intSpouse = 0 And Income.intChild = 2 Then
                    Income.dblClothing = 475
                ElseIf Income.intSpouse = 0 And Income.intChild = 1 Then
                    Income.dblClothing = 450
                ElseIf Income.intSpouse = 1 And Income.intChild = 0 Then
                    Income.dblClothing = 500
                ElseIf Income.intSpouse = 0 And Income.intChild = 0 Then
                    Income.dblClothing = 250
                End If
                btnContinue.Enabled = True
            Case 1
                If Income.intSpouse = 1 And Income.intChild = 2 Then
                    Income.dblClothing = 650
                ElseIf Income.intSpouse = 1 And Income.intChild = 1 Then
                    Income.dblClothing = 500
                ElseIf Income.intSpouse = 0 And Income.intChild = 2 Then
                    Income.dblClothing = 475
                ElseIf Income.intSpouse = 0 And Income.intChild = 1 Then
                    Income.dblClothing = 325
                ElseIf Income.intSpouse = 1 And Income.intChild = 0 Then
                    Income.dblClothing = 350
                ElseIf Income.intSpouse = 0 And Income.intChild = 0 Then
                    Income.dblClothing = 175
                End If
                btnContinue.Enabled = True
            Case 2
                If Income.intSpouse = 1 And Income.intChild = 2 Then
                    Income.dblClothing = 350
                ElseIf Income.intSpouse = 1 And Income.intChild = 1 Then
                    Income.dblClothing = 275
                ElseIf Income.intSpouse = 0 And Income.intChild = 2 Then
                    Income.dblClothing = 250
                ElseIf Income.intSpouse = 0 And Income.intChild = 1 Then
                    Income.dblClothing = 175
                ElseIf Income.intSpouse = 1 And Income.intChild = 0 Then
                    Income.dblClothing = 200
                ElseIf Income.intSpouse = 0 And Income.intChild = 0 Then
                    Income.dblClothing = 100
                End If
                btnContinue.Enabled = True
            Case Else
                btnContinue.Enabled = False
        End Select
        txtClothes.Text = Format$(Convert.ToString(Income.dblClothing), "Currency")
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmMain.Show()
        Me.Hide()
        frmMain.btnClothing.Enabled = False
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

    Private Sub frmClothing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class