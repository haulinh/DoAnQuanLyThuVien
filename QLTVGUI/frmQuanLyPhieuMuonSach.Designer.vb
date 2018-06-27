<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyPhieuMuonSach
	Inherits MetroFramework.Forms.MetroForm

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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dgvPhieuMuonSach = New MetroFramework.Controls.MetroGrid()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaPhieuMuonSach = New MetroFramework.Controls.MetroTextBox()
		Me.btnCapNhat = New MetroFramework.Controls.MetroButton()
		Me.btnXoa = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtTenSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtTheLoaiSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtTacGia = New MetroFramework.Controls.MetroTextBox()
		CType(Me.dgvPhieuMuonSach, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvPhieuMuonSach
		'
		Me.dgvPhieuMuonSach.AllowUserToResizeRows = False
		Me.dgvPhieuMuonSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvPhieuMuonSach.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvPhieuMuonSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvPhieuMuonSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvPhieuMuonSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvPhieuMuonSach.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvPhieuMuonSach.EnableHeadersVisualStyles = False
		Me.dgvPhieuMuonSach.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvPhieuMuonSach.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvPhieuMuonSach.Location = New System.Drawing.Point(34, 19)
		Me.dgvPhieuMuonSach.Name = "dgvPhieuMuonSach"
		Me.dgvPhieuMuonSach.ReadOnly = True
		Me.dgvPhieuMuonSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvPhieuMuonSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvPhieuMuonSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvPhieuMuonSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvPhieuMuonSach.Size = New System.Drawing.Size(525, 183)
		Me.dgvPhieuMuonSach.TabIndex = 0
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.dgvPhieuMuonSach)
		Me.GroupBox1.Location = New System.Drawing.Point(434, 136)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(593, 208)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Chi tiết phiếu mượn"
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(586, 84)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(132, 19)
		Me.MetroLabel1.TabIndex = 2
		Me.MetroLabel1.Text = "Mã phiếu mượn sách"
		'
		'txtMaPhieuMuonSach
		'
		'
		'
		'
		Me.txtMaPhieuMuonSach.CustomButton.Image = Nothing
		Me.txtMaPhieuMuonSach.CustomButton.Location = New System.Drawing.Point(91, 1)
		Me.txtMaPhieuMuonSach.CustomButton.Name = ""
		Me.txtMaPhieuMuonSach.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMaPhieuMuonSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaPhieuMuonSach.CustomButton.TabIndex = 1
		Me.txtMaPhieuMuonSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaPhieuMuonSach.CustomButton.UseSelectable = True
		Me.txtMaPhieuMuonSach.CustomButton.Visible = False
		Me.txtMaPhieuMuonSach.Lines = New String(-1) {}
		Me.txtMaPhieuMuonSach.Location = New System.Drawing.Point(742, 80)
		Me.txtMaPhieuMuonSach.MaxLength = 32767
		Me.txtMaPhieuMuonSach.Name = "txtMaPhieuMuonSach"
		Me.txtMaPhieuMuonSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaPhieuMuonSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaPhieuMuonSach.SelectedText = ""
		Me.txtMaPhieuMuonSach.SelectionLength = 0
		Me.txtMaPhieuMuonSach.SelectionStart = 0
		Me.txtMaPhieuMuonSach.ShortcutsEnabled = True
		Me.txtMaPhieuMuonSach.Size = New System.Drawing.Size(113, 23)
		Me.txtMaPhieuMuonSach.TabIndex = 3
		Me.txtMaPhieuMuonSach.UseSelectable = True
		Me.txtMaPhieuMuonSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaPhieuMuonSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnCapNhat
		'
		Me.btnCapNhat.Location = New System.Drawing.Point(167, 368)
		Me.btnCapNhat.Name = "btnCapNhat"
		Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
		Me.btnCapNhat.TabIndex = 4
		Me.btnCapNhat.Text = "Cập nhật"
		Me.btnCapNhat.UseSelectable = True
		'
		'btnXoa
		'
		Me.btnXoa.Location = New System.Drawing.Point(267, 368)
		Me.btnXoa.Name = "btnXoa"
		Me.btnXoa.Size = New System.Drawing.Size(75, 23)
		Me.btnXoa.TabIndex = 5
		Me.btnXoa.Text = "Xoá"
		Me.btnXoa.UseSelectable = True
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(41, 136)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(59, 19)
		Me.MetroLabel2.TabIndex = 6
		Me.MetroLabel2.Text = "Mã Sách"
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(41, 178)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(59, 19)
		Me.MetroLabel3.TabIndex = 6
		Me.MetroLabel3.Text = "Tên Sách"
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(41, 223)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(89, 19)
		Me.MetroLabel4.TabIndex = 6
		Me.MetroLabel4.Text = "Thể Loại Sách"
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = True
		Me.MetroLabel5.Location = New System.Drawing.Point(41, 276)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(49, 19)
		Me.MetroLabel5.TabIndex = 6
		Me.MetroLabel5.Text = "Tác giả"
		'
		'txtMaSach
		'
		'
		'
		'
		Me.txtMaSach.CustomButton.Image = Nothing
		Me.txtMaSach.CustomButton.Location = New System.Drawing.Point(153, 1)
		Me.txtMaSach.CustomButton.Name = ""
		Me.txtMaSach.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMaSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaSach.CustomButton.TabIndex = 1
		Me.txtMaSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaSach.CustomButton.UseSelectable = True
		Me.txtMaSach.CustomButton.Visible = False
		Me.txtMaSach.Lines = New String(-1) {}
		Me.txtMaSach.Location = New System.Drawing.Point(167, 136)
		Me.txtMaSach.MaxLength = 32767
		Me.txtMaSach.Name = "txtMaSach"
		Me.txtMaSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaSach.SelectedText = ""
		Me.txtMaSach.SelectionLength = 0
		Me.txtMaSach.SelectionStart = 0
		Me.txtMaSach.ShortcutsEnabled = True
		Me.txtMaSach.Size = New System.Drawing.Size(175, 23)
		Me.txtMaSach.TabIndex = 7
		Me.txtMaSach.UseSelectable = True
		Me.txtMaSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTenSach
		'
		'
		'
		'
		Me.txtTenSach.CustomButton.Image = Nothing
		Me.txtTenSach.CustomButton.Location = New System.Drawing.Point(153, 1)
		Me.txtTenSach.CustomButton.Name = ""
		Me.txtTenSach.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenSach.CustomButton.TabIndex = 1
		Me.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenSach.CustomButton.UseSelectable = True
		Me.txtTenSach.CustomButton.Visible = False
		Me.txtTenSach.Lines = New String(-1) {}
		Me.txtTenSach.Location = New System.Drawing.Point(167, 174)
		Me.txtTenSach.MaxLength = 32767
		Me.txtTenSach.Name = "txtTenSach"
		Me.txtTenSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenSach.SelectedText = ""
		Me.txtTenSach.SelectionLength = 0
		Me.txtTenSach.SelectionStart = 0
		Me.txtTenSach.ShortcutsEnabled = True
		Me.txtTenSach.Size = New System.Drawing.Size(175, 23)
		Me.txtTenSach.TabIndex = 7
		Me.txtTenSach.UseSelectable = True
		Me.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTenSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTheLoaiSach
		'
		'
		'
		'
		Me.txtTheLoaiSach.CustomButton.Image = Nothing
		Me.txtTheLoaiSach.CustomButton.Location = New System.Drawing.Point(153, 1)
		Me.txtTheLoaiSach.CustomButton.Name = ""
		Me.txtTheLoaiSach.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtTheLoaiSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTheLoaiSach.CustomButton.TabIndex = 1
		Me.txtTheLoaiSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTheLoaiSach.CustomButton.UseSelectable = True
		Me.txtTheLoaiSach.CustomButton.Visible = False
		Me.txtTheLoaiSach.Lines = New String(-1) {}
		Me.txtTheLoaiSach.Location = New System.Drawing.Point(167, 223)
		Me.txtTheLoaiSach.MaxLength = 32767
		Me.txtTheLoaiSach.Name = "txtTheLoaiSach"
		Me.txtTheLoaiSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTheLoaiSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTheLoaiSach.SelectedText = ""
		Me.txtTheLoaiSach.SelectionLength = 0
		Me.txtTheLoaiSach.SelectionStart = 0
		Me.txtTheLoaiSach.ShortcutsEnabled = True
		Me.txtTheLoaiSach.Size = New System.Drawing.Size(175, 23)
		Me.txtTheLoaiSach.TabIndex = 7
		Me.txtTheLoaiSach.UseSelectable = True
		Me.txtTheLoaiSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTheLoaiSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTacGia
		'
		'
		'
		'
		Me.txtTacGia.CustomButton.Image = Nothing
		Me.txtTacGia.CustomButton.Location = New System.Drawing.Point(153, 1)
		Me.txtTacGia.CustomButton.Name = ""
		Me.txtTacGia.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTacGia.CustomButton.TabIndex = 1
		Me.txtTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTacGia.CustomButton.UseSelectable = True
		Me.txtTacGia.CustomButton.Visible = False
		Me.txtTacGia.Lines = New String(-1) {}
		Me.txtTacGia.Location = New System.Drawing.Point(167, 272)
		Me.txtTacGia.MaxLength = 32767
		Me.txtTacGia.Name = "txtTacGia"
		Me.txtTacGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTacGia.SelectedText = ""
		Me.txtTacGia.SelectionLength = 0
		Me.txtTacGia.SelectionStart = 0
		Me.txtTacGia.ShortcutsEnabled = True
		Me.txtTacGia.Size = New System.Drawing.Size(175, 23)
		Me.txtTacGia.TabIndex = 7
		Me.txtTacGia.UseSelectable = True
		Me.txtTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTacGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'frmQuanLyPhieuMuonSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1075, 461)
		Me.Controls.Add(Me.txtTacGia)
		Me.Controls.Add(Me.txtTheLoaiSach)
		Me.Controls.Add(Me.txtTenSach)
		Me.Controls.Add(Me.txtMaSach)
		Me.Controls.Add(Me.MetroLabel5)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.btnXoa)
		Me.Controls.Add(Me.btnCapNhat)
		Me.Controls.Add(Me.txtMaPhieuMuonSach)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmQuanLyPhieuMuonSach"
		Me.Text = "frmQuanLyPhieuMuonSach"
		CType(Me.dgvPhieuMuonSach, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvPhieuMuonSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaPhieuMuonSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnCapNhat As MetroFramework.Controls.MetroButton
	Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTenSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTheLoaiSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTacGia As MetroFramework.Controls.MetroTextBox
End Class
