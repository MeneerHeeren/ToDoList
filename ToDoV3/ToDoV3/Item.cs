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

        public string Date { get; set; }

        public string Time { get; set; }

        public override string ToString()
        {
            return string.Format("[Item: ID={0}, Title={1}, Date={2}, Time={3}]", ID, Title, Date, Time);
        }
    }
}
