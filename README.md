# Museo

### Setup

* Fork this Repository
* Clone YOUR fork
* Complete the activity below
* Commit and push your solution to your fork


## Iteration 1

Create a `Photograph` and an `Artist` class that respond to the following interaction pattern.

For `AgeAtDeath`, assume an artist was born and died on the same day.

```c#
var photoAttributes = new Dictionary<string, string>
{
    { "id", "1" },
    { "name", "Rue Mouffetard, Paris (Boy with Bottles)" },
    { "artistId", "4" },
    { "year", "1954" }
};

var photo = new Photograph(photoAttributes);

Console.WriteLine(photo.Id);
// Output => "1"

Console.WriteLine(photo.Name);
// Output => "Rue Mouffetard, Paris (Boy with Bottles)"

Console.WriteLine(photo.ArtistId);
// Output => "4"

Console.WriteLine(photo.Year);
// Output => "1954"

var artistAttributes = new Dictionary<string, string> 
{
    { "id", "2" },
    { "name",  "Ansel Adams" },
    { "born", "1902" },
    { "died", "1984" },
    { "country", "United States" }

};

var artist = new Artist(artistAttributes);

Console.WriteLine(artist.Id);
// Output => "2"

Console.WriteLine(artist.Name);
// Output => "Ansel Adams"

Console.WriteLine(artist.BirthYear);
// Output => "1902"

Console.WriteLine(artist.DeathYear);
// Output => "1984"

Console.WriteLine(artist.Country);
// Output => "United States"

Console.WriteLine(artist.AgeAtDeat());
// Output => 82
```

## Iteration 2

Create a 

```c#
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
    { "id", "1" },
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

Artist foundArtist = curator.FindArtistById("1");

Console.WriteLine(foundArtist.Name);
// Output => "Henri Cartier-Bresson"

```

## Iteration 3
Update your `Curator` class so that is supports the following functionality:

* A `Curator` can return a dictionary of all artists and their photographs.
* A `Curator` can return a list of names of artists who have more than one photograph
* A `Curator` can return a list of photographs that were taken by a photographer from a given country.
