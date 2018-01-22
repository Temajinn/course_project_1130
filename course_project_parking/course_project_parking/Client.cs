using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace course_project_parking
{
    public class Client
    {
        public Client(Car car, string name, int placenumber, int days, DateTime dayOfAdd, bool discount)
        {
            m_car = car;
            m_name = name;
            m_days = days;
            m_placenumber = placenumber;
            m_dayOfAdd = dayOfAdd;
            m_discount = discount;
        }
        public string ConvertFieldsToString()
        {
            string discount = "";
            if (m_discount)
            {
                discount = "да";
            }
            else
            {
                discount = "нет";
            }
            string finalString = String.Format("{0}\t\t{1}\t\t{2}\t{3}\t\t{4}", m_name, m_car.ConvertFieldsToString(), Convert.ToString(m_placenumber), Convert.ToString(m_days),discount);
            return finalString;
        }
        public DateTime GetDayOfAdd()
        {
            return m_dayOfAdd;
        }
        public int GetNumberOfDays()
        {
            return m_days;
        }
        public void LoadFromFile(StreamReader LoadFile)
        {
            m_car = new Car(LoadFile.ReadLine(), LoadFile.ReadLine());
            m_name = LoadFile.ReadLine();
            m_days = Convert.ToInt32(LoadFile.ReadLine());
            m_placenumber = Convert.ToInt32(LoadFile.ReadLine());
            m_dayOfAdd = Convert.ToDateTime(LoadFile.Read());
            if (Convert.ToInt32(LoadFile.ReadLine()) == 0)
            {
                m_discount = true;
            }
            else
            {
                m_discount = false;
            }
        }
        public void SaveToFile(StreamWriter SaveFile)
        {
            SaveFile.WriteLine(m_car.GetMark());
            SaveFile.WriteLine(m_car.GetNumber());
            SaveFile.WriteLine(m_name);
            SaveFile.WriteLine("{0}", m_days);
            SaveFile.WriteLine("{0}", m_placenumber);
            SaveFile.WriteLine("{0}", m_dayOfAdd);
            if (m_discount)
            {
                SaveFile.WriteLine("0");
            }
            else
            {
                SaveFile.WriteLine("1");
            }
        }
        public int GetPlaceNumber()
        {
            return m_placenumber;
        }
        public string ReturnClientName()
        {
            return m_name;
        }
        private Car m_car;
        private string m_name;
        private int m_placenumber, m_days;
        private bool m_discount;
        private DateTime m_dayOfAdd;
    }
}
