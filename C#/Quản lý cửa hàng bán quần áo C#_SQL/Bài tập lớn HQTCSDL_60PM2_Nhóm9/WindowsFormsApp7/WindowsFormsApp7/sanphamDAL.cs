using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class sanphamDAL
    {
        Dataconection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public sanphamDAL()
        {
            dc = new Dataconection();
        }

        public DataTable getAllsanpham()
        {
            string sql = "Select * From sanpham";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getlistsanpham()
        {
            string sql = "Select * From viewsanpham";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Updatesanpham(SanPham sp)
        {
            string sql = "Update sanpham Set MaSP=@MaSP,TenSP=@TenSP,Mota=@Mota,Slton=@Slton Where MaSP=@MaSP";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = sp.MaSP;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = sp.TenSP;
                cmd.Parameters.Add("@Mota", SqlDbType.NVarChar).Value = sp.Mota;
                cmd.Parameters.Add("@Slton", SqlDbType.Float).Value = sp.Slton;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Deletesanpham(SanPham sp)
        {
            string sql = "Delete sanpham Where MaSP=@MaSP";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = sp.MaSP;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
