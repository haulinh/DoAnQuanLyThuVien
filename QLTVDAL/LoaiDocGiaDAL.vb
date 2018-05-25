Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class LoaiDocGiaDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub
	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function GetNextID(ByRef nextID As Integer) As Result

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [maloaidocgia] "
		query &= "FROM [tblLoaiDocGia] "
		query &= "ORDER BY [maloaidocgia] DESC "

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
					Dim idOnDB As Integer
					idOnDB = Nothing
					If reader.HasRows = True Then
						While reader.Read()
							idOnDB = reader("maloaidocgia")
						End While
					End If
					' new ID = current ID + 1
					nextID = idOnDB + 1
				Catch ex As Exception
					conn.Close()
					' them that bai!!!
					nextID = 1
					Return New Result(False, "Lấy ID kế tiếp của độc giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function insert(loaiDocGia As LoaiDocGiaDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia])"
		query &= "VALUES (@maloaidocgia, @tenloaidocgia)"

		Dim nextID = 0
		Dim result As Result
		result = GetNextID(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		loaiDocGia.MaLoaiDocGia = nextID

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@maloaidocgia", loaiDocGia.MaLoaiDocGia)
					.Parameters.AddWithValue("@tenloaidocgia", loaiDocGia.TenLoaiDocGia)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Thêm độc giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function selectALL(ByRef listLoaiDocGia As List(Of LoaiDocGiaDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [maloaidocgia], [tenloaidocgia]"
		query &= " FROM [tblLoaiDocGia]"


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
					If reader.HasRows = True Then
						listLoaiDocGia.Clear()
						While reader.Read()
							listLoaiDocGia.Add(New LoaiDocGiaDTO(reader("maloaidocgia"), reader("tenloaidocgia")))
						End While
					End If
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Lấy tất cả loại đọc giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

End Class
