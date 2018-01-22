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
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            OutputResult(Count());
        }
        public double Count()
        {
            double result = 0;
            if (rbtnTariffEconomic.Checked)
            {
                result = 50*(Convert.ToInt32(txtbxNumberOfDays.Text))/3 + 400*(Convert.ToInt32(txtbxNumberOfDays.Text)/3);
            }
            else
            {
                result = 200* (Convert.ToInt32(txtbxNumberOfDays.Text));
            }
            if (chbxDiscount.Checked)
            {
                result = result*0.95;
            }
            return result;
        }
        public void OutputResult(double result)
        {
            lblResult.Text = String.Format("В результате вы заплатите: {0:f2} рублей", result);
        }
    }
}
