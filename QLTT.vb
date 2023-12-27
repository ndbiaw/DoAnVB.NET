Imports System.Data.SQLite
Imports System.Data
Public Class QLTT
    Dim connectionString As String = "Data Source=C:\Users\shinanaoki\source\repos\DoAnVB\csdl.db;Version=3;"
    Private Sub QLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub
    Private Sub LoadDataGridView()
        Try
            Dim query As String = "SELECT * FROM ThongTinThuThu"
            Using connection As New SQLiteConnection(connectionString)
                Using adapter As New SQLiteDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "ThongTinThuThu")

                    DatabaseView.DataSource = dataSet.Tables("ThongTinThuThu")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs)
        If DatabaseView.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow = DatabaseView.SelectedRows(0)
                Dim selectedID = Convert.ToInt32(selectedRow.Cells("IDThuThu").Value)
                If MTTLog = selectedID Then
                    MsgBox("Bạn không thể xoá chính bạn!")
                Else
                    Dim query = "DELETE FROM ThongTinThuThu WHERE IDThuThu = @IDThuThu"
                    Using connection As New SQLiteConnection(connectionString)
                        Using cmd As New SQLiteCommand(query, connection)
                            cmd.Parameters.AddWithValue("@IDThuThu", selectedID)
                            connection.Open
                            cmd.ExecuteNonQuery
                        End Using
                    End Using

                    LoadDataGridView

                    MessageBox.Show("Đã xoá dữ liệu thành công.")
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xoá dữ liệu: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Vui lòng chọn dòng cần xoá.")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Try
            Dim TenThuThu = DatabaseView.CurrentRow.Cells("TenThuThu").Value.ToString
            Dim IDThuThu = DatabaseView.CurrentRow.Cells("IDThuThu").Value.ToString
            Dim MatKhauTT = DatabaseView.CurrentRow.Cells("MatKhauTT").Value.ToString

            Dim query = "INSERT INTO ThongTinThuThu (TenThuThu, IDThuThu, MatKhauTT) VALUES (@TenThuThu, @IDThuThu, @MatKhauTT)"
            Using connection As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@TenThuThu", TenThuThu)
                    cmd.Parameters.AddWithValue("@IDThuThu", IDThuThu)
                    cmd.Parameters.AddWithValue("@MatKhauTT", MatKhauTT)

                    connection.Open
                    cmd.ExecuteNonQuery
                End Using
            End Using

            LoadDataGridView

            MessageBox.Show("Đã thêm dữ liệu thành công.")
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            Dim builder As New SQLiteCommandBuilder()
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                Using adapter As New SQLiteDataAdapter("SELECT * FROM ThongTinThuThu", connection)
                    builder.DataAdapter = adapter
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "ThongTinThuThu")
                    Dim changes As DataSet = dataSet.GetChanges()
                    If changes IsNot Nothing Then

                        adapter.Update(changes, "ThongTinThuThu")
                        dataSet.AcceptChanges()
                        MessageBox.Show("Cập nhật thành công!")
                    Else
                        MessageBox.Show("Không có thay đổi để cập nhật!")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi cập nhật dữ liệu: " & ex.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Visible = False
        Dim MainLogin As New MainLogin
        MainLogin.Show
    End Sub
End Class