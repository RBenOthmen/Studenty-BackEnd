using Studenty_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using MySqlConnector; // NuGet package for MySQL connectivity

namespace Studenty_BackEnd.Services
{
    public class EventService
    {
        static List<Event> Events { get; }

        static EventService()
        {
            Events = new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "Introduction to Machine Learning",
                    /*StartDateTime = DateTime.Parse("2024-02-15T10:00:00"),
                    CategoryId = 2,
                    Description = "Learn the fundamentals of machine learning algorithms and techniques.",
                    Type = "Virtual",
                    Platform = "Zoom",
                    Link = "https://zoom.us/j/1234567890"*/
                }/*,

                new Event
                {
                    Id = 2,
                    Name = "Campus Hackathon",
                    StartDateTime = DateTime.Parse("2024-03-01T14:00:00"),
                    CategoryId = 3,
                    Description = "Join the coding challenge and unleash your creative solutions!",
                    Type = "Physical",
                    Location = new Location
                    {
                        Type = "Inside University",
                        State = "CA",
                        PlaceName = "Main Auditorium",
                        Link = "https://maps.google.com/?q=University+Main+Auditorium",
                        Description = "The auditorium located in the center of the campus."
                    }
                }*/

            };
        }

        public static List<Event> GetAll() => Events;
    }

    /*{
        
        
            private static List<Event> _events = new List<Event>(); // Static storage for events

            static EventService()
            {
                // Initialize events with sample data (replace with your actual data)
                _events.Add(new Event
                {
                    // ...
                });
                // ...
            }

            public IEnumerable<Event> GetAllEvents()
            {
                return _events;
            }

            // Implementation for other CRUD methods using the static _events list

            public Event CreateEvent(Event eventToCreate)
            {
                eventToCreate.Id = _events.Max(e => e.Id) + 1; // Assign a new ID
                _events.Add(eventToCreate);
                return eventToCreate;
            }

            // ... (implementation for ReadEventById, UpdateEvent, DeleteEvent)
    }*/
}

