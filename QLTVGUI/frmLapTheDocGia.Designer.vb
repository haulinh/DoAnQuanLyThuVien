﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapTheDocGia
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
		Me.btnNhap = New MetroFramework.Controls.MetroButton()
		Me.btnNhapDong = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaDocGia = New MetroFramework.Controls.MetroTextBox()
		Me.txtHoTen = New MetroFramework.Controls.MetroTextBox()
		Me.dtNgaySinh = New MetroFramework.Controls.MetroDateTime()
		Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
		Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
		Me.txtDiaChi = New MetroFramework.Controls.MetroTextBox()
		Me.dtNgayLapThe = New MetroFramework.Controls.MetroDateTime()
		Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
		Me.SuspendLayout()
		'
		'btnNhap
		'
		Me.btnNhap.Location = New System.Drawing.Point(158, 309)
		Me.btnNhap.Name = "btnNhap"
		Me.btnNhap.Size = New System.Drawing.Size(75, 23)
		Me.btnNhap.TabIndex = 4
		Me.btnNhap.Text = "Nhập"
		Me.btnNhap.UseSelectable = True
		'
		'btnNhapDong
		'
		Me.btnNhapDong.Location = New System.Drawing.Point(260, 309)
		Me.btnNhapDong.Name = "btnNhapDong"
		Me.btnNhapDong.Size = New System.Drawing.Size(94, 23)
		Me.btnNhapDong.TabIndex = 5
		Me.btnNhapDong.Text = "Nhập và đóng"
		Me.btnNhapDong.UseSelectable = True
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(40, 60)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(76, 19)
		Me.MetroLabel1.TabIndex = 6
		Me.MetroLabel1.Text = "Mã độc giả"
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(40, 95)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(65, 19)
		Me.MetroLabel2.TabIndex = 7
		Me.MetroLabel2.Text = "Họ và tên"
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(40, 136)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(66, 19)
		Me.MetroLabel4.TabIndex = 9
		Me.MetroLabel4.Text = "Ngày sinh"
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = True
		Me.MetroLabel5.Location = New System.Drawing.Point(40, 200)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(48, 19)
		Me.MetroLabel5.TabIndex = 10
		Me.MetroLabel5.Text = "Địa chỉ"
		'
		'MetroLabel7
		'
		Me.MetroLabel7.AutoSize = True
		Me.MetroLabel7.Location = New System.Drawing.Point(40, 270)
		Me.MetroLabel7.Name = "MetroLabel7"
		Me.MetroLabel7.Size = New System.Drawing.Size(84, 19)
		Me.MetroLabel7.TabIndex = 12
		Me.MetroLabel7.Text = "Ngày lập thẻ"
		'
		'txtMaDocGia
		'
		'
		'
		'
		Me.txtMaDocGia.CustomButton.Image = Nothing
		Me.txtMaDocGia.CustomButton.Location = New System.Drawing.Point(174, 1)
		Me.txtMaDocGia.CustomButton.Name = ""
		Me.txtMaDocGia.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMaDocGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaDocGia.CustomButton.TabIndex = 1
		Me.txtMaDocGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaDocGia.CustomButton.UseSelectable = True
		Me.txtMaDocGia.CustomButton.Visible = False
		Me.txtMaDocGia.Lines = New String(-1) {}
		Me.txtMaDocGia.Location = New System.Drawing.Point(158, 56)
		Me.txtMaDocGia.MaxLength = 32767
		Me.txtMaDocGia.Name = "txtMaDocGia"
		Me.txtMaDocGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaDocGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaDocGia.SelectedText = ""
		Me.txtMaDocGia.SelectionLength = 0
		Me.txtMaDocGia.SelectionStart = 0
		Me.txtMaDocGia.ShortcutsEnabled = True
		Me.txtMaDocGia.Size = New System.Drawing.Size(196, 23)
		Me.txtMaDocGia.TabIndex = 13
		Me.txtMaDocGia.UseSelectable = True
		Me.txtMaDocGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaDocGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtHoTen
		'
		'
		'
		'
		Me.txtHoTen.CustomButton.Image = Nothing
		Me.txtHoTen.CustomButton.Location = New System.Drawing.Point(174, 1)
		Me.txtHoTen.CustomButton.Name = ""
		Me.txtHoTen.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtHoTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtHoTen.CustomButton.TabIndex = 1
		Me.txtHoTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtHoTen.CustomButton.UseSelectable = True
		Me.txtHoTen.CustomButton.Visible = False
		Me.txtHoTen.Lines = New String(-1) {}
		Me.txtHoTen.Location = New System.Drawing.Point(158, 87)
		Me.txtHoTen.MaxLength = 32767
		Me.txtHoTen.Name = "txtHoTen"
		Me.txtHoTen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtHoTen.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHoTen.SelectedText = ""
		Me.txtHoTen.SelectionLength = 0
		Me.txtHoTen.SelectionStart = 0
		Me.txtHoTen.ShortcutsEnabled = True
		Me.txtHoTen.Size = New System.Drawing.Size(196, 23)
		Me.txtHoTen.TabIndex = 13
		Me.txtHoTen.UseSelectable = True
		Me.txtHoTen.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtHoTen.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'dtNgaySinh
		'
		Me.dtNgaySinh.Location = New System.Drawing.Point(158, 136)
		Me.dtNgaySinh.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtNgaySinh.Name = "dtNgaySinh"
		Me.dtNgaySinh.Size = New System.Drawing.Size(196, 29)
		Me.dtNgaySinh.TabIndex = 14
		'
		'txtEmail
		'
		'
		'
		'
		Me.txtEmail.CustomButton.Image = Nothing
		Me.txtEmail.CustomButton.Location = New System.Drawing.Point(174, 1)
		Me.txtEmail.CustomButton.Name = ""
		Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtEmail.CustomButton.TabIndex = 1
		Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtEmail.CustomButton.UseSelectable = True
		Me.txtEmail.CustomButton.Visible = False
		Me.txtEmail.Lines = New String(-1) {}
		Me.txtEmail.Location = New System.Drawing.Point(158, 223)
		Me.txtEmail.MaxLength = 32767
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEmail.SelectedText = ""
		Me.txtEmail.SelectionLength = 0
		Me.txtEmail.SelectionStart = 0
		Me.txtEmail.ShortcutsEnabled = True
		Me.txtEmail.Size = New System.Drawing.Size(196, 23)
		Me.txtEmail.TabIndex = 15
		Me.txtEmail.UseSelectable = True
		Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'MetroLabel8
		'
		Me.MetroLabel8.AutoSize = True
		Me.MetroLabel8.Location = New System.Drawing.Point(40, 235)
		Me.MetroLabel8.Name = "MetroLabel8"
		Me.MetroLabel8.Size = New System.Drawing.Size(41, 19)
		Me.MetroLabel8.TabIndex = 11
		Me.MetroLabel8.Text = "Email"
		'
		'txtDiaChi
		'
		'
		'
		'
		Me.txtDiaChi.CustomButton.Image = Nothing
		Me.txtDiaChi.CustomButton.Location = New System.Drawing.Point(174, 1)
		Me.txtDiaChi.CustomButton.Name = ""
		Me.txtDiaChi.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtDiaChi.CustomButton.TabIndex = 1
		Me.txtDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtDiaChi.CustomButton.UseSelectable = True
		Me.txtDiaChi.CustomButton.Visible = False
		Me.txtDiaChi.Lines = New String(-1) {}
		Me.txtDiaChi.Location = New System.Drawing.Point(158, 192)
		Me.txtDiaChi.MaxLength = 32767
		Me.txtDiaChi.Name = "txtDiaChi"
		Me.txtDiaChi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDiaChi.SelectedText = ""
		Me.txtDiaChi.SelectionLength = 0
		Me.txtDiaChi.SelectionStart = 0
		Me.txtDiaChi.ShortcutsEnabled = True
		Me.txtDiaChi.Size = New System.Drawing.Size(196, 23)
		Me.txtDiaChi.TabIndex = 15
		Me.txtDiaChi.UseSelectable = True
		Me.txtDiaChi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtDiaChi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'dtNgayLapThe
		'
		Me.dtNgayLapThe.Location = New System.Drawing.Point(158, 254)
		Me.dtNgayLapThe.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtNgayLapThe.Name = "dtNgayLapThe"
		Me.dtNgayLapThe.Size = New System.Drawing.Size(196, 29)
		Me.dtNgayLapThe.TabIndex = 14
		'
		'MetroLabel6
		'
		Me.MetroLabel6.AutoSize = True
		Me.MetroLabel6.Location = New System.Drawing.Point(178, 9)
		Me.MetroLabel6.Name = "MetroLabel6"
		Me.MetroLabel6.Size = New System.Drawing.Size(100, 19)
		Me.MetroLabel6.TabIndex = 16
		Me.MetroLabel6.Text = "Lập thẻ độc giả"
		'
		'frmLapTheDocGia
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(447, 386)
		Me.Controls.Add(Me.MetroLabel6)
		Me.Controls.Add(Me.txtDiaChi)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.dtNgayLapThe)
		Me.Controls.Add(Me.dtNgaySinh)
		Me.Controls.Add(Me.txtHoTen)
		Me.Controls.Add(Me.txtMaDocGia)
		Me.Controls.Add(Me.MetroLabel7)
		Me.Controls.Add(Me.MetroLabel8)
		Me.Controls.Add(Me.MetroLabel5)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Controls.Add(Me.btnNhapDong)
		Me.Controls.Add(Me.btnNhap)
		Me.Name = "frmLapTheDocGia"
		Me.Text = "frmLapTheDocGia"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnNhap As MetroFramework.Controls.MetroButton
	Friend WithEvents btnNhapDong As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaDocGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtHoTen As MetroFramework.Controls.MetroTextBox
	Friend WithEvents dtNgaySinh As MetroFramework.Controls.MetroDateTime
	Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtDiaChi As MetroFramework.Controls.MetroTextBox
	Friend WithEvents dtNgayLapThe As MetroFramework.Controls.MetroDateTime
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
End Class
