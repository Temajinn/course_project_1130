using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project_parking
{
    public interface IVisit
    {
        void Visit(Client newClient);
        void VisitWithSort(Client newClient);
        void VisitToGet(Client client, int place_number);
    }
}
