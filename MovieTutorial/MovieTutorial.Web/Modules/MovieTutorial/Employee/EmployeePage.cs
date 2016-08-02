

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Employee", typeof(MovieTutorial.Pages.EmployeeController))]

namespace MovieTutorial.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Employee"), Route("{action=index}")]
    public class EmployeeController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieTutorial/Employee/EmployeeIndex.cshtml");
        }
    }
}