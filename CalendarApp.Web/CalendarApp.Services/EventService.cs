using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarApp.DbModels;
using CalendarApp.DbModels.Tables;

namespace CalendarApp.Services
{
    public class EventService
    {
        DataContext _context;
        public EventService()
        {
            _context = new DataContext();
        }
        public List<Event> GetList()
        {
            try
            {
                var list = _context.Events.ToList();
                return list;
            }
            catch 
            {
                return null;
            }
        }
    }
}
