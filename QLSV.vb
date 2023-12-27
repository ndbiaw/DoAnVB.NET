Imports System.Data.SQLite
Imports System.Data
Public Class QLSV
    Dim connectionString As String = "Data Source=C:\Users\shinanaoki\source\repos\DoAnVB\csdl.db;Version=3;"
    Private Sub QLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub
    Private Sub LoadDataGridView()
        Try
            Dim query As String = "SELECT * FROM ThongTinSinhVien"
            Using connection As New SQLiteConnection(connectionString)
                Using adapter As New SQLiteDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "ThongTinSinhVien")

                    DatabaseView.DataSource = dataSet.Tables("ThongTinSinhVien")
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
                Dim selectedID = Convert.ToInt32(selectedRow.Cells("MaSinhVien").Value)

                Dim query = "DELETE FROM ThongTinSinhVien WHERE MaSinhVien = @MaSinhVien"
                Using connection As New SQLiteConnection(connectionString)
                    Using cmd As New SQLiteCommand(query, connection)
                        cmd.Parameters.AddWithValue("@MaSinhVien", selectedID)
                        connection.Open
                        cmd.ExecuteNonQuery
                    End Using
                End Using

                LoadDataGridView

                MessageBox.Show("Đã xoá dữ liệu thành công.")
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xoá dữ liệu: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Vui lòng chọn dòng cần xoá.")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Try
            Dim TenSinhVien = DatabaseView.CurrentRow.Cells("TenSinhVien").Value.ToString
            Dim MaSinhVien = DatabaseView.CurrentRow.Cells("MaSinhVien").Value.ToString
            Dim MatKhauSinhVien = DatabaseView.CurrentRow.Cells("MatKhauSinhVien").Value.ToString

            Dim query = "INSERT INTO ThongTinSinhVien (TenSinhVien, MaSinhVien, MatKhauSinhVien) VALUES (@TenSinhVien, @MaSinhVien, @MatKhauSinhVien)"
            Using connection As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@TenSinhVien", TenSinhVien)
                    cmd.Parameters.AddWithValue("@MaSinhVien", MaSinhVien)
                    cmd.Parameters.AddWithValue("@MatKhauSinhVien", MatKhauSinhVien)

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

                Using adapter As New SQLiteDataAdapter("SELECT * FROM ThongTinSinhVien", connection)
                    builder.DataAdapter = adapter
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "ThongTinSinhVien")
                    Dim changes As DataSet = dataSet.GetChanges()
                    If changes IsNot Nothing Then

                        adapter.Update(changes, "ThongTinSinhVien")
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