Imports DTO
Imports System.Data.OleDb
Imports System.Data
Public Class BaoCaoCongNoDAL
  Public Function KiemTraMaChiTietCongNo(ByVal machitietcongno As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from BaoCaoCongNo where MaChiTietCongNo=@machitietcongno"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietcongno", OleDbType.BSTR).Value = machitietcongno
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function LayDuLieuTheoMaKhachHang(ByVal makhachhang As String) As BaoCaoCongNo
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from BaoCaoCongNo where MaKhachHang=@makhachhang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim bccn As BaoCaoCongNo = New BaoCaoCongNo()
    While reader.Read()
      bccn.MaChiTietCongNo = reader.GetString(0)
      bccn.Thang = reader.GetInt32(1)
      bccn.MaKhachHang = reader.GetString(2)
      bccn.NoDau = reader.GetInt32(3)
      bccn.NoCuoi = reader.GetInt32(4)
      bccn.NoPhatSinh = reader.GetInt32(5)
    End While
    reader.Close()
    Return bccn
  End Function
  Public Function CapNhatDuLieu(ByVal machitietcongno As String, ByVal thang As Integer, ByVal makhachhang As String, ByVal nodau As Double, ByVal nocuoi As Double, ByVal nophatsinh As Double) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into BaoCaoCongNo values(@machitietcongno,@thang,@makhachhang,@nodau,@nocuoi,@nophatsinh)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietcongno", OleDbType.BSTR).Value = machitietcongno
    command.Parameters.Add("@thang", OleDbType.Integer).Value = thang
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    command.Parameters.Add("@nodau", OleDbType.Double).Value = nodau
    command.Parameters.Add("@nocuoi", OleDbType.Double).Value = nocuoi
    command.Parameters.Add("@nophatsinh", OleDbType.Double).Value = nophatsinh
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function LayToanBoDuLieu() As List(Of BaoCaoCongNo)
    Dim DSBC As List(Of BaoCaoCongNo) = New List(Of BaoCaoCongNo)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "Select * from BaoCaoCongNo"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      Dim baocao As BaoCaoCongNo = New BaoCaoCongNo()
      baocao.MaChiTietCongNo = reader.GetString(0)
      baocao.Thang = reader.GetInt32(1)
      baocao.MaKhachHang = reader.GetString(2)
      baocao.NoDau = reader.GetInt32(3)
      baocao.NoCuoi = reader.GetInt32(4)
      baocao.NoPhatSinh = reader.GetInt32(5)
      DSBC.Add(baocao)
    End While
    reader.Close()
    Return DSBC
  End Function
  Public Function LayTheoThang(ByVal thang As Integer) As List(Of BaoCaoCongNo)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from BaoCaoCongNo where Thang=@thang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@thang", OleDbType.Integer).Value = thang
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim DS As List(Of BaoCaoCongNo) = New List(Of BaoCaoCongNo)
    While reader.Read()
      Dim baocao As BaoCaoCongNo = New BaoCaoCongNo()
      baocao.MaChiTietCongNo = reader.GetString(0)
      baocao.Thang = reader.GetInt32(1)
      baocao.MaKhachHang = reader.GetString(2)
      baocao.NoDau = reader.GetInt32(3)
      baocao.NoCuoi = reader.GetInt32(4)
      baocao.NoPhatSinh = reader.GetInt32(5)
      DS.Add(baocao)
    End While
    reader.Close()
    Return DS
  End Function
  Public Function LayDuLieuInAn() As DataSet
    DataAccess.Openconnection()
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("select * from BaoCaoCongNo", DataAccess.connection)
    Dim ds As DataSet = New DataSet()
    adapter.Fill(ds)
    Return ds
  End Function
  Public Function LayID() As String
    Dim baocaocongno As BaoCaoCongNo = New BaoCaoCongNo()
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from BaoCaoCongNo"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim max As Integer = 0
    While reader.Read()
      baocaocongno.MaChiTietCongNo = reader.GetString(0)
      If baocaocongno.MaChiTietCongNo <> "" Then
        Dim chisoo As String = baocaocongno.MaChiTietCongNo.Substring(5)
        Dim y As Integer = Integer.Parse(chisoo)
        If max < y Then
          max = y
        End If
      End If
    End While
    reader.Close()
    If baocaocongno.MaChiTietCongNo = "" Then
      Return "mctcn1"
    End If
    max = max + 1
    Dim chiso As String = max.ToString()
    Return "mctcn" + chiso
  End Function
End Class
