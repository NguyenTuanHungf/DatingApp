namespace API.entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string? UserName { get; set;}

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalf { get; set; }



        
    }
}