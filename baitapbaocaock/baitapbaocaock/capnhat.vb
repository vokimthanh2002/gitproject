Imports System.Data.OleDb
Public Class capnhat
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Dim constring As String = "Provider=SQLOLEDB.1;Data Source=DESKTOP-PFLQ46B\SQLEXPRESS;Initial Catalog=QLTSDH;User ID=sa;password=12345"
    Private con As OleDbConnection = New OleDbConnection(constring)

    Private Sub xuat_TaiKhoan()
        Dim lenh As String
        lenh = "select TenDangNhap,MatKhau from TaiKhoan"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("TaiKhoan")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid1.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat_TK()
        txt_tk.Text = danh_sach.Current("TenDangNhap")
        txt_mk.Text = danh_sach.Current("MatKhau")
    End Sub
    Private Sub danhsach_TK(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_TK()
    End Sub

    Private Sub capnhat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xuat_TaiKhoan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_tk.Text = ""
        txt_mk.Text = ""
        txt_tk.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_tk.Text = "" Or txt_mk.Text = "" Then
            MsgBox("Nhập đầy đủ thông tin")
        Else
            lenh = "Insert into TaiKhoan(TenDangNhap,MatKhau) values ('" & txt_tk.Text & "', '" & txt_mk.Text & "')"
            Dim cmd As New OleDbCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Bạn đã nhập thành công")
            xuat_TaiKhoan()
            danhsach_TK(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Bạn có muốn cập nhật không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cập nhật") = MsgBoxResult.Yes Then
            If txt_tk.Text = "" Or txt_mk.Text = "" Then
                MsgBox("Nhập đầy đủ thông tin")
            Else
                lenh = "Update TaiKhoan set MatKhau = '" & txt_mk.Text &
                        "' where TenDangNhap = '" & txt_tk.Text & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_TaiKhoan()
                MsgBox("Bạn đã cập nhật thành công!!!")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txt_tk.Text = "" Then
                MsgBox("Phải Chọn Giá Trị Cần Xóa !!!")
            Else
                lenh = "delete from  TaiKhoan where TenDangNhap= " & Trim(txt_tk.Text)
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_TaiKhoan()
                MsgBox("Xóa thành công")
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Bạn có muốn hủy thay đổi ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes Then
            txt_tk.Text = ""
            txt_mk.Text = ""

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Main.Show()
        Me.Hide()
    End Sub
End Class