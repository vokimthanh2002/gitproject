<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.CB_htmk = New System.Windows.Forms.CheckBox()
        Me.btn_DangNhap = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.baitapbaocaock.My.Resources.Resources.nen5
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(995, 358)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.baitapbaocaock.My.Resources.Resources.nenn3
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(995, 358)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.baitapbaocaock.My.Resources.Resources.nen1
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(995, 358)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 377)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "QUẢN LÝ TUYỂN SINH ĐẠI HỌC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(260, 430)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TÊN ĐĂNG NHẬP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(261, 497)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MẬT KHẨU"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(501, 431)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(198, 25)
        Me.txt_user.TabIndex = 7
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(502, 500)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(198, 25)
        Me.txt_pass.TabIndex = 8
        '
        'CB_htmk
        '
        Me.CB_htmk.AutoSize = True
        Me.CB_htmk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_htmk.Location = New System.Drawing.Point(425, 552)
        Me.CB_htmk.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CB_htmk.Name = "CB_htmk"
        Me.CB_htmk.Size = New System.Drawing.Size(161, 22)
        Me.CB_htmk.TabIndex = 9
        Me.CB_htmk.Text = "Hiển thị mật khẩu"
        Me.CB_htmk.UseVisualStyleBackColor = True
        '
        'btn_DangNhap
        '
        Me.btn_DangNhap.BackColor = System.Drawing.Color.Lime
        Me.btn_DangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DangNhap.ForeColor = System.Drawing.Color.Red
        Me.btn_DangNhap.Location = New System.Drawing.Point(425, 610)
        Me.btn_DangNhap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_DangNhap.Name = "btn_DangNhap"
        Me.btn_DangNhap.Size = New System.Drawing.Size(166, 35)
        Me.btn_DangNhap.TabIndex = 10
        Me.btn_DangNhap.Text = "ĐĂNG NHẬP"
        Me.btn_DangNhap.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(991, 688)
        Me.Controls.Add(Me.btn_DangNhap)
        Me.Controls.Add(Me.CB_htmk)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Login"
        Me.Text = "FormDangNhap"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents CB_htmk As CheckBox
    Friend WithEvents btn_DangNhap As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
