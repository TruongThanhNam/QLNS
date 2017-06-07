Imports DAL
Imports DTO
Public Class DangNhapBLL
  Dim dangnhap As DangNhapDAL = New DangNhapDAL()
  Public Function KiemTraTen(ByVal ten As String) As Boolean
    Return dangnhap.KiemTraTen(ten)
  End Function
  Public Function KiemTraMatKhau(ByVal matkhau As String) As Boolean
    Return dangnhap.KiemTraMatKhau(matkhau)
  End Function
  Public Function CapNhatTaiKhoan(ByVal ten As String, ByVal matkhau As String, ByVal nhomatkhau As Boolean) As Boolean
    If dangnhap.KiemTraTen(ten) = True Then
      Return False
    End If
    If dangnhap.KiemTraMatKhau(matkhau) Then
      Return False
    End If
    Return dangnhap.CapNhatTaiKhoan(ten, matkhau, nhomatkhau)
  End Function
  Public Function KiemTraNhoMatKhau(ByVal ten As String, ByVal nhomatkhau As Boolean) As Boolean
    Return dangnhap.KiemTraNhoMatKhau(ten, nhomatkhau)
  End Function
  Public Function LayCacTaiKhoanNhoMatKhau() As List(Of DangNhap)
    Return dangnhap.LayCacTaiKhoanNhoMatKhau()
  End Function
  Public Function KiemTraTenvaMatKhau(ByVal ten As String, ByVal matkhau As String) As Boolean
    Return dangnhap.KiemTraTenvaMatKhau(ten, matkhau)
  End Function
  Public Function LayMatKhauTheoTen(ByVal ten As String) As String
    Return dangnhap.LayMatKhauTheoTen(ten)
  End Function
  Public Function DoiMatKhau(ByVal ten As String, ByVal matkhaumoi As String) As Boolean
    Return dangnhap.DoiMatKhau(ten, matkhaumoi)
  End Function
End Class
