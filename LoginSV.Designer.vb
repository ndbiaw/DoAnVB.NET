<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginSV
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
        lblTitle = New Label()
        lblID = New Label()
        lblPass = New Label()
        txtID = New TextBox()
        txtPass = New TextBox()
        btnLog = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTitle.Location = New Point(81, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(196, 23)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Đăng Nhập Mượn Sách"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(12, 44)
        lblID.Name = "lblID"
        lblID.Size = New Size(98, 20)
        lblID.TabIndex = 1
        lblID.Text = "Mã Sinh Viên:"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(12, 73)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(75, 20)
        lblPass.TabIndex = 2
        lblPass.Text = "Mật Khẩu:"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(116, 37)
        txtID.Name = "txtID"
        txtID.Size = New Size(125, 27)
        txtID.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(116, 66)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(125, 27)
        txtPass.TabIndex = 4
        ' 
        ' btnLog
        ' 
        btnLog.Location = New Point(257, 37)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(94, 56)
        btnLog.TabIndex = 5
        btnLog.Text = "Đăng Nhập"
        btnLog.UseVisualStyleBackColor = True
        ' 
        ' LoginSV
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
        Name = "LoginSV"
        Text = "Đăng Nhập - Sinh Viên"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLog As Button
End Class
