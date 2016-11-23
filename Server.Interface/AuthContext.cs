using Microsoft.AspNet.Identity.EntityFramework;

namespace Server.Interface
{
    public class AuthContext : IdentityDbContext<IdentityUser> 
    {
        public AuthContext() : base("AuthContext")
        {

        }
    }
}