using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        QuanLyDoanhThu quanly;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("Select * from CLB");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
            DeleteTextBoxes();
        }
        private void cb_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_CLB.SelectedIndex == 0)
            {
                tb_giave.Text = "10";
                tb_tennuoc.Text = "Anh";
            }
            if (cb_CLB.SelectedIndex == 1)
            {
                tb_giave.Text = "12";
                tb_tennuoc.Text = "Pháp";
            }
            if (cb_CLB.SelectedIndex == 2)
            {
                tb_giave.Text = "10";
                tb_tennuoc.Text = "Tây Ban Nha";
            }
            if (cb_CLB.SelectedIndex == 3)
            {
                tb_giave.Text = "7";
                tb_tennuoc.Text = "Bồ Đào Nha";
            }
            if (cb_CLB.SelectedIndex == 4)
            {
                tb_giave.Text = "12";
                tb_tennuoc.Text = "Ý";
            }
            if (cb_CLB.SelectedIndex == 5)
            {
                tb_giave.Text = "10";
                tb_tennuoc.Text = "Tây Ban Nha";
            }
            if (cb_CLB.SelectedIndex == 6)
            {
                tb_giave.Text = "10";
                tb_tennuoc.Text = "Đức";
            }
            if (cb_CLB.SelectedIndex == 7)
            {
                tb_giave.Text = "11";
                tb_tennuoc.Text = "Ý";
            }
        }
        private void tb_soluongve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void DeleteTextBoxes()
        {
            cb_CLB.SelectedIndex = -1;
            tb_giave.Text = "";
            tb_soluongve.Text = "";
            tb_tennuoc.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (cb_CLB.SelectedIndex == -1) { MessageBox.Show("Mời bạn chọn câu lạc bộ!"); return false; }
            if (tb_soluongve.Text == "") { MessageBox.Show("Mời bạn nhập số lượng vé!"); return false; }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _tenCLB = cb_CLB.Text;
            string _tenNuoc = tb_tennuoc.Text;
            int _slVe = int.Parse(tb_soluongve.Text);
            double _giaVe = double.Parse(tb_giave.Text);
            quanly = new QuanLyDoanhThu(_tenCLB,_tenNuoc,_slVe,_giaVe);
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            if(CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO CLB VALUES('"+quanly.TenCLB+"',N'"+quanly.TenNuoc+"','"+quanly.SlVe+"','"+quanly.GiaVe+"','"+quanly.DoanhThu()+"')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1_Load(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi Thêm:"+ex.Message);
                }
            }   
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "UPDATE CLB SET TenNuoc = N'" + quanly.TenNuoc+ "',SoLuongVe = '" + quanly.SlVe + "',GiaVe = '" + quanly.GiaVe + "',TongTien = '" +quanly.DoanhThu()+"'";
                query += "WHERE TenCauLacBo='"+quanly.TenCLB+"'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Sửa:" + ex.Message);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                cb_CLB.SelectedItem = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_giave.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_soluongve.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_tennuoc.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >1)
            {
                string choose = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE CLB";
                query += "WHERE TenCauLacBo = '"+choose+"'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa tên câu lạc bộ "+choose+" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa:" + ex.Message);
                }
            }
        }
        private void tb_TK_TextChanged(object sender, EventArgs e)
        {
            string name = tb_TK.Text.Trim();
            if(name == "")
            {
                Form1_Load(sender, e);
            }
            else
            {
                string query = "Select * from CLB Where TenCauLacBo like '%"+name+"%'";
                dataGridView1.DataSource = modify.Table(query);
            } 
        }
        private void bt_thongke_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }
    }
}
