Public Class frmGender

    Private Sub btnMale_Click(sender As Object, e As EventArgs) Handles btnMale.Click
        Income.intGender = 1
        Me.Hide()
        frmTransport.Show()
    End Sub

    Private Sub btnFemale_Click(sender As Object, e As EventArgs) Handles btnFemale.Click
        Income.intGender = 2
        Me.Hide()
        frmTransport.Show()
    End Sub
End Class