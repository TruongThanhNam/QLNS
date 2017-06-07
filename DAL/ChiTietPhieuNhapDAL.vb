Imports DTO
Imports System.Data.OleDb
Public Class ChiTietPhieuNhapDAL
  Public Function CapNhatChiTietPhieuNhap(ByVal machitietphieunhap As String, ByVal maphieunhap As String, ByVal masach As String, ByVal soluongnhap As Integer) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into ChiTietPhieuNhap values(@machitietphieunhap,@maphieunhap,@masach,@soluongnhap)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietphieunhap", OleDbType.BSTR).Value = machitietphieunhap
    command.Parameters.Add("@maphieunhap", OleDbType.BSTR).Value = maphieunhap
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    command.Parameters.Add("@soluongnhap", OleDbType.Integer).Value = soluongnhap
    Dim kq As Integer = command.ExecuteNonQuery()

    Return kq > 0
  End Function
  Public Function KiemTraMaChiTietPhieuNhap(ByVal machitietphieunhap As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from ChiTietPhieuNhap where MaChiTietPhieuNhap=@machitietphieunhap"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietphieunhap", OleDbType.BSTR).Value = machitietphieunhap
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function LayId() As String
    Dim chitietphieunhap As ChiTietPhieuNhap = New ChiTietPhieuNhap()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from ChiTietPhieuNhap"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim max As Integer = 0
    While reader.Read()
      chitietphieunhap.MaChiTietPhieuNhap = reader.GetString(0)
      If chitietphieunhap.MaChiTietPhieuNhap <> "" Then
        Dim chisoo As String = chitietphieunhap.MaChiTietPhieuNhap.Substring(5)
        Dim y As Integer = Integer.Parse(chisoo)
        If max < y Then
          max = y
        End If
      End If
    End While
    reader.Close()
    If chitietphieunhap.MaChiTietPhieuNhap = "" Then
      Return "mctpn1"
    End If
    max = max + 1
    Dim chiso As String = max.ToString()
    Return "mctpn" + chiso
  End Function
End Class
