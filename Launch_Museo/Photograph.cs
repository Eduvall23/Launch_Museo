using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launch_Museo
{
    public class Photograph
    {
        public int Id;
        public string Name;
        public int ArtistId;
        public int Year;

        public Photograph(Dictionary<string, string> data)
        {
            Id = Convert.ToInt32(data["id"]);
            Name = data["name"];
            ArtistId = Convert.ToInt32(data["artistId"]);
            Year = Convert.ToInt32(data["year"]);
        }


    }
}
