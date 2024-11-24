using ASP.Models;

public class Reminder
{
    public string ReminderID { get; set; }  // Birincil Anahtar
    public string UserID { get; set; }  // Foreign Key
    public string ReminderText { get; set; }
    public DateTime ReminderDateTime { get; set; }

    public User User { get; set; }  // Reminder bir User'a ait olduğunu belirtiyoruz
}