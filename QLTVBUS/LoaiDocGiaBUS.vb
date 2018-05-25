Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class LoaiDocGiaBUS
	Private loaiDocGiaDAL As LoaiDocGiaDAL
	Public Sub New()
		loaiDocGiaDAL = New LoaiDocGiaDAL()
	End Sub

	Public Sub New(connectionString As String)
		loaiDocGiaDAL = New LoaiDocGiaDAL(connectionString)
	End Sub

	Public Function IsVaildName(loaiDocGia As LoaiDocGiaDTO) As Boolean
		If (loaiDocGia.TenLoaiDocGia.Length < 1) Then
			Return False
		End If

		Return True

	End Function

	Public Function insert(loaiDocGia As LoaiDocGiaDTO) As Result
		'1. verify data here!!

		'2. insert to DB
		Return loaiDocGiaDAL.insert(loaiDocGia)
	End Function

	Public Function selectAll(ByRef listLoaiDocGia As List(Of LoaiDocGiaDTO)) As Result
		'1. verify data here!!

		'2. insert to DB
		Return loaiDocGiaDAL.selectALL(listLoaiDocGia)
	End Function

	Public Function GetNextID(ByRef nextID As Integer) As Result
		Return loaiDocGiaDAL.GetNextID(nextID)
	End Function
End Class
