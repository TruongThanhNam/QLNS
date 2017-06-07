Imports System.Data.OleDb
Imports System.Environment
Public Class DataAccess

#If DEBUG Then
  Public Shared DBPath As String = "."
#Else
  Public Shared DBPath As String = GetFolderPath(SpecialFolder.ApplicationData)
#End If

  Public Shared connection As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBPath + "\CSDL.accdb")
  Shared Sub Openconnection()
    Try
      'connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDL.accdb")
      If connection.State = ConnectionState.Closed Then
        connection.Open()
      End If
    Catch ex As Exception

    End Try
  End Sub
  Shared Sub Closeconnection()
    connection.Close()
  End Sub
End Class
