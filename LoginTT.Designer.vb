<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginTT
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
        btnLog = New Button()
        txtPass = New TextBox()
        txtID = New TextBox()
        lblPass = New Label()
        lblID = New Label()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' btnLog
        ' 
        btnLog.Location = New Point(259, 43)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(94, 56)
        btnLog.TabIndex = 11
        btnLog.Text = "Đăng Nhập"
        btnLog.UseVisualStyleBackColor = True
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(118, 72)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(125, 27)
        txtPass.TabIndex = 10
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(118, 43)
        txtID.Name = "txtID"
        txtID.Size = New Size(125, 27)
        txtID.TabIndex = 9
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(14, 79)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(75, 20)
        lblPass.TabIndex = 8
        lblPass.Text = "Mật Khẩu:"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(14, 50)
        lblID.Name = "lblID"
        lblID.Size = New Size(90, 20)
        lblID.TabIndex = 7
        lblID.Text = "Mã Thủ Thư:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTitle.Location = New Point(83, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(171, 23)
        lblTitle.TabIndex = 6
        lblTitle.Text = "Đăng Nhập Quản Lý"
        ' 
        ' LoginTT
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(367, 114)
        Controls.Add(btnLog)
        Controls.Add(txtPass)
        Controls.Add(txtID)
        Controls.Add(lblPass)
        Controls.Add(lblID)
        Controls.Add(lblTitle)
        Name = "LoginTT"
        Text = "LoginTT"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLog As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblTitle As Label
End Class
