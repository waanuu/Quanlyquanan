using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Login
{
    public partial class Form1 : Form
    {
        private string connect = @"Data Source=QUAN\SQLEXPRESS;Initial Catalog=MonAn;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(connect);
            string username = textBox1.Text;
            string password = textBox2.Text;
            try
            {
               
                string query = "SELECT * FROM Login WHERE username = '"+textBox1.Text+"'AND password = '"+textBox2.Text+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                sql.Close(); 
            }
        }
        bool isPasswordHidden = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                textBox2.PasswordChar = '\0';        
                isPasswordHidden = false;
            }
            else
            {
                textBox2.PasswordChar = '●';        
                isPasswordHidden = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
