using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class ThongkeSanpham : Form
    {
        BTLL blllSP;
        public ThongkeSanpham()
        {
            InitializeComponent();
            blllSP = new BTLL();
        }
        SqlConnection con;
        public void HienthiTKSP()
        {
            string sql = "Select * from DonHang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewThongkeSP.DataSource = dt;
        }
        public void Showlistsanpham()
        {
            DataTable dt = blllSP.getlistsanpham();
            lb_soSP.Text = dt.Rows.Count.ToString();
            dataGridViewThongkeSP.DataSource = dt;
        }

        private void ThongkeSanpham_Load(object sender, EventArgs e)
        {
            Showlistsanpham();
            con = new SqlConnection(@"Data Source=DESKTOP-B2J7U3P\SQLEXPRESS;Initial Catalog=QLCuaHang;Integrated Security=True");
            HienthiTKSP();

        }

        private void bt_tktkSP_Click(object sender, EventArgs e)
        {
            string sqltktksp = "Select * from sanpham where TenSP=@TenSP";
            SqlCommand cmd = new SqlCommand(sqltktksp, con);
            cmd.Parameters.AddWithValue("TenSP", txt_tktksp.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewThongkeSP.DataSource = dt;
        }
    }
}
