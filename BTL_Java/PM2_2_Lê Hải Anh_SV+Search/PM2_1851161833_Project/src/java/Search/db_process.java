/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Search;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author DELL
 */
public class db_process {
    public ArrayList<SinhVien> dbFindSV() throws SQLException, ClassNotFoundException
    {
        ArrayList<SinhVien> lsv =new ArrayList();
        try (Connection cn = db_connection.getcon()) {
            String SinhVien ="select*from sv";
            try {
                PreparedStatement ps=cn.prepareStatement(SinhVien);
                ResultSet rs=ps.executeQuery();
                while (rs.next()) {
                    String MaSV=rs.getString("MaSV");
                    String HT=rs.getString("Hoten");
                    String GT=rs.getString("GioiTinh");
                    String NS=rs.getString("NamSinh");
                    String QQ=rs.getString("QueQuan");
                    String MaLop=rs.getString("MaLop");
                    SinhVien sv=new  SinhVien(MaSV, HT, GT, NS, QQ, MaLop);
                    lsv.add(sv);
                }
            } catch (SQLException e) {
            }
        }
        return lsv;
    }
    public ArrayList<SinhVien> dbFindSV(String MaLop ) throws SQLException, ClassNotFoundException
    {
        ArrayList<SinhVien> lsv =new ArrayList();
        try (Connection cn = db_connection.getcon()) {
            String SinhVien ="select*from sv where MaLop ='"+MaLop+"'";
            try {
                PreparedStatement ps=cn.prepareStatement(SinhVien);
                ResultSet rs=ps.executeQuery();
                while (rs.next()) {
                    String MaSV=rs.getString("MaSV");
                    String HT=rs.getString("Hoten");                    
                    String GT=rs.getString("GioiTinh");
                    String NS=rs.getString("NamSinh");
                    String QQ=rs.getString("QueQuan");
                    String ML=rs.getString("MaLop");
                    SinhVien sv=new SinhVien(MaSV, HT, GT, NS, QQ, MaLop);
                    lsv.add(sv);
                }
            } catch (SQLException e) {
            }
        }
        return lsv;
    }
}
