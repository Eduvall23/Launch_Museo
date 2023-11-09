using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launch_Museo;
   
var curator = new Curator();

foreach (Photograph photo in curator.Photographs)
{
    Console.WriteLine(photo.Name);
}
// Output =>

foreach (Artist artist in curator.Artists)
{
    Console.WriteLine(artist.Name);
}
// Output =>

var photo1 = new Photograph(new Dictionary<string, string>
{
    { "id", "1" },
    { "name", "Rue Mouffetard, Paris (Boy with Bottles)" },
    { "artistId", "4" },
    { "year", "1954" }
});

var photo2 = new Photograph(new Dictionary<string, string>
{
    { "id", "2" },
    { "name", "Moonrise, Hernandez" },
    { "artistId", "2" },
    { "year", "1941" }
});

var artist1 = new Artist(new Dictionary<string, string>
{
    { "id", "4" },
    { "name",  "Henri Cartier-Bresson" },
    { "born", "1908" },
    { "died", "2004" },
    { "country", "France" }

});

var artist2 = new Artist(new Dictionary<string, string>
{
    { "id", "2" },
    { "name",  "Ansel Adams" },
    { "born", "1902" },
    { "died", "1984" },
    { "country", "United States" }

});

curator.AddPhotograph(photo1);
curator.AddPhotograph(photo2);
curator.AddArtist(artist1);
curator.AddArtist(artist2);

foreach (var photo in curator.Photographs)
{
    Console.WriteLine(photo.Name);
}
// Output => "Rue Mouffetard, Paris (Boy with Bottles)
//            Moonrise, Hernandez"

foreach (var artist in curator.Artists)
{
    Console.WriteLine(artist.Name);
}
// Output => "Henri Cartier-Bresson
//            Ansel Adams"

Artist foundArtist = curator.FindArtistById("4");

Console.WriteLine(foundArtist.Name);
// Output => "Henri Cartier-Bresson"
var womp = curator.AllArtistsAndPhotos();
foreach(var artist in womp)
{
    Console.WriteLine($"Key: {artist.Key.Name}, Value: {artist.Value.Name}");
}

