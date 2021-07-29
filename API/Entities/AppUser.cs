namespace API.Entities
{
    public class AppUser
    {
        // ahmad vs issa pes 7 matches won
        public int ID { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt {get; set;}
    }
}