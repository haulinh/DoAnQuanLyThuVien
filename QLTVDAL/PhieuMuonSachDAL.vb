Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class PhieuMuonSachDAL
	Private connectionString As String
	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub
	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function BuildMaPhieuMuonSach(ByRef nextMaPhieuMuonSach As String) As Result
		nextMaPhieuMuonSach = String.Empty
		nextMaPhieuMuonSach = "SNS000"

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
					If (msOnDB <> Nothing And msOnDB.Length >= 4) Then
						nextMaPhieuMuonSach = "SNS00"
						Dim v = msOnDB.Substring(3)
						Dim convertDecimal = Convert.ToDecimal(v)
						convertDecimal = convertDecimal + 1
						Dim tmp = convertDecimal.ToString()
						'tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
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
End Class
