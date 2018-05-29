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

	Public Function Insert(sach As SachDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return sachDAL.Insert(sach)
	End Function

	Public Function BuildMaSoSach(ByRef nextMaSoSach As Integer) As Result

		Return sachDAL.buildMaSoSach(nextMaSoSach)

	End Function

End Class
