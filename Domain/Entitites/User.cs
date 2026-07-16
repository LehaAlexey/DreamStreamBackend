using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Login { get; set; }

        #region authentication
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        #endregion

        public DateTime CreatedAt { get; set; }
        public List<Role> Roles { get; set; } = new List<Role>();
        public List<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
    }
}
