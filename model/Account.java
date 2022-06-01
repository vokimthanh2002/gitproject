package model;

public class Account {
    private String maThe;
    private String maKhau;
    private String tenDangNhap;
    private String soDu;
    private boolean trangThai;
    private byte[] anh;
    private String hoTen;
    private String cmnd;
    private String sdt;
    private String email;
    private String diaChi;
    private String gioiTinh;
    private String ngaySinh;

    public Account(String maThe, String maKhau, String tenDangNhap, String soDu, boolean trangThai, byte[] anh, String hoTen, String cmnd, String sdt, String email, String diaChi, String gioiTinh, String ngaySinh) {
        this.maThe = maThe;
        this.maKhau = maKhau;
        this.tenDangNhap = tenDangNhap;
        this.soDu = soDu;
        this.trangThai = trangThai;
        this.anh = anh;
        this.hoTen = hoTen;
        this.cmnd = cmnd;
        this.sdt = sdt;
        this.email = email;
        this.diaChi = diaChi;
        this.gioiTinh = gioiTinh;
        this.ngaySinh = ngaySinh;
    }

    public Account() {
    }

    public void setMaThe(String maThe) {
        this.maThe = maThe;
    }

    public void setMaKhau(String maKhau) {
        this.maKhau = maKhau;
    }

    public void setTenDangNhap(String tenDangNhap) {
        this.tenDangNhap = tenDangNhap;
    }

    public void setSoDu(String soDu) {
        this.soDu = soDu;
    }

    public void setTrangThai(boolean trangThai) {
        this.trangThai = trangThai;
    }

    public void setAnh(byte[] anh) {
        this.anh = anh;
    }

    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public void setCmnd(String cmnd) {
        this.cmnd = cmnd;
    }

    public void setSdt(String sdt) {
        this.sdt = sdt;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }

    public void setGioiTinh(String gioiTinh) {
        this.gioiTinh = gioiTinh;
    }

    public void setNgaySinh(String ngaySinh) {
        this.ngaySinh = ngaySinh;
    }

    public String getMaThe() {
        return maThe;
    }

    public String getMaKhau() {
        return maKhau;
    }

    public String getTenDangNhap() {
        return tenDangNhap;
    }

    public String getSoDu() {
        return soDu;
    }

    public boolean isTrangThai() {
        return trangThai;
    }

    public byte[] getAnh() {
        return anh;
    }

    public String getHoTen() {
        return hoTen;
    }

    public String getCmnd() {
        return cmnd;
    }

    public String getSdt() {
        return sdt;
    }

    public String getEmail() {
        return email;
    }

    public String getDiaChi() {
        return diaChi;
    }

    public String getGioiTinh() {
        return gioiTinh;
    }

    public String getNgaySinh() {
        return ngaySinh;
    }
}
