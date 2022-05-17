using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    abstract class User
    {
        static protected string Name { get; set; }

        List<DateTime> loginDate = new();

        public void AddLoginDate(int year, int mounth, int day)
        {
            loginDate.Add(new DateTime(year, mounth, day));
        }

        public void SortDate()
        {
            loginDate.Sort(delegate (DateTime date1, DateTime date2)
            {
                return date1.CompareTo(date2);
            });
        }

        public void ShowLoginDates()
        {
            Console.WriteLine("Пользователь {0} заходил на сайт:\n{1}\n{2}\n{3}", Name, loginDate[0].ToShortDateString(), loginDate[1].ToShortDateString(), loginDate[2].ToShortDateString());
        }




    }
}
