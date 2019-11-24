using System;
using System.Collections.Generic;
using System.Text;

namespace BuddyApp.Models
{
    class Buddy
    {
        public string Name { get; set; }
        public int Spent { get; set; }
        public int Change { get; set; }

        public Buddy(string name)
        {
            Name = name;
        }
    }
}
