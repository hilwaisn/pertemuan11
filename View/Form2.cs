using pertemuan11.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan11.View
{
    public partial class Form2 : Form
    {
        private BarangController barangController;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            barangController = new BarangController();
            barangController.tambahBarang(textBox1.Text, textBox2.Text, textBox3.Text, 
                textBox4.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            textBox1.Focus();
            MessageBox.Show("data disimpan");
            Form1 lk = new Form1();

            lk.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 lk = new Form1();
            lk.Show();
            this.Hide();
        }
    }
}
