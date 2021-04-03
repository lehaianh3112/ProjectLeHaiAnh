using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp7
{

    public partial class quanly : Form
    {
        BTLL bllNV, bllKH, bllSP, bllDH;
     

        public quanly()
        {
            InitializeComponent();
            bllNV = new BTLL();
            bllKH = new BTLL();
            bllSP = new BTLL();
            bllDH = new BTLL();

        }
        SqlConnection con;

        public void ShowAllnhanvien()
        {

            DataTable dt = bllNV.getAllnhanvien();
            dataGridNhanVien.DataSource = dt;


        }
        public void ShowAllkhachhang()
        {

            DataTable dt = bllKH.getAllkhachhang();
            dataGridkhachhang.DataSource = dt;

        }
        public void ShowAllsanpham()
        {

            DataTable dt = bllSP.getAllsanpham();
            dataGridViewSP.DataSource = dt;

        }
        public void ShowAlldonhang()
        {

            DataTable dt = bllDH.getAlldonhang();
            dataGridViewDonhang.DataSource = dt;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (CheckData())
                {
                    nhanvien nv = new nhanvien();
                    nv.MaNV = int.Parse(txt_manv.Text);
                    nv.TenNV = txt_hoten.Text;
                    nv.Diachi = cb_diachi.Text;
                    nv.SDTNV = double.Parse(txt_sdt.Text);
                    nv.Ngaysinh = dt_ngaysinh.Value;
                    nv.Chucvu = cb_chucvu.Text;
                    nv.Luong = double.Parse(cb_luong.Text);

                    if (bllNV.Updatenhanvien(nv))
                    {
                        ShowAllnhanvien();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
          
        }
        public void Hienthi()
        {
            string sql = "Select * from nhanvien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridNhanVien.DataSource = dt;
        }
        public void HienthiKH()
        {
            string sql = "Select * from khachhang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridkhachhang.DataSource = dt;
        }
        public void HienthiSP()
        {
            string sql = "Select * from sanpham";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewSP.DataSource = dt;
        }
        public void HienthiDH()
        {
            string sql = "Select * from DonHang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewDonhang.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllnhanvien();
            ShowAllkhachhang();
            ShowAllsanpham();
            ShowAlldonhang();
            con = new SqlConnection(@"Data Source=DESKTOP-B2J7U3P\SQLEXPRESS;Initial Catalog=QLCuaHang;Integrated Security=True");
            con.Open();
            Hienthi();
            HienthiKH();
            HienthiSP();
            HienthiDH();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txt_manv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_hoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_hoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_diachi.Text))
            {
                MessageBox.Show("Bạn chưa chọn địa chỉ nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_diachi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_chucvu.Text))
            {
                MessageBox.Show("Bạn chưa chọn chức vụ của nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_chucvu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_luong.Text))
            {
                MessageBox.Show("Bạn chưa chọn chức vụ của nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_luong.Focus();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (CheckData())
            {
                nhanvien nv = new nhanvien();
                int year_old = DateTime.Today.Year - dt_ngaysinh.Value.Year;
                if (year_old < 18 || year_old > 60)
                {
                    MessageBox.Show("Tuổi nhân viên phải từ 18 đến 60 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                nv.MaNV = int.Parse(txt_manv.Text);
                nv.TenNV = txt_hoten.Text;
                nv.Diachi = cb_diachi.Text;
                nv.SDTNV = double.Parse(txt_sdt.Text);
                nv.Ngaysinh = dt_ngaysinh.Value;
                nv.Gioitinh = cb_gt.Text;
                nv.Chucvu = cb_chucvu.Text;
                nv.Luong = double.Parse(cb_luong.Text);

                if (bllNV.Insertnhanvien(nv))
                {
                    ShowAllnhanvien();
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
    } 
        private void dataGridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_manv.Text = dataGridNhanVien.Rows[index].Cells["MaNV"].Value.ToString();
                txt_hoten.Text = dataGridNhanVien.Rows[index].Cells["TenNV"].Value.ToString();
                cb_diachi.Text = dataGridNhanVien.Rows[index].Cells["Diachi"].Value.ToString();
                txt_sdt.Text = dataGridNhanVien.Rows[index].Cells["SDTNV"].Value.ToString();
                cb_gt.Text = dataGridNhanVien.Rows[index].Cells["Gioitinh"].Value.ToString();
                dt_ngaysinh.Text = dataGridNhanVien.Rows[index].Cells["Ngaysinh"].Value.ToString();
                cb_chucvu.Text = dataGridNhanVien.Rows[index].Cells["Chucvu"].Value.ToString();
                cb_luong.Text = dataGridNhanVien.Rows[index].Cells["Luong"].Value.ToString();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Bạn có muốn xóa nhân viên?", "Lời nhắc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nhanvien nv = new nhanvien();
                    nv.MaNV = int.Parse(txt_manv.Text);

                    if (bllNV.Deletenhanvien(nv))
                    {
                        ShowAllnhanvien();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            string sqltk = "Select * from nhanvien where TenNV=@TenNV";
            SqlCommand cmd = new SqlCommand(sqltk, con);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.Parameters.AddWithValue("TenNV", txt_tk.Text);
            cmd.Parameters.AddWithValue("Diachi", cb_diachi.Text);
            cmd.Parameters.AddWithValue("SDTNV", txt_sdt.Text);
            cmd.Parameters.AddWithValue("Ngaysinh", dt_ngaysinh.Value);
            cmd.Parameters.AddWithValue("Chucvu", cb_chucvu.Text);
            cmd.Parameters.AddWithValue("Luong", cb_luong.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridNhanVien.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }


        private void txt_tk_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void bt_themkh_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                tabControl1.SelectTab(tabPage1);
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
           
                tabControl1.SelectTab(tabPage2);
             
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
          
                tabControl1.SelectTab(tabPage5);
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
           ("Bạn có chắc muốn thoát không?", "Đóng ứng dụng", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rb_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_nu_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng?", "Lời nhắc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Khachhang kh = new Khachhang();
                kh.MaKH = int.Parse(txt_makh.Text);

                if (bllKH.Deletekhachhang(kh))
                {
                    ShowAllkhachhang();
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_masp.Text = dataGridViewSP.Rows[index].Cells["MaSP"].Value.ToString();
                txt_tensp.Text = dataGridViewSP.Rows[index].Cells["TenSP"].Value.ToString();
                rt_mota.Text = dataGridViewSP.Rows[index].Cells["Mota"].Value.ToString();
                txt_slton.Text = dataGridViewSP.Rows[index].Cells["Slton"].Value.ToString();
            }
        }

        private void bt_suaSP_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = int.Parse(txt_masp.Text);
            sp.TenSP = txt_tensp.Text;
            sp.Mota = rt_mota.Text;
            sp.Slton = double.Parse(txt_slton.Text);
           
           if (bllSP.Updatesanpham(sp))
            {
                ShowAllsanpham();
            }
            else
            {
                MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bt_XoaSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm?", "Lời nhắc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SanPham sp = new SanPham();
                sp.MaSP = int.Parse(txt_masp.Text);

                if (bllSP.Deletesanpham(sp))
                {
                    ShowAllsanpham();
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridViewDonhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_madh.Text = dataGridViewDonhang.Rows[index].Cells["MaDH"].Value.ToString();
                dt_ngayDH.Text = dataGridViewDonhang.Rows[index].Cells["NgayDH"].Value.ToString();
                cb_dh.Text = dataGridViewDonhang.Rows[index].Cells["DiachiGH"].Value.ToString();
                txt_tongtien.Text = dataGridViewDonhang.Rows[index].Cells["TongTien"].Value.ToString();
               
            }
        }

        private void bt_suadh_Click(object sender, EventArgs e)
        {
            donhang dh = new donhang();
            dh.MaDH = int.Parse(txt_madh.Text);
            dh.NgayDH = dt_ngayDH.Value;
            dh.DiachiGH = cb_dh.Text;
            dh.Tongtien = double.Parse(txt_tongtien.Text);
        

            if (bllDH.Updatedonhang(dh))
            {
                ShowAlldonhang();
            }
            else
            {
                MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bt_xoadh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đơn hàng?", "Lời nhắc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                donhang dh = new donhang();
                dh.MaDH = int.Parse(txt_madh.Text);

                if (bllDH.Deletedonhang(dh))
                {
                    ShowAlldonhang();
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bt_thogke_Click(object sender, EventArgs e)
        {
            ThongkeDH form_TK = new ThongkeDH();
            form_TK.Show();
        }

        private void bt_thongkeSP_Click(object sender, EventArgs e)
        {
            ThongkeSanpham form_TK = new ThongkeSanpham();
            form_TK.Show();
        }

        private void bt_TKKH_Click(object sender, EventArgs e)
        {
            string sqltkkh = "Select * from khachhang where TenKH=@TenKH";
            SqlCommand cmd = new SqlCommand(sqltkkh, con);
            cmd.Parameters.AddWithValue("MaKH", txt_makh.Text);
            cmd.Parameters.AddWithValue("TenKH", txt_tkKH.Text);
            cmd.Parameters.AddWithValue("Ngaysinh", dt_nskh.Value);
            cmd.Parameters.AddWithValue("Gioitinh", cb_gtkh.Text);
            cmd.Parameters.AddWithValue("Email", txt_emailkh.Text);
            cmd.Parameters.AddWithValue("SDTKH",txt_sdtkh.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridkhachhang.DataSource = dt;
        }

        private void bt_TKSP_Click(object sender, EventArgs e)
        {
            string sqltksp = "Select * from sanpham where TenSP=@TenSP";
            SqlCommand cmd = new SqlCommand(sqltksp, con);
            cmd.Parameters.AddWithValue("MaSP", txt_masp.Text);
            cmd.Parameters.AddWithValue("TenSP", txt_TKSP.Text);
            cmd.Parameters.AddWithValue("Mota", rt_mota.Text);
            cmd.Parameters.AddWithValue("Slton", txt_slton.Text);
          
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewSP.DataSource = dt;
        }

        private void txt_tkdh_TextChanged(object sender, EventArgs e)
        {
            string sqltkdh = "Select * from DonHang where MaDH=@MaDH";
            SqlCommand cmd = new SqlCommand(sqltkdh, con);
            cmd.Parameters.AddWithValue("MaDH",txt_tkdh.Text);
            cmd.Parameters.AddWithValue("NgayDH", dt_ngayDH.Value);
            cmd.Parameters.AddWithValue("DiachiGH", cb_dh.Text);
            cmd.Parameters.AddWithValue("Tongtien", txt_tongtien.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
           dataGridViewDonhang.DataSource = dt;
        }

        private void bt_qldh_Click(object sender, EventArgs e)
        {
            
                tabControl1.SelectTab(tabPage3);
          
        }

        private void dataGridkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_makh.Text = dataGridkhachhang.Rows[index].Cells["MaKH"].Value.ToString();
                txt_tenkh.Text = dataGridkhachhang.Rows[index].Cells["TenKH"].Value.ToString();
                cb_diachikh.Text = dataGridkhachhang.Rows[index].Cells["DiaChiKH"].Value.ToString(); 
                dt_nskh.Text = dataGridkhachhang.Rows[index].Cells["NgaysinhKH"].Value.ToString();
                cb_gtkh.Text = dataGridkhachhang.Rows[index].Cells["GioitinhKH"].Value.ToString();
                txt_emailkh.Text = dataGridkhachhang.Rows[index].Cells["Email"].Value.ToString();
                txt_sdtkh.Text = dataGridkhachhang.Rows[index].Cells["SDTKH"].Value.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Khachhang kh = new Khachhang();
            kh.MaKH = int.Parse(txt_makh.Text);
            kh.TenKH = txt_tenkh.Text;
            kh.Diachi = cb_diachikh.Text;
            kh.Ngaysinh = dt_nskh.Value;
            kh.Gioitinh = cb_gtkh.Text;
            kh.Email = txt_emailkh.Text;
            kh.SDTKH = double.Parse(txt_sdtkh.Text);

            if (bllKH.Updatekhachhang(kh))
            {
                ShowAllkhachhang();
            }
            else
            {
                MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

