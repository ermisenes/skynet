namespace MusicShop.Models
{
    public class Album{
        public int ID{get;set;}
        public string Title { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}