Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmQuanLyPhieuMuonSach
	Private sachBUS As SachBUS
	Private theLoaiSachBUS As TheLoaiSachBUS
	Private chiTietPhieuMuonSachBUS As ChiTietPhieuMuonSachBUS
	Private phieuMuonSachBUS As PhieuMuonSachBUS


	Private Sub frmQuanLyPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		phieuMuonSachBUS = New PhieuMuonSachBUS()

		'Load LoaiDocGia list
		Dim listPhieuMuonSach = New List(Of PhieuMuonSachDTO)
		Dim result As Result
		result = phieuMuonSachBUS.SelectAll(listPhieuMuonSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách Phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If


		'txtMaPhieuMuonSach.DataBindings = New BindingSource(listPhieuMuonSach, String.Empty)
		'cbTheLoaiSach.DisplayMember = "TenTheLoaiSach"
		'cbTheLoaiSach.ValueMember = "MaTheLoaiSach"

		'cbTheLoaiSachCapNhap.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
		'cbTheLoaiSachCapNhap.DisplayMember = "TenTheLoaiSach"
		'cbTheLoaiSachCapNhap.ValueMember = "MaTheLoaiSach"

	End Sub
	Private Sub LoadPhieuMuonSach(maSach As Integer)
		Dim listSach = New List(Of SachReceive)
		Dim result As Result

		result = phieuMuonSachBUS.SelectByType(maSach, listSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách Phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		'dgvListDocGia.SuspendLayout()
		dgvPhieuMuonSach.Columns.Clear()
		dgvPhieuMuonSach.DataSource = Nothing
		dgvPhieuMuonSach.AutoGenerateColumns = False
		dgvPhieuMuonSach.AllowUserToAddRows = False

		dgvPhieuMuonSach.DataSource = listSach

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "MaSach"
		clMa.HeaderText = "Mã Sách"
		clMa.DataPropertyName = "MaSach"
		dgvPhieuMuonSach.Columns.Add(clMa)

		Dim clTenSach = New DataGridViewTextBoxColumn()
		clTenSach.Name = "TenSach"
		clTenSach.HeaderText = "Tên Sách"
		clTenSach.DataPropertyName = "TenSach"
		dgvPhieuMuonSach.Columns.Add(clTenSach)

		Dim clTenTheLoaiSach = New DataGridViewTextBoxColumn()
		clTenTheLoaiSach.Name = "TenTheLoai"
		clTenTheLoaiSach.HeaderText = "Thể Loại"
		clTenTheLoaiSach.DataPropertyName = "TenTheLoai"
		dgvPhieuMuonSach.Columns.Add(clTenTheLoaiSach)

		Dim clTacGia = New DataGridViewTextBoxColumn()
		clTacGia.Name = "TenTacGia"
		clTacGia.HeaderText = "Tác Giả"
		clTacGia.DataPropertyName = "TenTacGia"
		dgvPhieuMuonSach.Columns.Add(clTacGia)

		''dgvPhieuMuonSach.Columns(0).Width = 70
		''dgvPhieuMuonSach.Columns(1).Width = 160
		''dgvPhieuMuonSach.Columns(2).Width = 70
		''dgvPhieuMuonSach.Columns(3).Width = 160



	End Sub

	Private Sub txtMaPhieuMuonSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaPhieuMuonSach.KeyUp
		Try
			Dim maPhieuMuonSach = txtMaPhieuMuonSach.Text
			LoadPhieuMuonSach(maPhieuMuonSach)
		Catch ex As Exception

		End Try
	End Sub

	Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvPhieuMuonSach.CurrentCellAddress.Y 'current row selected

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvPhieuMuonSach.RowCount) Then
			Try
				Dim sach As SachDTO
				sach = New SachDTO()

				'1. Mapping data from GUI control
				sach.MaSach = Convert.ToInt32(txtMaSach.Text)
				sach.TenSach = txtTenSach.Text
				sach.MaTheLoaiSach = txtTheLoaiSach.Text
				sach.MaTacGia = txtTacGia.Text
			Catch ex As Exception

			End Try
		End If
	End Sub
End Class