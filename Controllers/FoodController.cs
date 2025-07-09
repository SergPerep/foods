using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace foods.Controllers
{
    [ApiController]
    [Route("/")]
    public class FoodController : ControllerBase
    {
        // GET: FoodController
        public ActionResult GetFoods()
        {
            return View();
        }

        //// GET: FoodController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: FoodController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: FoodController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FoodController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: FoodController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FoodController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: FoodController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
