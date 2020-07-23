using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Universe
    {
        public int size { get; set; }
        public float difficulty { get; set; }
        public int age { get; set; }

        public Dictionary<int, Node> Nodes;    

        /*public void GenerateUniverse(Config configFile)
        {
            // generate universe based on a config file, not ready, use GenerateNodes instead
        }
        */

        public static  Universe GenerateUniverse(int size, float difficulty)
        {
            Universe newUniverse = new Universe();
            newUniverse.size = size;
            newUniverse.difficulty = difficulty;
            Node.GenerateNodes(size);
            return newUniverse;
        }

        public static int ReturnRng(int number)
        {
            Random rng = new Random();
            return rng.Next(number);
        }
       
            
}
}
