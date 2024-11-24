namespace ASP.Models
{
    public class Taskk
    {
        public int Id { get; set; }  // Birincil Anahtar
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        // UserId: User ile ilişkiyi kuracak olan foreign key
        public string UserId { get; set; }  // Foreign Key (UserId)

        // Navigation property (Her görev bir kullanıcıya ait)
        public User User { get; set; }  // Taskk, bir User'a ait
    }
}


