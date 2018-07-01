<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLapPhieuTraSach
	Inherits MetroFramework.Forms.MetroForm

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
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaPhieuMuonSach = New MetroFramework.Controls.MetroTextBox()
		Me.dgvNhanTraSach = New MetroFramework.Controls.MetroGrid()
		Me.btnTraSach = New MetroFramework.Controls.MetroButton()
		Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.dtNgayTraSach = New MetroFramework.Controls.MetroDateTime()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.dtpNgayTraSach = New MetroFramework.Controls.MetroDateTime()
		CType(Me.dgvNhanTraSach, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(113, 94)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(134, 19)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Mã Phiếu Mượn Sách"
		'
		'txtMaPhieuMuonSach
		'
		'
		'
		'
		Me.txtMaPhieuMuonSach.CustomButton.Image = Nothing
		Me.txtMaPhieuMuonSach.CustomButton.Location = New System.Drawing.Point(178, 1)
		Me.txtMaPhieuMuonSach.CustomButton.Name = ""
		Me.txtMaPhieuMuonSach.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMaPhieuMuonSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaPhieuMuonSach.CustomButton.TabIndex = 1
		Me.txtMaPhieuMuonSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaPhieuMuonSach.CustomButton.UseSelectable = True
		Me.txtMaPhieuMuonSach.CustomButton.Visible = False
		Me.txtMaPhieuMuonSach.Lines = New String(-1) {}
		Me.txtMaPhieuMuonSach.Location = New System.Drawing.Point(273, 94)
		Me.txtMaPhieuMuonSach.MaxLength = 32767
		Me.txtMaPhieuMuonSach.Name = "txtMaPhieuMuonSach"
		Me.txtMaPhieuMuonSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaPhieuMuonSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaPhieuMuonSach.SelectedText = ""
		Me.txtMaPhieuMuonSach.SelectionLength = 0
		Me.txtMaPhieuMuonSach.SelectionStart = 0
		Me.txtMaPhieuMuonSach.ShortcutsEnabled = True
		Me.txtMaPhieuMuonSach.Size = New System.Drawing.Size(200, 23)
		Me.txtMaPhieuMuonSach.TabIndex = 1
		Me.txtMaPhieuMuonSach.UseSelectable = True
		Me.txtMaPhieuMuonSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaPhieuMuonSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'dgvNhanTraSach
		'
		Me.dgvNhanTraSach.AllowUserToResizeRows = False
		Me.dgvNhanTraSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvNhanTraSach.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvNhanTraSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvNhanTraSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvNhanTraSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
		Me.dgvNhanTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvNhanTraSach.DefaultCellStyle = DataGridViewCellStyle8
		Me.dgvNhanTraSach.EnableHeadersVisualStyles = False
		Me.dgvNhanTraSach.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvNhanTraSach.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvNhanTraSach.Location = New System.Drawing.Point(93, 236)
		Me.dgvNhanTraSach.Name = "dgvNhanTraSach"
		Me.dgvNhanTraSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvNhanTraSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
		Me.dgvNhanTraSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvNhanTraSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvNhanTraSach.Size = New System.Drawing.Size(532, 150)
		Me.dgvNhanTraSach.TabIndex = 2
		'
		'btnTraSach
		'
		Me.btnTraSach.Location = New System.Drawing.Point(325, 421)
		Me.btnTraSach.Name = "btnTraSach"
		Me.btnTraSach.Size = New System.Drawing.Size(75, 23)
		Me.btnTraSach.TabIndex = 3
		Me.btnTraSach.Text = "Trả Sách"
		Me.btnTraSach.UseSelectable = True
		'
		'MetroGrid1
		'
		Me.MetroGrid1.AllowUserToResizeRows = False
		Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
		Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle11
		Me.MetroGrid1.EnableHeadersVisualStyles = False
		Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.MetroGrid1.Location = New System.Drawing.Point(246, 360)
		Me.MetroGrid1.Name = "MetroGrid1"
		Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
		Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.MetroGrid1.Size = New System.Drawing.Size(8, 8)
		Me.MetroGrid1.TabIndex = 4
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(113, 137)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(108, 19)
		Me.MetroLabel2.TabIndex = 6
		Me.MetroLabel2.Text = "Ngày mượn sách"
		'
		'dtNgayTraSach
		'
		Me.dtNgayTraSach.Location = New System.Drawing.Point(273, 137)
		Me.dtNgayTraSach.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtNgayTraSach.Name = "dtNgayTraSach"
		Me.dtNgayTraSach.Size = New System.Drawing.Size(200, 29)
		Me.dtNgayTraSach.TabIndex = 7
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(113, 179)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(89, 19)
		Me.MetroLabel3.TabIndex = 8
		Me.MetroLabel3.Text = "Ngày trả sách"
		'
		'dtpNgayTraSach
		'
		Me.dtpNgayTraSach.Location = New System.Drawing.Point(273, 179)
		Me.dtpNgayTraSach.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtpNgayTraSach.Name = "dtpNgayTraSach"
		Me.dtpNgayTraSach.Size = New System.Drawing.Size(200, 29)
		Me.dtpNgayTraSach.TabIndex = 9
		'
		'frmLapPhieuTraSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(698, 464)
		Me.Controls.Add(Me.dtpNgayTraSach)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.dtNgayTraSach)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroGrid1)
		Me.Controls.Add(Me.btnTraSach)
		Me.Controls.Add(Me.dgvNhanTraSach)
		Me.Controls.Add(Me.txtMaPhieuMuonSach)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Name = "frmLapPhieuTraSach"
		Me.Text = "Lập Phiếu Trả Sách"
		CType(Me.dgvNhanTraSach, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaPhieuMuonSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents dgvNhanTraSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents btnTraSach As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents dtNgayTraSach As MetroFramework.Controls.MetroDateTime
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents dtpNgayTraSach As MetroFramework.Controls.MetroDateTime
End Class
