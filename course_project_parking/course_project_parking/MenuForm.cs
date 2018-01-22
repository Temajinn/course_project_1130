using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project_parking
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncllist_Click(object sender, EventArgs e)
        {
            ClientList cl = new ClientList();
            cl.Show();
        }

        private void btnparkmap_Click(object sender, EventArgs e)
        {
            Parking_plan pp = new Parking_plan();
            pp.Show();
        }
    }
}
