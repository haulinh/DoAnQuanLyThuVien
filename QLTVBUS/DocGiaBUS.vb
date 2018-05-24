Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DocGiaBUS
	Private docGiaDAL As DocGiaDAL
	Public Sub New()
		docGiaDAL = New DocGiaDAL()
	End Sub
	Public Sub New(connectionString As String)
		docGiaDAL = New DocGiaDAL(connectionString)
	End Sub

	Public Function isValidName(docgia As DocGiaDTO) As Boolean

		If (docgia.HoTen.Length < 1) Then
			Return False
		End If

		Return True
	End Function

	Public Function insert(docgia As DocGiaDTO) As Result
		'1. verify data here!!

		'2. insert to DB
		Return docGiaDAL.insert(docgia)
	End Function

	Public Function BuildMaSoDocGia(ByRef NextMaSoDocGia As Integer) As Result
		Return docGiaDAL.BuildMaSoDocGia(NextMaSoDocGia)
	End Function
End Class
