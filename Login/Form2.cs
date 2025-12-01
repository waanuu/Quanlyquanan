using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Trangchu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            HideAllPanels();
       
            Trangchu.Visible = true;

            Trangchu.BringToFront();
        }

        private void btn_them_dm_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
        }

        private void btn_sua_dm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = textBox1.Text;
                dataGridView1.SelectedRows[0].Cells[1].Value = textBox2.Text;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btn_xoa_dm_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            danhmuc.Visible = true;

            danhmuc.BringToFront();
        }

        private void btn_lammoi_dm_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void btn_lammoi_dm_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thucdon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_them_td_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(textBox4.Text, comboBox1.Text, textBox3.Text,textBox9.Text);
        }

        private void btn_sua_td_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.SelectedRows[0].Cells[0].Value = textBox4.Text;
                dataGridView2.SelectedRows[0].Cells[1].Value = comboBox1.Text;
                dataGridView2.SelectedRows[0].Cells[2].Value = textBox3.Text;
                dataGridView2.SelectedRows[0].Cells[3].Value = textBox9.Text;
            }
            
        }

        private void btn_xoa_td_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }

        private void btn_lammoi_td_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = 0;
            textBox9.Clear();
            textBox4.Focus();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBox4.Text = row.Cells[0].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox9.Text = row.Cells[3].Value.ToString();
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            Thucdon.Visible = true;

            Thucdon.BringToFront();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_ban_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add(textBox6.Text,textBox5.Text,textBox7.Text);
        }

        private void btn_sua_ban_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                dataGridView3.SelectedRows[0].Cells[0].Value = textBox6.Text;
                dataGridView3.SelectedRows[0].Cells[1].Value = textBox5.Text;
                dataGridView3.SelectedRows[0].Cells[2].Value = textBox7.Text;
            }
        }

        private void btn_xoa_ban_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
        }

        private void btn_lammoi_ban_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox6.Focus();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_lammoi_ban_Click_1(object sender, EventArgs e)
        {

        }

        private void customButton4_Click_1(object sender, EventArgs e)
        {
            HideAllPanels();

            banan.Visible = true;

            banan.BringToFront();
        }
        private void HideAllPanels()
        {
            Trangchu.Visible = false;
            Thucdon.Visible = false;
            banan.Visible = false;
            danhmuc.Visible = false;
            hoadon.Visible = false;
        }

        private void customButton2_Click_1(object sender, EventArgs e)
        {
            HideAllPanels();

            danhmuc.Visible = true;

            danhmuc.BringToFront();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView4.Rows.Add(comboBox3.Text, numericUpDown2.Value.ToString());
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            hoadon.Visible = true;

            hoadon.BringToFront();
        }
    }
}
