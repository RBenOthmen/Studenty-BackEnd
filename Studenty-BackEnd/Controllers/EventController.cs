using Microsoft.AspNetCore.Mvc;
using Studenty_BackEnd.Models;

namespace Studenty_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private static readonly Event[] events = new[]
        {
            new Event
            {
                Id = 1,
                Name = "Introduction to Machine Learning"
            }
            // Add more events if needed
        };

        [HttpGet(Name = "GetEvent")]
        public ActionResult<Event[]> GetAllEvents()
        {
            return events;
        }

        // ... Implementation for other CRUD endpoints
    }
}
