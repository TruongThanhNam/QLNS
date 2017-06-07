Imports DTO
Imports BLL
Public Class ManHinhDangNhap
  Dim dangnhapbll As DangNhapBLL = New DangNhapBLL()
  Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
    Dim manhinhdangky As ManHinhDangKyTaiKhoan = New ManHinhDangKyTaiKhoan()
    Me.Visible = False
    If manhinhdangky.ShowDialog() = DialogResult.OK Then
      Dim ten As String = manhinhdangky.txtTen.Text
      Dim matkhau As String = manhinhdangky.txtMatKhau.Text
      If ten = "" Then
        MessageBox.Show("Chưa đăng ký tên !")
        Me.Visible = True
        Return
      End If
      If matkhau = "" Then
        MessageBox.Show("Chưa đăng ký mật khẩu")
        Me.Visible = True
        Return
      End If
      Dim kq As Boolean = dangnhapbll.CapNhatTaiKhoan(ten, matkhau, False)
      If kq = False Then
        MessageBox.Show("Tên tài khoản hoặc mật khẩu đã tồn tại , vui lòng kiểm tra lại")
        Me.Visible = True
        Return
      End If
      MessageBox.Show("Đăng ký tài khoản thành công")
      Me.Visible = True
    End If
    Me.Visible = True
  End Sub

  Private Sub ManHinhDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(0, 20, 1)
    btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(0, 20, 1)
    Dim DSTK As List(Of DangNhap) = dangnhapbll.LayCacTaiKhoanNhoMatKhau()
    Dim taikhoan As DangNhap = New DangNhap()
    For Each taikhoan In DSTK
      cboTen.Items.Add(taikhoan.Ten)
    Next
  End Sub

  Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
    If cboTen.Text = "" Then
      MessageBox.Show("Chưa nhập tên")
      Return
    End If
    If txtMatKhau.Text = "" Then
      MessageBox.Show("Chưa nhập mật khẩu")
      Return
    End If
    Dim capnhat As Boolean = dangnhapbll.KiemTraNhoMatKhau(cboTen.Text, ckNhoMatKhau.Checked)
    Dim kiemtra As Boolean = dangnhapbll.KiemTraTenvaMatKhau(cboTen.Text, txtMatKhau.Text)
    If kiemtra = False Then
      MessageBox.Show("Tên hoặc mật khẩu không hợp lệ")
      Return
    End If
    If cboTen.Text = "Giám Đốc Trương Thanh Nam" Then
      Dim manhinhchinh As ManHinhChinh = New ManHinhChinh()
      Me.Visible = False
      manhinhchinh.btnLapPhieuNhapSach.Visible = False
      manhinhchinh.btnLapHoaDonBanSach.Visible = False
      manhinhchinh.btnLapPhieuThuTien.Visible = False
      manhinhchinh.btnLapBaoCaoTon.Visible = False
      manhinhchinh.btnLapBaoCaoCongNo.Visible = False
      manhinhchinh.ShowDialog()
      Me.Visible = True
      Return
    End If
    If cboTen.Text = "Khách Hàng" Then
      Dim manhinhchinh As ManHinhChinh = New ManHinhChinh()
      Me.Visible = False
      manhinhchinh.btnLapPhieuNhapSach.Visible = False
      manhinhchinh.btnLapHoaDonBanSach.Visible = False
      manhinhchinh.btnLapPhieuThuTien.Visible = False
      manhinhchinh.btnLapBaoCaoTon.Visible = False
      manhinhchinh.btnLapBaoCaoCongNo.Visible = False
      manhinhchinh.btnThayDoiQuyDinh.Visible = False
      manhinhchinh.ShowDialog()
      Me.Visible = True
      Return
    End If
    Dim manhinhchinhh As ManHinhChinh = New ManHinhChinh()
    Me.Visible = False
    manhinhchinhh.btnThayDoiQuyDinh.Visible = False
    manhinhchinhh.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub cboTen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTen.SelectedIndexChanged
    If cboTen.SelectedIndex = -1 Then
      Return
    End If
    Dim ten As String = cboTen.Text
    Dim matkhau As String = dangnhapbll.LayMatKhauTheoTen(ten)
    txtMatKhau.Text = matkhau
    ckNhoMatKhau.Checked = True
  End Sub

  Private Sub btnDoiMatKhau_Click(sender As Object, e As EventArgs) Handles btnDoiMatKhau.Click
    Dim manhinhbaomat As ManHinhBaoMat = New ManHinhBaoMat()
    Me.Visible = False
    If manhinhbaomat.ShowDialog() = DialogResult.OK Then
      If manhinhbaomat.txtTen.Text = "" Then
        MessageBox.Show("Chưa nhập tên !")
        Me.Visible = True
        Return
      End If
      If manhinhbaomat.txtMatKhauCu.Text = "" Then
        MessageBox.Show("Chưa nhập mật khẩu cũ !")
        Me.Visible = True
        Return
      End If
      If manhinhbaomat.txtMauKhauMoi.Text = "" Then
        MessageBox.Show("Chưa nhập mật khẩu mới !")
        Me.Visible = True
        Return
      End If
      If manhinhbaomat.txtNhapLaiMatKhau.Text = "" Then
        MessageBox.Show("Chưa nhập lại mật khẩu mới !")
        Me.Visible = True
        Return
      End If
      Dim kiemtratenvamatkhau As Boolean = dangnhapbll.KiemTraTenvaMatKhau(manhinhbaomat.txtTen.Text, manhinhbaomat.txtMatKhauCu.Text)
      If kiemtratenvamatkhau = False Then
        MessageBox.Show("Tên hoặc mật khẩu cũ sai,vui lòng kiểm tra lại")
        Me.Visible = True
        Return
      End If
      If manhinhbaomat.txtMauKhauMoi.Text = manhinhbaomat.txtNhapLaiMatKhau.Text Then
        Dim ketqua As Boolean = dangnhapbll.DoiMatKhau(manhinhbaomat.txtTen.Text, manhinhbaomat.txtMauKhauMoi.Text)
        If ketqua = True Then
          MessageBox.Show("Cập nhật mật khẩu mới thành công")
          Me.Visible = True
          Return
        End If
      End If
    End If
    Me.Visible = True
  End Sub

  Private Sub btnDangNhap_MouseDown(sender As Object, e As MouseEventArgs)
    btnDangNhap.BackColor = Color.Lime
  End Sub

  Private Sub btnDangNhap_MouseUp(sender As Object, e As MouseEventArgs)
    btnDangNhap.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnDangKy_MouseDown(sender As Object, e As MouseEventArgs)
    btnDangKy.BackColor = Color.Lime
  End Sub

  Private Sub btnDangKy_MouseUp(sender As Object, e As MouseEventArgs)
    btnDangKy.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnDoiMatKhau_MouseDown(sender As Object, e As MouseEventArgs)
    btnDoiMatKhau.BackColor = Color.Lime
  End Sub

  Private Sub btnDoiMatKhau_MouseUp(sender As Object, e As MouseEventArgs)
    btnDoiMatKhau.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
    Close()
  End Sub

  Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
    Me.WindowState = FormWindowState.Minimized
  End Sub
End Class