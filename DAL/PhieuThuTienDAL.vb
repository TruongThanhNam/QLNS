Imports DTO
Imports System.Data.OleDb
Public Class PhieuThuTienDAL
  Public Function KiemTraMaPhieuThu(ByVal maphieuthu As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from PhieuThuTien where MaPhieuThu=@maphieuthu"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@maphieuthu", OleDbType.BSTR).Value = maphieuthu
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function CapNhatPhieuThuTien(ByVal maphieuthu As String, ByVal sotienthu As Double, ByVal ngaythutien As DateTime, ByVal makhachhang As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into PhieuThuTien values(@maphieuthu,@sotienthu,@ngaythutien,@makhachhang)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@maphieuthu", OleDbType.BSTR).Value = maphieuthu
    command.Parameters.Add("@sotienthu", OleDbType.Double).Value = sotienthu
    command.Parameters.Add("@ngaythutien", OleDbType.Date).Value = ngaythutien
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function LayID() As String
    Dim phieuthutien As PhieuThuTien = New PhieuThuTien()
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from PhieuThuTien"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim max As Integer = 0
    While reader.Read()
      phieuthutien.MaPhieuThu = reader.GetString(0)
      If phieuthutien.MaPhieuThu <> "" Then
        Dim chisoo As String = phieuthutien.MaPhieuThu.Substring(4)
        Dim y As Integer = Integer.Parse(chisoo)
        If max < y Then
          max = y
        End If
      End If
    End While
    reader.Close()
    If phieuthutien.MaPhieuThu = "" Then
      Return "mptt1"
    End If
    max = max + 1
    Dim chiso As String = max.ToString()
    Return "mptt" + chiso
  End Function
End Class
