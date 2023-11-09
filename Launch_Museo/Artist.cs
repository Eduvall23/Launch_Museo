using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launch_Museo
{
    public class Artist
    {
        public int Id;
        public string Name;
        public int BirthYear;
        public int DeathYear;
        public string Country;

        public Artist(Dictionary<string, string> data)
        {
            Id = Convert.ToInt32(data["id"]);
            Name = data["name"];
            BirthYear = Convert.ToInt32(data["born"]);
            DeathYear = Convert.ToInt32(data["died"]);
            Country = data["country"];
        }
        public string AgeAtDeat()
        {
            var deathMath = DeathYear - BirthYear;
           string ageAtDeath = $"{Name} was {deathMath} years old when they died";
            return ageAtDeath;
        }

    }
}
