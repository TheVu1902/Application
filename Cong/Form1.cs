using System;
using System.Windows.Forms;

namespace Cong

{
    public partial class Form1 : Form
    {
        // Constructor khởi tạo giao diện
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện nút "Cộng"
        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                double tong = so1 + so2;
                lblKetQua.Text = "Kết quả: " + tong.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
