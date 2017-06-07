Imports DTO
Imports BLL
Public Class ManHinhLapPhieuThuTien
  Dim khachhangbll As KhachHangBLL = New KhachHangBLL()
  Dim baocaocongnobll As BaoCaoCongNoBLL = New BaoCaoCongNoBLL()
  Dim phieuthutienbll As PhieuThuTienBLL = New PhieuThuTienBLL()
  Dim thamsobll As ThamSoBLL = New ThamSoBLL()
  Private Sub ManHinhLapPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiKhachHangLenListView()
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(152, 97, 255)
    btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(152, 97, 255)
  End Sub

  Private Sub HienThiKhachHangLenListView()
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    DSKH = khachhangbll.LayToanBoKhachHang()
    Dim itemkhachhang As KhachHang = New KhachHang()
    For Each itemkhachhang In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkhachhang.MaKhachHang)
      lvi.SubItems.Add(itemkhachhang.HoTenKhachHang)
      lvi.SubItems.Add(itemkhachhang.DiaChi)
      lvi.SubItems.Add(itemkhachhang.DienThoai)
      lvi.SubItems.Add(itemkhachhang.Email)
      lvi.SubItems.Add(itemkhachhang.SoTienNo)
      lvi.Tag = itemkhachhang.MaKhachHang
      lvi.ImageIndex = 1
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub lvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged
    If lvData.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvData.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag

    Dim kh As KhachHang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    txtMaKhachHang.Text = kh.MaKhachHang
    txtHoTenKhachHang.Text = kh.HoTenKhachHang
    txtDiaChi.Text = kh.DiaChi
    txtDienThoai.Text = kh.DienThoai
    txtEmail.Text = kh.Email
    txtSoTienNo.Text = kh.SoTienNo.ToString()
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTimKhachHangTheoMa.Click
    lvData.Items.Clear()
    Dim makhachhang As String = txtMaKhachHang.Text
    If makhachhang = "" Then
      MessageBox.Show("Chưa nhập mã khách hàng")
      Return
    End If
    Dim khachhang As KhachHang = New KhachHang()
    khachhang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    Dim lvi As ListViewItem = New ListViewItem(khachhang.MaKhachHang)
    lvi.SubItems.Add(khachhang.HoTenKhachHang)
    lvi.SubItems.Add(khachhang.DiaChi)
    lvi.SubItems.Add(khachhang.DienThoai)
    lvi.SubItems.Add(khachhang.Email)
    lvi.SubItems.Add(khachhang.SoTienNo)
    lvi.Tag = khachhang.MaKhachHang
    lvi.ImageIndex = 1
    lvData.Items.Add(lvi)
    LamMoi()
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTimKhachHangTheoTen.Click
    lvData.Items.Clear()
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
      lvi.Tag = itemkh.MaKhachHang
      lvi.ImageIndex = 1
      lvData.Items.Add(lvi)
      LamMoi()
    Next
  End Sub

  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnTimKhachHangTheoDiaChi.Click
    lvData.Items.Clear()
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
      lvi.Tag = itemkh.MaKhachHang
      lvi.ImageIndex = 1
      lvData.Items.Add(lvi)
      LamMoi()
    Next
  End Sub

  Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnTimKhachHangTheoDienThoai.Click
    lvData.Items.Clear()
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
      lvi.Tag = itemkh.MaKhachHang
      lvi.ImageIndex = 1
      lvData.Items.Add(lvi)
      LamMoi()
    Next
  End Sub

  Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnTimKhachHangTheoEmail.Click
    lvData.Items.Clear()
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
      lvi.Tag = itemkh.MaKhachHang
      lvi.ImageIndex = 1
      lvData.Items.Add(lvi)
      LamMoi()
    Next
  End Sub

  Private Sub btnHienThiToanBoKhachHang_Click(sender As Object, e As EventArgs) Handles btnHienThiToanBoKhachHang.Click
    lvData.Items.Clear()
    HienThiKhachHangLenListView()
    LamMoi()
  End Sub
  Sub LamMoi()
    txtMaKhachHang.Text = ""
    txtHoTenKhachHang.Text = ""
    txtDiaChi.Text = ""
    txtDienThoai.Text = ""
    txtEmail.Text = ""
    txtSoTienNo.Text = ""
    txtSoTienThu.Text = ""
  End Sub

  Private Sub btnThuTien_Click(sender As Object, e As EventArgs) Handles btnThuTien.Click
    If txtMaKhachHang.Text = "" Then
      MessageBox.Show("Chưa chọn khách hàng mà")
      Return
    End If
    If txtSoTienThu.Text = "" Then
      MessageBox.Show("Chưa nhập số tiền thu")
      Return
    End If
    Dim sotienthu As Double = Double.Parse(txtSoTienThu.Text)
    If sotienthu < 0 Or sotienthu = 0 Then
      MessageBox.Show("Số tiền thu không hợp lệ")
      Return
    End If
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim sotienno As Double = khachhangbll.LaySoTienNoTheoMaKhachHang(makhachhang)
    Dim thamso As ThamSo = thamsobll.LayDuLieu()
    If thamso.SuDungQuyDinhSoTienThuVuotSoTienNo = False Then
      Dim baocaoo As BaoCaoCongNo = New BaoCaoCongNo()
      baocaoo = baocaocongnobll.LayDuLieuTheoMaKhachHang(makhachhang)
      Dim nodauu As Double
      Dim nocuoii As Double
      Dim nophatsinhh As Double = 0
      nodauu = sotienno
      nocuoii = nodauu - sotienthu
      nophatsinhh = nophatsinhh - sotienthu
      Dim baocaocongnoo As ManHinhBaoCaoCongNo = New ManHinhBaoCaoCongNo()
      baocaocongnoo.txtMaChiTietCongNo.Text = baocaocongnobll.LayID()
      baocaocongnoo.txtThang.Text = dtNgayThuTien.Value.Month
      baocaocongnoo.txtMaKhachHang.Text = makhachhang
      baocaocongnoo.txtNoDau.Text = nodauu.ToString()
      baocaocongnoo.txtNoCuoi.Text = nocuoii.ToString()
      baocaocongnoo.txtNoPhatSinh.Text = nophatsinhh.ToString()
      If baocaocongnoo.ShowDialog() = DialogResult.OK Then
        Dim machitietcongno As String = baocaocongnoo.txtMaChiTietCongNo.Text
        Dim thang As Integer = Integer.Parse(baocaocongnoo.txtThang.Text)
        Dim makhachhangg As String = baocaocongnoo.txtMaKhachHang.Text
        Dim nodauuu As Double = Double.Parse(baocaocongnoo.txtNoDau.Text)
        Dim nocuoiii As Double = Double.Parse(baocaocongnoo.txtNoCuoi.Text)
        Dim nophatsinhhh As Double = Double.Parse(baocaocongnoo.txtNoPhatSinh.Text)
        Dim kt As Boolean = baocaocongnobll.CapNhatDuLieu(machitietcongno, thang, makhachhangg, nodauuu, nocuoiii, nophatsinhhh)
        If kt = True Then
          MessageBox.Show("Cập nhật báo cáo công nợ thành công")
        ElseIf kt = False Then
          MessageBox.Show("Mã chi tiết công nợ này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
      Dim phieuthutienn As ManHinhPhieuThuTien = New ManHinhPhieuThuTien()
      phieuthutienn.txtMaPhieuThu.Text = phieuthutienbll.LayID()
      phieuthutienn.txtSoTienThu.Text = txtSoTienThu.Text
      phieuthutienn.dtNgayThuTien.Value = dtNgayThuTien.Value
      phieuthutienn.txtMaKhachHang.Text = txtMaKhachHang.Text
      If phieuthutienn.ShowDialog() = DialogResult.OK Then
        Dim machitietphieuthu As String = phieuthutienn.txtMaPhieuThu.Text
        Dim sotienthuuu As Double = Double.Parse(phieuthutienn.txtSoTienThu.Text)
        Dim ngaythutienn As DateTime = phieuthutienn.dtNgayThuTien.Value
        Dim makhach As String = phieuthutienn.txtMaKhachHang.Text
        Dim kiemtra As Boolean = phieuthutienbll.CapNhatPhieuThuTien(machitietphieuthu, sotienthuuu, ngaythutienn, makhach)
        If kiemtra = True Then
          MessageBox.Show("Cập nhật phiếu thu tiền thành công")
        ElseIf kiemtra = False Then
          MessageBox.Show("Mã chi tiết phiếu thu này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
      Dim sotiennomoii As Double = sotienno - sotienthu
      Dim kqq As Boolean = khachhangbll.CapNhatTienNoMoiTheoMaKhachHang(makhachhang, sotiennomoii)
      If kqq = True Then
        MessageBox.Show("Thu tiền thành công")
        lvData.Items.Clear()
        HienThiKhachHangLenListView()
        LamMoi()
        Return
      End If
    End If
    If sotienthu > sotienno Then
      MessageBox.Show("Số tiền thu lớn hơn số tiền khách hàng nợ rồi!!!")
      Return
    End If
    Dim baocao As BaoCaoCongNo = New BaoCaoCongNo()
    baocao = baocaocongnobll.LayDuLieuTheoMaKhachHang(makhachhang)
    Dim nodau As Double
    Dim nocuoi As Double
    Dim nophatsinh As Double = 0
    'If baocao.NoDau = sotienno Then
    '  nodau = baocao.NoDau
    '  nocuoi = sotienno
    '  nophatsinh = 0
    '  Dim baocaocongnoo As ManHinhBaoCaoCongNo = New ManHinhBaoCaoCongNo()
    '  baocaocongnoo.txtThang.Text = dtNgayThuTien.Value.Month
    '  baocaocongnoo.txtMaKhachHang.Text = makhachhang
    '  baocaocongnoo.txtNoDau.Text = nodau.ToString()
    '  baocaocongnoo.txtNoCuoi.Text = nocuoi.ToString()
    '  baocaocongnoo.txtNoPhatSinh.Text = nophatsinh.ToString()
    '  If baocaocongnoo.ShowDialog() = DialogResult.OK Then
    '    Dim machitietcongno As String = baocaocongnoo.txtMaChiTietCongNo.Text
    '    Dim thang As Integer = Integer.Parse(baocaocongnoo.txtThang.Text)
    '    Dim makhachhangg As String = baocaocongnoo.txtMaKhachHang.Text
    '    Dim nodauu As Double = Double.Parse(baocaocongnoo.txtNoDau.Text)
    '    Dim nocuoii As Double = Double.Parse(baocaocongnoo.txtNoCuoi.Text)
    '    Dim nophatsinhh As Double = Double.Parse(baocaocongnoo.txtNoPhatSinh.Text)
    '    Dim kt As Boolean = baocaocongnobll.CapNhatDuLieu(machitietcongno, thang, makhachhangg, nodauu, nocuoii, nophatsinhh)
    '    If kt = True Then
    '      MessageBox.Show("Cập nhật báo cáo công nợ thành công")
    '    ElseIf kt = False Then
    '      MessageBox.Show("Mã chi tiết công nợ này đã tồn tại rồi,vui lòng nhập lại")
    '      Return
    '    End If
    '  End If
    'End If
    nodau = sotienno
    nocuoi = nodau - sotienthu
    nophatsinh = nophatsinh - sotienthu
    Dim baocaocongno As ManHinhBaoCaoCongNo = New ManHinhBaoCaoCongNo()
    baocaocongno.txtMaChiTietCongNo.Text = baocaocongnobll.LayID()
    baocaocongno.txtThang.Text = dtNgayThuTien.Value.Month
    baocaocongno.txtMaKhachHang.Text = makhachhang
    baocaocongno.txtNoDau.Text = nodau.ToString()
    baocaocongno.txtNoCuoi.Text = nocuoi.ToString()
    baocaocongno.txtNoPhatSinh.Text = nophatsinh.ToString()
    If baocaocongno.ShowDialog() = DialogResult.OK Then
      Dim machitietcongno As String = baocaocongno.txtMaChiTietCongNo.Text
      Dim thang As Integer = Integer.Parse(baocaocongno.txtThang.Text)
      Dim makhachhangg As String = baocaocongno.txtMaKhachHang.Text
      Dim nodauu As Double = Double.Parse(baocaocongno.txtNoDau.Text)
      Dim nocuoii As Double = Double.Parse(baocaocongno.txtNoCuoi.Text)
      Dim nophatsinhh As Double = Double.Parse(baocaocongno.txtNoPhatSinh.Text)
      Dim kt As Boolean = baocaocongnobll.CapNhatDuLieu(machitietcongno, thang, makhachhangg, nodauu, nocuoii, nophatsinhh)
      If kt = True Then
        MessageBox.Show("Cập nhật báo cáo công nợ thành công")
      ElseIf kt = False Then
        MessageBox.Show("Mã chi tiết công nợ này đã tồn tại rồi,vui lòng nhập lại")
        Return
      End If
    End If
    Dim phieuthutien As ManHinhPhieuThuTien = New ManHinhPhieuThuTien()
    phieuthutien.txtMaPhieuThu.Text = phieuthutienbll.LayID()
    phieuthutien.txtSoTienThu.Text = txtSoTienThu.Text
    phieuthutien.dtNgayThuTien.Value = dtNgayThuTien.Value
    phieuthutien.txtMaKhachHang.Text = txtMaKhachHang.Text
    If phieuthutien.ShowDialog() = DialogResult.OK Then
      Dim machitietphieuthu As String = phieuthutien.txtMaPhieuThu.Text
      Dim sotienthuuu As Double = Double.Parse(phieuthutien.txtSoTienThu.Text)
      Dim ngaythutienn As DateTime = phieuthutien.dtNgayThuTien.Value
      Dim makhach As String = phieuthutien.txtMaKhachHang.Text
      Dim kiemtra As Boolean = phieuthutienbll.CapNhatPhieuThuTien(machitietphieuthu, sotienthuuu, ngaythutienn, makhach)
      If kiemtra = True Then
        MessageBox.Show("Cập nhật phiếu thu tiền thành công")
      ElseIf kiemtra = False Then
        MessageBox.Show("Mã chi tiết phiếu thu này đã tồn tại rồi,vui lòng nhập lại")
        Return
      End If
    End If
    Dim sotiennomoi As Double = sotienno - sotienthu
    Dim kq As Boolean = khachhangbll.CapNhatTienNoMoiTheoMaKhachHang(makhachhang, sotiennomoi)
    If kq = True Then
      MessageBox.Show("Thu tiền thành công")
      lvData.Items.Clear()
      HienThiKhachHangLenListView()
      LamMoi()
    End If
  End Sub

  Private Sub txtMaKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaKhachHang.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachHangTheoMa.PerformClick()
    End If
  End Sub

  Private Sub txtHoTenKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHoTenKhachHang.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachHangTheoTen.PerformClick()
    End If
  End Sub

  Private Sub txtDiaChi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiaChi.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachHangTheoDiaChi.PerformClick()
    End If
  End Sub

  Private Sub txtDienThoai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDienThoai.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachHangTheoDienThoai.PerformClick()
    End If
  End Sub

  Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimKhachHangTheoEmail.PerformClick()
    End If
  End Sub

  Private Sub txtSoTienThu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSoTienThu.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnThuTien.PerformClick()
    End If
  End Sub

  Private Sub btnTimKhachHangTheoMa_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoMa.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachHangTheoMa_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoMa.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimKhachHangTheoTen_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoTen.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachHangTheoTen_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoTen.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimKhachHangTheoDiaChi_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoDiaChi.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachHangTheoDiaChi_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoDiaChi.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimKhachHangTheoDienThoai_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoDienThoai.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachHangTheoDienThoai_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoDienThoai.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimKhachHangTheoEmail_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoEmail.BackColor = Color.Lime
  End Sub

  Private Sub btnTimKhachHangTheoEmail_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimKhachHangTheoEmail.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnHienThiToanBoKhachHang_MouseDown(sender As Object, e As MouseEventArgs) 
    btnHienThiToanBoKhachHang.BackColor = Color.Lime
  End Sub

  Private Sub btnHienThiToanBoKhachHang_MouseUp(sender As Object, e As MouseEventArgs) 
    btnHienThiToanBoKhachHang.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnThuTien_MouseDown(sender As Object, e As MouseEventArgs) 
    btnThuTien.BackColor = Color.Lime
  End Sub

  Private Sub btnThuTien_MouseUp(sender As Object, e As MouseEventArgs) 
    btnThuTien.BackColor = Color.Gainsboro
  End Sub

  Private Sub txtSoTienThu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoTienThu.KeyPress
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
End Class