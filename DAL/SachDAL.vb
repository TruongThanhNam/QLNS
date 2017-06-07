Imports DTO
Imports System.Data.OleDb
Imports System.Data
Public Class SachDAL
  Public Function LayToanBoSach() As List(Of Sach)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim DSS As List(Of Sach) = New List(Of Sach)
    While reader.Read
      Dim sach As Sach = New Sach()
      sach.MaSach = reader.GetString(0)
      sach.TenSach = reader.GetString(1)
      sach.TheLoai = reader.GetString(2)
      sach.TacGia = reader.GetString(3)
      sach.SoLuongTon = reader.GetInt32(4)
      sach.DonGia = reader.GetInt32(5)
      DSS.Add(sach)
    End While
    reader.Close()
    Return DSS
  End Function
  Public Function LaySachTheoMaSach(ByVal masach As String) As Sach
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach where MaSach=@masach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    Dim sach As Sach = New Sach()
    Dim reader As OleDbDataReader = command.ExecuteReader()
    If reader.Read Then
      sach.MaSach = reader.GetString(0)
      sach.TenSach = reader.GetString(1)
      sach.TheLoai = reader.GetString(2)
      sach.TacGia = reader.GetString(3)
      sach.SoLuongTon = reader.GetInt32(4)
      sach.DonGia = reader.GetInt32(5)
    End If
    reader.Close()
    Return sach
  End Function
  Public Function KiemTraMaSach(ByVal masach As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach where MaSach=@masach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    Return kq
  End Function
  Public Function LaySachTheoTen(ByVal tensach As String) As List(Of Sach)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach where TenSach like @tensach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@tensach", OleDbType.BSTR).Value = "%" + tensach + "%"
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read
      Dim sach As Sach = New Sach()
      sach.MaSach = reader.GetString(0)
      sach.TenSach = reader.GetString(1)
      sach.TheLoai = reader.GetString(2)
      sach.TacGia = reader.GetString(3)
      sach.SoLuongTon = reader.GetInt32(4)
      sach.DonGia = reader.GetInt32(5)

      DSS.Add(sach)
    End While
    reader.Close()
    Return DSS
  End Function
  Public Function LaySachTheoTheLoai(ByVal theloai As String) As List(Of Sach)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach where TheLoai like @theloai"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@tensach", OleDbType.BSTR).Value = "%" + theloai + "%"
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read
      Dim sach As Sach = New Sach()
      sach.MaSach = reader.GetString(0)
      sach.TenSach = reader.GetString(1)
      sach.TheLoai = reader.GetString(2)
      sach.TacGia = reader.GetString(3)
      sach.SoLuongTon = reader.GetInt32(4)
      sach.DonGia = reader.GetInt32(5)

      DSS.Add(sach)
    End While
    reader.Close()
    Return DSS
  End Function
  Public Function LaySachTheoTacGia(ByVal tacgia As String) As List(Of Sach)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach where TacGia like @tacgia"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@tensach", OleDbType.BSTR).Value = "%" + tacgia + "%"
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read
      Dim sach As Sach = New Sach()
      sach.MaSach = reader.GetString(0)
      sach.TenSach = reader.GetString(1)
      sach.TheLoai = reader.GetString(2)
      sach.TacGia = reader.GetString(3)
      sach.SoLuongTon = reader.GetInt32(4)
      sach.DonGia = reader.GetInt32(5)

      DSS.Add(sach)
    End While
    reader.Close()
    Return DSS
  End Function
  Public Function LaySoLuongTonTheoMaSach(ByVal masach As String) As Integer
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach where MaSach=@masach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim soluongton As Integer = 0
    If reader.Read() Then
      soluongton = reader.GetInt32(4)
    End If
    reader.Close()
    Return soluongton
  End Function
  Public Function CapNhatSoLuongTonMoiTheoMaSach(ByVal masach As String, ByVal soluongtonmoi As Integer) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "update Sach set SoLuongTon=@soluongtonmoi where MaSach=@masach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@soluongtonmoi", OleDbType.Integer).Value = soluongtonmoi
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function ThemSach(ByVal masach As String, ByVal tensach As String, ByVal theloai As String, ByVal tacgia As String, ByVal soluongton As Integer, ByVal dongia As Integer) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into Sach values(@masach,@tensach,@theloai,@tacgia,@soluongton,@dongia)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    command.Parameters.Add("@tensach", OleDbType.BSTR).Value = tensach
    command.Parameters.Add("@theloai", OleDbType.BSTR).Value = theloai
    command.Parameters.Add("@tacgia", OleDbType.BSTR).Value = tacgia
    command.Parameters.Add("@soluongton", OleDbType.Integer).Value = soluongton
    command.Parameters.Add("@dongia", OleDbType.Integer).Value = dongia
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function SuaSach(ByVal masach As String, ByVal tensach As String, ByVal theloai As String, ByVal tacgia As String, ByVal dongia As Integer) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "update Sach set TenSach=@tensach,TheLoai=@theloai,TacGia=@tacgia,DonGia=@dongia where MaSach=@masach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@tensach", OleDbType.BSTR).Value = tensach
    command.Parameters.Add("@theloai", OleDbType.BSTR).Value = theloai
    command.Parameters.Add("@tacgia", OleDbType.BSTR).Value = tacgia
    command.Parameters.Add("@dongia", OleDbType.Integer).Value = dongia
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function XoaSach(ByVal masach As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "delete from Sach where MaSach=@masach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function LayDonGiaTheoMaSach(ByVal masach As String) As Double
    Dim dongia As Double = 0
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach where MaSach=@masach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    Dim reader As OleDbDataReader = command.ExecuteReader()
    If reader.Read() Then
      dongia = reader.GetInt32(5)
    End If
    reader.Close()
    Return dongia
  End Function
  Public Function LayDuLieuInAn() As DataSet
    DataAccess.Openconnection()
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("select * from Sach", DataAccess.connection)
    Dim ds As DataSet = New DataSet()
    adapter.Fill(ds)
    Return ds
  End Function
  Public Function LayId() As String
    Dim sach As Sach = New Sach()
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim max As Integer = 0
    While reader.Read()
      sach.MaSach = reader.GetString(0)
      If sach.MaSach <> "" Then
        Dim chisoo As String = sach.MaSach.Substring(2)
        Dim y As Integer = Integer.Parse(chisoo)
        If max < y Then
          max = y
        End If
      End If
    End While
    reader.Close()
    If sach.MaSach = "" Then
      sach.MaSach = "ms1"
      Return sach.MaSach
    End If
    max = max + 1
    Dim chiso As String = max.ToString()
    Return "ms" + chiso
  End Function
  Public Function LayTenSach() As List(Of String)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from Sach"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim str As List(Of String) = New List(Of String)
    While reader.Read
      Dim ten As String = reader.GetString(1)
      str.Add(ten)
    End While
    reader.Close()
    Return str
  End Function
End Class
