﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi.EventsDataBase.ModelsConvertion
{
/// <summary>
/// Class to convert data between Application
/// and Database
/// </summary>
    public class ConvertIntoDataBase
    {
        /// <summary>
        /// Method to convert DayBook from class Model to Database Model
        /// </summary>
        /// <param name="dayBook">DayBook model from class Model</param>
        /// <returns>Converted DayBook to DataBase Model</returns>
        public static Models.DayBook convertDayBook(WeatherApi.Models.DayBook dayBook) {
            Models.DayBook dataBaseDayBook = new Models.DayBook() { date = dayBook.date };
            List<Models.Event> events = new List<Models.Event>();
            foreach (var element in dayBook.eventList) {
                events.Add(new Models.Event() { eventDate = element.eventDate, location = element.location, title = element.title });
            }
            dataBaseDayBook.eventList = events;
            return dataBaseDayBook;
        }

        /// <summary>
        /// Method to convert Event from class Model to DataBase Model      
        /// </summary>
        /// <param name="eventFromClass">Event model from class Model</param>
        /// <returns>Converted Event to DataBase Model</returns>
        public static Models.Event convertEvent(WeatherApi.Models.Event eventFromClass) {
            return new EventsDataBase.Models.Event { title = eventFromClass.title, location = eventFromClass.location, eventDate = eventFromClass.eventDate };
        }
    }
}
