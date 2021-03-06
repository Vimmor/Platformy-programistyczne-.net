﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarTests
{
    /// <summary>
    /// Class to test daybook model
    /// </summary>
    class DayBookTest
    {
        /// <summary>
        /// Method to test if initialization an object is correct
        /// </summary>
        [Test]
        public void DayBook_WhenCreatingObjectWithInitializationParams_ParamsSetCorrectly() {
            var testDayBook = new WeatherApi.Models.DayBook();
            testDayBook.date = DateTime.Parse("25/09/2021");
            var comparativeDayBook = new WeatherApi.Models.DayBook() { date = DateTime.Parse("25/09/2021"), eventList = null};
            Assert.AreEqual(testDayBook.date, comparativeDayBook.date);
            Assert.AreNotEqual(testDayBook.eventList, comparativeDayBook.eventList);
        }

        /// <summary>
        /// Method to test convert correctness from class model to 
        /// database model
        /// </summary>
        [Test]
        public void DayBook_ConvertFromClassIntoDatabase_ConvertedDayBook() {
            var testDayBook = new WeatherApi.Models.DayBook() { date = DateTime.Parse("25/09/2021") };
            var comparativeDayBook = WeatherApi.EventsDataBase.ModelsConvertion.ConvertIntoDataBase.convertDayBook(testDayBook);
            Assert.AreEqual(testDayBook.date, comparativeDayBook.Date);
            Assert.AreEqual(testDayBook.eventList, comparativeDayBook.EventList);
        }

        /// <summary>
        /// Method to test convert correctness from database model
        /// to class model
        /// </summary>
        [Test]
        public void DayBook_ConvertFromDataBaseIntoClass_ConvertedDayBook() {
            var testDayBook = new WeatherApi.EventsDataBase.Models.DayBook() { Date = DateTime.Parse("25/09/2021"), Id = 1 };
            var comparativeDayBook = WeatherApi.EventsDataBase.ModelsConvertion.ConvertIntoClass.convertDayBook(testDayBook);
            Assert.AreEqual(testDayBook.Date, comparativeDayBook.date);
            Assert.AreEqual(testDayBook.EventList, comparativeDayBook.eventList);
        }
    }
}
