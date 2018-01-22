using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace course_project_parking
{
    public class Parking
    {
        public void AddClientToList(Client newClient)
        {
            m_clientList.Add(newClient);
        }
        public List<Client> GetListOfClients()
        {
            return m_clientList;
        }
        public void LoadClientsFromFile(string path)
        {
            StreamReader ClientFile = new StreamReader(path);
            foreach (Client element in m_clientList)
            {
                element.LoadFromFile(ClientFile);
            }
        }
        public void SaveToFile(string path)
        {
            StreamWriter SaveFile = new StreamWriter(path);
            foreach (Client element in m_clientList)
            {
                element.SaveToFile(SaveFile);
            }
        }
        public void VisitEachClientAndSort(IVisit visitor)
        {
            foreach (Client element in m_clientList)
            {
                visitor.VisitWithSort(element);
            }
        }
        public void ForeachClient(IVisit visitor)
        {
            foreach (Client client in m_clientList)
            {
                visitor.Visit(client);
            }
        }
        public void GetRightClient(IVisit visitor, int place_number)
        {
            foreach (Client element in m_clientList)
            {
                visitor.VisitToGet(element, place_number);
            }
        }
        private List<Client> m_clientList = new List<Client>();
    }
}
