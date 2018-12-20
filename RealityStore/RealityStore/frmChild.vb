Option Strict On
Public Class frmChild
    Dim dblChildcare As Double
    Private Sub frmChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbChildcare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChildcare.SelectedIndexChanged
        Select Case cmbChildcare.SelectedIndex
            Case 0
                If Income.intChild = 1 Then
                    dblChildcare = 800
                Else
                    dblChildcare = 1600
                End If
                btnContinue.Enabled = True
            Case 1
                If Income.intChild = 1 Then
                    dblChildcare = 600
                Else
                    dblChildcare = 1000
                End If
                btnContinue.Enabled = True
            Case 2
                If Income.intSpouseOccupation = 163 Then
                    dblChildcare = 0
                    btnContinue.Enabled = True
                Else
                    MsgBox("You cannot select this option.", , "Input Error")
                    cmbChildcare.SelectedIndex = -1
                    btnContinue.Enabled = False
                End If
            Case Else
                btnContinue.Enabled = False
        End Select
        txtChildcare.Text = Format$(Convert.ToString(dblChildcare), "Currency")

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmMain.Show()
        Me.Hide()
        Income.dblChildcare = dblChildcare
        frmMain.btnChildcare.Enabled = False
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