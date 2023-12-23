using cine.Data.Base;
using cine.Models;

namespace cine.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
