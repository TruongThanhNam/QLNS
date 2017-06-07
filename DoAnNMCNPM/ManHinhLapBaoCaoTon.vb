Imports DTO
Imports BLL
Public Class ManHinhLapBaoCaoTon
  Dim baocaotonbll As BaoCaoTonBLL = New BaoCaoTonBLL()
  Dim sachbll As SachBLL = New SachBLL()
  Private Sub ManHinhLapBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiTatCalenListView()
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(0, 130, 120)
    btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 139)
  End Sub

  Private Sub HienThiTatCalenListView()
    Dim DSBCT As List(Of BaoCaoTon) = baocaotonbll.LayToanBoBaoCaoTon()
    Dim itembaocao As BaoCaoTon = New BaoCaoTon()
    For Each itembao In DSBCT
      Dim lvi As ListViewItem = New ListViewItem(itembao.MaChiTietTon)
      lvi.SubItems.Add(itembao.Thang)
      lvi.SubItems.Add(itembao.MaSach)
      lvi.SubItems.Add(itembao.TonDau)
      lvi.SubItems.Add(itembao.TonPhatSinh)
      lvi.SubItems.Add(itembao.TonCuoi)
      lvi.Tag = itembao.MaSach
      lvi.ImageIndex = 0
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub lvDaTa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDaTa.SelectedIndexChanged
    If lvDaTa.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim masach As String = lvi.Tag
    Dim itemsach As Sach = sachbll.LaySachTheoMaSach(masach)
    txtTenSach.Text = itemsach.TenSach
  End Sub

  Private Sub btnHienThiTatCa_Click(sender As Object, e As EventArgs) Handles btnHienThiTatCa.Click
    lvDaTa.Items.Clear()
    HienThiTatCalenListView()
  End Sub

  Private Sub cboThangCanLapBaoCao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboThangCanLapBaoCao.SelectedIndexChanged
    lvDaTa.Items.Clear()
    If cboThangCanLapBaoCao.SelectedItem = -1 Then
      Return
    End If
    Dim thang As Integer = Integer.Parse(cboThangCanLapBaoCao.Text)
    Dim DSBC As List(Of BaoCaoTon) = baocaotonbll.LayTheoThang(thang)
    Dim itembc As BaoCaoTon = New BaoCaoTon()
    For Each itembc In DSBC
      Dim lvi As ListViewItem = New ListViewItem(itembc.MaChiTietTon)
      lvi.SubItems.Add(itembc.Thang)
      lvi.SubItems.Add(itembc.MaSach)
      lvi.SubItems.Add(itembc.TonDau)
      lvi.SubItems.Add(itembc.TonPhatSinh)
      lvi.SubItems.Add(itembc.TonCuoi)
      lvi.ImageIndex = 0
      lvi.Tag = itembc.MaSach
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
    Dim manhinhin As ManHinhInAnBaoCaoTon = New ManHinhInAnBaoCaoTon()
    Me.Visible = False
    manhinhin.ShowDialog()
    Me.Visible = True
  End Sub

  Private Sub btnIn_MouseDown(sender As Object, e As MouseEventArgs)
    btnIn.BackColor = Color.Lime
  End Sub

  Private Sub btnIn_MouseUp(sender As Object, e As MouseEventArgs)
    btnIn.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnHienThiTatCa_MouseDown(sender As Object, e As MouseEventArgs)
    btnHienThiTatCa.BackColor = Color.Lime
  End Sub

  Private Sub btnHienThiTatCa_MouseUp(sender As Object, e As MouseEventArgs)
    btnHienThiTatCa.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
    Close()
  End Sub

  Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
    Me.WindowState = FormWindowState.Minimized
  End Sub
End Class