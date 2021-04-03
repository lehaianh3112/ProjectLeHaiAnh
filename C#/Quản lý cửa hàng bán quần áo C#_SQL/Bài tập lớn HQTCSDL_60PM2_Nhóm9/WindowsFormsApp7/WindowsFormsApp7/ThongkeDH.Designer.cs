
namespace WindowsFormsApp7
{
    partial class ThongkeDH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_sdh = new System.Windows.Forms.Label();
            this.lb_dtdh = new System.Windows.Forms.Label();
            this.ssss = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_timkiemdonhang = new System.Windows.Forms.Button();
            this.txt_tktkdh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewThongkeDH = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongkeDH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lb_sdh);
            this.panel1.Controls.Add(this.lb_dtdh);
            this.panel1.Controls.Add(this.ssss);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_timkiemdonhang);
            this.panel1.Controls.Add(this.txt_tktkdh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 100);
            this.panel1.TabIndex = 4;
            // 
            // lb_sdh
            // 
            this.lb_sdh.AutoSize = true;
            this.lb_sdh.Location = new System.Drawing.Point(347, 46);
            this.lb_sdh.Name = "lb_sdh";
            this.lb_sdh.Size = new System.Drawing.Size(35, 13);
            this.lb_sdh.TabIndex = 15;
            this.lb_sdh.Text = "label5";
            // 
            // lb_dtdh
            // 
            this.lb_dtdh.AutoSize = true;
            this.lb_dtdh.Location = new System.Drawing.Point(113, 46);
            this.lb_dtdh.Name = "lb_dtdh";
            this.lb_dtdh.Size = new System.Drawing.Size(35, 13);
            this.lb_dtdh.TabIndex = 14;
            this.lb_dtdh.Text = "label4";
            // 
            // ssss
            // 
            this.ssss.AutoSize = true;
            this.ssss.Location = new System.Drawing.Point(257, 46);
            this.ssss.Name = "ssss";
            this.ssss.Size = new System.Drawing.Size(72, 13);
            this.ssss.TabIndex = 12;
            this.ssss.Text = "Số đơn hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // bt_timkiemdonhang
            // 
            this.bt_timkiemdonhang.BackColor = System.Drawing.Color.LightCoral;
            this.bt_timkiemdonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiemdonhang.ForeColor = System.Drawing.Color.Maroon;
            this.bt_timkiemdonhang.Location = new System.Drawing.Point(732, 27);
            this.bt_timkiemdonhang.Name = "bt_timkiemdonhang";
            this.bt_timkiemdonhang.Size = new System.Drawing.Size(88, 42);
            this.bt_timkiemdonhang.TabIndex = 10;
            this.bt_timkiemdonhang.Text = "Tìm kiếm";
            this.bt_timkiemdonhang.UseVisualStyleBackColor = false;
            this.bt_timkiemdonhang.Click += new System.EventHandler(this.bt_timkiemdonhang_Click);
            // 
            // txt_tktkdh
            // 
            this.txt_tktkdh.Location = new System.Drawing.Point(581, 39);
            this.txt_tktkdh.Name = "txt_tktkdh";
            this.txt_tktkdh.Size = new System.Drawing.Size(100, 20);
            this.txt_tktkdh.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm Đơn Hàng";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.dataGridViewThongkeDH);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 351);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewThongkeDH
            // 
            this.dataGridViewThongkeDH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewThongkeDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongkeDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridViewThongkeDH.Location = new System.Drawing.Point(6, 55);
            this.dataGridViewThongkeDH.Name = "dataGridViewThongkeDH";
            this.dataGridViewThongkeDH.Size = new System.Drawing.Size(957, 241);
            this.dataGridViewThongkeDH.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDH";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Mã DH";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenKH";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Tên KH";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Email";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayDH";
            this.Column5.HeaderText = "Ngày đặt hàng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DiachiGH";
            this.Column6.HeaderText = "Địa chỉ GH";
            this.Column6.Name = "Column6";
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaNV";
            this.Column7.HeaderText = "Mã NV";
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenSP";
            this.Column8.HeaderText = "Tên SP";
            this.Column8.Name = "Column8";
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Soluong";
            this.Column9.HeaderText = "Số Lượng ";
            this.Column9.Name = "Column9";
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TenLSP";
            this.Column10.HeaderText = "Tên loại SP";
            this.Column10.Name = "Column10";
            this.Column10.Width = 70;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TenNV";
            this.Column11.HeaderText = "Tên NV";
            this.Column11.Name = "Column11";
            this.Column11.Width = 70;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SDTKH";
            this.Column12.HeaderText = "SDT Khách hàng";
            this.Column12.Name = "Column12";
            this.Column12.Width = 70;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Tongtien";
            this.Column13.HeaderText = "Tổng tiền";
            this.Column13.Name = "Column13";
            this.Column13.Width = 70;
            // 
            // ThongkeDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThongkeDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongkeDH";
            this.Load += new System.EventHandler(this.ThongkeDH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongkeDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ssss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_timkiemdonhang;
        private System.Windows.Forms.TextBox txt_tktkdh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewThongkeDH;
        private System.Windows.Forms.Label lb_sdh;
        private System.Windows.Forms.Label lb_dtdh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}