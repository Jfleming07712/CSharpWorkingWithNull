using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }

        public int? DaysSinceLastLogin { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? IsNoob { get; set; }

        public PlayerCharacter()
        {
            //DateOfBirth = DateTime.MinValue; // magic number
            //DaysSinceLastLogin = -1;          // magi number
            //DateOfBirth = null; 
            //DaysSinceLastLogin = null;          
        }
    }
}
