using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class nhanvienDAL
    {
        Dataconection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public nhanvienDAL()
        {
            dc = new Dataconection();
        }
        public DataTable getAllnhanvien()
        {
            string sql = "Select * From nhanvien";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    

       


        public bool Insertnhanvien(nhanvien nv)
        {
            string sql = "Insert into nhanvien(MaNV,TenNV,Diachi,SDTNV,Ngaysinh,Gioitinh,Chucvu,Luong) Values(@MaNV,@TenNV,@Diachi,@SDTNV,@Ngaysinh,@Gioitinh,@Chucvu,@Luong)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNV;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nv.Diachi;
                cmd.Parameters.Add("@SDTNV", SqlDbType.Int).Value = nv.SDTNV;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.DateTime).Value = nv.Ngaysinh;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nv.Gioitinh;
                cmd.Parameters.Add("@Chucvu", SqlDbType.NVarChar).Value = nv.Chucvu;
                cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = nv.Luong;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Updatenhanvien(nhanvien nv)
        {
            string sql = "Update nhanvien Set MaNV=@MaNV,TenNV=@TenNV,Diachi=@Diachi,SDTNV=@SDTNV,Ngaysinh=@Ngaysinh,Gioitinh=@Gioitinh,Chucvu=@Chucvu,Luong=@Luong Where MaNV=@MaNV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNV;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nv.Diachi;
                cmd.Parameters.Add("@SDTNV", SqlDbType.Int).Value = nv.SDTNV;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.DateTime).Value = nv.Ngaysinh;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nv.Gioitinh;
                cmd.Parameters.Add("@Chucvu", SqlDbType.NVarChar).Value = nv.Chucvu;
                cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = nv.Luong;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Deletenhanvien(nhanvien nv)
        {
            string sql = "Delete nhanvien Where MaNV=@MaNV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNV;
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
