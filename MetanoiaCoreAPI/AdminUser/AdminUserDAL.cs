using MetanoiaCoreAPI.Infra;
namespace MetanoiaCoreAPI.AdminUser
{

    public class AdminUserDAL
    {
        private readonly _context;
        public AdminUserDAL(AppDbContext dbContext)
        {
            _context = dbContext
        }

        
    }

}