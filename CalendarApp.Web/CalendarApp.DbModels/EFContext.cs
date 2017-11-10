using CalendarApp.DbModels.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.DbModels
{
    public class EFContext : ApplicationDbContext
    {
        public IDbSet<Event> Events { get; set; }
    }
}
