Imports DTO
Imports BLL
Imports Microsoft.Reporting.WinForms
Public Class ManHinhInAnBaoCaoCongNo
  Dim baocaocongnobll As BaoCaoCongNoBLL = New BaoCaoCongNoBLL()
  Private Sub ManHinhInAnBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim ds As DataSet = baocaocongnobll.LayDuLieuInAn()
    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DoAnNMCNPM.ReportBaoCaoCongNo.rdlc"
    Dim rds As ReportDataSource = New ReportDataSource()
    rds.Name = "DataSet1"
    rds.Value = ds.Tables(0)
    Me.ReportViewer1.LocalReport.DataSources.Add(rds)
    Me.ReportViewer1.RefreshReport()
  End Sub
End Class