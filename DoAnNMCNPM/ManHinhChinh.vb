Public Class ManHinhChinh
  Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
    Close()
  End Sub

  Private Sub btnThayDoiQuyDinh_Click(sender As Object, e As EventArgs) Handles btnThayDoiQuyDinh.Click
    Dim frm5 As ManHinhThayDoiQuyDinh = New ManHinhThayDoiQuyDinh()
    Me.Visible = False
    frm5.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnLapPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btnLapPhieuThuTien.Click
    Dim frm2 As ManHinhLapPhieuThuTien = New ManHinhLapPhieuThuTien()
    Me.Visible = False
    frm2.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnLapBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btnLapBaoCaoTon.Click
    Dim frm3 As ManHinhLapBaoCaoTon = New ManHinhLapBaoCaoTon()
    Me.Visible = False
    frm3.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnLapBaoCaoCongNo_Click(sender As Object, e As EventArgs) Handles btnLapBaoCaoCongNo.Click
    Dim frm4 As ManHinhLapBaoCaoCongNo = New ManHinhLapBaoCaoCongNo()
    Me.Visible = False
    frm4.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnLapPhieuNhapSach_Click(sender As Object, e As EventArgs) Handles btnLapPhieuNhapSach.Click
    Dim frm As ManHinhLapPhieuNhapSach = New ManHinhLapPhieuNhapSach()
    Me.Visible = False
    frm.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnTraCuuSach_Click(sender As Object, e As EventArgs) Handles btnTraCuuSach.Click
    Dim frm6 As ManHinhTraCuuSach = New ManHinhTraCuuSach()
    Me.Visible = False
    frm6.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnLapHoaDonBanSach_Click(sender As Object, e As EventArgs) Handles btnLapHoaDonBanSach.Click
    Dim frm1 As ManHinhLapHoaDonBanSach = New ManHinhLapHoaDonBanSach()
    Me.Visible = False
    frm1.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnThoatt_Click(sender As Object, e As EventArgs) Handles btnThoatt.Click
    Close()
  End Sub

  Private Sub btnMinimizee_Click(sender As Object, e As EventArgs)
    Me.WindowState = FormWindowState.Minimized
  End Sub

  Private Sub ManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    btnThoatt.FlatAppearance.BorderColor = Color.FromArgb(226, 0, 0)

  End Sub
End Class