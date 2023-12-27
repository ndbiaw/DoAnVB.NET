<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuonSach
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
        btnMuon = New Button()
        btnExit = New Button()
        CType(DatabaseView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DatabaseView
        ' 
        DatabaseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DatabaseView.Location = New Point(0, 0)
        DatabaseView.Name = "DatabaseView"
        DatabaseView.RowHeadersWidth = 51
        DatabaseView.Size = New Size(300, 188)
        DatabaseView.TabIndex = 0
        ' 
        ' btnMuon
        ' 
        btnMuon.Location = New Point(12, 194)
        btnMuon.Name = "btnMuon"
        btnMuon.Size = New Size(94, 29)
        btnMuon.TabIndex = 1
        btnMuon.Text = "Mượn"
        btnMuon.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(194, 194)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 2
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' MuonSach
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(300, 232)
        Controls.Add(btnExit)
        Controls.Add(btnMuon)
        Controls.Add(DatabaseView)
        Name = "MuonSach"
        Text = "MuonSach"
        CType(DatabaseView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DatabaseView As DataGridView
    Friend WithEvents btnMuon As Button
    Friend WithEvents btnExit As Button
End Class
