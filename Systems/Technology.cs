using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Technology : IAssets
    {
        public string name { get; set; }
        public float rarity { get; set; }

        public static Dictionary<int, Technology> Technologies = new Dictionary<int, Technology>();

        public static List<string> TechnologyNames = new List<string>();

        public void GenerateNames()
        {
            TechnologyNames.Add("Ore Harvesting");
            TechnologyNames.Add("Crystal Harvesting");
            TechnologyNames.Add("Alloy Harvesting");

        }

        public void GenerateAssets(int amount)
        {
            GenerateNames();
            Technology emptyTechnology = new Technology();

            emptyTechnology.name = "Empty";
            emptyTechnology.rarity = 0;
           
            

            Technologies.Add(0, emptyTechnology);

            for (int i = 0; i < amount; i++)
            {
                Technology newTechnology = new Technology();

                newTechnology.name = TechnologyNames[i];
                newTechnology.rarity = 1;

                Technologies.Add(i + 1, newTechnology);
            }


        }
    }
}
