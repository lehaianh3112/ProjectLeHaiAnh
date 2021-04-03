using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class BTLL
    {
        nhanvienDAL dalNV;
        khachhangDAL dalKH;
        sanphamDAL dalSP;
        donhangDAL dalDH;
        
        
        public BTLL()
        {
            dalNV = new nhanvienDAL();
            dalKH = new khachhangDAL();
            dalSP = new sanphamDAL();
            dalDH = new donhangDAL();
            
        }
        public DataTable getAllkhachhang()
        {
            return dalKH.getAllkhachhang();
        }
        public DataTable getAllnhanvien()
        {
            return dalNV.getAllnhanvien();
        }
        public DataTable getAllsanpham()
        {
            return dalSP.getAllsanpham();
        }
        public DataTable getAlldonhang()
        {
            return dalDH.getAlldonhang();
        }
        public DataTable getlistdonhang()
        {
            return dalDH.getlistdonhang();
        }
        public DataTable getlistsanpham()
        {
            return dalSP.getlistsanpham();
        }
        public bool Insertnhanvien(nhanvien nv)
        {
            return dalNV.Insertnhanvien(nv);
        }
        public bool Updatenhanvien(nhanvien nv)
        { return dalNV.Updatenhanvien(nv); 
        }
        public bool Deletenhanvien(nhanvien nv)
        { return dalNV.Deletenhanvien(nv); 
        }

        public bool Updatekhachhang(Khachhang kh)
        {
            return dalKH.Updatekhachhang(kh);
        }
        public bool Deletekhachhang(Khachhang kh)
        {
            return dalKH.Deletekhachhang(kh);
        }
        public bool Updatesanpham(SanPham sp)
        {
            return dalSP.Updatesanpham(sp);
        }
        public bool Deletesanpham(SanPham sp)
        {
            return dalSP.Deletesanpham(sp);
        }
        public bool Updatedonhang(donhang dh)
        {
            return dalDH.Updatedonhang(dh);
        }
        public bool Deletedonhang(donhang dh)
        {
            return dalDH.Deletedonhang(dh);
        }
    }
}
