
using Vezeeta.Data.Commons;

namespace Vezeeta.Data.Entities
{
    public class BaseEntity : LocalizableEntity
    {
        [Key]
        public int ID { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
