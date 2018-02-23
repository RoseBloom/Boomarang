using System;
using System.Collections.Generic;
using System.Text;

namespace Schema
{
    public class Character
    {
        public string ID { get; set; }
        public string DisplayName { get; set; } // the name used to identify the character on most screens 
        public CharacterName Name { get; set; }
        public List<string> Stories; // what stories this character is in 
        List<String> Bullets { get; set; } // some bullet points we may want to display 
    }
}
