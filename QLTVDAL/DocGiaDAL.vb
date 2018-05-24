Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class DocGiaDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub
	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function BuildMaSoDocGia(ByRef NextMaSoDocGia As String) As Result
		NextMaSoDocGia = String.Empty
		Dim y = DateTime.Now.Year
		Dim x = y.ToString().Substring(2)
		NextMaSoDocGia = x

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [madocgia] "
		query &= "FROM [tblDocGia] "
		query &= "ORDER BY [madocgia] DESC "

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
							msOnDB = reader("madocgia")
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
						NextMaSoDocGia = year.ToString()
						Dim v = msOnDB.Substring(2)
						Dim convertDecimal = Convert.ToDecimal(v)
						convertDecimal = convertDecimal + 1
						Dim tmp = convertDecimal.ToString()
						tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
						NextMaSoDocGia = NextMaSoDocGia + tmp
						System.Console.WriteLine(NextMaSoDocGia)
					End If

				Catch ex As Exception
					conn.Close() ' that bai!!!
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lấy tự động Mã độc giả kế tiếp không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function insert(docGia As DocGiaDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe])"
		query &= "VALUES (@madocgia, @hoten, @maloaidocgia, @ngaysinh, @diachi, @email, @ngaylapthe)"
		'query &= "INSERT INTO [tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia])"
		'query &= "VALUES (@maloaiddocgia, @tenloaidocgia)"

		'get madocgia
		Dim nextmadocgia = "1"
		BuildMaSoDocGia(nextmadocgia)
		docGia.MaDocGia = nextmadocgia

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@madocgia", docGia.MaDocGia)
					.Parameters.AddWithValue("@hoten", docGia.HoTen)
					.Parameters.AddWithValue("@maloaidocgia", docGia.MaLoaiDocGia)
					.Parameters.AddWithValue("@ngaysinh", docGia.NgaySinh)
					.Parameters.AddWithValue("@diachi", docGia.DiaChi)
					.Parameters.AddWithValue("@email", docGia.Email)
					.Parameters.AddWithValue("@ngaylapthe", docGia.NgayLapThe)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Thêm độc giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

End Class
