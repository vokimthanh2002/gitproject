Imports System.Data.OleDb
Public Class Login
    Dim Red, Blue, Green, Yellow As String
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Dim constring As String = "Provider=SQLOLEDB.1;Data Source=DESKTOP-PFLQ46B\SQLEXPRESS;Initial Catalog=QLTSDH;User ID=sa;password=12345"
    Private con As OleDbConnection = New OleDbConnection(constring)


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub btn_DangNhap_Click(sender As Object, e As EventArgs) Handles btn_DangNhap.Click
        If txt_user.Text = "" Then
            MsgBox("Hãy nhập tên đăng nhập")
        ElseIf txt_pass.Text = "" Then
            MsgBox("Hãy nhập mật khẩu")
        Else
            Dim lenh As String
            lenh = "select * from TaiKhoan where TenDangNhap = '" & txt_user.Text & "' and MatKhau = '" & txt_pass.Text & "'"
            Dim cmd As New OleDbCommand(lenh, con)
            con.Open()
            Dim doc_dl As OleDbDataReader = cmd.ExecuteReader

            If doc_dl.Read Then
                Main.Show()
                Me.Hide()
            Else
                MsgBox("Sai tài khoản và mật khẩu")
                txt_user.Text = ""
                txt_pass.Text = ""
            End If
            con.Close()
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CB_htmk.CheckedChanged
        If CB_htmk.Checked = True Then
            txt_pass.PasswordChar = ""
        Else
            txt_pass.PasswordChar = "*"
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Red = Int(Rnd() * 255)
        Green = Int(Rnd() * 255)
        Blue = Int(Rnd() * 255)
        Yellow = Int(Rnd() * 255)
        Label1.ForeColor = Color.FromArgb(Red, Green, Blue, Yellow)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
        ElseIf PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
            PictureBox1.Visible = True
        End If
    End Sub
End Class