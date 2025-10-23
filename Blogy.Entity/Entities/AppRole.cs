using Microsoft.AspNetCore.Identity;

namespace Blogy.Entity.Entities
{
    public class AppRole:IdentityRole<int>
    {
        //sadece primary key değerini belirtmek için oluşturuldu.
    }
}
