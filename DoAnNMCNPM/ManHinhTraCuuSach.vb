Imports DTO
Imports BLL
Public Class ManHinhTraCuuSach
  Dim sachbll As SachBLL = New SachBLL()
  Private Sub ManHinhTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiToanBoSachLenListView()
    btnThoat.FlatAppearance.BorderColor = Color.FromArgb(129, 255, 100)
    btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(129, 255, 100)
  End Sub
  Private Sub HienThiToanBoSachLenListView()
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LayToanBoSach()
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvData.Items.Add(lvi)
    Next
  End Sub


  Private Sub HienThiThongTinChiTietCho1QuyenSach(masach As String)
    Dim sach As Sach = New Sach()
    sach = sachbll.LaySachTheoMaSach(masach)
    txtMaSach.Text = sach.MaSach
    txtTenSach.Text = sach.TenSach
    txtTheLoai.Text = sach.TheLoai
    txtTacGia.Text = sach.TacGia
    txtSoLuongTon.Text = sach.SoLuongTon
    txtDonGia.Text = sach.DonGia
  End Sub
  Private Sub btnLamMoi()
    txtMaSach.Text = ""
    txtTenSach.Text = ""
    txtTheLoai.Text = ""
    txtTacGia.Text = ""

    txtSoLuongTon.Text = ""
    txtDonGia.Text = ""
  End Sub

  Private Sub btnTimSach_Click(sender As Object, e As EventArgs) Handles btnTimSach.Click
    Dim masach As String = txtMaSach.Text
    Dim kq As Boolean = sachbll.KiemTraMaSach(masach)
    If kq = True Then
      HienThiSachTheoMaSach(masach)
      btnLamMoi()
    ElseIf kq = False Then
      MessageBox.Show("Mã không tồn tại")
      btnLamMoi()
    End If
  End Sub
  Private Sub HienThiSachTheoMaSach(masach As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim sach As Sach = sachbll.LaySachTheoMaSach(masach)
    Dim lvi As ListViewItem = New ListViewItem(sach.MaSach)
    lvi.SubItems.Add(sach.TenSach)
    lvi.SubItems.Add(sach.TheLoai)
    lvi.SubItems.Add(sach.TacGia)
    lvi.SubItems.Add(sach.SoLuongTon)
    lvi.SubItems.Add(sach.DonGia)
    lvi.Tag = sach.MaSach
    lvi.ImageIndex = 0
    lvData.Items.Add(lvi)
  End Sub

  Private Sub btnTimSachTheoTen_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTen.Click
    Dim tensach As String = txtTenSach.Text
    HienThiSachTheoTenSach(tensach)
    btnLamMoi()
  End Sub
  Private Sub HienThiSachTheoTenSach(tensach As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTen(tensach)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimSachTheoTheLoai_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTheLoai.Click
    Dim theloai As String = txtTheLoai.Text
    HienThiSachTheoTheLoai(theloai)
    btnLamMoi()
  End Sub
  Private Sub HienThiSachTheoTheLoai(theloai As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTheLoai(theloai)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimSachTheoTacGia_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTacGia.Click
    Dim tacgia As String = txtTacGia.Text
    HienThiSachTheoTacGia(tacgia)
    btnLamMoi()
  End Sub
  Private Sub HienThiSachTheoTacGia(tacgia As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 350)
    lvData.Columns.Add("Thể loại", 250)
    lvData.Columns.Add("Tác giả", 350)
    lvData.Columns.Add("Số lượng tồn", 250)
    lvData.Columns.Add("Đơn giá", 350)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTacGia(tacgia)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvi.ImageIndex = 0
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnToanBo_Click(sender As Object, e As EventArgs) Handles btnToanBo.Click
    HienThiToanBoSachLenListView()
  End Sub

  Private Sub txtMaSach_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaSach.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSach.PerformClick()
    End If
  End Sub

  Private Sub txtTenSach_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTenSach.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSachTheoTen.PerformClick()
    End If
  End Sub

  Private Sub txtTheLoai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTheLoai.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSachTheoTheLoai.PerformClick()
    End If
  End Sub

  Private Sub txtTacGia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTacGia.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnTimSachTheoTacGia.PerformClick()
    End If
  End Sub

  Private Sub btnTimSach_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimSach.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSach_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimSach.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimSachTheoTen_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTen.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSachTheoTen_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTen.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimSachTheoTheLoai_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTheLoai.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSachTheoTheLoai_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTheLoai.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnTimSachTheoTacGia_MouseDown(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTacGia.BackColor = Color.Lime
  End Sub

  Private Sub btnTimSachTheoTacGia_MouseUp(sender As Object, e As MouseEventArgs) 
    btnTimSachTheoTacGia.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnToanBo_MouseDown(sender As Object, e As MouseEventArgs) 
    btnToanBo.BackColor = Color.Lime
  End Sub

  Private Sub btnToanBo_MouseUp(sender As Object, e As MouseEventArgs) 
    btnToanBo.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnLamMoi(sender As Object, e As EventArgs) Handles btnLamMoiThongTin.Click
    btnLamMoi()
  End Sub

  Private Sub btnLamMoiThongTin_MouseDown(sender As Object, e As MouseEventArgs) 
    btnLamMoiThongTin.BackColor = Color.Lime
  End Sub

  Private Sub btnLamMoiThongTin_MouseUp(sender As Object, e As MouseEventArgs) 
    btnLamMoiThongTin.BackColor = Color.Gainsboro
  End Sub

  Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
    Close()
  End Sub

  Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
    Me.WindowState = FormWindowState.Minimized
  End Sub

  Private Sub txtMaSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaSach.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtMaSach.Text = ""
    End If
  End Sub

  Private Sub txtTenSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTenSach.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtTenSach.Text = ""
    End If
  End Sub

  Private Sub txtTheLoai_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTheLoai.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtTheLoai.Text = ""
    End If
  End Sub

  Private Sub txtTacGia_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTacGia.KeyUp
    If e.KeyCode = Keys.Enter Then
      txtTacGia.Text = ""
    End If
  End Sub

  Private Sub lvData_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged
    If lvData.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvData.SelectedItems(0)
    Dim masach As String = lvi.Tag.ToString()
    HienThiThongTinChiTietCho1QuyenSach(masach)
  End Sub
End Class