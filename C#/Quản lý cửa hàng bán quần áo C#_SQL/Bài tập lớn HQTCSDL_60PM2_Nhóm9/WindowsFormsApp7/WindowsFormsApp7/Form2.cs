using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp7
{
    public partial class Dangnhap : Form

    {
        BTLL btllDN;
       
        public Dangnhap()
        {
            InitializeComponent();
            btllDN = new BTLL();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
           SqlConnection cn =new SqlConnection("Data Source=DESKTOP-B2J7U3P\\SQLEXPRESS;Initial Catalog=QLCuaHang;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan where TenDN = '" + txt_tk.Text + "'and Matkhau=  '" + txt_mk.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                quanly QL = new quanly();
                QL.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa điền sai thông tin đăng nhập hoặc bạn chưa điền thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
    }
}
