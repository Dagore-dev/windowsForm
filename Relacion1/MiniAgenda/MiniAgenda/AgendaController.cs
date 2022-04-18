using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAgenda
{
    class AgendaController
    {
        private DateTime current;

        public AgendaController ()
        {
            current = DateTime.Now;
        }
        
        public DateTime Date
        {
            get { return current; }
        }
        public int Day
        {
            get { return current.Day; }
        }
        public int Month
        {
            get { return current.Month; }
        }
        public int Year
        {
            get { return current.Year; }
        }
        public string Path
        {
            get
            {
                return $"{current.ToString("ddMMyyyy")}.txt";
            }
        }

        public void NextDay ()
        {
            current = current.AddDays(1);
        }
        public void PreviousDay ()
        {
            current = current.AddDays(-1);
        }

    }
}
