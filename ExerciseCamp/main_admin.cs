﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseCamp
{
    public partial class main_admin : Form
    {
        public main_admin()
        {
            InitializeComponent();
        }

        private void main_admin_Load(object sender, EventArgs e)
        {
            string d = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            string t = DateTime.Now.ToString("t");
            lblDate.Text = d.ToString();
            lblTime.Text = t.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Show();
            this.Hide();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_password i = new change_password();
            i.Show();
            this.Hide();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            master_book i = new master_book();
            i.Show();
        }

        private void depositPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deposit_payment i = new deposit_payment();
            i.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            @return i = new @return();
            i.Show();
        }

        private void allTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
