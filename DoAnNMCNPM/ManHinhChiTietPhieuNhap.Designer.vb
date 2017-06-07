<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhChiTietPhieuNhap
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhChiTietPhieuNhap))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtMaChiTietPhieuNhap = New System.Windows.Forms.TextBox()
    Me.txtMaPhieuNhap = New System.Windows.Forms.TextBox()
    Me.txtMaSach = New System.Windows.Forms.TextBox()
    Me.txtSoLuongNhap = New System.Windows.Forms.TextBox()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(39, 49)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(202, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã chi tiết phiếu nhập"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(39, 154)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(87, 25)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Mã sách"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(39, 208)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(139, 25)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Số lượng nhập"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.ForeColor = System.Drawing.Color.White
    Me.Label4.Location = New System.Drawing.Point(39, 101)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(142, 25)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Mã phiếu nhập"
    '
    'txtMaChiTietPhieuNhap
    '
    Me.txtMaChiTietPhieuNhap.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaChiTietPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaChiTietPhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaChiTietPhieuNhap.Location = New System.Drawing.Point(259, 46)
    Me.txtMaChiTietPhieuNhap.Multiline = True
    Me.txtMaChiTietPhieuNhap.Name = "txtMaChiTietPhieuNhap"
    Me.txtMaChiTietPhieuNhap.ReadOnly = True
    Me.txtMaChiTietPhieuNhap.Size = New System.Drawing.Size(489, 30)
    Me.txtMaChiTietPhieuNhap.TabIndex = 1
    '
    'txtMaPhieuNhap
    '
    Me.txtMaPhieuNhap.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaPhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaPhieuNhap.Location = New System.Drawing.Point(259, 98)
    Me.txtMaPhieuNhap.Multiline = True
    Me.txtMaPhieuNhap.Name = "txtMaPhieuNhap"
    Me.txtMaPhieuNhap.ReadOnly = True
    Me.txtMaPhieuNhap.Size = New System.Drawing.Size(489, 30)
    Me.txtMaPhieuNhap.TabIndex = 3
    '
    'txtMaSach
    '
    Me.txtMaSach.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMaSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMaSach.Location = New System.Drawing.Point(259, 151)
    Me.txtMaSach.Multiline = True
    Me.txtMaSach.Name = "txtMaSach"
    Me.txtMaSach.Size = New System.Drawing.Size(489, 30)
    Me.txtMaSach.TabIndex = 5
    '
    'txtSoLuongNhap
    '
    Me.txtSoLuongNhap.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtSoLuongNhap.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSoLuongNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSoLuongNhap.Location = New System.Drawing.Point(259, 203)
    Me.txtSoLuongNhap.Multiline = True
    Me.txtSoLuongNhap.Name = "txtSoLuongNhap"
    Me.txtSoLuongNhap.Size = New System.Drawing.Size(489, 30)
    Me.txtSoLuongNhap.TabIndex = 7
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
    Me.btnCapNhat.Location = New System.Drawing.Point(560, 301)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(188, 62)
    Me.btnCapNhat.TabIndex = 8
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = False
    '
    'ManHinhChiTietPhieuNhap
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.ManHinhNhoNew1
    Me.ClientSize = New System.Drawing.Size(803, 403)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.txtSoLuongNhap)
    Me.Controls.Add(Me.txtMaSach)
    Me.Controls.Add(Me.txtMaPhieuNhap)
    Me.Controls.Add(Me.txtMaChiTietPhieuNhap)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ForeColor = System.Drawing.Color.Yellow
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhChiTietPhieuNhap"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Chi Tiết Phiếu Nhập"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents txtMaChiTietPhieuNhap As TextBox
  Friend WithEvents txtMaPhieuNhap As TextBox
  Friend WithEvents txtMaSach As TextBox
  Friend WithEvents txtSoLuongNhap As TextBox
  Friend WithEvents btnCapNhat As Button
End Class
