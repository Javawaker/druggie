namespace DruggieLibrary
{
    public class UserDrugModel
    {
        public string User_username { get; set; }
        public string Drug_name { get; set; }
        public int Quantity { get; set; }

        public UserDrugModel() { }
        public UserDrugModel(string user_username, string drug_name, int quantity)
        {
            User_username = user_username;
            Drug_name = drug_name;
            Quantity = quantity;
        }
    }
}
