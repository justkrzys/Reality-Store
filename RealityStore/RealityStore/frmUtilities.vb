Option Strict On
Public Class frmUtilities
    Dim dblUtilities, dblCell, dblTV, dblInternet As Double
    Private Sub frmUtilities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case txtOption.Text
            Case "Option 1"
                dblUtilities = 270
            Case "Option 2"
                dblUtilities = 250
            Case "Option 3"
                dblUtilities = 235
            Case "Option 4"
                dblUtilities = 230
            Case "Option 5"
                dblUtilities = 205
            Case "Option 6"
                dblUtilities = 205
            Case "Option 7"
                dblUtilities = 190
            Case "Option 8"
                dblUtilities = 185
            Case "Option 9"
                dblUtilities = 205
            Case "Option 10"
                dblUtilities = 145
            Case "Option 11"
                dblUtilities = 100
            Case "Option 12"
                dblUtilities = 25
        End Select
        txtUtilities.Text = Format$(Convert.ToString(dblUtilities), "Currency")
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmMain.Show()
        Me.Hide()
        Select Case txtOption.Text
            Case "Option 1"
                dblUtilities = 270
            Case "Option 2"
                dblUtilities = 250
            Case "Option 3"
                dblUtilities = 235
            Case "Option 4"
                dblUtilities = 230
            Case "Option 5"
                dblUtilities = 205
            Case "Option 6"
                dblUtilities = 205
            Case "Option 7"
                dblUtilities = 190
            Case "Option 8"
                dblUtilities = 185
            Case "Option 9"
                dblUtilities = 205
            Case "Option 10"
                dblUtilities = 145
            Case "Option 11"
                dblUtilities = 100
            Case "Option 12"
                dblUtilities = 25
        End Select
        Income.dblUtilities = dblTV + dblInternet + dblCell + dblUtilities
        frmMain.btnUtilities.Enabled = False
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

    Private Sub txtOption_TextChanged(sender As Object, e As EventArgs) Handles txtOption.TextChanged

    End Sub


    Private Sub chkCell_CheckedChanged(sender As Object, e As EventArgs) Handles chkCell.CheckedChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Select Case txtOption.Text
            Case "Option 1"
                dblUtilities = 270
            Case "Option 2"
                dblUtilities = 250
            Case "Option 3"
                dblUtilities = 235
            Case "Option 4"
                dblUtilities = 230
            Case "Option 5"
                dblUtilities = 205
            Case "Option 6"
                dblUtilities = 205
            Case "Option 7"
                dblUtilities = 190
            Case "Option 8"
                dblUtilities = 185
            Case "Option 9"
                dblUtilities = 205
            Case "Option 10"
                dblUtilities = 145
            Case "Option 11"
                dblUtilities = 100
            Case "Option 12"
                dblUtilities = 25
        End Select
        If chkCell.Checked = True Then
            dblCell = 50
        Else
            dblCell = 0
        End If
        If chkInternet.Checked = True Then
            dblInternet = 60
        Else
            dblInternet = 0
        End If
        If chkTV.Checked = True Then
            dblTV = 35
        Else
            dblTV = 0
        End If

        txtUtilities.Text = Format$(Convert.ToString(dblTV + dblInternet + dblCell + dblUtilities), "Currency")
        btnContinue.Enabled = True
    End Sub
End Class