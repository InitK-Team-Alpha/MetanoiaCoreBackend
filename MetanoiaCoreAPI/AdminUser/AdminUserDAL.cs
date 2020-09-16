using MetanoiaCoreAPI.Infa;

namespace MetanoiaCoreAPI.AdminUser
{

    public class AdminUserDAL
    {
        private readonly _context;
        public AdminUserDAL(AppDbContext dbContext)
        {
            _context = dbContext
        }

        public async CreateAdminUser(string username, string password)
        {   
            
        }


    }

}