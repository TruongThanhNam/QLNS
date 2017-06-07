Imports BLL
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class ManHinhInAnBaoCaoTon
  Dim baocaotonbll As BaoCaoTonBLL = New BaoCaoTonBLL()
  Private Sub ManHinhInAnBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim ds As DataSet = baocaotonbll.LayDuLieuBaoCaoInAn()
    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DoAnNMCNPM.ReportBaoCaoTon.rdlc"
    Dim rds As ReportDataSource = New ReportDataSource()
    rds.Name = "DataSet1"
    rds.Value = ds.Tables(0)
    Me.ReportViewer1.LocalReport.DataSources.Add(rds)
    Me.ReportViewer1.RefreshReport()
  End Sub
End Class