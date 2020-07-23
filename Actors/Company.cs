using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Company
    { 
        public float credBonus = 1;
        public float timeUnitBonus = 1;
        public float techBonus = 1;
        public float resourceBonus = 1;

        public Dictionary<int, IAssets> infrastructure;
        public void InitializeAssets()
        {
            infrastructure = new Dictionary<int, IAssets>();
            //assets.Add("Asset Slot #1", 0);
            //assets.Add("Asset Slot #2", 0);
            //assets.Add("Asset Slot #3", 0);
            //assets.Add("Asset Slot #4", 0);
        }
        public Dictionary<string, int> techTree;
        public void InitializeTechTree()
        {
            techTree= new Dictionary<string, int>();
            techTree.Add("Tech 1", 1);
            techTree.Add("Tech 2", 1);
            techTree.Add("Tech 3", 1);
            techTree.Add("Tech 4", 1);
        }

        public Dictionary<int, Resource> ResourceInventory;

        public void InitializeInventory()
        {
            InitializeResourceInventory();
        }

        public void InitializeResourceInventory()
        {
            ResourceInventory = new Dictionary<int,Resource>();
            ResourceInventory.Add(0, Resource.Resources[1]);
            ResourceInventory.Add(1, Resource.Resources[2]);
            ResourceInventory.Add(2, Resource.Resources[3]);
            ResourceInventory.Add(3, Resource.Resources[4]);

            InitializeCredits();
           
        }

        public void InitializeCredits()
        {
            ResourceInventory[3].amount = 1000;
        }

        public static Company GenerateCompany()
        {
            Company newCompany = new Company();
            newCompany.InitializeInventory();
            newCompany.InitializeAssets();
            newCompany.InitializeTechTree();
            
            return newCompany;
        }

        public int getTimeUnits()
        {
            int currentTimeUnits = timeUnits; 
            return currentTimeUnits; 
        }

        //public float credits = 
        public int timeUnits = 1;
        
    }

}
