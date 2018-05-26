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
End Class
