Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmThemLoaiDocGia

	Private ldgBus As LoaiDocGiaBUS

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim ldg As LoaiDocGiaDTO
		ldg = New LoaiDocGiaDTO()

		'1. Mapping data from GUI control
		ldg.MaLoaiDG = Convert.ToInt32(txtMaLoaiDocGia.Text)
		ldg.TenLoaiDG = txtTenLoaiDocGia.Text

		'2. Business .....
		If (ldgBus.isValidName(ldg) = False) Then
			MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenLoaiDocGia.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = ldgBus.insert(ldg)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			txtTenLoaiDocGia.Text = String.Empty

			' Get Next ID
			Dim nextID As Integer
			result = ldgBus.getNextID(nextID)
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
		ldgBus = New LoaiDocGiaBUS()

		' Get Next ID
		Dim nextID As Integer
		Dim result As Result
		result = ldgBus.getNextID(nextID)
		If (result.FlagResult = True) Then
			txtMaLoaiDocGia.Text = nextID.ToString()
		Else
			MessageBox.Show("Lấy ID kế tiếp của Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
		Dim ldg As LoaiDocGiaDTO
		ldg = New LoaiDocGiaDTO()

		'1. Mapping data from GUI control
		ldg.MaLoaiDG = Convert.ToInt32(txtMaLoaiDocGia.Text)
		ldg.TenLoaiDG = txtTenLoaiDocGia.Text

		'2. Business .....
		If (ldgBus.isValidName(ldg) = False) Then
			MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenLoaiDocGia.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = ldgBus.insert(ldg)
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