Public Class SachDTO
	Private _maSach As String
	Private _tenSach As String
	Private _maTheLoaiSach As Integer
	Private _tacGia As String
	Private _namXuatBan As Integer
	Private _nhaXuatBan As String
	Private _ngayNhap As Date
	Private _triGia As Integer
	Private _tinhTrangSach As String

	Public Property MaSach As String
		Get
			Return _maSach
		End Get
		Set(value As String)
			_maSach = value
		End Set
	End Property

	Public Property TenSach As String
		Get
			Return _tenSach
		End Get
		Set(value As String)
			_tenSach = value
		End Set
	End Property

	Public Property MaTheLoaiSach As Integer
		Get
			Return _maTheLoaiSach
		End Get
		Set(value As Integer)
			_maTheLoaiSach = value
		End Set
	End Property

	Public Property TacGia As String
		Get
			Return _tacGia
		End Get
		Set(value As String)
			_tacGia = value
		End Set
	End Property

	Public Property NamXuatBan As Integer
		Get
			Return _namXuatBan
		End Get
		Set(value As Integer)
			_namXuatBan = value
		End Set
	End Property

	Public Property NhaXuatBan As String
		Get
			Return _nhaXuatBan
		End Get
		Set(value As String)
			_nhaXuatBan = value
		End Set
	End Property

	Public Property NgayNhap As Date
		Get
			Return _ngayNhap
		End Get
		Set(value As Date)
			_ngayNhap = value
		End Set
	End Property

	Public Property TriGia As Integer
		Get
			Return _triGia
		End Get
		Set(value As Integer)
			_triGia = value
		End Set
	End Property

	Public Property TinhTrangSach As String
		Get
			Return _tinhTrangSach
		End Get
		Set(value As String)
			_tinhTrangSach = value
		End Set
	End Property
End Class
