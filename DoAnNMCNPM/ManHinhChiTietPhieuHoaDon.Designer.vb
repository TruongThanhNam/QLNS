<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManHinhChiTietPhieuHoaDon
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhChiTietPhieuHoaDon))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtMaChiTietPhieuHoaDon = New System.Windows.Forms.TextBox()
    Me.txtMaPhieuHoaDon = New System.Windows.Forms.TextBox()
    Me.txtMaSach = New System.Windows.Forms.TextBox()
    Me.txtSoLuongBan = New System.Windows.Forms.TextBox()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(59, 36)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(229, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã chi tiết phiếu hóa đơn"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(59, 85)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(169, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Mã phiếu hóa đơn"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(59, 134)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(87, 25)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Mã sách"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Location = New System.Drawing.Point(59, 189)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(128, 25)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Số lượng bán"
    '
    'txtMaChiTietPhieuHoaDon
    '
    Me.txtMaChiTietPhieuHoaDon.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaChiTietPhieuHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaChiTietPhieuHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaChiTietPhieuHoaDon.Location = New System.Drawing.Point(316, 36)
    Me.txtMaChiTietPhieuHoaDon.Multiline = True
    Me.txtMaChiTietPhieuHoaDon.Name = "txtMaChiTietPhieuHoaDon"
    Me.txtMaChiTietPhieuHoaDon.ReadOnly = True
    Me.txtMaChiTietPhieuHoaDon.Size = New System.Drawing.Size(438, 30)
    Me.txtMaChiTietPhieuHoaDon.TabIndex = 1
    '
    'txtMaPhieuHoaDon
    '
    Me.txtMaPhieuHoaDon.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaPhieuHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaPhieuHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaPhieuHoaDon.Location = New System.Drawing.Point(316, 85)
    Me.txtMaPhieuHoaDon.Multiline = True
    Me.txtMaPhieuHoaDon.Name = "txtMaPhieuHoaDon"
    Me.txtMaPhieuHoaDon.ReadOnly = True
    Me.txtMaPhieuHoaDon.Size = New System.Drawing.Size(438, 30)
    Me.txtMaPhieuHoaDon.TabIndex = 3
    '
    'txtMaSach
    '
    Me.txtMaSach.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaSach.Location = New System.Drawing.Point(316, 134)
    Me.txtMaSach.Multiline = True
    Me.txtMaSach.Name = "txtMaSach"
    Me.txtMaSach.Size = New System.Drawing.Size(438, 30)
    Me.txtMaSach.TabIndex = 5
    '
    'txtSoLuongBan
    '
    Me.txtSoLuongBan.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtSoLuongBan.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoLuongBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoLuongBan.Location = New System.Drawing.Point(316, 186)
    Me.txtSoLuongBan.Multiline = True
    Me.txtSoLuongBan.Name = "txtSoLuongBan"
    Me.txtSoLuongBan.Size = New System.Drawing.Size(438, 30)
    Me.txtSoLuongBan.TabIndex = 7
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
    Me.btnCapNhat.Location = New System.Drawing.Point(565, 295)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(188, 62)
    Me.btnCapNhat.TabIndex = 8
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = False
    '
    'ManHinhChiTietPhieuHoaDon
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.ManHinhNhoNew1
    Me.ClientSize = New System.Drawing.Size(803, 403)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.txtSoLuongBan)
    Me.Controls.Add(Me.txtMaSach)
    Me.Controls.Add(Me.txtMaPhieuHoaDon)
    Me.Controls.Add(Me.txtMaChiTietPhieuHoaDon)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ForeColor = System.Drawing.Color.White
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhChiTietPhieuHoaDon"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Chi Tiết Phiếu Hóa Đơn"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Public WithEvents txtMaChiTietPhieuHoaDon As TextBox
  Public WithEvents txtMaPhieuHoaDon As TextBox
  Public WithEvents txtMaSach As TextBox
  Public WithEvents txtSoLuongBan As TextBox
  Friend WithEvents btnCapNhat As Button
End Class
