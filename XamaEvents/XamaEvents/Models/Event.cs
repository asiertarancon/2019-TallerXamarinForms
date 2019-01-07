using System;
using System.Collections.Generic;
using System.Text;

namespace XamaEvents.Models
{
    public class Event
    {
        public string Id { get; set; }
        public string Title { get; set; }        
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public string Organizer { get; set; }
    }
}
