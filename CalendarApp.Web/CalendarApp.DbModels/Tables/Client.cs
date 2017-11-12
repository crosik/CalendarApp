using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.DbModels.Tables
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
    }
}
