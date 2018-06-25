﻿Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class PhieuMuonSachBUS
	Private phieuMuonSachDAL As PhieuMuonSachDAL

	Public Sub New()
		phieuMuonSachDAL = New PhieuMuonSachDAL()
	End Sub
	Public Sub New(connectionString As String)
		phieuMuonSachDAL = New PhieuMuonSachDAL(connectionString)
	End Sub
	Public Function InsertPhieuMuonSach(phieuMuonSach As PhieuMuonSachDTO) As Result
		'1. verify data here!!

		'2. insert to DB
		Return phieuMuonSachDAL.InsertPhieuMuonSach(phieuMuonSach)
	End Function

	Public Function BuildMaPhieuMuonSach(ByRef nextMaPhieuMuonSach As String) As Result

		Return phieuMuonSachDAL.BuildMaPhieuMuonSach(nextMaPhieuMuonSach)

	End Function
End Class
