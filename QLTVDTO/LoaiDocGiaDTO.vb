Public Class LoaiDocGiaDTO
	Private iMaLoaiDG As Integer
	Private strTenLoaiDG As String

	Public Sub New()
	End Sub

	Public Sub New(ml As Integer, tl As String)
		iMaLoaiDG = ml
		strTenLoaiDG = tl
	End Sub

	Public Property MaLoaiDG As Integer
		Get
			Return iMaLoaiDG
		End Get
		Set(value As Integer)
			iMaLoaiDG = value
		End Set
	End Property

	Public Property TenLoaiDG As String
		Get
			Return strTenLoaiDG
		End Get
		Set(value As String)
			strTenLoaiDG = value
		End Set
	End Property
End Class
