package service;

import dao.AccountDao;
import java.sql.SQLException;
import model.Account;

public class AccountServices {
    
    public Account getAccountByMaThe309(String maThe309) throws SQLException {
        AccountDao dao309 = new AccountDao();
        return dao309.getAccountByMaThe309(maThe309);
    }
    
    public boolean UpdateAccount309(Account acc309) throws SQLException {
        AccountDao dao309 = new AccountDao();
        return dao309.UpdateAccount309(acc309);
    }
    
        public Account getAccountByUserName347(String tenDangNhap347) throws SQLException{
        AccountDao dao347 = new AccountDao();
        return dao347.getAccountByUserName347(tenDangNhap347);
    }
    
    public void UpdateTrangThai347(Account acc347) throws SQLException {
        AccountDao dao347 = new AccountDao();
        dao347.UpdateTrangThai347(acc347);
    }
    
    public void UpdateMatKhau347(Account acc347) throws SQLException {
        AccountDao dao347 = new AccountDao();
        dao347.UpdateMatKhau347(acc347);
    }
}
