Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmLapPhieuMuonSach

	Private phieuMuonSachBUS As LapPhieuMuonSachBUS

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim phieuMuonSach As LapPhieuMuonSachDTO
		phieuMuonSach = New LapPhieuMuonSachDTO()

		'1. Mapping data from GUI control
		phieuMuonSach.MaPhieuMuonSach = txtMaPhieuMuonSach.Text
		phieuMuonSach.MaDocGia = txtMaDocGia.Text
		'3. Insert to DB
		Dim result As Result
		result = phieuMuonSachBUS.insert(phieuMuonSach)
		If (result.FlagResult = True) Then
			MessageBox.Show("Lập phiếu mua sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			'set MSSH auto
			Dim nextMaSoPhieuMuon = "1"
			result = phieuMuonSachBUS.buildMaSoPhieuMuon(nextMaSoPhieuMuon)
			If (result.FlagResult = False) Then
				MessageBox.Show("Lấy danh tự động mã Phiếu mua sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Me.Close()
				Return
			End If
			txtMaPhieuMuonSach.Text = nextMaSoPhieuMuon
			txtMaDocGia.Text = String.Empty

		Else
			MessageBox.Show("Lập phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
		Dim phieuMuonSach As LapPhieuMuonSachDTO
		phieuMuonSach = New LapPhieuMuonSachDTO()

		'1. Mapping data from GUI control
		phieuMuonSach.MaPhieuMuonSach = txtMaPhieuMuonSach.Text
		phieuMuonSach.MaDocGia = txtMaDocGia.Text

		'2. Insert to DB
		Dim result As Result
		result = phieuMuonSachBUS.insert(phieuMuonSach)
		If (result.FlagResult = True) Then
			MessageBox.Show("Lập phiếu mượn sách thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MessageBox.Show("Lập phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub frmLapPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub txtMaDocGia_Leave(sender As Object, e As EventArgs) Handles txtMaDocGia.Leave

	End Sub
	'Private Sub LoadListSach()
	'	Dim listSach = New List(Of SachDTO)
	'	Dim result As Result
	'	result = SachBUS.SelectAll(listSach)

	'	If (result.FlagResult = False) Then
	'		MessageBox.Show("Lấy danh sách Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	'		System.Console.WriteLine(result.SystemMessage)
	'		Return
	'	End If

	'	'dgvListDocGia.SuspendLayout()
	'	dgvListDocGia.Columns.Clear()
	'	dgvListDocGia.DataSource = Nothing

	'	dgvListDocGia.AutoGenerateColumns = False
	'	dgvListDocGia.AllowUserToAddRows = False
	'	dgvListDocGia.DataSource = listDocGia

	'	Dim clMa = New DataGridViewTextBoxColumn()
	'	clMa.Name = "madocgia"
	'	clMa.HeaderText = "Mã Độc Giả"
	'	clMa.DataPropertyName = "MaDocGia"
	'	dgvListDocGia.Columns.Add(clMa)

	'	Dim clHoTen = New DataGridViewTextBoxColumn()
	'	clHoTen.Name = "HoTen"
	'	clHoTen.HeaderText = "Họ Tên"
	'	clHoTen.DataPropertyName = "HoTen"
	'	dgvListDocGia.Columns.Add(clHoTen)

	'	Dim clLoaiHS = New DataGridView()
	'	'clLoaiHS.Name = "LoaiHS"
	'	'clLoaiHS.HeaderText = "Tên Loại"
	'	'clLoaiHS.DataPropertyName = "LoaiHS"
	'	'dgvListDocGia.Columns.Add(clLoaiHS)

	'	Dim clNgaySinh = New DataGridViewTextBoxColumn()
	'	clNgaySinh.Name = "NgaySinh"
	'	clNgaySinh.HeaderText = "Ngày Sinh"
	'	clNgaySinh.DataPropertyName = "NgaySinh"
	'	dgvListDocGia.Columns.Add(clNgaySinh)
	'	'dgvListDocGia.ResumeLayout()

	'	Dim clDiaChi = New DataGridViewTextBoxColumn()
	'	clDiaChi.Name = "DiaChi"
	'	clDiaChi.HeaderText = "Địa Chỉ"
	'	clDiaChi.DataPropertyName = "DiaChi"
	'	dgvListDocGia.Columns.Add(clDiaChi)

	'	Dim clEmail = New DataGridViewTextBoxColumn()
	'	clNgaySinh.Name = "Email"
	'	clNgaySinh.HeaderText = "Email"
	'	clNgaySinh.DataPropertyName = "Email"
	'	dgvListDocGia.Columns.Add(clEmail)
	'	'dgvListDocGia.ResumeLayout()

	'	Dim clNgayLapThe = New DataGridViewTextBoxColumn()
	'	clNgaySinh.Name = "NgayLapThe"
	'	clNgaySinh.HeaderText = "Ngày Lập Thẻ"
	'	clNgaySinh.DataPropertyName = "NgayLapThe"
	'	dgvListDocGia.Columns.Add(clNgayLapThe)
	'	'dgvListDocGia.ResumeLayout()

	'End Sub
End Class