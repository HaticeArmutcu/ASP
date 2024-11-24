using System;
namespace ASP.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        // Navigation properties
        public ICollection<Taskk> Tasks { get; set; }
        public ICollection<Event> Events { get; set; }  // User'a ait Events
        public ICollection<Reminder> Reminders { get; set; }  // User'a ait Reminders
    }
}