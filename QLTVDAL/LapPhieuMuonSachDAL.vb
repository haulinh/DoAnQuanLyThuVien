Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class LapPhieuMuonSachDAL
	Private connectionString As String
	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub
	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub
	Public Function buildMaPhieuMuonSach(ByRef nextMaPhieuMuonSach As String) As Result 'ex: 18222229

		nextMaPhieuMuonSach = String.Empty
		Dim y = DateTime.Now.Year
		Dim x = y.ToString().Substring(2)
		nextMaPhieuMuonSach = x + "000000"

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [maphieumuonsach] "
		query &= "FROM [tblPhieuMuonSach] "
		query &= "ORDER BY [maphieumuonsach] DESC "

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With
				Try
					conn.Open()
					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()
					Dim msOnDB As String
					msOnDB = Nothing
					If reader.HasRows = True Then
						While reader.Read()
							msOnDB = reader("maphieumuonsach")
						End While
					End If
					If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
						Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
						Dim iCurrentYear = Integer.Parse(currentYear)
						Dim currentYearOnDB = msOnDB.Substring(0, 2)
						Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
						Dim year = iCurrentYear
						If (year < icurrentYearOnDB) Then
							year = icurrentYearOnDB
						End If
						nextMaPhieuMuonSach = year.ToString()
						Dim v = msOnDB.Substring(2)
						Dim convertDecimal = Convert.ToDecimal(v)
						convertDecimal = convertDecimal + 1
						Dim tmp = convertDecimal.ToString()
						tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
						nextMaPhieuMuonSach = nextMaPhieuMuonSach + tmp
						System.Console.WriteLine(nextMaPhieuMuonSach)
					End If

				Catch ex As Exception
					conn.Close() ' that bai!!!
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lấy tự động Mã phiếu mượn sách kế tiếp không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function
	Public Function Insert(phieuMuonSach As LapPhieuMuonSachDTO) As Result
		Dim query As String = String.Empty
		query &= "INSERT INTO [tblPhieuMuonSach] ([maphieumuonsach], [ngaymuonsach], [madocgia], [ngaytrasach])"
		query &= "VALUES (@maphieumuonsach, @ngaymuon, @madocgia, @ngaytrasach)"

		'get masach
		Dim nextMaPhieuMuonSach = "1"
		buildMaPhieuMuonSach(nextMaPhieuMuonSach)
		phieuMuonSach.MaPhieuMuonSach = nextMaPhieuMuonSach

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@maphieumuonsach", phieuMuonSach.MaPhieuMuonSach)
					.Parameters.AddWithValue("@ngaymuonsach", phieuMuonSach.NgayMuonSach)
					.Parameters.AddWithValue("@madocgia", phieuMuonSach.MaDocGia)
					.Parameters.AddWithValue("@ngaytrasach", phieuMuonSach.NgayTraSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lập phiếu mượn sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function

	'Public Function selectALL(ByRef listPhieuMuonSach As List(Of LapPhieuMuonSachDTO)) As Result

	'	Dim query As String = String.Empty
	'	query &= "SELECT [maphieumuonsach], [ngaymuonsach], [madocgia], [ngayhethan]"
	'	query &= "FROM [tblPhieuMuonSach]"


	'	Using conn As New SqlConnection(connectionString)
	'		Using comm As New SqlCommand()
	'			With comm
	'				.Connection = conn
	'				.CommandType = CommandType.Text
	'				.CommandText = query
	'			End With
	'			Try
	'				conn.Open()
	'				Dim reader As SqlDataReader
	'				reader = comm.ExecuteReader()
	'				If reader.HasRows = True Then
	'					listPhieuMuonSach.Clear()
	'					While reader.Read()
	'						listPhieuMuonSach.Add(New LapPhieuMuonSachDTO(reader("maphieumuonsach"), reader("ngaymuonsach"), reader("hoten"), reader("diachi"), reader("ngaysinh")))
	'					End While
	'				End If

	'			Catch ex As Exception
	'				conn.Close()
	'				System.Console.WriteLine(ex.StackTrace)
	'				Return New Result(False, "Lấy tất cả Phiếu mượn sách không thành công", ex.StackTrace)
	'			End Try
	'		End Using
	'	End Using
	'	Return New Result(True) ' thanh cong
	'End Function

End Class
