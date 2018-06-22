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
		Me.dtpMinNgayNhap = New System.Windows.Forms.DateTimePicker()
		Me.dtpMaxNgayNhap = New System.Windows.Forms.DateTimePicker()
		CType(Me.dgvListSach,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudMinTriGia,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudMaxTriGia,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudMinNamXuatBan,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudMaxNamXuatBan,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'Label3
		'
		Me.Label3.AutoSize = true
		Me.Label3.Location = New System.Drawing.Point(385, 67)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(92, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Nhà xuất bản"
		'
		'Label4
		'
		Me.Label4.AutoSize = true
		Me.Label4.Location = New System.Drawing.Point(385, 122)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 17)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Tác giả"
		'
		'Label5
		'
		Me.Label5.AutoSize = true
		Me.Label5.Location = New System.Drawing.Point(733, 67)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(95, 17)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Năm xuất bản"
		'
		'Label7
		'
		Me.Label7.AutoSize = true
		Me.Label7.Location = New System.Drawing.Point(733, 135)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(79, 17)
		Me.Label7.TabIndex = 0
		Me.Label7.Text = "Ngày Nhập"
		'
		'Label6
		'
		Me.Label6.AutoSize = true
		Me.Label6.Location = New System.Drawing.Point(733, 98)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 17)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Trị giá"
		'
		'btnTimKiem
		'
		Me.btnTimKiem.Location = New System.Drawing.Point(547, 187)
		Me.btnTimKiem.Name = "btnTimKiem"
		Me.btnTimKiem.Size = New System.Drawing.Size(75, 23)
		Me.btnTimKiem.TabIndex = 2
		Me.btnTimKiem.Text = "Tìm kiếm"
		Me.btnTimKiem.UseSelectable = true
		'
		'dgvListSach
		'
		Me.dgvListSach.AllowUserToResizeRows = false
		Me.dgvListSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvListSach.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvListSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvListSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvListSach.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvListSach.EnableHeadersVisualStyles = false
		Me.dgvListSach.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvListSach.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvListSach.Location = New System.Drawing.Point(36, 234)
		Me.dgvListSach.Name = "dgvListSach"
		Me.dgvListSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvListSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvListSach.RowTemplate.Height = 24
		Me.dgvListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvListSach.Size = New System.Drawing.Size(1192, 462)
		Me.dgvListSach.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.Location = New System.Drawing.Point(76, 122)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(59, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Thể loại"
		'
		'Label1
		'
		Me.Label1.AutoSize = true
		Me.Label1.Location = New System.Drawing.Point(76, 75)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(67, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Tên sách"
		'
		'txtTenSach
		'
		'
		'
		'
		Me.txtTenSach.CustomButton.Image = Nothing
		Me.txtTenSach.CustomButton.Location = New System.Drawing.Point(151, 2)
		Me.txtTenSach.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTenSach.CustomButton.Name = ""
		Me.txtTenSach.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenSach.CustomButton.TabIndex = 1
		Me.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenSach.CustomButton.UseSelectable = true
		Me.txtTenSach.CustomButton.Visible = false
		Me.txtTenSach.Lines = New String(-1) {}
		Me.txtTenSach.Location = New System.Drawing.Point(175, 64)
		Me.txtTenSach.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTenSach.MaxLength = 32767
		Me.txtTenSach.Name = "txtTenSach"
		Me.txtTenSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenSach.SelectedText = ""
		Me.txtTenSach.SelectionLength = 0
		Me.txtTenSach.SelectionStart = 0
		Me.txtTenSach.ShortcutsEnabled = true
		Me.txtTenSach.Size = New System.Drawing.Size(177, 28)
		Me.txtTenSach.TabIndex = 4
		Me.txtTenSach.UseSelectable = true
		Me.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtTenSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtNhaXuatBan
		'
		'
		'
		'
		Me.txtNhaXuatBan.CustomButton.Image = Nothing
		Me.txtNhaXuatBan.CustomButton.Location = New System.Drawing.Point(151, 2)
		Me.txtNhaXuatBan.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNhaXuatBan.CustomButton.Name = ""
		Me.txtNhaXuatBan.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtNhaXuatBan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNhaXuatBan.CustomButton.TabIndex = 1
		Me.txtNhaXuatBan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNhaXuatBan.CustomButton.UseSelectable = true
		Me.txtNhaXuatBan.CustomButton.Visible = false
		Me.txtNhaXuatBan.Lines = New String(-1) {}
		Me.txtNhaXuatBan.Location = New System.Drawing.Point(498, 64)
		Me.txtNhaXuatBan.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNhaXuatBan.MaxLength = 32767
		Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
		Me.txtNhaXuatBan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNhaXuatBan.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNhaXuatBan.SelectedText = ""
		Me.txtNhaXuatBan.SelectionLength = 0
		Me.txtNhaXuatBan.SelectionStart = 0
		Me.txtNhaXuatBan.ShortcutsEnabled = true
		Me.txtNhaXuatBan.Size = New System.Drawing.Size(177, 28)
		Me.txtNhaXuatBan.TabIndex = 4
		Me.txtNhaXuatBan.UseSelectable = true
		Me.txtNhaXuatBan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtNhaXuatBan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTacGia
		'
		'
		'
		'
		Me.txtTacGia.CustomButton.Image = Nothing
		Me.txtTacGia.CustomButton.Location = New System.Drawing.Point(151, 2)
		Me.txtTacGia.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTacGia.CustomButton.Name = ""
		Me.txtTacGia.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTacGia.CustomButton.TabIndex = 1
		Me.txtTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTacGia.CustomButton.UseSelectable = true
		Me.txtTacGia.CustomButton.Visible = false
		Me.txtTacGia.Lines = New String(-1) {}
		Me.txtTacGia.Location = New System.Drawing.Point(498, 124)
		Me.txtTacGia.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTacGia.MaxLength = 32767
		Me.txtTacGia.Name = "txtTacGia"
		Me.txtTacGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTacGia.SelectedText = ""
		Me.txtTacGia.SelectionLength = 0
		Me.txtTacGia.SelectionStart = 0
		Me.txtTacGia.ShortcutsEnabled = true
		Me.txtTacGia.Size = New System.Drawing.Size(177, 28)
		Me.txtTacGia.TabIndex = 4
		Me.txtTacGia.UseSelectable = true
		Me.txtTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtTacGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'cbTheLoaiSach
		'
		Me.cbTheLoaiSach.FormattingEnabled = true
		Me.cbTheLoaiSach.ItemHeight = 24
		Me.cbTheLoaiSach.Location = New System.Drawing.Point(175, 122)
		Me.cbTheLoaiSach.Name = "cbTheLoaiSach"
		Me.cbTheLoaiSach.Size = New System.Drawing.Size(177, 30)
		Me.cbTheLoaiSach.TabIndex = 5
		Me.cbTheLoaiSach.UseSelectable = true
		'
		'nudMinTriGia
		'
		Me.nudMinTriGia.Location = New System.Drawing.Point(914, 92)
		Me.nudMinTriGia.Name = "nudMinTriGia"
		Me.nudMinTriGia.Size = New System.Drawing.Size(88, 22)
		Me.nudMinTriGia.TabIndex = 6
		'
		'Label8
		'
		Me.Label8.AutoSize = true
		Me.Label8.Location = New System.Drawing.Point(875, 95)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(20, 17)
		Me.Label8.TabIndex = 0
		Me.Label8.Text = "từ"
		'
		'Label9
		'
		Me.Label9.AutoSize = true
		Me.Label9.Location = New System.Drawing.Point(1008, 97)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(32, 17)
		Me.Label9.TabIndex = 0
		Me.Label9.Text = "đến"
		'
		'nudMaxTriGia
		'
		Me.nudMaxTriGia.Location = New System.Drawing.Point(1046, 92)
		Me.nudMaxTriGia.Name = "nudMaxTriGia"
		Me.nudMaxTriGia.Size = New System.Drawing.Size(88, 22)
		Me.nudMaxTriGia.TabIndex = 6
		'
		'Label10
		'
		Me.Label10.AutoSize = true
		Me.Label10.Location = New System.Drawing.Point(875, 67)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(20, 17)
		Me.Label10.TabIndex = 0
		Me.Label10.Text = "từ"
		'
		'Label11
		'
		Me.Label11.AutoSize = true
		Me.Label11.Location = New System.Drawing.Point(1008, 69)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(32, 17)
		Me.Label11.TabIndex = 0
		Me.Label11.Text = "đến"
		'
		'nudMinNamXuatBan
		'
		Me.nudMinNamXuatBan.Location = New System.Drawing.Point(914, 64)
		Me.nudMinNamXuatBan.Name = "nudMinNamXuatBan"
		Me.nudMinNamXuatBan.Size = New System.Drawing.Size(88, 22)
		Me.nudMinNamXuatBan.TabIndex = 6
		'
		'nudMaxNamXuatBan
		'
		Me.nudMaxNamXuatBan.Location = New System.Drawing.Point(1046, 64)
		Me.nudMaxNamXuatBan.Name = "nudMaxNamXuatBan"
		Me.nudMaxNamXuatBan.Size = New System.Drawing.Size(88, 22)
		Me.nudMaxNamXuatBan.TabIndex = 6
		'
		'Label12
		'
		Me.Label12.AutoSize = true
		Me.Label12.Location = New System.Drawing.Point(875, 135)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(20, 17)
		Me.Label12.TabIndex = 0
		Me.Label12.Text = "từ"
		'
		'Label13
		'
		Me.Label13.AutoSize = true
		Me.Label13.Location = New System.Drawing.Point(874, 164)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(32, 17)
		Me.Label13.TabIndex = 0
		Me.Label13.Text = "đến"
		'
		'dtpMinNgayNhap
		'
		Me.dtpMinNgayNhap.Location = New System.Drawing.Point(914, 134)
		Me.dtpMinNgayNhap.Name = "dtpMinNgayNhap"
		Me.dtpMinNgayNhap.Size = New System.Drawing.Size(231, 22)
		Me.dtpMinNgayNhap.TabIndex = 7
		'
		'dtpMaxNgayNhap
		'
		Me.dtpMaxNgayNhap.Location = New System.Drawing.Point(914, 162)
		Me.dtpMaxNgayNhap.Name = "dtpMaxNgayNhap"
		Me.dtpMaxNgayNhap.Size = New System.Drawing.Size(231, 22)
		Me.dtpMaxNgayNhap.TabIndex = 7
		'
		'frmTraCuuSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1251, 764)
		Me.Controls.Add(Me.dtpMaxNgayNhap)
		Me.Controls.Add(Me.dtpMinNgayNhap)
		Me.Controls.Add(Me.nudMaxNamXuatBan)
		Me.Controls.Add(Me.nudMaxTriGia)
		Me.Controls.Add(Me.nudMinNamXuatBan)
		Me.Controls.Add(Me.nudMinTriGia)
		Me.Controls.Add(Me.cbTheLoaiSach)
		Me.Controls.Add(Me.txtTacGia)
		Me.Controls.Add(Me.txtNhaXuatBan)
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
		Me.Name = "frmTraCuuSach"
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
	Friend WithEvents dtpMinNgayNhap As DateTimePicker
	Friend WithEvents dtpMaxNgayNhap As DateTimePicker
End Class
