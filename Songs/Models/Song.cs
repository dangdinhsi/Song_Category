using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Songs.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Singer { get; set; }
        public string Author { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public List<SongCategory> SongCategoris { get; set; }
    }
}
