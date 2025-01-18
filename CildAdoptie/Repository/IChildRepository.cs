using CildAdoptie.Models;

namespace CildAdoptie.Repository
{
    public interface IChildRepository
    {
        public Child SpecificChild(Guid id);

        public List<Child> AllChild();
        public void Add(AdoptionRequest request);
    }
}
