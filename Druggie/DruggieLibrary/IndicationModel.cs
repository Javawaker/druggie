namespace DruggieLibrary
{
    public class IndicationModel : IModel
    {
        public string Name { get; set; }

        public IndicationModel()
        {

        }
        public IndicationModel(string name)
        {
            Name = name;
        }
    }
}
