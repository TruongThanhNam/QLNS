Imports DTO
Imports System.Data.OleDb
Public Class DangNhapDAL
  Public Function KiemTraTen(ByVal ten As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from DangNhap where Ten=@ten"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@ten", OleDbType.BSTR).Value = ten
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function KiemTraMatKhau(ByVal matkhau As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from DangNhap where MatKhau=@matkhau"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@matkhau", OleDbType.BSTR).Value = matkhau
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function CapNhatTaiKhoan(ByVal ten As String, ByVal matkhau As String, ByVal nhomatkhau As Boolean) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into DangNhap values(@ten,@matkhau,@nhomatkhau)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@ten", OleDbType.BSTR).Value = ten
    command.Parameters.Add("@matkhau", OleDbType.BSTR).Value = matkhau
    command.Parameters.Add("@nhomatkhau", OleDbType.Boolean).Value = nhomatkhau
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function KiemTraNhoMatKhau(ByVal ten As String, ByVal nhomatkhau As Boolean) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "update DangNhap set NhoMatKhau=@nhomatkhau where Ten=@ten"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@nhomatkhau", OleDbType.Boolean).Value = nhomatkhau
    command.Parameters.Add("@ten", OleDbType.BSTR).Value = ten
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function LayCacTaiKhoanNhoMatKhau() As List(Of DangNhap)
    Dim DSDN As List(Of DangNhap) = New List(Of DangNhap)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from DangNhap where NhoMatKhau=@nhomatkhau"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@nhomatkhau", OleDbType.Boolean).Value = True
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      Dim tk As DangNhap = New DangNhap()
      tk.Ten = reader.GetString(0)
      tk.MatKhau = reader.GetString(1)
      tk.NhoMatKhau = reader.GetBoolean(2)
      DSDN.Add(tk)
    End While
    reader.Close()
    Return DSDN
  End Function
  Public Function KiemTraTenvaMatKhau(ByVal ten As String, ByVal matkhau As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from DangNhap where Ten=@ten and MatKhau=@matkhau"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@ten", OleDbType.BSTR).Value = ten
    command.Parameters.Add("@matkhau", OleDbType.BSTR).Value = matkhau
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function LayMatKhauTheoTen(ByVal ten As String) As String
    Dim matkhau As String = ""
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from DangNhap where Ten=@ten"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@ten", OleDbType.BSTR).Value = ten
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      matkhau = reader.GetString(1)
    End While
    reader.Close()
    Return matkhau
  End Function
  Public Function DoiMatKhau(ByVal ten As String, ByVal matkhaumoi As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "update DangNhap set MatKhau=@matkhaumoi where Ten=@ten"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@matkhaumoi", OleDbType.BSTR).Value = matkhaumoi
    command.Parameters.Add("@ten", OleDbType.BSTR).Value = ten
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
End Class
