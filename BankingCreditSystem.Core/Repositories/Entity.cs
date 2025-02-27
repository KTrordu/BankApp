using System;

namespace BankingCreditSystem.Core.Repositories
{
    public class Entity<TId>
    {
        public TId Id { get; set; } = default!;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
} 