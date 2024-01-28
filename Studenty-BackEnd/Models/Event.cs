using System.ComponentModel.DataAnnotations;

namespace Studenty_BackEnd.Models
{
    /*{
        public int id { get; set; }
        public string name { get; set; }
        public DateTime start { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public bool type { get; set; }
        public bool isInsideUniversity { get; set; }

        public string appName { get; set; }
        public string appLink { get; set; }

        public string locationState { get; set; }
        public string locationPlace_name { get; set; }
        public string locationLink { get; set; }
        public string locationDescription { get; set; }
    }*/

    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public DateTime StartDateTime { get; set; }

        //public int CategoryId { get; set; } // Assuming category is represented by an ID

        //public string Description { get; set; }

        //public string Type { get; set; } // Physical or Virtual

        //public Location Location { get; set; } // Object for physical location details

        //public string Platform { get; set; } // For virtual events

        //public string Link { get; set; }
    }

}
