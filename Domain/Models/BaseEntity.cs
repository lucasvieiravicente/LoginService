using System;

namespace LoginService.Domain.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool FlagActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
