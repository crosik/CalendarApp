using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarApp.DbModels.Tables;

namespace CalendarApp.Dto
{
    public class EventDTO
    {
        public EventDTO(Event e)
        {
            EventId = e.EventId;
            Subject = e.Subject;
            Description = e.Description;
            Start = e.Start;
            End = e.End;
            ThemeColor = e.ThemeColor;
            IsFullDay = e.IsFullDay;
        }
        public int EventId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
    }

    public static class EventExtension
    {
        public static List<EventDTO> ConvertGroup(List<Event> events)
        {
            var eventDtoList = new List<EventDTO>();
            foreach (var @event in events)
            {
                var eventDto = new EventDTO(@event);
                eventDtoList.Add(eventDto);
            }
            return eventDtoList;
        }
    }
}
