Imports System.Configuration

Public Class frmMain

	Private ConnectionString As String
	Private Sub btnHoSoDocGia_Click(sender As Object, e As EventArgs) Handles btnHoSoDocGia.Click
		cmHoSoDocGia.Show(btnHoSoDocGia, 0, btnHoSoDocGia.Height)

	End Sub

	Private Sub ThêmLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐộcGiảToolStripMenuItem.Click
		Dim frmdg As frmLapTheDocGia = New frmLapTheDocGia()
		frmdg.MdiParent = Me
		frmdg.Show()
	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Read ConnectionString value from App.config file
		ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub

	Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
		Dim frmdg As frmThemLoaiDocGia = New frmThemLoaiDocGia()
		frmdg.MdiParent = Me
		frmdg.Show()
	End Sub

	Private Sub QuảnLíĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíĐộcGiảToolStripMenuItem.Click
		Dim frmDocGia As frmQuanLyDocGia = New frmQuanLyDocGia()
		frmDocGia.MdiParent = Me
		frmDocGia.Show()
	End Sub
End Class
