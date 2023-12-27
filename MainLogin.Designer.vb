<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LoginTitle = New Label()
        btnLogSV = New Button()
        btnLogTT = New Button()
        btnEgg = New Button()
        SuspendLayout()
        ' 
        ' LoginTitle
        ' 
        LoginTitle.AutoSize = True
        LoginTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        LoginTitle.Location = New Point(112, 2)
        LoginTitle.Name = "LoginTitle"
        LoginTitle.Size = New Size(147, 35)
        LoginTitle.TabIndex = 0
        LoginTitle.Text = "Đăng Nhập"
        ' 
        ' btnLogSV
        ' 
        btnLogSV.Location = New Point(12, 47)
        btnLogSV.Name = "btnLogSV"
        btnLogSV.Size = New Size(144, 29)
        btnLogSV.TabIndex = 1
        btnLogSV.Text = "Tôi Là Sinh Viên"
        btnLogSV.UseVisualStyleBackColor = True
        ' 
        ' btnLogTT
        ' 
        btnLogTT.Location = New Point(218, 47)
        btnLogTT.Name = "btnLogTT"
        btnLogTT.Size = New Size(144, 29)
        btnLogTT.TabIndex = 2
        btnLogTT.Text = "Tôi Là Thủ Thư"
        btnLogTT.UseVisualStyleBackColor = True
        ' 
        ' btnEgg
        ' 
        btnEgg.Location = New Point(171, 47)
        btnEgg.Name = "btnEgg"
        btnEgg.Size = New Size(32, 29)
        btnEgg.TabIndex = 3
        btnEgg.Text = ChrW(55358) & ChrW(56666)
        btnEgg.UseVisualStyleBackColor = True
        ' 
        ' MainLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 92)
        Controls.Add(btnEgg)
        Controls.Add(btnLogTT)
        Controls.Add(btnLogSV)
        Controls.Add(LoginTitle)
        Name = "MainLogin"
        Text = "Đăng Nhập - Thư Viện HUBT"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginTitle As Label
    Friend WithEvents btnLogSV As Button
    Friend WithEvents btnLogTT As Button
    Friend WithEvents btnEgg As Button

End Class
