using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelmanagementsystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCustomerRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementSystemDataSet.HMS' table. You can move, or remove it, as needed.
            this.hMSTableAdapter.Fill(this.hotelManagementSystemDataSet.HMS);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
