using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqliteDemo.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public string PassWord { get; set; }        

        public DateTime CreateTime { get; set; }

    }
}