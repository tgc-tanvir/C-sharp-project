﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace BookStoreApplication
{
    public partial class AdminPanel : Form
    {
        string user = "";
        public AdminPanel()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public AdminPanel(string username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            uC_ViewUser2.ID = ID;
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            uC_Adduser2.Visible = true;
            uC_Adduser2.BringToFront();
            uC_Dashbord1.Visible = false;
            uC_ViewUser2.Visible = false;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            uC_Dashbord1.Visible = true;
            uC_Adduser2.Visible = false;
            uC_ViewUser2.Visible = false;
          

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Lginform lg = new Lginform();
            lg.Show();
            this.Hide();
        }

        private void uC_Adduser1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser2.Visible = true;
            uC_ViewUser2.BringToFront();
            uC_Dashbord1.Visible = false;
            uC_Adduser2.Visible=false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
             uC_Dashbord1.Visible = true;
             uC_Dashbord1.BringToFront();
             uC_Adduser2.Visible=false;
             uC_ViewUser2.Visible=false;
        }

        private void uC_Dashbord1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_ViewUser2_Load(object sender, EventArgs e)
        {

        }

        private void uC_Adduser2_Load(object sender, EventArgs e)
        {

        }
    }
}
