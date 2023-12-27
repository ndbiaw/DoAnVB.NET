Imports System.Data.SQLite

Public Class LoginSV
    Dim connectionString As String = "Data Source=C:\Users\shinanaoki\source\repos\DoAnVB\csdl.db;Version=3;"
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM ThongTinSinhVien WHERE MaSinhVien = @MaSinhVien AND MatKhauSV = @MatKhauSV"
            Using cmd As New SQLiteCommand(query, connection)
                cmd.Parameters.AddWithValue("@MaSinhVien", txtID.Text)
                cmd.Parameters.AddWithValue("@MatKhauSV", txtPass.Text)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        LocalDatabase.MSVLog = txtID.Text
                        LocalDatabase.TSVLog = reader("TenSinhVien").ToString()
                        Me.Visible = False
                        Dim MuonSach As New MuonSach()
                        MuonSach.Show()
                    Else
                        MessageBox.Show("Thông tin đăng nhập không đúng!")
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class