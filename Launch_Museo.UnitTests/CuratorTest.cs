
namespace Launch_Museo.UnitTests
{
    public class CuratorTest
    {
        [Fact]
        public void CanShowArtitstWithMultiplePhotos()
        {
            Curator curator = new Curator();
            Photograph photograph = new Photograph(new Dictionary<string, string>
{
    { "id", "1" },
    { "name", "Rue Mouffetard, Paris (Boy with Bottles)" },
    { "artistId", "4" },
    { "year", "1954" }
});
            var photo1 = photograph;

            var photo2 = new Photograph(new Dictionary<string, string>
            {
                { "id", "2" },
                { "name", "Moonrise, Hernandez" },
                { "artistId", "2" },
                { "year", "1941" }
            });
            var photo3 = new Photograph(new Dictionary<string, string>
            {
                { "id", "3" },
                { "name", "Womp Womp" },
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
            curator.AddPhotograph(photo3);
            curator.AddArtist(artist1);
            curator.AddArtist(artist2);
            Assert.Equal(artist2.Name, curator.ArtistsWithMultiple()[0]);


        }
    }
}
