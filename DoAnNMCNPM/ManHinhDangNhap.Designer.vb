<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManHinhDangNhap
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHinhDangNhap))
    Me.txtMatKhau = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.ckNhoMatKhau = New System.Windows.Forms.CheckBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnDangNhap = New System.Windows.Forms.Button()
    Me.cboTen = New System.Windows.Forms.ComboBox()
    Me.btnDangKy = New System.Windows.Forms.Button()
    Me.btnDoiMatKhau = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnThoat = New System.Windows.Forms.Button()
    Me.btnMinimize = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'txtMatKhau
    '
    Me.txtMatKhau.BackColor = System.Drawing.Color.MediumAquamarine
    Me.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMatKhau.Location = New System.Drawing.Point(547, 202)
    Me.txtMatKhau.Multiline = True
    Me.txtMatKhau.Name = "txtMatKhau"
    Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtMatKhau.Size = New System.Drawing.Size(303, 30)
    Me.txtMatKhau.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(425, 202)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(105, 25)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Mật Khẩu"
    '
    'ckNhoMatKhau
    '
    Me.ckNhoMatKhau.AutoSize = True
    Me.ckNhoMatKhau.BackColor = System.Drawing.Color.Transparent
    Me.ckNhoMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ckNhoMatKhau.ForeColor = System.Drawing.Color.White
    Me.ckNhoMatKhau.Location = New System.Drawing.Point(547, 249)
    Me.ckNhoMatKhau.Name = "ckNhoMatKhau"
    Me.ckNhoMatKhau.Size = New System.Drawing.Size(164, 29)
    Me.ckNhoMatKhau.TabIndex = 4
    Me.ckNhoMatKhau.Text = "Nhớ mật khẩu"
    Me.ckNhoMatKhau.UseVisualStyleBackColor = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(425, 147)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(50, 25)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Tên"
    '
    'btnDangNhap
    '
    Me.btnDangNhap.BackgroundImage = CType(resources.GetObject("btnDangNhap.BackgroundImage"), System.Drawing.Image)
    Me.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDangNhap.ForeColor = System.Drawing.Color.White
    Me.btnDangNhap.Location = New System.Drawing.Point(430, 301)
    Me.btnDangNhap.Name = "btnDangNhap"
    Me.btnDangNhap.Size = New System.Drawing.Size(136, 51)
    Me.btnDangNhap.TabIndex = 5
    Me.btnDangNhap.Text = "Đăng nhập"
    Me.btnDangNhap.UseVisualStyleBackColor = False
    '
    'cboTen
    '
    Me.cboTen.BackColor = System.Drawing.Color.MediumAquamarine
    Me.cboTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cboTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTen.FormattingEnabled = True
    Me.cboTen.Location = New System.Drawing.Point(547, 144)
    Me.cboTen.Name = "cboTen"
    Me.cboTen.Size = New System.Drawing.Size(303, 33)
    Me.cboTen.TabIndex = 1
    '
    'btnDangKy
    '
    Me.btnDangKy.BackgroundImage = CType(resources.GetObject("btnDangKy.BackgroundImage"), System.Drawing.Image)
    Me.btnDangKy.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnDangKy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnDangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDangKy.ForeColor = System.Drawing.Color.White
    Me.btnDangKy.Location = New System.Drawing.Point(573, 301)
    Me.btnDangKy.Name = "btnDangKy"
    Me.btnDangKy.Size = New System.Drawing.Size(136, 51)
    Me.btnDangKy.TabIndex = 6
    Me.btnDangKy.Text = "Đăng ký"
    Me.btnDangKy.UseVisualStyleBackColor = False
    '
    'btnDoiMatKhau
    '
    Me.btnDoiMatKhau.BackgroundImage = CType(resources.GetObject("btnDoiMatKhau.BackgroundImage"), System.Drawing.Image)
    Me.btnDoiMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.Black
    Me.btnDoiMatKhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
    Me.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnDoiMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDoiMatKhau.ForeColor = System.Drawing.Color.White
    Me.btnDoiMatKhau.Location = New System.Drawing.Point(714, 301)
    Me.btnDoiMatKhau.Name = "btnDoiMatKhau"
    Me.btnDoiMatKhau.Size = New System.Drawing.Size(136, 51)
    Me.btnDoiMatKhau.TabIndex = 7
    Me.btnDoiMatKhau.Text = "Bảo mật"
    Me.btnDoiMatKhau.UseVisualStyleBackColor = False
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Font = New System.Drawing.Font("Perpetua", 35.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(881, 113)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "NHÀ SÁCH HYDRA"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'btnThoat
    '
    Me.btnThoat.BackColor = System.Drawing.Color.Transparent
    Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
    Me.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnThoat.Image = Global.DoAnNMCNPM.My.Resources.Resources.SHUTDOWN
    Me.btnThoat.Location = New System.Drawing.Point(836, 12)
    Me.btnThoat.Name = "btnThoat"
    Me.btnThoat.Size = New System.Drawing.Size(33, 33)
    Me.btnThoat.TabIndex = 2
    Me.btnThoat.UseVisualStyleBackColor = False
    '
    'btnMinimize
    '
    Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
    Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
    Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMinimize.Image = Global.DoAnNMCNPM.My.Resources.Resources.MINIMIZE
    Me.btnMinimize.Location = New System.Drawing.Point(797, 12)
    Me.btnMinimize.Name = "btnMinimize"
    Me.btnMinimize.Size = New System.Drawing.Size(33, 33)
    Me.btnMinimize.TabIndex = 1
    Me.btnMinimize.UseVisualStyleBackColor = False
    '
    'ManHinhDangNhap
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.DoAnNMCNPM.My.Resources.Resources.HINHNENHYDRANEW4
    Me.ClientSize = New System.Drawing.Size(881, 443)
    Me.Controls.Add(Me.btnMinimize)
    Me.Controls.Add(Me.btnDoiMatKhau)
    Me.Controls.Add(Me.btnThoat)
    Me.Controls.Add(Me.btnDangKy)
    Me.Controls.Add(Me.cboTen)
    Me.Controls.Add(Me.btnDangNhap)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtMatKhau)
    Me.Controls.Add(Me.ckNhoMatKhau)
    Me.Controls.Add(Me.Label3)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhDangNhap"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Đăng Nhập"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtMatKhau As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents ckNhoMatKhau As CheckBox
  Friend WithEvents Label2 As Label
  Friend WithEvents btnDangNhap As Button
  Friend WithEvents cboTen As ComboBox
  Friend WithEvents btnDangKy As Button
  Friend WithEvents btnDoiMatKhau As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents btnThoat As Button
  Friend WithEvents btnMinimize As Button
End Class
