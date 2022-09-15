using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHang
{
    public partial class Form2 : Form
    {
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
        public Form2()
        {
            InitializeComponent();
            listNguoiGuis = StaticData._NguoiGui;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int timthay = 0;
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.MaKH1 == Convert.ToInt32(textBox1.Text))
                {
                    timthay = 1;
                    textBox2.Text = "Khách hàng " + i.TenKH1 + " phải trả"
                        + i.Tien1 + " nghìn đồng";

                }
            }

            if (timthay == 0)
            {
                textBox2.Text = "Khách hàng " + textBox1.Text + " không có trong danh sách";

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
