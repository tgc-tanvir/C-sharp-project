using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication.AdministratorUC
{
    public partial class UC_Dashbord : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public UC_Dashbord()
        {
            InitializeComponent();
        }

        private void UC_Dashbord_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Admin User'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);
            query = "select count(bookTitle) from allbooks";
            ds = fn.getData(query);
            setLabel(ds, BookLabel);
            /*query = "select count(customer) from Order";
            ds=fn.getData(query);
            setLabel(ds, BuyLabel);*/
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }
    }
}
