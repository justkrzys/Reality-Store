Option Strict On
Public Class frmMain

    Private Sub btnCareer_Click(sender As Object, e As EventArgs) Handles btnCareer.Click
        frmCareer.Show()
        Me.Hide()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUse.Text = Format$(Convert.ToString(Income.dblMonthly), "Currency")
        If btnCareer.Enabled = False And btnChildcare.Enabled = False And btnClothing.Enabled = False And btnFood.Enabled = False And btnHousing.Enabled = False And btnLeisure.Enabled = False And btnTransportation.Enabled = False And btnUtilities.Enabled = False And btnWheelOfFortune.Enabled = False Then
            btnEnding.Enabled = True
        End If
    End Sub

    Private Sub txtUse_TextChanged(sender As Object, e As EventArgs) Handles txtUse.TextChanged

    End Sub

    Private Sub btnRndSpouse_Click(sender As Object, e As EventArgs) Handles btnRndSpouse.Click
        Randomize()
        Income.intSpouse = CInt(Rnd() * 1)
        btnRndSpouse.Enabled = False
        If Income.intSpouse = 0 Then
            txtRndSpouse.Text = "Not married"
            btnCareer.Focus()
        Else
            txtRndSpouse.Text = "Married"
            btnSpouseOccupation.Visible = True
            cmbSpouse.Visible = True
            txtSpouseIncome.Visible = True
            lblSpouseIncome.Visible = True
            btnSpouseOccupation.Focus()
            btnSpouseOccupation.Enabled = True
        End If
        If btnCareer.Enabled = False And btnRndChild.Enabled = False And btnSpouseOccupation.Enabled = False Then
            btnClothing.Enabled = True
            btnFood.Enabled = True
            btnHousing.Enabled = True
            btnLeisure.Enabled = True
            btnWheelOfFortune.Enabled = True
            btnTransportation.Enabled = True
            If Income.intChild <> 0 Then
                btnChildcare.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnRndChild_Click(sender As Object, e As EventArgs) Handles btnRndChild.Click
        Randomize()
        Income.intChild = CInt(Rnd() * 2)
        btnRndChild.Enabled = False
        If Income.intChild = 0 Then
            txtRndChild.Text = "No children"
            btnCareer.Focus()
        ElseIf Income.intChild = 1 Then
            txtRndChild.Text = "One child"

            btnCareer.Focus()
        ElseIf Income.intChild = 2 Then
            txtRndChild.Text = "Two children"

            btnCareer.Focus()
        End If
        If btnCareer.Enabled = False And btnRndSpouse.Enabled = False And btnSpouseOccupation.Enabled = False Then
            btnClothing.Enabled = True
            btnFood.Enabled = True
            btnHousing.Enabled = True
            btnLeisure.Enabled = True
            btnWheelOfFortune.Enabled = True
            btnTransportation.Enabled = True
            If Income.intChild <> 0 Then
                btnChildcare.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSpouseOccupation_Click(sender As Object, e As EventArgs) Handles btnSpouseOccupation.Click
        Randomize()
        Income.intSpouseOccupation = CInt(Rnd() * 163)
        cmbSpouse.SelectedIndex = Income.intSpouseOccupation
        btnSpouseOccupation.Enabled = False
        Income.dblDispose = Income.dblUsableIncome - (Income.dblChildcare + Income.dblClothing + Income.dblFood + Income.dblHousingCost + Income.dblRecreation + Income.dblTransportation + Income.dblUtilities) + Income.dblNetSpouseIncome + Income.dblWheelOfFortune
        txtUse.Text = Format$(Convert.ToString(Income.dblDispose), "Currency")
        If btnCareer.Enabled = False And btnRndSpouse.Enabled = False And btnRndChild.Enabled = False Then
            btnClothing.Enabled = True
            btnFood.Enabled = True
            btnHousing.Enabled = True
            btnLeisure.Enabled = True
            btnWheelOfFortune.Enabled = True
            btnTransportation.Enabled = True
        End If
    End Sub
    Private Sub txtSpouseIncome_TextChanged(sender As Object, e As EventArgs) Handles txtSpouseIncome.TextChanged

    End Sub
    Private Sub cmbSpouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSpouse.SelectedIndexChanged
        Dim SSalaries As Integer() = {3305, 4175, 3129, 5673, 2503, 3249, 3353, 5860, 3917, 1606, 4479, 4726, 4583, 2430, 2588, 2253, 1813, 2038, 1517, 4421, 4421, 5483, 1628, 2430, 3249, 2837, 2860, 1538, 2663, 6655, 4131, 4208, 2637, 5575, 2246, 4750, 4836, 4610, 6437, 2413, 4549, 1580, 4258, 2242, 2396, 3653, 2750, 2187, 2827, 2288, 4378, 7023, 4040, 2815, 3062, 3049, 6008, 4667, 4548, 3519, 3167, 2819, 4532, 4733, 3917, 3093, 6632, 3204, 2713, 2205, 3254, 1528, 3333, 2583, 4017, 5421, 2862, 6273, 2272, 4089, 2899, 3670, 3725, 2836, 4323, 2919, 2691, 3120, 3479, 6004, 3349, 3033, 2565, 3576, 2751, 2013, 5398, 4050, 5462, 2105, 3883, 2555, 4462, 2792, 3500, 2208, 8319, 4083, 1764, 4933, 5079, 2750, 6940, 3064, 3579, 5412, 2917, 3413, 4583, 2339, 5279, 4583, 5500, 4096, 4096, 4778, 1788, 2048, 4583, 4789, 2695, 2192, 1754, 2607, 4434, 2048, 4715, 4023, 2931, 1744, 2898, 3369, 3015, 4114, 4302, 2917, 4764, 4757, 2923, 3696, 1868, 2978, 2699, 4189, 2120, 2665, 4784, 4583, 2917, 3693, 4167, 3932, 4050, 0}
        txtSpouseIncome.Text = Format$((SSalaries(cmbSpouse.SelectedIndex) * 0.66), "Currency")
        Income.dblNetSpouseIncome = SSalaries(cmbSpouse.SelectedIndex) * 0.66
    End Sub
    Private Sub btnHousing_Click(sender As Object, e As EventArgs) Handles btnHousing.Click
        Dim form = New frmHousing
        frmHousing.Show()
        Me.Hide()
    End Sub

    Private Sub btnUtilities_Click(sender As Object, e As EventArgs) Handles btnUtilities.Click
        Dim form = New frmUtilities
        frmUtilities.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransportation_Click(sender As Object, e As EventArgs) Handles btnTransportation.Click
        frmTransport.Show()
        Me.Hide()
    End Sub

    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        frmFood.Show()
        Me.Hide()
    End Sub

    Private Sub btnClothing_Click(sender As Object, e As EventArgs) Handles btnClothing.Click
        frmClothing.Show()
        Me.Hide()
    End Sub

    Private Sub btnWheelOfFortune_Click(sender As Object, e As EventArgs) Handles btnWheelOfFortune.Click
        frmWheel.Show()
        Me.Hide()
    End Sub

    Private Sub btnLeisure_Click(sender As Object, e As EventArgs) Handles btnLeisure.Click
        frmLeisure.Show()
        Me.Hide()
    End Sub

    Private Sub btnChildcare_Click(sender As Object, e As EventArgs) Handles btnChildcare.Click
        frmChild.Show()
        Me.Hide()
    End Sub

    Private Sub btnEnding_Click(sender As Object, e As EventArgs) Handles btnEnding.Click
        frmEnding.Show()
        Me.Hide()
    End Sub
End Class