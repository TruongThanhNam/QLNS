Imports DTO
Imports BLL
Public Class ManHinhLapHoaDonBanSach
  Dim sachbll As SachBLL = New SachBLL()
  Dim thamsobll As ThamSoBLL = New ThamSoBLL()
  Dim khachhangbll As KhachHangBLL = New KhachHangBLL()
  Dim baocaotonbll As BaoCaoTonBLL = New BaoCaoTonBLL()
  Dim phieuhoadonbll As PhieuHoaDonBLL = New PhieuHoaDonBLL()
  Dim chitietphieuhoadonbll As ChiTietPhieuHoaDonBLL = New ChiTietPhieuHoaDonBLL()
  Private Sub ManHinhLapHoaDonBanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiQuyDinh()
    HienThiSachLenListView()
    txtMaKhachHang.Text = khachhangbll.LayID()
    txtHoTenKhachHang.Focus()
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(66, 86, 0)
    btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(66, 86, 0)
  End Sub

  Private Sub HienThiSachLenListView()
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LayToanBoSach()
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã sách", 150)
    lvDaTa.Columns.Add("Tên sách", 350)
    lvDaTa.Columns.Add("Thể loại", 250)
    lvDaTa.Columns.Add("Tác giả", 350)
    lvDaTa.Columns.Add("Số lượng tồn", 250)
    lvDaTa.Columns.Add("Đơn giá", 350)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub HienThiQuyDinh()
    Dim thamso As ThamSo = thamsobll.LayDuLieu()
    txtSoTienNoToiDa.Text = thamso.SoTienNoToiDa.ToString()
    txtSoLuongTonToiThieuSauKhiBan.Text = thamso.SoLuongTonSauToiThieu.ToString()
  End Sub

  Private Sub lvDaTa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDaTa.SelectedIndexChanged
    If lvDaTa.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag

    Dim kh As KhachHang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    txtMaKhachHang.Text = kh.MaKhachHang
    txtHoTenKhachHang.Text = kh.HoTenKhachHang
    txtDiaChi.Text = kh.DiaChi
    txtDienThoai.Text = kh.DienThoai
    txtEmail.Text = kh.Email
    txtSoTienNo.Text = kh.SoTienNo.ToString()

  End Sub

  Private Sub btnTimSachTheoMa_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoMa.Click
    Dim masach As String = txtMaSach.Text
    Dim kq As Boolean = sachbll.KiemTraMaSach(masach)
    If kq = True Then
      HienThiSachTheoMaSach(masach)
    ElseIf kq = False Then
      MessageBox.Show("Mã không tồn tại")
    End If
    btnLamMoi.PerformClick()
  End Sub
  Private Sub HienThiSachTheoMaSach(masach As String)
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã sách", 150)
    lvDaTa.Columns.Add("Tên sách", 350)
    lvDaTa.Columns.Add("Thể loại", 250)
    lvDaTa.Columns.Add("Tác giả", 350)
    lvDaTa.Columns.Add("Số lượng tồn", 250)
    lvDaTa.Columns.Add("Đơn giá", 350)
    Dim sach As Sach = sachbll.LaySachTheoMaSach(masach)
    Dim lvi As ListViewItem = New ListViewItem(sach.MaSach)
    lvi.SubItems.Add(sach.TenSach)
    lvi.SubItems.Add(sach.TheLoai)
    lvi.SubItems.Add(sach.TacGia)
    lvi.SubItems.Add(sach.SoLuongTon)
    lvi.SubItems.Add(sach.DonGia)
    lvi.Tag = sach.MaSach
    lvi.ImageIndex = 0
    lvDaTa.Items.Add(lvi)
  End Sub

  Private Sub btnHienThiSach_Click(sender As Object, e As EventArgs) Handles btnHienThiSach.Click
    HienThiSachLenListView()
  End Sub

  Private Sub btnHienThiKhach_Click(sender As Object, e As EventArgs) Handles btnHienThiKhach.Click
    HienThiToanBoKhachHang()
  End Sub

  Private Sub HienThiToanBoKhachHang()
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 350)
    lvDaTa.Columns.Add("Địa chỉ", 350)
    lvDaTa.Columns.Add("Điện thoại", 250)
    lvDaTa.Columns.Add("Email", 350)
    lvDaTa.Columns.Add("Số tiền nợ", 350)
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    DSKH = khachhangbll.LayToanBoKhachHang()
    Dim itemkhachhang As KhachHang = New KhachHang()
    Dim sotiennotoida As Double = Double.Parse(txtSoTienNoToiDa.Text)
    For Each itemkhachhang In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkhachhang.MaKhachHang)
      lvi.SubItems.Add(itemkhachhang.HoTenKhachHang)
      lvi.SubItems.Add(itemkhachhang.DiaChi)
      lvi.SubItems.Add(itemkhachhang.DienThoai)
      lvi.SubItems.Add(itemkhachhang.Email)
      lvi.SubItems.Add(itemkhachhang.SoTienNo)
      If itemkhachhang.SoTienNo > sotiennotoida Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.Tag = itemkhachhang.MaKhachHang
      lvi.ImageIndex = 1
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimKhachTheoMa_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoMa.Click
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim khachhang As KhachHang = New KhachHang()
    khachhang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 350)
    lvDaTa.Columns.Add("Địa chỉ", 350)
    lvDaTa.Columns.Add("Điện thoại", 250)
    lvDaTa.Columns.Add("Email", 350)
    lvDaTa.Columns.Add("Số tiền nợ", 350)
    Dim sotiennotoida As Double = Double.Parse(txtSoTienNoToiDa.Text)
    Dim lvi As ListViewItem = New ListViewItem(khachhang.MaKhachHang)
    lvi.SubItems.Add(khachhang.HoTenKhachHang)
    lvi.SubItems.Add(khachhang.DiaChi)
    lvi.SubItems.Add(khachhang.DienThoai)
    lvi.SubItems.Add(khachhang.Email)
    lvi.SubItems.Add(khachhang.SoTienNo)
    If khachhang.SoTienNo > sotiennotoida Then
      lvi.BackColor = Color.LightCoral
    End If
    lvi.Tag = khachhang.MaKhachHang
    lvi.ImageIndex = 1
    lvDaTa.Items.Add(lvi)
    btnLamMoi.PerformClick()
  End Sub

  Private Sub btnTimKhachTheoTenKhach_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoTenKhach.Click
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 350)
    lvDaTa.Columns.Add("Địa chỉ", 350)
    lvDaTa.Columns.Add("Điện thoại", 250)
    lvDaTa.Columns.Add("Email", 350)
    lvDaTa.Columns.Add("Số tiền nợ", 350)
    Dim sotiennotoida As Double = Double.Parse(txtSoTienNoToiDa.Text)
    Dim tenkhachhang As String = txtHoTenKhachHang.Text
    Dim DSKH As List(Of KhachHang) = khachhangbll.LayKhachHangTheoTen(tenkhachhang)
    Dim itemkh As KhachHang = New KhachHang()
    For Each itemkh In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkh.MaKhachHang)
      lvi.SubItems.Add(itemkh.HoTenKhachHang)
      lvi.SubItems.Add(itemkh.DiaChi)
      lvi.SubItems.Add(itemkh.DienThoai)
      lvi.SubItems.Add(itemkh.Email)
      lvi.SubItems.Add(itemkh.SoTienNo)
      If itemkh.SoTienNo > sotiennotoida Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.Tag = itemkh.MaKhachHang
      lvi.ImageIndex = 1
      lvDaTa.Items.Add(lvi)
      btnLamMoi.PerformClick()
    Next
  End Sub

  Private Sub btnTimKhachTheoDiaChi_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoDiaChi.Click
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 350)
    lvDaTa.Columns.Add("Địa chỉ", 350)
    lvDaTa.Columns.Add("Điện thoại", 250)
    lvDaTa.Columns.Add("Email", 350)
    lvDaTa.Columns.Add("Số tiền nợ", 350)
    Dim sotiennotoida As Double = Double.Parse(txtSoTienNoToiDa.Text)
    Dim diachi As String = txtDiaChi.Text
    Dim DSKH As List(Of KhachHang) = khachhangbll.LayKhachHangTheoDiaChi(diachi)
    Dim itemkh As KhachHang = New KhachHang()
    For Each itemkh In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkh.MaKhachHang)
      lvi.SubItems.Add(itemkh.HoTenKhachHang)
      lvi.SubItems.Add(itemkh.DiaChi)
      lvi.SubItems.Add(itemkh.DienThoai)
      lvi.SubItems.Add(itemkh.Email)
      lvi.SubItems.Add(itemkh.SoTienNo)
      If itemkh.SoTienNo > sotiennotoida Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.Tag = itemkh.MaKhachHang
      lvi.ImageIndex = 1
      lvDaTa.Items.Add(lvi)
      btnLamMoi.PerformClick()
    Next
  End Sub

  Private Sub btnTimKhachTheoSoDienThoai_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoSoDienThoai.Click
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 350)
    lvDaTa.Columns.Add("Địa chỉ", 350)
    lvDaTa.Columns.Add("Điện thoại", 250)
    lvDaTa.Columns.Add("Email", 350)
    lvDaTa.Columns.Add("Số tiền nợ", 350)
    Dim sotiennotoida As Double = Double.Parse(txtSoTienNoToiDa.Text)
    Dim dienthoai As String = txtDienThoai.Text
    Dim DSKH As List(Of KhachHang) = khachhangbll.LayKhachHangTheoSoDienThoai(dienthoai)
    Dim itemkh As KhachHang = New KhachHang()
    For Each itemkh In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkh.MaKhachHang)
      lvi.SubItems.Add(itemkh.HoTenKhachHang)
      lvi.SubItems.Add(itemkh.DiaChi)
      lvi.SubItems.Add(itemkh.DienThoai)
      lvi.SubItems.Add(itemkh.Email)
      lvi.SubItems.Add(itemkh.SoTienNo)
      If itemkh.SoTienNo > sotiennotoida Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.Tag = itemkh.MaKhachHang
      lvi.ImageIndex = 1
      lvDaTa.Items.Add(lvi)
      btnLamMoi.PerformClick()
    Next
  End Sub

  Private Sub btnTimKhachTheoEmail_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoEmail.Click
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 350)
    lvDaTa.Columns.Add("Địa chỉ", 350)
    lvDaTa.Columns.Add("Điện thoại", 250)
    lvDaTa.Columns.Add("Email", 350)
    lvDaTa.Columns.Add("Số tiền nợ", 350)
    Dim sotiennotoida As Double = Double.Parse(txtSoTienNoToiDa.Text)
    Dim email As String = txtEmail.Text
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    Dim itemkh As KhachHang = New KhachHang()
    DSKH = khachhangbll.LayKhachHangTheoEmail(email)
    For Each itemkh In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkh.MaKhachHang)
      lvi.SubItems.Add(itemkh.HoTenKhachHang)
      lvi.SubItems.Add(itemkh.DiaChi)
      lvi.SubItems.Add(itemkh.DienThoai)
      lvi.SubItems.Add(itemkh.Email)
      lvi.SubItems.Add(itemkh.SoTienNo)
      If itemkh.SoTienNo > sotiennotoida Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.Tag = itemkh.MaKhachHang
      lvi.ImageIndex = 1
      lvDaTa.Items.Add(lvi)
      btnLamMoi.PerformClick()
    Next
  End Sub

  Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
    txtMaKhachHang.Text = khachhangbll.LayID()
    txtHoTenKhachHang.Text = ""
    txtDiaChi.Text = ""
    txtDienThoai.Text = ""
    txtEmail.Text = ""
    txtSoTienNo.Text = ""
    txtMaSach.Text = ""
    txtSoLuongMua.Text = ""
    txtTongTien.Text = ""
  End Sub

  Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
    If txtMaKhachHang.Text = "" Then
      MessageBox.Show("Chưa nhập mã khách hàng")
      Return
    End If
    If txtHoTenKhachHang.Text = "" Then
      MessageBox.Show("Chưa nhập họ tên khách hàng")
      Return
    End If
    If txtDiaChi.Text = "" Then
      MessageBox.Show("Chưa nhập địa chỉ")
      Return
    End If
    If txtDienThoai.Text = "" Then
      MessageBox.Show("Chưa nhập điện thoại")
      Return
    End If
    If txtEmail.Text = "" Then
      MessageBox.Show("Chưa nhập email")
      Return
    End If
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim hotenkhachhang As String = txtHoTenKhachHang.Text
    Dim diachi As String = txtDiaChi.Text
    Dim dienthoai As String = txtDienThoai.Text
    Dim email As String = txtEmail.Text
    Dim kq As Boolean = khachhangbll.ThemKhachHang(makhachhang, hotenkhachhang, diachi, dienthoai, email)
    If kq = True Then
      MessageBox.Show("Thêm khách hàng mới thành công")
      HienThiToanBoKhachHang()
      btnLamMoi.PerformClick()
      txtHoTenKhachHang.Focus()
    ElseIf kq = False Then
      MessageBox.Show("Mã khách hàng này đã tồn tại rồi")
    End If
  End Sub

  Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
    If lvDaTa.SelectedItems.Count = 0 Then
      MessageBox.Show("Chưa chọn sao sửa được")
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag
    Dim hotenkhachhang As String = txtHoTenKhachHang.Text
    Dim diachi As String = txtDiaChi.Text
    Dim dienthoai As String = txtDienThoai.Text
    Dim email As String = txtEmail.Text
    Dim kq As Boolean = khachhangbll.SuaKhachHang(makhachhang, hotenkhachhang, diachi, dienthoai, email)
    If kq = True Then
      MessageBox.Show("Sửa thông tin khách hàng thành công")
      HienThiToanBoKhachHang()
      btnLamMoi.PerformClick()
      txtHoTenKhachHang.Focus()
    End If
  End Sub

  Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
    If lvDaTa.SelectedItems.Count = 0 Then
      MessageBox.Show("Chưa chọn sao xóa")
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag
    Dim ret As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    If ret = DialogResult.Yes Then
      Dim kq As Boolean = khachhangbll.XoaKhachHang(makhachhang)
      If kq = True Then
        MessageBox.Show("Xóa khách hàng thành công")
        HienThiToanBoKhachHang()
        btnLamMoi.PerformClick()
        txtHoTenKhachHang.Focus()
      End If
    End If
  End Sub

  Private Sub btnBan_Click(sender As Object, e As EventArgs) Handles btnBan.Click
    If txtMaKhachHang.Text = "" Then
      MessageBox.Show("Chưa nhập mã khách hàng")
      Return
    End If
    If txtHoTenKhachHang.Text = "" Then
      MessageBox.Show("Chưa nhập họ tên khách hàng")
      Return
    End If
    If txtDiaChi.Text = "" Then
      MessageBox.Show("Chưa nhập địa chỉ")
      Return
    End If
    If txtDienThoai.Text = "" Then
      MessageBox.Show("Chưa nhập điện thoại")
      Return
    End If
    If txtEmail.Text = "" Then
      MessageBox.Show("Chưa nhập email")
      Return
    End If
    If txtMaSach.Text = "" Then
      MessageBox.Show("Chưa nhập mã sách")
      Return
    End If
    If txtSoLuongMua.Text = "" Then
      MessageBox.Show("Chưa nhập số lượng mua")
      Return
    End If
    If Integer.Parse(txtSoLuongMua.Text) = 0 Or Integer.Parse(txtSoLuongMua.Text) < 0 Then
      MessageBox.Show("Nhập số lượng mua không hợp lệ !")
      Return
    End If
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim kq As Boolean = khachhangbll.KiemTraMaKhachHang(makhachhang)

    If kq = True Then     'Khách hàng cũ
      Dim thamso As ThamSo = New ThamSo()
      thamso = thamsobll.LayDuLieu()
      If thamso.SuDungQuyDinhSoTienNoToiDa = True Then
        Dim sotiennoo As Double = khachhangbll.LaySoTienNoTheoMaKhachHang(makhachhang)
        Dim sotiennotoidaa As Double = Double.Parse(txtSoTienNoToiDa.Text)
        If sotiennoo > sotiennotoidaa Then
          MessageBox.Show("Không bán cho khách hàng này nữa vì khách hàng này đã nợ quá nhiều")
          Return
        End If
      End If
      Dim tonnn As BaoCaoTon = New BaoCaoTon()
      Dim masachhh As String = txtMaSach.Text
      Dim kiemtramasachhh As Boolean = sachbll.KiemTraMaSach(masachhh)
      If kiemtramasachhh = False Then
        MessageBox.Show("Mã sách không tồn tại !")
        Return
      End If
      tonnn = baocaotonbll.LayTonDauTheoMaSach(masachhh)
      Dim soluongtonn As Integer = sachbll.LaySoLuongTonTheoMaSach(masachhh)
      Dim tondauuu As Integer = tonnn.TonCuoi
      Dim tonphatsinhh As Integer = 0
      Dim toncuoiii As Integer
      Dim soluongmuaa As Integer = Integer.Parse(txtSoLuongMua.Text)
      If soluongtonn - soluongmuaa < Integer.Parse(txtSoLuongTonToiThieuSauKhiBan.Text) Then
        MessageBox.Show("Không thỏa qui định số lượng tồn tối thiểu sau khi bán !")
        Return
      End If
      tonphatsinhh = tonphatsinhh - soluongmuaa
      toncuoiii = tondauuu + tonphatsinhh
      Dim baocaotonnn As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
      baocaotonnn.txtMaChiTietTon.Text = baocaotonbll.LayID()
      baocaotonnn.txtMaSach.Text = txtMaSach.Text
      baocaotonnn.txtThang.Text = DateTime.Now.Month
      baocaotonnn.txtTonDau.Text = tondauuu.ToString()
      baocaotonnn.txtTonPhatSinh.Text = tonphatsinhh.ToString()
      baocaotonnn.txtTonCuoi.Text = toncuoiii.ToString()
      If baocaotonnn.ShowDialog() = DialogResult.OK Then
        Dim machitietton As String = baocaotonnn.txtMaChiTietTon.Text
        If machitietton = "" Then
          MessageBox.Show("Chưa nhập mã chi tiết tồn")
          Return
        End If
        Dim thang As Integer = baocaotonnn.txtThang.Text
        Dim masah As String = baocaotonnn.txtMaSach.Text
        Dim tondauu As Integer = Integer.Parse(baocaotonnn.txtTonDau.Text)
        Dim tonphatsinhhh As Integer = Integer.Parse(baocaotonnn.txtTonPhatSinh.Text)
        Dim toncuoii As Integer = Integer.Parse(baocaotonnn.txtTonCuoi.Text)
        Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thang, masah, tondauu, tonphatsinhhh, toncuoii)
        If kimtra = True Then
          MessageBox.Show("Cập nhật báo cáo tồn thành công")
        ElseIf kimtra = False Then
          MessageBox.Show("Mã chi tiết tồn đã tồn tại,vui lòng nhập lại")
          Return
        End If
      End If
      Dim phieuhoadonn As ManHinhPhieuHoaDon = New ManHinhPhieuHoaDon()
      phieuhoadonn.txtMaPhieuHoaDon.Text = phieuhoadonbll.LayID()
      phieuhoadonn.txtMaKhachHang.Text = txtMaKhachHang.Text
      phieuhoadonn.dtNgayLap.Value = DateTime.Now
      Dim strr As String = ""
      Dim makhachhanggg As String = ""
      Dim masach As String = ""
      Dim soluongbannn As Integer = 0
      If phieuhoadonn.ShowDialog() = DialogResult.OK Then
        Dim maphieuhoadon As String = phieuhoadonn.txtMaPhieuHoaDon.Text
        If maphieuhoadon = "" Then
          MessageBox.Show("Chưa nhập mã phiếu hóa đơn")
          Return
        End If
        strr = maphieuhoadon
        Dim makhachhangg As String = phieuhoadonn.txtMaKhachHang.Text
        If khachhangbll.KiemTraMaKhachHang(makhachhangg) = False Then
          MessageBox.Show("Bổ sung thông tin khách hàng mới trước khi thanh  toán")
          Return
        End If
        makhachhanggg = makhachhangg
        Dim ngaylap As DateTime = phieuhoadonn.dtNgayLap.Value
        Dim ktphieuhoadon As Boolean = phieuhoadonbll.CapNhatPhieuHoaDon(maphieuhoadon, makhachhangg, ngaylap)
        If ktphieuhoadon = True Then
          MessageBox.Show("Cập nhật phiếu hóa đơn thành công")
        ElseIf ktphieuhoadon = False Then
          MessageBox.Show("Mã phiếu hóa đơn này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
      Dim x As Integer = 1
      While x = 1
        Dim chitietphieuhoadonn As ManHinhChiTietPhieuHoaDon = New ManHinhChiTietPhieuHoaDon()
        chitietphieuhoadonn.txtMaChiTietPhieuHoaDon.Text = chitietphieuhoadonbll.LayID()
        chitietphieuhoadonn.txtMaPhieuHoaDon.Text = strr
        If txtMaSach.Text <> "" Then
          chitietphieuhoadonn.txtMaSach.Text = txtMaSach.Text
        End If
        If txtSoLuongMua.Text <> "" Then
          chitietphieuhoadonn.txtSoLuongBan.Text = txtSoLuongMua.Text
        End If
        If chitietphieuhoadonn.ShowDialog() = DialogResult.OK Then
          Dim machitietphieuhoadon As String = chitietphieuhoadonn.txtMaChiTietPhieuHoaDon.Text
          If machitietphieuhoadon = "" Then
            MessageBox.Show("Chưa nhập mã chi tiết phiếu hóa đơn")
            Return
          End If
          Dim maphieuhoadonn As String = chitietphieuhoadonn.txtMaPhieuHoaDon.Text
          If chitietphieuhoadonn.txtMaSach.Text = "" Then
            MessageBox.Show("Chưa nhập mã sách !")
            Return
          End If
          Dim masahh As String = chitietphieuhoadonn.txtMaSach.Text
          If sachbll.KiemTraMaSach(masahh) = False Then
            MessageBox.Show("Mã sách không tồn tại !")
            Return
          End If
          masach = masahh
          If chitietphieuhoadonn.txtSoLuongBan.Text = "" Then
            MessageBox.Show("Chưa nhập số lượng bán !")
            Return
          End If
          Dim soluongban As Integer = Integer.Parse(chitietphieuhoadonn.txtSoLuongBan.Text)
            soluongbannn = soluongban
            Dim kiemtrachitietphieuhoadon As Boolean = chitietphieuhoadonbll.CapNhapChiTietPhieuHoaDon(machitietphieuhoadon, maphieuhoadonn, masahh, soluongban)
            If kiemtrachitietphieuhoadon = True Then
              MessageBox.Show("Cập nhật chi tiết phiếu hóa đơn thành công")
            ElseIf kiemtrachitietphieuhoadon = False Then
              MessageBox.Show("Mã chi tiết phiếu hóa đơn này đã tồn tại rồi,vui lòng nhập lại")
              Return
            End If
          End If
          Dim soluongtontoithieusaukhibann As Integer = Integer.Parse(txtSoLuongTonToiThieuSauKhiBan.Text)
        Dim soluongtonmoii As Integer = sachbll.LaySoLuongTonTheoMaSach(masach) - soluongbannn
        If soluongtonmoii < soluongtontoithieusaukhibann Then
          MessageBox.Show("Không bán do không thỏa quy định số lượng tồn của sách sau khi bán")
          Return
        End If
        Dim dongiaa As Double = sachbll.LayDonGiaTheoMaSach(masach)
        Dim sotiennomoii As Double = soluongbannn * dongiaa
        txtTongTien.Text = sotiennomoii.ToString()
        Dim rett As DialogResult = MessageBox.Show("Bạn sẽ thanh toán trực tiếp ?", "Hỏi thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rett = DialogResult.Yes Then 'thanh toán trực tiếp
          Dim kqq As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masach, soluongtonmoii)
          If kqq = True Then
            MessageBox.Show("Bán sách thành công")
            HienThiSachLenListView()
            btnLamMoi.PerformClick()
            txtHoTenKhachHang.Focus()
          End If
        ElseIf rett = DialogResult.No Then 'ghi nợ
          Dim sotiennoo As Double = khachhangbll.LaySoTienNoTheoMaKhachHang(makhachhanggg)
          Dim kqqq As Boolean = khachhangbll.CapNhatTienNoMoiTheoMaKhachHang(makhachhanggg, sotiennomoii + sotiennoo)
          If kqqq = True Then
            MessageBox.Show("Cập nhật nợ cho khách hàng thành công")
          End If
          Dim kqq As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masach, soluongtonmoii)
          If kqq = True Then
            MessageBox.Show("Bán sách thành công")
            HienThiSachLenListView()
            btnLamMoi.PerformClick()
            txtHoTenKhachHang.Focus()
          End If
        End If
        Dim ret As DialogResult = MessageBox.Show("Bán tiếp không ?", "Hỏi bán", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ret = DialogResult.Yes Then
          x = 1
        Else
          x = 0
        End If
      End While
    ElseIf kq = False Then     'Khách hàng mới
      Dim makhachhangggg As String = txtMaKhachHang.Text
      Dim hotenkhachhang As String = txtHoTenKhachHang.Text
      Dim diachi As String = txtDiaChi.Text
      Dim dienthoai As String = txtDienThoai.Text
      Dim email As String = txtEmail.Text
      Dim bl As Boolean = khachhangbll.ThemKhachHang(makhachhangggg, hotenkhachhang, diachi, dienthoai, email)
      If bl = True Then
        MessageBox.Show("Thêm khách hàng mới thành công")
        HienThiToanBoKhachHang()
      ElseIf bl = False Then
        MessageBox.Show("Mã khách hàng này đã tồn tại rồi")
      End If
      Dim tonnn As BaoCaoTon = New BaoCaoTon()
      Dim masachhh As String = txtMaSach.Text
      Dim kiemtramasachhh As Boolean = sachbll.KiemTraMaSach(masachhh)
      If kiemtramasachhh = False Then
        MessageBox.Show("Mã sách không tồn tại !")
        Return
      End If
      tonnn = baocaotonbll.LayTonDauTheoMaSach(masachhh)
      Dim soluongtonn As Integer = sachbll.LaySoLuongTonTheoMaSach(masachhh)
      Dim tondauuu As Integer = tonnn.TonCuoi
      Dim tonphatsinhh As Integer = 0
      Dim toncuoiii As Integer
      Dim soluongmuaa As Integer = Integer.Parse(txtSoLuongMua.Text)
      If soluongtonn - soluongmuaa < Integer.Parse(txtSoLuongTonToiThieuSauKhiBan.Text) Then
        MessageBox.Show("Không thỏa qui định số lượng tồn tối thiểu sau khi bán !")
        Return
      End If
      tonphatsinhh = tonphatsinhh - soluongmuaa
      toncuoiii = tondauuu + tonphatsinhh
      Dim baocaotonnn As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
      baocaotonnn.txtMaChiTietTon.Text = baocaotonbll.LayID()
      baocaotonnn.txtMaSach.Text = txtMaSach.Text
      baocaotonnn.txtThang.Text = DateTime.Now.Month
      baocaotonnn.txtTonDau.Text = tondauuu.ToString()
      baocaotonnn.txtTonPhatSinh.Text = tonphatsinhh.ToString()
      baocaotonnn.txtTonCuoi.Text = toncuoiii.ToString()
      If baocaotonnn.ShowDialog() = DialogResult.OK Then
        Dim machitietton As String = baocaotonnn.txtMaChiTietTon.Text
        If machitietton = "" Then
          MessageBox.Show("Chưa nhập mã chi tiết tồn")
          Return
        End If
        Dim thang As Integer = baocaotonnn.txtThang.Text
        Dim masah As String = baocaotonnn.txtMaSach.Text
        Dim tondauu As Integer = Integer.Parse(baocaotonnn.txtTonDau.Text)
        Dim tonphatsinhhh As Integer = Integer.Parse(baocaotonnn.txtTonPhatSinh.Text)
        Dim toncuoii As Integer = Integer.Parse(baocaotonnn.txtTonCuoi.Text)
        Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thang, masah, tondauu, tonphatsinhhh, toncuoii)
        If kimtra = True Then
          MessageBox.Show("Cập nhật báo cáo tồn thành công")
        ElseIf kimtra = False Then
          MessageBox.Show("Mã chi tiết tồn đã tồn tại,vui lòng nhập lại")
          Return
        End If
      End If
      Dim phieuhoadonn As ManHinhPhieuHoaDon = New ManHinhPhieuHoaDon()
      phieuhoadonn.txtMaPhieuHoaDon.Text = phieuhoadonbll.LayID()
      phieuhoadonn.txtMaKhachHang.Text = txtMaKhachHang.Text
      phieuhoadonn.dtNgayLap.Value = DateTime.Now
      Dim strr As String = ""
      Dim makhachhanggg As String = ""
      Dim masach As String = ""
      Dim soluongbannn As Integer = 0
      If phieuhoadonn.ShowDialog() = DialogResult.OK Then
        Dim maphieuhoadon As String = phieuhoadonn.txtMaPhieuHoaDon.Text
        If maphieuhoadon = "" Then
          MessageBox.Show("Chưa nhập mã phiếu hóa đơn")
          Return
        End If
        strr = maphieuhoadon
        Dim makhachhangg As String = phieuhoadonn.txtMaKhachHang.Text
        If khachhangbll.KiemTraMaKhachHang(makhachhangg) = False Then
          MessageBox.Show("Bổ sung thông tin khách hàng mới trước khi thanh  toán")
          Return
        End If
        makhachhanggg = makhachhangg
        Dim ngaylap As DateTime = phieuhoadonn.dtNgayLap.Value
        Dim ktphieuhoadon As Boolean = phieuhoadonbll.CapNhatPhieuHoaDon(maphieuhoadon, makhachhangg, ngaylap)
        If ktphieuhoadon = True Then
          MessageBox.Show("Cập nhật phiếu hóa đơn thành công")
        ElseIf ktphieuhoadon = False Then
          MessageBox.Show("Mã phiếu hóa đơn này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
      Dim x As Integer = 1
      While x = 1
        Dim chitietphieuhoadonn As ManHinhChiTietPhieuHoaDon = New ManHinhChiTietPhieuHoaDon()
        chitietphieuhoadonn.txtMaChiTietPhieuHoaDon.Text = chitietphieuhoadonbll.LayID()
        chitietphieuhoadonn.txtMaPhieuHoaDon.Text = strr
        If txtMaSach.Text <> "" Then
          chitietphieuhoadonn.txtMaSach.Text = txtMaSach.Text
        End If
        If txtSoLuongMua.Text <> "" Then
          chitietphieuhoadonn.txtSoLuongBan.Text = txtSoLuongMua.Text
        End If
        If chitietphieuhoadonn.ShowDialog() = DialogResult.OK Then
          Dim machitietphieuhoadon As String = chitietphieuhoadonn.txtMaChiTietPhieuHoaDon.Text
          If machitietphieuhoadon = "" Then
            MessageBox.Show("Chưa nhập mã chi tiết phiếu hóa đơn")
            Return
          End If
          Dim maphieuhoadonn As String = chitietphieuhoadonn.txtMaPhieuHoaDon.Text
          If chitietphieuhoadonn.txtMaSach.Text = "" Then
            MessageBox.Show("Chưa nhập mã sách !")
            Return
          End If
          Dim masahh As String = chitietphieuhoadonn.txtMaSach.Text
          If sachbll.KiemTraMaSach(masahh) = False Then
            MessageBox.Show("Mã sách không tồn tại !")
            Return
          End If
          masach = masahh
          If chitietphieuhoadonn.txtSoLuongBan.Text = "" Then
            MessageBox.Show("Chưa nhập số lượng bán !")
            Return
          End If
          Dim soluongban As Integer = Integer.Parse(chitietphieuhoadonn.txtSoLuongBan.Text)
          soluongbannn = soluongban
          Dim kiemtrachitietphieuhoadon As Boolean = chitietphieuhoadonbll.CapNhapChiTietPhieuHoaDon(machitietphieuhoadon, maphieuhoadonn, masahh, soluongban)
          If kiemtrachitietphieuhoadon = True Then
            MessageBox.Show("Cập nhật chi tiết phiếu hóa đơn thành công")
          ElseIf kiemtrachitietphieuhoadon = False Then
            MessageBox.Show("Mã chi tiết phiếu hóa đơn này đã tồn tại rồi,vui lòng nhập lại")
            Return
          End If
        End If
        Dim soluongtontoithieusaukhibann As Integer = Integer.Parse(txtSoLuongTonToiThieuSauKhiBan.Text)
        Dim soluongtonmoii As Integer = sachbll.LaySoLuongTonTheoMaSach(masach) - soluongbannn
        If soluongtonmoii < soluongtontoithieusaukhibann Then
          MessageBox.Show("Không bán do không thỏa quy định số lượng tồn của sách sau khi bán")
          Return
        End If
        Dim dongiaa As Double = sachbll.LayDonGiaTheoMaSach(masach)
        Dim sotiennomoii As Double = soluongbannn * dongiaa
        txtTongTien.Text = sotiennomoii.ToString()
        Dim rett As DialogResult = MessageBox.Show("Bạn sẽ thanh toán trực tiếp ?", "Hỏi thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rett = DialogResult.Yes Then 'thanh toán trực tiếp
          Dim kqq As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masach, soluongtonmoii)
          If kqq = True Then
            MessageBox.Show("Bán sách thành công")
            HienThiSachLenListView()
            btnLamMoi.PerformClick()
            txtHoTenKhachHang.Focus()
          End If
        ElseIf rett = DialogResult.No Then 'ghi nợ
          Dim sotiennoo As Double = khachhangbll.LaySoTienNoTheoMaKhachHang(makhachhanggg)
          Dim kqqq As Boolean = khachhangbll.CapNhatTienNoMoiTheoMaKhachHang(makhachhanggg, sotiennomoii + sotiennoo)
          If kqqq = True Then
            MessageBox.Show("Cập nhật nợ cho khách hàng thành công")
          End If
          Dim kqq As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masach, soluongtonmoii)
          If kqq = True Then
            MessageBox.Show("Bán sách thành công")
            HienThiSachLenListView()
            btnLamMoi.PerformClick()
            txtHoTenKhachHang.Focus()
          End If
        End If
        Dim ret As DialogResult = MessageBox.Show("Bán tiếp không ?", "Hỏi bán", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ret = DialogResult.Yes Then
          x = 1
        Else
          x = 0
        End If
      End While
    End If
  End Sub

  Private Sub txtMaKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaKhachHang.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachTheoMa.PerformClick()
    End If
  End Sub

  Private Sub txtHoTenKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHoTenKhachHang.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachTheoTenKhach.PerformClick()
    End If
  End Sub

  Private Sub txtDiaChi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiaChi.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachTheoDiaChi.PerformClick()
    End If
  End Sub

  Private Sub txtDienThoai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDienThoai.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachTheoSoDienThoai.PerformClick()
    End If
  End Sub

  Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachTheoEmail.PerformClick()
    End If
  End Sub

  Private Sub txtMaSach_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaSach.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSachTheoMa.PerformClick()
    End If
  End Sub

  Private Sub txtSoLuongMua_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSoLuongMua.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnBan.PerformClick()
    End If
  End Sub

  Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
    Dim manhinhin As ManHinhInAnKhachHang = New ManHinhInAnKhachHang()
    Me.Visible = False
    manhinhin.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnTimKhachTheoMa_MouseDown(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoMa.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachTheoMa_MouseUp(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoMa.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimKhachTheoTenKhach_MouseDown(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoTenKhach.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachTheoTenKhach_MouseUp(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoTenKhach.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimKhachTheoDiaChi_MouseDown(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoDiaChi.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachTheoDiaChi_MouseUp(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoDiaChi.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimKhachTheoSoDienThoai_MouseDown(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoSoDienThoai.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachTheoSoDienThoai_MouseUp(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoSoDienThoai.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimKhachTheoEmail_MouseDown(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoEmail.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachTheoEmail_MouseUp(sender As Object, e As MouseEventArgs)
    btnTimKhachTheoEmail.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimSachTheoMa_MouseDown(sender As Object, e As MouseEventArgs)
    btnTimSachTheoMa.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSachTheoMa_MouseUp(sender As Object, e As MouseEventArgs)
    btnTimSachTheoMa.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnBan_MouseDown(sender As Object, e As MouseEventArgs)
    btnBan.BackColor = Color.Lime
  End Sub

  Private Sub btnBan_MouseUp(sender As Object, e As MouseEventArgs)
    btnBan.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnThem_MouseDown(sender As Object, e As MouseEventArgs)
    btnThem.BackColor = Color.Lime
  End Sub

  Private Sub btnThem_MouseUp(sender As Object, e As MouseEventArgs)
    btnThem.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnSua_MouseDown(sender As Object, e As MouseEventArgs)
    btnSua.BackColor = Color.Lime
  End Sub

  Private Sub btnSua_MouseUp(sender As Object, e As MouseEventArgs)
    btnSua.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnXoa_MouseDown(sender As Object, e As MouseEventArgs)
    btnXoa.BackColor = Color.Lime
  End Sub

  Private Sub btnXoa_MouseUp(sender As Object, e As MouseEventArgs)
    btnXoa.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnLamMoi_MouseDown(sender As Object, e As MouseEventArgs)
    btnLamMoi.BackColor = Color.Lime
  End Sub

  Private Sub btnLamMoi_MouseUp(sender As Object, e As MouseEventArgs)
    btnLamMoi.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnHienThiSach_MouseDown(sender As Object, e As MouseEventArgs)
    btnHienThiSach.BackColor = Color.Lime
  End Sub

  Private Sub btnHienThiSach_MouseUp(sender As Object, e As MouseEventArgs)
    btnHienThiSach.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnHienThiKhach_MouseDown(sender As Object, e As MouseEventArgs)
    btnHienThiKhach.BackColor = Color.Lime
  End Sub

  Private Sub btnHienThiKhach_MouseUp(sender As Object, e As MouseEventArgs)
    btnHienThiKhach.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnIn_MouseDown(sender As Object, e As MouseEventArgs)
    btnIn.BackColor = Color.Lime
  End Sub

  Private Sub btnIn_MouseUp(sender As Object, e As MouseEventArgs)
    btnIn.BackColor = Color.Gainsboro
  End Sub

  Private Sub txtSoLuongMua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuongMua.KeyPress
    If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub

  Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
    Close()
  End Sub

  Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
    Me.WindowState = FormWindowState.Minimized
  End Sub

  Private Sub txtMaKhachHang_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaKhachHang.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtMaKhachHang.Text = ""
      txtMaKhachHang.Text = khachhangbll.LayID()
      txtHoTenKhachHang.Focus()
    End If
  End Sub

  Private Sub txtHoTenKhachHang_KeyUp(sender As Object, e As KeyEventArgs) Handles txtHoTenKhachHang.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtHoTenKhachHang.Text = ""
    End If
  End Sub

  Private Sub txtDiaChi_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDiaChi.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtDiaChi.Text = ""
    End If
  End Sub

  Private Sub txtDienThoai_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDienThoai.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtDienThoai.Text = ""
    End If
  End Sub

  Private Sub txtEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtEmail.Text = ""
    End If
  End Sub

  Private Sub txtMaSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaSach.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtMaSach.Text = ""
    End If
  End Sub
End Class