using Hostel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class Form1 : Form
    {
        HostelAppEntities db = new HostelAppEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            bool allempty = Extentions.isnotEmpty(new string[]
            {
                Email,Password
            }, string.Empty);
            if (allempty)
            {
                string AdminName = db.Admin.FirstOrDefault(a => a.Id == 1).Email;
                string AdminPassword = db.Admin.FirstOrDefault(a => a.Id == 1).Password;
                if(Email==AdminName && Password == AdminPassword)
                {
                    AdminDahboard ad = new AdminDahboard();
                    ad.ShowDialog();
                }
                else
                {
                    Worker wk = db.Worker.FirstOrDefault(a => a.Email == Email);
                    
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Please field all input";
            }
          
        }
    }
}
