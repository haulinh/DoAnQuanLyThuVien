Public Class DocGiaDTO
	Private strmaDocGia As String
	Private strhoTen As String
	Private strmaLoaiDocGia As String
	Private datengaySinh As Date
	Private strdiaChi As String
	Private stremail As String
	Private datengayLapThe As Date

	Public Property HoTen As String
		Get
			Return strhoTen
		End Get
		Set(value As String)
			strhoTen = value
		End Set
	End Property

	Public Property MaLoaiDocGia As String
		Get
			Return strmaLoaiDocGia
		End Get
		Set(value As String)
			strmaLoaiDocGia = value
		End Set
	End Property

	Public Property NgaySinh As Date
		Get
			Return datengaySinh
		End Get
		Set(value As Date)
			datengaySinh = value
		End Set
	End Property

	Public Property DiaChi As String
		Get
			Return strdiaChi
		End Get
		Set(value As String)
			strdiaChi = value
		End Set
	End Property

	Public Property Email As String
		Get
			Return stremail
		End Get
		Set(value As String)
			stremail = value
		End Set
	End Property

	Public Property NgayLapThe As Date
		Get
			Return datengayLapThe
		End Get
		Set(value As Date)
			datengayLapThe = value
		End Set
	End Property

	Public Property MaDocGia As String
		Get
			Return strmaLoaiDocGia
		End Get
		Set(value As String)
			strmaLoaiDocGia = value
		End Set
	End Property
End Class
