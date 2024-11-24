using ASP.Models;

public class Event
{
    public string EventID { get; set; }  // Birincil Anahtar
    public string UserID { get; set; }
    public string EventName { get; set; }
    public string EventDescription { get; set; }
    public DateTime EventDate { get; set; }

    public User User { get; set; }
}
