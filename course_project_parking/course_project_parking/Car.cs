using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project_parking
{
    public class Car
    {
        public string ConvertFieldsToString()
        {
            string finalString = String.Format("{0}\t{1}", m_mark, m_number);
            return finalString;
        }
        public string GetNumber()
        {
            return m_number;
        }
        public string GetMark()
        {
            return m_mark;
        }
        public Car()
        {
            m_number = "Unknown";
            m_mark = "Unknown";
        }
        public Car(string mark, string number)
        {
            m_number = number;
            m_mark = mark;
        }
        public Car(Car prevcar)
        {
            m_number = prevcar.m_number;
            m_mark = prevcar.m_mark;
        }
        string m_number, m_mark;
    }
}
