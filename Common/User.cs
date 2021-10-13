namespace Common
{
    public class User
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Hash { get; set; }

        public bool IsActive { get; set; }
    }
}
