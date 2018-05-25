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

	Public Function IsVaildName(docgia As DocGiaDTO) As Boolean
		If (docgia.HoTen.Length < 1) Then
			Return False
		End If

		Return True

	End Function

	Public Function Insert(docgia As DocGiaDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.Insert(docgia)
	End Function
	Public Function Update(docGia As DocGiaDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.Update(docGia)

	End Function
	Public Function Delete(maLoai As Integer) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.Delete(maLoai)

	End Function

	Public Function SelectAll(ByRef listLoaiDocGia As List(Of DocGiaDTO)) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.SelectAll(listLoaiDocGia)

	End Function

	Public Function SelectAllByType(maLoai As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.SelectAllByType(maLoai, listDocGia)

	End Function

	Public Function BuildMaSoDocGia(ByRef nextMaSoDocGia As Integer) As Result

		Return docGiaDAL.BuildMaSoDocGia(nextMaSoDocGia)

	End Function

End Class
