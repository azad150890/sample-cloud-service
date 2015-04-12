using System.Web.Mvc;
using OnCheckin.Business;

namespace OnCheckin.Website.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            _additionService = new AdditionService();
        }

        private IAdditionService _additionService;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Addition(int firstNumber, int secondNumber)
        {
            // Call our addition service and return a JSON result
            return Json(_additionService.AddTwoNumbersTogether(firstNumber, secondNumber));
        }
    }
}
