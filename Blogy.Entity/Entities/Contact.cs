using Blogy.Entity.Entities.Common;

namespace Blogy.Entity.Entities
{
    public class Contact:BaseEntity
    {
      
        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

    }
}
