<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.components = New System.ComponentModel.Container()
		Me.cmHoSoDocGia = New MetroFramework.Controls.MetroContextMenu(Me.components)
		Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuảnLíToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ThêmLoạiĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuảnLíĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnHoSoDocGia = New MetroFramework.Controls.MetroButton()
		Me.cmHoSoDocGia.SuspendLayout()
		Me.SuspendLayout()
		'
		'cmHoSoDocGia
		'
		Me.cmHoSoDocGia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.QuảnLíToolStripMenuItem, Me.ThêmLoạiĐộcGiảToolStripMenuItem, Me.QuảnLíĐộcGiảToolStripMenuItem})
		Me.cmHoSoDocGia.Name = "MetroContextMenu1"
		Me.cmHoSoDocGia.Size = New System.Drawing.Size(180, 92)
		Me.cmHoSoDocGia.Text = "Hồ sơ độc giả"
		'
		'QuảnLýToolStripMenuItem
		'
		Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
		Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.QuảnLýToolStripMenuItem.Text = "Thêm loại độc giả "
		'
		'QuảnLíToolStripMenuItem
		'
		Me.QuảnLíToolStripMenuItem.Name = "QuảnLíToolStripMenuItem"
		Me.QuảnLíToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.QuảnLíToolStripMenuItem.Text = "Quản lí loại độc giả "
		'
		'ThêmLoạiĐộcGiảToolStripMenuItem
		'
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Name = "ThêmLoạiĐộcGiảToolStripMenuItem"
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.ThêmLoạiĐộcGiảToolStripMenuItem.Text = "Thêm độc  giả "
		'
		'QuảnLíĐộcGiảToolStripMenuItem
		'
		Me.QuảnLíĐộcGiảToolStripMenuItem.Name = "QuảnLíĐộcGiảToolStripMenuItem"
		Me.QuảnLíĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.QuảnLíĐộcGiảToolStripMenuItem.Text = "Quản lí độc giả"
		'
		'btnHoSoDocGia
		'
		Me.btnHoSoDocGia.Location = New System.Drawing.Point(22, 61)
		Me.btnHoSoDocGia.Name = "btnHoSoDocGia"
		Me.btnHoSoDocGia.Size = New System.Drawing.Size(100, 23)
		Me.btnHoSoDocGia.TabIndex = 2
		Me.btnHoSoDocGia.Text = "Hồ sơ độc giả"
		Me.btnHoSoDocGia.UseSelectable = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(933, 480)
		Me.Controls.Add(Me.btnHoSoDocGia)
		Me.IsMdiContainer = True
		Me.Name = "frmMain"
		Me.Text = "Quản lí độc giả"
		Me.TransparencyKey = System.Drawing.Color.Empty
		Me.cmHoSoDocGia.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents cmHoSoDocGia As MetroFramework.Controls.MetroContextMenu
	Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuảnLíToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ThêmLoạiĐộcGiảToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuảnLíĐộcGiảToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btnHoSoDocGia As MetroFramework.Controls.MetroButton
End Class
