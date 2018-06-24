Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmLapPhieuMuonSach

	Private docGiaBUS As DocGiaBUS
	Private sachBUS As SachBUS
	Private phieuMuonSachBUS As PhieuMuonSachBUS

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnLap.Click  
		Dim phieuMuonSach As PhieuMuonSachDTO
		phieuMuonSach = New PhieuMuonSachDTO()

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

	Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnLapVaDong.Click  
		Dim phieuMuonSach As PhieuMuonSachDTO
		phieuMuonSach = New PhieuMuonSachDTO()

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
		docGiaBUS = New DocGiaBUS()
		sachBUS = New SachBUS()
		phieuMuonSachBUS = New PhieuMuonSachBUS()

		Dim result As Result
		Dim nextMaPhieuMuonSach = "1"
		result = phieuMuonSachBUS.BuildMaPhieuMuonSach(nextMaPhieuMuonSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Me.Close()
			Return
		End If
		txtMaPhieuMuonSach.Text = nextMaPhieuMuonSach

		dtpNgayHetHan.Enabled = False

		dtpNgayMuonSach.Enabled = False
		dtpNgayMuonSach.Value = DateTime.Today

		dgvDanhSachMuon.Columns.Clear()
		dgvDanhSachMuon.DataSource = Nothing

		dgvDanhSachMuon.AutoGenerateColumns = False
		dgvDanhSachMuon.AllowUserToAddRows = False

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "MaSach"
		clMa.HeaderText = "Mã Sách"
		dgvDanhSachMuon.Columns.Add(clMa)

		Dim clTenSach = New DataGridViewTextBoxColumn()
		clTenSach.Name = "TenSach"
		clTenSach.HeaderText = "Tên Sách"
		dgvDanhSachMuon.Columns.Add(clTenSach)

		Dim clTheLoai = New DataGridViewTextBoxColumn()
		clTheLoai.Name = "TheLoai"
		clTheLoai.HeaderText = "Thể Loại"
		dgvDanhSachMuon.Columns.Add(clTheLoai)

		Dim clTacGia = New DataGridViewTextBoxColumn()
		clTacGia.Name = "TacGia"
		clTacGia.HeaderText = "Tác Giả"
		dgvDanhSachMuon.Columns.Add(clTacGia)
		
	End Sub

	Private Sub LoadInfoReader(maDocGia As String)
		Dim hoTen = New String(Nothing)
		Dim ngayHetHan = new Date()
		Dim result As Result

		result = docGiaBUS.SelectByType(maDocGia, hoTen, ngayHetHan)

		txtHoTenDocGia.Text = hoTen
		dtpNgayHetHan.Value = ngayHetHan
	End Sub

	Private Sub LoadInfoBook(maSach As String)
		Dim tenSach = New String(Nothing)
		Dim tacGia = New String(Nothing)
		Dim theLoai = new String(Nothing)
		Dim result As Result

		result = sachBUS.SelectByType(maSach, tenSach, theLoai, tacGia)

		txtTenSach.Text = tenSach
		txtTacGia.Text = tacGia
		txtTheLoai.Text = theLoai
	End Sub

	Private Sub txtMaDocGia_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaDocGia.KeyUp, txtTenSach.KeyUp, txtTacGia.KeyUp, txtTheLoai.KeyUp 
		Try

			Dim maDocGia = txtMaDocGia.Text
			LoadInfoReader(maDocGia)

		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtMaSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaSach.KeyUp
		Try

			Dim maSach = txtMaSach.Text
			LoadInfoBook(maSach)

		Catch ex As Exception
		End Try
	End Sub

	Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
		Dim rnum As Integer = dgvDanhSachMuon.Rows.Add()

		dgvDanhSachMuon.Rows.Item(rnum).Cells("MaSach").Value = txtMaSach.Text
		dgvDanhSachMuon.Rows.Item(rnum).Cells("TenSach").Value = txtTenSach.Text
		dgvDanhSachMuon.Rows.Item(rnum).Cells("TheLoai").Value = txtTheLoai.Text
		dgvDanhSachMuon.Rows.Item(rnum).Cells("TacGia").Value = txtTacGia.Text

		Dim numberOfRows = dgvDanhSachMuon.Rows.Count - 1 'subtract the last row which is an editing row
		Dim i As Integer = 0

		While i < numberOfRows 

			For j As Integer = (numberOfRows) To (i + 1) Step - 1
				If dgvDanhSachMuon.Rows(i).Cells("MaSach").Value.ToString() = dgvDanhSachMuon.Rows(j).Cells("MaSach").Value.ToString() Then
					dgvDanhSachMuon.Rows.Remove(dgvDanhSachMuon.Rows(j))
					numberOfRows -= 1
				End If
			Next
			i += 1
		End While

		If dgvDanhSachMuon.Rows(numberOfRows).Cells("MaSach").Value.ToString() = nothing
			dgvDanhSachMuon.Rows.Remove(dgvDanhSachMuon.Rows(numberOfRows))
		End If

	End Sub
End Class