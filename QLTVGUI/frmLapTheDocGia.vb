﻿Imports System.Text.RegularExpressions
Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmLapTheDocGia
	Private docGiaBUS As docGiaBUS
	Private loaiDocGiaBUS As LoaidocGiaBUS

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim docgia As DocGiaDTO
		docgia = New DocGiaDTO()

		' 1.Mapping data from GUI control
		docgia.MaDocGia = txtMaDocGia.Text
		docgia.HoTen = txtHoTen.Text
		docgia.MaLoaiDocGia = Convert.ToInt32(cbLoaiDocGia.SelectedValue)
		docgia.NgaySinh = dtNgaySinh.Value
		docgia.DiaChi = txtDiaChi.Text
		docgia.Email = txtEmail.Text
		docgia.NgayLapThe = dtNgayLapThe.Value

		'2. Business .....
		If (docGiaBUS.IsVaildName(docgia) = False) Then
			MessageBox.Show("Họ tên độc giả không đúng")
			txtHoTen.Focus()
			Return
		End If

		If (docGiaBUS.IsVaildAge(docgia) = False) Then
			MessageBox.Show("Tuổi độc giả không đúng")
			dtNgaySinh.Focus()
			Return
		End If

		'3. Insert to DB
		Dim result As Result
		result = docGiaBUS.Insert(docgia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm độc giả thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)

			'Set MSdocgia auto
			Dim nextMaSoDocGia = "1"
			result = docGiaBUS.BuildMaSoDocGia(nextMaSoDocGia)

			If (result.FlagResult = False) Then
				MessageBox.Show("Lấy danh sách tự động mã Độc giả không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Me.Close()
				Return
			End If

			txtMaDocGia.Text = nextMaSoDocGia
			txtHoTen.Text = String.Empty
			txtDiaChi.Text = String.Empty
			txtEmail.Text = String.Empty
		Else
			MessageBox.Show("Thêm Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub btnNhapDong_Click(sender As Object, e As EventArgs) Handles btnNhapDong.Click
		Dim docgia As DocGiaDTO
		docgia = New DocGiaDTO()

		' 1.Mapping data from GUI control
		docgia.MaDocGia = txtMaDocGia.Text
		docgia.HoTen = txtHoTen.Text
		' docgia.MaLoaiDocGia = Convert.ToInt32(cbLoaiDocGia.SelectedValue)
		docgia.NgaySinh = dtNgaySinh.Value
		docgia.DiaChi = txtDiaChi.Text
		docgia.Email = txtEmail.Text
		docgia.NgayLapThe = dtNgayLapThe.Value

		'2. Business .....
		If (docGiaBUS.IsVaildName(docgia) = False) Then
			MessageBox.Show("Họ tên độc giả không đúng")
			txtHoTen.Focus()
			Return
		End If

		If (docGiaBUS.IsVaildAge(docgia) = False) Then
			MessageBox.Show("Tuổi độc giả không đúng")
			dtNgaySinh.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = docGiaBUS.Insert(docgia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm độc giả thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MessageBox.Show("Thêm Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub frmLapTheDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		docGiaBUS = New docGiaBUS()
		loaiDocGiaBUS = New LoaidocGiaBUS()

		'Load LoaiDocGiaDTO list
		Dim LoaiDocGiaDTo = New List(Of LoaiDocGiaDTo)
		Dim result As Result

		result = loaiDocGiaBUS.SelectAll(LoaiDocGiaDTo)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Me.Close()
			Return
		End If

		cbLoaiDocGia.DataSource = New BindingSource(LoaiDocGiaDTo, String.Empty)
		cbLoaiDocGia.DisplayMember = "TenLoaiDocGia"
		cbLoaiDocGia.ValueMember = "MaLoaiDocGia"

		'Set Ma so doc gia auto
		Dim nextMaSoDocGia = "1"
		result = docGiaBUS.BuildMaSoDocGia(nextMaSoDocGia)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Me.Close()
			Return
		End If
		txtMaDocGia.Text = nextMaSoDocGia

		dtNgayLapThe.Value = DateTime.Today
		dtNgayHetHan.Value = docGiaBUS.LayNgayHetHan(dtNgayLapThe.Value)


	End Sub
	' xóa khoảng trắng 
	Private Sub txtHoTen_Leave(sender As Object, e As EventArgs) Handles txtHoTen.Leave
		txtHoTen.Text = Regex.Replace(txtHoTen.Text, "\s\s+", " ")
	End Sub
End Class