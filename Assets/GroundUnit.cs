using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class GroundUnit : Entity
    {
        public string name { get; set; }

        public int job { get; set; }


        public Dictionary<string,float> Skillset { get; set; }

        public List<Entity> Inventory{ get; set; }

    }
}
