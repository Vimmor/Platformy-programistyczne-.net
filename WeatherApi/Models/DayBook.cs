﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi.Models
{
    public class DayBook
    {
        public List<Event> eventList { get; set; }
        public DateTime date { get; set; }
    }
}