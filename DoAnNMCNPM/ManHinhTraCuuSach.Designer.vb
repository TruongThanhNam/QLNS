<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhTraCuuSach
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhTraCuuSach))
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.btnMinimize = New System.Windows.Forms.Button()
    Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
    Me.btnThoat = New System.Windows.Forms.Button()
    Me.txtTacGia = New System.Windows.Forms.TextBox()
    Me.txtMaSach = New System.Windows.Forms.TextBox()
    Me.btnTimSach = New System.Windows.Forms.Button()
    Me.btnLamMoiThongTin = New System.Windows.Forms.Button()
    Me.txtTheLoai = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnTimSachTheoTen = New System.Windows.Forms.Button()
    Me.btnToanBo = New System.Windows.Forms.Button()
    Me.txtTenSach = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnTimSachTheoTheLoai = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.btnTimSachTheoTacGia = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.lvData = New System.Windows.Forms.ListView()
    Me.lblDongia = New System.Windows.Forms.Label()
    Me.txtDonGia = New System.Windows.Forms.TextBox()
    Me.Panel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.Color.Transparent
    Me.Panel2.Controls.Add(Me.lvData)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 407)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(1153, 257)
    Me.Panel2.TabIndex = 1
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "sach.jpg")
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Transparent
    Me.Panel1.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.manhinhtracuusach
    Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.Panel1.Controls.Add(Me.btnMinimize)
    Me.Panel1.Controls.Add(Me.txtDonGia)
    Me.Panel1.Controls.Add(Me.txtSoLuongTon)
    Me.Panel1.Controls.Add(Me.btnThoat)
    Me.Panel1.Controls.Add(Me.txtTacGia)
    Me.Panel1.Controls.Add(Me.txtMaSach)
    Me.Panel1.Controls.Add(Me.btnTimSach)
    Me.Panel1.Controls.Add(Me.btnLamMoiThongTin)
    Me.Panel1.Controls.Add(Me.txtTheLoai)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.btnTimSachTheoTen)
    Me.Panel1.Controls.Add(Me.btnToanBo)
    Me.Panel1.Controls.Add(Me.txtTenSach)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.btnTimSachTheoTheLoai)
    Me.Panel1.Controls.Add(Me.lblDongia)
    Me.Panel1.Controls.Add(Me.Label5)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.btnTimSachTheoTacGia)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1153, 407)
    Me.Panel1.TabIndex = 0
    '
    'btnMinimize
    '
    Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
    Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMinimize.Image = Global.DoAnNMCNPM.My.Resources.Resources.MINIMIZE
    Me.btnMinimize.Location = New System.Drawing.Point(1069, 12)
    Me.btnMinimize.Name = "btnMinimize"
    Me.btnMinimize.Size = New System.Drawing.Size(33, 33)
    Me.btnMinimize.TabIndex = 18
    Me.btnMinimize.UseVisualStyleBackColor = True
    '
    'txtSoLuongTon
    '
    Me.txtSoLuongTon.BackColor = System.Drawing.Color.LightGreen
    Me.txtSoLuongTon.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoLuongTon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoLuongTon.Location = New System.Drawing.Point(219, 284)
    Me.txtSoLuongTon.Multiline = True
    Me.txtSoLuongTon.Name = "txtSoLuongTon"
    Me.txtSoLuongTon.ReadOnly = True
    Me.txtSoLuongTon.Size = New System.Drawing.Size(405, 30)
    Me.txtSoLuongTon.TabIndex = 13
    '
    'btnThoat
    '
    Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
    Me.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnThoat.Image = Global.DoAnNMCNPM.My.Resources.Resources.SHUTDOWN
    Me.btnThoat.Location = New System.Drawing.Point(1108, 12)
    Me.btnThoat.Name = "btnThoat"
    Me.btnThoat.Size = New System.Drawing.Size(33, 33)
    Me.btnThoat.TabIndex = 19
    Me.btnThoat.UseVisualStyleBackColor = True
    '
    'txtTacGia
    '
    Me.txtTacGia.BackColor = System.Drawing.Color.LightGreen
    Me.txtTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtTacGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTacGia.Location = New System.Drawing.Point(219, 201)
    Me.txtTacGia.Multiline = True
    Me.txtTacGia.Name = "txtTacGia"
    Me.txtTacGia.Size = New System.Drawing.Size(405, 67)
    Me.txtTacGia.TabIndex = 10
    '
    'txtMaSach
    '
    Me.txtMaSach.BackColor = System.Drawing.Color.LightGreen
    Me.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaSach.Location = New System.Drawing.Point(219, 43)
    Me.txtMaSach.Multiline = True
    Me.txtMaSach.Name = "txtMaSach"
    Me.txtMaSach.Size = New System.Drawing.Size(405, 30)
    Me.txtMaSach.TabIndex = 1
    '
    'btnTimSach
    '
    Me.btnTimSach.BackgroundImage = CType(resources.GetObject("btnTimSach.BackgroundImage"), System.Drawing.Image)
    Me.btnTimSach.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimSach.ForeColor = System.Drawing.Color.White
    Me.btnTimSach.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimSach.Location = New System.Drawing.Point(640, 40)
    Me.btnTimSach.Name = "btnTimSach"
    Me.btnTimSach.Size = New System.Drawing.Size(404, 38)
    Me.btnTimSach.TabIndex = 2
    Me.btnTimSach.Text = "Tìm sách theo mã"
    Me.btnTimSach.UseVisualStyleBackColor = False
    '
    'btnLamMoiThongTin
    '
    Me.btnLamMoiThongTin.BackgroundImage = CType(resources.GetObject("btnLamMoiThongTin.BackgroundImage"), System.Drawing.Image)
    Me.btnLamMoiThongTin.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnLamMoiThongTin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnLamMoiThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLamMoiThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLamMoiThongTin.ForeColor = System.Drawing.Color.White
    Me.btnLamMoiThongTin.Image = Global.DoAnNMCNPM.My.Resources.Resources.CREATENEW
    Me.btnLamMoiThongTin.Location = New System.Drawing.Point(640, 284)
    Me.btnLamMoiThongTin.Name = "btnLamMoiThongTin"
    Me.btnLamMoiThongTin.Size = New System.Drawing.Size(199, 88)
    Me.btnLamMoiThongTin.TabIndex = 16
    Me.btnLamMoiThongTin.Text = "Làm mới thông tin chi tiết"
    Me.btnLamMoiThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.btnLamMoiThongTin.UseVisualStyleBackColor = False
    '
    'txtTheLoai
    '
    Me.txtTheLoai.BackColor = System.Drawing.Color.LightGreen
    Me.txtTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtTheLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTheLoai.Location = New System.Drawing.Point(219, 159)
    Me.txtTheLoai.Multiline = True
    Me.txtTheLoai.Name = "txtTheLoai"
    Me.txtTheLoai.Size = New System.Drawing.Size(405, 30)
    Me.txtTheLoai.TabIndex = 7
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(83, 43)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(87, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã sách"
    '
    'btnTimSachTheoTen
    '
    Me.btnTimSachTheoTen.BackgroundImage = CType(resources.GetObject("btnTimSachTheoTen.BackgroundImage"), System.Drawing.Image)
    Me.btnTimSachTheoTen.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimSachTheoTen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimSachTheoTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimSachTheoTen.ForeColor = System.Drawing.Color.White
    Me.btnTimSachTheoTen.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimSachTheoTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimSachTheoTen.Location = New System.Drawing.Point(640, 101)
    Me.btnTimSachTheoTen.Name = "btnTimSachTheoTen"
    Me.btnTimSachTheoTen.Size = New System.Drawing.Size(404, 38)
    Me.btnTimSachTheoTen.TabIndex = 5
    Me.btnTimSachTheoTen.Text = "Tìm sách theo tên"
    Me.btnTimSachTheoTen.UseVisualStyleBackColor = False
    '
    'btnToanBo
    '
    Me.btnToanBo.BackgroundImage = CType(resources.GetObject("btnToanBo.BackgroundImage"), System.Drawing.Image)
    Me.btnToanBo.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnToanBo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnToanBo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnToanBo.ForeColor = System.Drawing.Color.White
    Me.btnToanBo.Image = Global.DoAnNMCNPM.My.Resources.Resources.MENU
    Me.btnToanBo.Location = New System.Drawing.Point(845, 284)
    Me.btnToanBo.Name = "btnToanBo"
    Me.btnToanBo.Size = New System.Drawing.Size(199, 88)
    Me.btnToanBo.TabIndex = 17
    Me.btnToanBo.Text = "Hiển thị toàn bộ sách"
    Me.btnToanBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.btnToanBo.UseVisualStyleBackColor = False
    '
    'txtTenSach
    '
    Me.txtTenSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    Me.txtTenSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
    Me.txtTenSach.BackColor = System.Drawing.Color.LightGreen
    Me.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtTenSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTenSach.Location = New System.Drawing.Point(219, 85)
    Me.txtTenSach.Multiline = True
    Me.txtTenSach.Name = "txtTenSach"
    Me.txtTenSach.Size = New System.Drawing.Size(405, 68)
    Me.txtTenSach.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(83, 102)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(94, 25)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Tên sách"
    '
    'btnTimSachTheoTheLoai
    '
    Me.btnTimSachTheoTheLoai.BackgroundImage = CType(resources.GetObject("btnTimSachTheoTheLoai.BackgroundImage"), System.Drawing.Image)
    Me.btnTimSachTheoTheLoai.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimSachTheoTheLoai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimSachTheoTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimSachTheoTheLoai.ForeColor = System.Drawing.Color.White
    Me.btnTimSachTheoTheLoai.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimSachTheoTheLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimSachTheoTheLoai.Location = New System.Drawing.Point(640, 157)
    Me.btnTimSachTheoTheLoai.Name = "btnTimSachTheoTheLoai"
    Me.btnTimSachTheoTheLoai.Size = New System.Drawing.Size(404, 38)
    Me.btnTimSachTheoTheLoai.TabIndex = 8
    Me.btnTimSachTheoTheLoai.Text = "Tìm sách theo thể loại"
    Me.btnTimSachTheoTheLoai.UseVisualStyleBackColor = False
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.ForeColor = System.Drawing.Color.White
    Me.Label5.Location = New System.Drawing.Point(83, 284)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(122, 25)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "Số lượng tồn"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(83, 159)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(82, 25)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Thể loại"
    '
    'btnTimSachTheoTacGia
    '
    Me.btnTimSachTheoTacGia.BackgroundImage = CType(resources.GetObject("btnTimSachTheoTacGia.BackgroundImage"), System.Drawing.Image)
    Me.btnTimSachTheoTacGia.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnTimSachTheoTacGia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnTimSachTheoTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnTimSachTheoTacGia.ForeColor = System.Drawing.Color.White
    Me.btnTimSachTheoTacGia.Image = Global.DoAnNMCNPM.My.Resources.Resources.SEARCH
    Me.btnTimSachTheoTacGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnTimSachTheoTacGia.Location = New System.Drawing.Point(640, 212)
    Me.btnTimSachTheoTacGia.Name = "btnTimSachTheoTacGia"
    Me.btnTimSachTheoTacGia.Size = New System.Drawing.Size(404, 38)
    Me.btnTimSachTheoTacGia.TabIndex = 11
    Me.btnTimSachTheoTacGia.Text = "Tìm sách theo tác giả"
    Me.btnTimSachTheoTacGia.UseVisualStyleBackColor = False
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.ForeColor = System.Drawing.Color.White
    Me.Label4.Location = New System.Drawing.Point(83, 218)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(77, 25)
    Me.Label4.TabIndex = 9
    Me.Label4.Text = "Tác giả"
    '
    'lvData
    '
    Me.lvData.BackColor = System.Drawing.Color.LightGreen
    Me.lvData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lvData.FullRowSelect = True
    Me.lvData.GridLines = True
    Me.lvData.HideSelection = False
    Me.lvData.LargeImageList = Me.ImageList1
    Me.lvData.Location = New System.Drawing.Point(0, 0)
    Me.lvData.Name = "lvData"
    Me.lvData.Size = New System.Drawing.Size(1153, 257)
    Me.lvData.SmallImageList = Me.ImageList1
    Me.lvData.TabIndex = 2
    Me.lvData.UseCompatibleStateImageBehavior = False
    Me.lvData.View = System.Windows.Forms.View.Details
    '
    'lblDongia
    '
    Me.lblDongia.AutoSize = True
    Me.lblDongia.ForeColor = System.Drawing.Color.White
    Me.lblDongia.Location = New System.Drawing.Point(83, 337)
    Me.lblDongia.Name = "lblDongia"
    Me.lblDongia.Size = New System.Drawing.Size(79, 25)
    Me.lblDongia.TabIndex = 12
    Me.lblDongia.Text = "Đơn giá"
    '
    'txtDonGia
    '
    Me.txtDonGia.BackColor = System.Drawing.Color.LightGreen
    Me.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDonGia.Location = New System.Drawing.Point(219, 337)
    Me.txtDonGia.Multiline = True
    Me.txtDonGia.Name = "txtDonGia"
    Me.txtDonGia.ReadOnly = True
    Me.txtDonGia.Size = New System.Drawing.Size(405, 30)
    Me.txtDonGia.TabIndex = 13
    '
    'ManHinhTraCuuSach
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1153, 664)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhTraCuuSach"
    Me.Text = "Tra Cứu sách"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.Panel2.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Panel1 As Panel
  Friend WithEvents Panel2 As Panel
  Friend WithEvents btnTimSachTheoTacGia As Button
  Friend WithEvents btnTimSachTheoTheLoai As Button
  Friend WithEvents btnTimSachTheoTen As Button
  Friend WithEvents btnTimSach As Button
  Friend WithEvents txtSoLuongTon As TextBox
  Friend WithEvents txtTacGia As TextBox
  Friend WithEvents txtTheLoai As TextBox
  Friend WithEvents txtTenSach As TextBox
  Public WithEvents txtMaSach As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents btnToanBo As Button
  Friend WithEvents ImageList1 As ImageList
  Friend WithEvents btnLamMoiThongTin As Button
  Friend WithEvents btnMinimize As Button
  Friend WithEvents btnThoat As Button
  Friend WithEvents lvData As ListView
  Friend WithEvents txtDonGia As TextBox
  Friend WithEvents lblDongia As Label
End Class
