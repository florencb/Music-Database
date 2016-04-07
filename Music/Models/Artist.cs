using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class Artist
    {

        public int ArtistID { get; set; }
        [Required(ErrorMessage= "name required")]
        public string Name { get; set; }
    }
}