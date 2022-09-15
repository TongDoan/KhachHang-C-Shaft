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
    public partial class Form1 : Form
    {
        double tienlai = 0;
        public Form1()
        {
            InitializeComponent();
            AddComboBox();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void newKH()
        {
            int kt = 1;
            if (textBox1.TextLength < 6)
            {
                MessageBox.Show("Nhập lại vì mã < 6");
                kt = 0;
            }
            if (textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Nhập lại vì tên hoặc địa chỉ rỗng");
                kt = 0;
            }

            if (kt == 1)
            {
                if (radioButton1.Checked == true)
                {
                    if (comboBox1.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(textBox4.Text) * 0.06;

                    }
                    if (comboBox1.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(textBox4.Text) * 0.07;

                    }
                    if (comboBox1.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(textBox4.Text) * 0.08;

                    }
                    if (comboBox1.SelectedItem == "12")
                    {
                        tienlai = Convert.ToDouble(textBox4.Text) * 0.09;
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if (comboBox1.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(textBox4.Text) * 0.07;

                    }
                    if (comboBox1.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(textBox4.Text) * 0.08;

                    }
                    if (comboBox1.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(textBox4.Text) * 0.09;

                    }
                    if (comboBox1.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(textBox4.Text) * 0.1;

                    }
                }


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            newKH();
            listBox1.Items.Add(textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text
                    + " | " + textBox4.Text + " | " + dateTimePicker1.Text + " | "
                    + comboBox1.Text + " tháng | " + tienlai);
            addList();
        }
        private void addList()
        {
            List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
            listNguoiGuis.Add(new NguoiGui(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text),
                dateTimePicker1.Text, comboBox1.Text, tienlai
              ));
           
            StaticData._NguoiGui = listNguoiGuis;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void AddComboBox()
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("12");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
