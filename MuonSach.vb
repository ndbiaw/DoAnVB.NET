Imports System.Data.SQLite
Imports System.Reflection

Public Class MuonSach
    Dim connectionString As String = "Data Source=C:\Users\shinanaoki\source\repos\DoAnVB\csdl.db;Version=3;"
    Private Sub QLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub
    Private Sub LoadDataGridView()
        Try
            Dim query As String = "SELECT * FROM ThongTinSach"
            Using connection As New SQLiteConnection(connectionString)
                Using adapter As New SQLiteDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "ThongTinSach")

                    DatabaseView.DataSource = dataSet.Tables("ThongTinSach")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub btnMuon_Click(sender As Object, e As EventArgs) Handles btnMuon.Click
        Try
            If DatabaseView.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DatabaseView.SelectedRows(0)
                Dim idsach As Integer = CInt(selectedRow.Cells("IDSach").Value)
                Dim soluongConLai As Integer = CInt(selectedRow.Cells("SoLuong").Value)

                If soluongConLai > 0 Then
                    soluongConLai -= 1
                    selectedRow.Cells("SoLuong").Value = soluongConLai

                    Dim idMuon As Integer = GetMaxIDMuon() + 1
                    Dim maSinhVien As String = LocalDatabase.MSVLog
                    Dim soLuongMuon As Integer = 1

                    Dim insertQuery As String = "INSERT INTO DanhSachMuon (IDMuon, IDSach, MaSinhVien, SoLuong) VALUES (@IDMuon, @IDSach, @MaSinhVien, @SoLuong)"
                    Using connection As New SQLiteConnection(connectionString)
                        connection.Open()
                        Using command As New SQLiteCommand(insertQuery, connection)
                            command.Parameters.AddWithValue("@IDMuon", idMuon)
                            command.Parameters.AddWithValue("@IDSach", idsach)
                            command.Parameters.AddWithValue("@MaSinhVien", maSinhVien)
                            command.Parameters.AddWithValue("@SoLuong", soLuongMuon)

                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Đã mượn sách thành công!")
                Else
                    MessageBox.Show("Số lượng sách không đủ để mượn.")
                End If
            Else
                MessageBox.Show("Vui lòng chọn một sách để mượn.")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thực hiện mượn sách: " & ex.Message)
        End Try
    End Sub

    Private Function GetMaxIDMuon() As Integer
        Dim maxID As Integer = 0
        Try
            Dim query As String = "SELECT MAX(IDMuon) FROM DanhSachMuon"
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        maxID = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lấy giá trị lớn nhất từ cột IDMuon: " & ex.Message)
        End Try
        Return maxID
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Visible = False
        Dim MainLogin As New MainLogin()
        MainLogin.Show()
    End Sub
End Class