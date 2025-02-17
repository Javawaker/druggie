using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruggieLibrary
{
    public class ActiveIngredientModel: IModel
    {
        public string Name { get; set; }

        public ActiveIngredientModel()
        {

        }
        public ActiveIngredientModel(string name)
        {
            Name = name;
        }
    }
}
