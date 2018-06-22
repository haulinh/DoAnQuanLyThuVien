Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmLapPhieuMuonSach

	Private docGiaBUS As DocGiaBUS
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
		docGiaBUS = New DocGiaBUS()
	End Sub

	Private Sub txtMaDocGia_Leave(sender As Object, e As EventArgs) Handles txtMaDocGia.Leave
		Try

		Dim maDocGia = txtMaDocGia.Text
		LoadInfoReader(maDocGia)

		Catch ex As Exception
		End Try

	End Sub

	Private Sub LoadInfoReader(maDocGia As String)
		Dim hoTen = New String("")
		Dim ngayHetHan = new Date()
		Dim result As Result
		result = docGiaBUS.SelectByType(maDocGia, hoTen, ngayHetHan)
		txtHoTenDocGia.Text = hoTen
		dtpNgayHetHan.Value = ngayHetHan
	End Sub
End Class