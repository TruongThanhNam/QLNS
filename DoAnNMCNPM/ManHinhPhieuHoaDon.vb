﻿Public Class ManHinhPhieuHoaDon
  Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
    DialogResult = DialogResult.OK
  End Sub

  Private Sub txtMaPhieuHoaDon_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaPhieuHoaDon.KeyDown
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