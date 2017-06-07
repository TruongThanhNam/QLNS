Imports DTO
Imports System.Data.OleDb
Public Class PhieuNhapDAL

  Public Function CapNhatThongTinVaoPhieuNhap(ByVal maphieunhap As String, ByVal ngaynhap As DateTime) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into PhieuNhap values(@maphieunhap,@ngaynhap)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@maphieunhap", OleDbType.BSTR).Value = maphieunhap
    command.Parameters.Add("@ngaynhap", OleDbType.Date).Value = ngaynhap
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function KiemTraMaPhieuNhap(ByVal maphieunhap As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from PhieuNhap where MaPhieuNhap=@maphieunhap"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@maphieunhap", OleDbType.BSTR).Value = maphieunhap
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read
    reader.Close()
    Return kq
  End Function
  Public Function LayID() As String
    Dim phieunhap As PhieuNhap = New PhieuNhap()
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from PhieuNhap"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim max As Integer = 0
    While reader.Read()
      phieunhap.MaPhieuNhap = reader.GetString(0)
      If phieunhap.MaPhieuNhap <> "" Then
        Dim chisoo As String = phieunhap.MaPhieuNhap.Substring(3)
        Dim y As Integer = Integer.Parse(chisoo)
        If max < y Then
          max = y
        End If
      End If
    End While
    reader.Close()
    If phieunhap.MaPhieuNhap = "" Then
      phieunhap.MaPhieuNhap = "mpn1"
      Return phieunhap.MaPhieuNhap
    End If
    max = max + 1
    Dim chiso As String = max.ToString()
    Return "mpn" + chiso
  End Function
End Class
