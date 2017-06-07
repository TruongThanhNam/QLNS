Imports DTO
Imports System.Data.OleDb
Public Class ChiTietPhieuHoaDonDAL
  Public Function KiemTraMaChiTietPhieuHoaDon(ByVal machitietphieuhoadon As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from ChiTietPhieuHoaDon where MaChiTietPhieuHoaDon=@machitietphieuhoadon"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietphieuhoadon", OleDbType.BSTR).Value = machitietphieuhoadon
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function CapNhapChiTietPhieuHoaDon(ByVal machitietphieuhoadon As String, ByVal maphieuhoadon As String, ByVal masach As String, ByVal soluongban As Integer) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into ChiTietPhieuHoaDon values(@machitietphieuhoadon,@maphieuhoadon,@masach,@soluongban)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietphieuhoadon", OleDbType.BSTR).Value = machitietphieuhoadon
    command.Parameters.Add("@maphieuhoadon", OleDbType.BSTR).Value = maphieuhoadon
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    command.Parameters.Add("@soluongban", OleDbType.Integer).Value = soluongban
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function LayID() As String
    Dim chitietphieuhoadon As ChiTietPhieuHoaDon = New ChiTietPhieuHoaDon()
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from ChiTietPhieuHoaDon"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim max As Integer = 0
    While reader.Read()
      chitietphieuhoadon.MaChiTietPhieuHoaDon = reader.GetString(0)
      If chitietphieuhoadon.MaChiTietPhieuHoaDon <> "" Then
        Dim chisoo As String = chitietphieuhoadon.MaChiTietPhieuHoaDon.Substring(6)
        Dim y As Integer = Integer.Parse(chisoo)
        If max < y Then
          max = y
        End If
      End If
    End While
    reader.Close()
    If chitietphieuhoadon.MaChiTietPhieuHoaDon = "" Then
      Return "mctphd1"
    End If
    max = max + 1
    Dim chiso As String = max.ToString()
    Return "mctphd" + chiso
  End Function
End Class
