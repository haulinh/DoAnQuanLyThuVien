<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemSach
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
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtTenSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtTacGia = New MetroFramework.Controls.MetroTextBox()
		Me.txtNhaXuatBan = New MetroFramework.Controls.MetroTextBox()
		Me.txtTriGia = New MetroFramework.Controls.MetroTextBox()
		Me.btnNhap = New MetroFramework.Controls.MetroButton()
		Me.btnNhapVaDong = New MetroFramework.Controls.MetroButton()
		Me.dtNgayNhap = New MetroFramework.Controls.MetroDateTime()
		Me.cbMaTheLoaiSach = New MetroFramework.Controls.MetroComboBox()
		Me.cbNamXuatBan = New MetroFramework.Controls.MetroComboBox()
		Me.cbTinhTrangSach = New MetroFramework.Controls.MetroComboBox()
		Me.SuspendLayout()
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(72, 69)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(78, 19)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Mã Số Sách"
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(72, 107)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
		Me.MetroLabel2.TabIndex = 0
		Me.MetroLabel2.Text = "Tên Sách "
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(72, 145)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(116, 19)
		Me.MetroLabel3.TabIndex = 0
		Me.MetroLabel3.Text = "Mã Thể Loại Sách "
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(72, 183)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(54, 19)
		Me.MetroLabel4.TabIndex = 0
		Me.MetroLabel4.Text = "Tác Giả "
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = True
		Me.MetroLabel5.Location = New System.Drawing.Point(72, 221)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(94, 19)
		Me.MetroLabel5.TabIndex = 0
		Me.MetroLabel5.Text = "Năm Xuất Bản"
		'
		'MetroLabel6
		'
		Me.MetroLabel6.AutoSize = True
		Me.MetroLabel6.Location = New System.Drawing.Point(72, 259)
		Me.MetroLabel6.Name = "MetroLabel6"
		Me.MetroLabel6.Size = New System.Drawing.Size(89, 19)
		Me.MetroLabel6.TabIndex = 0
		Me.MetroLabel6.Text = "Nhà Xuất Bản"
		'
		'MetroLabel7
		'
		Me.MetroLabel7.AutoSize = True
		Me.MetroLabel7.Location = New System.Drawing.Point(72, 297)
		Me.MetroLabel7.Name = "MetroLabel7"
		Me.MetroLabel7.Size = New System.Drawing.Size(76, 19)
		Me.MetroLabel7.TabIndex = 0
		Me.MetroLabel7.Text = "Ngày Nhập"
		'
		'MetroLabel8
		'
		Me.MetroLabel8.AutoSize = True
		Me.MetroLabel8.Location = New System.Drawing.Point(72, 335)
		Me.MetroLabel8.Name = "MetroLabel8"
		Me.MetroLabel8.Size = New System.Drawing.Size(45, 19)
		Me.MetroLabel8.TabIndex = 0
		Me.MetroLabel8.Text = "Trị Giá"
		'
		'MetroLabel9
		'
		Me.MetroLabel9.AutoSize = True
		Me.MetroLabel9.Location = New System.Drawing.Point(72, 373)
		Me.MetroLabel9.Name = "MetroLabel9"
		Me.MetroLabel9.Size = New System.Drawing.Size(100, 19)
		Me.MetroLabel9.TabIndex = 0
		Me.MetroLabel9.Text = "Tình Trạng Sách"
		'
		'txtMaSach
		'
		'
		'
		'
		Me.txtMaSach.CustomButton.Image = Nothing
		Me.txtMaSach.CustomButton.Location = New System.Drawing.Point(178, 1)
		Me.txtMaSach.CustomButton.Name = ""
		Me.txtMaSach.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMaSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaSach.CustomButton.TabIndex = 1
		Me.txtMaSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaSach.CustomButton.UseSelectable = True
		Me.txtMaSach.CustomButton.Visible = False
		Me.txtMaSach.Lines = New String() {"a"}
		Me.txtMaSach.Location = New System.Drawing.Point(229, 69)
		Me.txtMaSach.MaxLength = 32767
		Me.txtMaSach.Name = "txtMaSach"
		Me.txtMaSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaSach.SelectedText = ""
		Me.txtMaSach.SelectionLength = 0
		Me.txtMaSach.SelectionStart = 0
		Me.txtMaSach.ShortcutsEnabled = True
		Me.txtMaSach.Size = New System.Drawing.Size(200, 23)
		Me.txtMaSach.TabIndex = 1
		Me.txtMaSach.Text = "a"
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
		Me.txtTenSach.CustomButton.Location = New System.Drawing.Point(178, 1)
		Me.txtTenSach.CustomButton.Name = ""
		Me.txtTenSach.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenSach.CustomButton.TabIndex = 1
		Me.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenSach.CustomButton.UseSelectable = True
		Me.txtTenSach.CustomButton.Visible = False
		Me.txtTenSach.Lines = New String() {"tình yêu"}
		Me.txtTenSach.Location = New System.Drawing.Point(229, 104)
		Me.txtTenSach.MaxLength = 32767
		Me.txtTenSach.Name = "txtTenSach"
		Me.txtTenSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenSach.SelectedText = ""
		Me.txtTenSach.SelectionLength = 0
		Me.txtTenSach.SelectionStart = 0
		Me.txtTenSach.ShortcutsEnabled = True
		Me.txtTenSach.Size = New System.Drawing.Size(200, 23)
		Me.txtTenSach.TabIndex = 1
		Me.txtTenSach.Text = "tình yêu"
		Me.txtTenSach.UseSelectable = True
		Me.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTenSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTacGia
		'
		'
		'
		'
		Me.txtTacGia.CustomButton.Image = Nothing
		Me.txtTacGia.CustomButton.Location = New System.Drawing.Point(178, 1)
		Me.txtTacGia.CustomButton.Name = ""
		Me.txtTacGia.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTacGia.CustomButton.TabIndex = 1
		Me.txtTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTacGia.CustomButton.UseSelectable = True
		Me.txtTacGia.CustomButton.Visible = False
		Me.txtTacGia.Lines = New String() {"a"}
		Me.txtTacGia.Location = New System.Drawing.Point(229, 180)
		Me.txtTacGia.MaxLength = 32767
		Me.txtTacGia.Name = "txtTacGia"
		Me.txtTacGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTacGia.SelectedText = ""
		Me.txtTacGia.SelectionLength = 0
		Me.txtTacGia.SelectionStart = 0
		Me.txtTacGia.ShortcutsEnabled = True
		Me.txtTacGia.Size = New System.Drawing.Size(200, 23)
		Me.txtTacGia.TabIndex = 1
		Me.txtTacGia.Text = "a"
		Me.txtTacGia.UseSelectable = True
		Me.txtTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTacGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtNhaXuatBan
		'
		'
		'
		'
		Me.txtNhaXuatBan.CustomButton.Image = Nothing
		Me.txtNhaXuatBan.CustomButton.Location = New System.Drawing.Point(178, 1)
		Me.txtNhaXuatBan.CustomButton.Name = ""
		Me.txtNhaXuatBan.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtNhaXuatBan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNhaXuatBan.CustomButton.TabIndex = 1
		Me.txtNhaXuatBan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNhaXuatBan.CustomButton.UseSelectable = True
		Me.txtNhaXuatBan.CustomButton.Visible = False
		Me.txtNhaXuatBan.Lines = New String() {"a"}
		Me.txtNhaXuatBan.Location = New System.Drawing.Point(229, 256)
		Me.txtNhaXuatBan.MaxLength = 32767
		Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
		Me.txtNhaXuatBan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNhaXuatBan.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNhaXuatBan.SelectedText = ""
		Me.txtNhaXuatBan.SelectionLength = 0
		Me.txtNhaXuatBan.SelectionStart = 0
		Me.txtNhaXuatBan.ShortcutsEnabled = True
		Me.txtNhaXuatBan.Size = New System.Drawing.Size(200, 23)
		Me.txtNhaXuatBan.TabIndex = 1
		Me.txtNhaXuatBan.Text = "a"
		Me.txtNhaXuatBan.UseSelectable = True
		Me.txtNhaXuatBan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtNhaXuatBan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTriGia
		'
		'
		'
		'
		Me.txtTriGia.CustomButton.Image = Nothing
		Me.txtTriGia.CustomButton.Location = New System.Drawing.Point(178, 1)
		Me.txtTriGia.CustomButton.Name = ""
		Me.txtTriGia.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtTriGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTriGia.CustomButton.TabIndex = 1
		Me.txtTriGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTriGia.CustomButton.UseSelectable = True
		Me.txtTriGia.CustomButton.Visible = False
		Me.txtTriGia.Lines = New String() {"123"}
		Me.txtTriGia.Location = New System.Drawing.Point(229, 332)
		Me.txtTriGia.MaxLength = 32767
		Me.txtTriGia.Name = "txtTriGia"
		Me.txtTriGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTriGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTriGia.SelectedText = ""
		Me.txtTriGia.SelectionLength = 0
		Me.txtTriGia.SelectionStart = 0
		Me.txtTriGia.ShortcutsEnabled = True
		Me.txtTriGia.Size = New System.Drawing.Size(200, 23)
		Me.txtTriGia.TabIndex = 1
		Me.txtTriGia.Text = "123"
		Me.txtTriGia.UseSelectable = True
		Me.txtTriGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTriGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnNhap
		'
		Me.btnNhap.Location = New System.Drawing.Point(229, 432)
		Me.btnNhap.Name = "btnNhap"
		Me.btnNhap.Size = New System.Drawing.Size(88, 23)
		Me.btnNhap.TabIndex = 3
		Me.btnNhap.Text = "Nhập"
		Me.btnNhap.UseSelectable = True
		'
		'btnNhapVaDong
		'
		Me.btnNhapVaDong.Location = New System.Drawing.Point(336, 432)
		Me.btnNhapVaDong.Name = "btnNhapVaDong"
		Me.btnNhapVaDong.Size = New System.Drawing.Size(93, 23)
		Me.btnNhapVaDong.TabIndex = 3
		Me.btnNhapVaDong.Text = "Nhập và đóng"
		Me.btnNhapVaDong.UseSelectable = True
		'
		'dtNgayNhap
		'
		Me.dtNgayNhap.Location = New System.Drawing.Point(229, 291)
		Me.dtNgayNhap.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtNgayNhap.Name = "dtNgayNhap"
		Me.dtNgayNhap.Size = New System.Drawing.Size(200, 29)
		Me.dtNgayNhap.TabIndex = 4
		'
		'cbMaTheLoaiSach
		'
		Me.cbMaTheLoaiSach.FormattingEnabled = True
		Me.cbMaTheLoaiSach.ItemHeight = 23
		Me.cbMaTheLoaiSach.Items.AddRange(New Object() {"1", "2"})
		Me.cbMaTheLoaiSach.Location = New System.Drawing.Point(229, 139)
		Me.cbMaTheLoaiSach.Name = "cbMaTheLoaiSach"
		Me.cbMaTheLoaiSach.Size = New System.Drawing.Size(200, 29)
		Me.cbMaTheLoaiSach.TabIndex = 5
		Me.cbMaTheLoaiSach.UseSelectable = True
		'
		'cbNamXuatBan
		'
		Me.cbNamXuatBan.FormattingEnabled = True
		Me.cbNamXuatBan.ItemHeight = 23
		Me.cbNamXuatBan.Items.AddRange(New Object() {"2017"})
		Me.cbNamXuatBan.Location = New System.Drawing.Point(229, 215)
		Me.cbNamXuatBan.Name = "cbNamXuatBan"
		Me.cbNamXuatBan.Size = New System.Drawing.Size(200, 29)
		Me.cbNamXuatBan.TabIndex = 6
		Me.cbNamXuatBan.UseSelectable = True
		'
		'cbTinhTrangSach
		'
		Me.cbTinhTrangSach.FormattingEnabled = True
		Me.cbTinhTrangSach.ItemHeight = 23
		Me.cbTinhTrangSach.Items.AddRange(New Object() {"Rỗng"})
		Me.cbTinhTrangSach.Location = New System.Drawing.Point(229, 367)
		Me.cbTinhTrangSach.Name = "cbTinhTrangSach"
		Me.cbTinhTrangSach.Size = New System.Drawing.Size(200, 29)
		Me.cbTinhTrangSach.TabIndex = 7
		Me.cbTinhTrangSach.UseSelectable = True
		'
		'frmThemSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(973, 520)
		Me.Controls.Add(Me.cbTinhTrangSach)
		Me.Controls.Add(Me.cbNamXuatBan)
		Me.Controls.Add(Me.cbMaTheLoaiSach)
		Me.Controls.Add(Me.dtNgayNhap)
		Me.Controls.Add(Me.btnNhapVaDong)
		Me.Controls.Add(Me.btnNhap)
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
		Me.Name = "frmThemSach"
		Me.Text = "frmThemSach"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTenSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTacGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtNhaXuatBan As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTriGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnNhap As MetroFramework.Controls.MetroButton
	Friend WithEvents btnNhapVaDong As MetroFramework.Controls.MetroButton
	Friend WithEvents dtNgayNhap As MetroFramework.Controls.MetroDateTime
	Friend WithEvents cbMaTheLoaiSach As MetroFramework.Controls.MetroComboBox
	Friend WithEvents cbNamXuatBan As MetroFramework.Controls.MetroComboBox
	Friend WithEvents cbTinhTrangSach As MetroFramework.Controls.MetroComboBox
End Class
