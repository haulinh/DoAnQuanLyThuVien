Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmQuanLyDocGia
	Private docGiaBUS As docGiaBUS
	Private loaiDocGiaBUS As LoaidocGiaBUS

	Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvListDocGia.CurrentCellAddress.Y ' current row selected

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvListDocGia.RowCount) Then
			Try
				Dim docGia As DocGiaDTO
				docGia = New DocGiaDTO()

				'1. Mapping data from GUI control
				docGia.MaDocGia = txtMaDocGia.Text
				docGia.HoTen = txtHoTenDocGia.Text
				docGia.NgaySinh = dtpNgaySinh.Value
				docGia.Email = txtEmail.Text
				docGia.DiaChi = txtDiaChi.Text
				docGia.NgayLapThe = dtNgayLapThe.Value
				docGia.MaLoaiDocGia = Convert.ToInt32(cbLoaiDocGiaCapNhat.SelectedValue)

				'2. Business .....
				If (docGiaBUS.IsVaildName(docGia) = False) Then
					MessageBox.Show("Họ tên Độc Giả không đúng.")
					txtHoTenDocGia.Focus()
					Return
				End If
				'3. Insert to DB
				Dim result As Result
				result = docGiaBUS.Update(docGia)
				If (result.FlagResult = True) Then
					' Re-Load docGia list
					LoadListDocGia(cbLoaiDocGia.SelectedValue)
					' Hightlight the row has been updated on table
					dgvListDocGia.Rows(currentRowIndex).Selected = True

					MessageBox.Show("Cập nhật Độc Giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Else
					MessageBox.Show("Cập nhật Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					System.Console.WriteLine(result.SystemMessage)
				End If
			Catch ex As Exception
				Console.WriteLine(ex.StackTrace)
			End Try
		End If

	End Sub

	Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvListDocGia.CurrentCellAddress.Y 'current row selected

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvListDocGia.RowCount) Then
			Select Case MsgBox("Bạn có thực sự muốn xóa học sinh có mã số: " + txtMaDocGia.Text, MsgBoxStyle.YesNo, "Information")

				Case MsgBoxResult.Yes
					Try
						'1. Delete from DB
						Dim result As Result
						result = docGiaBUS.Delete(txtMaDocGia.Text)
						If (result.FlagResult = True) Then

							' Re-Load LoaiHocSinh list
							LoadListDocGia(cbLoaiDocGia.SelectedValue)

							' Hightlight the next row on table
							If (currentRowIndex >= dgvListDocGia.Rows.Count) Then
								currentRowIndex = currentRowIndex - 1
							End If
							If (currentRowIndex >= 0) Then
								dgvListDocGia.Rows(currentRowIndex).Selected = True
							End If

							MessageBox.Show("Xóa Độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
						Else
							MessageBox.Show("Xóa Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
							System.Console.WriteLine(result.SystemMessage)
						End If
					Catch ex As Exception
						Console.WriteLine(ex.StackTrace)
					End Try
				Case MsgBoxResult.No
					Return
			End Select

		End If

	End Sub

	Private Sub frmQuanLyDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		docGiaBUS = New docGiaBUS()
		loaiDocGiaBUS = New LoaidocGiaBUS()

		'Load LoaiDocGia list
		Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
		Dim result As Result
		result = loaiDocGiaBUS.SelectAll(listLoaiDocGia)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách loại Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		cbLoaiDocGia.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
		cbLoaiDocGia.DisplayMember = "TenLoaiDocGia"
		cbLoaiDocGia.ValueMember = "MaLoaiDocGia"

		cbLoaiDocGiaCapNhat.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
		cbLoaiDocGiaCapNhat.DisplayMember = "TenLoaiDocGia"
		cbLoaiDocGiaCapNhat.ValueMember = "MaLoaiDocGia"

	End Sub

	Private Sub LoadListDocGia()
		Dim listDocGia = New List(Of DocGiaDTO)
		Dim result As Result
		result = docGiaBUS.SelectAll(listDocGia)

		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		'dgvListDocGia.SuspendLayout()
		dgvListDocGia.Columns.Clear()
		dgvListDocGia.DataSource = Nothing

		dgvListDocGia.AutoGenerateColumns = False
		dgvListDocGia.AllowUserToAddRows = False
		dgvListDocGia.DataSource = listDocGia

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "madocgia"
		clMa.HeaderText = "Mã Độc Giả"
		clMa.DataPropertyName = "MaDocGia"
		dgvListDocGia.Columns.Add(clMa)

		Dim clHoTen = New DataGridViewTextBoxColumn()
		clHoTen.Name = "HoTen"
		clHoTen.HeaderText = "Họ Tên"
		clHoTen.DataPropertyName = "HoTen"
		dgvListDocGia.Columns.Add(clHoTen)

		Dim clLoaiHS = New DataGridView()
		'clLoaiHS.Name = "LoaiHS"
		'clLoaiHS.HeaderText = "Tên Loại"
		'clLoaiHS.DataPropertyName = "LoaiHS"
		'dgvListDocGia.Columns.Add(clLoaiHS)

		Dim clNgaySinh = New DataGridViewTextBoxColumn()
		clNgaySinh.Name = "NgaySinh"
		clNgaySinh.HeaderText = "Ngày Sinh"
		clNgaySinh.DataPropertyName = "NgaySinh"
		dgvListDocGia.Columns.Add(clNgaySinh)
		'dgvListDocGia.ResumeLayout()

		Dim clDiaChi = New DataGridViewTextBoxColumn()
		clDiaChi.Name = "DiaChi"
		clDiaChi.HeaderText = "Địa Chỉ"
		clDiaChi.DataPropertyName = "DiaChi"
		dgvListDocGia.Columns.Add(clDiaChi)

		Dim clEmail = New DataGridViewTextBoxColumn()
		clNgaySinh.Name = "Email"
		clNgaySinh.HeaderText = "Email"
		clNgaySinh.DataPropertyName = "Email"
		dgvListDocGia.Columns.Add(clEmail)
		'dgvListDocGia.ResumeLayout()

		Dim clNgayLapThe = New DataGridViewTextBoxColumn()
		clNgaySinh.Name = "NgayLapThe"
		clNgaySinh.HeaderText = "Ngày Lập Thẻ"
		clNgaySinh.DataPropertyName = "NgayLapThe"
		dgvListDocGia.Columns.Add(clNgayLapThe)
		'dgvListDocGia.ResumeLayout()

	End Sub


	Private Sub LoadListDocGia(maLoai As String)
		Dim listDocGia = New List(Of DocGiaDTO)
		Dim result As Result
		result = docGiaBUS.SelectAllByType(maLoai, listDocGia)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách Độc Giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		'dgvListDocGia.SuspendLayout()
		dgvListDocGia.Columns.Clear()
		dgvListDocGia.DataSource = Nothing

		dgvListDocGia.AutoGenerateColumns = False
		dgvListDocGia.AllowUserToAddRows = False
		dgvListDocGia.DataSource = listDocGia

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "MaDocGia"
		clMa.HeaderText = "Mã Độc Giả"
		clMa.DataPropertyName = "MaDocGia"
		dgvListDocGia.Columns.Add(clMa)

		Dim clHoTen = New DataGridViewTextBoxColumn()
		clHoTen.Name = "HoTen"
		clHoTen.HeaderText = "Họ Tên"
		clHoTen.DataPropertyName = "HoTen"
		dgvListDocGia.Columns.Add(clHoTen)

		Dim clLoaiHS = New DataGridView()
		'clLoaiHS.Name = "LoaiHS"
		'clLoaiHS.HeaderText = "Tên Loại"
		'clLoaiHS.DataPropertyName = "LoaiHS"
		'dgvListDocGia.Columns.Add(clLoaiHS)

		Dim clNgaySinh = New DataGridViewTextBoxColumn()
		clNgaySinh.Name = "NgaySinh"
		clNgaySinh.HeaderText = "Ngày Sinh"
		clNgaySinh.DataPropertyName = "NgaySinh"
		dgvListDocGia.Columns.Add(clNgaySinh)
		'dgvListDocGia.ResumeLayout()

		Dim clDiaChi = New DataGridViewTextBoxColumn()
		clDiaChi.Name = "DiaChi"
		clDiaChi.HeaderText = "Địa Chỉ"
		clDiaChi.DataPropertyName = "DiaChi"
		dgvListDocGia.Columns.Add(clDiaChi)

		Dim clEmail = New DataGridViewTextBoxColumn()
		clDiaChi.Name = "Email"
		clDiaChi.HeaderText = "Email"
		clDiaChi.DataPropertyName = "Email"
		dgvListDocGia.Columns.Add(clEmail)

		Dim clNgayLapThe = New DataGridViewTextBoxColumn()
		clDiaChi.Name = "NgayLapThe"
		clDiaChi.HeaderText = "Ngày Lập Thẻ"
		clDiaChi.DataPropertyName = "NgayLapThe"
		dgvListDocGia.Columns.Add(clNgayLapThe)

	End Sub

	Private Sub cbLoaiDocGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoaiDocGia.SelectedIndexChanged
		Try
			Dim maLoai = Convert.ToInt32(cbLoaiDocGia.SELECTedValue)
			LoadListDocGia(maLoai)
		Catch ex As Exception
		End Try

	End Sub

	Private Sub dgvListDocGia_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListDocGia.SelectionChanged
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvListDocGia.CurrentCellAddress.Y 'current row selected
		'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

		' Write coordinates to console for debugging
		'Console.WriteLine(y.ToString + " " + x.ToString)

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvListDocGia.RowCount) Then
			Try
				Dim docGia = CType(dgvListDocGia.Rows(currentRowIndex).DataBoundItem, DocGiaDTO)
				txtMaDocGia.Text = docGia.MaDocGia
				txtHoTenDocGia.Text = docGia.HoTen
				dtpNgaySinh.Value = docGia.NgaySinh
				txtDiaChi.Text = docGia.DiaChi
				txtEmail.Text = docGia.Email
				dtNgayLapThe.Value = docGia.NgayLapThe
				cbLoaiDocGiaCapNhat.SelectedIndex = cbLoaiDocGia.SelectedIndex
			Catch ex As Exception
				Console.WriteLine(ex.StackTrace)
			End Try
		End If

	End Sub

End Class