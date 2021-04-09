/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Search;

/**
 *
 * @author DELL
 */
public class SinhVien {
    private String MaSV;
    private String HT;
    private String GT;
    private String NS;
    private String QQ ;
    private String MaLop;
    public String getMasv() {
        return MaSV;
    }

    public void setMasv(String Masv) {
        this.MaSV = Masv;
    }

    public String getHT() {
        return HT;
    }

    public void setHT(String HT) {
        this.HT = HT;
    }

    public String getGT() {
        return GT;
    }

    public void setGT(String GT) {
        this.GT = GT;
    }

    public String getNS() {
        return NS;
    }

    public void setNS(String NS) {
        this.NS = NS;
    }

    public String getQQ() {
        return QQ;
    }

    public void setQQ(String QQ) {
        this.QQ = QQ;
    }

    public String getMaLop() {
        return MaLop;
    }

    public void setMaLop(String ML) {
        this.MaLop = MaLop;
    }

    
    public SinhVien() {
    }

    public SinhVien(String MaSV, String HT, String GT, String NS, String QQ, String MaLop) {
        this.MaSV = MaSV;
        this.HT = HT;
        this.GT = GT;
        this.NS = NS;
        this.QQ = QQ;
        this.MaLop = MaLop;
    }
    
    
}
