using FoundYou.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundYou.Core.Models
{
    public class Player
    {
        public string Name { get; set; }
        public PlayerColour Colour { get; set; }
        public bool Dead { get; set; }
        public bool Imposter { get; set; }
    }
}
