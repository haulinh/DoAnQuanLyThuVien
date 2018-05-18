Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmLapTheDocGia

	Private dgBus As DocGiaBUS
	' Private ldgBus	As LoaiDocGiaBus

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim docgia As DocGiaDTO
		docgia = New DocGiaDTO()

		' 1.Mapping data from GUI control
		docgia.MaDocGia = txtMaDocGia.Text
		docgia.HoTen = txtHoTen.Text
		docgia.MaLoaiDocGia = 1
		docgia.NgaySinh = dtNgaySinh.Value
		docgia.DiaChi = txtDiaChi.Text
		docgia.Email = txtEmail.Text
		docgia.NgayLapThe = dtNgayLapThe.Value

		'2. Business .....
		If (dgBus.isValidName(docgia) = False) Then
			MessageBox.Show("Họ tên độc giả không đúng")
			txtHoTen.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = dgBus.insert(docgia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm độc giả thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
			'Set MSDG auto
			Dim nextMsdg = "1"
			result = dgBus.buildMSDG(nextMsdg)
			If (result.FlagResult = False) Then
				MessageBox.Show("Lấy danh sách tự động mã Độc giả không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Me.Close()
				Return
			End If

			txtMaDocGia.Text = nextMsdg
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
		docgia.MaLoaiDocGia = Convert.ToInt32(cbLoaiDocGia.SelectedValue)
		docgia.NgaySinh = dtNgaySinh.Value
		docgia.DiaChi = txtDiaChi.Text
		docgia.Email = txtEmail.Text
		docgia.NgayLapThe = dtNgayLapThe.Value

		'2. Business .....
		If (dgBus.isValidName(docgia) = False) Then
			MessageBox.Show("Họ tên độc giả không đúng")
			txtHoTen.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = dgBus.insert(docgia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm độc giả thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MessageBox.Show("Thêm Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub frmLapTheDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		dgBus = New DocGiaBUS()
		Dim result As Result

		Dim nextMsdg = "1"
		Result = dgBus.buildMSDG(nextMsdg)
		If (Result.FlagResult = False) Then
			MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(Result.SystemMessage)
			Me.Close()
			Return
		End If
		txtMaDocGia.Text = nextMsdg
	End Sub
End Class