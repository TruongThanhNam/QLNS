<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhLapPhieuThuTien
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhLapPhieuThuTien))
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.lvData = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.t = New System.Windows.Forms.Panel()
    Me.btnMinimize = New System.Windows.Forms.Button()
    Me.btnThoat = New System.Windows.Forms.Button()
    Me.btnHienThiToanBoKhachHang = New System.Windows.Forms.Button()
    Me.btnTimKhachHangTheoEmail = New System.Windows.Forms.Button()
    Me.btnTimKhachHangTheoDienThoai = New System.Windows.Forms.Button()
    Me.btnTimKhachHangTheoDiaChi = New System.Windows.Forms.Button()
    Me.btnTimKhachHangTheoTen = New System.Windows.Forms.Button()
    Me.btnTimKhachHangTheoMa = New System.Windows.Forms.Button()
    Me.btnThuTien = New System.Windows.Forms.Button()
    Me.txtSoTienThu = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.dtNgayThuTien = New System.Windows.Forms.DateTimePicker()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtSoTienNo = New System.Windows.Forms.TextBox()
    Me.txtEmail = New System.Windows.Forms.TextBox()
    Me.txtDienThoai = New System.Windows.Forms.TextBox()
    Me.txtDiaChi = New System.Windows.Forms.TextBox()
    Me.txtHoTenKhachHang = New System.Windows.Forms.TextBox()
    Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel2.SuspendLayout()
    Me.t.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.lvData)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 418)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(1332, 161)
    Me.Panel2.TabIndex = 1
    '
    'lvData
    '
    Me.lvData.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.lvData.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
    Me.lvData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lvData.FullRowSelect = True
    Me.lvData.GridLines = True
    Me.lvData.HideSelection = False
    Me.lvData.LargeImageList = Me.ImageList1
    Me.lvData.Location = New System.Drawing.Point(0, 0)
    Me.lvData.Name = "lvData"
    Me.lvData.Size = New System.Drawing.Size(1332, 161)
    Me.lvData.SmallImageList = Me.ImageList1
    Me.lvData.TabIndex = 0
    Me.lvData.UseCompatibleStateImageBehavior = False
    Me.lvData.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Mã khách hàng"
    Me.ColumnHeader1.Width = 150
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Họ tên khách hàng"
    Me.ColumnHeader2.Width = 350
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Địa chỉ"
    Me.ColumnHeader3.Width = 350
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Điện thoại"
    Me.ColumnHeader4.Width = 200
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Text = "Email"
    Me.ColumnHeader5.Width = 350
    '
    'ColumnHeader6
    '
    Me.ColumnHeader6.Text = "Số tiền nợ"
    Me.ColumnHeader6.Width = 350
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "sach.jpg")
    Me.ImageList1.Images.SetKeyName(1, "Aha-Soft-People-People.ico")
    '
    't
    '
    Me.t.BackColor = System.Drawing.Color.Transparent
    Me.t.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.manhinhlapphieuthutien2
    Me.t.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.t.Controls.Add(Me.btnMinimize)
    Me.t.Controls.Add(Me.btnThoat)
    Me.t.Controls.Add(Me.btnHienThiToanBoKhachHang)
    Me.t.Controls.Add(Me.btnTimKhachHangTheoEmail)
    Me.t.Controls.Add(Me.btnTimKhachHangTheoDienThoai)
    Me.t.Controls.Add(Me.btnTimKhachHangTheoDiaChi)
    Me.t.Controls.Add(Me.btnTimKhachHangTheoTen)
    Me.t.Controls.Add(Me.btnTimKhachHangTheoMa)
    Me.t.Controls.Add(Me.btnThuTien)
    Me.t.Controls.Add(Me.txtSoTienThu)
    Me.t.Controls.Add(Me.Label8)
    Me.t.Controls.Add(Me.dtNgayThuTien)
    Me.t.Controls.Add(Me.Label7)
    Me.t.Controls.Add(Me.txtSoTienNo)
    Me.t.Controls.Add(Me.txtEmail)
    Me.t.Controls.Add(Me.txtDienThoai)
    Me.t.Controls.Add(Me.txtDiaChi)
    Me.t.Controls.Add(Me.txtHoTenKhachHang)
    Me.t.Controls.Add(Me.txtMaKhachHang)
    Me.t.Controls.Add(Me.Label6)
    Me.t.Controls.Add(Me.Label5)
    Me.t.Controls.Add(Me.Label4)
    Me.t.Controls.Add(Me.Label3)
    Me.t.Controls.Add(Me.Label2)
    Me.t.Controls.Add(Me.Label1)
    Me.t.Dock = System.Windows.Forms.DockStyle.Top
    Me.t.Location = New System.Drawing.Point(0, 0)
    Me.t.Name = "t"
    Me.t.Size = New System.Drawing.Size(1332, 418)
    Me.t.TabIndex = 0
    '
    'btnMinimize
    '
    Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
    Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMinimize.Image = Global.DoAnNMCNPM.My.Resources.Resources.MINIMIZE
    Me.btnMinimize.Location = New System.Drawing.Point(1246, 10)
    Me.btnMinimize.Name = "btnMinimize"
    Me.btnMinimize.Size = New System.Drawing.Size(33, 33)
    Me.btnMinimize.TabIndex = 23
    Me.btnMinimize.UseVisualStyleBackColor = True
    '
    'btnThoat
    '
    Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
    Me.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnThoat.Image = Global.DoAnNMCNPM.My.Resources.Resources.SHUTDOWN
    Me.btnThoat.Location = New System.Drawing.Point(1285, 10)
    Me.btnThoat.Name = "btnThoat"
    Me.btnThoat.Size = New System.Drawing.Size(33, 33)
    Me.btnThoat.TabIndex = 24
    Me.btnThoat.UseVisualStyleBackColor = True
    '
    'btnHienThiToanBoKhachHang
    '
    Me.btnHienThiToanBoKhachHang.BackgroundImage = CType(resources.GetObject("btnHienThiToanBoKhachHang.BackgroundImage"), System.Drawing.Image)
    Me.btnHienThiToanBoKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnHienThiToanBoKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnHienThiToanBoKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnHienThiToanBoKhachHang.ForeColor = System.Drawing.Color.White
    Me.btnHienThiToanBoKhachHang.Image = Global.DoAnNMCNPM.My.Resources.Resources.MENU
    Me.btnHienThiToanBoKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnHienThiToanBoKhachHang.Location = New System.Drawing.Point(748, 258)
    Me.btnHienThiToanBoKhachHang.Name = "btnHienThiToanBoKhachHang"
    Me.btnHienThiToanBoKhachHang.Size = New System.Drawing.Size(343, 70)
    Me.btnHienThiToanBoKhachHang.TabIndex = 17
    Me.btnHienThiToanBoKhachHang.Text = " Hiển thị toàn bộ khách hàng"
    Me.btnHienThiToanBoKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnHienThiToanBoKhachHang.UseVisualStyleBackColor = False
    '
    'btnTimKhachHangTheoEmail
    '
    Me.btnTimKhachHangTheoEmail.BackgroundImage = CType(resources.GetObject("btnTimKhachHangTheoEmail.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachHangTheoEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachHangTheoEmail.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachHangTheoEmail.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachHangTheoEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachHangTheoEmail.Location = New System.Drawing.Point(748, 212)
    Me.btnTimKhachHangTheoEmail.Name = "btnTimKhachHangTheoEmail"
    Me.btnTimKhachHangTheoEmail.Size = New System.Drawing.Size(343, 40)
    Me.btnTimKhachHangTheoEmail.TabIndex = 14
    Me.btnTimKhachHangTheoEmail.Text = "Tìm khách hàng theo email"
    Me.btnTimKhachHangTheoEmail.UseVisualStyleBackColor = False
    '
    'btnTimKhachHangTheoDienThoai
    '
    Me.btnTimKhachHangTheoDienThoai.BackgroundImage = CType(resources.GetObject("btnTimKhachHangTheoDienThoai.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachHangTheoDienThoai.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoDienThoai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoDienThoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachHangTheoDienThoai.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachHangTheoDienThoai.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachHangTheoDienThoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachHangTheoDienThoai.Location = New System.Drawing.Point(748, 159)
    Me.btnTimKhachHangTheoDienThoai.Name = "btnTimKhachHangTheoDienThoai"
    Me.btnTimKhachHangTheoDienThoai.Size = New System.Drawing.Size(343, 40)
    Me.btnTimKhachHangTheoDienThoai.TabIndex = 11
    Me.btnTimKhachHangTheoDienThoai.Text = "Tìm khách hàng theo điện thoại"
    Me.btnTimKhachHangTheoDienThoai.UseVisualStyleBackColor = False
    '
    'btnTimKhachHangTheoDiaChi
    '
    Me.btnTimKhachHangTheoDiaChi.BackgroundImage = CType(resources.GetObject("btnTimKhachHangTheoDiaChi.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachHangTheoDiaChi.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoDiaChi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoDiaChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachHangTheoDiaChi.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachHangTheoDiaChi.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachHangTheoDiaChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachHangTheoDiaChi.Location = New System.Drawing.Point(748, 108)
    Me.btnTimKhachHangTheoDiaChi.Name = "btnTimKhachHangTheoDiaChi"
    Me.btnTimKhachHangTheoDiaChi.Size = New System.Drawing.Size(343, 40)
    Me.btnTimKhachHangTheoDiaChi.TabIndex = 8
    Me.btnTimKhachHangTheoDiaChi.Text = "Tìm khách hàng theo địa chỉ"
    Me.btnTimKhachHangTheoDiaChi.UseVisualStyleBackColor = False
    '
    'btnTimKhachHangTheoTen
    '
    Me.btnTimKhachHangTheoTen.BackgroundImage = CType(resources.GetObject("btnTimKhachHangTheoTen.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachHangTheoTen.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoTen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachHangTheoTen.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachHangTheoTen.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachHangTheoTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachHangTheoTen.Location = New System.Drawing.Point(748, 62)
    Me.btnTimKhachHangTheoTen.Name = "btnTimKhachHangTheoTen"
    Me.btnTimKhachHangTheoTen.Size = New System.Drawing.Size(343, 40)
    Me.btnTimKhachHangTheoTen.TabIndex = 5
    Me.btnTimKhachHangTheoTen.Text = "Tìm khách hàng theo tên"
    Me.btnTimKhachHangTheoTen.UseVisualStyleBackColor = False
    '
    'btnTimKhachHangTheoMa
    '
    Me.btnTimKhachHangTheoMa.BackgroundImage = CType(resources.GetObject("btnTimKhachHangTheoMa.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachHangTheoMa.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoMa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachHangTheoMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachHangTheoMa.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachHangTheoMa.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachHangTheoMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachHangTheoMa.Location = New System.Drawing.Point(748, 14)
    Me.btnTimKhachHangTheoMa.Name = "btnTimKhachHangTheoMa"
    Me.btnTimKhachHangTheoMa.Size = New System.Drawing.Size(343, 40)
    Me.btnTimKhachHangTheoMa.TabIndex = 2
    Me.btnTimKhachHangTheoMa.Text = "Tìm khách hàng theo mã"
    Me.btnTimKhachHangTheoMa.UseVisualStyleBackColor = False
    '
    'btnThuTien
    '
    Me.btnThuTien.BackgroundImage = CType(resources.GetObject("btnThuTien.BackgroundImage"), System.Drawing.Image)
    Me.btnThuTien.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnThuTien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnThuTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnThuTien.ForeColor = System.Drawing.Color.White
    Me.btnThuTien.Image = Global.DoAnNMCNPM.My.Resources.Resources.TIENMANHINHCHINH
    Me.btnThuTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnThuTien.Location = New System.Drawing.Point(748, 334)
    Me.btnThuTien.Name = "btnThuTien"
    Me.btnThuTien.Size = New System.Drawing.Size(343, 72)
    Me.btnThuTien.TabIndex = 22
    Me.btnThuTien.Text = "Thu tiền"
    Me.btnThuTien.UseVisualStyleBackColor = False
    '
    'txtSoTienThu
    '
    Me.txtSoTienThu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.txtSoTienThu.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoTienThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoTienThu.Location = New System.Drawing.Point(230, 376)
    Me.txtSoTienThu.Multiline = True
    Me.txtSoTienThu.Name = "txtSoTienThu"
    Me.txtSoTienThu.Size = New System.Drawing.Size(497, 30)
    Me.txtSoTienThu.TabIndex = 21
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.ForeColor = System.Drawing.Color.White
    Me.Label8.Location = New System.Drawing.Point(20, 376)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(105, 25)
    Me.Label8.TabIndex = 20
    Me.Label8.Text = "Số tiền thu"
    '
    'dtNgayThuTien
    '
    Me.dtNgayThuTien.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayThuTien.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayThuTien.CalendarTitleForeColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayThuTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtNgayThuTien.Location = New System.Drawing.Point(230, 320)
    Me.dtNgayThuTien.Name = "dtNgayThuTien"
    Me.dtNgayThuTien.Size = New System.Drawing.Size(497, 30)
    Me.dtNgayThuTien.TabIndex = 19
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.ForeColor = System.Drawing.Color.White
    Me.Label7.Location = New System.Drawing.Point(20, 320)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(126, 25)
    Me.Label7.TabIndex = 18
    Me.Label7.Text = "Ngày thu tiền"
    '
    'txtSoTienNo
    '
    Me.txtSoTienNo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.txtSoTienNo.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoTienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoTienNo.Location = New System.Drawing.Point(230, 262)
    Me.txtSoTienNo.Multiline = True
    Me.txtSoTienNo.Name = "txtSoTienNo"
    Me.txtSoTienNo.ReadOnly = True
    Me.txtSoTienNo.Size = New System.Drawing.Size(497, 30)
    Me.txtSoTienNo.TabIndex = 16
    '
    'txtEmail
    '
    Me.txtEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtEmail.Location = New System.Drawing.Point(230, 215)
    Me.txtEmail.Multiline = True
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(497, 30)
    Me.txtEmail.TabIndex = 13
    '
    'txtDienThoai
    '
    Me.txtDienThoai.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.txtDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtDienThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDienThoai.Location = New System.Drawing.Point(230, 165)
    Me.txtDienThoai.Multiline = True
    Me.txtDienThoai.Name = "txtDienThoai"
    Me.txtDienThoai.Size = New System.Drawing.Size(497, 30)
    Me.txtDienThoai.TabIndex = 10
    '
    'txtDiaChi
    '
    Me.txtDiaChi.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDiaChi.Location = New System.Drawing.Point(230, 114)
    Me.txtDiaChi.Multiline = True
    Me.txtDiaChi.Name = "txtDiaChi"
    Me.txtDiaChi.Size = New System.Drawing.Size(497, 30)
    Me.txtDiaChi.TabIndex = 7
    '
    'txtHoTenKhachHang
    '
    Me.txtHoTenKhachHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.txtHoTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtHoTenKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtHoTenKhachHang.Location = New System.Drawing.Point(230, 64)
    Me.txtHoTenKhachHang.Multiline = True
    Me.txtHoTenKhachHang.Name = "txtHoTenKhachHang"
    Me.txtHoTenKhachHang.Size = New System.Drawing.Size(497, 30)
    Me.txtHoTenKhachHang.TabIndex = 4
    '
    'txtMaKhachHang
    '
    Me.txtMaKhachHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaKhachHang.Location = New System.Drawing.Point(230, 18)
    Me.txtMaKhachHang.Multiline = True
    Me.txtMaKhachHang.Name = "txtMaKhachHang"
    Me.txtMaKhachHang.Size = New System.Drawing.Size(497, 30)
    Me.txtMaKhachHang.TabIndex = 1
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.ForeColor = System.Drawing.Color.White
    Me.Label6.Location = New System.Drawing.Point(20, 262)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(100, 25)
    Me.Label6.TabIndex = 15
    Me.Label6.Text = "Số tiền nợ"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.ForeColor = System.Drawing.Color.White
    Me.Label5.Location = New System.Drawing.Point(20, 215)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(60, 25)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "Email"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.ForeColor = System.Drawing.Color.White
    Me.Label4.Location = New System.Drawing.Point(20, 170)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(99, 25)
    Me.Label4.TabIndex = 9
    Me.Label4.Text = "Điện thoại"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(20, 117)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(71, 25)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Địa chỉ"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(20, 64)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(176, 25)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Họ tên khách hàng"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(20, 18)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(147, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã khách hàng"
    '
    'ManHinhLapPhieuThuTien
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(1332, 579)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.t)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.Name = "ManHinhLapPhieuThuTien"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Lập Phiếu Thu Tiền"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.Panel2.ResumeLayout(False)
    Me.t.ResumeLayout(False)
    Me.t.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents t As Panel
  Friend WithEvents btnTimKhachHangTheoEmail As Button
  Friend WithEvents btnTimKhachHangTheoDienThoai As Button
  Friend WithEvents btnTimKhachHangTheoDiaChi As Button
  Friend WithEvents btnTimKhachHangTheoTen As Button
  Friend WithEvents btnTimKhachHangTheoMa As Button
  Friend WithEvents btnThuTien As Button
  Friend WithEvents txtSoTienThu As TextBox
  Friend WithEvents Label8 As Label
  Friend WithEvents dtNgayThuTien As DateTimePicker
  Friend WithEvents Label7 As Label
  Friend WithEvents txtSoTienNo As TextBox
  Friend WithEvents txtEmail As TextBox
  Friend WithEvents txtDienThoai As TextBox
  Friend WithEvents txtDiaChi As TextBox
  Friend WithEvents txtHoTenKhachHang As TextBox
  Friend WithEvents txtMaKhachHang As TextBox
  Friend WithEvents Label6 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Panel2 As Panel
  Friend WithEvents lvData As ListView
  Friend WithEvents ColumnHeader1 As ColumnHeader
  Friend WithEvents ColumnHeader2 As ColumnHeader
  Friend WithEvents ColumnHeader3 As ColumnHeader
  Friend WithEvents ColumnHeader4 As ColumnHeader
  Friend WithEvents ColumnHeader5 As ColumnHeader
  Friend WithEvents ColumnHeader6 As ColumnHeader
  Friend WithEvents btnHienThiToanBoKhachHang As Button
  Friend WithEvents ImageList1 As ImageList
  Friend WithEvents btnMinimize As Button
  Friend WithEvents btnThoat As Button
End Class
