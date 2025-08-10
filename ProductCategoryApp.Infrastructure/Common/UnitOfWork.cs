using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCategoryApp.Infrastructure.Data;
using ProductCategoryApp.Application.Common;

namespace ProductCategoryApp.Infrastructure.Common
{
    public class UnitOfWork : IUnitOfWork // This class implements the IUnitOfWork interface
    {
        private readonly ApplicationDbContext _context; // This is the database context
        // private readonly ILogger<UnitOfWork> _logger; // Optional: for logging purposes

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}