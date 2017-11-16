using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace CalendarApp.DbModels.Tables
{
    public class Event
    {
        public int EventId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
        [ScriptIgnore]
        public virtual Client Client { get; set; }
        [ScriptIgnore]
        public virtual Place Place { get; set; }
        [ScriptIgnore]
        public virtual ICollection<User> Users { get; set; }
    }
}
