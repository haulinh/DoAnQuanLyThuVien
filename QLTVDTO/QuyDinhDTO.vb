Public Class QuyDinhDTO
	Private _ID As Integer
	Private _tuoiToiThieu As Integer
	Private _tuoiToiDa As Integer
	Private _thoiHanSuDung As Integer
	Private _khoangCachXuatBan As Integer
	Private _soNgayMuonToiDa As Integer
	Private _soSachMuonToiDa As Integer
	Public Sub New()
		ID = 0
		TuoiToiThieu = 0
		TuoiToiDa = 0
		ThoiHanSuDung = 0
		KhoangCachXuatBan = 9
		SoNgayMuonToiDa = 0
		SoSachMuonToiDa = 0
	End Sub

	Public Sub New(id As Integer, iTuoiToiThieu As Integer, iTuoiToiDa As Integer, iThoiHanSuDung As Integer, iKhoangCachXuatBan As Integer, iSoNgayMuonToiDa As Integer, iSoSachMuonToiDa As Integer)
		Me.ID = id
		Me.TuoiToiThieu = iTuoiToiThieu
		Me.TuoiToiDa = iTuoiToiDa
		Me.ThoiHanSuDung = iThoiHanSuDung
		Me.KhoangCachXuatBan = iKhoangCachXuatBan
		Me.SoNgayMuonToiDa = iSoNgayMuonToiDa
		Me.SoSachMuonToiDa = iSoSachMuonToiDa
	End Sub

	Public Property ID As Integer
		Get
			Return _ID
		End Get
		Set(value As Integer)
			_ID = value
		End Set
	End Property

	Public Property TuoiToiThieu As Integer
		Get
			Return _tuoiToiThieu
		End Get
		Set(value As Integer)
			_tuoiToiThieu = value
		End Set
	End Property

	Public Property TuoiToiDa As Integer
		Get
			Return _tuoiToiDa
		End Get
		Set(value As Integer)
			_tuoiToiDa = value
		End Set
	End Property

	Public Property ThoiHanSuDung As Integer
		Get
			Return _thoiHanSuDung
		End Get
		Set(value As Integer)
			_thoiHanSuDung = value
		End Set
	End Property

	Public Property KhoangCachXuatBan As Integer
		Get
			Return _khoangCachXuatBan
		End Get
		Set(value As Integer)
			_khoangCachXuatBan = value
		End Set
	End Property

	Public Property SoNgayMuonToiDa As Integer
		Get
			Return _soNgayMuonToiDa
		End Get
		Set(value As Integer)
			_soNgayMuonToiDa = value
		End Set
	End Property

	Public Property SoSachMuonToiDa As Integer
		Get
			Return _soSachMuonToiDa
		End Get
		Set(value As Integer)
			_soSachMuonToiDa = value
		End Set
	End Property
End Class
