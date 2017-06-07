Imports DTO
Imports BLL
Public Class ManHinhThayDoiQuyDinh
  Dim thamsobll As ThamSoBLL = New ThamSoBLL()
  Private Sub ManHinhThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim ts As ThamSo = New ThamSo()
    ts = thamsobll.LayDuLieu()
    txtSoLuongNhatItNhat.Text = ts.SoLuongNhapItNhat.ToString()
    txtLuongTonToiDaTruocKhiNhap.Text = ts.SoLuongTonToiDaTruocNhap.ToString()
    txtTienNoToiDa.Text = ts.SoTienNoToiDa.ToString()
    txtLuongTonToiThieuSauKhiBan.Text = ts.SoLuongTonSauToiThieu.ToString()
    ckbSuDungTienNoToiDa.Checked = ts.SuDungQuyDinhSoTienNoToiDa
    ckbSoTienThuVuotSoTienNo.Checked = ts.SuDungQuyDinhSoTienThuVuotSoTienNo
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(44, 0, 0)
    btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(44, 0, 0)
  End Sub

  Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
    Dim ret As DialogResult = MessageBox.Show("Bạn có chắc muốn thay đổi quy định không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    If ret = DialogResult.Yes Then
      Dim soluongnhapitnhat As Integer = Integer.Parse(txtSoLuongNhatItNhat.Text)
      Dim soluongtontoidatruocnhap As Integer = Integer.Parse(txtLuongTonToiDaTruocKhiNhap.Text)
      Dim soluongtonsautoithieu As Integer = Integer.Parse(txtLuongTonToiThieuSauKhiBan.Text)
      Dim sotiennotoida As Double = Double.Parse(txtTienNoToiDa.Text)
      Dim sudungquydinhsotiennotoida As Boolean = ckbSuDungTienNoToiDa.Checked
      Dim sudungquydinhsotienthuvuotsotienno As Boolean = ckbSoTienThuVuotSoTienNo.Checked
      Dim kq As Boolean = thamsobll.CapNhatDuLieu(soluongnhapitnhat, soluongtontoidatruocnhap, soluongtonsautoithieu, sotiennotoida, sudungquydinhsotiennotoida, sudungquydinhsotienthuvuotsotienno)
      If kq = True Then
        MessageBox.Show("Cập nhật quy định thành công")
      End If
    End If
  End Sub

  Private Sub btnCapNhat_MouseDown(sender As Object, e As MouseEventArgs) 
    btnCapNhat.BackColor = Color.Lime
  End Sub

  Private Sub btnCapNhat_MouseUp(sender As Object, e As MouseEventArgs) 
    btnCapNhat.BackColor = Color.Gainsboro
  End Sub

  Private Sub txtSoLuongNhatItNhat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuongNhatItNhat.KeyPress
    If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtLuongTonToiDaTruocKhiNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLuongTonToiDaTruocKhiNhap.KeyPress
    If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtTienNoToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTienNoToiDa.KeyPress
    If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtLuongTonToiThieuSauKhiBan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLuongTonToiThieuSauKhiBan.KeyPress
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
End Class