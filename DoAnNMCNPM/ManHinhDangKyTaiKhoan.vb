Public Class ManHinhDangKyTaiKhoan
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    DialogResult = DialogResult.OK
  End Sub

  Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) 
    Button1.BackColor = Color.Lime
  End Sub

  Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs)
    Button1.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
    Close()
  End Sub

  Private Sub ManHinhDangKyTaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
  End Sub
End Class