<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySach
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
		Me.cbTinhTrangSach = New MetroFramework.Controls.MetroComboBox()
		Me.cbTheLoaiSachCapNhap = New MetroFramework.Controls.MetroComboBox()
		Me.dtNgayNhap = New MetroFramework.Controls.MetroDateTime()
		Me.txtTriGia = New MetroFramework.Controls.MetroTextBox()
		Me.txtNhaXuatBan = New MetroFramework.Controls.MetroTextBox()
		Me.txtTacGia = New MetroFramework.Controls.MetroTextBox()
		Me.txtTenSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtMaSach = New MetroFramework.Controls.MetroTextBox()
		Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.btnXoa = New MetroFramework.Controls.MetroButton()
		Me.btnCapNhat = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
		Me.cbTheLoaiSach = New MetroFramework.Controls.MetroComboBox()
		Me.dgvListSach = New MetroFramework.Controls.MetroGrid()
		Me.cbNamXuatBan = New MetroFramework.Controls.MetroComboBox()
		CType(Me.dgvListSach,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'cbTinhTrangSach
		'
		Me.cbTinhTrangSach.FormattingEnabled = True
		Me.cbTinhTrangSach.ItemHeight = 23
		Me.cbTinhTrangSach.Items.AddRange(New Object() {"Rỗng"})
		Me.cbTinhTrangSach.Location = New System.Drawing.Point(153, 372)
		Me.cbTinhTrangSach.Name = "cbTinhTrangSach"
		Me.cbTinhTrangSach.Size = New System.Drawing.Size(200, 29)
		Me.cbTinhTrangSach.TabIndex = 25
		Me.cbTinhTrangSach.UseSelectable = True
		'
		'cbTheLoaiSachCapNhap
		'
		Me.cbTheLoaiSachCapNhap.FormattingEnabled = True
		Me.cbTheLoaiSachCapNhap.ItemHeight = 23
		Me.cbTheLoaiSachCapNhap.Items.AddRange(New Object() {"1", "2"})
		Me.cbTheLoaiSachCapNhap.Location = New System.Drawing.Point(153, 144)
		Me.cbTheLoaiSachCapNhap.Name = "cbTheLoaiSachCapNhap"
		Me.cbTheLoaiSachCapNhap.Size = New System.Drawing.Size(200, 29)
		Me.cbTheLoaiSachCapNhap.TabIndex = 23
		Me.cbTheLoaiSachCapNhap.UseSelectable = True
		'
		'dtNgayNhap
		'
		Me.dtNgayNhap.Location = New System.Drawing.Point(153, 296)
		Me.dtNgayNhap.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtNgayNhap.Name = "dtNgayNhap"
		Me.dtNgayNhap.Size = New System.Drawing.Size(200, 30)
		Me.dtNgayNhap.TabIndex = 22
		'
		'txtTriGia
		'
		'
		'
		'
		Me.txtTriGia.CustomButton.Image = Nothing
		Me.txtTriGia.CustomButton.Location = New System.Drawing.Point(134, 1)
		Me.txtTriGia.CustomButton.Name = ""
		Me.txtTriGia.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtTriGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTriGia.CustomButton.TabIndex = 1
		Me.txtTriGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTriGia.CustomButton.UseSelectable = True
		Me.txtTriGia.CustomButton.Visible = False
		Me.txtTriGia.Lines = New String() {"123"}
		Me.txtTriGia.Location = New System.Drawing.Point(153, 337)
		Me.txtTriGia.MaxLength = 32767
		Me.txtTriGia.Name = "txtTriGia"
		Me.txtTriGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTriGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTriGia.SelectedText = ""
		Me.txtTriGia.SelectionLength = 0
		Me.txtTriGia.SelectionStart = 0
		Me.txtTriGia.ShortcutsEnabled = True
		Me.txtTriGia.Size = New System.Drawing.Size(200, 23)
		Me.txtTriGia.TabIndex = 20
		Me.txtTriGia.Text = "123"
		Me.txtTriGia.UseSelectable = True
		Me.txtTriGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTriGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtNhaXuatBan
		'
		'
		'
		'
		Me.txtNhaXuatBan.CustomButton.Image = Nothing
		Me.txtNhaXuatBan.CustomButton.Location = New System.Drawing.Point(134, 1)
		Me.txtNhaXuatBan.CustomButton.Name = ""
		Me.txtNhaXuatBan.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtNhaXuatBan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNhaXuatBan.CustomButton.TabIndex = 1
		Me.txtNhaXuatBan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNhaXuatBan.CustomButton.UseSelectable = True
		Me.txtNhaXuatBan.CustomButton.Visible = False
		Me.txtNhaXuatBan.Lines = New String() {"a"}
		Me.txtNhaXuatBan.Location = New System.Drawing.Point(153, 261)
		Me.txtNhaXuatBan.MaxLength = 32767
		Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
		Me.txtNhaXuatBan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNhaXuatBan.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNhaXuatBan.SelectedText = ""
		Me.txtNhaXuatBan.SelectionLength = 0
		Me.txtNhaXuatBan.SelectionStart = 0
		Me.txtNhaXuatBan.ShortcutsEnabled = True
		Me.txtNhaXuatBan.Size = New System.Drawing.Size(200, 23)
		Me.txtNhaXuatBan.TabIndex = 19
		Me.txtNhaXuatBan.Text = "a"
		Me.txtNhaXuatBan.UseSelectable = True
		Me.txtNhaXuatBan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtNhaXuatBan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTacGia
		'
		'
		'
		'
		Me.txtTacGia.CustomButton.Image = Nothing
		Me.txtTacGia.CustomButton.Location = New System.Drawing.Point(134, 1)
		Me.txtTacGia.CustomButton.Name = ""
		Me.txtTacGia.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTacGia.CustomButton.TabIndex = 1
		Me.txtTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTacGia.CustomButton.UseSelectable = True
		Me.txtTacGia.CustomButton.Visible = False
		Me.txtTacGia.Lines = New String() {"a"}
		Me.txtTacGia.Location = New System.Drawing.Point(153, 185)
		Me.txtTacGia.MaxLength = 32767
		Me.txtTacGia.Name = "txtTacGia"
		Me.txtTacGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTacGia.SelectedText = ""
		Me.txtTacGia.SelectionLength = 0
		Me.txtTacGia.SelectionStart = 0
		Me.txtTacGia.ShortcutsEnabled = True
		Me.txtTacGia.Size = New System.Drawing.Size(200, 23)
		Me.txtTacGia.TabIndex = 18
		Me.txtTacGia.Text = "a"
		Me.txtTacGia.UseSelectable = True
		Me.txtTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTacGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTenSach
		'
		'
		'
		'
		Me.txtTenSach.CustomButton.Image = Nothing
		Me.txtTenSach.CustomButton.Location = New System.Drawing.Point(134, 1)
		Me.txtTenSach.CustomButton.Name = ""
		Me.txtTenSach.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenSach.CustomButton.TabIndex = 1
		Me.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenSach.CustomButton.UseSelectable = True
		Me.txtTenSach.CustomButton.Visible = False
		Me.txtTenSach.Lines = New String() {"tình yêu"}
		Me.txtTenSach.Location = New System.Drawing.Point(153, 109)
		Me.txtTenSach.MaxLength = 32767
		Me.txtTenSach.Name = "txtTenSach"
		Me.txtTenSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenSach.SelectedText = ""
		Me.txtTenSach.SelectionLength = 0
		Me.txtTenSach.SelectionStart = 0
		Me.txtTenSach.ShortcutsEnabled = True
		Me.txtTenSach.Size = New System.Drawing.Size(200, 23)
		Me.txtTenSach.TabIndex = 21
		Me.txtTenSach.Text = "tình yêu"
		Me.txtTenSach.UseSelectable = True
		Me.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTenSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtMaSach
		'
		'
		'
		'
		Me.txtMaSach.CustomButton.Image = Nothing
		Me.txtMaSach.CustomButton.Location = New System.Drawing.Point(134, 1)
		Me.txtMaSach.CustomButton.Name = ""
		Me.txtMaSach.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtMaSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaSach.CustomButton.TabIndex = 1
		Me.txtMaSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaSach.CustomButton.UseSelectable = True
		Me.txtMaSach.CustomButton.Visible = False
		Me.txtMaSach.ForeColor = System.Drawing.Color.Gray
		Me.txtMaSach.Lines = New String(-1) {}
		Me.txtMaSach.Location = New System.Drawing.Point(153, 74)
		Me.txtMaSach.MaxLength = 32767
		Me.txtMaSach.Name = "txtMaSach"
		Me.txtMaSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaSach.ReadOnly = True
		Me.txtMaSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaSach.SelectedText = ""
		Me.txtMaSach.SelectionLength = 0
		Me.txtMaSach.SelectionStart = 0
		Me.txtMaSach.ShortcutsEnabled = True
		Me.txtMaSach.Size = New System.Drawing.Size(200, 23)
		Me.txtMaSach.TabIndex = 17
		Me.txtMaSach.UseSelectable = True
		Me.txtMaSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'MetroLabel9
		'
		Me.MetroLabel9.AutoSize = True
		Me.MetroLabel9.Location = New System.Drawing.Point(37, 378)
		Me.MetroLabel9.Name = "MetroLabel9"
		Me.MetroLabel9.Size = New System.Drawing.Size(100, 19)
		Me.MetroLabel9.TabIndex = 15
		Me.MetroLabel9.Text = "Tình Trạng Sách"
		'
		'MetroLabel8
		'
		Me.MetroLabel8.AutoSize = True
		Me.MetroLabel8.Location = New System.Drawing.Point(37, 340)
		Me.MetroLabel8.Name = "MetroLabel8"
		Me.MetroLabel8.Size = New System.Drawing.Size(45, 19)
		Me.MetroLabel8.TabIndex = 14
		Me.MetroLabel8.Text = "Trị Giá"
		'
		'MetroLabel7
		'
		Me.MetroLabel7.AutoSize = True
		Me.MetroLabel7.Location = New System.Drawing.Point(37, 302)
		Me.MetroLabel7.Name = "MetroLabel7"
		Me.MetroLabel7.Size = New System.Drawing.Size(76, 19)
		Me.MetroLabel7.TabIndex = 13
		Me.MetroLabel7.Text = "Ngày Nhập"
		'
		'MetroLabel6
		'
		Me.MetroLabel6.AutoSize = True
		Me.MetroLabel6.Location = New System.Drawing.Point(37, 264)
		Me.MetroLabel6.Name = "MetroLabel6"
		Me.MetroLabel6.Size = New System.Drawing.Size(89, 19)
		Me.MetroLabel6.TabIndex = 12
		Me.MetroLabel6.Text = "Nhà Xuất Bản"
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = True
		Me.MetroLabel5.Location = New System.Drawing.Point(37, 226)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(94, 19)
		Me.MetroLabel5.TabIndex = 11
		Me.MetroLabel5.Text = "Năm Xuất Bản"
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(37, 188)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(54, 19)
		Me.MetroLabel4.TabIndex = 10
		Me.MetroLabel4.Text = "Tác Giả "
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(37, 150)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(93, 19)
		Me.MetroLabel3.TabIndex = 9
		Me.MetroLabel3.Text = "Thể Loại Sách "
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(37, 112)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
		Me.MetroLabel2.TabIndex = 16
		Me.MetroLabel2.Text = "Tên Sách "
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(37, 74)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(78, 19)
		Me.MetroLabel1.TabIndex = 8
		Me.MetroLabel1.Text = "Mã Số Sách"
		'
		'btnXoa
		'
		Me.btnXoa.Location = New System.Drawing.Point(278, 455)
		Me.btnXoa.Name = "btnXoa"
		Me.btnXoa.Size = New System.Drawing.Size(75, 23)
		Me.btnXoa.TabIndex = 27
		Me.btnXoa.Text = "Xóa"
		Me.btnXoa.UseSelectable = True
		'
		'btnCapNhat
		'
		Me.btnCapNhat.Location = New System.Drawing.Point(153, 453)
		Me.btnCapNhat.Name = "btnCapNhat"
		Me.btnCapNhat.Size = New System.Drawing.Size(88, 25)
		Me.btnCapNhat.TabIndex = 26
		Me.btnCapNhat.Text = "Cập nhật"
		Me.btnCapNhat.UseSelectable = True
		'
		'MetroLabel10
		'
		Me.MetroLabel10.AutoSize = True
		Me.MetroLabel10.Location = New System.Drawing.Point(476, 39)
		Me.MetroLabel10.Name = "MetroLabel10"
		Me.MetroLabel10.Size = New System.Drawing.Size(89, 19)
		Me.MetroLabel10.TabIndex = 29
		Me.MetroLabel10.Text = "Thể Loại Sách"
		'
		'cbTheLoaiSach
		'
		Me.cbTheLoaiSach.FormattingEnabled = True
		Me.cbTheLoaiSach.ItemHeight = 23
		Me.cbTheLoaiSach.Location = New System.Drawing.Point(573, 32)
		Me.cbTheLoaiSach.Name = "cbTheLoaiSach"
		Me.cbTheLoaiSach.Size = New System.Drawing.Size(121, 29)
		Me.cbTheLoaiSach.TabIndex = 28
		Me.cbTheLoaiSach.UseSelectable = True
		'
		'dgvListSach
		'
		Me.dgvListSach.AllowUserToResizeColumns = False
		Me.dgvListSach.AllowUserToResizeRows = False
		Me.dgvListSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvListSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvListSach.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvListSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvListSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvListSach.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvListSach.EnableHeadersVisualStyles = False
		Me.dgvListSach.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvListSach.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvListSach.Location = New System.Drawing.Point(365, 74)
		Me.dgvListSach.MultiSelect = False
		Me.dgvListSach.Name = "dgvListSach"
		Me.dgvListSach.ReadOnly = True
		Me.dgvListSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvListSach.RowHeadersVisible = False
		Me.dgvListSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvListSach.Size = New System.Drawing.Size(634, 323)
		Me.dgvListSach.TabIndex = 30
		'
		'cbNamXuatBan
		'
		Me.cbNamXuatBan.FormattingEnabled = True
		Me.cbNamXuatBan.ItemHeight = 23
		Me.cbNamXuatBan.Location = New System.Drawing.Point(153, 223)
		Me.cbNamXuatBan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.cbNamXuatBan.Name = "cbNamXuatBan"
		Me.cbNamXuatBan.Size = New System.Drawing.Size(200, 29)
		Me.cbNamXuatBan.TabIndex = 31
		Me.cbNamXuatBan.UseSelectable = True
		'
		'frmQuanLySach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1012, 520)
		Me.Controls.Add(Me.cbNamXuatBan)
		Me.Controls.Add(Me.dgvListSach)
		Me.Controls.Add(Me.MetroLabel10)
		Me.Controls.Add(Me.cbTheLoaiSach)
		Me.Controls.Add(Me.btnXoa)
		Me.Controls.Add(Me.btnCapNhat)
		Me.Controls.Add(Me.cbTinhTrangSach)
		Me.Controls.Add(Me.cbTheLoaiSachCapNhap)
		Me.Controls.Add(Me.dtNgayNhap)
		Me.Controls.Add(Me.txtTriGia)
		Me.Controls.Add(Me.txtNhaXuatBan)
		Me.Controls.Add(Me.txtTacGia)
		Me.Controls.Add(Me.txtTenSach)
		Me.Controls.Add(Me.txtMaSach)
		Me.Controls.Add(Me.MetroLabel9)
		Me.Controls.Add(Me.MetroLabel8)
		Me.Controls.Add(Me.MetroLabel7)
		Me.Controls.Add(Me.MetroLabel6)
		Me.Controls.Add(Me.MetroLabel5)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmQuanLySach"
		Me.Padding = New System.Windows.Forms.Padding(15, 49, 15, 16)
		Me.Text = "frmQuanLySach"
		CType(Me.dgvListSach,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents cbTinhTrangSach As MetroFramework.Controls.MetroComboBox
	Friend WithEvents cbTheLoaiSachCapNhap As MetroFramework.Controls.MetroComboBox
	Friend WithEvents dtNgayNhap As MetroFramework.Controls.MetroDateTime
	Friend WithEvents txtTriGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtNhaXuatBan As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTacGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTenSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtMaSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
	Friend WithEvents btnCapNhat As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbTheLoaiSach As MetroFramework.Controls.MetroComboBox
	Friend WithEvents dgvListSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents cbNamXuatBan As MetroFramework.Controls.MetroComboBox
End Class
