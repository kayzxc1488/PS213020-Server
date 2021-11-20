using PS213020_Serve.DataAccess.Core.Models;
using System;

namespace PS213020_Serve.DataAccess.Core.Interfaces.DbContext
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
    }
}
