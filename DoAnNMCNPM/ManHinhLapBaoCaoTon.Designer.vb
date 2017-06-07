<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhLapBaoCaoTon
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhLapBaoCaoTon))
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.lvDaTa = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.btnMinimize = New System.Windows.Forms.Button()
    Me.btnThoat = New System.Windows.Forms.Button()
    Me.btnIn = New System.Windows.Forms.Button()
    Me.btnHienThiTatCa = New System.Windows.Forms.Button()
    Me.txtTenSach = New System.Windows.Forms.TextBox()
    Me.cboThangCanLapBaoCao = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.lvDaTa)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.Location = New System.Drawing.Point(0, 267)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(965, 606)
    Me.Panel1.TabIndex = 0
    '
    'lvDaTa
    '
    Me.lvDaTa.BackColor = System.Drawing.Color.Aqua
    Me.lvDaTa.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lvDaTa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
    Me.lvDaTa.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvDaTa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lvDaTa.FullRowSelect = True
    Me.lvDaTa.GridLines = True
    Me.lvDaTa.HideSelection = False
    Me.lvDaTa.LargeImageList = Me.ImageList1
    Me.lvDaTa.Location = New System.Drawing.Point(0, 0)
    Me.lvDaTa.Name = "lvDaTa"
    Me.lvDaTa.Size = New System.Drawing.Size(965, 606)
    Me.lvDaTa.SmallImageList = Me.ImageList1
    Me.lvDaTa.TabIndex = 0
    Me.lvDaTa.UseCompatibleStateImageBehavior = False
    Me.lvDaTa.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Mã chi tiết tồn"
    Me.ColumnHeader1.Width = 300
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Tháng"
    Me.ColumnHeader2.Width = 200
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Mã sách"
    Me.ColumnHeader3.Width = 300
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Tồn đầu"
    Me.ColumnHeader4.Width = 300
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Text = "Tồn phát sinh"
    Me.ColumnHeader5.Width = 300
    '
    'ColumnHeader6
    '
    Me.ColumnHeader6.Text = "Tồn cuối"
    Me.ColumnHeader6.Width = 300
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "4-yeu-to-quan-trong-trong-quan-ly-hang-ton-kho-1-2.png")
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.Color.Transparent
    Me.Panel2.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.manhinhlapbaocaoton
    Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.Panel2.Controls.Add(Me.btnMinimize)
    Me.Panel2.Controls.Add(Me.btnThoat)
    Me.Panel2.Controls.Add(Me.btnIn)
    Me.Panel2.Controls.Add(Me.btnHienThiTatCa)
    Me.Panel2.Controls.Add(Me.txtTenSach)
    Me.Panel2.Controls.Add(Me.cboThangCanLapBaoCao)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(965, 267)
    Me.Panel2.TabIndex = 0
    '
    'btnMinimize
    '
    Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
    Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMinimize.Image = Global.DoAnNMCNPM.My.Resources.Resources.MINIMIZE
    Me.btnMinimize.Location = New System.Drawing.Point(883, 12)
    Me.btnMinimize.Name = "btnMinimize"
    Me.btnMinimize.Size = New System.Drawing.Size(33, 33)
    Me.btnMinimize.TabIndex = 6
    Me.btnMinimize.UseVisualStyleBackColor = True
    '
    'btnThoat
    '
    Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
    Me.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnThoat.Image = Global.DoAnNMCNPM.My.Resources.Resources.SHUTDOWN
    Me.btnThoat.Location = New System.Drawing.Point(922, 12)
    Me.btnThoat.Name = "btnThoat"
    Me.btnThoat.Size = New System.Drawing.Size(33, 33)
    Me.btnThoat.TabIndex = 7
    Me.btnThoat.UseVisualStyleBackColor = True
    '
    'btnIn
    '
    Me.btnIn.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.buttonmanhinhlapcaoton
    Me.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnIn.ForeColor = System.Drawing.Color.White
    Me.btnIn.Image = Global.DoAnNMCNPM.My.Resources.Resources.MAYIn2HAIMANHINHBAOCAO
    Me.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnIn.Location = New System.Drawing.Point(399, 166)
    Me.btnIn.Name = "btnIn"
    Me.btnIn.Size = New System.Drawing.Size(217, 69)
    Me.btnIn.TabIndex = 4
    Me.btnIn.Text = "In Báo Cáo"
    Me.btnIn.UseVisualStyleBackColor = False
    '
    'btnHienThiTatCa
    '
    Me.btnHienThiTatCa.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.buttonmanhinhlapcaoton
    Me.btnHienThiTatCa.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnHienThiTatCa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnHienThiTatCa.ForeColor = System.Drawing.Color.White
    Me.btnHienThiTatCa.Image = Global.DoAnNMCNPM.My.Resources.Resources.MENU
    Me.btnHienThiTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnHienThiTatCa.Location = New System.Drawing.Point(638, 166)
    Me.btnHienThiTatCa.Name = "btnHienThiTatCa"
    Me.btnHienThiTatCa.Size = New System.Drawing.Size(217, 69)
    Me.btnHienThiTatCa.TabIndex = 5
    Me.btnHienThiTatCa.Text = " Hiển thị tất cả"
    Me.btnHienThiTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnHienThiTatCa.UseVisualStyleBackColor = False
    '
    'txtTenSach
    '
    Me.txtTenSach.BackColor = System.Drawing.Color.Aqua
    Me.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtTenSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTenSach.Location = New System.Drawing.Point(399, 113)
    Me.txtTenSach.Multiline = True
    Me.txtTenSach.Name = "txtTenSach"
    Me.txtTenSach.Size = New System.Drawing.Size(456, 30)
    Me.txtTenSach.TabIndex = 3
    '
    'cboThangCanLapBaoCao
    '
    Me.cboThangCanLapBaoCao.BackColor = System.Drawing.Color.Aqua
    Me.cboThangCanLapBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cboThangCanLapBaoCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboThangCanLapBaoCao.FormattingEnabled = True
    Me.cboThangCanLapBaoCao.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
    Me.cboThangCanLapBaoCao.Location = New System.Drawing.Point(399, 56)
    Me.cboThangCanLapBaoCao.Name = "cboThangCanLapBaoCao"
    Me.cboThangCanLapBaoCao.Size = New System.Drawing.Size(456, 33)
    Me.cboThangCanLapBaoCao.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(150, 113)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(94, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Tên sách"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(150, 56)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(212, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tháng cần lập báo cáo"
    '
    'ManHinhLapBaoCaoTon
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(965, 873)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.DoubleBuffered = True
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhLapBaoCaoTon"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Lập Báo Cáo Tồn"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.Panel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Panel1 As Panel
  Friend WithEvents lvDaTa As ListView
  Friend WithEvents ColumnHeader1 As ColumnHeader
  Friend WithEvents ColumnHeader2 As ColumnHeader
  Friend WithEvents ColumnHeader3 As ColumnHeader
  Friend WithEvents ColumnHeader4 As ColumnHeader
  Friend WithEvents ColumnHeader5 As ColumnHeader
  Friend WithEvents ColumnHeader6 As ColumnHeader
  Friend WithEvents Panel2 As Panel
  Friend WithEvents btnHienThiTatCa As Button
  Friend WithEvents txtTenSach As TextBox
  Friend WithEvents cboThangCanLapBaoCao As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents btnIn As Button
  Friend WithEvents ImageList1 As ImageList
  Friend WithEvents btnMinimize As Button
  Friend WithEvents btnThoat As Button
End Class
