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
    public partial class Parking_plan : Form, IVisit
    {
        
        public Parking_plan()
        {
            InitializeComponent();
        }
        public void CheckIfPlaceFree(int place_number)
        {
            if (ParkingFabric.m_parking.GetListOfClients().Any(element => element.GetPlaceNumber() == place_number))
            {
                ParkingFabric.m_parking.GetRightClient(this, place_number);
            }
            else
            {
                MessageBox.Show("Место свободно.");
            }
        }
        public void VisitToGet(Client newClient, int place_number)
        {
            if (newClient.GetPlaceNumber() == place_number)
            {
                MessageBox.Show(newClient.ReturnClientName(), "Место занято", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void Visit(Client newClient)
        {

        }
        public void VisitWithSort(Client newClient)
        {

        }

        private void btn_place1_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(1);
        }

        private void btn_place2_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(2);
        }

        private void btn_place_3_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(3);
        }

        private void btn_place4_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(4);
        }

        private void btn_place5_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(5);
        }

        private void btn_place6_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(6);
        }

        private void btn_place7_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(7);
        }

        private void btn_place8_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(8);
        }

        private void btn_place9_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(10);
        }

        private void btn_place11_Click(object sender, EventArgs e)
        {
            CheckIfPlaceFree(11);
        }
    }
}
