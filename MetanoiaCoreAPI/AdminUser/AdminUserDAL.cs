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

        public async CreateAdminUser2(string username, string password)
        {   
            
        }


    }

}