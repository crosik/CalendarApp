using System.Collections.Generic;
using Newtonsoft.Json;

namespace CalendarApp.DbModels.Tables
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phonenumber { get; set; }
        [JsonIgnore]
        public virtual ICollection<Event> Events { get; set; }
    }
}
