using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    internal class Artist
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public required string Name { get; set; }
        public List<Music> Musics { get; set; } = new List<Music>();
    }
}
