using cine.Data.Base;
using cine.Models;
using Microsoft.EntityFrameworkCore;

namespace cine.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context) { }
        
    }
}
