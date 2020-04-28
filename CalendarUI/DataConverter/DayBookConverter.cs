﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarUI.DataConverter
{
    /// <summary>
    /// Class to convert data download in 
    /// json format to string ready to 
    /// display in User Inferface Window
    /// </summary>
    class DayBookConverter
    {
        /// <summary>
        /// Method to create String in right format for the client
        /// </summary>
        /// <param name="listOfDayBooks">DayBook object</param>
        /// <returns>String ready to display</returns>
        public static String getDayBooks(Models.DayBook listOfDayBooks) {
            var allEventsTable = new StringBuilder();
            allEventsTable.AppendLine($"--------- {listOfDayBooks.date.Day}.{listOfDayBooks.date.Month}.{listOfDayBooks.date.Year} -----------");
            allEventsTable.AppendLine("Title\tLocation");
            foreach (var dayBook in listOfDayBooks.eventList) {
                    allEventsTable.AppendLine($"{dayBook.title}\t{dayBook.location}");
            }
            return allEventsTable.ToString();
        }

        /// <summary>
        /// Method to create String in right format with all Events from DataBase
        /// </summary>
        /// <param name="listOfDayBooks">List of all events</param>
        /// <returns>String ready to display</returns>
        public static String getAllEvents(List<Models.Event> listOfAllEvents) {
            //var allEventsTable = new System.Text.StringBuilder();
            //allEventsTable.Append("Date\tTitle\tLocation\t");
            //foreach (var daybook in listOfDayBooks) {
            //    allEventsTable.AppendLine($"--------- {daybook.date.Day}.{daybook.date.Month}.{daybook.date.Year} -----------");
            //    allEventsTable.AppendLine("Title\tLocation");
            //    foreach (var oneEvent in daybook.eventList) {
            //        allEventsTable.AppendLine($"{oneEvent.title}\t{oneEvent.location}");
            //    }
            //}
            //return allEventsTable.ToString();
            var allEventsTable = new System.Text.StringBuilder();
            foreach (var dayBookEvent in listOfAllEvents)
            {
                allEventsTable.AppendLine($"{dayBookEvent.title}\t{dayBookEvent.location}");
            }
            return allEventsTable.ToString();
        }
    }
}
