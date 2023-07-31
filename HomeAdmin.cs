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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            timerAdmin.Start();
        }

        private void timerAdmin_Tick(object sender, EventArgs e)
        {
            timerAdmin.Stop();
            this.Hide();

            AdminForm adminForm = new AdminForm(this);
            adminForm.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
