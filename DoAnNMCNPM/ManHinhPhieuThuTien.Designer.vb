<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhPhieuThuTien
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhPhieuThuTien))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtMaPhieuThu = New System.Windows.Forms.TextBox()
    Me.txtSoTienThu = New System.Windows.Forms.TextBox()
    Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.dtNgayThuTien = New System.Windows.Forms.DateTimePicker()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(65, 48)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(125, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã phiếu thu"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(65, 99)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(105, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Số tiền thu"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(65, 150)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(126, 25)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Ngày thu tiền"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.ForeColor = System.Drawing.Color.White
    Me.Label4.Location = New System.Drawing.Point(65, 209)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(152, 25)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Mã khách  hàng"
    '
    'txtMaPhieuThu
    '
    Me.txtMaPhieuThu.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaPhieuThu.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaPhieuThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaPhieuThu.Location = New System.Drawing.Point(230, 48)
    Me.txtMaPhieuThu.Multiline = True
    Me.txtMaPhieuThu.Name = "txtMaPhieuThu"
    Me.txtMaPhieuThu.ReadOnly = True
    Me.txtMaPhieuThu.Size = New System.Drawing.Size(509, 30)
    Me.txtMaPhieuThu.TabIndex = 1
    '
    'txtSoTienThu
    '
    Me.txtSoTienThu.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtSoTienThu.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoTienThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoTienThu.Location = New System.Drawing.Point(230, 96)
    Me.txtSoTienThu.Multiline = True
    Me.txtSoTienThu.Name = "txtSoTienThu"
    Me.txtSoTienThu.ReadOnly = True
    Me.txtSoTienThu.Size = New System.Drawing.Size(509, 30)
    Me.txtSoTienThu.TabIndex = 3
    '
    'txtMaKhachHang
    '
    Me.txtMaKhachHang.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaKhachHang.Location = New System.Drawing.Point(230, 204)
    Me.txtMaKhachHang.Multiline = True
    Me.txtMaKhachHang.Name = "txtMaKhachHang"
    Me.txtMaKhachHang.ReadOnly = True
    Me.txtMaKhachHang.Size = New System.Drawing.Size(509, 30)
    Me.txtMaKhachHang.TabIndex = 7
    '
    'btnCapNhat
    '
    Me.btnCapNhat.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.buttonmanhinhnhonew1
    Me.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnCapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCapNhat.ForeColor = System.Drawing.Color.White
    Me.btnCapNhat.Image = Global.DoAnNMCNPM.My.Resources.Resources.UPDATE
    Me.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCapNhat.Location = New System.Drawing.Point(551, 303)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(188, 62)
    Me.btnCapNhat.TabIndex = 8
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = False
    '
    'dtNgayThuTien
    '
    Me.dtNgayThuTien.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayThuTien.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayThuTien.CalendarTitleForeColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayThuTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtNgayThuTien.Location = New System.Drawing.Point(230, 150)
    Me.dtNgayThuTien.Name = "dtNgayThuTien"
    Me.dtNgayThuTien.Size = New System.Drawing.Size(509, 30)
    Me.dtNgayThuTien.TabIndex = 5
    '
    'ManHinhPhieuThuTien
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.ManHinhNhoNew1
    Me.ClientSize = New System.Drawing.Size(803, 403)
    Me.Controls.Add(Me.dtNgayThuTien)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.txtMaKhachHang)
    Me.Controls.Add(Me.txtSoTienThu)
    Me.Controls.Add(Me.txtMaPhieuThu)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.DoubleBuffered = True
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhPhieuThuTien"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Phiếu Thu Tiền"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents btnCapNhat As Button
  Public WithEvents txtMaPhieuThu As TextBox
  Public WithEvents txtSoTienThu As TextBox
  Public WithEvents txtMaKhachHang As TextBox
  Public WithEvents dtNgayThuTien As DateTimePicker
End Class
