<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuuSach
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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnTimKiem = New MetroFramework.Controls.MetroButton()
		Me.dgvListSach = New MetroFramework.Controls.MetroGrid()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtTenSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtNhaXuatBan = New MetroFramework.Controls.MetroTextBox()
		Me.txtTacGia = New MetroFramework.Controls.MetroTextBox()
		Me.cbTheLoaiSach = New MetroFramework.Controls.MetroComboBox()
		Me.nudMinTriGia = New System.Windows.Forms.NumericUpDown()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.nudMaxTriGia = New System.Windows.Forms.NumericUpDown()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.nudMinNamXuatBan = New System.Windows.Forms.NumericUpDown()
		Me.nudMaxNamXuatBan = New System.Windows.Forms.NumericUpDown()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtMaSach = New MetroFramework.Controls.MetroTextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.dtpMinNgayNhap = New MetroFramework.Controls.MetroDateTime()
		Me.dtpMaxNgayNhap = New MetroFramework.Controls.MetroDateTime()
		CType(Me.dgvListSach, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudMinTriGia, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudMaxTriGia, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudMinNamXuatBan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudMaxNamXuatBan, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(289, 54)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(71, 13)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Nhà xuất bản"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(289, 99)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Tác giả"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(550, 54)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(73, 13)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Năm xuất bản"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(550, 110)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(61, 13)
		Me.Label7.TabIndex = 0
		Me.Label7.Text = "Ngày Nhập"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(550, 80)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(36, 13)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Trị giá"
		'
		'btnTimKiem
		'
		Me.btnTimKiem.Location = New System.Drawing.Point(410, 152)
		Me.btnTimKiem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnTimKiem.Name = "btnTimKiem"
		Me.btnTimKiem.Size = New System.Drawing.Size(56, 19)
		Me.btnTimKiem.TabIndex = 11
		Me.btnTimKiem.Text = "Tìm kiếm"
		Me.btnTimKiem.UseSelectable = True
		'
		'dgvListSach
		'
		Me.dgvListSach.AllowUserToResizeRows = False
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
		Me.dgvListSach.Location = New System.Drawing.Point(27, 190)
		Me.dgvListSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
		Me.dgvListSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvListSach.RowTemplate.Height = 24
		Me.dgvListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvListSach.Size = New System.Drawing.Size(894, 375)
		Me.dgvListSach.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(57, 99)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(45, 13)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Thể loại"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(57, 61)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(52, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Tên sách"
		'
		'txtTenSach
		'
		'
		'
		'
		Me.txtTenSach.CustomButton.Image = Nothing
		Me.txtTenSach.CustomButton.Location = New System.Drawing.Point(83, 1)
		Me.txtTenSach.CustomButton.Name = ""
		Me.txtTenSach.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenSach.CustomButton.TabIndex = 1
		Me.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenSach.CustomButton.UseSelectable = True
		Me.txtTenSach.CustomButton.Visible = False
		Me.txtTenSach.Lines = New String(-1) {}
		Me.txtTenSach.Location = New System.Drawing.Point(131, 52)
		Me.txtTenSach.MaxLength = 32767
		Me.txtTenSach.Name = "txtTenSach"
		Me.txtTenSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenSach.SelectedText = ""
		Me.txtTenSach.SelectionLength = 0
		Me.txtTenSach.SelectionStart = 0
		Me.txtTenSach.ShortcutsEnabled = True
		Me.txtTenSach.Size = New System.Drawing.Size(133, 23)
		Me.txtTenSach.TabIndex = 0
		Me.txtTenSach.UseSelectable = True
		Me.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTenSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtNhaXuatBan
		'
		'
		'
		'
		Me.txtNhaXuatBan.CustomButton.Image = Nothing
		Me.txtNhaXuatBan.CustomButton.Location = New System.Drawing.Point(83, 1)
		Me.txtNhaXuatBan.CustomButton.Name = ""
		Me.txtNhaXuatBan.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtNhaXuatBan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNhaXuatBan.CustomButton.TabIndex = 1
		Me.txtNhaXuatBan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNhaXuatBan.CustomButton.UseSelectable = True
		Me.txtNhaXuatBan.CustomButton.Visible = False
		Me.txtNhaXuatBan.Lines = New String(-1) {}
		Me.txtNhaXuatBan.Location = New System.Drawing.Point(374, 52)
		Me.txtNhaXuatBan.MaxLength = 32767
		Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
		Me.txtNhaXuatBan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNhaXuatBan.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNhaXuatBan.SelectedText = ""
		Me.txtNhaXuatBan.SelectionLength = 0
		Me.txtNhaXuatBan.SelectionStart = 0
		Me.txtNhaXuatBan.ShortcutsEnabled = True
		Me.txtNhaXuatBan.Size = New System.Drawing.Size(133, 23)
		Me.txtNhaXuatBan.TabIndex = 3
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
		Me.txtTacGia.CustomButton.Location = New System.Drawing.Point(83, 1)
		Me.txtTacGia.CustomButton.Name = ""
		Me.txtTacGia.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTacGia.CustomButton.TabIndex = 1
		Me.txtTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTacGia.CustomButton.UseSelectable = True
		Me.txtTacGia.CustomButton.Visible = False
		Me.txtTacGia.Lines = New String(-1) {}
		Me.txtTacGia.Location = New System.Drawing.Point(374, 101)
		Me.txtTacGia.MaxLength = 32767
		Me.txtTacGia.Name = "txtTacGia"
		Me.txtTacGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTacGia.SelectedText = ""
		Me.txtTacGia.SelectionLength = 0
		Me.txtTacGia.SelectionStart = 0
		Me.txtTacGia.ShortcutsEnabled = True
		Me.txtTacGia.Size = New System.Drawing.Size(133, 23)
		Me.txtTacGia.TabIndex = 4
		Me.txtTacGia.UseSelectable = True
		Me.txtTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTacGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'cbTheLoaiSach
		'
		Me.cbTheLoaiSach.FormattingEnabled = True
		Me.cbTheLoaiSach.ItemHeight = 23
		Me.cbTheLoaiSach.Location = New System.Drawing.Point(131, 99)
		Me.cbTheLoaiSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.cbTheLoaiSach.Name = "cbTheLoaiSach"
		Me.cbTheLoaiSach.Size = New System.Drawing.Size(134, 29)
		Me.cbTheLoaiSach.TabIndex = 1
		Me.cbTheLoaiSach.UseSelectable = True
		'
		'nudMinTriGia
		'
		Me.nudMinTriGia.Location = New System.Drawing.Point(686, 75)
		Me.nudMinTriGia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.nudMinTriGia.Name = "nudMinTriGia"
		Me.nudMinTriGia.Size = New System.Drawing.Size(66, 20)
		Me.nudMinTriGia.TabIndex = 7
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(656, 77)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(16, 13)
		Me.Label8.TabIndex = 0
		Me.Label8.Text = "từ"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(756, 79)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(26, 13)
		Me.Label9.TabIndex = 0
		Me.Label9.Text = "đến"
		'
		'nudMaxTriGia
		'
		Me.nudMaxTriGia.Location = New System.Drawing.Point(784, 75)
		Me.nudMaxTriGia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.nudMaxTriGia.Name = "nudMaxTriGia"
		Me.nudMaxTriGia.Size = New System.Drawing.Size(66, 20)
		Me.nudMaxTriGia.TabIndex = 8
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(656, 54)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(16, 13)
		Me.Label10.TabIndex = 0
		Me.Label10.Text = "từ"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(756, 56)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(26, 13)
		Me.Label11.TabIndex = 0
		Me.Label11.Text = "đến"
		'
		'nudMinNamXuatBan
		'
		Me.nudMinNamXuatBan.Location = New System.Drawing.Point(686, 52)
		Me.nudMinNamXuatBan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.nudMinNamXuatBan.Name = "nudMinNamXuatBan"
		Me.nudMinNamXuatBan.Size = New System.Drawing.Size(66, 20)
		Me.nudMinNamXuatBan.TabIndex = 5
		'
		'nudMaxNamXuatBan
		'
		Me.nudMaxNamXuatBan.Location = New System.Drawing.Point(784, 52)
		Me.nudMaxNamXuatBan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.nudMaxNamXuatBan.Name = "nudMaxNamXuatBan"
		Me.nudMaxNamXuatBan.Size = New System.Drawing.Size(66, 20)
		Me.nudMaxNamXuatBan.TabIndex = 6
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(656, 110)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(16, 13)
		Me.Label12.TabIndex = 0
		Me.Label12.Text = "từ"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(656, 139)
		Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(26, 13)
		Me.Label13.TabIndex = 0
		Me.Label13.Text = "đến"
		'
		'txtMaSach
		'
		'
		'
		'
		Me.txtMaSach.CustomButton.Image = Nothing
		Me.txtMaSach.CustomButton.Location = New System.Drawing.Point(83, 1)
		Me.txtMaSach.CustomButton.Name = ""
		Me.txtMaSach.CustomButton.Size = New System.Drawing.Size(16, 17)
		Me.txtMaSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaSach.CustomButton.TabIndex = 1
		Me.txtMaSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaSach.CustomButton.UseSelectable = True
		Me.txtMaSach.CustomButton.Visible = False
		Me.txtMaSach.Lines = New String(-1) {}
		Me.txtMaSach.Location = New System.Drawing.Point(131, 141)
		Me.txtMaSach.MaxLength = 32767
		Me.txtMaSach.Name = "txtMaSach"
		Me.txtMaSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaSach.SelectedText = ""
		Me.txtMaSach.SelectionLength = 0
		Me.txtMaSach.SelectionStart = 0
		Me.txtMaSach.ShortcutsEnabled = True
		Me.txtMaSach.Size = New System.Drawing.Size(133, 23)
		Me.txtMaSach.TabIndex = 2
		Me.txtMaSach.UseSelectable = True
		Me.txtMaSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(59, 141)
		Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(50, 13)
		Me.Label14.TabIndex = 8
		Me.Label14.Text = "Mã Sách"
		'
		'dtpMinNgayNhap
		'
		Me.dtpMinNgayNhap.Location = New System.Drawing.Point(686, 101)
		Me.dtpMinNgayNhap.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtpMinNgayNhap.Name = "dtpMinNgayNhap"
		Me.dtpMinNgayNhap.Size = New System.Drawing.Size(200, 29)
		Me.dtpMinNgayNhap.TabIndex = 12
		'
		'dtpMaxNgayNhap
		'
		Me.dtpMaxNgayNhap.Location = New System.Drawing.Point(686, 133)
		Me.dtpMaxNgayNhap.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtpMaxNgayNhap.Name = "dtpMaxNgayNhap"
		Me.dtpMaxNgayNhap.Size = New System.Drawing.Size(200, 29)
		Me.dtpMaxNgayNhap.TabIndex = 13
		'
		'frmTraCuuSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(938, 621)
		Me.Controls.Add(Me.dtpMaxNgayNhap)
		Me.Controls.Add(Me.dtpMinNgayNhap)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.nudMaxNamXuatBan)
		Me.Controls.Add(Me.nudMaxTriGia)
		Me.Controls.Add(Me.nudMinNamXuatBan)
		Me.Controls.Add(Me.nudMinTriGia)
		Me.Controls.Add(Me.cbTheLoaiSach)
		Me.Controls.Add(Me.txtTacGia)
		Me.Controls.Add(Me.txtNhaXuatBan)
		Me.Controls.Add(Me.txtMaSach)
		Me.Controls.Add(Me.txtTenSach)
		Me.Controls.Add(Me.dgvListSach)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.btnTimKiem)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmTraCuuSach"
		Me.Padding = New System.Windows.Forms.Padding(15, 49, 15, 16)
		Me.Text = "Tra Cứu Sách"
		CType(Me.dgvListSach,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudMinTriGia,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudMaxTriGia,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudMinNamXuatBan,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudMaxNamXuatBan,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents btnTimKiem As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvListSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtTenSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtNhaXuatBan As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTacGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cbTheLoaiSach As MetroFramework.Controls.MetroComboBox
	Friend WithEvents nudMinTriGia As NumericUpDown
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents nudMaxTriGia As NumericUpDown
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents nudMinNamXuatBan As NumericUpDown
	Friend WithEvents nudMaxNamXuatBan As NumericUpDown
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents txtMaSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents dtpMinNgayNhap As MetroFramework.Controls.MetroDateTime
	Friend WithEvents dtpMaxNgayNhap As MetroFramework.Controls.MetroDateTime
End Class
