using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project_parking
{
    public static class ParkingFabric
    {
        public static void AddNewClientToList(Client newClient)
        {
            m_parking.AddClientToList(newClient);
        }
        public static Parking m_parking = new Parking();
    }
}
