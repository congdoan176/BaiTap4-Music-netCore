using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusicV01.Models
{
    public class SongCategory
    {
        public string SongId { get; set; }
        public Song Song { get; set; }
        public String CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
