Option Strict On
Public Class frmBegin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnStart
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim form = frmMain
        frmMain.Show()
        Me.Hide()
    End Sub
End Class