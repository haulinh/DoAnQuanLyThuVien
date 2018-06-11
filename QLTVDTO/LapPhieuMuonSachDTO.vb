Public Class LapPhieuMuonSachDTO
	Private _maPhieuMuonSach As String
	Private _ngayMuonSach As Date
	Private _maDocGia As String
	Private _ngayTraSach As Date
	Private v1 As Object
	Private v2 As Object
	Private v3 As Object
	Private v4 As Object
	Private v5 As Object

	Public Sub New(v1 As Object, v2 As Object, v3 As Object, v4 As Object, v5 As Object)
		Me.v1 = v1
		Me.v2 = v2
		Me.v3 = v3
		Me.v4 = v4
		Me.v5 = v5
	End Sub

	Public Sub New()
	End Sub

	Public Property MaPhieuMuonSach As String
		Get
			Return _maPhieuMuonSach
		End Get
		Set(value As String)
			_maPhieuMuonSach = value
		End Set
	End Property

	Public Property NgayMuonSach As Date
		Get
			Return _ngayMuonSach
		End Get
		Set(value As Date)
			_ngayMuonSach = value
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

	Public Property NgayTraSach As Date
		Get
			Return _ngayTraSach
		End Get
		Set(value As Date)
			_ngayTraSach = value
		End Set
	End Property
End Class
