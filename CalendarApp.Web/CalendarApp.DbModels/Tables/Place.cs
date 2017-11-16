using System.Collections.Generic;
using Newtonsoft.Json;

namespace CalendarApp.DbModels.Tables
{
    public class Place
    {
        public int PlaceId { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Event> Events { get; set; }
    }
}
