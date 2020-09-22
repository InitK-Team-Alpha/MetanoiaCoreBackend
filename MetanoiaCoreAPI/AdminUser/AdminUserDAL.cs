using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MetanoiaCoreAPI.AppUser;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MetanoiaCoreAPI.AdminUser
{
    [ApiController]
    [Route("[]")]
    public class AdminUserDAL
    {
        private readonly AppDBContext _context;
        public AdminUserDAL(AppDBContext dbContext)
        {
            _context = dbContext;
        }

    }
}