using System;
using System.Collections.Generic;
using System.Text;
using XamaEvents.Models;

namespace XamaEvents.ViewModels
{
    public class DetailEventViewModel : BaseViewModel
    {
        public Event Event { get; set; }
        public DetailEventViewModel(Event item)
        {            
            Event = item;
        }
    }
}
