using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launch_Museo
{
    public class Curator
    {
        public List<Photograph> Photographs;
        public List<Artist> Artists;

        public Curator()
        {
            Photographs = new List<Photograph>();
            Artists = new List<Artist>();
        }

        public void AddPhotograph(Photograph photograph)
        {
            Photographs.Add(photograph);
        }
        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
        }
        public Artist FindArtistById(string id)
        {
            Artist foundArtis = null;
            foreach (var artist in Artists)
            {
                if (artist.Id == Convert.ToInt32(id))
                {
                    foundArtis = artist;
                    return foundArtis;
                }

            }
            return foundArtis;
        }
        public Dictionary<Artist, Photograph> AllArtistsAndPhotos()
        {
            var all = new Dictionary<Artist, Photograph>();
            foreach (var photo in Photographs)
            {
                var artist = FindArtistById(Convert.ToString(photo.ArtistId));
                if (artist != null)
                {
                    all.Add(artist, photo);
                }
            }
            return all;
        }

        public List<string> ArtistsWithMultiple()
        {
            var artists = new List<string>();
            foreach (var artist in Artists)
            {
                var photostaken = 0;
                foreach (var photo in Photographs)
                {
                    if (artist.Id == Convert.ToInt32(photo.ArtistId))
                    {
                        photostaken++;
                    }
                }
                if (photostaken > 1)
                {
                    artists.Add(artist.Name);
                }
            }
            return artists;
        }
    }
}

