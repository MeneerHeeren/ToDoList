using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ToDoV3
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateTest { get; set; } // kan ik hier formatten? Of toch in de XAML? Ik wil dat DateTime alleen date teruggeeft en ook nog die van vandaag pakt.


        public DateTime Time { get; set; }

        public override string ToString()
        {
            return string.Format("[Item: ID={0}, Title={1}, Date={2}, Time={3}]", ID, Title, Date, Time);
        }
    }
}
