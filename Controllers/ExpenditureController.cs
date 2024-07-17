using Microsoft.AspNetCore.Mvc;
using QueteRazor.Models;
using QueteRazor.Repository;

namespace QueteRazor.Controllers
{
    public class ExpenditureController : Controller
    {
        //Display list of Expenditures
        public IActionResult List()
        {
            List<Expenditure> expenditures = new List<Expenditure>();
            expenditures = ExpenditureRepository.GetExpenditures();
            return View(expenditures);
        }
    }
}
