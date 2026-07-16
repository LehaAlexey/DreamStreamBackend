using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Background
    {
        public Guid Id { get; set; }
        public required string DescriptionPrompt { get; set; }
    }
}
