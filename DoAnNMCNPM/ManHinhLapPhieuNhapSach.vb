Imports BLL
Imports DTO
Public Class ManHinhLapPhieuNhapSach
  Dim thamsobll As ThamSoBLL = New ThamSoBLL()
  Dim sachbll As SachBLL = New SachBLL()
  Dim phieunhapbll As PhieuNhapBLL = New PhieuNhapBLL()
  Dim chitietphieunhapbll As ChiTietPhieuNhapBLL = New ChiTietPhieuNhapBLL()
  Dim baocaotonbll As BaoCaoTonBLL = New BaoCaoTonBLL()
  Private Sub LapPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiQuyDinh()
    HienThiToanBoSachLenListView()
    Dim t = 5
    txtMaSach.Text = sachbll.LayId()
    txtTenSach.Focus()
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(66, 86, 0)
    btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(66, 86, 0)
  End Sub

  Private Sub HienThiToanBoSachLenListView()
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LayToanBoSach()
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim soluongtontoidatruockhinhap As Integer = Integer.Parse(txtSoLuongTonToiDaTruocNhap.Text)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      If itemsach.SoLuongTon >= soluongtontoidatruockhinhap Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvData.Items.Add(lvi)
    Next
  End Sub
  Private Sub HienThiQuyDinh()
    Dim thamso As ThamSo = New ThamSo()
    thamso = thamsobll.LayDuLieu()
    txtSoLuongNhapItNhat.Text = thamso.SoLuongNhapItNhat
    txtSoLuongTonToiDaTruocNhap.Text = thamso.SoLuongTonToiDaTruocNhap
  End Sub

  Private Sub lvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged
    If lvData.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvData.SelectedItems(0)
    Dim masach As String = lvi.Tag.ToString()
    HienThiThongTinChiTietCho1QuyenSach(masach)
  End Sub

  Private Sub HienThiThongTinChiTietCho1QuyenSach(masach As String)
    Dim sach As Sach = New Sach()
    sach = sachbll.LaySachTheoMaSach(masach)
    txtMaSach.Text = sach.MaSach
    txtTenSach.Text = sach.TenSach
    txtTheLoai.Text = sach.TheLoai
    txtTacGia.Text = sach.TacGia
    txtSoLuongTon.Text = sach.SoLuongTon
    txtDonGia.Text = sach.DonGia
  End Sub

  Private Sub btnTimSach_Click(sender As Object, e As EventArgs) Handles btnTimSach.Click
    Dim masach As String = txtMaSach.Text
    masach = masach.Replace("\n", "")
    Dim kq As Boolean = sachbll.KiemTraMaSach(masach)
    If kq = True Then
      HienThiSachTheoMaSach(masach)
      btnLamMoi.PerformClick()
    ElseIf kq = False Then
      MessageBox.Show("Mã không tồn tại")
      btnLamMoi.PerformClick()
    End If
  End Sub

  Private Sub HienThiSachTheoMaSach(masach As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim soluongtontoidatruockhinhap As Integer = Integer.Parse(txtSoLuongTonToiDaTruocNhap.Text)
    Dim sach As Sach = sachbll.LaySachTheoMaSach(masach)
    Dim lvi As ListViewItem = New ListViewItem(sach.MaSach)
    lvi.SubItems.Add(sach.TenSach)
    lvi.SubItems.Add(sach.TheLoai)
    lvi.SubItems.Add(sach.TacGia)
    lvi.SubItems.Add(sach.SoLuongTon)
    If sach.SoLuongTon >= soluongtontoidatruockhinhap Then
      lvi.BackColor = Color.LightCoral
    End If
    lvi.SubItems.Add(sach.DonGia)
    lvi.Tag = sach.MaSach
    lvi.ImageIndex = 0
    lvData.Items.Add(lvi)
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTen.Click
    Dim tensach As String = txtTenSach.Text
    HienThiSachTheoTenSach(tensach)
    btnLamMoi.PerformClick()
  End Sub

  Private Sub HienThiSachTheoTenSach(tensach As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim soluongtontoidatruockhinhap As Integer = Integer.Parse(txtSoLuongTonToiDaTruocNhap.Text)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTen(tensach)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      If itemsach.SoLuongTon >= soluongtontoidatruockhinhap Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimSachTheoTheLoai_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTheLoai.Click
    Dim theloai As String = txtTheLoai.Text
    HienThiSachTheoTheLoai(theloai)
    btnLamMoi.PerformClick()
  End Sub

  Private Sub HienThiSachTheoTheLoai(theloai As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim soluongtontoidatruockhinhap As Integer = Integer.Parse(txtSoLuongTonToiDaTruocNhap.Text)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTheLoai(theloai)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      If itemsach.SoLuongTon >= soluongtontoidatruockhinhap Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimSachTheoTacGia_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTacGia.Click
    Dim tacgia As String = txtTacGia.Text
    HienThiSachTheoTacGia(tacgia)
    btnLamMoi.PerformClick()
  End Sub

  Private Sub HienThiSachTheoTacGia(tacgia As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim soluongtontoidatruockhinhap As Integer = Integer.Parse(txtSoLuongTonToiDaTruocNhap.Text)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTacGia(tacgia)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      If itemsach.SoLuongTon >= soluongtontoidatruockhinhap Then
        lvi.BackColor = Color.LightCoral
      End If
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnToanBo_Click(sender As Object, e As EventArgs) Handles btnToanBo.Click
    HienThiToanBoSachLenListView()
  End Sub

  Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
    txtMaSach.Text = sachbll.LayId()
    txtTenSach.Text = ""
    txtTheLoai.Text = ""
    txtTacGia.Text = ""
    txtSoLuongNhap.Text = ""
    txtSoLuongTon.Text = ""
    txtDonGia.Text = ""
  End Sub

  Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
    Dim quydinhsoluongnhapitnhat As Integer = Integer.Parse(txtSoLuongNhapItNhat.Text)
    Dim quydinhsoluongtontoidatruocnhap As Integer = Integer.Parse(txtSoLuongTonToiDaTruocNhap.Text)
    If txtMaSach.Text = "" Then
      MessageBox.Show("Chưa nhập mã sách")
      Return
    End If
    If txtTenSach.Text = "" Then
      MessageBox.Show("Chưa nhập tên sách")
      Return
    End If
    If txtTheLoai.Text = "" Then
      MessageBox.Show("Chưa nhập thể loại sách")
      Return
    End If
    If txtTacGia.Text = "" Then
      MessageBox.Show("Chưa nhập tác giả")
      Return
    End If
    If txtDonGia.Text = "" Then
      MessageBox.Show("Chưa nhập đơn giá")
      Return
    End If
    If txtSoLuongNhap.Text = "" Then
      MessageBox.Show("Chưa nhập số lượng sách cần nhập vào")
      Return
    End If
    If Integer.Parse(txtDonGia.Text) = 0 Or Integer.Parse(txtDonGia.Text) < 0 Then
      MessageBox.Show("Nhập đơn giá không hợp lệ !")
      Return
    End If
    If Integer.Parse(txtSoLuongNhap.Text) = 0 Or Integer.Parse(txtSoLuongNhap.Text) < 0 Then
      MessageBox.Show("Nhập số lượng nhập không hợp lệ !")
      Return
    End If
    Dim kq As Boolean = sachbll.KiemTraMaSach(txtMaSach.Text)
    Dim f = 5
    If kq = True Then       ' mã sách có tồn tại trong kho sách
      Dim soluongtoncu As Integer = sachbll.LaySoLuongTonTheoMaSach(txtMaSach.Text)
      If soluongtoncu >= quydinhsoluongtontoidatruocnhap Then
        MessageBox.Show("Sách này tồn kho nhiều rồi , không nhập thêm được nữa !!!")
        Return
      End If
      Dim soluongnhap As Integer = Integer.Parse(txtSoLuongNhap.Text)
      If soluongnhap < quydinhsoluongnhapitnhat Then
        MessageBox.Show("Nhập quá ít , không cho nhập")
        Return
      End If
      Dim phieunhap As manhinhphieunhap = New manhinhphieunhap()
      phieunhap.txtMaPhieuNHap.Text = phieunhapbll.LayID()
      Dim str As String = ""
      Dim thang As Integer = 0
      If phieunhap.ShowDialog() = DialogResult.OK Then
        Dim maphieunhap As String = phieunhap.txtMaPhieuNHap.Text
        If maphieunhap = "" Then
          MessageBox.Show("Chưa nhập mã phiếu nhập kìa")
          Return
        End If
        str = maphieunhap
        Dim ngaynhap As DateTime = phieunhap.dtNgayNhap.Value
        thang = ngaynhap.Month
        Dim kt As Boolean = phieunhapbll.CapNhatThongTinVaoPhieuNhap(maphieunhap, ngaynhap)
        If kt = True Then
          MessageBox.Show("Cập nhật phiếu nhập thành công")
        ElseIf kt = False Then
          MessageBox.Show("Mã phiếu nhập đã tồn tại rồi")
          Return
        End If
      End If
      Dim x As Integer = 1
      While x = 1
        Dim masach As String = ""
        Dim soluongnhappp As Integer = 0
        Dim chitietphieunhap As ManHinhChiTietPhieuNhap = New ManHinhChiTietPhieuNhap()
        chitietphieunhap.txtMaChiTietPhieuNhap.Text = chitietphieunhapbll.LayId()
        chitietphieunhap.txtMaPhieuNhap.Text = str
        If txtMaSach.Text <> "" And txtMaSach.Text <> sachbll.LayId() Then
          chitietphieunhap.txtMaSach.Text = txtMaSach.Text
        End If
        If txtSoLuongNhap.Text <> "" Then
          chitietphieunhap.txtSoLuongNhap.Text = txtSoLuongNhap.Text
        End If
        If chitietphieunhap.ShowDialog() = DialogResult.OK Then
          If chitietphieunhap.txtMaSach.Text = sachbll.LayId() Then
            MessageBox.Show("Bổ sung thông tin cho đầu sách mới trước khi nhập sách !")
            Return
          End If
          Dim machitietphieunhap As String = chitietphieunhap.txtMaChiTietPhieuNhap.Text
          If machitietphieunhap = "" Then
            MessageBox.Show("Chưa nhập mã chi tiết phiếu nhập kìa")
            Return
          End If
          Dim maphieunhapp As String = chitietphieunhap.txtMaPhieuNhap.Text
          Dim masachh As String = chitietphieunhap.txtMaSach.Text
          masach = masachh
          Dim soluongnhapp As Integer = Integer.Parse(chitietphieunhap.txtSoLuongNhap.Text)
          soluongnhappp = soluongnhapp
          Dim ktt As Boolean = chitietphieunhapbll.CapNhatChiTietPhieuNhap(machitietphieunhap, maphieunhapp, masachh, soluongnhapp)
          If ktt = True Then
            MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công")
          ElseIf ktt = False Then
            MessageBox.Show("Mã chi tiết phiếu nhập đã tồn tại , vui lòng nhập lại")
            Dim a = 5
            Return
          End If
        End If
        Dim ton As BaoCaoTon = baocaotonbll.LayTonDauTheoMaSach(masach)
        Dim baocaoton As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
        baocaoton.txtMaChiTietTon.Text = baocaotonbll.LayID()
        baocaoton.txtMaSach.Text = masach
        baocaoton.txtThang.Text = thang.ToString()
        baocaoton.txtTonDau.Text = ton.TonCuoi.ToString()
        Dim tonphatsinhmoi As Integer = soluongnhappp
        baocaoton.txtTonPhatSinh.Text = tonphatsinhmoi.ToString()
        Dim toncuoimoi As Integer = ton.TonCuoi + soluongnhappp
        baocaoton.txtTonCuoi.Text = toncuoimoi.ToString()
        Dim d = 5
        If baocaoton.ShowDialog() = DialogResult.OK Then
          Dim machitietton As String = baocaoton.txtMaChiTietTon.Text
          If machitietton = "" Then
            MessageBox.Show("Chưa nhập mã chi tiết tồn")
            Return
          End If
          Dim thangg As Integer = Integer.Parse(baocaoton.txtThang.Text)
          Dim masah As String = baocaoton.txtMaSach.Text
          Dim tondauu As Integer = Integer.Parse(baocaoton.txtTonDau.Text)
          Dim tonphatsinh As Integer = Integer.Parse(baocaoton.txtTonPhatSinh.Text)
          Dim toncuoi As Integer = Integer.Parse(baocaoton.txtTonCuoi.Text)
          Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thangg, masah, tondauu, tonphatsinh, toncuoi)
          If kimtra Then
            MessageBox.Show("Cập nhật báo cáo tồn thành công")
          ElseIf kimtra = False Then
            MessageBox.Show("Mã chi tiết tồn đã tồn tại, vui lòng nhập lại")
            Return
          End If
        End If
        Dim soluongtonmoi As Integer = soluongtoncu + soluongnhappp
        Dim kiemtra As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masach, soluongtonmoi)
        If kiemtra = True Then
          MessageBox.Show("Thêm thành công")
          HienThiToanBoSachLenListView()
          btnLamMoi.PerformClick()
          txtTenSach.Focus()
        End If
        Dim ret As DialogResult = MessageBox.Show("Nhập sách nữa không !", "Hỏi nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ret = DialogResult.Yes Then
          x = 1
        Else
          x = 0
        End If
      End While

    ElseIf kq = False Then     'mã sách không tồn tại trong kho sách
      Dim soluongtoncu As Integer = sachbll.LaySoLuongTonTheoMaSach(txtMaSach.Text)
      Dim soluongnhap As Integer = Integer.Parse(txtSoLuongNhap.Text)
      If soluongnhap < quydinhsoluongnhapitnhat Then
        MessageBox.Show("Nhập quá ít , không cho nhập")
        Return
      End If
      Dim masach As String = txtMaSach.Text
      Dim tensach As String = txtTenSach.Text
      Dim theloai As String = txtTheLoai.Text
      Dim tacgia As String = txtTacGia.Text
      Dim soluongton As Integer = Integer.Parse(txtSoLuongNhap.Text)
      Dim dongia As Integer = Integer.Parse(txtDonGia.Text)
      Dim kiemtra As Boolean = sachbll.ThemSach(masach, tensach, theloai, tacgia, soluongton, dongia)
      If kiemtra = True Then
        MessageBox.Show("Thêm thành công")
        HienThiToanBoSachLenListView()
      End If
      Dim phieunhap As manhinhphieunhap = New manhinhphieunhap()
      phieunhap.txtMaPhieuNHap.Text = phieunhapbll.LayID()
      Dim str As String = ""
      Dim thang As Integer = 0
      If phieunhap.ShowDialog() = DialogResult.OK Then
        Dim maphieunhap As String = phieunhap.txtMaPhieuNHap.Text
        If maphieunhap = "" Then
          MessageBox.Show("Chưa nhập mã phiếu nhập kìa")
          Return
        End If
        str = maphieunhap
        Dim ngaynhap As DateTime = phieunhap.dtNgayNhap.Value
        thang = ngaynhap.Month
        Dim kt As Boolean = phieunhapbll.CapNhatThongTinVaoPhieuNhap(maphieunhap, ngaynhap)
        If kt = True Then
          MessageBox.Show("Cập nhật phiếu nhập thành công")
        ElseIf kt = False Then
          MessageBox.Show("Mã phiếu nhập đã tồn tại rồi")
          Return
        End If
      End If
      Dim x As Integer = 1
      While x = 1
        Dim masac As String = ""
        Dim soluongnhappp As Integer = 0
        Dim chitietphieunhap As ManHinhChiTietPhieuNhap = New ManHinhChiTietPhieuNhap()
        chitietphieunhap.txtMaChiTietPhieuNhap.Text = chitietphieunhapbll.LayId()
        chitietphieunhap.txtMaPhieuNhap.Text = str
        If txtMaSach.Text <> "" And txtMaSach.Text <> sachbll.LayId() Then
          chitietphieunhap.txtMaSach.Text = txtMaSach.Text
        End If
        If txtSoLuongNhap.Text <> "" Then
          chitietphieunhap.txtSoLuongNhap.Text = txtSoLuongNhap.Text
        End If
        If chitietphieunhap.ShowDialog() = DialogResult.OK Then
          If chitietphieunhap.txtMaSach.Text = sachbll.LayId() Then
            MessageBox.Show("Bổ sung thông tin cho đầu sách mới trước khi nhập sách !")
            Return
          End If
          Dim machitietphieunhap As String = chitietphieunhap.txtMaChiTietPhieuNhap.Text
          If machitietphieunhap = "" Then
            MessageBox.Show("Chưa nhập mã chi tiết phiếu nhập kìa")
            Return
          End If
          Dim maphieunhapp As String = chitietphieunhap.txtMaPhieuNhap.Text
          Dim masachh As String = chitietphieunhap.txtMaSach.Text
          masac = masachh
          Dim soluongnhapp As Integer = Integer.Parse(chitietphieunhap.txtSoLuongNhap.Text)
          soluongnhappp = soluongnhapp
          Dim ktt As Boolean = chitietphieunhapbll.CapNhatChiTietPhieuNhap(machitietphieunhap, maphieunhapp, masachh, soluongnhapp)
          If ktt = True Then
            MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công")
          ElseIf ktt = False Then
            MessageBox.Show("Mã chi tiết phiếu nhập đã tồn tại , vui lòng nhập lại")
            Dim a = 5
            Return
          End If
        End If
        Dim ton As BaoCaoTon = baocaotonbll.LayTonDauTheoMaSach(masac)
        Dim baocaoton As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
        BaoCaoTon.txtMaChiTietTon.Text = baocaotonbll.LayID()
        baocaoton.txtMaSach.Text = masac
        baocaoton.txtThang.Text = thang.ToString()
        BaoCaoTon.txtTonDau.Text = ton.TonCuoi.ToString()
        Dim tonphatsinhmoi As Integer = soluongnhappp
        baocaoton.txtTonPhatSinh.Text = tonphatsinhmoi.ToString()
        Dim toncuoimoi As Integer = ton.TonCuoi + soluongnhappp
        baocaoton.txtTonCuoi.Text = toncuoimoi.ToString()
        Dim d = 5
        If baocaoton.ShowDialog() = DialogResult.OK Then
          Dim machitietton As String = baocaoton.txtMaChiTietTon.Text
          If machitietton = "" Then
            MessageBox.Show("Chưa nhập mã chi tiết tồn")
            Return
          End If
          Dim thangg As Integer = Integer.Parse(baocaoton.txtThang.Text)
          Dim masah As String = baocaoton.txtMaSach.Text
          Dim tondauu As Integer = Integer.Parse(baocaoton.txtTonDau.Text)
          Dim tonphatsinh As Integer = Integer.Parse(baocaoton.txtTonPhatSinh.Text)
          Dim toncuoi As Integer = Integer.Parse(baocaoton.txtTonCuoi.Text)
          Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thangg, masah, tondauu, tonphatsinh, toncuoi)
          If kimtra Then
            MessageBox.Show("Cập nhật báo cáo tồn thành công")
          ElseIf kimtra = False Then
            MessageBox.Show("Mã chi tiết tồn đã tồn tại, vui lòng nhập lại")
            Return
          End If
        End If
        Dim soluongtonmoi As Integer = soluongtoncu + soluongnhappp
        Dim kiemtraa As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masac, soluongtonmoi)
        If kiemtraa = True Then
          MessageBox.Show("Thêm thành công")
          HienThiToanBoSachLenListView()
          btnLamMoi.PerformClick()
          txtTenSach.Focus()
        End If
        Dim ret As DialogResult = MessageBox.Show("Nhập sách nữa không !", "Hỏi nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ret = DialogResult.Yes Then
          x = 1
        Else
          x = 0
        End If
      End While
    End If
  End Sub

  Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
    If lvData.SelectedItems.Count = 0 Then
      MessageBox.Show("Chưa chọn sao sửa được thím")
      Return
    End If
    Dim lvi As ListViewItem = lvData.SelectedItems(0)
    Dim masach As String = lvi.Tag.ToString()
    Dim tensach As String = txtTenSach.Text
    Dim theloai As String = txtTheLoai.Text
    Dim tacgia As String = txtTacGia.Text
    Dim dongia As Integer = Integer.Parse(txtDonGia.Text)
    If dongia = 0 Or dongia < 0 Then
      MessageBox.Show("Đơn giá không hợp lệ !")
      Return
    End If
    Dim kq As Boolean = sachbll.SuaSach(masach, tensach, theloai, tacgia, dongia)
    If kq Then
      MessageBox.Show("Sửa sách thành công")
      HienThiToanBoSachLenListView()
      btnLamMoi.PerformClick()
      txtTenSach.Focus()
    End If
  End Sub

  Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
    If lvData.SelectedItems.Count = 0 Then
      MessageBox.Show("Chưa chọn sao xóa được thím")
      Return
    End If
    Dim ret As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    If ret = DialogResult.Yes Then
      Dim lvi As ListViewItem = lvData.SelectedItems(0)
      Dim masach As String = lvi.Tag.ToString()
      Dim kq As Boolean = sachbll.XoaSach(masach)
      If kq Then
        MessageBox.Show("Xóa sách thành công")
        HienThiToanBoSachLenListView()
        btnLamMoi.PerformClick()
        txtTenSach.Focus()
        Return
      End If
    End If
  End Sub

  Private Sub txtMaSach_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaSach.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSach.PerformClick()
    End If
  End Sub

  Private Sub txtTenSach_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTenSach.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSachTheoTen.PerformClick()
    End If
  End Sub

  Private Sub txtTheLoai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTheLoai.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSachTheoTheLoai.PerformClick()
    End If
  End Sub

  Private Sub txtTacGia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTacGia.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSachTheoTacGia.PerformClick()
    End If
  End Sub

  Private Sub txtSoLuongNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSoLuongNhap.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnThem.PerformClick()
    End If
  End Sub

  Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
    Dim manhinhin As ManHinhInAnSach = New ManHinhInAnSach()
    Me.Visible = False
    manhinhin.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnTimSach_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimSach.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSach_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimSach.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimSachTheoTen_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTen.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSachTheoTen_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTen.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimSachTheoTheLoai_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTheLoai.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSachTheoTheLoai_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTheLoai.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimSachTheoTacGia_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTacGia.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSachTheoTacGia_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTacGia.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnToanBo_MouseDown(sender As Object, e As MouseEventArgs) 
    btnToanBo.BackColor = Color.Lime
  End Sub

  Private Sub btnToanBo_MouseUp(sender As Object, e As MouseEventArgs) 
    btnToanBo.BackColor = Color.Gainsboro
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

  Private Sub btnIn_MouseDown(sender As Object, e As MouseEventArgs) 
    btnIn.BackColor = Color.Lime
  End Sub

  Private Sub btnIn_MouseUp(sender As Object, e As MouseEventArgs) 
    btnIn.BackColor = Color.Gainsboro
  End Sub

  Private Sub txtDonGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDonGia.KeyPress
    If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtSoLuongNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuongNhap.KeyPress
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

  Private Sub txtMaSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaSach.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtMaSach.Text = ""
      txtMaSach.Text = sachbll.LayId()
      txtTenSach.Focus()
    End If
  End Sub

  Private Sub txtTenSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTenSach.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtTenSach.Text = ""
    End If
  End Sub

  Private Sub txtTheLoai_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTheLoai.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtTheLoai.Text = ""
    End If
  End Sub

  Private Sub txtTacGia_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTacGia.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtTacGia.Text = ""
    End If
  End Sub
End Class