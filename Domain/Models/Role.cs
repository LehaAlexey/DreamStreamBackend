using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    internal class Role
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
