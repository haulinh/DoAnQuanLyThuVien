Public Class DocGiaDTO
	Private _maDocGia As String
	Private _hoTen As String
	Private _maLoaiDocGia As Integer
	Private _ngaySinh As Date
	Private _diaChi As String
	Private _email As String
	Private _ngayLapThe As Date

	Public Sub New()
	End Sub

	Public Sub New(_maDocgia As String, 
	               _hoTen As String, 
	               _maLoaiDocGia As Integer, 
	               _ngaySinh As Date, 
	               _diaChi As String,
	               _email As String, 
	               _ngayLapThe As Date)

		Me.MaDocGia = _maDocgia
		Me.HoTen = _hoTen
		Me.MaLoaiDocGia = _maLoaiDocGia
		Me.NgaySinh = _ngaySinh
		Me.DiaChi = _diaChi
		Me.DiaChi = _diaChi
		Me.Email = _email
		Me.NgayLapThe = _ngayLapThe
	End Sub

	Public Property HoTen As String
		Get
			Return _hoTen
		End Get
		Set(value As String)
			_hoTen = value
		End Set
	End Property

	Public Property MaLoaiDocGia As Integer
		Get
			Return _maLoaiDocGia
		End Get
		Set(ByVal Value As Integer)
			_maLoaiDocGia = Value
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
