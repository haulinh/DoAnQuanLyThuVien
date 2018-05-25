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

	Public Function Insert(loaiDocGia As LoaiDocGiaDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return loaiDocGiaDAL.Insert(loaiDocGia)
	End Function

	Public Function SelectAll(ByRef listLoaiDocGia As List(Of LoaiDocGiaDTO)) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return loaiDocGiaDAL.SelectAll(listLoaiDocGia)
	End Function

	Public Function GetNextID(ByRef nextID As Integer) As Result
		Return loaiDocGiaDAL.GetNextID(nextID)
	End Function
End Class
