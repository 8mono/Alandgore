using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class POI
    {
        public string name { get; set; }
        public float dangerLvl { get; set; }
        public int size { get; set; }

        public static List<Entity> Contents;

        public static void GeneratePOI(int amount)
        {
            Dictionary<int, POI> PointsOfInterest = new Dictionary<int, POI>();
            Contents = new List<Entity>();

            for (int i = 0; i < amount; i++)
            {

                int rngName = Universe.ReturnRng(8) + 1;

                string chosenName = Node.names[rngName];

                POI newPOI = new POI();

                string sectorNumberString = Universe.ReturnRng(10).ToString();

                string sectorName = chosenName + " Inner Proxima " + sectorNumberString;
                newPOI.name = sectorName;
                
                GenerateContents(amount - 2);

                PointsOfInterest.Add(i + 1, newPOI);
            }

        }
        public static void GenerateContents(int amount)
        {
            List<IAssets>Contents = new List<IAssets>();

            for (int i = 0; i < amount; i++)
            {

                int rng = Universe.ReturnRng(100);

                if(rng >= 50)
                {
                    rng = Universe.ReturnRng(4);
                    Contents.Add(Resource.Resources[rng]);
                }

                Contents.Add(Resource.Resources[0]);
               
               
                
            }
        }
    }
}
