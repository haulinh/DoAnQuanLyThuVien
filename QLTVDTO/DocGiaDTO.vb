Public Class DocGiaDTO
	Private _maDocGia As String
	Private _hoTen As String
	Private _maLoaiDocGia As String
	Private _ngaySinh As Date
	Private _diaChi As String
	Private _email As String
	Private _ngayLapThe As Date

	Public Property HoTen As String
		Get
			Return _hoTen
		End Get
		Set(value As String)
			_hoTen = value
		End Set
	End Property

	Public Property MaLoaiDocGia As String
		Get
			Return _maLoaiDocGia
		End Get
		Set(value As String)
			_maLoaiDocGia = value
		End Set
	End Property

	Public Property NgaySinh As Date
		Get
			Return _ngaySinh
		End Get
		Set(value As Date)
			_ngaySinh = value
		End Set
	End Property

	Public Property DiaChi As String
		Get
			Return _diaChi
		End Get
		Set(value As String)
			_diaChi = value
		End Set
	End Property

	Public Property Email As String
		Get
			Return _email
		End Get
		Set(value As String)
			_email = value
		End Set
	End Property

	Public Property NgayLapThe As Date
		Get
			Return _ngayLapThe
		End Get
		Set(value As Date)
			_ngayLapThe = value
		End Set
	End Property

	Public Property MaDocGia As String
		Get
			Return _maDocGia
		End Get
		Set(value As String)
			_maDocGia = value
		End Set
	End Property
End Class
