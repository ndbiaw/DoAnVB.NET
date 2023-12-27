Public Class MainLogin
    Private Sub btnLogSV_Click(sender As Object, e As EventArgs) Handles btnLogSV.Click
        Me.Visible = False
        Dim LoginSV As New LoginSV()
        LoginSV.Show()
    End Sub

    Private Sub btnLogTT_Click(sender As Object, e As EventArgs) Handles btnLogTT.Click
        Me.Visible = False
        Dim LoginTT As New LoginTT()
        LoginTT.Show()
    End Sub
    Private Sub btnEgg_Click(sender As Object, e As EventArgs) Handles btnEgg.Click
        MsgBox("Thực Hiện Bởi Nguyễn Duy Bách" & vbNewLine & "SV: 2722225523 - TH27.44", vbOKOnly + vbExclamation, "Bạn đã tìm thấy một Easter Egg!")
    End Sub
End Class
