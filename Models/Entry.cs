using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenSoup
{
    public class Entry
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; }

        // New properties for the visual entries
        public string ImagePath { get; set; } = "";  
        public string ImageCaption { get; set; } = "";  

        public Entry()
        {

        }
    } 
}