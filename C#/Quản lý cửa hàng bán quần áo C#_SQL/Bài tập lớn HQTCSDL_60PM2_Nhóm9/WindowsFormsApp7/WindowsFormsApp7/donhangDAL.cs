using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class donhangDAL
    {
        Dataconection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public donhangDAL()
        {
            dc = new Dataconection();
        }

        

        public DataTable getAlldonhang()
        {
            string sql = "Select * From DonHang";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getlistdonhang()
        {
            string sql = "Select * From viewdonhang";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Updatedonhang(donhang dh)
        {
            string sql = "Update DonHang Set MaDH=@MaSP,NgayDH=@NgayDH,DiaChiGH=@DiaCHiGH,Tongtien=@Tongtien Where MaDH=@MaDH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaDH", SqlDbType.Int).Value = dh.MaDH;
                cmd.Parameters.Add("@NgayDH", SqlDbType.DateTime).Value = dh.NgayDH;
                cmd.Parameters.Add("@DiaChiGH", SqlDbType.NVarChar).Value = dh.DiachiGH;
                cmd.Parameters.Add("@Tongtien", SqlDbType.Float).Value = dh.Tongtien;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Deletedonhang(donhang dh)
        {
            string sql = "Delete DonHang Where MaDH=@MaDH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaDH", SqlDbType.Int).Value = dh.MaDH;
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
