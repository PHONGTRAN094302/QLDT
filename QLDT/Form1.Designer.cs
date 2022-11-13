namespace QLDT
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_soluongve = new System.Windows.Forms.TextBox();
            this.tb_tennuoc = new System.Windows.Forms.TextBox();
            this.tb_giave = new System.Windows.Forms.TextBox();
            this.cb_CLB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Doanh Thu CLB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(433, 306);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_TK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // tb_TK
            // 
            this.tb_TK.Location = new System.Drawing.Point(105, 36);
            this.tb_TK.Name = "tb_TK";
            this.tb_TK.Size = new System.Drawing.Size(298, 26);
            this.tb_TK.TabIndex = 1;
            this.tb_TK.TextChanged += new System.EventHandler(this.tb_TK_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên CLB:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_soluongve);
            this.groupBox2.Controls.Add(this.tb_tennuoc);
            this.groupBox2.Controls.Add(this.tb_giave);
            this.groupBox2.Controls.Add(this.cb_CLB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Location = new System.Drawing.Point(451, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 386);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // tb_soluongve
            // 
            this.tb_soluongve.Location = new System.Drawing.Point(131, 216);
            this.tb_soluongve.Name = "tb_soluongve";
            this.tb_soluongve.Size = new System.Drawing.Size(121, 26);
            this.tb_soluongve.TabIndex = 5;
            this.tb_soluongve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soluongve_KeyPress);
            // 
            // tb_tennuoc
            // 
            this.tb_tennuoc.Location = new System.Drawing.Point(121, 154);
            this.tb_tennuoc.Name = "tb_tennuoc";
            this.tb_tennuoc.Size = new System.Drawing.Size(229, 26);
            this.tb_tennuoc.TabIndex = 5;
            // 
            // tb_giave
            // 
            this.tb_giave.Location = new System.Drawing.Point(121, 98);
            this.tb_giave.Name = "tb_giave";
            this.tb_giave.Size = new System.Drawing.Size(131, 26);
            this.tb_giave.TabIndex = 5;
            // 
            // cb_CLB
            // 
            this.cb_CLB.FormattingEnabled = true;
            this.cb_CLB.Items.AddRange(new object[] {
            "MANCHESTER",
            "PARISSG",
            "REALMADRIT",
            "BENFICA",
            "ACMILAN",
            "BARCELONA",
            "B.MUNICH",
            "JUVENTUS"});
            this.cb_CLB.Location = new System.Drawing.Point(121, 36);
            this.cb_CLB.Name = "cb_CLB";
            this.cb_CLB.Size = new System.Drawing.Size(229, 28);
            this.cb_CLB.TabIndex = 4;
            this.cb_CLB.SelectedIndexChanged += new System.EventHandler(this.cb_CLB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Vé:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(19, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số Lượng Vé:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(19, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Nước:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên CLB:";
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.BackColor = System.Drawing.Color.Yellow;
            this.bt_xoa.ForeColor = System.Drawing.Color.White;
            this.bt_xoa.Location = new System.Drawing.Point(261, 328);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 42);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.AutoSize = true;
            this.bt_sua.BackColor = System.Drawing.Color.Orange;
            this.bt_sua.ForeColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(151, 328);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 42);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.AutoSize = true;
            this.bt_them.BackColor = System.Drawing.Color.Blue;
            this.bt_them.ForeColor = System.Drawing.Color.White;
            this.bt_them.Location = new System.Drawing.Point(25, 328);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 42);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_thongke
            // 
            this.bt_thongke.AutoSize = true;
            this.bt_thongke.BackColor = System.Drawing.Color.Lime;
            this.bt_thongke.Location = new System.Drawing.Point(602, 36);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(91, 37);
            this.bt_thongke.TabIndex = 2;
            this.bt_thongke.Text = "Thống Kê";
            this.bt_thongke.UseVisualStyleBackColor = false;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.Color.Red;
            this.bt_thoat.Location = new System.Drawing.Point(712, 36);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(89, 37);
            this.bt_thoat.TabIndex = 2;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 494);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_thongke);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_TK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_soluongve;
        private System.Windows.Forms.TextBox tb_tennuoc;
        private System.Windows.Forms.TextBox tb_giave;
        private System.Windows.Forms.ComboBox cb_CLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_thoat;
    }
}

