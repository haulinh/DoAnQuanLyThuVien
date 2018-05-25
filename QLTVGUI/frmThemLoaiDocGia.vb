Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmThemLoaiDocGia

	Private loaiDocGiaBUS As LoaiDocGiaBUS

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim loaiDocGia As LoaiDocGiaDTO
		loaiDocGia = New LoaiDocGiaDTO()

		'1. Mapping data from GUI control
		loaiDocGia.MaLoaiDocGia = Convert.ToInt32(txtMaLoaiDocGia.Text)
		loaiDocGia.TenLoaiDocGia = txtTenLoaiDocGia.Text

		'2. Business .....
		If (loaiDocGiaBUS.IsVaildName(loaiDocGia) = False) Then
			MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenLoaiDocGia.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = loaiDocGiaBUS.insert(loaiDocGia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			txtTenLoaiDocGia.Text = String.Empty

			' Get Next ID
			Dim nextID As Integer
			result = loaiDocGiaBUS.GetNextID(nextID)
			If (result.FlagResult = True) Then
				txtMaLoaiDocGia.Text = nextID.ToString()
			Else
				MessageBox.Show("Lấy ID kế tiếp của Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				System.Console.WriteLine(result.SystemMessage)
			End If

		Else
			MessageBox.Show("Thêm loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub frmThemLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		loaiDocGiaBUS = New LoaiDocGiaBUS()

		' Get Next ID
		Dim nextID As Integer
		Dim result As Result
		result = loaiDocGiaBUS.GetNextID(nextID)
		If (result.FlagResult = True) Then
			txtMaLoaiDocGia.Text = nextID.ToString()
		Else
			MessageBox.Show("Lấy ID kế tiếp của Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
		Dim loaiDocGia As LoaiDocGiaDTO
		loaiDocGia = New LoaiDocGiaDTO()

		'1. Mapping data from GUI control
		loaiDocGia.MaLoaiDocGia = Convert.ToInt32(txtMaLoaiDocGia.Text)
		loaiDocGia.TenLoaiDocGia = txtTenLoaiDocGia.Text

		'2. Business .....
		If (loaiDocGiaBUS.IsVaildName(loaiDocGia) = False) Then
			MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenLoaiDocGia.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = loaiDocGiaBUS.insert(loaiDocGia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			txtTenLoaiDocGia.Text = String.Empty
			Me.Close()
		Else
			MessageBox.Show("Thêm loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub
End Class