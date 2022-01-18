using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21.Models
{
    public class Pirate
    {
        public int Id { get; set; } //Måste heta Id för att databasen ska förstå att det är ett Id
        public string Name { get; set; }
        public int Level { get; set; }

    }
}
