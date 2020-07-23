using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Cycle
    {
        public static int GameState;
        
        public static int tDays = 0;

        public static void SetGameState(int state)
        {
            GameState = state;
 
        }

        public void InitializeUniverse()
        {
            // generation of universe
        }
        
        public void ManteinancePhase()
        {
            // manteinance costs get deducted from credits/resources
            //asset list is iterated and manteinance cost property is added here then substracted to our credits/income
        }

        public void GatheringPhase()
        {
            // gathers based on assets/mines etc
            //asset list is iterated and gathering property + gathering bonuses are calculated and added to our total resource inventory
            
        }

        public void ResearchPhase()
        {
            //advances research points based on researchers/assets
        }

        public static void EndPhase()
        {
            //advance one day
            tDays++;
           
        }
    }
}
// Every  cycle Resource gathering takes place
// Manteinance takes place
// Commerce takes place

// AI motivated to win state