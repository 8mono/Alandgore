using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Structure : IAssets
    {
        public string name { get; set; }
        public float HP { get; set; }
        public float price { get; set; }
        public struct manteinance {};  //ideally two properties, one being the resource, the other being the amount needed

        public static Dictionary<int, Structure> Structures = new Dictionary<int, Structure>();

        public static List<string> StructureNames = new List<string>();

        public void GenerateNames()
        {
            StructureNames.Add("Ore Mine");
            StructureNames.Add("Crystal Mine");
            StructureNames.Add("Alloy Mine");

        }

        public void GenerateAssets(int amount)
        {

        }

    }
}
