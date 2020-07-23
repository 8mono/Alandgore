using System;
using System.Collections.Generic;


namespace Alandgore
{ 
    class Program
    {
        
        static void Main(string[] args)
        {
            Cycle.SetGameState(1);
            Config MyConfig = Config.OutputCurrentConfig();
            Universe theUniverse = Universe.GenerateUniverse(MyConfig.nodeSize,MyConfig.difficulty);
            Company player = Company.GenerateCompany();
            
            while (Cycle.GameState == 1)
            {
                UI.ProtoUI.GenerateUI(player);
                
                Cycle.EndPhase();
            }


        }

    }
}
