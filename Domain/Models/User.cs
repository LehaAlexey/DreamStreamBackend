using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    internal class User
    {
        public Guid Id { get; set; }
        public required string Login { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Role> Roles { get; set; } = new List<Role>();
        public List<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
    }
}
