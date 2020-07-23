using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Resource : IAssets
    {
        public float value { get; set; }
        public float weight { get; set; }
        public string name { get; set; }
        public float rarity { get; set; }

        public int amount { get; set; }

        public static Dictionary<int, Resource> Resources = new Dictionary<int, Resource>();

        public static List<string> ResourceNames = new List<string>();

        public static void GenerateNames()
        {
            ResourceNames.Add("Iron");
            ResourceNames.Add("Crystals");
            ResourceNames.Add("Alloys");
            ResourceNames.Add("Credits");

        }

        public static void GenerateAssets(int amount)
        {
            GenerateNames();
            Resource emptyResource = new Resource();

            emptyResource.name = "Empty";
            emptyResource.rarity = 0;
            emptyResource.value = 0;
            emptyResource.weight = 0;

            Resources.Add(0, emptyResource);

            for (int i = 0; i < amount; i++)
            {
                Resource newResource = new Resource();

                newResource.name = ResourceNames[i];
                newResource.rarity = 1;
                newResource.value = 10;
                newResource.weight = 10;

                Resources.Add(i+1 , newResource);
            }


        }

       

    }
}
