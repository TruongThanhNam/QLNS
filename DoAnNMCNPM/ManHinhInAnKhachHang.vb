Imports BLL
Imports Microsoft.Reporting.WinForms
Public Class ManHinhInAnKhachHang
  Dim khachhangbll As KhachHangBLL = New KhachHangBLL()
  Private Sub ManHinhInAnKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim ds As DataSet = khachhangbll.LayDuLieuInAn()
    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DoAnNMCNPM.ReportKhachHang.rdlc"
    Dim rds As ReportDataSource = New ReportDataSource()
    rds.Name = "DataSet1"
    rds.Value = ds.Tables(0)
    Me.ReportViewer1.LocalReport.DataSources.Add(rds)
    Me.ReportViewer1.RefreshReport()
  End Sub
End Class