<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhBaoCaoCongNo
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhBaoCaoCongNo))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtMaChiTietCongNo = New System.Windows.Forms.TextBox()
    Me.txtThang = New System.Windows.Forms.TextBox()
    Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
    Me.txtNoDau = New System.Windows.Forms.TextBox()
    Me.txtNoCuoi = New System.Windows.Forms.TextBox()
    Me.txtNoPhatSinh = New System.Windows.Forms.TextBox()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(42, 24)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(175, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã chi tiết công nợ"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(42, 67)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(69, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Tháng"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(42, 112)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(147, 25)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Mã khách hàng"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.ForeColor = System.Drawing.Color.White
    Me.Label4.Location = New System.Drawing.Point(42, 161)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(75, 25)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Nợ đầu"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.ForeColor = System.Drawing.Color.White
    Me.Label5.Location = New System.Drawing.Point(42, 208)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(78, 25)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Nợ cuối"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.ForeColor = System.Drawing.Color.White
    Me.Label6.Location = New System.Drawing.Point(42, 262)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(121, 25)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Nợ phát sinh"
    '
    'txtMaChiTietCongNo
    '
    Me.txtMaChiTietCongNo.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaChiTietCongNo.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaChiTietCongNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaChiTietCongNo.Location = New System.Drawing.Point(249, 24)
    Me.txtMaChiTietCongNo.Multiline = True
    Me.txtMaChiTietCongNo.Name = "txtMaChiTietCongNo"
    Me.txtMaChiTietCongNo.ReadOnly = True
    Me.txtMaChiTietCongNo.Size = New System.Drawing.Size(486, 30)
    Me.txtMaChiTietCongNo.TabIndex = 1
    '
    'txtThang
    '
    Me.txtThang.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtThang.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtThang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtThang.Location = New System.Drawing.Point(249, 67)
    Me.txtThang.Multiline = True
    Me.txtThang.Name = "txtThang"
    Me.txtThang.ReadOnly = True
    Me.txtThang.Size = New System.Drawing.Size(486, 30)
    Me.txtThang.TabIndex = 3
    '
    'txtMaKhachHang
    '
    Me.txtMaKhachHang.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaKhachHang.Location = New System.Drawing.Point(249, 112)
    Me.txtMaKhachHang.Multiline = True
    Me.txtMaKhachHang.Name = "txtMaKhachHang"
    Me.txtMaKhachHang.ReadOnly = True
    Me.txtMaKhachHang.Size = New System.Drawing.Size(486, 30)
    Me.txtMaKhachHang.TabIndex = 5
    '
    'txtNoDau
    '
    Me.txtNoDau.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtNoDau.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtNoDau.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNoDau.Location = New System.Drawing.Point(249, 161)
    Me.txtNoDau.Multiline = True
    Me.txtNoDau.Name = "txtNoDau"
    Me.txtNoDau.ReadOnly = True
    Me.txtNoDau.Size = New System.Drawing.Size(486, 30)
    Me.txtNoDau.TabIndex = 7
    '
    'txtNoCuoi
    '
    Me.txtNoCuoi.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtNoCuoi.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtNoCuoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNoCuoi.Location = New System.Drawing.Point(249, 203)
    Me.txtNoCuoi.Multiline = True
    Me.txtNoCuoi.Name = "txtNoCuoi"
    Me.txtNoCuoi.ReadOnly = True
    Me.txtNoCuoi.Size = New System.Drawing.Size(486, 30)
    Me.txtNoCuoi.TabIndex = 9
    '
    'txtNoPhatSinh
    '
    Me.txtNoPhatSinh.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtNoPhatSinh.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtNoPhatSinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNoPhatSinh.Location = New System.Drawing.Point(249, 257)
    Me.txtNoPhatSinh.Multiline = True
    Me.txtNoPhatSinh.Name = "txtNoPhatSinh"
    Me.txtNoPhatSinh.ReadOnly = True
    Me.txtNoPhatSinh.Size = New System.Drawing.Size(486, 30)
    Me.txtNoPhatSinh.TabIndex = 11
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
    Me.btnCapNhat.Location = New System.Drawing.Point(547, 308)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(188, 62)
    Me.btnCapNhat.TabIndex = 12
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = False
    '
    'ManHinhBaoCaoCongNo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.ManHinhNhoNew1
    Me.ClientSize = New System.Drawing.Size(803, 403)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.txtNoPhatSinh)
    Me.Controls.Add(Me.txtNoCuoi)
    Me.Controls.Add(Me.txtNoDau)
    Me.Controls.Add(Me.txtMaKhachHang)
    Me.Controls.Add(Me.txtThang)
    Me.Controls.Add(Me.txtMaChiTietCongNo)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhBaoCaoCongNo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Báo Cáo Công Nợ"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents btnCapNhat As Button
  Public WithEvents txtMaChiTietCongNo As TextBox
  Public WithEvents txtThang As TextBox
  Public WithEvents txtMaKhachHang As TextBox
  Public WithEvents txtNoDau As TextBox
  Public WithEvents txtNoCuoi As TextBox
  Public WithEvents txtNoPhatSinh As TextBox
End Class
