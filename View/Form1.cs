using MySqlConnector;
using pertemuan11.Controller;
using pertemuan11.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan11
{
    public partial class Form1 : Form
    {
        private BarangController barangController;
        public Form1()
        {
            barangController = new BarangController();
            InitializeComponent();
        }

        bool verify()
        {
            if ((txtDelete1.Text == "") || (txtDelete2.Text == "") || (txtDelete3.Text == "") ||
                (txtDelete4.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form3 update = new Form3();
            update.Show();
            this.Hide();

            update.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void showTable()
        {
            dataGridView1.DataSource = barangController.selectBarang(new MySqlCommand("SELECT * FROM barang"));
            dataGridView1.RowTemplate.Height = 80;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDelete1.Clear();
            txtDelete2.Clear();
            txtDelete3.Clear();
            txtDelete4.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    barangController.hapusbarang(txtDelete1.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Barang Deleted succesfully", "Delete Barang",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDelete1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Barang not delete", "Delete Barang",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDelete1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDelete2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDelete3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDelete4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void printDocumentBarang_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(btm, 45, 170);
            e.Graphics.DrawString(lblBarang.Text, new Font("Calibri", 23, FontStyle.Bold), Brushes.Black, new Point
                (185, 100));
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = barangController.searchBarang(txtForSearch.Text);
            dataGridView1.RowTemplate.Height = 20;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            printDialogBarang.Document = printDocumentBarang;
            printDialogBarang.ShowDialog();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(34, 36, 49);
                lblBarang.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                lblBarang.ForeColor = Color.Black;
            }
        }
    }
}