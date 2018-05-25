<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLyDocGia
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dgvListDocGia = New MetroFramework.Controls.MetroGrid()
		Me.btnCapNhat = New MetroFramework.Controls.MetroButton()
		Me.btnXoa = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaDocGia = New MetroFramework.Controls.MetroTextBox()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.a = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.txtHoTenDocGia = New MetroFramework.Controls.MetroTextBox()
		Me.txtDiaChi = New MetroFramework.Controls.MetroTextBox()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
		Me.tx = New MetroFramework.Controls.MetroLabel()
		Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
		Me.dtNgayLapThe = New MetroFramework.Controls.MetroDateTime()
		Me.dtpNgaySinh = New MetroFramework.Controls.MetroDateTime()
		Me.cbLoaiDocGiaCapNhat = New MetroFramework.Controls.MetroComboBox()
		Me.cbLoaiDocGia = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		CType(Me.dgvListDocGia,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dgvListDocGia
		'
		Me.dgvListDocGia.AllowUserToResizeRows = false
		Me.dgvListDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvListDocGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dgvListDocGia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvListDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvListDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvListDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListDocGia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvListDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvListDocGia.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvListDocGia.EnableHeadersVisualStyles = false
		Me.dgvListDocGia.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvListDocGia.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvListDocGia.Location = New System.Drawing.Point(547, 96)
		Me.dgvListDocGia.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvListDocGia.MultiSelect = false
		Me.dgvListDocGia.Name = "dgvListDocGia"
		Me.dgvListDocGia.ReadOnly = true
		Me.dgvListDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListDocGia.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvListDocGia.RowHeadersVisible = false
		Me.dgvListDocGia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvListDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvListDocGia.Size = New System.Drawing.Size(722, 185)
		Me.dgvListDocGia.TabIndex = 0
		'
		'btnCapNhat
		'
		Me.btnCapNhat.Location = New System.Drawing.Point(260, 502)
		Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCapNhat.Name = "btnCapNhat"
		Me.btnCapNhat.Size = New System.Drawing.Size(117, 31)
		Me.btnCapNhat.TabIndex = 1
		Me.btnCapNhat.Text = "Cập nhật"
		Me.btnCapNhat.UseSelectable = true
		'
		'btnXoa
		'
		Me.btnXoa.Location = New System.Drawing.Point(427, 505)
		Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
		Me.btnXoa.Name = "btnXoa"
		Me.btnXoa.Size = New System.Drawing.Size(100, 28)
		Me.btnXoa.TabIndex = 2
		Me.btnXoa.Text = "Xóa"
		Me.btnXoa.UseSelectable = true
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = true
		Me.MetroLabel1.Location = New System.Drawing.Point(52, 96)
		Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(81, 20)
		Me.MetroLabel1.TabIndex = 3
		Me.MetroLabel1.Text = "Mã Độc Giả"
		'
		'txtMaDocGia
		'
		'
		'
		'
		Me.txtMaDocGia.CustomButton.Image = Nothing
		Me.txtMaDocGia.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtMaDocGia.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtMaDocGia.CustomButton.Name = ""
		Me.txtMaDocGia.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtMaDocGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaDocGia.CustomButton.TabIndex = 1
		Me.txtMaDocGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaDocGia.CustomButton.UseSelectable = true
		Me.txtMaDocGia.CustomButton.Visible = false
		Me.txtMaDocGia.Lines = New String(-1) {}
		Me.txtMaDocGia.Location = New System.Drawing.Point(260, 96)
		Me.txtMaDocGia.Margin = New System.Windows.Forms.Padding(4)
		Me.txtMaDocGia.MaxLength = 32767
		Me.txtMaDocGia.Name = "txtMaDocGia"
		Me.txtMaDocGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaDocGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaDocGia.SelectedText = ""
		Me.txtMaDocGia.SelectionLength = 0
		Me.txtMaDocGia.SelectionStart = 0
		Me.txtMaDocGia.ShortcutsEnabled = true
		Me.txtMaDocGia.Size = New System.Drawing.Size(267, 28)
		Me.txtMaDocGia.TabIndex = 4
		Me.txtMaDocGia.UseSelectable = true
		Me.txtMaDocGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtMaDocGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = true
		Me.MetroLabel2.Location = New System.Drawing.Point(52, 150)
		Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(106, 20)
		Me.MetroLabel2.TabIndex = 3
		Me.MetroLabel2.Text = "Họ Tên Độc Giả"
		'
		'a
		'
		Me.a.AutoSize = true
		Me.a.Location = New System.Drawing.Point(52, 204)
		Me.a.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.a.Name = "a"
		Me.a.Size = New System.Drawing.Size(76, 20)
		Me.a.TabIndex = 3
		Me.a.Text = "Ngày Sinh "
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = true
		Me.MetroLabel4.Location = New System.Drawing.Point(52, 258)
		Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(53, 20)
		Me.MetroLabel4.TabIndex = 3
		Me.MetroLabel4.Text = "Địa Chỉ"
		'
		'txtHoTenDocGia
		'
		'
		'
		'
		Me.txtHoTenDocGia.CustomButton.Image = Nothing
		Me.txtHoTenDocGia.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtHoTenDocGia.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtHoTenDocGia.CustomButton.Name = ""
		Me.txtHoTenDocGia.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtHoTenDocGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtHoTenDocGia.CustomButton.TabIndex = 1
		Me.txtHoTenDocGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtHoTenDocGia.CustomButton.UseSelectable = true
		Me.txtHoTenDocGia.CustomButton.Visible = false
		Me.txtHoTenDocGia.Lines = New String(-1) {}
		Me.txtHoTenDocGia.Location = New System.Drawing.Point(260, 149)
		Me.txtHoTenDocGia.Margin = New System.Windows.Forms.Padding(4)
		Me.txtHoTenDocGia.MaxLength = 32767
		Me.txtHoTenDocGia.Name = "txtHoTenDocGia"
		Me.txtHoTenDocGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtHoTenDocGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHoTenDocGia.SelectedText = ""
		Me.txtHoTenDocGia.SelectionLength = 0
		Me.txtHoTenDocGia.SelectionStart = 0
		Me.txtHoTenDocGia.ShortcutsEnabled = true
		Me.txtHoTenDocGia.Size = New System.Drawing.Size(267, 28)
		Me.txtHoTenDocGia.TabIndex = 4
		Me.txtHoTenDocGia.UseSelectable = true
		Me.txtHoTenDocGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtHoTenDocGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtDiaChi
		'
		'
		'
		'
		Me.txtDiaChi.CustomButton.Image = Nothing
		Me.txtDiaChi.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtDiaChi.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtDiaChi.CustomButton.Name = ""
		Me.txtDiaChi.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtDiaChi.CustomButton.TabIndex = 1
		Me.txtDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtDiaChi.CustomButton.UseSelectable = true
		Me.txtDiaChi.CustomButton.Visible = false
		Me.txtDiaChi.Lines = New String(-1) {}
		Me.txtDiaChi.Location = New System.Drawing.Point(260, 255)
		Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
		Me.txtDiaChi.MaxLength = 32767
		Me.txtDiaChi.Name = "txtDiaChi"
		Me.txtDiaChi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDiaChi.SelectedText = ""
		Me.txtDiaChi.SelectionLength = 0
		Me.txtDiaChi.SelectionStart = 0
		Me.txtDiaChi.ShortcutsEnabled = true
		Me.txtDiaChi.Size = New System.Drawing.Size(267, 28)
		Me.txtDiaChi.TabIndex = 4
		Me.txtDiaChi.UseSelectable = true
		Me.txtDiaChi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtDiaChi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = true
		Me.MetroLabel5.Location = New System.Drawing.Point(52, 313)
		Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(42, 20)
		Me.MetroLabel5.TabIndex = 5
		Me.MetroLabel5.Text = "Email"
		'
		'MetroLabel6
		'
		Me.MetroLabel6.AutoSize = true
		Me.MetroLabel6.Location = New System.Drawing.Point(52, 367)
		Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel6.Name = "MetroLabel6"
		Me.MetroLabel6.Size = New System.Drawing.Size(96, 20)
		Me.MetroLabel6.TabIndex = 6
		Me.MetroLabel6.Text = "Ngày Lập Thẻ"
		'
		'tx
		'
		Me.tx.AutoSize = true
		Me.tx.Location = New System.Drawing.Point(52, 421)
		Me.tx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.tx.Name = "tx"
		Me.tx.Size = New System.Drawing.Size(87, 20)
		Me.tx.TabIndex = 7
		Me.tx.Text = "Loại Độc Giả"
		'
		'txtEmail
		'
		'
		'
		'
		Me.txtEmail.CustomButton.Image = Nothing
		Me.txtEmail.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtEmail.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtEmail.CustomButton.Name = ""
		Me.txtEmail.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtEmail.CustomButton.TabIndex = 1
		Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtEmail.CustomButton.UseSelectable = true
		Me.txtEmail.CustomButton.Visible = false
		Me.txtEmail.Lines = New String(-1) {}
		Me.txtEmail.Location = New System.Drawing.Point(260, 308)
		Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
		Me.txtEmail.MaxLength = 32767
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEmail.SelectedText = ""
		Me.txtEmail.SelectionLength = 0
		Me.txtEmail.SelectionStart = 0
		Me.txtEmail.ShortcutsEnabled = true
		Me.txtEmail.Size = New System.Drawing.Size(267, 28)
		Me.txtEmail.TabIndex = 4
		Me.txtEmail.UseSelectable = true
		Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'dtNgayLapThe
		'
		Me.dtNgayLapThe.Location = New System.Drawing.Point(260, 361)
		Me.dtNgayLapThe.Margin = New System.Windows.Forms.Padding(4)
		Me.dtNgayLapThe.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtNgayLapThe.Name = "dtNgayLapThe"
		Me.dtNgayLapThe.Size = New System.Drawing.Size(265, 30)
		Me.dtNgayLapThe.TabIndex = 8
		'
		'dtpNgaySinh
		'
		Me.dtpNgaySinh.Location = New System.Drawing.Point(260, 204)
		Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpNgaySinh.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtpNgaySinh.Name = "dtpNgaySinh"
		Me.dtpNgaySinh.Size = New System.Drawing.Size(265, 30)
		Me.dtpNgaySinh.TabIndex = 9
		'
		'cbLoaiDocGiaCapNhat
		'
		Me.cbLoaiDocGiaCapNhat.FormattingEnabled = true
		Me.cbLoaiDocGiaCapNhat.ItemHeight = 24
		Me.cbLoaiDocGiaCapNhat.Location = New System.Drawing.Point(260, 432)
		Me.cbLoaiDocGiaCapNhat.Margin = New System.Windows.Forms.Padding(4)
		Me.cbLoaiDocGiaCapNhat.Name = "cbLoaiDocGiaCapNhat"
		Me.cbLoaiDocGiaCapNhat.Size = New System.Drawing.Size(265, 30)
		Me.cbLoaiDocGiaCapNhat.TabIndex = 10
		Me.cbLoaiDocGiaCapNhat.UseSelectable = true
		'
		'cbLoaiDocGia
		'
		Me.cbLoaiDocGia.FormattingEnabled = true
		Me.cbLoaiDocGia.ItemHeight = 24
		Me.cbLoaiDocGia.Location = New System.Drawing.Point(859, 17)
		Me.cbLoaiDocGia.Margin = New System.Windows.Forms.Padding(4)
		Me.cbLoaiDocGia.Name = "cbLoaiDocGia"
		Me.cbLoaiDocGia.Size = New System.Drawing.Size(160, 30)
		Me.cbLoaiDocGia.TabIndex = 11
		Me.cbLoaiDocGia.UseSelectable = true
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = true
		Me.MetroLabel3.Location = New System.Drawing.Point(705, 30)
		Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(87, 20)
		Me.MetroLabel3.TabIndex = 12
		Me.MetroLabel3.Text = "Loại Độc Giả"
		'
		'frmQuanLyDocGia
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1288, 588)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.cbLoaiDocGia)
		Me.Controls.Add(Me.cbLoaiDocGiaCapNhat)
		Me.Controls.Add(Me.dtpNgaySinh)
		Me.Controls.Add(Me.dtNgayLapThe)
		Me.Controls.Add(Me.tx)
		Me.Controls.Add(Me.MetroLabel6)
		Me.Controls.Add(Me.MetroLabel5)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.txtDiaChi)
		Me.Controls.Add(Me.txtHoTenDocGia)
		Me.Controls.Add(Me.txtMaDocGia)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.a)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Controls.Add(Me.btnXoa)
		Me.Controls.Add(Me.btnCapNhat)
		Me.Controls.Add(Me.dgvListDocGia)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "frmQuanLyDocGia"
		Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
		Me.Text = "frmQuanLyDocGia"
		CType(Me.dgvListDocGia,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
	Friend WithEvents dgvListDocGia As MetroFramework.Controls.MetroGrid
	Friend WithEvents btnCapNhat As MetroFramework.Controls.MetroButton
	Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaDocGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents a As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtHoTenDocGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtDiaChi As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents tx As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
	Friend WithEvents dtNgayLapThe As MetroFramework.Controls.MetroDateTime
	Friend WithEvents dtpNgaySinh As MetroFramework.Controls.MetroDateTime
	Friend WithEvents cbLoaiDocGiaCapNhat As MetroFramework.Controls.MetroComboBox
	Friend WithEvents cbLoaiDocGia As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
