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
		Me.txtTheLoaiSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtTacGia = New MetroFramework.Controls.MetroTextBox()
		Me.txtMaSach = New MetroFramework.Controls.MetroTextBox()
		Me.btnCapNhat = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.btnXoa = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.txtTenSach = New MetroFramework.Controls.MetroTextBox()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaPhieuMuonSach = New MetroFramework.Controls.MetroTextBox()
		Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.dtpNgayTraSach = New MetroFramework.Controls.MetroDateTime()
		Me.dtpNgayMuonSach = New MetroFramework.Controls.MetroDateTime()
		Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
		Me.btnCapNhapPhieuMuonSach = New MetroFramework.Controls.MetroButton()
		Me.btnXoaPhieuMuonSach = New MetroFramework.Controls.MetroButton()
		CType(Me.dgvPhieuMuonSach, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
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
		Me.dgvPhieuMuonSach.Location = New System.Drawing.Point(6, 130)
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
		Me.dgvPhieuMuonSach.Size = New System.Drawing.Size(515, 182)
		Me.dgvPhieuMuonSach.TabIndex = 0
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtTheLoaiSach)
		Me.GroupBox1.Controls.Add(Me.dgvPhieuMuonSach)
		Me.GroupBox1.Controls.Add(Me.txtTacGia)
		Me.GroupBox1.Controls.Add(Me.txtMaSach)
		Me.GroupBox1.Controls.Add(Me.btnCapNhat)
		Me.GroupBox1.Controls.Add(Me.MetroLabel3)
		Me.GroupBox1.Controls.Add(Me.MetroLabel5)
		Me.GroupBox1.Controls.Add(Me.btnXoa)
		Me.GroupBox1.Controls.Add(Me.MetroLabel4)
		Me.GroupBox1.Controls.Add(Me.MetroLabel2)
		Me.GroupBox1.Controls.Add(Me.txtTenSach)
		Me.GroupBox1.Location = New System.Drawing.Point(46, 254)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(527, 318)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Chi tiết phiếu mượn"
		'
		'txtTheLoaiSach
		'
		'
		'
		'
		Me.txtTheLoaiSach.CustomButton.Image = Nothing
		Me.txtTheLoaiSach.CustomButton.Location = New System.Drawing.Point(51, 1)
		Me.txtTheLoaiSach.CustomButton.Name = ""
		Me.txtTheLoaiSach.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtTheLoaiSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTheLoaiSach.CustomButton.TabIndex = 1
		Me.txtTheLoaiSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTheLoaiSach.CustomButton.UseSelectable = True
		Me.txtTheLoaiSach.CustomButton.Visible = False
		Me.txtTheLoaiSach.Lines = New String(-1) {}
		Me.txtTheLoaiSach.Location = New System.Drawing.Point(324, 41)
		Me.txtTheLoaiSach.MaxLength = 32767
		Me.txtTheLoaiSach.Name = "txtTheLoaiSach"
		Me.txtTheLoaiSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTheLoaiSach.ReadOnly = True
		Me.txtTheLoaiSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTheLoaiSach.SelectedText = ""
		Me.txtTheLoaiSach.SelectionLength = 0
		Me.txtTheLoaiSach.SelectionStart = 0
		Me.txtTheLoaiSach.ShortcutsEnabled = True
		Me.txtTheLoaiSach.Size = New System.Drawing.Size(90, 23)
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
		Me.txtTacGia.CustomButton.Location = New System.Drawing.Point(51, 1)
		Me.txtTacGia.CustomButton.Name = ""
		Me.txtTacGia.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTacGia.CustomButton.TabIndex = 1
		Me.txtTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTacGia.CustomButton.UseSelectable = True
		Me.txtTacGia.CustomButton.Visible = False
		Me.txtTacGia.Lines = New String(-1) {}
		Me.txtTacGia.Location = New System.Drawing.Point(324, 81)
		Me.txtTacGia.MaxLength = 32767
		Me.txtTacGia.Name = "txtTacGia"
		Me.txtTacGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTacGia.ReadOnly = True
		Me.txtTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTacGia.SelectedText = ""
		Me.txtTacGia.SelectionLength = 0
		Me.txtTacGia.SelectionStart = 0
		Me.txtTacGia.ShortcutsEnabled = True
		Me.txtTacGia.Size = New System.Drawing.Size(90, 23)
		Me.txtTacGia.TabIndex = 7
		Me.txtTacGia.UseSelectable = True
		Me.txtTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTacGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtMaSach
		'
		'
		'
		'
		Me.txtMaSach.CustomButton.Image = Nothing
		Me.txtMaSach.CustomButton.Location = New System.Drawing.Point(51, 1)
		Me.txtMaSach.CustomButton.Name = ""
		Me.txtMaSach.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtMaSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaSach.CustomButton.TabIndex = 1
		Me.txtMaSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaSach.CustomButton.UseSelectable = True
		Me.txtMaSach.CustomButton.Visible = False
		Me.txtMaSach.Lines = New String(-1) {}
		Me.txtMaSach.Location = New System.Drawing.Point(88, 41)
		Me.txtMaSach.MaxLength = 32767
		Me.txtMaSach.Name = "txtMaSach"
		Me.txtMaSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaSach.SelectedText = ""
		Me.txtMaSach.SelectionLength = 0
		Me.txtMaSach.SelectionStart = 0
		Me.txtMaSach.ShortcutsEnabled = True
		Me.txtMaSach.Size = New System.Drawing.Size(90, 23)
		Me.txtMaSach.TabIndex = 7
		Me.txtMaSach.UseSelectable = True
		Me.txtMaSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnCapNhat
		'
		Me.btnCapNhat.Location = New System.Drawing.Point(438, 41)
		Me.btnCapNhat.Name = "btnCapNhat"
		Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
		Me.btnCapNhat.TabIndex = 4
		Me.btnCapNhat.Text = "Cập nhật"
		Me.btnCapNhat.UseSelectable = True
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(18, 83)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(57, 19)
		Me.MetroLabel3.TabIndex = 6
		Me.MetroLabel3.Text = "Tên sách"
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = True
		Me.MetroLabel5.Location = New System.Drawing.Point(230, 83)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(49, 19)
		Me.MetroLabel5.TabIndex = 6
		Me.MetroLabel5.Text = "Tác giả"
		'
		'btnXoa
		'
		Me.btnXoa.Location = New System.Drawing.Point(438, 81)
		Me.btnXoa.Name = "btnXoa"
		Me.btnXoa.Size = New System.Drawing.Size(75, 23)
		Me.btnXoa.TabIndex = 5
		Me.btnXoa.Text = "Xoá"
		Me.btnXoa.UseSelectable = True
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(230, 41)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(84, 19)
		Me.MetroLabel4.TabIndex = 6
		Me.MetroLabel4.Text = "Thể loại sách"
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(18, 41)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(57, 19)
		Me.MetroLabel2.TabIndex = 6
		Me.MetroLabel2.Text = "Mã sách"
		'
		'txtTenSach
		'
		'
		'
		'
		Me.txtTenSach.CustomButton.Image = Nothing
		Me.txtTenSach.CustomButton.Location = New System.Drawing.Point(51, 1)
		Me.txtTenSach.CustomButton.Name = ""
		Me.txtTenSach.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenSach.CustomButton.TabIndex = 1
		Me.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenSach.CustomButton.UseSelectable = True
		Me.txtTenSach.CustomButton.Visible = False
		Me.txtTenSach.Lines = New String(-1) {}
		Me.txtTenSach.Location = New System.Drawing.Point(88, 81)
		Me.txtTenSach.MaxLength = 32767
		Me.txtTenSach.Name = "txtTenSach"
		Me.txtTenSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenSach.ReadOnly = True
		Me.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenSach.SelectedText = ""
		Me.txtTenSach.SelectionLength = 0
		Me.txtTenSach.SelectionStart = 0
		Me.txtTenSach.ShortcutsEnabled = True
		Me.txtTenSach.Size = New System.Drawing.Size(90, 23)
		Me.txtTenSach.TabIndex = 7
		Me.txtTenSach.UseSelectable = True
		Me.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTenSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(191, 73)
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
		Me.txtMaPhieuMuonSach.CustomButton.Location = New System.Drawing.Point(68, 1)
		Me.txtMaPhieuMuonSach.CustomButton.Name = ""
		Me.txtMaPhieuMuonSach.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtMaPhieuMuonSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaPhieuMuonSach.CustomButton.TabIndex = 1
		Me.txtMaPhieuMuonSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaPhieuMuonSach.CustomButton.UseSelectable = True
		Me.txtMaPhieuMuonSach.CustomButton.Visible = False
		Me.txtMaPhieuMuonSach.Lines = New String(-1) {}
		Me.txtMaPhieuMuonSach.Location = New System.Drawing.Point(332, 73)
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
		'MetroLabel6
		'
		Me.MetroLabel6.AutoSize = True
		Me.MetroLabel6.Location = New System.Drawing.Point(18, 37)
		Me.MetroLabel6.Name = "MetroLabel6"
		Me.MetroLabel6.Size = New System.Drawing.Size(108, 19)
		Me.MetroLabel6.TabIndex = 6
		Me.MetroLabel6.Text = "Ngày mượn sách"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.dtpNgayTraSach)
		Me.GroupBox2.Controls.Add(Me.dtpNgayMuonSach)
		Me.GroupBox2.Controls.Add(Me.MetroLabel7)
		Me.GroupBox2.Controls.Add(Me.MetroLabel6)
		Me.GroupBox2.Controls.Add(Me.btnCapNhapPhieuMuonSach)
		Me.GroupBox2.Location = New System.Drawing.Point(123, 110)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.GroupBox2.Size = New System.Drawing.Size(383, 138)
		Me.GroupBox2.TabIndex = 8
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Phiếu mượn sách"
		'
		'dtpNgayTraSach
		'
		Me.dtpNgayTraSach.Location = New System.Drawing.Point(127, 85)
		Me.dtpNgayTraSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.dtpNgayTraSach.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtpNgayTraSach.Name = "dtpNgayTraSach"
		Me.dtpNgayTraSach.Size = New System.Drawing.Size(151, 30)
		Me.dtpNgayTraSach.TabIndex = 7
		'
		'dtpNgayMuonSach
		'
		Me.dtpNgayMuonSach.Location = New System.Drawing.Point(127, 37)
		Me.dtpNgayMuonSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.dtpNgayMuonSach.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtpNgayMuonSach.Name = "dtpNgayMuonSach"
		Me.dtpNgayMuonSach.Size = New System.Drawing.Size(151, 30)
		Me.dtpNgayMuonSach.TabIndex = 7
		'
		'MetroLabel7
		'
		Me.MetroLabel7.AutoSize = True
		Me.MetroLabel7.Location = New System.Drawing.Point(18, 85)
		Me.MetroLabel7.Name = "MetroLabel7"
		Me.MetroLabel7.Size = New System.Drawing.Size(89, 19)
		Me.MetroLabel7.TabIndex = 6
		Me.MetroLabel7.Text = "Ngày trả sách"
		'
		'btnCapNhapPhieuMuonSach
		'
		Me.btnCapNhapPhieuMuonSach.Location = New System.Drawing.Point(296, 37)
		Me.btnCapNhapPhieuMuonSach.Name = "btnCapNhapPhieuMuonSach"
		Me.btnCapNhapPhieuMuonSach.Size = New System.Drawing.Size(75, 23)
		Me.btnCapNhapPhieuMuonSach.TabIndex = 4
		Me.btnCapNhapPhieuMuonSach.Text = "Cập nhật"
		Me.btnCapNhapPhieuMuonSach.UseSelectable = True
		'
		'btnXoaPhieuMuonSach
		'
		Me.btnXoaPhieuMuonSach.Location = New System.Drawing.Point(276, 607)
		Me.btnXoaPhieuMuonSach.Name = "btnXoaPhieuMuonSach"
		Me.btnXoaPhieuMuonSach.Size = New System.Drawing.Size(75, 23)
		Me.btnXoaPhieuMuonSach.TabIndex = 5
		Me.btnXoaPhieuMuonSach.Text = "Xoá"
		Me.btnXoaPhieuMuonSach.UseSelectable = True
		'
		'frmQuanLyPhieuMuonSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(624, 640)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.txtMaPhieuMuonSach)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnXoaPhieuMuonSach)
		Me.Name = "frmQuanLyPhieuMuonSach"
		Me.Text = "Quản Lý Phiếu Mượn Sách"
		CType(Me.dgvPhieuMuonSach,System.ComponentModel.ISupportInitialize).EndInit
		Me.GroupBox1.ResumeLayout(false)
		Me.GroupBox1.PerformLayout
		Me.GroupBox2.ResumeLayout(false)
		Me.GroupBox2.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents dgvPhieuMuonSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaPhieuMuonSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTheLoaiSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTacGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtMaSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnCapNhat As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtTenSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents dtpNgayTraSach As MetroFramework.Controls.MetroDateTime
	Friend WithEvents dtpNgayMuonSach As MetroFramework.Controls.MetroDateTime
	Friend WithEvents btnCapNhapPhieuMuonSach As MetroFramework.Controls.MetroButton
	Friend WithEvents btnXoaPhieuMuonSach As MetroFramework.Controls.MetroButton
End Class
