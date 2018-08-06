using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingTest.Classes
{
    class MinecraftSkins
    {
        public string Description { get; set; }
        public string URL { get; set; }
        public string Image { get; set; }

        public MinecraftSkins(string description, string url, string image)
        {
            Description = description;
            URL = url;
            Image = image;
        }
    }
}
