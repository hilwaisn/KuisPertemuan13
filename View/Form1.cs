using KuisPertemuan13.Controller;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan13
{
    public partial class Form1 : Form
    {
        private ProfilController profcontroller;

        public Form1()
        {
            profcontroller = new ProfilController();
            InitializeComponent();
        }
        bool verify()
        {
            if ((txtDel1.Text == "") || (txtDel2.Text == "") || (txtDel3.Text == "") || (txtDel4.Text == "") || (txtDel5.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDel1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDel2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDel3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDel4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDel5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTable();
        }
        private void showTable()
        {
            dataGridView1.DataSource = profcontroller.tampilProfil(new MySqlCommand("SELECT * FROM pegawai"));
            dataGridView1.RowTemplate.Height = 80;
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            showTable();
        }

        private void rbIslam_CheckedChanged(object sender, EventArgs e)
        {
            showTable1();
        }
        private void showTable1() { 
            dataGridView1.DataSource = profcontroller.tampilProfil1(new MySqlCommand("SELECT * FROM pegawai WHERE agama='Islam'"));
            dataGridView1.RowTemplate.Height = 60;
        }

        private void rbKristen_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = profcontroller.tampilProfil2(new MySqlCommand("SELECT * FROM pegawai WHERE agama='Kristen'"));
            dataGridView1.RowTemplate.Height = 60;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = profcontroller.searchPegawai(textBox1.Text);
            dataGridView1.RowTemplate.Height = 80;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    profcontroller.hapusPegawai(txtDel1.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Pegawai Deleted succesfully", "Delete Pegawai",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDel1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Pegawai not delete", "Delete Pegawai",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDel1.Clear();
            txtDel2.Clear();
            txtDel3.Clear();
            txtDel4.Clear();
            txtDel5.Clear();
        }


    }
}
