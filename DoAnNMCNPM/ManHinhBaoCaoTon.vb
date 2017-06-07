Public Class ManHinhBaoCaoTon
  Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
    DialogResult = DialogResult.OK
  End Sub

  Private Sub txtMaChiTietTon_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaChiTietTon.KeyDown
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
End Class