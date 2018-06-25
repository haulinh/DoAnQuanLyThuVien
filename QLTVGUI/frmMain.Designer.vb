<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Me.cmHoSoDocGia.SuspendLayout
		Me.cmQuanLi.SuspendLayout
		Me.cmQuyDinh.SuspendLayout
		Me.SuspendLayout
		'
		'cmHoSoDocGia
		'
		Me.cmHoSoDocGia.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmHoSoDocGia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.QuảnLíToolStripMenuItem, Me.ThêmLoạiĐộcGiảToolStripMenuItem, Me.QuảnLíĐộcGiảToolStripMenuItem, Me.LậpThẻMượnSáchToolStripMenuItem})
		Me.cmHoSoDocGia.Name = "MetroContextMenu1"
		Me.cmHoSoDocGia.Size = New System.Drawing.Size(213, 124)
		Me.cmHoSoDocGia.Text = "Hồ sơ độc giả"
		'
		'QuảnLýToolStripMenuItem
		'
		Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
		Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
		Me.QuảnLýToolStripMenuItem.Text = "Thêm loại độc giả "
		'
		'QuảnLíToolStripMenuItem
		'
		Me.QuảnLíToolStripMenuItem.Name = "QuảnLíToolStripMenuItem"
		Me.QuảnLíToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
		Me.QuảnLíToolStripMenuItem.Text = "Quản lí loại độc giả "
		'
		'ThêmLoạiĐộcGiảToolStripMenuItem
		'
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Name = "ThêmLoạiĐộcGiảToolStripMenuItem"
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Text = "Thêm độc  giả "
		'
		'QuảnLíĐộcGiảToolStripMenuItem
		'
		Me.QuảnLíĐộcGiảToolStripMenuItem.Name = "QuảnLíĐộcGiảToolStripMenuItem"
		Me.QuảnLíĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
		Me.QuảnLíĐộcGiảToolStripMenuItem.Text = "Quản lí độc giả"
		'
		'LậpThẻMượnSáchToolStripMenuItem
		'
		Me.LậpThẻMượnSáchToolStripMenuItem.Name = "LậpThẻMượnSáchToolStripMenuItem"
		Me.LậpThẻMượnSáchToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
		Me.LậpThẻMượnSáchToolStripMenuItem.Text = "Lập Thẻ Mượn Sách"
		'
		'btnHoSoDocGia
		'
		Me.btnHoSoDocGia.Location = New System.Drawing.Point(171, 91)
		Me.btnHoSoDocGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnHoSoDocGia.Name = "btnHoSoDocGia"
		Me.btnHoSoDocGia.Size = New System.Drawing.Size(133, 28)
		Me.btnHoSoDocGia.TabIndex = 1
		Me.btnHoSoDocGia.Text = "Hồ sơ độc giả"
		Me.btnHoSoDocGia.UseSelectable = true
		'
		'cmQuanLi
		'
		Me.cmQuanLi.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmQuanLi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemSachToolTrip, Me.ThêmThểLoạiSáchToolStripMenuItem, Me.QuảnLýThểLoạiSáchToolStripMenuItem, Me.QuảnLýSáchToolStripMenuItem, Me.TraCứuSáchToolStripMenuItem})
		Me.cmQuanLi.Name = "cmQuanLi"
		Me.cmQuanLi.Size = New System.Drawing.Size(226, 124)
		'
		'ThemSachToolTrip
		'
		Me.ThemSachToolTrip.Name = "ThemSachToolTrip"
		Me.ThemSachToolTrip.Size = New System.Drawing.Size(225, 24)
		Me.ThemSachToolTrip.Text = "Thêm Sách"
		'
		'ThêmThểLoạiSáchToolStripMenuItem
		'
		Me.ThêmThểLoạiSáchToolStripMenuItem.Name = "ThêmThểLoạiSáchToolStripMenuItem"
		Me.ThêmThểLoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
		Me.ThêmThểLoạiSáchToolStripMenuItem.Text = "Thêm Thể Loại Sách"
		'
		'QuảnLýThểLoạiSáchToolStripMenuItem
		'
		Me.QuảnLýThểLoạiSáchToolStripMenuItem.Name = "QuảnLýThểLoạiSáchToolStripMenuItem"
		Me.QuảnLýThểLoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
		Me.QuảnLýThểLoạiSáchToolStripMenuItem.Text = "Quản Lý Thể Loại Sách"
		'
		'QuảnLýSáchToolStripMenuItem
		'
		Me.QuảnLýSáchToolStripMenuItem.Name = "QuảnLýSáchToolStripMenuItem"
		Me.QuảnLýSáchToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
		Me.QuảnLýSáchToolStripMenuItem.Text = "Quản Lý  Sách"
		'
		'TraCứuSáchToolStripMenuItem
		'
		Me.TraCứuSáchToolStripMenuItem.Name = "TraCứuSáchToolStripMenuItem"
		Me.TraCứuSáchToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
		Me.TraCứuSáchToolStripMenuItem.Text = "Tra cứu Sách"
		'
		'btnQuanLi
		'
		Me.btnQuanLi.Location = New System.Drawing.Point(304, 91)
		Me.btnQuanLi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnQuanLi.Name = "btnQuanLi"
		Me.btnQuanLi.Size = New System.Drawing.Size(133, 28)
		Me.btnQuanLi.TabIndex = 0
		Me.btnQuanLi.Text = "Quản Lí Sách"
		Me.btnQuanLi.UseSelectable = true
		'
		'cmQuyDinh
		'
		Me.cmQuyDinh.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmQuyDinh.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuyĐịnhToolStripMenuItem})
		Me.cmQuyDinh.Name = "cmQuyDinh"
		Me.cmQuyDinh.Size = New System.Drawing.Size(140, 28)
		'
		'QuyĐịnhToolStripMenuItem
		'
		Me.QuyĐịnhToolStripMenuItem.Name = "QuyĐịnhToolStripMenuItem"
		Me.QuyĐịnhToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
		Me.QuyĐịnhToolStripMenuItem.Text = "Quy Định"
		'
		'btnQuyDinh
		'
		Me.btnQuyDinh.Location = New System.Drawing.Point(37, 91)
		Me.btnQuyDinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnQuyDinh.Name = "btnQuyDinh"
		Me.btnQuyDinh.Size = New System.Drawing.Size(133, 28)
		Me.btnQuyDinh.TabIndex = 4
		Me.btnQuyDinh.Text = "Quy Định"
		Me.btnQuyDinh.UseSelectable = true
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1450, 925)
		Me.Controls.Add(Me.btnQuyDinh)
		Me.Controls.Add(Me.btnQuanLi)
		Me.Controls.Add(Me.btnHoSoDocGia)
		Me.IsMdiContainer = true
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "frmMain"
		Me.Padding = New System.Windows.Forms.Padding(36, 91, 36, 31)
		Me.Text = "Quản lí độc giả"
		Me.TransparencyKey = System.Drawing.Color.Empty
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
End Class
