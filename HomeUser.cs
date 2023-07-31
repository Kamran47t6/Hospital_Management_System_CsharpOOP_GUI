using Hospital.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class HomeUser : Form
    {
        public HomeUser()
        {
            InitializeComponent();
        }

        private void HomeUser_Load(object sender, EventArgs e)
        {
            timerUser.Start();
        }

        private void timerUser_Tick(object sender, EventArgs e)
        {
            timerUser.Stop();
            this.Close();

            UserForm userForm = new UserForm(this);
            userForm.Show();
        }

        private void lblheader_Click(object sender, EventArgs e)
        {

        }
    }
}
