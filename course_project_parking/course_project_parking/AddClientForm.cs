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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public Client CreateNewClient()
        {
            Car newcar = new Car(txtbxmark.Text, txtbxnumber.Text);
            string name = txtbxfio.Text;
            int placenumber = Convert.ToInt32(txtbxparknumber.Text),
                days = Convert.ToInt32(txtbxdaysnumb.Text);
            bool disc = chbxdiscount.Checked ? true : false;
            Client newClient = new Client(newcar,name,placenumber,days, DateTime.Today, disc);
            return newClient;
        }
    }
}
