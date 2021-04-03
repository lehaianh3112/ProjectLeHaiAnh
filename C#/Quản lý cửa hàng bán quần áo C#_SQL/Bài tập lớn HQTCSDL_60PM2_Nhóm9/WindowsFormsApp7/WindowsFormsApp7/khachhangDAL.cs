using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class khachhangDAL
    {
        Dataconection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public khachhangDAL()
        {
            dc = new Dataconection();
        }
        public DataTable getAllkhachhang()
        {
            string sql = "Select * From khachhang";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
        public bool Updatekhachhang(Khachhang kh)
        {
            string sql = "Update khachhang Set MaKH=@MaKH,TenKH=@TenKH,Diachi=@Diachi,Ngaysinh=@Ngaysinh,Gioitinh=@Gioitinh,Email=@Email,SDTKH=@SDTKH Where MaKH=@MaKH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = kh.MaKH;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = kh.TenKH;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = kh.Diachi;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.DateTime).Value = kh.Ngaysinh;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = kh.Gioitinh;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = kh.Email;
                cmd.Parameters.Add("@SDTKH", SqlDbType.Int).Value = kh.SDTKH;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Deletekhachhang(Khachhang kh)
        {
            string sql = "Delete khachhang Where MaKH=@MaKH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = kh.MaKH;
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
