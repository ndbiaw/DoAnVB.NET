Imports System.Data.SQLite
Imports System.Data
Public Class QLSach
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

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If DatabaseView.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow As DataGridViewRow = DatabaseView.SelectedRows(0)
                Dim selectedID As Integer = Convert.ToInt32(selectedRow.Cells("IDSach").Value)

                Dim query As String = "DELETE FROM ThongTinSach WHERE IDSach = @IDSach"
                Using connection As New SQLiteConnection(connectionString)
                    Using cmd As New SQLiteCommand(query, connection)
                        cmd.Parameters.AddWithValue("@IDSach", selectedID)
                        connection.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                LoadDataGridView()

                MessageBox.Show("Đã xoá dữ liệu thành công.")
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xoá dữ liệu: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Vui lòng chọn dòng cần xoá.")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim tenSach As String = DatabaseView.CurrentRow.Cells("TenSach").Value.ToString()
            Dim idSach As Integer = Convert.ToInt32(DatabaseView.CurrentRow.Cells("IDSach").Value)
            Dim soLuong As Integer = Convert.ToInt32(DatabaseView.CurrentRow.Cells("SoLuong").Value)

            Dim query As String = "INSERT INTO ThongTinSach (TenSach, IDSach, SoLuong) VALUES (@TenSach, @IDSach, @SoLuong)"
            Using connection As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@TenSach", tenSach)
                    cmd.Parameters.AddWithValue("@IDSach", idSach)
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong)

                    connection.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadDataGridView()

            MessageBox.Show("Đã thêm dữ liệu thành công.")
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Visible = False
        Dim MainLogin As New MainLogin()
        MainLogin.Show()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            Dim builder As New SQLiteCommandBuilder()
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                Using adapter As New SQLiteDataAdapter("SELECT * FROM ThongTinSach", connection)
                    builder.DataAdapter = adapter
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "ThongTinSach")
                    Dim changes As DataSet = dataSet.GetChanges()
                    If changes IsNot Nothing Then

                        adapter.Update(changes, "ThongTinSach")
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
End Class