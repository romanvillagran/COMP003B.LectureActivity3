using Microsoft.AspNetCore.Mvc;
namespace COMP003B.LectureActivity3.Controllers
{
    [Route("store")]

    public class StoreController : Controller
    {
        [Route("product/{id:int}")]

        public IActionResult ViewProduct(int id)
        {
            return View(id);
        }
        
        
        [HttpGet("Product/search")]

        public IActionResult Search([FromQuery] string category)
        {
            //the view() method returns a view result that renders a view to the response
            //the category parameter is passed to the view
            //the category parameter is retrieved from the query string
            //the [fromquery] attridute specifies that the peremter should be bound using the query string
            return View("search", category);
        }
    }
}
