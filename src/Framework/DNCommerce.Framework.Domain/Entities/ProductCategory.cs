using System;

namespace DNCommerce.Domain.Entities
{
    public class ProductCategory : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public Guid ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}