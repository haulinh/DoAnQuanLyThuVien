Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class SachBUS
	Private sachDAL As SachDAL
	Public Sub New()
		sachDAL = New SachDAL()
	End Sub

	Public Sub New(connectionString As String)
		sachDAL = New SachDAL(connectionString)
	End Sub

	Public Function IsVaildName(sach As SachDTO) As Boolean
		If (sach.TenSach.Length < 1) Then
			Return False
		End If

		Return True

	End Function

	Public Shared Function GetMinAndMaxValue(obj As Object) As Object
		If obj <> Nothing
			Return obj
		End If

		Return nothing

	End Function


	Public Function Insert(sach As SachDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return sachDAL.Insert(sach)
	End Function

	Public Function SelectAllByType(maLoai As Integer, Byref listSach As List(Of SachDTO)) As Result
		Return sachDAL.SelectAllByType(maLoai, listSach)
	End Function

	Public Function SelectAllCondition(maSach As String,
	                                   maLoai As Integer,
									   tenSach As String,
									   tacGia As String,
									   nhaXuatBan As String,
									   minTriGia As Integer,
									   maxTriGia As Integer, 
	                                   minNamXuatBan as Integer, 
	                                   maxNamXuatBan as Integer, 
	                                   minNgayNhap As String, 
	                                   maxNgayNhap As String,
									   Byref listSach As List(Of SachDTO)) As Result
		Return sachDAL.SelectAllCondition(maSach, maLoai, tenSach, tacGia, nhaXuatBan, minTriGia, maxTriGia, minNamXuatBan, maxNamXuatBan, minNgayNhap, maxNgayNhap, listSach)
	End Function

	Public Function BuildMaSoSach(ByRef nextMaSoSach As String) As Result

		Return sachDAL.buildMaSoSach(nextMaSoSach)

	End Function

	Public Function Update(sach As SachDTO) As Result
		Return sachDAL.Update(sach)
	End Function

	Public Function Delete(maSach As String) As Result
		Return sachDAL.Delete(maSach)
	End Function
End Class
