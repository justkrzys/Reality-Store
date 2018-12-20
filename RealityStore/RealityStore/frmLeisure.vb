Option Strict On
Public Class frmLeisure
    Dim dblVacation, dblSport, dblMovie, dblGym, dblConcert As Double
    Private Sub cmbGym_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGym.SelectedIndexChanged
        Select Case cmbGym.SelectedIndex
            Case 0
                If Income.intSpouse = 0 Then
                    dblGym = 135
                Else
                    dblGym = 270
                End If
            Case 1
                If Income.intSpouse = 0 Then
                    dblGym = 40
                Else
                    dblGym = 80
                End If
            Case 2
                If Income.intSpouse = 0 Then
                    dblGym = 20
                Else
                    dblGym = 40
                End If
            Case Else
                dblGym = 0
        End Select
        txtGym.Text = Format$(Convert.ToString(dblGym), "Currency")
        Income.dblRecreation = dblConcert + dblGym + dblMovie + dblSport + dblVacation
        txtLeisure.Text = Format$(Convert.ToString(Income.dblRecreation), "Currency")
    End Sub

    Private Sub cmbConcert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConcert.SelectedIndexChanged
        Select Case cmbConcert.SelectedIndex
            Case 0
                If Income.intSpouse = 0 Then
                    If Income.intChild = 0 Then
                        dblConcert = 250
                    ElseIf Income.intChild = 1 Then
                        dblConcert = 250 + 60
                    ElseIf Income.intChild = 2 Then
                        dblConcert = 250 + 90
                    End If
                Else
                    If Income.intChild = 0 Then
                        dblConcert = 500
                    ElseIf Income.intChild = 1 Then
                        dblConcert = 500 + 60
                    ElseIf Income.intChild = 2 Then
                        dblConcert = 500 + 90
                    End If
                End If
            Case 1
                If Income.intSpouse = 1 Then
                    If Income.intChild = 0 Then
                        dblConcert = 200
                    ElseIf Income.intChild = 1 Then
                        dblConcert = 200 + 60
                    ElseIf Income.intChild = 2 Then
                        dblConcert = 200 + 90
                    End If
                Else
                    If Income.intChild = 0 Then
                        dblConcert = 100
                    ElseIf Income.intChild = 1 Then
                        dblConcert = 100 + 60
                    ElseIf Income.intChild = 2 Then
                        dblConcert = 100 + 90
                    End If
                End If
            Case 2
                If Income.intSpouse = 0 Then
                    If Income.intChild = 0 Then
                        dblConcert = 30
                    ElseIf Income.intChild = 1 Then
                        dblConcert = 30 + 60
                    ElseIf Income.intChild = 2 Then
                        dblConcert = 30 + 90
                    End If
                Else
                    If Income.intChild = 0 Then
                        dblConcert = 60
                    ElseIf Income.intChild = 1 Then
                        dblConcert = 60 + 60
                    ElseIf Income.intChild = 2 Then
                        dblConcert = 60 + 90
                    End If
                End If
            Case Else
                dblConcert = 0
        End Select
        txtConcert.Text = Format$(Convert.ToString(dblConcert), "Currency")
        Income.dblRecreation = dblConcert + dblGym + dblMovie + dblSport + dblVacation
        txtLeisure.Text = Format$(Convert.ToString(Income.dblRecreation), "Currency")
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
        frmMain.btnLeisure.Enabled = False
        If frmMain.btnCareer.Enabled = False And frmMain.btnChildcare.Enabled = False And frmMain.btnClothing.Enabled = False And frmMain.btnFood.Enabled = False And frmMain.btnHousing.Enabled = False And frmMain.btnLeisure.Enabled = False And frmMain.btnTransportation.Enabled = False And frmMain.btnUtilities.Enabled = False And frmMain.btnWheelOfFortune.Enabled = False And frmMain.btnRndChild.Enabled = False And frmMain.btnRndSpouse.Enabled = False Then
            frmMain.btnEnding.Enabled = True
        End If
    End Sub

    Private Sub txtLeisure_TextChanged(sender As Object, e As EventArgs) Handles txtLeisure.TextChanged

    End Sub

    Private Sub cmbSports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSports.SelectedIndexChanged
        Select Case cmbSports.SelectedIndex
            Case 0
                If Income.intSpouse = 0 Then
                    If Income.intChild = 0 Then
                        dblSport = 170
                    ElseIf Income.intChild = 1 Then
                        dblSport = 170 + 60
                    ElseIf Income.intChild = 2 Then
                        dblSport = 170 + 90
                    End If
                Else
                    If Income.intChild = 0 Then
                        dblSport = 340
                    ElseIf Income.intChild = 1 Then
                        dblSport = 340 + 60
                    ElseIf Income.intChild = 2 Then
                        dblSport = 340 + 90
                    End If
                End If
            Case 1
                If Income.intSpouse = 0 Then
                    If Income.intChild = 0 Then
                        dblSport = 60
                    ElseIf Income.intChild = 1 Then
                        dblSport = 60 + 60
                    ElseIf Income.intChild = 2 Then
                        dblSport = 60 + 90
                    End If
                Else
                    If Income.intChild = 0 Then
                        dblSport = 120
                    ElseIf Income.intChild = 1 Then
                        dblSport = 120 + 60
                    ElseIf Income.intChild = 2 Then
                        dblSport = 120 + 90
                    End If
                End If
            Case 2
                If Income.intSpouse = 0 Then
                    If Income.intChild = 0 Then
                        dblSport = 20
                    ElseIf Income.intChild = 1 Then
                        dblSport = 20 + 60
                    ElseIf Income.intChild = 2 Then
                        dblSport = 20 + 90
                    End If
                Else
                    If Income.intChild = 0 Then
                        dblSport = 40
                    ElseIf Income.intChild = 1 Then
                        dblSport = 40 + 60
                    ElseIf Income.intChild = 2 Then
                        dblSport = 40 + 90
                    End If
                End If
            Case Else
                dblSport = 0
        End Select
        txtSport.Text = Format$(Convert.ToString(dblSport), "Currency")
        Income.dblRecreation = dblConcert + dblGym + dblMovie + dblSport + dblVacation
        txtLeisure.Text = Format$(Convert.ToString(Income.dblRecreation), "Currency")
    End Sub

    Private Sub cmbMovies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMovies.SelectedIndexChanged
        Select Case cmbMovies.SelectedIndex
            Case 0
                If Income.intSpouse = 0 Then
                    If Income.intChild = 0 Then
                        dblMovie = 40
                    ElseIf Income.intChild = 1 Then
                        dblMovie = 40 + 40
                    ElseIf Income.intChild = 2 Then
                        dblMovie = 40 + 60
                    End If
                Else
                    If Income.intChild = 0 Then
                        dblMovie = 80
                    ElseIf Income.intChild = 1 Then
                        dblMovie = 80 + 40
                    ElseIf Income.intChild = 2 Then
                        dblMovie = 80 + 60
                    End If
                End If
            Case 1
                If Income.intSpouse = 0 Then
                    If Income.intChild = 0 Then
                        dblMovie = 20
                    ElseIf Income.intChild = 1 Then
                        dblMovie = 20 + 40
                    ElseIf Income.intChild = 2 Then
                        dblMovie = 20 + 60
                    End If
                Else
                    If Income.intChild = 0 Then
                        dblMovie = 40
                    ElseIf Income.intChild = 1 Then
                        dblMovie = 40 + 40
                    ElseIf Income.intChild = 2 Then
                        dblMovie = 40 + 60
                    End If
                End If
            Case 2
                dblMovie = 5
            Case Else
                dblMovie = 0
        End Select
        txtMovie.Text = Format$(Convert.ToString(dblMovie), "Currency")
        Income.dblRecreation = dblConcert + dblGym + dblMovie + dblSport + dblVacation
        txtLeisure.Text = Format$(Convert.ToString(Income.dblRecreation), "Currency")
    End Sub

    Private Sub frmLeisure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbVacation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVacation.SelectedIndexChanged
        Select Case cmbVacation.SelectedIndex
            Case 0
                If Income.intSpouse = 0 Then
                    dblVacation = 1500
                Else
                    dblVacation = 3000
                End If
            Case 1
                If Income.intSpouse = 0 Then
                    dblVacation = 550
                Else
                    dblVacation = 700
                End If
            Case 2
                If Income.intSpouse = 0 Then
                    dblVacation = 300
                Else
                    dblVacation = 450
                End If
            Case Else
                dblVacation = 0
        End Select
        txtVacation.Text = Format$(Convert.ToString(dblVacation), "Currency")
        Income.dblRecreation = dblConcert + dblGym + dblMovie + dblSport + dblVacation
        txtLeisure.Text = Format$(Convert.ToString(Income.dblRecreation), "Currency")
    End Sub
End Class