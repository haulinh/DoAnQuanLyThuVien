﻿Imports System.Configuration

Public Class frmMain
	Private ConnectionString As String

	Private Sub btnHoSoDocGia_Click(sender As Object, e As EventArgs) Handles btnHoSoDocGia.Click
		cmHoSoDocGia.Show(btnHoSoDocGia, 0, btnHoSoDocGia.Height)

	End Sub

	Private Sub ThêmLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐộcGiảToolStripMenuItem.Click
		Dim frmLapTheDocGia As frmLapTheDocGia = New frmLapTheDocGia()
		frmLapTheDocGia.MdiParent = Me
		frmLapTheDocGia.Show()

	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Read ConnectionString value from App.config file
		ConnectionString = ConfigurationManager.AppSettings("ConnectionString")

	End Sub

	Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
		Dim frmThemLoaiDoGia As frmThemLoaiDocGia = New frmThemLoaiDocGia()
		frmThemLoaiDoGia.MdiParent = Me
		frmThemLoaiDoGia.Show()

	End Sub

	Private Sub QuảnLíĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíĐộcGiảToolStripMenuItem.Click
		Dim frmQuanLyDocGia As frmQuanLyDocGia = New frmQuanLyDocGia()
		frmQuanLyDocGia.MdiParent = Me
		frmQuanLyDocGia.Show()

	End Sub

	Private Sub QuảnLíToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíToolStripMenuItem.Click
		Dim frmQuanLyLoaiDocGia As frmQuanLyLoaiDocGia = New frmQuanLyLoaiDocGia()
		frmQuanLyLoaiDocGia.MdiParent = Me
		frmQuanLyLoaiDocGia.Show()
	End Sub

	Private Sub btnQuanLi_Click(sender As Object, e As EventArgs) Handles btnQuanLi.Click
		cmQuanLi.Show(btnQuanLi, 0, btnQuanLi.Height)
	End Sub

	Private Sub ThemSachToolTrip_Click(sender As Object, e As EventArgs) Handles ThemSachToolTrip.Click
		Dim frmThemSach As frmThemSach = New frmThemSach()
		frmThemSach.MdiParent = Me
		frmThemSach.Show()
	End Sub

	Private Sub ThêmThểLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmThểLoạiSáchToolStripMenuItem.Click
		Dim frmThemTheLoaiSach As frmThemTheLoaiSach = New frmThemTheLoaiSach()
		frmThemTheLoaiSach.MdiParent = Me
		frmThemTheLoaiSach.Show()
	End Sub

	Private Sub QuảnLýThểLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýThểLoạiSáchToolStripMenuItem.Click
		Dim frmQuanLyTheLoaiSach As frmQuanLyTheLoaiSach = new frmQuanLyTheLoaiSach()
		frmQuanLyTheLoaiSach.MdiParent = Me
		frmQuanLyTheLoaiSach.Show()
	End Sub

	Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSáchToolStripMenuItem.Click
		Dim frmQuanLySach as frmQuanLySach = New frmQuanLySach()
		frmQuanLySach.MdiParent = Me
		frmQuanLySach.Show()
	End Sub
End Class
