<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLy
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
        btnSV = New Button()
        btnS = New Button()
        btnSM = New Button()
        btnTT = New Button()
        qlTitle = New Label()
        SuspendLayout()
        ' 
        ' btnSV
        ' 
        btnSV.Location = New Point(12, 53)
        btnSV.Name = "btnSV"
        btnSV.Size = New Size(94, 29)
        btnSV.TabIndex = 0
        btnSV.Text = "Sinh Viên"
        btnSV.UseVisualStyleBackColor = True
        ' 
        ' btnS
        ' 
        btnS.Location = New Point(112, 53)
        btnS.Name = "btnS"
        btnS.Size = New Size(94, 29)
        btnS.TabIndex = 1
        btnS.Text = "Sách"
        btnS.UseVisualStyleBackColor = True
        ' 
        ' btnSM
        ' 
        btnSM.Location = New Point(212, 53)
        btnSM.Name = "btnSM"
        btnSM.Size = New Size(94, 29)
        btnSM.TabIndex = 2
        btnSM.Text = "Sách Mượn"
        btnSM.UseVisualStyleBackColor = True
        ' 
        ' btnTT
        ' 
        btnTT.Location = New Point(312, 53)
        btnTT.Name = "btnTT"
        btnTT.Size = New Size(94, 29)
        btnTT.TabIndex = 3
        btnTT.Text = "Thủ Thư"
        btnTT.UseVisualStyleBackColor = True
        ' 
        ' qlTitle
        ' 
        qlTitle.AutoSize = True
        qlTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        qlTitle.Location = New Point(19, 9)
        qlTitle.Name = "qlTitle"
        qlTitle.Size = New Size(379, 35)
        qlTitle.TabIndex = 4
        qlTitle.Text = "Chọn Danh Mục Muốn Quản Lý"
        ' 
        ' QuanLy
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 102)
        Controls.Add(qlTitle)
        Controls.Add(btnTT)
        Controls.Add(btnSM)
        Controls.Add(btnS)
        Controls.Add(btnSV)
        Name = "QuanLy"
        Text = "Tuỳ Chọn Quản Lý"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSV As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnSM As Button
    Friend WithEvents btnTT As Button
    Friend WithEvents qlTitle As Label
End Class
