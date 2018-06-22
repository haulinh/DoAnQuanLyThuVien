Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmTraCuuSach
	Private sachBUS As SachBUS
	Private theLoaiSachBUS As TheLoaiSachBUS

	Private Sub LoadMaxinumAndMininum()
		nudMinTriGia.Minimum = 0
		nudMinTriGia.Maximum = Decimal.MaxValue

		nudMaxTriGia.Minimum = 0
		nudMaxTriGia.Maximum = Decimal.MaxValue

		nudMinNamXuatBan.Minimum = 0
		nudMinNamXuatBan.Maximum = Decimal.MaxValue

		nudMaxNamXuatBan.Minimum = 0
		nudMaxNamXuatBan.Maximum = Decimal.MaxValue
	End Sub

	Private Sub LoadListSach(maLoai As Integer,
							 tenSach As String,
							 tacGia As String,
							 nhaXuatBan As String,
							 minTriGia As Integer,
							 maxTriGia As Integer,
	                         minNamXuatBan As Integer,
	                         maxNamXuatBan As Integer, 
	                         minNgayNhap As String,
	                         maxNgayNhap As String)
		Dim listSach = New List(Of SachDTO)
		Dim result As Result
		result = sachBUS.SelectAllCondition(maLoai, tenSach, tacGia, nhaXuatBan, minTriGia, maxTriGia, minNamXuatBan, maxNamXuatBan, minNgayNhap, maxNgayNhap, listSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		'dgvListDocGia.SuspendLayout()
		dgvListSach.Columns.Clear()
		dgvListSach.DataSource = Nothing

		dgvListSach.AutoGenerateColumns = False
		dgvListSach.AllowUserToAddRows = False
		dgvListSach.DataSource = listSach

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "MaSach"
		clMa.HeaderText = "Mã Sách"
		clMa.DataPropertyName = "MaSach"
		dgvListSach.Columns.Add(clMa)

		Dim clTenSach = New DataGridViewTextBoxColumn()
		clTenSach.Name = "TenSach"
		clTenSach.HeaderText = "Tên Sách"
		clTenSach.DataPropertyName = "TenSach"
		dgvListSach.Columns.Add(clTenSach)

		Dim clTacGia = New DataGridViewTextBoxColumn()
		clTacGia.Name = "TacGia"
		clTacGia.HeaderText = "Tác Giả"
		clTacGia.DataPropertyName = "TacGia"
		dgvListSach.Columns.Add(clTacGia)

		Dim clNamXuatBan = New DataGridViewTextBoxColumn()
		clNamXuatBan.Name = "NamXuatBan"
		clNamXuatBan.HeaderText = "Năm Xuất Bản"
		clNamXuatBan.DataPropertyName = "NamXuatBan"
		dgvListSach.Columns.Add(clNamXuatBan)

		Dim clNhaXuatBan = New DataGridViewTextBoxColumn()
		clNhaXuatBan.Name = "NhaXuatBan"
		clNhaXuatBan.HeaderText = "Nhà Xuất Bản"
		clNhaXuatBan.DataPropertyName = "NhaXuatBan"
		dgvListSach.Columns.Add(clNhaXuatBan)

		Dim clNgayNhap = New DataGridViewTextBoxColumn()
		clNgayNhap.Name = "NgayNhap"
		clNgayNhap.HeaderText = "Ngày Nhập"
		clNgayNhap.DataPropertyName = "NgayNhap"
		dgvListSach.Columns.Add(clNgayNhap)

		Dim clTriGia = New DataGridViewTextBoxColumn()
		clTriGia.Name = "TriGia"
		clTriGia.HeaderText = "Trị Giá"
		clTriGia.DataPropertyName = "TriGia"
		dgvListSach.Columns.Add(clTriGia)

		Dim clTinhTrangSach = New DataGridViewTextBoxColumn()
		clTinhTrangSach.Name = "TinhTrangSach"
		clTinhTrangSach.HeaderText = "Tình Trạng Sách"
		clTinhTrangSach.DataPropertyName = "TinhTrangSach"
		dgvListSach.Columns.Add(clTinhTrangSach)

	End Sub

	Private Sub frmTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sachBUS = New SachBUS()
		theLoaiSachBUS = New TheLoaiSachBUS()

		'Load LoaiDocGia list
		Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
		Dim result As Result
		result = theLoaiSachBUS.selectAll(listTheLoaiSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If


		cbTheLoaiSach.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
		cbTheLoaiSach.DisplayMember = "TenTheLoaiSach"
		cbTheLoaiSach.ValueMember = "MaTheLoaiSach"

		dtpMinNgayNhap.Value = DateTimePicker.MinimumDateTime
		dtpMaxNgayNhap.Value = Date.Today

		LoadMaxinumAndMininum()

	End Sub

	Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
		Try
			Dim maLoai = Convert.ToInt32(cbTheLoaiSach.SelectedValue)
			Dim tenSach = txtTenSach.Text
			Dim tacGia = txtTacGia.Text
			Dim nhaXuatBan = txtNhaXuatBan.Text
			Dim minNgayNhap = dtpMinNgayNhap.Value
			Dim maxNgayNhap = dtpMaxNgayNhap.Value
			Dim minTriGia
			Dim maxTriGia
			Dim minNamXuatBan
			Dim maxNamXuatBan

			minTriGia = SachBUS.GetMinAndMaxValue(nudMinTriGia.Text)
			maxTriGia = SachBUS.GetMinAndMaxValue(nudMaxTriGia.Text)
			minNamXuatBan = SachBUS.GetMinAndMaxValue(nudMinNamXuatBan.Text)
			maxNamXuatBan = SachBUS.GetMinAndMaxValue(nudMaxNamXuatBan.Text)

			LoadListSach(maLoai, tenSach, tacGia, nhaXuatBan, minTriGia, maxTriGia, minNamXuatBan, maxNamXuatBan, minNgayNhap, maxNgayNhap)
		Catch ex As Exception
		End Try
	End Sub
End Class