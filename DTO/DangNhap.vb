Public Class DangNhap
  Private _Ten As String
  Private _MatKhau As String
  Private _NhoMatKhau As Boolean
  Public Property Ten() As String
    Get
      Return _Ten
    End Get
    Set(value As String)
      _Ten = value
    End Set
  End Property
  Public Property MatKhau() As String
    Get
      Return _MatKhau
    End Get
    Set(value As String)
      _MatKhau = value
    End Set
  End Property
  Public Property NhoMatKhau() As Boolean
    Get
      Return _NhoMatKhau
    End Get
    Set(value As Boolean)
      _NhoMatKhau = value
    End Set
  End Property
  Public Sub New()
    _Ten = ""
    _MatKhau = ""
    _NhoMatKhau = False
  End Sub
  Public Sub New(ByVal ten As String, ByVal matkhau As String, ByVal nhomatkhau As Boolean)
    _Ten = ten
    _MatKhau = matkhau
    _NhoMatKhau = nhomatkhau
  End Sub
End Class
