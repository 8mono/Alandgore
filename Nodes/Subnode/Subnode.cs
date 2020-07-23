using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Subnode
    {
        public string name { get; set; }
        public int size { get; set; }

        public Dictionary<int, POI> PointsOfInterest;
        // each subnode contains units, buildings, assets, etc

        public static void GenerateSubNodes(int size)
        {
            Node.Subnodes = new Dictionary<int, Subnode>();
            for (int i = 0; i < size; i++)
            {
                int rngName = Universe.ReturnRng(8) + 1;

                string chosenName = Node.names[rngName];

                Subnode newSubNode = new Subnode();
                newSubNode.name = chosenName;
                string sectorNumberString = Universe.ReturnRng(10).ToString();

                string sectorName = "Inner " + newSubNode.name + " " + sectorNumberString;

                POI.GeneratePOI(size - 1);

                Node.Subnodes.Add(i + 1, newSubNode);

            }
        }

        

    }
}
