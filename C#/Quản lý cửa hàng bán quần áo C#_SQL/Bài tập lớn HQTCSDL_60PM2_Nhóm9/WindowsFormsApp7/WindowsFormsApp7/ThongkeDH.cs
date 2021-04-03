using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class ThongkeDH : Form
    {
        BTLL blllDH;
        public ThongkeDH()
        {
            InitializeComponent();
            blllDH = new BTLL();            
        }
        SqlConnection con;
        public void HienthiTKDH()
        {
            string sql = "Select * from DonHang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewThongkeDH.DataSource = dt;
        }
        public void Showlistdonhang()
        {
            DataTable dt = blllDH.getlistdonhang();
            lb_sdh.Text = dt.Rows.Count.ToString();
            dataGridViewThongkeDH.DataSource = dt;
        }
      
        private void ThongkeDH_Load(object sender, EventArgs e)
        {
            Showlistdonhang();
            con = new SqlConnection(@"Data Source=DESKTOP-B2J7U3P\SQLEXPRESS;Initial Catalog=QLCuaHang;Integrated Security=True");
            HienthiTKDH();
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_timkiemdonhang_Click(object sender, EventArgs e)
        {
            string sqltktkdh = "Select * from DonHang where MaDH=@MaDH";
            SqlCommand cmd = new SqlCommand(sqltktkdh, con);
            cmd.Parameters.AddWithValue("MaDH", txt_tktkdh.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewThongkeDH.DataSource = dt;
        }
    }
}
