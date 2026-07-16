using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Music
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public required string Title { get; set; }
        public required string DescriptionPrompt { get; set; }
        public Artist Author { get; set; }
    }
}
