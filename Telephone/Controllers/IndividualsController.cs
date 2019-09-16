using System.Linq;
using System.Web.Mvc;
using Telephone.Models;
using Telephone.ViewModels;

namespace Telephone.Controllers
{
    public class IndividualsController : Controller
    {
        private ApplicationDbContext _context;

        public IndividualsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Persons
        public ActionResult Index()
        {
            var persons = _context.Persons.ToList();
            return View(persons);
        }

        public ActionResult New()
        {
            var viewModel = new IndividualFormViewModel()
            {

            };
            return View("PersonForm");
            
        }

        public ActionResult Edit()
        {
            return PartialView("_PersonForm"); 
        }

        public ActionResult Save()
        {
            return RedirectToAction("Index", "Individuals");
        }
    }
}