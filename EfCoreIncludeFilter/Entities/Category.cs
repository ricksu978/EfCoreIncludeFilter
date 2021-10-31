using System.Collections.Generic;

namespace EfCoreIncludeFilter.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public ICollection<Record> Records { get; set; }
    }
}
