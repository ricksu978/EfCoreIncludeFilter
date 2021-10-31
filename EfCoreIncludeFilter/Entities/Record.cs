using System;

namespace EfCoreIncludeFilter.Entities
{
    public class Record
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        
        public DateTime LastUpdate { get; set; }

        public Category Category { get; set; }

    }
}
