using System;
using System.Collections.Generic;
using System.Text;

namespace Alandgore
{
    class Config
    {
        public int nodeSize = 4;

        public float difficulty = 1.0f;

        public static Config OutputCurrentConfig()
        {
            Config currentConfig = new Config();
            return currentConfig;
        }
    }

    
}
