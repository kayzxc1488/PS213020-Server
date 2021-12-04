using Microsoft.EntityFrameworkCore;
using PS223020_server.DataAcess.Core.Interfaces.DbContext;
using PS223020_server.DataAcess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS223020_server.DataAcess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options)
                 : base(options)
        {
        }
        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }
    }
}
