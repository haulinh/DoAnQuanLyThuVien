﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
		Me.components = New System.ComponentModel.Container()
		Me.cmHoSoDocGia = New MetroFramework.Controls.MetroContextMenu(Me.components)
		Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuảnLíToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ThêmLoạiĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuảnLíĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LậpThẻMượnSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ThêmTácGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnHoSoDocGia = New MetroFramework.Controls.MetroButton()
		Me.cmQuanLi = New MetroFramework.Controls.MetroContextMenu(Me.components)
		Me.ThemSachToolTrip = New System.Windows.Forms.ToolStripMenuItem()
		Me.ThêmThểLoạiSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuảnLýThểLoạiSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuảnLýSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TraCứuSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnQuanLi = New MetroFramework.Controls.MetroButton()
		Me.cmQuyDinh = New MetroFramework.Controls.MetroContextMenu(Me.components)
		Me.QuyĐịnhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnQuyDinh = New MetroFramework.Controls.MetroButton()
		Me.QuảnLíThẻMượnSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.cmHoSoDocGia.SuspendLayout()
		Me.cmQuanLi.SuspendLayout()
		Me.cmQuyDinh.SuspendLayout()
		Me.SuspendLayout()
		'
		'cmHoSoDocGia
		'
		Me.cmHoSoDocGia.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmHoSoDocGia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.QuảnLíToolStripMenuItem, Me.ThêmLoạiĐộcGiảToolStripMenuItem, Me.QuảnLíĐộcGiảToolStripMenuItem, Me.LậpThẻMượnSáchToolStripMenuItem, Me.ThêmTácGiảToolStripMenuItem, Me.QuảnLíThẻMượnSáchToolStripMenuItem})
		Me.cmHoSoDocGia.Name = "MetroContextMenu1"
		Me.cmHoSoDocGia.Size = New System.Drawing.Size(212, 180)
		Me.cmHoSoDocGia.Text = "Hồ sơ độc giả"
		'
		'QuảnLýToolStripMenuItem
		'
		Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
		Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.QuảnLýToolStripMenuItem.Text = "Thêm loại độc giả "
		'
		'QuảnLíToolStripMenuItem
		'
		Me.QuảnLíToolStripMenuItem.Name = "QuảnLíToolStripMenuItem"
		Me.QuảnLíToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.QuảnLíToolStripMenuItem.Text = "Quản lí loại độc giả "
		'
		'ThêmLoạiĐộcGiảToolStripMenuItem
		'
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Name = "ThêmLoạiĐộcGiảToolStripMenuItem"
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Text = "Thêm độc giả "
		'
		'QuảnLíĐộcGiảToolStripMenuItem
		'
		Me.QuảnLíĐộcGiảToolStripMenuItem.Name = "QuảnLíĐộcGiảToolStripMenuItem"
		Me.QuảnLíĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.QuảnLíĐộcGiảToolStripMenuItem.Text = "Quản lí độc giả"
		'
		'LậpThẻMượnSáchToolStripMenuItem
		'
		Me.LậpThẻMượnSáchToolStripMenuItem.Name = "LậpThẻMượnSáchToolStripMenuItem"
		Me.LậpThẻMượnSáchToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.LậpThẻMượnSáchToolStripMenuItem.Text = "Lập Thẻ Mượn Sách"
		'
		'ThêmTácGiảToolStripMenuItem
		'
		Me.ThêmTácGiảToolStripMenuItem.Name = "ThêmTácGiảToolStripMenuItem"
		Me.ThêmTácGiảToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.ThêmTácGiảToolStripMenuItem.Text = "Thêm Tác Giả"
		'
		'btnHoSoDocGia
		'
		Me.btnHoSoDocGia.Location = New System.Drawing.Point(128, 74)
		Me.btnHoSoDocGia.Name = "btnHoSoDocGia"
		Me.btnHoSoDocGia.Size = New System.Drawing.Size(100, 23)
		Me.btnHoSoDocGia.TabIndex = 1
		Me.btnHoSoDocGia.Text = "Hồ sơ độc giả"
		Me.btnHoSoDocGia.UseSelectable = True
		'
		'cmQuanLi
		'
		Me.cmQuanLi.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmQuanLi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemSachToolTrip, Me.ThêmThểLoạiSáchToolStripMenuItem, Me.QuảnLýThểLoạiSáchToolStripMenuItem, Me.QuảnLýSáchToolStripMenuItem, Me.TraCứuSáchToolStripMenuItem})
		Me.cmQuanLi.Name = "cmQuanLi"
		Me.cmQuanLi.Size = New System.Drawing.Size(194, 114)
		'
		'ThemSachToolTrip
		'
		Me.ThemSachToolTrip.Name = "ThemSachToolTrip"
		Me.ThemSachToolTrip.Size = New System.Drawing.Size(193, 22)
		Me.ThemSachToolTrip.Text = "Thêm Sách"
		'
		'ThêmThểLoạiSáchToolStripMenuItem
		'
		Me.ThêmThểLoạiSáchToolStripMenuItem.Name = "ThêmThểLoạiSáchToolStripMenuItem"
		Me.ThêmThểLoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
		Me.ThêmThểLoạiSáchToolStripMenuItem.Text = "Thêm Thể Loại Sách"
		'
		'QuảnLýThểLoạiSáchToolStripMenuItem
		'
		Me.QuảnLýThểLoạiSáchToolStripMenuItem.Name = "QuảnLýThểLoạiSáchToolStripMenuItem"
		Me.QuảnLýThểLoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
		Me.QuảnLýThểLoạiSáchToolStripMenuItem.Text = "Quản Lý Thể Loại Sách"
		'
		'QuảnLýSáchToolStripMenuItem
		'
		Me.QuảnLýSáchToolStripMenuItem.Name = "QuảnLýSáchToolStripMenuItem"
		Me.QuảnLýSáchToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
		Me.QuảnLýSáchToolStripMenuItem.Text = "Quản Lý  Sách"
		'
		'TraCứuSáchToolStripMenuItem
		'
		Me.TraCứuSáchToolStripMenuItem.Name = "TraCứuSáchToolStripMenuItem"
		Me.TraCứuSáchToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
		Me.TraCứuSáchToolStripMenuItem.Text = "Tra cứu Sách"
		'
		'btnQuanLi
		'
		Me.btnQuanLi.Location = New System.Drawing.Point(228, 74)
		Me.btnQuanLi.Name = "btnQuanLi"
		Me.btnQuanLi.Size = New System.Drawing.Size(100, 23)
		Me.btnQuanLi.TabIndex = 0
		Me.btnQuanLi.Text = "Quản Lí Sách"
		Me.btnQuanLi.UseSelectable = True
		'
		'cmQuyDinh
		'
		Me.cmQuyDinh.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmQuyDinh.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuyĐịnhToolStripMenuItem})
		Me.cmQuyDinh.Name = "cmQuyDinh"
		Me.cmQuyDinh.Size = New System.Drawing.Size(125, 26)
		'
		'QuyĐịnhToolStripMenuItem
		'
		Me.QuyĐịnhToolStripMenuItem.Name = "QuyĐịnhToolStripMenuItem"
		Me.QuyĐịnhToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
		Me.QuyĐịnhToolStripMenuItem.Text = "Quy Định"
		'
		'btnQuyDinh
		'
		Me.btnQuyDinh.Location = New System.Drawing.Point(28, 74)
		Me.btnQuyDinh.Name = "btnQuyDinh"
		Me.btnQuyDinh.Size = New System.Drawing.Size(100, 23)
		Me.btnQuyDinh.TabIndex = 4
		Me.btnQuyDinh.Text = "Quy Định"
		Me.btnQuyDinh.UseSelectable = True
		'
		'QuảnLíThẻMượnSáchToolStripMenuItem
		'
		Me.QuảnLíThẻMượnSáchToolStripMenuItem.Name = "QuảnLíThẻMượnSáchToolStripMenuItem"
		Me.QuảnLíThẻMượnSáchToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
		Me.QuảnLíThẻMượnSáchToolStripMenuItem.Text = "Quản Lí Phiếu Mượn Sách"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1040, 640)
		Me.Controls.Add(Me.btnQuyDinh)
		Me.Controls.Add(Me.btnQuanLi)
		Me.Controls.Add(Me.btnHoSoDocGia)
		Me.IsMdiContainer = True
		Me.Name = "frmMain"
		Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
		Me.Text = "Quản lí độc giả"
		Me.TransparencyKey = System.Drawing.Color.Empty
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.cmHoSoDocGia.ResumeLayout(false)
		Me.cmQuanLi.ResumeLayout(false)
		Me.cmQuyDinh.ResumeLayout(false)
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents cmHoSoDocGia As MetroFramework.Controls.MetroContextMenu
	Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuảnLíToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ThêmLoạiĐộcGiảToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuảnLíĐộcGiảToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btnHoSoDocGia As MetroFramework.Controls.MetroButton
	Friend WithEvents cmQuanLi As MetroFramework.Controls.MetroContextMenu
	Friend WithEvents ThemSachToolTrip As ToolStripMenuItem
	Friend WithEvents btnQuanLi As MetroFramework.Controls.MetroButton
	Friend WithEvents ThêmThểLoạiSáchToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuảnLýThểLoạiSáchToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuảnLýSáchToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents cmQuyDinh As MetroFramework.Controls.MetroContextMenu
	Friend WithEvents btnQuyDinh As MetroFramework.Controls.MetroButton
	Friend WithEvents QuyĐịnhToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TraCứuSáchToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LậpThẻMượnSáchToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ThêmTácGiảToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuảnLíThẻMượnSáchToolStripMenuItem As ToolStripMenuItem
End Class
