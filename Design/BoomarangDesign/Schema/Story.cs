using System;
using System.Collections.Generic;
using System.Text;

namespace Schema
{
    public class Story
    { 
        public string Id { get; set; }
        public Universe Universe { get; set; } // the world in which the story exists we could have many stories in the same world
        public Author Creator { get; set; } // who created the story 
        public DateTime Craeted { get; set; } // when the story is created
        public List<Scene> Scenes { get; set; } // collection of writings with the story 
    }
}
