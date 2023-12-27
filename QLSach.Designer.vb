<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLSach
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
        DatabaseView = New DataGridView()
        btnAdd = New Button()
        btnDel = New Button()
        btnExit = New Button()
        btnSua = New Button()
        CType(DatabaseView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DatabaseView
        ' 
        DatabaseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DatabaseView.Location = New Point(12, 12)
        DatabaseView.Name = "DatabaseView"
        DatabaseView.RowHeadersWidth = 51
        DatabaseView.Size = New Size(420, 188)
        DatabaseView.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(24, 207)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Thêm"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDel
        ' 
        btnDel.Location = New Point(224, 207)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(94, 29)
        btnDel.TabIndex = 2
        btnDel.Text = "Xoá"
        btnDel.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(324, 207)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 3
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(124, 207)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(94, 29)
        btnSua.TabIndex = 4
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' QLSach
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(444, 253)
        Controls.Add(btnSua)
        Controls.Add(btnExit)
        Controls.Add(btnDel)
        Controls.Add(btnAdd)
        Controls.Add(DatabaseView)
        Name = "QLSach"
        Text = "Quản Lý Sách"
        CType(DatabaseView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DatabaseView As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSua As Button
End Class
