using CildAdoptie.Models;
using CildAdoptie.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CildAdoptie.Components
{
    public class NumberViewComponent: ViewComponent
    {
        public readonly IChildRepository _childRepository;

        public NumberViewComponent(IChildRepository childRepository)
        {
            _childRepository = childRepository;
        }

        public IViewComponentResult Invoke()
        {
            Console.WriteLine("in invoke");
            var count = _childRepository.AllChild().Count();
            var model = new NumberViewModel();
            model.Number = count;
            return View(model);
        }
    }
}
