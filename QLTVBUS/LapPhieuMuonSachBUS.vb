Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class LapPhieuMuonSachBUS
	Private phieuMuonSachDAL As LapPhieuMuonSachDAL
	Public Sub New()
		phieuMuonSachDAL = New LapPhieuMuonSachDAL()
	End Sub
	Public Sub New(connectionString As String)
		phieuMuonSachDAL = New LapPhieuMuonSachDAL(connectionString)
	End Sub
	Public Function insert(phieuMuonSachDTO As LapPhieuMuonSachDTO) As Result
		'1. verify data here!!

		'2. insert to DB
		Return phieuMuonSachDAL.Insert(phieuMuonSachDTO)
	End Function
	Public Function buildMaSoPhieuMuon(ByRef nextMaSoPhieuMuon As Integer) As Result
		Return phieuMuonSachDAL.buildMaPhieuMuonSach(nextMaSoPhieuMuon)
	End Function
End Class
