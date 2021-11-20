using PS213020_Serve.DataAccess.Core.Interfaces.DbContext;
using PS213020_Serve.DataAccess.Core.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PS213020_Serve.DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options) 
            : base(options)
            { }
        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }
    }
}
