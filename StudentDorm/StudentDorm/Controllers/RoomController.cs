using StudentDorm.Models;
using System.Linq;
using System.Web.Mvc;

namespace StudentDorm.Controllers
{
    public class RoomController : Controller
    {
        private StudentDormContext db = new StudentDormContext();

        // GET: Booking
        public ActionResult Index()
        {
            return View(db.Room.ToList());
        }

    }
}
