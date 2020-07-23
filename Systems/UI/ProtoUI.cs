using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore.UI
{
    class ProtoUI
    {

        public static void GenerateUI(Company player)
        {
            foreach (var resource in player.ResourceInventory)
            {
                Console.WriteLine(resource.Value.name + ": " + resource.Value.amount);

            }

            Console.WriteLine("Time Units: " + player.getTimeUnits());

            Console.WriteLine(Cycle.tDays + " days elapsed");
            
        }
    }
}
