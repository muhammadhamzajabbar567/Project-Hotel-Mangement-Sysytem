using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Hotelmanagementsystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            panelLeft.Height = btnHome.Height;
            panelLeft.Top = btnHome.Top;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            panelLeft.Height = btnHome.Height;
            panelLeft.Top = btnHome.Top;
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Baglioni Hotel London", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnAddRec.Height;
            panelLeft.Top = btnAddRec.Top;           
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();

        }

        private void btnViewFromDatabase_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
            this.Close();
         

            Thread.Sleep(5000);
            Form5 f5 = new Form5();
            f5.ShowDialog();
            panelLeft.Height = btnViewFromDatabase.Height;
            panelLeft.Top = btnViewFromDatabase.Top;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
          
            panelLeft.Height = btnFind.Height;
            panelLeft.Top = btnFind.Top;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
