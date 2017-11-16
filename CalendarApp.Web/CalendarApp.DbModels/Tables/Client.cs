using System.Collections.Generic;
using Newtonsoft.Json;

namespace CalendarApp.DbModels.Tables
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        [JsonIgnore]
        public virtual ICollection<Event> Events { get; set; }
    }
}
