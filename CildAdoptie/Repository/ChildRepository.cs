using CildAdoptie.Context;
using CildAdoptie.Models;

namespace CildAdoptie.Repository
{
    public class ChildRepository : IChildRepository
    {
        public readonly AdoptionDbContext _context;

        public ChildRepository(AdoptionDbContext context)
        {
            _context = context;
        }

        public void Add(AdoptionRequest request)
        { 
                _context.AdoptionRequests.Add(request);
                _context.SaveChanges();
        }

        public List<Child> AllChild()
        {
            return _context.Children.ToList();
        }

        public Child SpecificChild(Guid id)
        {
            Child? child = _context.Children.FirstOrDefault(c => c.Id == id);
            return child;
        }
    }
}
