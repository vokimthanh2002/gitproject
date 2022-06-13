Imports System.Data.OleDb
Public Class Main
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Dim constring As String = "Provider=SQLOLEDB.1;Data Source=DESKTOP-PFLQ46B\SQLEXPRESS;Initial Catalog=QLTSDH;User ID=sa;password=12345"
    Private con As OleDbConnection = New OleDbConnection(constring)

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_Trangchu.Visible = True
        Panel_QLSV.Visible = False
        Panel_QLD.Visible = False
        Xuat_Nganh()
        Dim a%
        For I = 0 To danh_sach.Count - 1
            a = 0
            danh_sach.Position = I
            For Each ds In Cb_timkiem.Items
                If ds = danh_sach.Current("Nganh") Then
                    a += 1
                End If
            Next
            If a = 0 Then
                Cb_timkiem.Items.Add(danh_sach.Current("Nganh"))
                cb_timkiemd.Items.Add(danh_sach.Current("Nganh"))
            End If
        Next
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub xuat_nganh()
        Dim lenh As String
        lenh = "select nganh from HOSOTHISINH"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("HOSOTHISINH")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid1.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub

    Private Sub Xuat_Diem()
        Dim lenh As String
        lenh = "select SBD,Khoi, Diem1,Diem2,Diem3, (Diem1 +Diem2 +Diem3)as DiemTong
        from  DIEM AS D"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("DIEM")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid2.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub

    Private Sub Xuat_SinhVien()
        Dim lenh As String
        lenh = "select * from HOSOTHISINH"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("HOSOTHISINH")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid1.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub

    Private Sub Xuat_SinhVienTT()
        Dim lenh As String
        lenh = "select *,(Diem1 +Diem2 +Diem3)as DiemTong 
            from HOSOTHISINH as th,DIEM  as  DM
            where th.SBD = DM.SBD and (Diem1 +Diem2 +Diem3) >=21"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("HOSOTHISINH")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid1.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub

    Private Sub Xuat_SinhVienKTT()
        Dim lenh As String
        lenh = "select *,(Diem1 +Diem2 +Diem3)as DiemTong 
            from HOSOTHISINH as th,DIEM  as  DM
            where th.SBD = DM.SBD and (Diem1 +Diem2 +Diem3) <21"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("HOSOTHISINH")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid1.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub

    Private Sub xuat_SV()
        txt_SBD.Text = danh_sach.Current("SBD")
        txt_HoTen.Text = danh_sach.Current("Hoten")
        txt_NgaySinh.Text = danh_sach.Current("NgaySinh")
        If danh_sach.Current("GioiTinh") = True Then
            Nam.Checked = True
        Else
            Nu.Checked = True
        End If
        txt_DiaChi.Text = danh_sach.Current("DiaChi")
        txt_Nganh.Text = danh_sach.Current("Nganh")
    End Sub

    Private Sub xuat_SVTT()
        txt_SBD.Text = danh_sach.Current("SBD")
        txt_HoTen.Text = danh_sach.Current("Hoten")
        txt_NgaySinh.Text = danh_sach.Current("NgaySinh")
        If danh_sach.Current("GioiTinh") = True Then
            Nam.Checked = True
        Else
            Nu.Checked = True
        End If
        txt_DiaChi.Text = danh_sach.Current("DiaChi")
        txt_Nganh.Text = danh_sach.Current("Nganh")
        txt_Diem.Text = danh_sach.Current("DiemTong")
    End Sub
    Private Sub xuat_D()
        txt_d1.Text = danh_sach.Current("Diem1")
        txt_d2.Text = danh_sach.Current("Diem2")
        txt_d3.Text = danh_sach.Current("Diem3")
        txt_dt.Text = danh_sach.Current("DiemTong")
        txt_sbdd.Text = danh_sach.Current("SBD")
        txt_khoi.Text = danh_sach.Current("Khoi")
    End Sub

    Private Sub danhsach_SV(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_SV()
    End Sub
    Private Sub danhsach_SVTT(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_SVTT()
    End Sub
    Private Sub danhsach_D(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_D()
    End Sub


    Private Sub QuảnLýThôngTinThíSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýThôngTinThíSinhToolStripMenuItem.Click
        Xuat_SinhVien()
        danhsach_SV(sender, e)
        Heading.Text = "QUẢN LÝ THÔNG TIN THÍ SINH"
        Panel_Trangchu.Visible = False
        Panel_QLSV.Visible = True
        Panel_QLD.Visible = False
        lb_diem.Visible = False
        txt_Diem.Visible = False
        btn_luusv.Visible = True
        btn_themsv.Visible = True
        btn_suasv.Visible = True
        btn_xoasv.Visible = True
        btn_luusv.Enabled = True
        btn_luusv.Enabled = False
    End Sub

    Private Sub QuảnLýĐiểmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýĐiểmToolStripMenuItem.Click
        Xuat_Diem()
        danhsach_D(sender, e)
        Panel_Trangchu.Visible = False
        Panel_QLSV.Visible = False
        Panel_QLD.Visible = True
        btn_themd.Enabled = True
        btn_luud.Enabled = False
    End Sub



    Private Sub btn_themsv_Click(sender As Object, e As EventArgs) Handles btn_themsv.Click
        txt_SBD.Text = ""
        txt_HoTen.Text = ""
        txt_NgaySinh.Text = ""
        txt_Nganh.Text = ""
        txt_DiaChi.Text = ""
        btn_luusv.Enabled = True
        btn_themsv.Enabled = False
    End Sub

    Private Sub btn_luusv_Click(sender As Object, e As EventArgs) Handles btn_luusv.Click
        Dim gt As Integer
        If Nam.Checked = True Then
            gt = 1
        Else
            gt = 0
        End If
        If txt_HoTen.Text = "" Or txt_NgaySinh.Text = "" Or txt_Nganh.Text = "" Or txt_DiaChi.Text = "" Then
            MsgBox("Nhập đầy đủ thông tin")
        Else
            lenh = "Insert into HOSOTHISINH(Hoten,NgaySinh,Gioitinh,DiaChi,Nganh) values (N'" & txt_HoTen.Text _
        & "', N'" & txt_NgaySinh.Text & "'," & gt & ", N'" & txt_DiaChi.Text & "', N'" & txt_Nganh.Text & "')"
            Dim cmd As New OleDbCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_SinhVien()
            danhsach_SV(sender, e)
            MsgBox("Bạn đã nhập thành công")
            btn_luusv.Enabled = False
            btn_themsv.Enabled = True
        End If
    End Sub

    Private Sub btn_xoasv_Click(sender As Object, e As EventArgs) Handles btn_xoasv.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txt_SBD.Text = "" Then
                MsgBox("Phải Chọn Giá Trị Cần Xóa !!!")
            Else
                lenh = "delete from  DIEM where SBD= " & Trim(txt_SBD.Text)
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                lenh = "delete from HOSOTHISINH where SBD = " & Trim(txt_SBD.Text)
                Dim cmd1 As New OleDbCommand(lenh, con)
                con.Open()
                cmd1.ExecuteNonQuery()
                con.Close()
                Xuat_SinhVien()
                MsgBox("Xóa thành công")
            End If
        End If
    End Sub

    Private Sub btn_suasv_Click(sender As Object, e As EventArgs) Handles btn_suasv.Click
        Dim gt As Integer
        If Nam.Checked = True Then
            gt = 1
        Else
            gt = 0
        End If
        If MsgBox("Bạn có muốn cập nhật không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cập nhật") = MsgBoxResult.Yes Then
            If txt_SBD.Text = "" Or txt_HoTen.Text = "" Or txt_NgaySinh.Text = "" Or txt_Nganh.Text = "" Or txt_DiaChi.Text = "" Then
                MsgBox("Nhập đầy đủ thông tin")
            Else
                lenh = "Update HOSOTHISINH set Hoten = N'" & txt_HoTen.Text & "',NgaySinh = '" _
                        & txt_NgaySinh.Text & "',Gioitinh = " & gt & ",DiaChi = N'" & txt_DiaChi.Text & "', Nganh = N'" _
                        & txt_Nganh.Text & "'" & "where SBD = '" & txt_SBD.Text & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_SinhVien()
                MsgBox("Bạn đã cập nhật thành công!!!")
            End If
        End If
    End Sub

    Private Sub btn_tksv_Click(sender As Object, e As EventArgs) Handles btn_tksv.Click
        If Heading.Text = "QUẢN LÝ THÔNG TIN THÍ SINH" Then
            lenh = "select * from HOSOTHISINH where Nganh = N'" & Cb_timkiem.Text & "'"
        ElseIf Heading.Text = "DANH SÁCH TRÚNG TUYỂN" Then
            lenh = "select *,(Diem1 +Diem2 +Diem3)as DiemTong 
            from HOSOTHISINH as th,DIEM  as  DM
            where th.SBD = DM.SBD and (Diem1 +Diem2 +Diem3) >=21 and Nganh = N'" & Cb_timkiem.Text & "'"
        End If
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        If Heading.Text = "DANH SÁCH TRÚNG TUYỂN" Then
            Dim dttable1 As New DataTable("HOSOTHISINH")
            dttable1.Load(bang_doc, LoadOption.OverwriteChanges)
            con.Close()
            DataGrid1.DataSource = dttable1
            danh_sach = Me.BindingContext(dttable1)
        ElseIf Heading.Text = "QUẢN LÝ THÔNG TIN THÍ SINH" Then
            Dim dttable2 As New DataTable("HOSOTHISINH")
            dttable2.Load(bang_doc, LoadOption.OverwriteChanges)
            con.Close()
            DataGrid1.DataSource = dttable2
            danh_sach = Me.BindingContext(dttable2)
        End If
        danhsach_SV(sender, e)
    End Sub

    Private Sub btn_dausv_Click(sender As Object, e As EventArgs) Handles btn_dausv.Click
        danh_sach.Position = 0
    End Sub

    Private Sub btn_trcsv_Click(sender As Object, e As EventArgs) Handles btn_trcsv.Click
        danh_sach.Position -= 1
    End Sub

    Private Sub btn_sausv_Click(sender As Object, e As EventArgs) Handles btn_sausv.Click
        danh_sach.Position += 1
    End Sub

    Private Sub btn_cuoisv_Click(sender As Object, e As EventArgs) Handles btn_cuoisv.Click
        danh_sach.Position = danh_sach.Count - 1
    End Sub

    Private Sub btn_httt_Click(sender As Object, e As EventArgs) Handles btn_httt.Click
        If Heading.Text = "DANH SÁCH TRÚNG TUYỂN" Then
            Xuat_SinhVienTT()
        ElseIf Heading.Text = "QUẢN LÝ THÔNG TIN THÍ SINH" Then
            Xuat_SinhVien()
        End If
    End Sub

    Private Sub btn_daud_Click(sender As Object, e As EventArgs) Handles btn_daud.Click
        danh_sach.Position = 0
    End Sub

    Private Sub btn_truocd_Click(sender As Object, e As EventArgs) Handles btn_truocd.Click
        danh_sach.Position -= 1
    End Sub

    Private Sub btn_saud_Click(sender As Object, e As EventArgs) Handles btn_saud.Click
        danh_sach.Position += 1
    End Sub

    Private Sub btn_cuoid_Click(sender As Object, e As EventArgs) Handles btn_cuoid.Click
        danh_sach.Position = danh_sach.Count - 1
    End Sub

    Private Sub btn_htttd_Click(sender As Object, e As EventArgs) Handles btn_htttd.Click
        Xuat_Diem()
    End Sub

    Private Sub btn_tkd_Click(sender As Object, e As EventArgs) Handles btn_tkd.Click
        lenh = "select H.SBD,Khoi, Diem1,Diem2,Diem3, (Diem1 +Diem2 +Diem3)as DiemTong
        from HOSOTHISINH AS H, DIEM AS D
        where H.SBD = D.SBD and Nganh = N'" & cb_timkiemd.Text & "'"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("DIEM")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid2.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
        danhsach_D(sender, e)
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        Panel_Trangchu.Visible = True
        Panel_QLSV.Visible = False
        Panel_QLD.Visible = False
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
        ElseIf PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = True
        ElseIf PictureBox3.Visible = True Then
            PictureBox3.Visible = False
            PictureBox4.Visible = True
        Else
            PictureBox4.Visible = False
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Red = Int(Rnd() * 255)
        Green = Int(Rnd() * 255)
        Blue = Int(Rnd() * 255)
        Yellow = Int(Rnd() * 255)
        Label3.ForeColor = Color.FromArgb(Red, Green, Blue, Yellow)
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
        Panel_Trangchu.Visible = True
        Panel_QLSV.Visible = False
        Panel_QLD.Visible = False
        Login.txt_user.Text = ""
        Login.txt_pass.Text = ""
        Login.CB_htmk.Checked = False
        Login.txt_user.Focus()
    End Sub

    Private Sub btn_themd_Click(sender As Object, e As EventArgs) Handles btn_themd.Click
        txt_sbdd.Text = ""
        txt_d1.Text = "0"
        txt_d2.Text = "0"
        txt_d3.Text = "0"
        txt_dt.Text = "0"
        txt_khoi.Text = ""
        btn_luud.Enabled = True
        btn_themd.Enabled = False
    End Sub

    Private Sub btn_luud_Click(sender As Object, e As EventArgs) Handles btn_luud.Click
        If txt_sbdd.Text = "" Or txt_d1.Text = "" Or txt_d2.Text = "" Or txt_d3.Text = "" Then
            MsgBox("Nhập đầy đủ thông tin")
        Else
            lenh = "Insert into DIEM(SBD,Khoi,Diem1,Diem2,Diem3) values ('" & txt_sbdd.Text & "','" & txt_khoi.Text & "','" &
                txt_d1.Text & "', '" & txt_d2.Text & "', '" & txt_d3.Text & "')"
            Dim cmd As New OleDbCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Bạn đã nhập thành công")
            Xuat_Diem()
            danhsach_D(sender, e)
            btn_luud.Enabled = False
            btn_themd.Enabled = True
        End If
    End Sub

    Private Sub btn_suad_Click(sender As Object, e As EventArgs) Handles btn_suad.Click
        If MsgBox("Bạn có muốn cập nhật không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cập nhật") = MsgBoxResult.Yes Then
            If txt_sbdd.Text = "" Or txt_d1.Text = "" Or txt_d2.Text = "" Or txt_d3.Text = "" Or txt_khoi.Text = "" Then
                MsgBox("Nhập đầy đủ thông tin")
            Else
                lenh = "Update DIEM set Khoi = '" & txt_khoi.Text & "',Diem1 = '" & txt_d1.Text & "',Diem2 = '" _
                        & txt_d2.Text & "',Diem3 = '" & txt_d3.Text &
                        "' where SBD = '" & txt_sbdd.Text & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_Diem()
                MsgBox("Bạn đã cập nhật thành công!!!")
            End If
        End If
    End Sub

    Private Sub btn_Tong_Click(sender As Object, e As EventArgs) Handles btn_Tong.Click
        If txt_d1.Text > 10 Or txt_d1.Text < 0 Or txt_d2.Text > 10 Or txt_d2.Text < 0 Or txt_d3.Text > 10 Or txt_d3.Text < 0 Then
            txt_dt.Text = ""
            MsgBox("Điểm không được nhỏ hơn 10 và bé hơn 0 !!!!")
        Else
            txt_dt.Text = CInt(txt_d1.Text) + CInt(txt_d2.Text) + CInt(txt_d3.Text)
        End If
    End Sub

    Private Sub CậpNhậtTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtTàiKhoảnToolStripMenuItem.Click
        capnhat.Show()
        Me.Hide()
    End Sub

    Private Sub DannToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DannToolStripMenuItem.Click
        Xuat_SinhVienTT()
        danhsach_SV(sender, e)
        Heading.Text = "DANH SÁCH TRÚNG TUYỂN"
        Panel_Trangchu.Visible = False
        Panel_QLSV.Visible = True
        Panel_QLD.Visible = False
        lb_diem.Visible = True
        txt_Diem.Visible = True
        btn_luusv.Visible = False
        btn_themsv.Visible = False
        btn_suasv.Visible = False
        btn_xoasv.Visible = False
    End Sub

    Private Sub DanhSáchKhôngTrúngTuyểToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchKhôngTrúngTuyểToolStripMenuItem.Click
        Xuat_SinhVienKTT()
        danhsach_SV(sender, e)
        Heading.Text = "DANH SÁCH KHÔNGTRÚNG TUYỂN"
        Panel_Trangchu.Visible = False
        Panel_QLSV.Visible = True
        Panel_QLD.Visible = False
        lb_diem.Visible = True
        txt_Diem.Visible = True
        btn_luusv.Visible = False
        btn_themsv.Visible = False
        btn_suasv.Visible = False
        btn_xoasv.Visible = False
    End Sub
End Class