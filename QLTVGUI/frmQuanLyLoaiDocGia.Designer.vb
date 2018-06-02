<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyLoaiDocGia
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
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.HtmlLabel1 = New MetroFramework.Drawing.Html.HtmlLabel()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.dgvDanhSachLoaiDocGia = New MetroFramework.Controls.MetroGrid()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaLoai = New MetroFramework.Controls.MetroTextBox()
		Me.btnCapNhap = New MetroFramework.Controls.MetroButton()
		Me.btnXoa = New MetroFramework.Controls.MetroButton()
		Me.txtTenLoai = New MetroFramework.Controls.MetroTextBox()
		CType(Me.dgvDanhSachLoaiDocGia,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'HtmlLabel1
		'
		Me.HtmlLabel1.AutoScroll = true
		Me.HtmlLabel1.AutoScrollMinSize = New System.Drawing.Size(76, 25)
		Me.HtmlLabel1.AutoSize = false
		Me.HtmlLabel1.BackColor = System.Drawing.SystemColors.Window
		Me.HtmlLabel1.Location = New System.Drawing.Point(-19, -18)
		Me.HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.HtmlLabel1.Name = "HtmlLabel1"
		Me.HtmlLabel1.Size = New System.Drawing.Size(75, 23)
		Me.HtmlLabel1.TabIndex = 0
		Me.HtmlLabel1.Text = "HtmlLabel1"
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = true
		Me.MetroLabel1.Location = New System.Drawing.Point(238, 75)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(157, 20)
		Me.MetroLabel1.TabIndex = 1
		Me.MetroLabel1.Text = "Danh Sách Loại Độc Giả"
		'
		'dgvDanhSachLoaiDocGia
		'
		Me.dgvDanhSachLoaiDocGia.AllowUserToResizeRows = false
		Me.dgvDanhSachLoaiDocGia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvDanhSachLoaiDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvDanhSachLoaiDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvDanhSachLoaiDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDanhSachLoaiDocGia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.dgvDanhSachLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvDanhSachLoaiDocGia.DefaultCellStyle = DataGridViewCellStyle5
		Me.dgvDanhSachLoaiDocGia.EnableHeadersVisualStyles = false
		Me.dgvDanhSachLoaiDocGia.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvDanhSachLoaiDocGia.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvDanhSachLoaiDocGia.Location = New System.Drawing.Point(143, 97)
		Me.dgvDanhSachLoaiDocGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.dgvDanhSachLoaiDocGia.Name = "dgvDanhSachLoaiDocGia"
		Me.dgvDanhSachLoaiDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDanhSachLoaiDocGia.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
		Me.dgvDanhSachLoaiDocGia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvDanhSachLoaiDocGia.RowTemplate.Height = 24
		Me.dgvDanhSachLoaiDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDanhSachLoaiDocGia.Size = New System.Drawing.Size(403, 261)
		Me.dgvDanhSachLoaiDocGia.TabIndex = 2
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = true
		Me.MetroLabel2.Location = New System.Drawing.Point(245, 396)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(60, 20)
		Me.MetroLabel2.TabIndex = 3
		Me.MetroLabel2.Text = "Mã Loại:"
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = true
		Me.MetroLabel3.Location = New System.Drawing.Point(242, 438)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(63, 20)
		Me.MetroLabel3.TabIndex = 4
		Me.MetroLabel3.Text = "Tên Loại:"
		'
		'txtMaLoai
		'
		'
		'
		'
		Me.txtMaLoai.CustomButton.Image = Nothing
		Me.txtMaLoai.CustomButton.Location = New System.Drawing.Point(71, 1)
		Me.txtMaLoai.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtMaLoai.CustomButton.Name = ""
		Me.txtMaLoai.CustomButton.Size = New System.Drawing.Size(28, 26)
		Me.txtMaLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaLoai.CustomButton.TabIndex = 1
		Me.txtMaLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaLoai.CustomButton.UseSelectable = true
		Me.txtMaLoai.CustomButton.Visible = false
		Me.txtMaLoai.Lines = New String(-1) {}
		Me.txtMaLoai.Location = New System.Drawing.Point(373, 391)
		Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtMaLoai.MaxLength = 32767
		Me.txtMaLoai.Name = "txtMaLoai"
		Me.txtMaLoai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaLoai.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaLoai.SelectedText = ""
		Me.txtMaLoai.SelectionLength = 0
		Me.txtMaLoai.SelectionStart = 0
		Me.txtMaLoai.ShortcutsEnabled = true
		Me.txtMaLoai.Size = New System.Drawing.Size(75, 23)
		Me.txtMaLoai.TabIndex = 5
		Me.txtMaLoai.UseSelectable = true
		Me.txtMaLoai.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtMaLoai.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnCapNhap
		'
		Me.btnCapNhap.Location = New System.Drawing.Point(197, 487)
		Me.btnCapNhap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.btnCapNhap.Name = "btnCapNhap"
		Me.btnCapNhap.Size = New System.Drawing.Size(108, 23)
		Me.btnCapNhap.TabIndex = 7
		Me.btnCapNhap.Text = "Cập Nhập"
		Me.btnCapNhap.UseSelectable = true
		'
		'btnXoa
		'
		Me.btnXoa.Location = New System.Drawing.Point(373, 487)
		Me.btnXoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.btnXoa.Name = "btnXoa"
		Me.btnXoa.Size = New System.Drawing.Size(75, 23)
		Me.btnXoa.TabIndex = 7
		Me.btnXoa.Text = "Xoá"
		Me.btnXoa.UseSelectable = true
		'
		'txtTenLoai
		'
		'
		'
		'
		Me.txtTenLoai.CustomButton.Image = Nothing
		Me.txtTenLoai.CustomButton.Location = New System.Drawing.Point(71, 1)
		Me.txtTenLoai.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtTenLoai.CustomButton.Name = ""
		Me.txtTenLoai.CustomButton.Size = New System.Drawing.Size(28, 26)
		Me.txtTenLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenLoai.CustomButton.TabIndex = 1
		Me.txtTenLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenLoai.CustomButton.UseSelectable = true
		Me.txtTenLoai.CustomButton.Visible = false
		Me.txtTenLoai.Lines = New String(-1) {}
		Me.txtTenLoai.Location = New System.Drawing.Point(373, 434)
		Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtTenLoai.MaxLength = 32767
		Me.txtTenLoai.Name = "txtTenLoai"
		Me.txtTenLoai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenLoai.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenLoai.SelectedText = ""
		Me.txtTenLoai.SelectionLength = 0
		Me.txtTenLoai.SelectionStart = 0
		Me.txtTenLoai.ShortcutsEnabled = true
		Me.txtTenLoai.Size = New System.Drawing.Size(75, 23)
		Me.txtTenLoai.TabIndex = 5
		Me.txtTenLoai.UseSelectable = true
		Me.txtTenLoai.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtTenLoai.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'frmQuanLyLoaiDocGia
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(658, 574)
		Me.Controls.Add(Me.btnXoa)
		Me.Controls.Add(Me.btnCapNhap)
		Me.Controls.Add(Me.txtTenLoai)
		Me.Controls.Add(Me.txtMaLoai)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.dgvDanhSachLoaiDocGia)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Controls.Add(Me.HtmlLabel1)
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmQuanLyLoaiDocGia"
		Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
		Me.Text = "Quản Lý Loại Độc Giả"
		CType(Me.dgvDanhSachLoaiDocGia,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents HtmlLabel1 As MetroFramework.Drawing.Html.HtmlLabel
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents dgvDanhSachLoaiDocGia As MetroFramework.Controls.MetroGrid
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaLoai As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnCapNhap As MetroFramework.Controls.MetroButton
	Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
	Friend WithEvents txtTenLoai As MetroFramework.Controls.MetroTextBox
End Class
