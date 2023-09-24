using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LAB4.Form1;

namespace LAB4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numerFillings_ValueChanged(object sender, EventArgs e)
        {
            
        }




        private void btnDel_Click(object sender, EventArgs e)
        {
            

            // Xóa chọn cho tất cả các checkbox
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            // Đặt giá trị của numerFillings về 0
            numerFillings.Value = 0;

            // Xóa nội dung trong textbox "Customer Name"
            textName.Text = "";

            // Đặt tổng giá về 0 và hiển thị nó trong textTotal
            textTotal.Text = "0";
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có tên khách hàng và không có checkbox nào được chọn
            if (string.IsNullOrWhiteSpace(textName.Text) && !checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Please enter customer name and select atleast 1 service.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Ngăn chặn tính toán tổng giá
            }


            // Kiểm tra nếu không có tên khách hàng và không có checkbox được chọn
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Please enter customer name ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Ngăn chặn tính toán tổng giá
            }

            // Kiểm tra nếu có tên khách hàng nhưng không có checkbox nào được chọn
            bool hasCheckedService = checkBox1.Checked || checkBox2.Checked || checkBox3.Checked;

            // Kiểm tra xem có dịch vụ nào được chọn không
            if (!hasCheckedService)
            {
                MessageBox.Show("Please select at least 1 service.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Ngăn chặn tính toán tổng giá
            }

            if (checkBox3.Checked && numerFillings.Value == 0)
            {
                MessageBox.Show("Please enter quantity for Fillings.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Ngăn chặn tính toán tổng giá
            }

            if ((string.IsNullOrWhiteSpace(textName.Text) && (checkBox3.Checked && numerFillings.Value == 0)))
            {
                MessageBox.Show("Please enter customer name and quantity for Fillings. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Ngăn chặn tính toán tổng giá
            }

            // Khởi tạo biến tổng giá
            decimal total = 0;


            // Kiểm tra và tính giá dựa vào trạng thái của các checkbox
            if (checkBox1.Checked)
            {
                // Scrape Tartar được chọn, cộng thêm 3,000 vào tổng
                total += 3000;
            }

            if (checkBox2.Checked)
            {
                // Teeth Whitening được chọn, cộng thêm 5,000 vào tổng
                total += 5000;
            }

            if (checkBox3.Checked)
            {
                // Lấy số lượng items từ numeric up-down control numerFillings
                int numberOfFillings = (int)numerFillings.Value;

                // Tính giá dựa trên số lượng items và giá mỗi item (1,000$ mỗi item)
                total += numberOfFillings * 1000;
            }

            // Hiển thị tổng trong text box textTotal
            textTotal.Text = total.ToString("C"); // Định dạng giá tiền

            // Lưu ý rằng bạn có thể thêm logic xử lý cho Fillings ở đây tương tự
        }

        

        



    }

}
