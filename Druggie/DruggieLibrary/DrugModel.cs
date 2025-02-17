namespace DruggieLibrary
{
    public class DrugModel : IModel
    {
        public string Name { get; set; }
        public string DrugClass_name { get; set; }
        public string Manufacturer_name { get; set; }
        public string INN { get; set; }
        public string Instruction { get; set; }

        public DrugModel() { }
        public DrugModel(string name, string drugClass_name, string manufacturer_name, string inn, string instruction)
        {
            Name = name;
            DrugClass_name = drugClass_name;
            Manufacturer_name = manufacturer_name;
            INN = inn;
            Instruction = instruction;
        }
    }

}
