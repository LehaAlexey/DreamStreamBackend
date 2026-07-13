using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    internal class StreamRecord
    {
        public Guid Id { get; set; }
        public Guid MusicId { get; set; }
        public Guid BackgroundId { get; set; }
        public Guid EffectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
