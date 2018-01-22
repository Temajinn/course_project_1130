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
    public partial class ClientList : Form, IVisit
    {
        public ClientList()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addNewClient = new AddClientForm();
            addNewClient.ShowDialog();
            if (addNewClient.DialogResult == DialogResult.OK)
            {
                ParkingFabric.AddNewClientToList(addNewClient.CreateNewClient());
            }
            FillListOfClients();
        }
        public void Visit(Client newClient)
        {
            lstbxClienList.Items.Add(newClient.ConvertFieldsToString());
        }
        public void VisitWithSort(Client newClient)
        {
            if (newClient.GetDayOfAdd().AddDays(Convert.ToDouble(newClient.GetNumberOfDays())) < DateTime.Today)
            {
                lstbxClienList.Items.Add(newClient.ConvertFieldsToString());
            }
        }
        public void VisitToGet(Client newClient, int place_number)
        {

        }
        private void btnShowDebtors_Click(object sender, EventArgs e)
        {
            lstbxClienList.Items.Clear();
            string head = "Фамилия Имя\t\tМарка\tНомер\tНомер места\tКоличество дней\tДисконтная карта";
            lstbxClienList.Items.Add(head);
            ParkingFabric.m_parking.VisitEachClientAndSort(this);
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            FillListOfClients();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CalculateForm calculateCosts = new CalculateForm();
            calculateCosts.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFDClientFile.ShowDialog() == DialogResult.OK)
            {
                if (openFDClientFile.CheckFileExists)
                {
                    ParkingFabric.m_parking.LoadClientsFromFile(openFDClientFile.FileName);
                    FillListOfClients();
                }
            }   
            openFDClientFile.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFDClientList.ShowDialog() == DialogResult.OK)
            {
                if (saveFDClientList.CheckFileExists)
                {
                    ParkingFabric.m_parking.SaveToFile(saveFDClientList.FileName);
                    saveFDClientList.Dispose();
                }
            }

        }
        public void FillListOfClients()
        {
            lstbxClienList.Items.Clear();
            string head = "Фамилия Имя\t\tМарка\tНомер\tНомер места\tКоличество дней\tДисконтная карта";
            lstbxClienList.Items.Add(head);
            ParkingFabric.m_parking.ForeachClient(this);
        }

        private void btnReturnToMainList_Click(object sender, EventArgs e)
        {
            FillListOfClients();
        }

    }
}
