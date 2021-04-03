
namespace WindowsFormsApp7
{
    partial class ThongkeSanpham
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
            this.lb_soSP = new System.Windows.Forms.Label();
            this.bt_tktkSP = new System.Windows.Forms.Button();
            this.txt_tktksp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewThongkeSP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongkeSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lb_soSP);
            this.panel1.Controls.Add(this.bt_tktkSP);
            this.panel1.Controls.Add(this.txt_tktksp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 6;
            // 
            // lb_soSP
            // 
            this.lb_soSP.AutoSize = true;
            this.lb_soSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soSP.Location = new System.Drawing.Point(157, 42);
            this.lb_soSP.Name = "lb_soSP";
            this.lb_soSP.Size = new System.Drawing.Size(45, 16);
            this.lb_soSP.TabIndex = 9;
            this.lb_soSP.Text = "label2";
            // 
            // bt_tktkSP
            // 
            this.bt_tktkSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_tktkSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tktkSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_tktkSP.Location = new System.Drawing.Point(501, 22);
            this.bt_tktkSP.Name = "bt_tktkSP";
            this.bt_tktkSP.Size = new System.Drawing.Size(131, 36);
            this.bt_tktkSP.TabIndex = 8;
            this.bt_tktkSP.Text = "Tìm kiếm";
            this.bt_tktkSP.UseVisualStyleBackColor = false;
            this.bt_tktkSP.Click += new System.EventHandler(this.bt_tktkSP_Click);
            // 
            // txt_tktksp
            // 
            this.txt_tktksp.Location = new System.Drawing.Point(361, 38);
            this.txt_tktksp.Name = "txt_tktksp";
            this.txt_tktksp.Size = new System.Drawing.Size(100, 20);
            this.txt_tktksp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số sản phẩm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewThongkeSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 349);
            this.panel2.TabIndex = 7;
            // 
            // dataGridViewThongkeSP
            // 
            this.dataGridViewThongkeSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongkeSP.Location = new System.Drawing.Point(3, 5);
            this.dataGridViewThongkeSP.Name = "dataGridViewThongkeSP";
            this.dataGridViewThongkeSP.Size = new System.Drawing.Size(774, 294);
            this.dataGridViewThongkeSP.TabIndex = 5;
            // 
            // ThongkeSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThongkeSanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongkeSanpham";
            this.Load += new System.EventHandler(this.ThongkeSanpham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongkeSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_soSP;
        private System.Windows.Forms.Button bt_tktkSP;
        private System.Windows.Forms.TextBox txt_tktksp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewThongkeSP;
    }
}