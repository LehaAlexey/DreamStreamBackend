using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    internal class ChatMessage
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required string MessageText { get; set; }
        public DateTime CreateDate { get; set; }
        public User User { get; set; }
    }
}
