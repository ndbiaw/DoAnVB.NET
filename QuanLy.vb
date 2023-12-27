Public Class QuanLy

    Private Sub btnSV_Click(sender As Object, e As EventArgs) Handles btnSV.Click
        Me.Visible = False
        Dim QLSV As New QLSV()
        QLSV.Show()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        Me.Visible = False
        Dim QLSach As New QLSach()
        QLSach.Show()
    End Sub

    Private Sub btnSM_Click(sender As Object, e As EventArgs) Handles btnSM.Click
        Me.Visible = False
        Dim QLSachM As New QLSachM()
        QLSachM.Show()
    End Sub

    Private Sub btnTT_Click(sender As Object, e As EventArgs) Handles btnTT.Click
        Me.Visible = False
        Dim QLTT As New QLTT()
        QLTT.Show()
    End Sub
End Class