using System;
using Microsoft.AspNetCore.Mvc;
using Lab11.Models;

namespace Lab11.Controllers
{
    public class ManageController : Controller
    {


        /********************************
        * TODO - HOMEWORK
        * *******************************/

        [HttpGet]
        public ViewResult Index()
        {
            var vm = new ManageViewModel();
            LoadDropDownData(vm);
            return View(vm);
        }

        [HttpPost]
        public RedirectToActionResult Add(ManageViewModel vm)
        {

            /********************************
            * TODO - HOMEWORK
            * *******************************/

            return RedirectToAction("Confirm");
        }

        [HttpPost]
        public IActionResult Delete(ManageViewModel vm)
        {

            /********************************
            * TODO - HOMEWORK
            * *******************************/

            return RedirectToAction("Confirm");
        }

        public ViewResult Confirm() => View();

        private void LoadDropDownData(ManageViewModel vm)
        {

            /********************************
            * TODO - HOMEWORK
            * *******************************/

        }
    }
}