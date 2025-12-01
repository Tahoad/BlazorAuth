namespace BlazorAuth.Data
{
    public class User
    {
        public int Id { get; set; }
        public string user_name { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;

        public List<User> GetUser()
        {
            return new List<User> {
                new User
                {
                    Id = 1,
                    user_name = "admin",
                    password = "admin123",
                    role = "Administrator",
                },
                new User
                {
                     Id = 2,
                    user_name = "user",
                    password = "user123",
                    role = "User",
                }
            };
        }
    }
}
