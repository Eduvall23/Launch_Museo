namespace Launch_Museo.UnitTests
{
    public class PhotograghTest
    {
        [Fact]
        public void CanCreatePhotograph()
        {
            var photoAttributes = new Dictionary<string, string>
            {
             { "id", "1" },
            { "name", "Rue Mouffetard, Paris (Boy with Bottles)" },
            { "artistId", "4" },
            { "year", "1954" }
             };
            var photo = new Photograph(photoAttributes);
            Assert.Equal(1, photo.Id);
            Assert.Equal("Rue Mouffetard, Paris (Boy with Bottles)", photo.Name);
            Assert.Equal(4, photo.ArtistId);
            Assert.Equal(1954, photo.Year);
        }
    }
}