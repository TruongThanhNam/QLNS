<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhDangKyTaiKhoan
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhDangKyTaiKhoan))
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.btnThoat = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.txtMatKhau = New System.Windows.Forms.TextBox()
    Me.txtTen = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Transparent
    Me.Panel1.Controls.Add(Me.btnThoat)
    Me.Panel1.Controls.Add(Me.Button1)
    Me.Panel1.Controls.Add(Me.txtTen)
    Me.Panel1.Controls.Add(Me.txtMatKhau)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(803, 403)
    Me.Panel1.TabIndex = 0
    '
    'btnThoat
    '
    Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
    Me.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnThoat.Image = Global.DoAnNMCNPM.My.Resources.Resources.SHUTDOWN
    Me.btnThoat.Location = New System.Drawing.Point(758, 12)
    Me.btnThoat.Name = "btnThoat"
    Me.btnThoat.Size = New System.Drawing.Size(33, 33)
    Me.btnThoat.TabIndex = 5
    Me.btnThoat.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.buttonmanhinhnhonew1
    Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Button1.ForeColor = System.Drawing.Color.White
    Me.Button1.Image = Global.DoAnNMCNPM.My.Resources.Resources.UPDATE
    Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Button1.Location = New System.Drawing.Point(552, 308)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(188, 62)
    Me.Button1.TabIndex = 4
    Me.Button1.Text = "Cập nhật"
    Me.Button1.UseVisualStyleBackColor = False
    '
    'txtMatKhau
    '
    Me.txtMatKhau.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMatKhau.Location = New System.Drawing.Point(175, 163)
    Me.txtMatKhau.Multiline = True
    Me.txtMatKhau.Name = "txtMatKhau"
    Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtMatKhau.Size = New System.Drawing.Size(565, 30)
    Me.txtMatKhau.TabIndex = 3
    '
    'txtTen
    '
    Me.txtTen.BackColor = System.Drawing.Color.LightSkyBlue
    Me.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtTen.Location = New System.Drawing.Point(175, 106)
    Me.txtTen.Multiline = True
    Me.txtTen.Name = "txtTen"
    Me.txtTen.Size = New System.Drawing.Size(565, 30)
    Me.txtTen.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(57, 168)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(93, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Mật khẩu"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(57, 106)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(47, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tên"
    '
    'ManHinhDangKyTaiKhoan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.ManHinhNhoNew1
    Me.ClientSize = New System.Drawing.Size(803, 403)
    Me.Controls.Add(Me.Panel1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhDangKyTaiKhoan"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Đăng ký tài khoản"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Panel1 As Panel
  Friend WithEvents Button1 As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Public WithEvents txtMatKhau As TextBox
  Public WithEvents txtTen As TextBox
  Friend WithEvents btnThoat As Button
End Class
