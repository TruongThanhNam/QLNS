<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhPhieuHoaDon
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhPhieuHoaDon))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtMaPhieuHoaDon = New System.Windows.Forms.TextBox()
    Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.dtNgayLap = New System.Windows.Forms.DateTimePicker()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(77, 74)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(169, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã phiếu hóa đơn"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(77, 127)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(147, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Mã khách hàng"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(77, 182)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(165, 25)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Ngày lập hóa đơn"
    '
    'txtMaPhieuHoaDon
    '
    Me.txtMaPhieuHoaDon.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaPhieuHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaPhieuHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaPhieuHoaDon.Location = New System.Drawing.Point(274, 71)
    Me.txtMaPhieuHoaDon.Multiline = True
    Me.txtMaPhieuHoaDon.Name = "txtMaPhieuHoaDon"
    Me.txtMaPhieuHoaDon.ReadOnly = True
    Me.txtMaPhieuHoaDon.Size = New System.Drawing.Size(469, 30)
    Me.txtMaPhieuHoaDon.TabIndex = 1
    '
    'txtMaKhachHang
    '
    Me.txtMaKhachHang.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaKhachHang.Location = New System.Drawing.Point(274, 127)
    Me.txtMaKhachHang.Multiline = True
    Me.txtMaKhachHang.Name = "txtMaKhachHang"
    Me.txtMaKhachHang.ReadOnly = True
    Me.txtMaKhachHang.Size = New System.Drawing.Size(469, 30)
    Me.txtMaKhachHang.TabIndex = 3
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
    Me.btnCapNhat.Location = New System.Drawing.Point(555, 303)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(188, 62)
    Me.btnCapNhat.TabIndex = 6
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = False
    '
    'dtNgayLap
    '
    Me.dtNgayLap.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayLap.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayLap.CalendarTitleForeColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.dtNgayLap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtNgayLap.Location = New System.Drawing.Point(274, 182)
    Me.dtNgayLap.Name = "dtNgayLap"
    Me.dtNgayLap.Size = New System.Drawing.Size(469, 30)
    Me.dtNgayLap.TabIndex = 5
    '
    'ManHinhPhieuHoaDon
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.ManHinhNhoNew1
    Me.ClientSize = New System.Drawing.Size(803, 403)
    Me.Controls.Add(Me.dtNgayLap)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.txtMaKhachHang)
    Me.Controls.Add(Me.txtMaPhieuHoaDon)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhPhieuHoaDon"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Phiếu Hóa Đơn"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents btnCapNhat As Button
  Public WithEvents txtMaPhieuHoaDon As TextBox
  Public WithEvents txtMaKhachHang As TextBox
  Public WithEvents dtNgayLap As DateTimePicker
End Class
