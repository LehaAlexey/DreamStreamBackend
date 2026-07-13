using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    internal class Background
    {
        public Guid Id { get; set; }
        public required string DescriptionPrompt { get; set; }
    }
}
