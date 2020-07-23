using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Unit : Entity
    {
        public string name { get; set; }

        public int type { get; set; }

        public float HP { get; set; }

        public float armor { get; set; }

        public float evasion { get; set; }

        public float atk { get; set; }

        public float accuracy { get; set; }

        public List<Entity> Loot { get; set; }

    }
}
