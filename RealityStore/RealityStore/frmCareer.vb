Option Strict On
Public Class frmCareer
    Dim gstrCareer As String
    Dim gdblSalary As Double
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cmbCareer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCareer.SelectedIndexChanged
        Dim MSalaries As Integer() = {3305, 4175, 3129, 5673, 2503, 3249, 3353, 5860, 3917, 1606, 4479, 4726, 4583, 2430, 2588, 2253, 1813, 2038, 1517, 4421, 4421, 5483, 1628, 2430, 3249, 2837, 2860, 1538, 2663, 6655, 4131, 4208, 2637, 5575, 2246, 4750, 4836, 4610, 6437, 2413, 4549, 1580, 4258, 2242, 2396, 3653, 2750, 2187, 2827, 2288, 4378, 7023, 4040, 2815, 3062, 3049, 6008, 4667, 4548, 3519, 3167, 2819, 4532, 4733, 3917, 3093, 6632, 3204, 2713, 2205, 3254, 1528, 3333, 2583, 4017, 5421, 2862, 6273, 2272, 4089, 2899, 3670, 3725, 2836, 4323, 2919, 2691, 3120, 3479, 6004, 3349, 3033, 2565, 3576, 2751, 2013, 5398, 4050, 5462, 2105, 3883, 2555, 4462, 2792, 3500, 2208, 8319, 4083, 1764, 4933, 5079, 2750, 6940, 3064, 3579, 5412, 2917, 3413, 4583, 2339, 5279, 4583, 5500, 4096, 4096, 4778, 1788, 2048, 4583, 4789, 2695, 2192, 1754, 2607, 4434, 2048, 4715, 4023, 2931, 1744, 2898, 3369, 3015, 4114, 4302, 2917, 4764, 4757, 2923, 3696, 1868, 2978, 2699, 4189, 2120, 2665, 4784, 4583, 2917, 3693, 4167, 3932, 4050}
        txtMonthlySalaries.Text = Format$(MSalaries(cmbCareer.SelectedIndex), "Currency")
        txtYearlySalary.Text = Format$((MSalaries(cmbCareer.SelectedIndex) * 12), "Currency")
        Income.dblMonthly = Convert.ToDouble(MSalaries(cmbCareer.SelectedIndex))
        Randomize()
        Income.dblUsableIncome = Income.dblMonthly * 0.66
        txtNetMonthly.Text = Format$((Convert.ToString(Income.dblUsableIncome)), "Currency")
        txtNetSalary.Text = Format$((Convert.ToString(Income.dblUsableIncome * 12)), "Currency")
    End Sub

    Private Sub txtMonthlySalaries_TextChanged(sender As Object, e As EventArgs) Handles txtMonthlySalaries.TextChanged

    End Sub

    Private Sub txtYearlySalary_TextChanged(sender As Object, e As EventArgs) Handles txtYearlySalary.TextChanged

    End Sub
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If cmbCareer.SelectedIndex = -1 Or cmbCareer.SelectedIndex > 162 Then
            MsgBox("You must select a valid career.", , "Input Error")
        Else
            frmMain.Show()
            Me.Hide()
            frmMain.btnCareer.Enabled = False
        End If
        Income.dblDispose = Income.dblUsableIncome - (Income.dblChildcare + Income.dblClothing + Income.dblFood + Income.dblHousingCost + Income.dblRecreation + Income.dblTransportation + Income.dblUtilities) + Income.dblNetSpouseIncome + Income.dblWheelOfFortune
        If Income.dblDispose < 0 Then
            frmMain.txtUse.Text = "-" & Format$(Convert.ToString(-Income.dblDispose), "Currency")
        Else
            frmMain.txtUse.Text = Format$(Convert.ToString(Income.dblDispose), "Currency")
        End If
        If frmMain.btnRndChild.Enabled = False And frmMain.btnRndSpouse.Enabled = False And frmMain.btnSpouseOccupation.Enabled = False Then
            frmMain.btnClothing.Enabled = True
            frmMain.btnFood.Enabled = True
            frmMain.btnHousing.Enabled = True
            frmMain.btnLeisure.Enabled = True
            frmMain.btnWheelOfFortune.Enabled = True
            frmMain.btnTransportation.Enabled = True
            If Income.intChild <> 0 Then
                frmMain.btnChildcare.Enabled = True
            End If
        End If
    End Sub
End Class