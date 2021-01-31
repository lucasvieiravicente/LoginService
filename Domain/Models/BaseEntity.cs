using System;

namespace LoginService.Domain.Models
{
    public class BaseEntity
    {
        #region [Constructors]
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            FlagActive = true;
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
        }

        public BaseEntity(Guid id, DateTime createdAt, DateTime modifiedAt)
        {
            Id = id;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
        #endregion

        #region [Columns]
        public Guid Id { get; set; }
        public bool FlagActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        #endregion
    }
}
