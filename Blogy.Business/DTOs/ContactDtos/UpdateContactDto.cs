using Blogy.Business.DTOs.Common;

namespace Blogy.Business.DTOs.ContactDto
{
    public class UpdateContactDto:BaseDto
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        
    }
}
