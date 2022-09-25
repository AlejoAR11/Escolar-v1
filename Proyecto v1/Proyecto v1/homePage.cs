using System;
using System.Windows.Forms;

namespace Proyecto_v1
{


    public partial class home : Form
    {

        public home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin master = new Admin();
            master.Show();
            this.Hide();
        }
    }
}
