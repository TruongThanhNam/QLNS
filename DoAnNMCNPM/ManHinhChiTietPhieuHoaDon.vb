Public Class ManHinhChiTietPhieuHoaDon
  Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
    DialogResult = DialogResult.OK
  End Sub

  Private Sub txtMaChiTietPhieuHoaDon_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaChiTietPhieuHoaDon.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnCapNhat.PerformClick()
    End If
  End Sub

  Private Sub btnCapNhat_MouseDown(sender As Object, e As MouseEventArgs)
    btnCapNhat.BackColor = Color.Lime
  End Sub

  Private Sub btnCapNhat_MouseUp(sender As Object, e As MouseEventArgs)
    btnCapNhat.BackColor = Color.Gainsboro
  End Sub

  Private Sub txtMaKhachHang_KeyDown(sender As Object, e As KeyEventArgs)

  End Sub

  Private Sub txtSoLuongBan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSoLuongBan.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnCapNhat.PerformClick()
    End If
  End Sub
End Class