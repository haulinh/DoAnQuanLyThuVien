Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuMuonSachBUS
	Private chiTietPhieuMuonSachDAL As ChiTietPhieuMuonSachDAL

	Public Sub New()
		chiTietPhieuMuonSachDAL = New ChiTietPhieuMuonSachDAL()
	End Sub
	Public Sub New(connectionString As String)
		chiTietPhieuMuonSachDAL = New ChiTietPhieuMuonSachDAL(connectionString)
	End Sub

	Public Function InsertChiTietPhieuMuonSach(chiTietPhieuMuonSach As ChiTietPhieuMuonSachDTO) As Result
	
		Return chiTietPhieuMuonSachDAL.InsertChiTietPhieuMuonSach(chiTietPhieuMuonSach)

	End Function

	Public Function BuildMaChiTietPhieuMuonSach(ByRef nextMaPhieuMuonSach As String) As Result

		Return chiTietPhieuMuonSachDAL.BuildMaChiTietPhieuMuonSach(nextMaPhieuMuonSach)

	End Function

End Class
