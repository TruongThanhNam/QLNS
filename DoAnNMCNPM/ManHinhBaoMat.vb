Public Class ManHinhBaoMat
  Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
    DialogResult = DialogResult.OK
  End Sub

  Private Sub btnCapNhat_MouseDown(sender As Object, e As MouseEventArgs)
    btnCapNhat.BackColor = Color.Lime
  End Sub

  Private Sub btnCapNhat_MouseUp(sender As Object, e As MouseEventArgs)
    btnCapNhat.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
    Close()
  End Sub

  Private Sub ManHinhBaoMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
  End Sub
End Class