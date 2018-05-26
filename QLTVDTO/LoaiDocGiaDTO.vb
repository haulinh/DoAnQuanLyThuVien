Public Class LoaiDocGiaDTO
	Private _maLoaiDocGia As Integer
	Private _TenLoaiDocGia As String

	Public Sub New()
	End Sub

	Public Sub New(maLoai As Integer, TenLoaiDocGia As String)
		_maLoaiDocGia = maLoai
		_TenLoaiDocGia = TenLoaiDocGia
	End Sub

	Public Property MaLoaiDocGia As Integer
		Get
			Return _maLoaiDocGia
		End Get
		Set(value As Integer)
			_maLoaiDocGia = value
		End Set
	End Property

	Public Property TenLoaiDocGia As String
		Get
			Return _TenLoaiDocGia
		End Get
		Set(value As String)
			_TenLoaiDocGia = value
		End Set
	End Property
End Class
