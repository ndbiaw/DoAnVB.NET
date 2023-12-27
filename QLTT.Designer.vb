<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLTT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnSua = New Button()
        btnExit = New Button()
        btnDel = New Button()
        btnAdd = New Button()
        DatabaseView = New DataGridView()
        CType(DatabaseView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(124, 207)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(94, 29)
        btnSua.TabIndex = 9
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(324, 207)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 8
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnDel
        ' 
        btnDel.Location = New Point(224, 207)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(94, 29)
        btnDel.TabIndex = 7
        btnDel.Text = "Xoá"
        btnDel.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(24, 207)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Thêm"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' DatabaseView
        ' 
        DatabaseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DatabaseView.Location = New Point(12, 12)
        DatabaseView.Name = "DatabaseView"
        DatabaseView.RowHeadersWidth = 51
        DatabaseView.Size = New Size(420, 188)
        DatabaseView.TabIndex = 5
        ' 
        ' QLTT
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(442, 253)
        Controls.Add(btnSua)
        Controls.Add(btnExit)
        Controls.Add(btnDel)
        Controls.Add(btnAdd)
        Controls.Add(DatabaseView)
        Name = "QLTT"
        Text = "Quản Lý Thủ Thư"
        CType(DatabaseView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSua As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DatabaseView As DataGridView
End Class
