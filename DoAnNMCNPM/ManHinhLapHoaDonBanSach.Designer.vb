<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManHinhLapHoaDonBanSach
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhLapHoaDonBanSach))
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.lvDaTa = New System.Windows.Forms.ListView()
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.btnMinimize = New System.Windows.Forms.Button()
    Me.btnThoat = New System.Windows.Forms.Button()
    Me.btnIn = New System.Windows.Forms.Button()
    Me.btnHienThiKhach = New System.Windows.Forms.Button()
    Me.txtTongTien = New System.Windows.Forms.TextBox()
    Me.btnHienThiSach = New System.Windows.Forms.Button()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.txtSoLuongTonToiThieuSauKhiBan = New System.Windows.Forms.TextBox()
    Me.txtSoTienNoToiDa = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.btnLamMoi = New System.Windows.Forms.Button()
    Me.btnXoa = New System.Windows.Forms.Button()
    Me.btnSua = New System.Windows.Forms.Button()
    Me.btnThem = New System.Windows.Forms.Button()
    Me.btnBan = New System.Windows.Forms.Button()
    Me.txtSoLuongMua = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.btnTimSachTheoMa = New System.Windows.Forms.Button()
    Me.txtMaSach = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.btnTimKhachTheoEmail = New System.Windows.Forms.Button()
    Me.btnTimKhachTheoSoDienThoai = New System.Windows.Forms.Button()
    Me.btnTimKhachTheoDiaChi = New System.Windows.Forms.Button()
    Me.btnTimKhachTheoTenKhach = New System.Windows.Forms.Button()
    Me.btnTimKhachTheoMa = New System.Windows.Forms.Button()
    Me.txtSoTienNo = New System.Windows.Forms.TextBox()
    Me.txtEmail = New System.Windows.Forms.TextBox()
    Me.txtDienThoai = New System.Windows.Forms.TextBox()
    Me.txtDiaChi = New System.Windows.Forms.TextBox()
    Me.txtHoTenKhachHang = New System.Windows.Forms.TextBox()
    Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Panel1.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.lvDaTa)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.Location = New System.Drawing.Point(0, 611)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1596, 262)
    Me.Panel1.TabIndex = 0
    '
    'lvDaTa
    '
    Me.lvDaTa.BackColor = System.Drawing.Color.Khaki
    Me.lvDaTa.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lvDaTa.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvDaTa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lvDaTa.FullRowSelect = True
    Me.lvDaTa.GridLines = True
    Me.lvDaTa.HideSelection = False
    Me.lvDaTa.LargeImageList = Me.ImageList1
    Me.lvDaTa.Location = New System.Drawing.Point(0, 0)
    Me.lvDaTa.Name = "lvDaTa"
    Me.lvDaTa.Size = New System.Drawing.Size(1596, 262)
    Me.lvDaTa.SmallImageList = Me.ImageList1
    Me.lvDaTa.TabIndex = 0
    Me.lvDaTa.UseCompatibleStateImageBehavior = False
    Me.lvDaTa.View = System.Windows.Forms.View.Details
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "sach.jpg")
    Me.ImageList1.Images.SetKeyName(1, "Aha-Soft-People-People.ico")
    '
    'Panel3
    '
    Me.Panel3.BackColor = System.Drawing.Color.Transparent
    Me.Panel3.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.manhinhlaphoadonbansachRight1
    Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.Panel3.Controls.Add(Me.GroupBox1)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3.Location = New System.Drawing.Point(929, 0)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(667, 611)
    Me.Panel3.TabIndex = 2
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.GroupBox1.Controls.Add(Me.btnMinimize)
    Me.GroupBox1.Controls.Add(Me.btnThoat)
    Me.GroupBox1.Controls.Add(Me.btnIn)
    Me.GroupBox1.Controls.Add(Me.btnHienThiKhach)
    Me.GroupBox1.Controls.Add(Me.txtTongTien)
    Me.GroupBox1.Controls.Add(Me.btnHienThiSach)
    Me.GroupBox1.Controls.Add(Me.Label11)
    Me.GroupBox1.Controls.Add(Me.txtSoLuongTonToiThieuSauKhiBan)
    Me.GroupBox1.Controls.Add(Me.txtSoTienNoToiDa)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.ForeColor = System.Drawing.Color.White
    Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(667, 611)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Quy định"
    '
    'btnMinimize
    '
    Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
    Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMinimize.Image = Global.DoAnNMCNPM.My.Resources.Resources.MINIMIZE
    Me.btnMinimize.Location = New System.Drawing.Point(583, 12)
    Me.btnMinimize.Name = "btnMinimize"
    Me.btnMinimize.Size = New System.Drawing.Size(33, 33)
    Me.btnMinimize.TabIndex = 17
    Me.btnMinimize.UseVisualStyleBackColor = True
    '
    'btnThoat
    '
    Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnThoat.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.SHUTDOWN
    Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
    Me.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnThoat.Location = New System.Drawing.Point(622, 12)
    Me.btnThoat.Name = "btnThoat"
    Me.btnThoat.Size = New System.Drawing.Size(33, 33)
    Me.btnThoat.TabIndex = 18
    Me.btnThoat.UseVisualStyleBackColor = True
    '
    'btnIn
    '
    Me.btnIn.BackgroundImage = CType(resources.GetObject("btnIn.BackgroundImage"), System.Drawing.Image)
    Me.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnIn.ForeColor = System.Drawing.Color.White
    Me.btnIn.Image = Global.DoAnNMCNPM.My.Resources.Resources.MAYIn2HAIMANHINHBAOCAO
    Me.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnIn.Location = New System.Drawing.Point(23, 531)
    Me.btnIn.Name = "btnIn"
    Me.btnIn.Size = New System.Drawing.Size(320, 59)
    Me.btnIn.TabIndex = 9
    Me.btnIn.Text = "   In danh sách khách hàng"
    Me.btnIn.UseVisualStyleBackColor = False
    '
    'btnHienThiKhach
    '
    Me.btnHienThiKhach.BackgroundImage = CType(resources.GetObject("btnHienThiKhach.BackgroundImage"), System.Drawing.Image)
    Me.btnHienThiKhach.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnHienThiKhach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnHienThiKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnHienThiKhach.ForeColor = System.Drawing.Color.White
    Me.btnHienThiKhach.Image = Global.DoAnNMCNPM.My.Resources.Resources.MENU
    Me.btnHienThiKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnHienThiKhach.Location = New System.Drawing.Point(23, 442)
    Me.btnHienThiKhach.Name = "btnHienThiKhach"
    Me.btnHienThiKhach.Size = New System.Drawing.Size(320, 59)
    Me.btnHienThiKhach.TabIndex = 8
    Me.btnHienThiKhach.Text = "Hiển thị khách hàng"
    Me.btnHienThiKhach.UseVisualStyleBackColor = False
    '
    'txtTongTien
    '
    Me.txtTongTien.BackColor = System.Drawing.Color.Khaki
    Me.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtTongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTongTien.Location = New System.Drawing.Point(23, 277)
    Me.txtTongTien.Multiline = True
    Me.txtTongTien.Name = "txtTongTien"
    Me.txtTongTien.ReadOnly = True
    Me.txtTongTien.Size = New System.Drawing.Size(278, 30)
    Me.txtTongTien.TabIndex = 6
    '
    'btnHienThiSach
    '
    Me.btnHienThiSach.BackgroundImage = CType(resources.GetObject("btnHienThiSach.BackgroundImage"), System.Drawing.Image)
    Me.btnHienThiSach.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnHienThiSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnHienThiSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnHienThiSach.ForeColor = System.Drawing.Color.White
    Me.btnHienThiSach.Image = Global.DoAnNMCNPM.My.Resources.Resources.MENU
    Me.btnHienThiSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnHienThiSach.Location = New System.Drawing.Point(23, 352)
    Me.btnHienThiSach.Name = "btnHienThiSach"
    Me.btnHienThiSach.Size = New System.Drawing.Size(320, 59)
    Me.btnHienThiSach.TabIndex = 7
    Me.btnHienThiSach.Text = "Hiển thị sách"
    Me.btnHienThiSach.UseVisualStyleBackColor = False
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(18, 234)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(148, 25)
    Me.Label11.TabIndex = 5
    Me.Label11.Text = "Tổng thành tiền"
    '
    'txtSoLuongTonToiThieuSauKhiBan
    '
    Me.txtSoLuongTonToiThieuSauKhiBan.BackColor = System.Drawing.Color.Khaki
    Me.txtSoLuongTonToiThieuSauKhiBan.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoLuongTonToiThieuSauKhiBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoLuongTonToiThieuSauKhiBan.Location = New System.Drawing.Point(23, 174)
    Me.txtSoLuongTonToiThieuSauKhiBan.Multiline = True
    Me.txtSoLuongTonToiThieuSauKhiBan.Name = "txtSoLuongTonToiThieuSauKhiBan"
    Me.txtSoLuongTonToiThieuSauKhiBan.ReadOnly = True
    Me.txtSoLuongTonToiThieuSauKhiBan.Size = New System.Drawing.Size(278, 30)
    Me.txtSoLuongTonToiThieuSauKhiBan.TabIndex = 4
    '
    'txtSoTienNoToiDa
    '
    Me.txtSoTienNoToiDa.BackColor = System.Drawing.Color.Khaki
    Me.txtSoTienNoToiDa.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoTienNoToiDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoTienNoToiDa.Location = New System.Drawing.Point(23, 79)
    Me.txtSoTienNoToiDa.Multiline = True
    Me.txtSoTienNoToiDa.Name = "txtSoTienNoToiDa"
    Me.txtSoTienNoToiDa.ReadOnly = True
    Me.txtSoTienNoToiDa.Size = New System.Drawing.Size(278, 30)
    Me.txtSoTienNoToiDa.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(18, 134)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(299, 25)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Số lượng tồn tối thiểu sau khi bán"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(18, 38)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(152, 25)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Số tiền nợ tối đa"
    '
    'Panel2
    '
    Me.Panel2.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.manhinhlaphoadonbansachleft1
    Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.Panel2.Controls.Add(Me.GroupBox2)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(929, 611)
    Me.Panel2.TabIndex = 1
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox2.Controls.Add(Me.btnLamMoi)
    Me.GroupBox2.Controls.Add(Me.btnXoa)
    Me.GroupBox2.Controls.Add(Me.btnSua)
    Me.GroupBox2.Controls.Add(Me.btnThem)
    Me.GroupBox2.Controls.Add(Me.btnBan)
    Me.GroupBox2.Controls.Add(Me.txtSoLuongMua)
    Me.GroupBox2.Controls.Add(Me.Label10)
    Me.GroupBox2.Controls.Add(Me.btnTimSachTheoMa)
    Me.GroupBox2.Controls.Add(Me.txtMaSach)
    Me.GroupBox2.Controls.Add(Me.Label9)
    Me.GroupBox2.Controls.Add(Me.btnTimKhachTheoEmail)
    Me.GroupBox2.Controls.Add(Me.btnTimKhachTheoSoDienThoai)
    Me.GroupBox2.Controls.Add(Me.btnTimKhachTheoDiaChi)
    Me.GroupBox2.Controls.Add(Me.btnTimKhachTheoTenKhach)
    Me.GroupBox2.Controls.Add(Me.btnTimKhachTheoMa)
    Me.GroupBox2.Controls.Add(Me.txtSoTienNo)
    Me.GroupBox2.Controls.Add(Me.txtEmail)
    Me.GroupBox2.Controls.Add(Me.txtDienThoai)
    Me.GroupBox2.Controls.Add(Me.txtDiaChi)
    Me.GroupBox2.Controls.Add(Me.txtHoTenKhachHang)
    Me.GroupBox2.Controls.Add(Me.txtMaKhachHang)
    Me.GroupBox2.Controls.Add(Me.Label8)
    Me.GroupBox2.Controls.Add(Me.Label7)
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Controls.Add(Me.Label4)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.ForeColor = System.Drawing.Color.White
    Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(929, 611)
    Me.GroupBox2.TabIndex = 0
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Thông tin chi tiết"
    '
    'btnLamMoi
    '
    Me.btnLamMoi.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.buttonban
    Me.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLamMoi.ForeColor = System.Drawing.Color.White
    Me.btnLamMoi.Image = Global.DoAnNMCNPM.My.Resources.Resources.CREATENEW
    Me.btnLamMoi.Location = New System.Drawing.Point(787, 501)
    Me.btnLamMoi.Name = "btnLamMoi"
    Me.btnLamMoi.Size = New System.Drawing.Size(136, 89)
    Me.btnLamMoi.TabIndex = 26
    Me.btnLamMoi.Text = "Làm mới "
    Me.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.btnLamMoi.UseVisualStyleBackColor = False
    '
    'btnXoa
    '
    Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
    Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnXoa.ForeColor = System.Drawing.Color.White
    Me.btnXoa.Image = Global.DoAnNMCNPM.My.Resources.Resources.PEOPLES
    Me.btnXoa.Location = New System.Drawing.Point(582, 500)
    Me.btnXoa.Name = "btnXoa"
    Me.btnXoa.Size = New System.Drawing.Size(199, 90)
    Me.btnXoa.TabIndex = 25
    Me.btnXoa.Text = "Xóa khách hàng"
    Me.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.btnXoa.UseVisualStyleBackColor = False
    '
    'btnSua
    '
    Me.btnSua.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.buttonthem
    Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSua.ForeColor = System.Drawing.Color.White
    Me.btnSua.Image = Global.DoAnNMCNPM.My.Resources.Resources.PEOPLES
    Me.btnSua.Location = New System.Drawing.Point(323, 500)
    Me.btnSua.Name = "btnSua"
    Me.btnSua.Size = New System.Drawing.Size(253, 90)
    Me.btnSua.TabIndex = 24
    Me.btnSua.Text = "Sửa thông tin khách hàng"
    Me.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.btnSua.UseVisualStyleBackColor = False
    '
    'btnThem
    '
    Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
    Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnThem.ForeColor = System.Drawing.Color.White
    Me.btnThem.Image = Global.DoAnNMCNPM.My.Resources.Resources.PEOPLES
    Me.btnThem.Location = New System.Drawing.Point(127, 500)
    Me.btnThem.Name = "btnThem"
    Me.btnThem.Size = New System.Drawing.Size(190, 90)
    Me.btnThem.TabIndex = 23
    Me.btnThem.Text = "Thêm khách hàng"
    Me.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.btnThem.UseVisualStyleBackColor = False
    '
    'btnBan
    '
    Me.btnBan.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.buttonban
    Me.btnBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnBan.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBan.ForeColor = System.Drawing.Color.White
    Me.btnBan.Image = Global.DoAnNMCNPM.My.Resources.Resources.TUITIEN
    Me.btnBan.Location = New System.Drawing.Point(17, 500)
    Me.btnBan.Name = "btnBan"
    Me.btnBan.Size = New System.Drawing.Size(104, 90)
    Me.btnBan.TabIndex = 22
    Me.btnBan.Text = "Bán"
    Me.btnBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.btnBan.UseVisualStyleBackColor = False
    '
    'txtSoLuongMua
    '
    Me.txtSoLuongMua.BackColor = System.Drawing.Color.Khaki
    Me.txtSoLuongMua.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoLuongMua.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoLuongMua.Location = New System.Drawing.Point(206, 453)
    Me.txtSoLuongMua.Multiline = True
    Me.txtSoLuongMua.Name = "txtSoLuongMua"
    Me.txtSoLuongMua.Size = New System.Drawing.Size(331, 30)
    Me.txtSoLuongMua.TabIndex = 21
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(12, 453)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(133, 25)
    Me.Label10.TabIndex = 20
    Me.Label10.Text = "Số lượng mua"
    '
    'btnTimSachTheoMa
    '
    Me.btnTimSachTheoMa.BackColor = System.Drawing.SystemColors.MenuHighlight
    Me.btnTimSachTheoMa.BackgroundImage = CType(resources.GetObject("btnTimSachTheoMa.BackgroundImage"), System.Drawing.Image)
    Me.btnTimSachTheoMa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnTimSachTheoMa.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimSachTheoMa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimSachTheoMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimSachTheoMa.ForeColor = System.Drawing.Color.White
    Me.btnTimSachTheoMa.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimSachTheoMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimSachTheoMa.Location = New System.Drawing.Point(552, 406)
    Me.btnTimSachTheoMa.Name = "btnTimSachTheoMa"
    Me.btnTimSachTheoMa.Size = New System.Drawing.Size(348, 33)
    Me.btnTimSachTheoMa.TabIndex = 19
    Me.btnTimSachTheoMa.Text = "Tìm theo mã sách"
    Me.btnTimSachTheoMa.UseVisualStyleBackColor = False
    '
    'txtMaSach
    '
    Me.txtMaSach.BackColor = System.Drawing.Color.Khaki
    Me.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaSach.Location = New System.Drawing.Point(206, 406)
    Me.txtMaSach.Multiline = True
    Me.txtMaSach.Name = "txtMaSach"
    Me.txtMaSach.Size = New System.Drawing.Size(331, 30)
    Me.txtMaSach.TabIndex = 18
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(12, 409)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(87, 25)
    Me.Label9.TabIndex = 17
    Me.Label9.Text = "Mã sách"
    '
    'btnTimKhachTheoEmail
    '
    Me.btnTimKhachTheoEmail.BackColor = System.Drawing.SystemColors.MenuHighlight
    Me.btnTimKhachTheoEmail.BackgroundImage = CType(resources.GetObject("btnTimKhachTheoEmail.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachTheoEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnTimKhachTheoEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachTheoEmail.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachTheoEmail.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachTheoEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachTheoEmail.Location = New System.Drawing.Point(552, 291)
    Me.btnTimKhachTheoEmail.Name = "btnTimKhachTheoEmail"
    Me.btnTimKhachTheoEmail.Size = New System.Drawing.Size(348, 33)
    Me.btnTimKhachTheoEmail.TabIndex = 14
    Me.btnTimKhachTheoEmail.Text = "Tìm khách theo email"
    Me.btnTimKhachTheoEmail.UseVisualStyleBackColor = False
    '
    'btnTimKhachTheoSoDienThoai
    '
    Me.btnTimKhachTheoSoDienThoai.BackColor = System.Drawing.SystemColors.MenuHighlight
    Me.btnTimKhachTheoSoDienThoai.BackgroundImage = CType(resources.GetObject("btnTimKhachTheoSoDienThoai.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachTheoSoDienThoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnTimKhachTheoSoDienThoai.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoSoDienThoai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoSoDienThoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachTheoSoDienThoai.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachTheoSoDienThoai.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachTheoSoDienThoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachTheoSoDienThoai.Location = New System.Drawing.Point(552, 231)
    Me.btnTimKhachTheoSoDienThoai.Name = "btnTimKhachTheoSoDienThoai"
    Me.btnTimKhachTheoSoDienThoai.Size = New System.Drawing.Size(348, 33)
    Me.btnTimKhachTheoSoDienThoai.TabIndex = 11
    Me.btnTimKhachTheoSoDienThoai.Text = "Tìm khách theo số điện thoại"
    Me.btnTimKhachTheoSoDienThoai.UseVisualStyleBackColor = False
    '
    'btnTimKhachTheoDiaChi
    '
    Me.btnTimKhachTheoDiaChi.BackColor = System.Drawing.SystemColors.MenuHighlight
    Me.btnTimKhachTheoDiaChi.BackgroundImage = CType(resources.GetObject("btnTimKhachTheoDiaChi.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachTheoDiaChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnTimKhachTheoDiaChi.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoDiaChi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoDiaChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachTheoDiaChi.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachTheoDiaChi.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachTheoDiaChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachTheoDiaChi.Location = New System.Drawing.Point(552, 168)
    Me.btnTimKhachTheoDiaChi.Name = "btnTimKhachTheoDiaChi"
    Me.btnTimKhachTheoDiaChi.Size = New System.Drawing.Size(348, 33)
    Me.btnTimKhachTheoDiaChi.TabIndex = 8
    Me.btnTimKhachTheoDiaChi.Text = "Tìm khách theo địa chỉ"
    Me.btnTimKhachTheoDiaChi.UseVisualStyleBackColor = False
    '
    'btnTimKhachTheoTenKhach
    '
    Me.btnTimKhachTheoTenKhach.BackColor = System.Drawing.SystemColors.MenuHighlight
    Me.btnTimKhachTheoTenKhach.BackgroundImage = CType(resources.GetObject("btnTimKhachTheoTenKhach.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachTheoTenKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnTimKhachTheoTenKhach.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoTenKhach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoTenKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachTheoTenKhach.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachTheoTenKhach.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachTheoTenKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachTheoTenKhach.Location = New System.Drawing.Point(552, 96)
    Me.btnTimKhachTheoTenKhach.Name = "btnTimKhachTheoTenKhach"
    Me.btnTimKhachTheoTenKhach.Size = New System.Drawing.Size(348, 33)
    Me.btnTimKhachTheoTenKhach.TabIndex = 5
    Me.btnTimKhachTheoTenKhach.Text = "Tìm khách theo tên khách"
    Me.btnTimKhachTheoTenKhach.UseVisualStyleBackColor = False
    '
    'btnTimKhachTheoMa
    '
    Me.btnTimKhachTheoMa.BackgroundImage = CType(resources.GetObject("btnTimKhachTheoMa.BackgroundImage"), System.Drawing.Image)
    Me.btnTimKhachTheoMa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.btnTimKhachTheoMa.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoMa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimKhachTheoMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimKhachTheoMa.ForeColor = System.Drawing.Color.White
    Me.btnTimKhachTheoMa.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimKhachTheoMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimKhachTheoMa.Location = New System.Drawing.Point(552, 38)
    Me.btnTimKhachTheoMa.Name = "btnTimKhachTheoMa"
    Me.btnTimKhachTheoMa.Size = New System.Drawing.Size(348, 33)
    Me.btnTimKhachTheoMa.TabIndex = 2
    Me.btnTimKhachTheoMa.Text = "Tìm khách theo mã khách"
    Me.btnTimKhachTheoMa.UseVisualStyleBackColor = False
    '
    'txtSoTienNo
    '
    Me.txtSoTienNo.BackColor = System.Drawing.Color.Khaki
    Me.txtSoTienNo.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoTienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoTienNo.Location = New System.Drawing.Point(206, 352)
    Me.txtSoTienNo.Multiline = True
    Me.txtSoTienNo.Name = "txtSoTienNo"
    Me.txtSoTienNo.ReadOnly = True
    Me.txtSoTienNo.Size = New System.Drawing.Size(331, 30)
    Me.txtSoTienNo.TabIndex = 16
    '
    'txtEmail
    '
    Me.txtEmail.BackColor = System.Drawing.Color.Khaki
    Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtEmail.Location = New System.Drawing.Point(206, 277)
    Me.txtEmail.Multiline = True
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(331, 61)
    Me.txtEmail.TabIndex = 13
    '
    'txtDienThoai
    '
    Me.txtDienThoai.BackColor = System.Drawing.Color.Khaki
    Me.txtDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtDienThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDienThoai.Location = New System.Drawing.Point(206, 231)
    Me.txtDienThoai.Multiline = True
    Me.txtDienThoai.Name = "txtDienThoai"
    Me.txtDienThoai.Size = New System.Drawing.Size(331, 30)
    Me.txtDienThoai.TabIndex = 10
    '
    'txtDiaChi
    '
    Me.txtDiaChi.BackColor = System.Drawing.Color.Khaki
    Me.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDiaChi.Location = New System.Drawing.Point(206, 154)
    Me.txtDiaChi.Multiline = True
    Me.txtDiaChi.Name = "txtDiaChi"
    Me.txtDiaChi.Size = New System.Drawing.Size(331, 71)
    Me.txtDiaChi.TabIndex = 7
    '
    'txtHoTenKhachHang
    '
    Me.txtHoTenKhachHang.BackColor = System.Drawing.Color.Khaki
    Me.txtHoTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtHoTenKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtHoTenKhachHang.Location = New System.Drawing.Point(206, 76)
    Me.txtHoTenKhachHang.Multiline = True
    Me.txtHoTenKhachHang.Name = "txtHoTenKhachHang"
    Me.txtHoTenKhachHang.Size = New System.Drawing.Size(331, 66)
    Me.txtHoTenKhachHang.TabIndex = 4
    '
    'txtMaKhachHang
    '
    Me.txtMaKhachHang.BackColor = System.Drawing.Color.Khaki
    Me.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaKhachHang.Location = New System.Drawing.Point(206, 38)
    Me.txtMaKhachHang.Multiline = True
    Me.txtMaKhachHang.Name = "txtMaKhachHang"
    Me.txtMaKhachHang.Size = New System.Drawing.Size(331, 30)
    Me.txtMaKhachHang.TabIndex = 1
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(12, 352)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(100, 25)
    Me.Label8.TabIndex = 15
    Me.Label8.Text = "Số tiền nợ"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(12, 295)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(60, 25)
    Me.Label7.TabIndex = 12
    Me.Label7.Text = "Email"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(12, 234)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(99, 25)
    Me.Label6.TabIndex = 9
    Me.Label6.Text = "Điện thoại"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 172)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(71, 25)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Địa chỉ"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 96)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(176, 25)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Họ tên khách hàng"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 38)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(147, 25)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Mã khách hàng"
    '
    'ManHinhLapHoaDonBanSach
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(1596, 873)
    Me.Controls.Add(Me.Panel3)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.DoubleBuffered = True
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.Name = "ManHinhLapHoaDonBanSach"
    Me.Text = "Lập Hóa Đơn Bán Sách"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.Panel1.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Panel1 As Panel
  Friend WithEvents lvDaTa As ListView
  Friend WithEvents Panel2 As Panel
  Friend WithEvents GroupBox2 As GroupBox
  Friend WithEvents btnBan As Button
  Friend WithEvents txtSoLuongMua As TextBox
  Friend WithEvents Label10 As Label
  Friend WithEvents btnTimSachTheoMa As Button
  Friend WithEvents txtMaSach As TextBox
  Friend WithEvents Label9 As Label
  Friend WithEvents btnTimKhachTheoEmail As Button
  Friend WithEvents btnTimKhachTheoSoDienThoai As Button
  Friend WithEvents btnTimKhachTheoDiaChi As Button
  Friend WithEvents btnTimKhachTheoTenKhach As Button
  Friend WithEvents btnTimKhachTheoMa As Button
  Friend WithEvents txtSoTienNo As TextBox
  Friend WithEvents txtEmail As TextBox
  Friend WithEvents txtDienThoai As TextBox
  Friend WithEvents txtDiaChi As TextBox
  Friend WithEvents txtHoTenKhachHang As TextBox
  Friend WithEvents txtMaKhachHang As TextBox
  Friend WithEvents Label8 As Label
  Friend WithEvents Label7 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Panel3 As Panel
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents txtSoLuongTonToiThieuSauKhiBan As TextBox
  Friend WithEvents txtSoTienNoToiDa As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents btnHienThiKhach As Button
  Friend WithEvents btnHienThiSach As Button
  Friend WithEvents txtTongTien As TextBox
  Friend WithEvents Label11 As Label
  Friend WithEvents btnXoa As Button
  Friend WithEvents btnSua As Button
  Friend WithEvents btnThem As Button
  Friend WithEvents btnLamMoi As Button
  Friend WithEvents btnIn As Button
  Friend WithEvents ImageList1 As ImageList
  Friend WithEvents btnMinimize As Button
  Friend WithEvents btnThoat As Button
End Class
