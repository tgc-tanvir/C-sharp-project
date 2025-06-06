﻿using System;
using System.Data;
using System.Windows.Forms;

namespace BookStoreApplication.AdministratorUC
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        string query;
        string currentUser = "";
        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { currentUser = value; }
        }
        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '" + txtUserName.Text + "%'";
            DataSet ds = fn.getData(query);
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        string userName;
        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = gunaDataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                
                if (MessageBox.Show("Are you sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (currentUser != userName)
                    {
                        query = "delete from users where username='" + userName + "'";
                        fn.setData(query, "User Record Deleted.");
                        UC_ViewUser_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("You are trying to delete yourself!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

    

        private void btnSync_Click(object sender, EventArgs e)
        {
            
            UC_ViewUser_Load(this, null);

        }
    }
}
