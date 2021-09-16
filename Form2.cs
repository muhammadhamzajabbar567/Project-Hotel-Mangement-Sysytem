using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;

using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Text.RegularExpressions;

namespace Hotelmanagementsystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MALSR5\OMAR;Initial Catalog=HotelManagementSystem;Integrated Security=True");
        private void btnexitform2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
      


        private void textBoxusername_TextChanged(object sender, EventArgs e)
        {
            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", textBoxusername, pictureBox4);
        }
       

            private void textBoxusername_Enter(object sender, EventArgs e)
        {
            if (textBoxusername.Text == "Username")
            {
                textBoxusername.Text = "";
            }
            
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
            }
         
        }

        private void textBoxusername_Leave(object sender, EventArgs e)
        {
            if (textBoxusername.Text == "")
            {
                textBoxusername.Text = "Username";
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

          

            con.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [Username] WHERE ([UserName] = @user)", con);
            check_User_Name.Parameters.AddWithValue("@user", textBoxusername.Text);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            
            check_User_Name.ExecuteNonQuery();
           
          
            con.Close();
            con.Open();
            SqlCommand check_User_Pass = new SqlCommand("SELECT COUNT(*) FROM [Password] WHERE ([PassWord] = @pass)", con);
            check_User_Pass.Parameters.AddWithValue("@pass", textBoxPassword.Text);
            int PassExist = (int)check_User_Pass.ExecuteScalar();

            check_User_Pass.ExecuteNonQuery();

            if (PassExist > 0 && UserExist>0)
            {
                //Username exist
             
                Form7 f7 = new Form7();
                f7.ShowDialog();             
                Thread.Sleep(2000);            
                this.Hide();
                Form4 f4 = new Form4();
                f4.ShowDialog();
                this.Close();
                
               

            }
            else
            {
                MessageBox.Show("You have entered a wrong ID or Password!");
                //Username doesn't exist.
            }
            con.Close();
         
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
        public void Regexp(string re, TextBox tb, PictureBox pc)
        {

            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.verified_account_24px;


            }
            else
            {
                pc.Image = Properties.Resources.delete_16px;


            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            Regexp(@"^([A-Za-z]{4,9})([0-9]{3})$", textBoxPassword, pictureBox3);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
           
        }
    }
}
