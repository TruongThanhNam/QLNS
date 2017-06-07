Public Class ManHinhChiTietPhieuNhap
  Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label4.Click

  End Sub

  Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
    DialogResult = DialogResult.OK
  End Sub

  Private Sub txtMaChiTietPhieuNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaChiTietPhieuNhap.KeyDown
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

  Private Sub txtSoLuongNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSoLuongNhap.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnCapNhat.PerformClick()
    End If
  End Sub
End Class