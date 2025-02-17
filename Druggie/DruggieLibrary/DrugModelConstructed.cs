using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruggieLibrary
{
    public class DrugModelConstructed: IModel
    {
        public string Name { get; set; }
        public string Manufacturer_name { get; set; }
        public string Manufacturer_country { get; set; }
        public string Inn { get; set; }
        public int Quantity { get; set; }
    }
}
