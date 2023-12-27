Imports System.Data.SQLite

Public Class LoginTT
    Dim connectionString As String = "Data Source=C:\Users\shinanaoki\source\repos\DoAnVB\csdl.db;Version=3;"
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM ThongTinThuThu WHERE IDThuThu = @IDThuThu AND MatKhauTT = @MatKhauTT"
            Using cmd As New SQLiteCommand(query, connection)
                cmd.Parameters.AddWithValue("@IDThuThu", txtID.Text)
                cmd.Parameters.AddWithValue("@MatKhauTT", txtPass.Text)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        LocalDatabase.MTTLog = txtID.Text
                        LocalDatabase.TTTLog = reader("TenThuThu").ToString()
                        Me.Visible = False
                        Dim QuanLy As New QuanLy()
                        QuanLy.Show()
                    Else
                        MessageBox.Show("Thông tin đăng nhập không đúng!")
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class