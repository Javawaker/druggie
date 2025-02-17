namespace DruggieLibrary
{

    public class UserModel
    {
        public string Username { get; set; }
        public string UserMode_name { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }

        public UserModel() { }
        public UserModel(UserModel user)
        {
            Username = user.Username;
            Hash = user.Hash;
            UserMode_name = user.UserMode_name;
        }
    }
}