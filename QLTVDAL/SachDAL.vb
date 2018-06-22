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
		nextMaSoSach = "MGX000"

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
					If (msOnDB <> Nothing And msOnDB.Length >= 4) Then
						nextMaSoSach = "MGX00"
						Dim v = msOnDB.Substring(3)
						Dim convertDecimal = Convert.ToDecimal(v)
						convertDecimal = convertDecimal + 1
						Dim tmp = convertDecimal.ToString()
						'tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
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
					Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function

	Public Function SelectAllByType(maLoai As Integer, listSach As List(Of SachDTO)) As Result
		Dim query As String = String.Empty
		query &= "SELECT [masach], [tensach], [matheloaisach], [tacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach] "
		query &= "FROM [tblSach] "
		query &= "WHERE [matheloaisach] = @matheloaisach"

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matheloaisach", maLoai)
				End With
				Try
					conn.Open()
					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()
					If reader.HasRows = True Then
						listSach.Clear()
						While reader.Read()
							listSach.Add(New SachDTO(reader("masach"), reader("tensach"), reader("matheloaisach"), reader("tacgia"), reader("namxuatban"), reader("nhaxuatban"), reader("ngaynhap"), reader("trigia"), reader("tinhtrangsach")))
						End While
					End If

				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lấy tất cả Sach theo Loại không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function SelectAllCondition(maLoai As Integer, 
	                                   tenSach As String,
	                                   tacGia As String, 
	                                   nhaXuatBan As String, 
	                                   minTriGia As Integer,
									   maxTriGia As Integer, 
	                                   minNamXuatBan as Integer,
	                                   maxNamXuatBan as Integer,
	                                   minNgayNhap As String,
	                                   maxNgayNhap As String,
	                                   listSach As List(Of SachDTO)) As Result

		Dim query As String = String.Empty

		query &= "SELECT [masach], [tensach], [matheloaisach], [tacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach] "
		query &= "FROM [tblSach] "
		query &= "WHERE " +
				 Condition.CheckDTORangeAndGetQuery(minTriGia, maxTriGia, "mintrigia", "maxtrigia", "trigia") + " AND " +
				 Condition.CheckDTORangeAndGetQuery(minNamXuatBan, maxNamXuatBan, "minnamxuatban", "maxnamxuatban", "namxuatban") + " AND " +
				 "ngaynhap BETWEEN @minngaynhap AND @maxngaynhap AND " +
				 Condition.CheckDTOEmptyAndGetQuery(maLoai, "matheloaisach") + " AND " +
				 Condition.CheckDTOEmptyAndGetQuery(tenSach, "tensach") + " AND " +
				 Condition.CheckDTOEmptyAndGetQuery(tacGia, "tacgia") + " AND " +
				 Condition.CheckDTOEmptyAndGetQuery(nhaXuatBan, "nhaxuatban")


		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matheloaisach", maLoai)
					.Parameters.AddWithValue("@tensach", tenSach)
					.Parameters.AddWithValue("@tacgia", tacGia)
					.Parameters.AddWithValue("@nhaxuatban", nhaXuatBan)
					.Parameters.AddWithValue("@mintrigia", minTriGia)
					.Parameters.AddWithValue("@maxtrigia", maxTriGia)
					.Parameters.AddWithValue("@minnamxuatban", minNamXuatBan)
					.Parameters.AddWithValue("@maxnamxuatban", maxNamXuatBan)
					.Parameters.AddWithValue("@minngaynhap", minNgayNhap)
					.Parameters.AddWithValue("@maxngaynhap", maxNgayNhap)
				End With
				Try
					conn.Open()
					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()
					If reader.HasRows = True Then
						listSach.Clear()
						While reader.Read()
							listSach.Add(New SachDTO(reader("masach"), reader("tensach"), reader("matheloaisach"), reader("tacgia"), reader("namxuatban"), reader("nhaxuatban"), reader("ngaynhap"), reader("trigia"), reader("tinhtrangsach")))
						End While
					End If

				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lấy tất cả Sách theo Loại không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	 End Function

	Public Function Update(sach As SachDTO) As Result
		Dim query As String = String.Empty

		query &= " UPDATE [tblSach] SET"
		query &= " [tensach] = @tensach "
		query &= " ,[matheloaisach] = @matheloaisach "
		query &= " ,[tacgia] = @tacgia "
		query &= " ,[namxuatban] = @namxuatban "
		query &= " ,[nhaxuatban] = @nhaxuatban "
		query &= " ,[ngaynhap] = @ngaynhap "
		query &= " ,[trigia] = @trigia "
		query &= " WHERE "
		query &= " [masach] = @masach "

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
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Cập nhập sách  không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function

	Public Function Delete(maSach As String) As Result
		Dim query As String = String.Empty
		query &= " DELETE FROM [tblSach] "
		query &= " WHERE "
		query &= " [masach] = @masach "

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@masach", maSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Xóa sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True)  ' thanh cong
	End Function
End Class
