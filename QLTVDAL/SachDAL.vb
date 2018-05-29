Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class SachDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub

	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function buildMaSoSach(ByRef nextMaSoSach As String) As Result 'ex: 18222229

		nextMaSoSach = String.Empty
		Dim y = DateTime.Now.Year
		Dim x = y.ToString().Substring(2)
		nextMaSoSach = x + "000000"

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [masach] "
		query &= "FROM [tblSach] "
		query &= "ORDER BY [masach] DESC "

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
							msOnDB = reader("masach")
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
						nextMaSoSach = year.ToString()
						Dim v = msOnDB.Substring(2)
						Dim convertDecimal = Convert.ToDecimal(v)
						convertDecimal = convertDecimal + 1
						Dim tmp = convertDecimal.ToString()
						tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
						nextMaSoSach = nextMaSoSach + tmp
						System.Console.WriteLine(nextMaSoSach)
					End If

				Catch ex As Exception
					conn.Close() ' that bai!!!
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lấy tự động Mã số sách kế tiếp không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function Insert(sach As SachDTO) As Result
		Dim query As String = String.Empty
		query &= "INSERT INTO [tblSach] ([masach], [tensach], [matheloaisach], [tacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach])"
		query &= "VALUES (@masach, @tensach, @matheloaisach, @tacgia, @namxuatban, @nhaxuatban, @ngaynhap, @trigia, @tinhtrangsach)"

		'get masach
		Dim nextMaSach = "1"
		buildMaSoSach(nextMaSach)
		sach.MaSach = nextMaSach

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@masach", sach.MaSach)
					.Parameters.AddWithValue("@tensach", sach.TenSach)
					.Parameters.AddWithValue("@matheloaisach", sach.MaTheLoaiSach)
					.Parameters.AddWithValue("@tacgia", sach.TacGia)
					.Parameters.AddWithValue("@namxuatban", sach.NamXuatBan)
					.Parameters.AddWithValue("@nhaxuatban", sach.NhaXuatBan)
					.Parameters.AddWithValue("@ngaynhap", sach.NgayNhap)
					.Parameters.AddWithValue("@trigia", sach.TriGia)
					.Parameters.AddWithValue("@tinhtrangsach", sach.TinhTrangSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Thêm sách  không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function
End Class
