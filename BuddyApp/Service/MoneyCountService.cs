using BuddyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuddyApp.Service
{
    class MoneyCountService
    {
        public int Sum { get; set; }

        List<Buddy> Buddies { get;}

        public MoneyCountService(List<Buddy> buddies)
        {
            Buddies = buddies;
        }
    }
}
