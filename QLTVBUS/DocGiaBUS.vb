Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DocGiaBUS
	Private dgDAL As DocGiaDAL
	Public Sub New()
		dgDAL = New DocGiaDAL()
	End Sub
	Public Sub New(connectionString As String)
		dgDAL = New DocGiaDAL(connectionString)
	End Sub

	Public Function isValidName(dg As DocGiaDTO) As Boolean

		If (dg.HoTen.Length < 1) Then
			Return False
		End If

		Return True
	End Function

	Public Function insert(dg As DocGiaDTO) As Result
		'1. verify data here!!

		'2. insert to DB
		Return dgDAL.insert(dg)
	End Function

	Public Function buildMSDG(ByRef nextMsdg As Integer) As Result
		Return dgDAL.buildMSDG(nextMsdg)
	End Function
End Class
