using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Node
    {
        public string name { get; set; }
        public int size { get; set; } = 6;

        // size affects how many subnodes per node

        public float riskLvl { get; set; }

        // List of pockets per node 

        public List<Resource> Resources = new List<Resource>();

        public static Dictionary<int, Subnode> Subnodes;

        public static Dictionary<int, string> names = new Dictionary<int, string>();

        //consider either making a Names class or moving elsewehre
        public static void GenerateNames()
        {
            names.Add(1, "Alpha");
            names.Add(2, "Beta");
            names.Add(3, "Gamma");
            names.Add(4, "Epsilon");
            names.Add(5, "Theta");
            names.Add(6, "Phi");
            names.Add(7, "Omega");
            names.Add(8, "Mu");
            names.Add(9, "Tau");

        }


        public static void GenerateNodes(int size)
        {
            GenerateNames();
            Resource.GenerateAssets(size);

            Dictionary<int, Node> Nodes = new Dictionary<int, Node>();

            for (int i = 0; i < size; i++)
            {
                int rngName = Universe.ReturnRng(8) + 1;

                string chosenName = Node.names[rngName];

                Node newNode = new Node();

                string sectorNumberString = Universe.ReturnRng(10).ToString();

                string sectorName = chosenName + " " + sectorNumberString;
                //Console.WriteLine(sectorName);
                newNode.name = sectorName;
                Subnode.GenerateSubNodes(size - 1);

                Nodes.Add(i + 1, newNode);

            }



        }

        


    }
}
