using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusicV01.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public CategoryStatus Status { get; set; }
        public List<SongCategory> SongCategories { get; set; }
        public Category()
        {
            this.CreatedAt = DateTime.Now;
            this.CreatedAt = DateTime.Now;
            this.Status = CategoryStatus.Activated;
        }
    }
    public enum CategoryStatus
    {
        Activated = 1,
        DecActivated = 2,
    }
}
